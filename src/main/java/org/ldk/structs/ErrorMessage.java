package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An [`error`] message to be sent to or received from a peer.
 * 
 * [`error`]: https://github.com/lightning/bolts/blob/master/01-messaging.md#the-error-and-warning-messages
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ErrorMessage extends CommonBase {
	ErrorMessage(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
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
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
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
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * A possibly human-readable error description.
	 * 
	 * The string should be sanitized before it is used (e.g., emitted to logs or printed to
	 * `stdout`). Otherwise, a well crafted error message may trigger a security vulnerability in
	 * the terminal emulator or the logging subsystem.
	 */
	public String get_data() {
		String ret = bindings.ErrorMessage_get_data(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A possibly human-readable error description.
	 * 
	 * The string should be sanitized before it is used (e.g., emitted to logs or printed to
	 * `stdout`). Otherwise, a well crafted error message may trigger a security vulnerability in
	 * the terminal emulator or the logging subsystem.
	 */
	public void set_data(java.lang.String val) {
		bindings.ErrorMessage_set_data(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new ErrorMessage given each field
	 */
	public static ErrorMessage of(org.ldk.structs.ChannelId channel_id_arg, java.lang.String data_arg) {
		long ret = bindings.ErrorMessage_new(channel_id_arg.ptr, data_arg);
		Reference.reachabilityFence(channel_id_arg);
		Reference.reachabilityFence(data_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ErrorMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ErrorMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.ErrorMessage_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ErrorMessage
	 */
	public ErrorMessage clone() {
		long ret = bindings.ErrorMessage_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ErrorMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ErrorMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ErrorMessage.
	 */
	public long hash() {
		long ret = bindings.ErrorMessage_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ErrorMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.ErrorMessage b) {
		boolean ret = bindings.ErrorMessage_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof ErrorMessage)) return false;
		return this.eq((ErrorMessage)o);
	}
	/**
	 * Serialize the ErrorMessage object into a byte array which can be read by ErrorMessage_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ErrorMessage_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a ErrorMessage from a byte array, created by ErrorMessage_write
	 */
	public static Result_ErrorMessageDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ErrorMessage_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ErrorMessageDecodeErrorZ ret_hu_conv = Result_ErrorMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
