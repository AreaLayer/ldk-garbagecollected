package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Lightning message type used by LSPS protocols.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class RawLSPSMessage extends CommonBase {
	RawLSPSMessage(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.RawLSPSMessage_free(ptr); }
	}

	/**
	 * The raw string payload that holds the actual message.
	 */
	public String get_payload() {
		String ret = bindings.RawLSPSMessage_get_payload(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The raw string payload that holds the actual message.
	 */
	public void set_payload(java.lang.String val) {
		bindings.RawLSPSMessage_set_payload(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new RawLSPSMessage given each field
	 */
	public static RawLSPSMessage of(java.lang.String payload_arg) {
		long ret = bindings.RawLSPSMessage_new(payload_arg);
		Reference.reachabilityFence(payload_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RawLSPSMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RawLSPSMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.RawLSPSMessage_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the RawLSPSMessage
	 */
	public RawLSPSMessage clone() {
		long ret = bindings.RawLSPSMessage_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RawLSPSMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RawLSPSMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two RawLSPSMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.RawLSPSMessage b) {
		boolean ret = bindings.RawLSPSMessage_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof RawLSPSMessage)) return false;
		return this.eq((RawLSPSMessage)o);
	}
	/**
	 * Serialize the RawLSPSMessage object into a byte array which can be read by RawLSPSMessage_read
	 */
	public byte[] write() {
		byte[] ret = bindings.RawLSPSMessage_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a RawLSPSMessage from a byte array, created by RawLSPSMessage_write
	 */
	public static Result_RawLSPSMessageDecodeErrorZ read(byte[] ser) {
		long ret = bindings.RawLSPSMessage_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RawLSPSMessageDecodeErrorZ ret_hu_conv = Result_RawLSPSMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new Type which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned Type must be freed before this_arg is
	 */
	public Type as_Type() {
		long ret = bindings.RawLSPSMessage_as_Type(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Type ret_hu_conv = new Type(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
