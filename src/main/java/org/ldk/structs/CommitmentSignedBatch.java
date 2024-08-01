package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Optional batch parameters for `commitment_signed` message.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class CommitmentSignedBatch extends CommonBase {
	CommitmentSignedBatch(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.CommitmentSignedBatch_free(ptr); }
	}

	/**
	 * Batch size N: all N `commitment_signed` messages must be received before being processed
	 */
	public short get_batch_size() {
		short ret = bindings.CommitmentSignedBatch_get_batch_size(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Batch size N: all N `commitment_signed` messages must be received before being processed
	 */
	public void set_batch_size(short val) {
		bindings.CommitmentSignedBatch_set_batch_size(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The funding transaction, to discriminate among multiple pending funding transactions (e.g. in case of splicing)
	 */
	public byte[] get_funding_txid() {
		byte[] ret = bindings.CommitmentSignedBatch_get_funding_txid(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The funding transaction, to discriminate among multiple pending funding transactions (e.g. in case of splicing)
	 */
	public void set_funding_txid(byte[] val) {
		bindings.CommitmentSignedBatch_set_funding_txid(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new CommitmentSignedBatch given each field
	 */
	public static CommitmentSignedBatch of(short batch_size_arg, byte[] funding_txid_arg) {
		long ret = bindings.CommitmentSignedBatch_new(batch_size_arg, InternalUtils.check_arr_len(funding_txid_arg, 32));
		Reference.reachabilityFence(batch_size_arg);
		Reference.reachabilityFence(funding_txid_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSignedBatch ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSignedBatch(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.CommitmentSignedBatch_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the CommitmentSignedBatch
	 */
	public CommitmentSignedBatch clone() {
		long ret = bindings.CommitmentSignedBatch_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSignedBatch ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSignedBatch(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the CommitmentSignedBatch.
	 */
	public long hash() {
		long ret = bindings.CommitmentSignedBatch_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two CommitmentSignedBatchs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.CommitmentSignedBatch b) {
		boolean ret = bindings.CommitmentSignedBatch_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof CommitmentSignedBatch)) return false;
		return this.eq((CommitmentSignedBatch)o);
	}
	/**
	 * Serialize the CommitmentSignedBatch object into a byte array which can be read by CommitmentSignedBatch_read
	 */
	public byte[] write() {
		byte[] ret = bindings.CommitmentSignedBatch_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a CommitmentSignedBatch from a byte array, created by CommitmentSignedBatch_write
	 */
	public static Result_CommitmentSignedBatchDecodeErrorZ read(byte[] ser) {
		long ret = bindings.CommitmentSignedBatch_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CommitmentSignedBatchDecodeErrorZ ret_hu_conv = Result_CommitmentSignedBatchDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
