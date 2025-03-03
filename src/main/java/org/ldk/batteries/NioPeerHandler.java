package org.ldk.batteries;

import org.ldk.impl.bindings;
import org.ldk.structs.*;

import java.io.IOException;
import java.lang.reflect.Field;
import java.lang.ref.Reference;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.net.*;
import java.util.LinkedList;
import java.nio.Buffer;
import java.nio.ByteBuffer;
import java.nio.channels.*;

/**
 * A NioPeerHandler maps LDK's PeerHandler to Java's NIO I/O interface. It spawns a single background thread which
 * processes socket events and provides the data to LDK for decryption and processing.
 */
public class NioPeerHandler {
    private static class Peer {
        SocketDescriptor descriptor;
        SelectionKey key;
    }

    // Android's java.nio implementation has a big lock inside the selector, preventing any concurrent access to it.
    // This appears to largely defeat the entire purpose of java.nio, but we work around it here by explicitly checking
    // for an Android environment and passing any selector access on any thread other than our internal one through
    // do_selector_action, which wakes up the selector before accessing it.
    private static boolean IS_ANDROID;
    static {
        IS_ANDROID = System.getProperty("java.vendor").toLowerCase().contains("android");
    }
    private boolean wakeup_selector = false;
    private interface SelectorCall {
        void meth() throws IOException;
    }
    private void do_selector_action(SelectorCall meth) throws IOException {
        if (IS_ANDROID) {
            wakeup_selector = true;
            this.selector.wakeup();
            synchronized (this.selector) {
                meth.meth();
                wakeup_selector = false;
            }
        } else {
            meth.meth();
        }
    }

    static private Method ResultBoolPeerHandleError_Free;
    static {
        try {
            Class c = Result_boolPeerHandleErrorZ.class;
            ResultBoolPeerHandleError_Free = c.getDeclaredMethod("force_free");
            ResultBoolPeerHandleError_Free.setAccessible(true);
        } catch (NoSuchMethodException e) {
            throw new IllegalArgumentException(
                    "We currently use reflection to access protected fields as Java has no reasonable access controls", e);
        }
    }

    private Peer setup_socket(SocketChannel chan) throws IOException {
        chan.configureBlocking(false);
        // Lightning tends to send a number of small messages back and forth between peers quickly, which Nagle is
        // particularly bad at handling, so we disable it here.
        chan.setOption(StandardSocketOptions.TCP_NODELAY, true);
        long our_id;
        synchronized (this) {
            this.socket_id = this.socket_id + 1;
            our_id = this.socket_id;
        }

        final Peer peer = new Peer();
        SocketDescriptor descriptor = SocketDescriptor.new_impl(new SocketDescriptor.SocketDescriptorInterface() {
            @Override
            public long send_data(byte[] data, boolean resume_read) {
                try {
                    long written = chan.write(ByteBuffer.wrap(data));
                    if (written != data.length) {
                        do_selector_action(() -> peer.key.interestOps(
							(peer.key.interestOps() | SelectionKey.OP_WRITE) & (~SelectionKey.OP_READ)));
                    } else if (resume_read) {
                        do_selector_action(() -> peer.key.interestOps(
							(peer.key.interestOps() | SelectionKey.OP_READ) & (~SelectionKey.OP_WRITE)));
					}
                    return written;
                } catch (IOException|CancelledKeyException ignored) {
                    // Most likely the socket is disconnected, let the background thread handle it.
                    return 0;
                }
            }

            @Override
            public void disconnect_socket() {
                try {
                    do_selector_action(() -> {
                        try { peer.key.cancel(); } catch (CancelledKeyException ignored) {}
                        peer.key.channel().close();
                    });
                } catch (IOException ignored) { }
            }
            @Override public boolean eq(SocketDescriptor other_arg) { return other_arg.hash() == our_id; }
            @Override public long hash() { return our_id; }
        });
        peer.descriptor = descriptor;
        return peer;
    }

    PeerManager peer_manager;
    Thread io_thread;
    final Selector selector;
    long socket_id;
    volatile boolean shutdown = false;

    private static Option_SocketAddressZ get_netaddr_from_sockaddr(java.net.SocketAddress sockaddr) {
        if (sockaddr instanceof InetSocketAddress) {
            InetAddress addr = ((InetSocketAddress) sockaddr).getAddress();
            short port = (short) ((InetSocketAddress) sockaddr).getPort();
            if (addr instanceof Inet4Address) {
                return Option_SocketAddressZ.some(org.ldk.structs.SocketAddress.tcp_ip_v4(addr.getAddress(), port));
            } else if (addr instanceof Inet6Address) {
                return Option_SocketAddressZ.some(org.ldk.structs.SocketAddress.tcp_ip_v6(addr.getAddress(), port));
            }
        }
        return Option_SocketAddressZ.none();
    }

