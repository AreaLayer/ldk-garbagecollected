package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * This class tracks the per-transaction information needed to build a commitment transaction and will
 * actually build it and sign.  It is used for holder transactions that we sign only when needed
 * and for transactions we sign for the counterparty.
 * 
 * This class can be used inside a signer implementation to generate a signature given the relevant
 * secret key.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class CommitmentTransaction extends CommonBase {
	CommitmentTransaction(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.CommitmentTransaction_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.CommitmentTransaction_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the CommitmentTransaction
	 */
	public CommitmentTransaction clone() {
		long ret = bindings.CommitmentTransaction_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentTransaction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentTransaction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the CommitmentTransaction object into a byte array which can be read by CommitmentTransaction_read
	 */
	public byte[] write() {
		byte[] ret = bindings.CommitmentTransaction_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a CommitmentTransaction from a byte array, created by CommitmentTransaction_write
	 */
	public static Result_CommitmentTransactionDecodeErrorZ read(byte[] ser) {
		long ret = bindings.CommitmentTransaction_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CommitmentTransactionDecodeErrorZ ret_hu_conv = Result_CommitmentTransactionDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * The backwards-counting commitment number
	 */
	public long commitment_number() {
		long ret = bindings.CommitmentTransaction_commitment_number(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The per commitment point used by the broadcaster.
	 */
	public byte[] per_commitment_point() {
		byte[] ret = bindings.CommitmentTransaction_per_commitment_point(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The value to be sent to the broadcaster
	 */
	public long to_broadcaster_value_sat() {
		long ret = bindings.CommitmentTransaction_to_broadcaster_value_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The value to be sent to the counterparty
	 */
	public long to_countersignatory_value_sat() {
		long ret = bindings.CommitmentTransaction_to_countersignatory_value_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The feerate paid per 1000-weight-unit in this commitment transaction.
	 */
	public int feerate_per_kw() {
		int ret = bindings.CommitmentTransaction_feerate_per_kw(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Trust our pre-built transaction and derived transaction creation public keys.
	 * 
	 * Applies a wrapper which allows access to these fields.
	 * 
	 * This should only be used if you fully trust the builder of this object.  It should not
	 * be used by an external signer - instead use the verify function.
	 */
	public TrustedCommitmentTransaction trust() {
		long ret = bindings.CommitmentTransaction_trust(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TrustedCommitmentTransaction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TrustedCommitmentTransaction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Verify our pre-built transaction and derived transaction creation public keys.
	 * 
	 * Applies a wrapper which allows access to these fields.
	 * 
	 * An external validating signer must call this method before signing
	 * or using the built transaction.
	 */
	public Result_TrustedCommitmentTransactionNoneZ verify(org.ldk.structs.DirectedChannelTransactionParameters channel_parameters, org.ldk.structs.ChannelPublicKeys broadcaster_keys, org.ldk.structs.ChannelPublicKeys countersignatory_keys) {
		long ret = bindings.CommitmentTransaction_verify(this.ptr, channel_parameters.ptr, broadcaster_keys.ptr, countersignatory_keys.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(channel_parameters);
		Reference.reachabilityFence(broadcaster_keys);
		Reference.reachabilityFence(countersignatory_keys);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TrustedCommitmentTransactionNoneZ ret_hu_conv = Result_TrustedCommitmentTransactionNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(channel_parameters); };
		if (this != null) { this.ptrs_to.add(broadcaster_keys); };
		if (this != null) { this.ptrs_to.add(countersignatory_keys); };
		return ret_hu_conv;
	}

}
