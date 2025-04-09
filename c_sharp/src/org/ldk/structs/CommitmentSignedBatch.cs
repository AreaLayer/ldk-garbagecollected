using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Optional batch parameters for `commitment_signed` message.
 */
public class CommitmentSignedBatch : CommonBase {
	internal CommitmentSignedBatch(object _dummy, long ptr) : base(ptr) { }
	~CommitmentSignedBatch() {
		if (ptr != 0) { bindings.CommitmentSignedBatch_free(ptr); }
	}

	/**
	 * Batch size N: all N `commitment_signed` messages must be received before being processed
	 */
	public short get_batch_size() {
		short ret = bindings.CommitmentSignedBatch_get_batch_size(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Batch size N: all N `commitment_signed` messages must be received before being processed
	 */
	public void set_batch_size(short val) {
		bindings.CommitmentSignedBatch_set_batch_size(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The funding transaction, to discriminate among multiple pending funding transactions (e.g. in case of splicing)
	 */
	public byte[] get_funding_txid() {
		long ret = bindings.CommitmentSignedBatch_get_funding_txid(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The funding transaction, to discriminate among multiple pending funding transactions (e.g. in case of splicing)
	 */
	public void set_funding_txid(byte[] val) {
		bindings.CommitmentSignedBatch_set_funding_txid(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new CommitmentSignedBatch given each field
	 */
	public static org.ldk.structs.CommitmentSignedBatch of(short batch_size_arg, byte[] funding_txid_arg) {
		long ret = bindings.CommitmentSignedBatch_new(batch_size_arg, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(funding_txid_arg, 32)));
		GC.KeepAlive(batch_size_arg);
		GC.KeepAlive(funding_txid_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSignedBatch ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSignedBatch(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.CommitmentSignedBatch_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the CommitmentSignedBatch
	 */
	public org.ldk.structs.CommitmentSignedBatch clone() {
		long ret = bindings.CommitmentSignedBatch_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSignedBatch ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSignedBatch(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the CommitmentSignedBatch.
	 */
	public long hash() {
		long ret = bindings.CommitmentSignedBatch_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two CommitmentSignedBatchs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.CommitmentSignedBatch b) {
		bool ret = bindings.CommitmentSignedBatch_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is CommitmentSignedBatch)) return false;
		return this.eq((CommitmentSignedBatch)o);
	}
	/**
	 * Serialize the CommitmentSignedBatch object into a byte array which can be read by CommitmentSignedBatch_read
	 */
	public byte[] write() {
		long ret = bindings.CommitmentSignedBatch_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a CommitmentSignedBatch from a byte array, created by CommitmentSignedBatch_write
	 */
	public static org.ldk.structs.Result_CommitmentSignedBatchDecodeErrorZ read(byte[] ser) {
		long ret = bindings.CommitmentSignedBatch_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CommitmentSignedBatchDecodeErrorZ ret_hu_conv = Result_CommitmentSignedBatchDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
