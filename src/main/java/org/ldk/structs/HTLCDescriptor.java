package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A descriptor used to sign for a commitment transaction's HTLC output.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class HTLCDescriptor extends CommonBase {
	HTLCDescriptor(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.HTLCDescriptor_free(ptr); }
	}

	/**
	 * The parameters required to derive the signer for the HTLC input.
	 */
	public ChannelDerivationParameters get_channel_derivation_parameters() {
		long ret = bindings.HTLCDescriptor_get_channel_derivation_parameters(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelDerivationParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelDerivationParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The parameters required to derive the signer for the HTLC input.
	 */
	public void set_channel_derivation_parameters(org.ldk.structs.ChannelDerivationParameters val) {
		bindings.HTLCDescriptor_set_channel_derivation_parameters(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The txid of the commitment transaction in which the HTLC output lives.
	 */
	public byte[] get_commitment_txid() {
		byte[] ret = bindings.HTLCDescriptor_get_commitment_txid(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The txid of the commitment transaction in which the HTLC output lives.
	 */
	public void set_commitment_txid(byte[] val) {
		bindings.HTLCDescriptor_set_commitment_txid(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The number of the commitment transaction in which the HTLC output lives.
	 */
	public long get_per_commitment_number() {
		long ret = bindings.HTLCDescriptor_get_per_commitment_number(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The number of the commitment transaction in which the HTLC output lives.
	 */
	public void set_per_commitment_number(long val) {
		bindings.HTLCDescriptor_set_per_commitment_number(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The key tweak corresponding to the number of the commitment transaction in which the HTLC
	 * output lives. This tweak is applied to all the basepoints for both parties in the channel to
	 * arrive at unique keys per commitment.
	 * 
	 * See <https://github.com/lightning/bolts/blob/master/03-transactions.md#keys> for more info.
	 */
	public byte[] get_per_commitment_point() {
		byte[] ret = bindings.HTLCDescriptor_get_per_commitment_point(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The key tweak corresponding to the number of the commitment transaction in which the HTLC
	 * output lives. This tweak is applied to all the basepoints for both parties in the channel to
	 * arrive at unique keys per commitment.
	 * 
	 * See <https://github.com/lightning/bolts/blob/master/03-transactions.md#keys> for more info.
	 */
	public void set_per_commitment_point(byte[] val) {
		bindings.HTLCDescriptor_set_per_commitment_point(this.ptr, InternalUtils.check_arr_len(val, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The feerate to use on the HTLC claiming transaction. This is always `0` for HTLCs
	 * originating from a channel supporting anchor outputs, otherwise it is the channel's
	 * negotiated feerate at the time the commitment transaction was built.
	 */
	public int get_feerate_per_kw() {
		int ret = bindings.HTLCDescriptor_get_feerate_per_kw(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The feerate to use on the HTLC claiming transaction. This is always `0` for HTLCs
	 * originating from a channel supporting anchor outputs, otherwise it is the channel's
	 * negotiated feerate at the time the commitment transaction was built.
	 */
	public void set_feerate_per_kw(int val) {
		bindings.HTLCDescriptor_set_feerate_per_kw(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The details of the HTLC as it appears in the commitment transaction.
	 */
	public HTLCOutputInCommitment get_htlc() {
		long ret = bindings.HTLCDescriptor_get_htlc(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCOutputInCommitment ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HTLCOutputInCommitment(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The details of the HTLC as it appears in the commitment transaction.
	 */
	public void set_htlc(org.ldk.structs.HTLCOutputInCommitment val) {
		bindings.HTLCDescriptor_set_htlc(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The preimage, if `Some`, to claim the HTLC output with. If `None`, the timeout path must be
	 * taken.
	 */
	public Option_ThirtyTwoBytesZ get_preimage() {
		long ret = bindings.HTLCDescriptor_get_preimage(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ThirtyTwoBytesZ ret_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The preimage, if `Some`, to claim the HTLC output with. If `None`, the timeout path must be
	 * taken.
	 */
	public void set_preimage(org.ldk.structs.Option_ThirtyTwoBytesZ val) {
		bindings.HTLCDescriptor_set_preimage(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The counterparty's signature required to spend the HTLC output.
	 */
	public byte[] get_counterparty_sig() {
		byte[] ret = bindings.HTLCDescriptor_get_counterparty_sig(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The counterparty's signature required to spend the HTLC output.
	 */
	public void set_counterparty_sig(byte[] val) {
		bindings.HTLCDescriptor_set_counterparty_sig(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new HTLCDescriptor given each field
	 */
	public static HTLCDescriptor of(org.ldk.structs.ChannelDerivationParameters channel_derivation_parameters_arg, byte[] commitment_txid_arg, long per_commitment_number_arg, byte[] per_commitment_point_arg, int feerate_per_kw_arg, org.ldk.structs.HTLCOutputInCommitment htlc_arg, org.ldk.structs.Option_ThirtyTwoBytesZ preimage_arg, byte[] counterparty_sig_arg) {
		long ret = bindings.HTLCDescriptor_new(channel_derivation_parameters_arg.ptr, InternalUtils.check_arr_len(commitment_txid_arg, 32), per_commitment_number_arg, InternalUtils.check_arr_len(per_commitment_point_arg, 33), feerate_per_kw_arg, htlc_arg.ptr, preimage_arg.ptr, InternalUtils.check_arr_len(counterparty_sig_arg, 64));
		Reference.reachabilityFence(channel_derivation_parameters_arg);
		Reference.reachabilityFence(commitment_txid_arg);
		Reference.reachabilityFence(per_commitment_number_arg);
		Reference.reachabilityFence(per_commitment_point_arg);
		Reference.reachabilityFence(feerate_per_kw_arg);
		Reference.reachabilityFence(htlc_arg);
		Reference.reachabilityFence(preimage_arg);
		Reference.reachabilityFence(counterparty_sig_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDescriptor ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HTLCDescriptor(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.HTLCDescriptor_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the HTLCDescriptor
	 */
	public HTLCDescriptor clone() {
		long ret = bindings.HTLCDescriptor_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDescriptor ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HTLCDescriptor(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two HTLCDescriptors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.HTLCDescriptor b) {
		boolean ret = bindings.HTLCDescriptor_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof HTLCDescriptor)) return false;
		return this.eq((HTLCDescriptor)o);
	}
	/**
	 * Serialize the HTLCDescriptor object into a byte array which can be read by HTLCDescriptor_read
	 */
	public byte[] write() {
		byte[] ret = bindings.HTLCDescriptor_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a HTLCDescriptor from a byte array, created by HTLCDescriptor_write
	 */
	public static Result_HTLCDescriptorDecodeErrorZ read(byte[] ser) {
		long ret = bindings.HTLCDescriptor_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HTLCDescriptorDecodeErrorZ ret_hu_conv = Result_HTLCDescriptorDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Returns the outpoint of the HTLC output in the commitment transaction. This is the outpoint
	 * being spent by the HTLC input in the HTLC transaction.
	 */
	public OutPoint outpoint() {
		long ret = bindings.HTLCDescriptor_outpoint(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns the UTXO to be spent by the HTLC input, which can be obtained via
	 * [`Self::unsigned_tx_input`].
	 */
	public TxOut previous_utxo() {
		long ret = bindings.HTLCDescriptor_previous_utxo(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TxOut ret_conv = new TxOut(null, ret);
		return ret_conv;
	}

	/**
	 * Returns the unsigned transaction input spending the HTLC output in the commitment
	 * transaction.
	 */
	public TxIn unsigned_tx_input() {
		long ret = bindings.HTLCDescriptor_unsigned_tx_input(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TxIn ret_conv = new TxIn(null, ret);
		return ret_conv;
	}

	/**
	 * Returns the delayed output created as a result of spending the HTLC output in the commitment
	 * transaction.
	 */
	public TxOut tx_output() {
		long ret = bindings.HTLCDescriptor_tx_output(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TxOut ret_conv = new TxOut(null, ret);
		return ret_conv;
	}

	/**
	 * Returns the witness script of the HTLC output in the commitment transaction.
	 */
	public byte[] witness_script() {
		byte[] ret = bindings.HTLCDescriptor_witness_script(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Returns the fully signed witness required to spend the HTLC output in the commitment
	 * transaction.
	 */
	public byte[] tx_input_witness(byte[] signature, byte[] witness_script) {
		byte[] ret = bindings.HTLCDescriptor_tx_input_witness(this.ptr, InternalUtils.check_arr_len(signature, 64), witness_script);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(signature);
		Reference.reachabilityFence(witness_script);
		return ret;
	}

	/**
	 * Derives the channel signer required to sign the HTLC input.
	 */
	public EcdsaChannelSigner derive_channel_signer(org.ldk.structs.SignerProvider signer_provider) {
		long ret = bindings.HTLCDescriptor_derive_channel_signer(this.ptr, signer_provider.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(signer_provider);
		if (ret >= 0 && ret <= 4096) { return null; }
		EcdsaChannelSigner ret_hu_conv = new EcdsaChannelSigner(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		if (this != null) { this.ptrs_to.add(signer_provider); };
		return ret_hu_conv;
	}

}
