using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An [`update_add_htlc`] message to be sent to or received from a peer.
 * 
 * [`update_add_htlc`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#adding-an-htlc-update_add_htlc
 */
public class UpdateAddHTLC : CommonBase {
	internal UpdateAddHTLC(object _dummy, long ptr) : base(ptr) { }
	~UpdateAddHTLC() {
		if (ptr != 0) { bindings.UpdateAddHTLC_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public org.ldk.structs.ChannelId get_channel_id() {
		long ret = bindings.UpdateAddHTLC_get_channel_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(org.ldk.structs.ChannelId val) {
		bindings.UpdateAddHTLC_set_channel_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The HTLC ID
	 */
	public long get_htlc_id() {
		long ret = bindings.UpdateAddHTLC_get_htlc_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The HTLC ID
	 */
	public void set_htlc_id(long val) {
		bindings.UpdateAddHTLC_set_htlc_id(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The HTLC value in milli-satoshi
	 */
	public long get_amount_msat() {
		long ret = bindings.UpdateAddHTLC_get_amount_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The HTLC value in milli-satoshi
	 */
	public void set_amount_msat(long val) {
		bindings.UpdateAddHTLC_set_amount_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The payment hash, the pre-image of which controls HTLC redemption
	 */
	public byte[] get_payment_hash() {
		long ret = bindings.UpdateAddHTLC_get_payment_hash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The payment hash, the pre-image of which controls HTLC redemption
	 */
	public void set_payment_hash(byte[] val) {
		bindings.UpdateAddHTLC_set_payment_hash(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The expiry height of the HTLC
	 */
	public int get_cltv_expiry() {
		int ret = bindings.UpdateAddHTLC_get_cltv_expiry(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The expiry height of the HTLC
	 */
	public void set_cltv_expiry(int val) {
		bindings.UpdateAddHTLC_set_cltv_expiry(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The extra fee skimmed by the sender of this message. See
	 * [`ChannelConfig::accept_underpaying_htlcs`].
	 * 
	 * [`ChannelConfig::accept_underpaying_htlcs`]: crate::util::config::ChannelConfig::accept_underpaying_htlcs
	 */
	public org.ldk.structs.Option_u64Z get_skimmed_fee_msat() {
		long ret = bindings.UpdateAddHTLC_get_skimmed_fee_msat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The extra fee skimmed by the sender of this message. See
	 * [`ChannelConfig::accept_underpaying_htlcs`].
	 * 
	 * [`ChannelConfig::accept_underpaying_htlcs`]: crate::util::config::ChannelConfig::accept_underpaying_htlcs
	 */
	public void set_skimmed_fee_msat(org.ldk.structs.Option_u64Z val) {
		bindings.UpdateAddHTLC_set_skimmed_fee_msat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The onion routing packet with encrypted data for the next hop.
	 */
	public org.ldk.structs.OnionPacket get_onion_routing_packet() {
		long ret = bindings.UpdateAddHTLC_get_onion_routing_packet(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OnionPacket ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OnionPacket(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The onion routing packet with encrypted data for the next hop.
	 */
	public void set_onion_routing_packet(org.ldk.structs.OnionPacket val) {
		bindings.UpdateAddHTLC_set_onion_routing_packet(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Provided if we are relaying or receiving a payment within a blinded path, to decrypt the onion
	 * routing packet and the recipient-provided encrypted payload within.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public byte[] get_blinding_point() {
		long ret = bindings.UpdateAddHTLC_get_blinding_point(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Provided if we are relaying or receiving a payment within a blinded path, to decrypt the onion
	 * routing packet and the recipient-provided encrypted payload within.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_blinding_point(byte[] val) {
		bindings.UpdateAddHTLC_set_blinding_point(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new UpdateAddHTLC given each field
	 * 
	 * Note that blinding_point_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static org.ldk.structs.UpdateAddHTLC of(org.ldk.structs.ChannelId channel_id_arg, long htlc_id_arg, long amount_msat_arg, byte[] payment_hash_arg, int cltv_expiry_arg, org.ldk.structs.Option_u64Z skimmed_fee_msat_arg, org.ldk.structs.OnionPacket onion_routing_packet_arg, byte[] blinding_point_arg) {
		long ret = bindings.UpdateAddHTLC_new(channel_id_arg.ptr, htlc_id_arg, amount_msat_arg, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash_arg, 32)), cltv_expiry_arg, skimmed_fee_msat_arg.ptr, onion_routing_packet_arg.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(blinding_point_arg, 33)));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(htlc_id_arg);
		GC.KeepAlive(amount_msat_arg);
		GC.KeepAlive(payment_hash_arg);
		GC.KeepAlive(cltv_expiry_arg);
		GC.KeepAlive(skimmed_fee_msat_arg);
		GC.KeepAlive(onion_routing_packet_arg);
		GC.KeepAlive(blinding_point_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateAddHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateAddHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.UpdateAddHTLC_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UpdateAddHTLC
	 */
	public org.ldk.structs.UpdateAddHTLC clone() {
		long ret = bindings.UpdateAddHTLC_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateAddHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateAddHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the UpdateAddHTLC.
	 */
	public long hash() {
		long ret = bindings.UpdateAddHTLC_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two UpdateAddHTLCs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UpdateAddHTLC b) {
		bool ret = bindings.UpdateAddHTLC_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UpdateAddHTLC)) return false;
		return this.eq((UpdateAddHTLC)o);
	}
	/**
	 * Serialize the UpdateAddHTLC object into a byte array which can be read by UpdateAddHTLC_read
	 */
	public byte[] write() {
		long ret = bindings.UpdateAddHTLC_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a UpdateAddHTLC from a byte array, created by UpdateAddHTLC_write
	 */
	public static org.ldk.structs.Result_UpdateAddHTLCDecodeErrorZ read(byte[] ser) {
		long ret = bindings.UpdateAddHTLC_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateAddHTLCDecodeErrorZ ret_hu_conv = Result_UpdateAddHTLCDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
