package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Details of a connected peer as returned by [`PeerManager::list_peers`].
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class PeerDetails extends CommonBase {
	PeerDetails(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.PeerDetails_free(ptr); }
	}

	/**
	 * The node id of the peer.
	 * 
	 * For outbound connections, this [`PublicKey`] will be the same as the `their_node_id` parameter
	 * passed in to [`PeerManager::new_outbound_connection`].
	 */
	public byte[] get_counterparty_node_id() {
		byte[] ret = bindings.PeerDetails_get_counterparty_node_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The node id of the peer.
	 * 
	 * For outbound connections, this [`PublicKey`] will be the same as the `their_node_id` parameter
	 * passed in to [`PeerManager::new_outbound_connection`].
	 */
	public void set_counterparty_node_id(byte[] val) {
		bindings.PeerDetails_set_counterparty_node_id(this.ptr, InternalUtils.check_arr_len(val, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The socket address the peer provided in the initial handshake.
	 * 
	 * Will only be `Some` if an address had been previously provided to
	 * [`PeerManager::new_outbound_connection`] or [`PeerManager::new_inbound_connection`].
	 * 
	 * Returns a copy of the field.
	 */
	public Option_SocketAddressZ get_socket_address() {
		long ret = bindings.PeerDetails_get_socket_address(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_SocketAddressZ ret_hu_conv = org.ldk.structs.Option_SocketAddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The socket address the peer provided in the initial handshake.
	 * 
	 * Will only be `Some` if an address had been previously provided to
	 * [`PeerManager::new_outbound_connection`] or [`PeerManager::new_inbound_connection`].
	 */
	public void set_socket_address(org.ldk.structs.Option_SocketAddressZ val) {
		bindings.PeerDetails_set_socket_address(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The features the peer provided in the initial handshake.
	 */
	public InitFeatures get_init_features() {
		long ret = bindings.PeerDetails_get_init_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InitFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InitFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The features the peer provided in the initial handshake.
	 */
	public void set_init_features(org.ldk.structs.InitFeatures val) {
		bindings.PeerDetails_set_init_features(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Indicates the direction of the peer connection.
	 * 
	 * Will be `true` for inbound connections, and `false` for outbound connections.
	 */
	public boolean get_is_inbound_connection() {
		boolean ret = bindings.PeerDetails_get_is_inbound_connection(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates the direction of the peer connection.
	 * 
	 * Will be `true` for inbound connections, and `false` for outbound connections.
	 */
	public void set_is_inbound_connection(boolean val) {
		bindings.PeerDetails_set_is_inbound_connection(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new PeerDetails given each field
	 */
	public static PeerDetails of(byte[] counterparty_node_id_arg, org.ldk.structs.Option_SocketAddressZ socket_address_arg, org.ldk.structs.InitFeatures init_features_arg, boolean is_inbound_connection_arg) {
		long ret = bindings.PeerDetails_new(InternalUtils.check_arr_len(counterparty_node_id_arg, 33), socket_address_arg.ptr, init_features_arg.ptr, is_inbound_connection_arg);
		Reference.reachabilityFence(counterparty_node_id_arg);
		Reference.reachabilityFence(socket_address_arg);
		Reference.reachabilityFence(init_features_arg);
		Reference.reachabilityFence(is_inbound_connection_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PeerDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PeerDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
