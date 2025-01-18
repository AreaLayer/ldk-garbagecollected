package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A PeerManager manages a set of peers, described by their [`SocketDescriptor`] and marshalls
 * socket events into messages which it passes on to its [`MessageHandler`].
 * 
 * Locks are taken internally, so you must never assume that reentrancy from a
 * [`SocketDescriptor`] call back into [`PeerManager`] methods will not deadlock.
 * 
 * Calls to [`read_event`] will decode relevant messages and pass them to the
 * [`ChannelMessageHandler`], likely doing message processing in-line. Thus, the primary form of
 * parallelism in Rust-Lightning is in calls to [`read_event`]. Note, however, that calls to any
 * [`PeerManager`] functions related to the same connection must occur only in serial, making new
 * calls only after previous ones have returned.
 * 
 * Rather than using a plain [`PeerManager`], it is preferable to use either a [`SimpleArcPeerManager`]
 * a [`SimpleRefPeerManager`], for conciseness. See their documentation for more details, but
 * essentially you should default to using a [`SimpleRefPeerManager`], and use a
 * [`SimpleArcPeerManager`] when you require a `PeerManager` with a static lifetime, such as when
 * you're using lightning-net-tokio.
 * 
 * [`read_event`]: PeerManager::read_event
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class PeerManager extends CommonBase {
	PeerManager(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.PeerManager_free(ptr); }
	}

	/**
	 * Constructs a new `PeerManager` with the given message handlers.
	 * 
	 * `ephemeral_random_data` is used to derive per-connection ephemeral keys and must be
	 * cryptographically secure random bytes.
	 * 
	 * `current_time` is used as an always-increasing counter that survives across restarts and is
	 * incremented irregularly internally. In general it is best to simply use the current UNIX
	 * timestamp, however if it is not available a persistent counter that increases once per
	 * minute should suffice.
	 */
	public static PeerManager of(ChannelMessageHandler message_handler_chan_handler_arg, RoutingMessageHandler message_handler_route_handler_arg, OnionMessageHandler message_handler_onion_message_handler_arg, CustomMessageHandler message_handler_custom_message_handler_arg, int current_time, byte[] ephemeral_random_data, org.ldk.structs.Logger logger, org.ldk.structs.NodeSigner node_signer) {
		long ret = bindings.PeerManager_new(bindings.MessageHandler_new(message_handler_chan_handler_arg.ptr, message_handler_route_handler_arg.ptr, message_handler_onion_message_handler_arg.ptr, message_handler_custom_message_handler_arg.ptr), current_time, InternalUtils.check_arr_len(ephemeral_random_data, 32), logger.ptr, node_signer.ptr);
		Reference.reachabilityFence(message_handler_chan_handler_arg);
		Reference.reachabilityFence(message_handler_route_handler_arg);
		Reference.reachabilityFence(message_handler_onion_message_handler_arg);
		Reference.reachabilityFence(message_handler_custom_message_handler_arg);
		Reference.reachabilityFence(current_time);
		Reference.reachabilityFence(ephemeral_random_data);
		Reference.reachabilityFence(logger);
		Reference.reachabilityFence(node_signer);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PeerManager ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PeerManager(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(message_handler_chan_handler_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(message_handler_route_handler_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(message_handler_onion_message_handler_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(message_handler_custom_message_handler_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(logger); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(node_signer); };
		return ret_hu_conv;
	}

	/**
	 * Returns a list of [`PeerDetails`] for connected peers that have completed the initial
	 * handshake.
	 */
	public PeerDetails[] list_peers() {
		long[] ret = bindings.PeerManager_list_peers(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_13_len = ret.length;
		PeerDetails[] ret_conv_13_arr = new PeerDetails[ret_conv_13_len];
		for (int n = 0; n < ret_conv_13_len; n++) {
			long ret_conv_13 = ret[n];
			org.ldk.structs.PeerDetails ret_conv_13_hu_conv = null; if (ret_conv_13 < 0 || ret_conv_13 > 4096) { ret_conv_13_hu_conv = new org.ldk.structs.PeerDetails(null, ret_conv_13); }
			if (ret_conv_13_hu_conv != null) { ret_conv_13_hu_conv.ptrs_to.add(this); };
			ret_conv_13_arr[n] = ret_conv_13_hu_conv;
		}
		return ret_conv_13_arr;
	}

	/**
	 * Returns the [`PeerDetails`] of a connected peer that has completed the initial handshake.
	 * 
	 * Will return `None` if the peer is unknown or it hasn't completed the initial handshake.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public PeerDetails peer_by_node_id(byte[] their_node_id) {
		long ret = bindings.PeerManager_peer_by_node_id(this.ptr, InternalUtils.check_arr_len(their_node_id, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(their_node_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PeerDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PeerDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Indicates a new outbound connection has been established to a node with the given `node_id`
	 * and an optional remote network address.
	 * 
	 * The remote network address adds the option to report a remote IP address back to a connecting
	 * peer using the init message.
	 * The user should pass the remote network address of the host they are connected to.
	 * 
	 * If an `Err` is returned here you must disconnect the connection immediately.
	 * 
	 * Returns a small number of bytes to send to the remote node (currently always 50).
	 * 
	 * Panics if descriptor is duplicative with some other descriptor which has not yet been
	 * [`socket_disconnected`].
	 * 
	 * [`socket_disconnected`]: PeerManager::socket_disconnected
	 */
	public Result_CVec_u8ZPeerHandleErrorZ new_outbound_connection(byte[] their_node_id, org.ldk.structs.SocketDescriptor descriptor, org.ldk.structs.Option_SocketAddressZ remote_network_address) {
		long ret = bindings.PeerManager_new_outbound_connection(this.ptr, InternalUtils.check_arr_len(their_node_id, 33), descriptor.ptr, remote_network_address.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(their_node_id);
		Reference.reachabilityFence(descriptor);
		Reference.reachabilityFence(remote_network_address);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_u8ZPeerHandleErrorZ ret_hu_conv = Result_CVec_u8ZPeerHandleErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(descriptor); };
		return ret_hu_conv;
	}

	/**
	 * Indicates a new inbound connection has been established to a node with an optional remote
	 * network address.
	 * 
	 * The remote network address adds the option to report a remote IP address back to a connecting
	 * peer using the init message.
	 * The user should pass the remote network address of the host they are connected to.
	 * 
	 * May refuse the connection by returning an Err, but will never write bytes to the remote end
	 * (outbound connector always speaks first). If an `Err` is returned here you must disconnect
	 * the connection immediately.
	 * 
	 * Panics if descriptor is duplicative with some other descriptor which has not yet been
	 * [`socket_disconnected`].
	 * 
	 * [`socket_disconnected`]: PeerManager::socket_disconnected
	 */
	public Result_NonePeerHandleErrorZ new_inbound_connection(org.ldk.structs.SocketDescriptor descriptor, org.ldk.structs.Option_SocketAddressZ remote_network_address) {
		long ret = bindings.PeerManager_new_inbound_connection(this.ptr, descriptor.ptr, remote_network_address.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(descriptor);
		Reference.reachabilityFence(remote_network_address);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePeerHandleErrorZ ret_hu_conv = Result_NonePeerHandleErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(descriptor); };
		return ret_hu_conv;
	}

	/**
	 * Indicates that there is room to write data to the given socket descriptor.
	 * 
	 * May return an Err to indicate that the connection should be closed.
	 * 
	 * May call [`send_data`] on the descriptor passed in (or an equal descriptor) before
	 * returning. Thus, be very careful with reentrancy issues! The invariants around calling
	 * [`write_buffer_space_avail`] in case a write did not fully complete must still hold - be
	 * ready to call [`write_buffer_space_avail`] again if a write call generated here isn't
	 * sufficient!
	 * 
	 * [`send_data`]: SocketDescriptor::send_data
	 * [`write_buffer_space_avail`]: PeerManager::write_buffer_space_avail
	 */
	public Result_NonePeerHandleErrorZ write_buffer_space_avail(org.ldk.structs.SocketDescriptor descriptor) {
		long ret = bindings.PeerManager_write_buffer_space_avail(this.ptr, descriptor.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(descriptor);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePeerHandleErrorZ ret_hu_conv = Result_NonePeerHandleErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Indicates that data was read from the given socket descriptor.
	 * 
	 * May return an Err to indicate that the connection should be closed.
	 * 
	 * Will *not* call back into [`send_data`] on any descriptors to avoid reentrancy complexity.
	 * Thus, however, you should call [`process_events`] after any `read_event` to generate
	 * [`send_data`] calls to handle responses.
	 * 
	 * If `Ok(true)` is returned, further read_events should not be triggered until a
	 * [`send_data`] call on this descriptor has `resume_read` set (preventing DoS issues in the
	 * send buffer).
	 * 
	 * In order to avoid processing too many messages at once per peer, `data` should be on the
	 * order of 4KiB.
	 * 
	 * [`send_data`]: SocketDescriptor::send_data
	 * [`process_events`]: PeerManager::process_events
	 */
	public Result_boolPeerHandleErrorZ read_event(org.ldk.structs.SocketDescriptor peer_descriptor, byte[] data) {
		long ret = bindings.PeerManager_read_event(this.ptr, peer_descriptor.ptr, data);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(peer_descriptor);
		Reference.reachabilityFence(data);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolPeerHandleErrorZ ret_hu_conv = Result_boolPeerHandleErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks for any events generated by our handlers and processes them. Includes sending most
	 * response messages as well as messages generated by calls to handler functions directly (eg
	 * functions like [`ChannelManager::process_pending_htlc_forwards`] or [`send_payment`]).
	 * 
	 * May call [`send_data`] on [`SocketDescriptor`]s. Thus, be very careful with reentrancy
	 * issues!
	 * 
	 * This should be called any time we may have messages to send. It is automatically called by
	 * [`lightning-net-tokio`] after processing incoming messages, and by
	 * [`lightning-background-processor`] when channel state has changed. Therefore, If you are not
	 * using both [`lightning-net-tokio`] and [`lightning-background-processor`], you may need to call
	 * this function manually to prevent messages from being delayed.
	 * 
	 * Note that if there are any other calls to this function waiting on lock(s) this may return
	 * without doing any work. All available events that need handling will be handled before the
	 * other calls return.
	 * 
	 * [`send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
	 * [`ChannelManager::process_pending_htlc_forwards`]: crate::ln::channelmanager::ChannelManager::process_pending_htlc_forwards
	 * [`send_data`]: SocketDescriptor::send_data
	 */
	public void process_events() {
		bindings.PeerManager_process_events(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Indicates that the given socket descriptor's connection is now closed.
	 */
	public void socket_disconnected(org.ldk.structs.SocketDescriptor descriptor) {
		bindings.PeerManager_socket_disconnected(this.ptr, descriptor.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(descriptor);
	}

	/**
	 * Disconnect a peer given its node id.
	 * 
	 * If a peer is connected, this will call [`disconnect_socket`] on the descriptor for the
	 * peer. Thus, be very careful about reentrancy issues.
	 * 
	 * [`disconnect_socket`]: SocketDescriptor::disconnect_socket
	 */
	public void disconnect_by_node_id(byte[] node_id) {
		bindings.PeerManager_disconnect_by_node_id(this.ptr, InternalUtils.check_arr_len(node_id, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(node_id);
	}

	/**
	 * Disconnects all currently-connected peers. This is useful on platforms where there may be
	 * an indication that TCP sockets have stalled even if we weren't around to time them out
	 * using regular ping/pongs.
	 */
	public void disconnect_all_peers() {
		bindings.PeerManager_disconnect_all_peers(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Send pings to each peer and disconnect those which did not respond to the last round of
	 * pings.
	 * 
	 * This may be called on any timescale you want, however, roughly once every ten seconds is
	 * preferred. The call rate determines both how often we send a ping to our peers and how much
	 * time they have to respond before we disconnect them.
	 * 
	 * May call [`send_data`] on all [`SocketDescriptor`]s. Thus, be very careful with reentrancy
	 * issues!
	 * 
	 * [`send_data`]: SocketDescriptor::send_data
	 */
	public void timer_tick_occurred() {
		bindings.PeerManager_timer_tick_occurred(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Generates a signed node_announcement from the given arguments, sending it to all connected
	 * peers. Note that peers will likely ignore this message unless we have at least one public
	 * channel which has at least six confirmations on-chain.
	 * 
	 * `rgb` is a node \"color\" and `alias` is a printable human-readable string to describe this
	 * node to humans. They carry no in-protocol meaning.
	 * 
	 * `addresses` represent the set (possibly empty) of socket addresses on which this node
	 * accepts incoming connections. These will be included in the node_announcement, publicly
	 * tying these addresses together and to this node. If you wish to preserve user privacy,
	 * addresses should likely contain only Tor Onion addresses.
	 * 
	 * Panics if `addresses` is absurdly large (more than 100).
	 * 
	 * [`get_and_clear_pending_msg_events`]: MessageSendEventsProvider::get_and_clear_pending_msg_events
	 */
	public void broadcast_node_announcement(byte[] rgb, byte[] alias, SocketAddress[] addresses) {
		bindings.PeerManager_broadcast_node_announcement(this.ptr, InternalUtils.check_arr_len(rgb, 3), InternalUtils.check_arr_len(alias, 32), addresses != null ? Arrays.stream(addresses).mapToLong(addresses_conv_15 -> addresses_conv_15.ptr).toArray() : null);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(rgb);
		Reference.reachabilityFence(alias);
		Reference.reachabilityFence(addresses);
	}

}
