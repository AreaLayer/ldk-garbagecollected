using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An [`update_fail_malformed_htlc`] message to be sent to or received from a peer.
 * 
 * [`update_fail_malformed_htlc`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#removing-an-htlc-update_fulfill_htlc-update_fail_htlc-and-update_fail_malformed_htlc
 */
public class UpdateFailMalformedHTLC : CommonBase {
	internal UpdateFailMalformedHTLC(object _dummy, long ptr) : base(ptr) { }
	~UpdateFailMalformedHTLC() {
		if (ptr != 0) { bindings.UpdateFailMalformedHTLC_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public ChannelId get_channel_id() {
		long ret = bindings.UpdateFailMalformedHTLC_get_channel_id(this.ptr);
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
		bindings.UpdateFailMalformedHTLC_set_channel_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The HTLC ID
	 */
	public long get_htlc_id() {
		long ret = bindings.UpdateFailMalformedHTLC_get_htlc_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The HTLC ID
	 */
	public void set_htlc_id(long val) {
		bindings.UpdateFailMalformedHTLC_set_htlc_id(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The failure code
	 */
	public short get_failure_code() {
		short ret = bindings.UpdateFailMalformedHTLC_get_failure_code(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The failure code
	 */
	public void set_failure_code(short val) {
		bindings.UpdateFailMalformedHTLC_set_failure_code(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = bindings.UpdateFailMalformedHTLC_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UpdateFailMalformedHTLC
	 */
	public UpdateFailMalformedHTLC clone() {
		long ret = bindings.UpdateFailMalformedHTLC_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFailMalformedHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFailMalformedHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the UpdateFailMalformedHTLC.
	 */
	public long hash() {
		long ret = bindings.UpdateFailMalformedHTLC_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two UpdateFailMalformedHTLCs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UpdateFailMalformedHTLC b) {
		bool ret = bindings.UpdateFailMalformedHTLC_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UpdateFailMalformedHTLC)) return false;
		return this.eq((UpdateFailMalformedHTLC)o);
	}
	/**
	 * Serialize the UpdateFailMalformedHTLC object into a byte array which can be read by UpdateFailMalformedHTLC_read
	 */
	public byte[] write() {
		long ret = bindings.UpdateFailMalformedHTLC_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a UpdateFailMalformedHTLC from a byte array, created by UpdateFailMalformedHTLC_write
	 */
	public static Result_UpdateFailMalformedHTLCDecodeErrorZ read(byte[] ser) {
		long ret = bindings.UpdateFailMalformedHTLC_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateFailMalformedHTLCDecodeErrorZ ret_hu_conv = Result_UpdateFailMalformedHTLCDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
