package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A [`tx_remove_output`] message for removing an output during interactive transaction construction.
 * 
 * [`tx_remove_output`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#the-tx_remove_input-and-tx_remove_output-messages
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class TxRemoveOutput extends CommonBase {
	TxRemoveOutput(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.TxRemoveOutput_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public ChannelId get_channel_id() {
		long ret = bindings.TxRemoveOutput_get_channel_id(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(org.ldk.structs.ChannelId val) {
		bindings.TxRemoveOutput_set_channel_id(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The serial ID of the output to be removed
	 */
	public long get_serial_id() {
		long ret = bindings.TxRemoveOutput_get_serial_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The serial ID of the output to be removed
	 */
	public void set_serial_id(long val) {
		bindings.TxRemoveOutput_set_serial_id(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new TxRemoveOutput given each field
	 */
	public static TxRemoveOutput of(org.ldk.structs.ChannelId channel_id_arg, long serial_id_arg) {
		long ret = bindings.TxRemoveOutput_new(channel_id_arg.ptr, serial_id_arg);
		Reference.reachabilityFence(channel_id_arg);
		Reference.reachabilityFence(serial_id_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxRemoveOutput ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxRemoveOutput(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.TxRemoveOutput_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxRemoveOutput
	 */
	public TxRemoveOutput clone() {
		long ret = bindings.TxRemoveOutput_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxRemoveOutput ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxRemoveOutput(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the TxRemoveOutput.
	 */
	public long hash() {
		long ret = bindings.TxRemoveOutput_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two TxRemoveOutputs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.TxRemoveOutput b) {
		boolean ret = bindings.TxRemoveOutput_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof TxRemoveOutput)) return false;
		return this.eq((TxRemoveOutput)o);
	}
	/**
	 * Serialize the TxRemoveOutput object into a byte array which can be read by TxRemoveOutput_read
	 */
	public byte[] write() {
		byte[] ret = bindings.TxRemoveOutput_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a TxRemoveOutput from a byte array, created by TxRemoveOutput_write
	 */
	public static Result_TxRemoveOutputDecodeErrorZ read(byte[] ser) {
		long ret = bindings.TxRemoveOutput_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxRemoveOutputDecodeErrorZ ret_hu_conv = Result_TxRemoveOutputDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
