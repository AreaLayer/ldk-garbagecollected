using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`channel_update`] message to be sent to or received from a peer.
 * 
 * [`channel_update`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-channel_update-message
 */
public class ChannelUpdate : CommonBase {
	internal ChannelUpdate(object _dummy, long ptr) : base(ptr) { }
	~ChannelUpdate() {
		if (ptr != 0) { bindings.ChannelUpdate_free(ptr); }
	}

	/**
	 * A signature of the channel update
	 */
	public byte[] get_signature() {
		long ret = bindings.ChannelUpdate_get_signature(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * A signature of the channel update
	 */
	public void set_signature(byte[] val) {
		bindings.ChannelUpdate_set_signature(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 64)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The actual channel update
	 */
	public org.ldk.structs.UnsignedChannelUpdate get_contents() {
		long ret = bindings.ChannelUpdate_get_contents(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The actual channel update
	 */
	public void set_contents(org.ldk.structs.UnsignedChannelUpdate val) {
		bindings.ChannelUpdate_set_contents(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ChannelUpdate given each field
	 */
	public static org.ldk.structs.ChannelUpdate of(byte[] signature_arg, org.ldk.structs.UnsignedChannelUpdate contents_arg) {
		long ret = bindings.ChannelUpdate_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(signature_arg, 64)), contents_arg.ptr);
		GC.KeepAlive(signature_arg);
		GC.KeepAlive(contents_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ChannelUpdate_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelUpdate
	 */
	public org.ldk.structs.ChannelUpdate clone() {
		long ret = bindings.ChannelUpdate_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelUpdate.
	 */
	public long hash() {
		long ret = bindings.ChannelUpdate_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ChannelUpdates contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelUpdate b) {
		bool ret = bindings.ChannelUpdate_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelUpdate)) return false;
		return this.eq((ChannelUpdate)o);
	}
	/**
	 * Serialize the ChannelUpdate object into a byte array which can be read by ChannelUpdate_read
	 */
	public byte[] write() {
		long ret = bindings.ChannelUpdate_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelUpdate from a byte array, created by ChannelUpdate_write
	 */
	public static org.ldk.structs.Result_ChannelUpdateDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelUpdate_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelUpdateDecodeErrorZ ret_hu_conv = Result_ChannelUpdateDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
