package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A tx_add_input message for adding an input during interactive transaction construction
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class TxAddInput extends CommonBase {
	TxAddInput(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.TxAddInput_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public ChannelId get_channel_id() {
		long ret = bindings.TxAddInput_get_channel_id(this.ptr);
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
		bindings.TxAddInput_set_channel_id(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * A randomly chosen unique identifier for this input, which is even for initiators and odd for
	 * non-initiators.
	 */
	public long get_serial_id() {
		long ret = bindings.TxAddInput_get_serial_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A randomly chosen unique identifier for this input, which is even for initiators and odd for
	 * non-initiators.
	 */
	public void set_serial_id(long val) {
		bindings.TxAddInput_set_serial_id(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Serialized transaction that contains the output this input spends to verify that it is non
	 * malleable.
	 */
	public TransactionU16LenLimited get_prevtx() {
		long ret = bindings.TxAddInput_get_prevtx(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TransactionU16LenLimited ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TransactionU16LenLimited(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialized transaction that contains the output this input spends to verify that it is non
	 * malleable.
	 */
	public void set_prevtx(org.ldk.structs.TransactionU16LenLimited val) {
		bindings.TxAddInput_set_prevtx(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The index of the output being spent
	 */
	public int get_prevtx_out() {
		int ret = bindings.TxAddInput_get_prevtx_out(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The index of the output being spent
	 */
	public void set_prevtx_out(int val) {
		bindings.TxAddInput_set_prevtx_out(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The sequence number of this input
	 */
	public int get_sequence() {
		int ret = bindings.TxAddInput_get_sequence(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The sequence number of this input
	 */
	public void set_sequence(int val) {
		bindings.TxAddInput_set_sequence(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The ID of the previous funding transaction, when it is being added as an input during splicing
	 */
	public Option_ThirtyTwoBytesZ get_shared_input_txid() {
		long ret = bindings.TxAddInput_get_shared_input_txid(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ThirtyTwoBytesZ ret_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The ID of the previous funding transaction, when it is being added as an input during splicing
	 */
	public void set_shared_input_txid(org.ldk.structs.Option_ThirtyTwoBytesZ val) {
		bindings.TxAddInput_set_shared_input_txid(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new TxAddInput given each field
	 */
	public static TxAddInput of(org.ldk.structs.ChannelId channel_id_arg, long serial_id_arg, org.ldk.structs.TransactionU16LenLimited prevtx_arg, int prevtx_out_arg, int sequence_arg, org.ldk.structs.Option_ThirtyTwoBytesZ shared_input_txid_arg) {
		long ret = bindings.TxAddInput_new(channel_id_arg.ptr, serial_id_arg, prevtx_arg.ptr, prevtx_out_arg, sequence_arg, shared_input_txid_arg.ptr);
		Reference.reachabilityFence(channel_id_arg);
		Reference.reachabilityFence(serial_id_arg);
		Reference.reachabilityFence(prevtx_arg);
		Reference.reachabilityFence(prevtx_out_arg);
		Reference.reachabilityFence(sequence_arg);
		Reference.reachabilityFence(shared_input_txid_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxAddInput ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxAddInput(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.TxAddInput_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxAddInput
	 */
	public TxAddInput clone() {
		long ret = bindings.TxAddInput_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxAddInput ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxAddInput(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the TxAddInput.
	 */
	public long hash() {
		long ret = bindings.TxAddInput_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two TxAddInputs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.TxAddInput b) {
		boolean ret = bindings.TxAddInput_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof TxAddInput)) return false;
		return this.eq((TxAddInput)o);
	}
	/**
	 * Serialize the TxAddInput object into a byte array which can be read by TxAddInput_read
	 */
	public byte[] write() {
		byte[] ret = bindings.TxAddInput_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a TxAddInput from a byte array, created by TxAddInput_write
	 */
	public static Result_TxAddInputDecodeErrorZ read(byte[] ser) {
		long ret = bindings.TxAddInput_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxAddInputDecodeErrorZ ret_hu_conv = Result_TxAddInputDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