    /**
     * Constructs a new peer handler, spawning a thread to monitor for socket events.
     *
     * @param manager The LDK PeerManager which connection data will be provided to.
     * @throws IOException If an internal java.nio error occurs.
     */
    public NioPeerHandler(PeerManager manager) throws IOException {
        this.peer_manager = manager;
        this.selector = Selector.open();
        io_thread = new Thread(() -> {
            int BUF_SZ = 16 * 1024;
            byte[] max_buf_byte_object = new byte[BUF_SZ];
            ByteBuffer buf = ByteBuffer.allocate(BUF_SZ);

            while (true) {
                try {
                    if (IS_ANDROID) {
                        while (true) {
                            synchronized (this.selector) {
                                if (!wakeup_selector) {
                                    this.selector.select(1000);
                                    break;
                                }
                            }
                        }
                    } else {
                        this.selector.select(1000);
                    }
                } catch (IOException ignored) {
                    System.err.println("java.nio threw an unexpected IOException. Stopping PeerHandler thread!");
                    return;
                }
                if (shutdown) return;
                if (Thread.interrupted()) return;
                for (SelectionKey key : this.selector.selectedKeys()) {
                    try {
                        if ((key.interestOps() & SelectionKey.OP_ACCEPT) != 0) {
                            if (key.isAcceptable()) {
                                SocketChannel chan;
                                try {
                                    chan = ((ServerSocketChannel) key.channel()).accept();
                                } catch (IOException ignored) {
                                    key.cancel();
                                    continue;
                                }
                                if (chan == null) continue;
                                try {
                                    Peer peer = setup_socket(chan);
                                    peer.key = chan.register(this.selector, SelectionKey.OP_READ, peer);
                                    Option_SocketAddressZ netaddr = get_netaddr_from_sockaddr(chan.getRemoteAddress());
                                    Result_NonePeerHandleErrorZ res = this.peer_manager.new_inbound_connection(peer.descriptor, netaddr);
                                    if (res instanceof Result_NonePeerHandleErrorZ.Result_NonePeerHandleErrorZ_Err) {
										peer.descriptor.disconnect_socket();
									}
                                } catch (IOException ignored) { }
                            }
                            continue; // There is no attachment so the rest of the loop is useless
                        }
                        Peer peer = (Peer) key.attachment();
                        try {
                            if (key.isValid() && (key.interestOps() & SelectionKey.OP_WRITE) != 0 && key.isWritable()) {
                                Result_NonePeerHandleErrorZ res = this.peer_manager.write_buffer_space_avail(peer.descriptor);
                                if (res instanceof Result_NonePeerHandleErrorZ.Result_NonePeerHandleErrorZ_Err) {
                                    key.cancel();
                                    key.channel().close();
                                }
                            }
                            if (key.isValid() && (key.interestOps() & SelectionKey.OP_READ) != 0 && key.isReadable()) {
                                ((Buffer)buf).clear();
                                int read = ((SocketChannel) key.channel()).read(buf);
                                if (read == -1) {
                                    this.peer_manager.socket_disconnected(peer.descriptor);
                                    key.cancel();
                                    key.channel().close(); // This may throw, we read -1 so the channel should already be closed, but do this to be safe
                                } else if (read > 0) {
                                    ((Buffer)buf).flip();
                                    byte[] read_bytes;
                                    if (read == BUF_SZ) {
                                        read_bytes = max_buf_byte_object;
                                    } else {
                                        read_bytes = new byte[read];
                                    }
                                    buf.get(read_bytes, 0, read);
                                    Result_boolPeerHandleErrorZ read_res = this.peer_manager.read_event(peer.descriptor, read_bytes);
                                    if (read_res instanceof Result_boolPeerHandleErrorZ.Result_boolPeerHandleErrorZ_OK) {
                                        if (((Result_boolPeerHandleErrorZ.Result_boolPeerHandleErrorZ_OK) read_res).res) {
                                            key.interestOps(key.interestOps() & (~SelectionKey.OP_READ));
                                        }
                                        // Force the read_res to drop its native memory early (before finalize()) as this is
                                        // pretty hot and we don't want to bloat native memory too long.
                                        // Note that we only do this in the Ok case as its more trivially safe, the Err
                                        // case has nested structs which will also free and may be confused if their pointer
                                        // is dropped out from under them.
                                        try { ResultBoolPeerHandleError_Free.invoke(read_res); } catch (Exception ignored) {}
                                    } else {
                                        key.cancel();
                                        key.channel().close();
                                    }
                                }
                            }
                        } catch (IOException ignored) {
                            key.cancel();
                            try { key.channel().close(); } catch (IOException ignored2) { }
                            peer_manager.socket_disconnected(peer.descriptor);
                        }
                    } catch (CancelledKeyException e) {
                        try { key.channel().close(); } catch (IOException ignored) { }
                        // The key is only cancelled when we have notified the PeerManager that the socket is closed, so
                        // no need to do anything here with the PeerManager.
                    }
                }
                peer_manager.process_events();
            }
        }, "NioPeerHandler NIO Thread");
        io_thread.start();
    }

