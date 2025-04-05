using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Lightning message type used by LSPS protocols.
 */
public class RawLSPSMessage : CommonBase {
	internal RawLSPSMessage(object _dummy, long ptr) : base(ptr) { }
	~RawLSPSMessage() {
		if (ptr != 0) { bindings.RawLSPSMessage_free(ptr); }
	}

	/**
	 * The raw string payload that holds the actual message.
	 */
	public string get_payload() {
		long ret = bindings.RawLSPSMessage_get_payload(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * The raw string payload that holds the actual message.
	 */
	public void set_payload(string val) {
		bindings.RawLSPSMessage_set_payload(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new RawLSPSMessage given each field
	 */
	public static org.ldk.structs.RawLSPSMessage of(string payload_arg) {
		long ret = bindings.RawLSPSMessage_new(InternalUtils.encodeString(payload_arg));
		GC.KeepAlive(payload_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RawLSPSMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RawLSPSMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.RawLSPSMessage_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the RawLSPSMessage
	 */
	public org.ldk.structs.RawLSPSMessage clone() {
		long ret = bindings.RawLSPSMessage_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RawLSPSMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RawLSPSMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two RawLSPSMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.RawLSPSMessage b) {
		bool ret = bindings.RawLSPSMessage_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is RawLSPSMessage)) return false;
		return this.eq((RawLSPSMessage)o);
	}
	/**
	 * Serialize the RawLSPSMessage object into a byte array which can be read by RawLSPSMessage_read
	 */
	public byte[] write() {
		long ret = bindings.RawLSPSMessage_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a RawLSPSMessage from a byte array, created by RawLSPSMessage_write
	 */
	public static org.ldk.structs.Result_RawLSPSMessageDecodeErrorZ read(byte[] ser) {
		long ret = bindings.RawLSPSMessage_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RawLSPSMessageDecodeErrorZ ret_hu_conv = Result_RawLSPSMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new Type which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned Type must be freed before this_arg is
	 */
	public org.ldk.structs.Type as_Type() {
		long ret = bindings.RawLSPSMessage_as_Type(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Type ret_hu_conv = new Type(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
