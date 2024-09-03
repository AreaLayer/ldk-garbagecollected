using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An [`error`] message to be sent to or received from a peer.
 * 
 * [`error`]: https://github.com/lightning/bolts/blob/master/01-messaging.md#the-error-and-warning-messages
 */
public class ErrorMessage : CommonBase {
	internal ErrorMessage(object _dummy, long ptr) : base(ptr) { }
	~ErrorMessage() {
		if (ptr != 0) { bindings.ErrorMessage_free(ptr); }
	}

	/**
	 * The channel ID involved in the error.
	 * 
	 * All-0s indicates a general error unrelated to a specific channel, after which all channels
	 * with the sending peer should be closed.
	 */
	public ChannelId get_channel_id() {
		long ret = bindings.ErrorMessage_get_channel_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The channel ID involved in the error.
	 * 
	 * All-0s indicates a general error unrelated to a specific channel, after which all channels
	 * with the sending peer should be closed.
	 */
	public void set_channel_id(org.ldk.structs.ChannelId val) {
		bindings.ErrorMessage_set_channel_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A possibly human-readable error description.
	 * 
	 * The string should be sanitized before it is used (e.g., emitted to logs or printed to
	 * `stdout`). Otherwise, a well crafted error message may trigger a security vulnerability in
	 * the terminal emulator or the logging subsystem.
	 */
	public string get_data() {
		long ret = bindings.ErrorMessage_get_data(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * A possibly human-readable error description.
	 * 
	 * The string should be sanitized before it is used (e.g., emitted to logs or printed to
	 * `stdout`). Otherwise, a well crafted error message may trigger a security vulnerability in
	 * the terminal emulator or the logging subsystem.
	 */
	public void set_data(string val) {
		bindings.ErrorMessage_set_data(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ErrorMessage given each field
	 */
	public static ErrorMessage of(org.ldk.structs.ChannelId channel_id_arg, string data_arg) {
		long ret = bindings.ErrorMessage_new(channel_id_arg.ptr, InternalUtils.encodeString(data_arg));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(data_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ErrorMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ErrorMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ErrorMessage_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ErrorMessage
	 */
	public ErrorMessage clone() {
		long ret = bindings.ErrorMessage_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ErrorMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ErrorMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ErrorMessage.
	 */
	public long hash() {
		long ret = bindings.ErrorMessage_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ErrorMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ErrorMessage b) {
		bool ret = bindings.ErrorMessage_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ErrorMessage)) return false;
		return this.eq((ErrorMessage)o);
	}
	/**
	 * Serialize the ErrorMessage object into a byte array which can be read by ErrorMessage_read
	 */
	public byte[] write() {
		long ret = bindings.ErrorMessage_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ErrorMessage from a byte array, created by ErrorMessage_write
	 */
	public static Result_ErrorMessageDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ErrorMessage_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ErrorMessageDecodeErrorZ ret_hu_conv = Result_ErrorMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
