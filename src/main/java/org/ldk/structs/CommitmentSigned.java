package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A [`commitment_signed`] message to be sent to or received from a peer.
 * 
 * [`commitment_signed`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#committing-updates-so-far-commitment_signed
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class CommitmentSigned extends CommonBase {
	CommitmentSigned(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.CommitmentSigned_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public ChannelId get_channel_id() {
		long ret = bindings.CommitmentSigned_get_channel_id(this.ptr);
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
		bindings.CommitmentSigned_set_channel_id(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * A signature on the commitment transaction
	 */
	public byte[] get_signature() {
		byte[] ret = bindings.CommitmentSigned_get_signature(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A signature on the commitment transaction
	 */
	public void set_signature(byte[] val) {
		bindings.CommitmentSigned_set_signature(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Signatures on the HTLC transactions
	 * 
	 * Returns a copy of the field.
	 */
	public byte[][] get_htlc_signatures() {
		byte[][] ret = bindings.CommitmentSigned_get_htlc_signatures(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Signatures on the HTLC transactions
	 */
	public void set_htlc_signatures(byte[][] val) {
		bindings.CommitmentSigned_set_htlc_signatures(this.ptr, val != null ? Arrays.stream(val).map(val_conv_8 -> InternalUtils.check_arr_len(val_conv_8, 64)).toArray(byte[][]::new) : null);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Optional batch size and other parameters
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public CommitmentSignedBatch get_batch() {
		long ret = bindings.CommitmentSigned_get_batch(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSignedBatch ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSignedBatch(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Optional batch size and other parameters
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_batch(@Nullable org.ldk.structs.CommitmentSignedBatch val) {
		bindings.CommitmentSigned_set_batch(this.ptr, val == null ? 0 : val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new CommitmentSigned given each field
	 * 
	 * Note that batch_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static CommitmentSigned of(org.ldk.structs.ChannelId channel_id_arg, byte[] signature_arg, byte[][] htlc_signatures_arg, @Nullable org.ldk.structs.CommitmentSignedBatch batch_arg) {
		long ret = bindings.CommitmentSigned_new(channel_id_arg.ptr, InternalUtils.check_arr_len(signature_arg, 64), htlc_signatures_arg != null ? Arrays.stream(htlc_signatures_arg).map(htlc_signatures_arg_conv_8 -> InternalUtils.check_arr_len(htlc_signatures_arg_conv_8, 64)).toArray(byte[][]::new) : null, batch_arg == null ? 0 : batch_arg.ptr);
		Reference.reachabilityFence(channel_id_arg);
		Reference.reachabilityFence(signature_arg);
		Reference.reachabilityFence(htlc_signatures_arg);
		Reference.reachabilityFence(batch_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSigned ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSigned(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.CommitmentSigned_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the CommitmentSigned
	 */
	public CommitmentSigned clone() {
		long ret = bindings.CommitmentSigned_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSigned ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSigned(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the CommitmentSigned.
	 */
	public long hash() {
		long ret = bindings.CommitmentSigned_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two CommitmentSigneds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.CommitmentSigned b) {
		boolean ret = bindings.CommitmentSigned_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof CommitmentSigned)) return false;
		return this.eq((CommitmentSigned)o);
	}
	/**
	 * Serialize the CommitmentSigned object into a byte array which can be read by CommitmentSigned_read
	 */
	public byte[] write() {
		byte[] ret = bindings.CommitmentSigned_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a CommitmentSigned from a byte array, created by CommitmentSigned_write
	 */
	public static Result_CommitmentSignedDecodeErrorZ read(byte[] ser) {
		long ret = bindings.CommitmentSigned_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CommitmentSignedDecodeErrorZ ret_hu_conv = Result_CommitmentSignedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