    /**
     * Connect to a peer given their node id and socket address. Blocks until a connection is established (or returns
     * IOException) and then the connection handling runs in the background.
     *
     * @param their_node_id A valid 33-byte public key representing the peer's Lightning Node ID. If this is invalid,
     *                      undefined behavior (read: Segfault, etc) may occur.
     * @param remote The socket address to connect to.
     * @param timeout_ms The amount of time, in milliseconds, up to which we will wait for connection to complete.
     * @throws IOException If connecting to the remote endpoint fails or internal java.nio errors occur.
     */
    public void connect(byte[] their_node_id, java.net.SocketAddress remote, int timeout_ms) throws IOException {
        if (this.peer_manager.peer_by_node_id(their_node_id) != null) {
            // The peer is already connected, no need to try to reconnect.
            return;
        }
        SocketChannel chan = SocketChannel.open();
        boolean connected;
        try {
            chan.configureBlocking(false);
            Selector open_selector = Selector.open();
            chan.register(open_selector, SelectionKey.OP_CONNECT);
            if (!chan.connect(remote)) {
                open_selector.select(timeout_ms);
            }
            connected = chan.finishConnect();
        } catch (IOException e) {
            try { chan.close(); } catch (IOException _e) { }
            throw e;
        }
        if (!connected) {
            try { chan.close(); } catch (IOException _e) { }
            throw new IOException("Timed out");
        }
        Peer peer = setup_socket(chan);
        do_selector_action(() -> peer.key = chan.register(this.selector, SelectionKey.OP_READ, peer));
        Result_CVec_u8ZPeerHandleErrorZ res = this.peer_manager.new_outbound_connection(their_node_id, peer.descriptor, get_netaddr_from_sockaddr(remote));
        if (res instanceof  Result_CVec_u8ZPeerHandleErrorZ.Result_CVec_u8ZPeerHandleErrorZ_OK) {
            byte[] initial_bytes = ((Result_CVec_u8ZPeerHandleErrorZ.Result_CVec_u8ZPeerHandleErrorZ_OK) res).res;
            if (chan.write(ByteBuffer.wrap(initial_bytes)) != initial_bytes.length) {
                peer.descriptor.disconnect_socket();
                this.peer_manager.socket_disconnected(peer.descriptor);
                throw new IOException("We assume TCP socket buffer is at least a single packet in length");
            }
        } else {
            peer.descriptor.disconnect_socket();
            throw new IOException("LDK rejected outbound connection. This likely shouldn't ever happen.");
        }
    }

    /**
     * Disconnects any connections currently open with the peer with the given node id.
     *
     * @param their_node_id must be a valid 33-byte public key
     */
    public void disconnect(byte[] their_node_id) {
        this.peer_manager.disconnect_by_node_id(their_node_id);
    }

    /**
     * Before shutdown, we have to ensure all of our listening sockets are closed manually, as they appear
     * to otherwise remain open and lying around on OSX (though no other platform).
     */
    private LinkedList<ServerSocketChannel> listening_sockets = new LinkedList();
    /**
     * Binds a listening socket to the given address, accepting incoming connections and handling them on the background
     * thread.
     *
     * @param socket_address The address to bind the listening socket to.
     * @throws IOException if binding the listening socket fail.
     */
    public void bind_listener(java.net.SocketAddress socket_address) throws IOException {
        ServerSocketChannel listen_channel = ServerSocketChannel.open();
        listen_channel.setOption(StandardSocketOptions.SO_REUSEADDR, true);
        listen_channel.bind(socket_address);
        listen_channel.configureBlocking(false);
        do_selector_action(() -> listen_channel.register(this.selector, SelectionKey.OP_ACCEPT));
        synchronized(listening_sockets) {
            listening_sockets.add(listen_channel);
        }
    }

    /**
     * Interrupt the background thread, stopping all peer handling.
     *
     * After this method is called, the behavior of future calls to methods on this NioPeerHandler are undefined.
     */
    public void interrupt() {
        this.peer_manager.disconnect_all_peers();
        shutdown = true;
        selector.wakeup();
        try {
            io_thread.join();
        } catch (InterruptedException ignored) { }
        synchronized(listening_sockets) {
            try {
                selector.close();
                for (ServerSocketChannel chan : listening_sockets) {
                    chan.close();
                }
                listening_sockets.clear();
            } catch (IOException ignored) {}
        }
        Reference.reachabilityFence(this.peer_manager); // Almost certainly overkill, but no harm in it
    }

    /**
     * Calls process_events on the PeerManager immediately. Normally process_events is polled regularly to check for new
     * messages which need to be sent, but you can interrupt the poll and check immediately by calling this function.
     */
    public void check_events() {
        selector.wakeup();
    }
}
