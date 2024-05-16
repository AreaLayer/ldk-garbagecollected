using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Details of a connected peer as returned by [`PeerManager::list_peers`].
 */
public class PeerDetails : CommonBase {
	internal PeerDetails(object _dummy, long ptr) : base(ptr) { }
	~PeerDetails() {
		if (ptr != 0) { bindings.PeerDetails_free(ptr); }
	}

	/**
	 * The node id of the peer.
	 * 
	 * For outbound connections, this [`PublicKey`] will be the same as the `their_node_id` parameter
	 * passed in to [`PeerManager::new_outbound_connection`].
	 */
	public byte[] get_counterparty_node_id() {
		long ret = bindings.PeerDetails_get_counterparty_node_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The node id of the peer.
	 * 
	 * For outbound connections, this [`PublicKey`] will be the same as the `their_node_id` parameter
	 * passed in to [`PeerManager::new_outbound_connection`].
	 */
	public void set_counterparty_node_id(byte[] val) {
		bindings.PeerDetails_set_counterparty_node_id(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
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
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_SocketAddressZ ret_hu_conv = org.ldk.structs.Option_SocketAddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
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
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The features the peer provided in the initial handshake.
	 */
	public InitFeatures get_init_features() {
		long ret = bindings.PeerDetails_get_init_features(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InitFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InitFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The features the peer provided in the initial handshake.
	 */
	public void set_init_features(org.ldk.structs.InitFeatures val) {
		bindings.PeerDetails_set_init_features(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Indicates the direction of the peer connection.
	 * 
	 * Will be `true` for inbound connections, and `false` for outbound connections.
	 */
	public bool get_is_inbound_connection() {
		bool ret = bindings.PeerDetails_get_is_inbound_connection(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates the direction of the peer connection.
	 * 
	 * Will be `true` for inbound connections, and `false` for outbound connections.
	 */
	public void set_is_inbound_connection(bool val) {
		bindings.PeerDetails_set_is_inbound_connection(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PeerDetails given each field
	 */
	public static PeerDetails of(byte[] counterparty_node_id_arg, org.ldk.structs.Option_SocketAddressZ socket_address_arg, org.ldk.structs.InitFeatures init_features_arg, bool is_inbound_connection_arg) {
		long ret = bindings.PeerDetails_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id_arg, 33)), socket_address_arg.ptr, init_features_arg.ptr, is_inbound_connection_arg);
		GC.KeepAlive(counterparty_node_id_arg);
		GC.KeepAlive(socket_address_arg);
		GC.KeepAlive(init_features_arg);
		GC.KeepAlive(is_inbound_connection_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PeerDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PeerDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(socket_address_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(init_features_arg); };
		return ret_hu_conv;
	}

}
} } }
