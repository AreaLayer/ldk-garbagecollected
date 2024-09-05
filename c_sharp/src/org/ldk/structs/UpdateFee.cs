using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An [`update_fee`] message to be sent to or received from a peer
 * 
 * [`update_fee`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#updating-fees-update_fee
 */
public class UpdateFee : CommonBase {
	internal UpdateFee(object _dummy, long ptr) : base(ptr) { }
	~UpdateFee() {
		if (ptr != 0) { bindings.UpdateFee_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public ChannelId get_channel_id() {
		long ret = bindings.UpdateFee_get_channel_id(this.ptr);
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
		bindings.UpdateFee_set_channel_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Fee rate per 1000-weight of the transaction
	 */
	public int get_feerate_per_kw() {
		int ret = bindings.UpdateFee_get_feerate_per_kw(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Fee rate per 1000-weight of the transaction
	 */
	public void set_feerate_per_kw(int val) {
		bindings.UpdateFee_set_feerate_per_kw(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new UpdateFee given each field
	 */
	public static UpdateFee of(org.ldk.structs.ChannelId channel_id_arg, int feerate_per_kw_arg) {
		long ret = bindings.UpdateFee_new(channel_id_arg.ptr, feerate_per_kw_arg);
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(feerate_per_kw_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFee ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFee(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.UpdateFee_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UpdateFee
	 */
	public UpdateFee clone() {
		long ret = bindings.UpdateFee_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFee ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFee(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the UpdateFee.
	 */
	public long hash() {
		long ret = bindings.UpdateFee_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two UpdateFees contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UpdateFee b) {
		bool ret = bindings.UpdateFee_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UpdateFee)) return false;
		return this.eq((UpdateFee)o);
	}
	/**
	 * Serialize the UpdateFee object into a byte array which can be read by UpdateFee_read
	 */
	public byte[] write() {
		long ret = bindings.UpdateFee_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a UpdateFee from a byte array, created by UpdateFee_write
	 */
	public static Result_UpdateFeeDecodeErrorZ read(byte[] ser) {
		long ret = bindings.UpdateFee_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateFeeDecodeErrorZ ret_hu_conv = Result_UpdateFeeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
