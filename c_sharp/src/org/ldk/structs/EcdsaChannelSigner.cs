
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of EcdsaChannelSigner */
public interface EcdsaChannelSignerInterface {
	/**Create a signature for a counterparty's commitment transaction and associated HTLC transactions.
	 * 
	 * Policy checks should be implemented in this function, including checking the amount
	 * sent to us and checking the HTLCs.
	 * 
	 * The preimages of outbound and inbound HTLCs that were fulfilled since the last commitment
	 * are provided. A validating signer should ensure that an outbound HTLC output is removed
	 * only when the matching preimage is provided and after the corresponding inbound HTLC has
	 * been removed for forwarded payments.
	 * 
	 * Note that all the relevant preimages will be provided, but there may also be additional
	 * irrelevant or duplicate preimages.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelManager::signer_unblocked`] must be called.
	 * 
	 * [`ChannelManager::signer_unblocked`]: crate::ln::channelmanager::ChannelManager::signer_unblocked
	 */
	Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ sign_counterparty_commitment(CommitmentTransaction commitment_tx, byte[][] inbound_htlc_preimages, byte[][] outbound_htlc_preimages);
	/**Creates a signature for a holder's commitment transaction.
	 * 
	 * This will be called
	 * - with a non-revoked `commitment_tx`.
	 * - with the latest `commitment_tx` when we initiate a force-close.
	 * 
	 * This may be called multiple times for the same transaction.
	 * 
	 * An external signer implementation should check that the commitment has not been revoked.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	Result_ECDSASignatureNoneZ sign_holder_commitment(HolderCommitmentTransaction commitment_tx);
	/**Create a signature for the given input in a transaction spending an HTLC transaction output
	 * or a commitment transaction `to_local` output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * Amount is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder `revocation_secret` to do
	 * so).
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	Result_ECDSASignatureNoneZ sign_justice_revoked_output(byte[] justice_tx, long input, long amount, byte[] per_commitment_key);
	/**Create a signature for the given input in a transaction spending a commitment transaction
	 * HTLC output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * `amount` is the value of the output spent by this input, committed to in the BIP 143
	 * signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder revocation_secret to do
	 * so).
	 * 
	 * `htlc` holds HTLC elements (hash, timelock), thus changing the format of the witness script
	 * (which is committed to in the BIP 143 signatures).
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	Result_ECDSASignatureNoneZ sign_justice_revoked_htlc(byte[] justice_tx, long input, long amount, byte[] per_commitment_key, HTLCOutputInCommitment htlc);
	/**Computes the signature for a commitment transaction's HTLC output used as an input within
	 * `htlc_tx`, which spends the commitment transaction at index `input`. The signature returned
	 * must be be computed using [`EcdsaSighashType::All`].
	 * 
	 * Note that this may be called for HTLCs in the penultimate commitment transaction if a
	 * [`ChannelMonitor`] [replica](https://github.com/lightningdevkit/rust-lightning/blob/main/GLOSSARY.md#monitor-replicas)
	 * broadcasts it before receiving the update for the latest commitment transaction.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`EcdsaSighashType::All`]: bitcoin::sighash::EcdsaSighashType::All
	 * [`ChannelMonitor`]: crate::chain::channelmonitor::ChannelMonitor
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	Result_ECDSASignatureNoneZ sign_holder_htlc_transaction(byte[] htlc_tx, long input, HTLCDescriptor htlc_descriptor);
	/**Create a signature for a claiming transaction for a HTLC output on a counterparty's commitment
	 * transaction, either offered or received.
	 * 
	 * Such a transaction may claim multiples offered outputs at same time if we know the
	 * preimage for each when we create it, but only the input at index `input` should be
	 * signed for here. It may be called multiple times for same output(s) if a fee-bump is
	 * needed with regards to an upcoming timelock expiration.
	 * 
	 * `witness_script` is either an offered or received script as defined in BOLT3 for HTLC
	 * outputs.
	 * 
	 * `amount` is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_point` is the dynamic point corresponding to the channel state
	 * detected onchain. It has been generated by our counterparty and is used to derive
	 * channel state keys, which are then included in the witness script and committed to in the
	 * BIP 143 signature.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	Result_ECDSASignatureNoneZ sign_counterparty_htlc_transaction(byte[] htlc_tx, long input, long amount, byte[] per_commitment_point, HTLCOutputInCommitment htlc);
	/**Create a signature for a (proposed) closing transaction.
	 * 
	 * Note that, due to rounding, there may be one \"missing\" satoshi, and either party may have
	 * chosen to forgo their output as dust.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelManager::signer_unblocked`] must be called.
	 * 
	 * [`ChannelManager::signer_unblocked`]: crate::ln::channelmanager::ChannelManager::signer_unblocked
	 */
	Result_ECDSASignatureNoneZ sign_closing_transaction(ClosingTransaction closing_tx);
	/**Computes the signature for a commitment transaction's anchor output used as an
	 * input within `anchor_tx`, which spends the commitment transaction, at index `input`.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	Result_ECDSASignatureNoneZ sign_holder_anchor_input(byte[] anchor_tx, long input);
	/**Signs a channel announcement message with our funding key proving it comes from one of the
	 * channel participants.
	 * 
	 * Channel announcements also require a signature from each node's network key. Our node
	 * signature is computed through [`NodeSigner::sign_gossip_message`].
	 * 
	 * This method is *not* asynchronous. If an `Err` is returned, the channel will not be
	 * publicly announced and our counterparty may (though likely will not) close the channel on
	 * us for violating the protocol.
	 * 
	 * [`NodeSigner::sign_gossip_message`]: crate::sign::NodeSigner::sign_gossip_message
	 */
	Result_ECDSASignatureNoneZ sign_channel_announcement_with_funding_key(UnsignedChannelAnnouncement msg);
	/**Signs the input of a splicing funding transaction with our funding key.
	 * 
	 * In splicing, the previous funding transaction output is spent as the input of
	 * the new funding transaction, and is a 2-of-2 multisig.
	 * 
	 * `input_index`: The index of the input within the new funding transaction `tx`,
	 * spending the previous funding transaction's output
	 * 
	 * `input_value`: The value of the previous funding transaction output.
	 * 
	 * This method is *not* asynchronous. If an `Err` is returned, the channel will be immediately
	 * closed.
	 */
	Result_ECDSASignatureNoneZ sign_splicing_funding_input(byte[] tx, long input_index, long input_value);
}

/**
 * A trait to sign Lightning channel transactions as described in
 * [BOLT 3](https://github.com/lightning/bolts/blob/master/03-transactions.md).
 * 
 * Signing services could be implemented on a hardware wallet and should implement signing
 * policies in order to be secure. Please refer to the [VLS Policy
 * Controls](https://gitlab.com/lightning-signer/validating-lightning-signer/-/blob/main/docs/policy-controls.md)
 * for an example of such policies.
 * 
 * Like [`ChannelSigner`], many of the methods allow errors to be returned to support async
 * signing. In such cases, the signing operation can be replayed by calling
 * [`ChannelManager::signer_unblocked`] or [`ChainMonitor::signer_unblocked`] (see individual
 * method documentation for which method should be called) once the result is ready, at which
 * point the channel operation will resume.
 * 
 * [`ChannelManager::signer_unblocked`]: crate::ln::channelmanager::ChannelManager::signer_unblocked
 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
 */
public class EcdsaChannelSigner : CommonBase {
	internal bindings.LDKEcdsaChannelSigner bindings_instance;
	internal long instance_idx;

	internal EcdsaChannelSigner(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~EcdsaChannelSigner() {
		if (ptr != 0) { bindings.EcdsaChannelSigner_free(ptr); }
	}

	private class LDKEcdsaChannelSignerHolder { internal EcdsaChannelSigner held; }
	private class LDKEcdsaChannelSignerImpl : bindings.LDKEcdsaChannelSigner {
		internal LDKEcdsaChannelSignerImpl(EcdsaChannelSignerInterface arg, LDKEcdsaChannelSignerHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private EcdsaChannelSignerInterface arg;
		private LDKEcdsaChannelSignerHolder impl_holder;
		public long sign_counterparty_commitment(long _commitment_tx, long _inbound_htlc_preimages, long _outbound_htlc_preimages) {
			org.ldk.structs.CommitmentTransaction _commitment_tx_hu_conv = null; if (_commitment_tx < 0 || _commitment_tx > 4096) { _commitment_tx_hu_conv = new org.ldk.structs.CommitmentTransaction(null, _commitment_tx); }
			int _inbound_htlc_preimages_conv_8_len = InternalUtils.getArrayLength(_inbound_htlc_preimages);
			byte[][] _inbound_htlc_preimages_conv_8_arr = new byte[_inbound_htlc_preimages_conv_8_len][];
			for (int i = 0; i < _inbound_htlc_preimages_conv_8_len; i++) {
				long _inbound_htlc_preimages_conv_8 = InternalUtils.getU64ArrayElem(_inbound_htlc_preimages, i);
				byte[] _inbound_htlc_preimages_conv_8_conv = InternalUtils.decodeUint8Array(_inbound_htlc_preimages_conv_8);
				_inbound_htlc_preimages_conv_8_arr[i] = _inbound_htlc_preimages_conv_8_conv;
			}
			bindings.free_buffer(_inbound_htlc_preimages);
			int _outbound_htlc_preimages_conv_8_len = InternalUtils.getArrayLength(_outbound_htlc_preimages);
			byte[][] _outbound_htlc_preimages_conv_8_arr = new byte[_outbound_htlc_preimages_conv_8_len][];
			for (int i = 0; i < _outbound_htlc_preimages_conv_8_len; i++) {
				long _outbound_htlc_preimages_conv_8 = InternalUtils.getU64ArrayElem(_outbound_htlc_preimages, i);
				byte[] _outbound_htlc_preimages_conv_8_conv = InternalUtils.decodeUint8Array(_outbound_htlc_preimages_conv_8);
				_outbound_htlc_preimages_conv_8_arr[i] = _outbound_htlc_preimages_conv_8_conv;
			}
			bindings.free_buffer(_outbound_htlc_preimages);
			Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ ret = arg.sign_counterparty_commitment(_commitment_tx_hu_conv, _inbound_htlc_preimages_conv_8_arr, _outbound_htlc_preimages_conv_8_arr);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_holder_commitment(long _commitment_tx) {
			org.ldk.structs.HolderCommitmentTransaction _commitment_tx_hu_conv = null; if (_commitment_tx < 0 || _commitment_tx > 4096) { _commitment_tx_hu_conv = new org.ldk.structs.HolderCommitmentTransaction(null, _commitment_tx); }
			Result_ECDSASignatureNoneZ ret = arg.sign_holder_commitment(_commitment_tx_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_justice_revoked_output(long _justice_tx, long _input, long _amount, long _per_commitment_key) {
			byte[] _justice_tx_conv = InternalUtils.decodeUint8Array(_justice_tx);
			byte[] _per_commitment_key_conv = InternalUtils.decodeUint8Array(_per_commitment_key);
			Result_ECDSASignatureNoneZ ret = arg.sign_justice_revoked_output(_justice_tx_conv, _input, _amount, _per_commitment_key_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_justice_revoked_htlc(long _justice_tx, long _input, long _amount, long _per_commitment_key, long _htlc) {
			byte[] _justice_tx_conv = InternalUtils.decodeUint8Array(_justice_tx);
			byte[] _per_commitment_key_conv = InternalUtils.decodeUint8Array(_per_commitment_key);
			org.ldk.structs.HTLCOutputInCommitment _htlc_hu_conv = null; if (_htlc < 0 || _htlc > 4096) { _htlc_hu_conv = new org.ldk.structs.HTLCOutputInCommitment(null, _htlc); }
			Result_ECDSASignatureNoneZ ret = arg.sign_justice_revoked_htlc(_justice_tx_conv, _input, _amount, _per_commitment_key_conv, _htlc_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_holder_htlc_transaction(long _htlc_tx, long _input, long _htlc_descriptor) {
			byte[] _htlc_tx_conv = InternalUtils.decodeUint8Array(_htlc_tx);
			org.ldk.structs.HTLCDescriptor _htlc_descriptor_hu_conv = null; if (_htlc_descriptor < 0 || _htlc_descriptor > 4096) { _htlc_descriptor_hu_conv = new org.ldk.structs.HTLCDescriptor(null, _htlc_descriptor); }
			Result_ECDSASignatureNoneZ ret = arg.sign_holder_htlc_transaction(_htlc_tx_conv, _input, _htlc_descriptor_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_counterparty_htlc_transaction(long _htlc_tx, long _input, long _amount, long _per_commitment_point, long _htlc) {
			byte[] _htlc_tx_conv = InternalUtils.decodeUint8Array(_htlc_tx);
			byte[] _per_commitment_point_conv = InternalUtils.decodeUint8Array(_per_commitment_point);
			org.ldk.structs.HTLCOutputInCommitment _htlc_hu_conv = null; if (_htlc < 0 || _htlc > 4096) { _htlc_hu_conv = new org.ldk.structs.HTLCOutputInCommitment(null, _htlc); }
			Result_ECDSASignatureNoneZ ret = arg.sign_counterparty_htlc_transaction(_htlc_tx_conv, _input, _amount, _per_commitment_point_conv, _htlc_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_closing_transaction(long _closing_tx) {
			org.ldk.structs.ClosingTransaction _closing_tx_hu_conv = null; if (_closing_tx < 0 || _closing_tx > 4096) { _closing_tx_hu_conv = new org.ldk.structs.ClosingTransaction(null, _closing_tx); }
			Result_ECDSASignatureNoneZ ret = arg.sign_closing_transaction(_closing_tx_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_holder_anchor_input(long _anchor_tx, long _input) {
			byte[] _anchor_tx_conv = InternalUtils.decodeUint8Array(_anchor_tx);
			Result_ECDSASignatureNoneZ ret = arg.sign_holder_anchor_input(_anchor_tx_conv, _input);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_channel_announcement_with_funding_key(long _msg) {
			org.ldk.structs.UnsignedChannelAnnouncement _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.UnsignedChannelAnnouncement(null, _msg); }
			Result_ECDSASignatureNoneZ ret = arg.sign_channel_announcement_with_funding_key(_msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_splicing_funding_input(long _tx, long _input_index, long _input_value) {
			byte[] _tx_conv = InternalUtils.decodeUint8Array(_tx);
			Result_ECDSASignatureNoneZ ret = arg.sign_splicing_funding_input(_tx_conv, _input_index, _input_value);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
	}

	/** Creates a new instance of EcdsaChannelSigner from a given implementation */
	public static EcdsaChannelSigner new_impl(EcdsaChannelSignerInterface arg, ChannelSignerInterface channelSigner_impl, ChannelPublicKeys pubkeys) {
		LDKEcdsaChannelSignerHolder impl_holder = new LDKEcdsaChannelSignerHolder();
		LDKEcdsaChannelSignerImpl impl = new LDKEcdsaChannelSignerImpl(arg, impl_holder);
		ChannelSigner channelSigner = ChannelSigner.new_impl(channelSigner_impl, pubkeys);
		long[] ptr_idx = bindings.LDKEcdsaChannelSigner_new(impl, channelSigner.instance_idx, pubkeys.clone_ptr());

		impl_holder.held = new EcdsaChannelSigner(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		impl_holder.held.ptrs_to.AddLast(channelSigner);
		return impl_holder.held;
	}

	/**
	 * Create a signature for a counterparty's commitment transaction and associated HTLC transactions.
	 * 
	 * Policy checks should be implemented in this function, including checking the amount
	 * sent to us and checking the HTLCs.
	 * 
	 * The preimages of outbound and inbound HTLCs that were fulfilled since the last commitment
	 * are provided. A validating signer should ensure that an outbound HTLC output is removed
	 * only when the matching preimage is provided and after the corresponding inbound HTLC has
	 * been removed for forwarded payments.
	 * 
	 * Note that all the relevant preimages will be provided, but there may also be additional
	 * irrelevant or duplicate preimages.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelManager::signer_unblocked`] must be called.
	 * 
	 * [`ChannelManager::signer_unblocked`]: crate::ln::channelmanager::ChannelManager::signer_unblocked
	 */
	public Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ sign_counterparty_commitment(org.ldk.structs.CommitmentTransaction commitment_tx, byte[][] inbound_htlc_preimages, byte[][] outbound_htlc_preimages) {
		long ret = bindings.EcdsaChannelSigner_sign_counterparty_commitment(this.ptr, commitment_tx.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(inbound_htlc_preimages, inbound_htlc_preimages_conv_8 => InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(inbound_htlc_preimages_conv_8, 32)))), InternalUtils.encodeUint64Array(InternalUtils.mapArray(outbound_htlc_preimages, outbound_htlc_preimages_conv_8 => InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(outbound_htlc_preimages_conv_8, 32)))));
		GC.KeepAlive(this);
		GC.KeepAlive(commitment_tx);
		GC.KeepAlive(inbound_htlc_preimages);
		GC.KeepAlive(outbound_htlc_preimages);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ ret_hu_conv = Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(commitment_tx); };
		return ret_hu_conv;
	}

	/**
	 * Creates a signature for a holder's commitment transaction.
	 * 
	 * This will be called
	 * - with a non-revoked `commitment_tx`.
	 * - with the latest `commitment_tx` when we initiate a force-close.
	 * 
	 * This may be called multiple times for the same transaction.
	 * 
	 * An external signer implementation should check that the commitment has not been revoked.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	public Result_ECDSASignatureNoneZ sign_holder_commitment(org.ldk.structs.HolderCommitmentTransaction commitment_tx) {
		long ret = bindings.EcdsaChannelSigner_sign_holder_commitment(this.ptr, commitment_tx.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(commitment_tx);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(commitment_tx); };
		return ret_hu_conv;
	}

	/**
	 * Create a signature for the given input in a transaction spending an HTLC transaction output
	 * or a commitment transaction `to_local` output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * Amount is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder `revocation_secret` to do
	 * so).
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	public Result_ECDSASignatureNoneZ sign_justice_revoked_output(byte[] justice_tx, long input, long amount, byte[] per_commitment_key) {
		long ret = bindings.EcdsaChannelSigner_sign_justice_revoked_output(this.ptr, InternalUtils.encodeUint8Array(justice_tx), input, amount, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(per_commitment_key, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(justice_tx);
		GC.KeepAlive(input);
		GC.KeepAlive(amount);
		GC.KeepAlive(per_commitment_key);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Create a signature for the given input in a transaction spending a commitment transaction
	 * HTLC output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * `amount` is the value of the output spent by this input, committed to in the BIP 143
	 * signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder revocation_secret to do
	 * so).
	 * 
	 * `htlc` holds HTLC elements (hash, timelock), thus changing the format of the witness script
	 * (which is committed to in the BIP 143 signatures).
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	public Result_ECDSASignatureNoneZ sign_justice_revoked_htlc(byte[] justice_tx, long input, long amount, byte[] per_commitment_key, org.ldk.structs.HTLCOutputInCommitment htlc) {
		long ret = bindings.EcdsaChannelSigner_sign_justice_revoked_htlc(this.ptr, InternalUtils.encodeUint8Array(justice_tx), input, amount, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(per_commitment_key, 32)), htlc.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(justice_tx);
		GC.KeepAlive(input);
		GC.KeepAlive(amount);
		GC.KeepAlive(per_commitment_key);
		GC.KeepAlive(htlc);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(htlc); };
		return ret_hu_conv;
	}

	/**
	 * Computes the signature for a commitment transaction's HTLC output used as an input within
	 * `htlc_tx`, which spends the commitment transaction at index `input`. The signature returned
	 * must be be computed using [`EcdsaSighashType::All`].
	 * 
	 * Note that this may be called for HTLCs in the penultimate commitment transaction if a
	 * [`ChannelMonitor`] [replica](https://github.com/lightningdevkit/rust-lightning/blob/main/GLOSSARY.md#monitor-replicas)
	 * broadcasts it before receiving the update for the latest commitment transaction.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`EcdsaSighashType::All`]: bitcoin::sighash::EcdsaSighashType::All
	 * [`ChannelMonitor`]: crate::chain::channelmonitor::ChannelMonitor
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	public Result_ECDSASignatureNoneZ sign_holder_htlc_transaction(byte[] htlc_tx, long input, org.ldk.structs.HTLCDescriptor htlc_descriptor) {
		long ret = bindings.EcdsaChannelSigner_sign_holder_htlc_transaction(this.ptr, InternalUtils.encodeUint8Array(htlc_tx), input, htlc_descriptor.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(htlc_tx);
		GC.KeepAlive(input);
		GC.KeepAlive(htlc_descriptor);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(htlc_descriptor); };
		return ret_hu_conv;
	}

	/**
	 * Create a signature for a claiming transaction for a HTLC output on a counterparty's commitment
	 * transaction, either offered or received.
	 * 
	 * Such a transaction may claim multiples offered outputs at same time if we know the
	 * preimage for each when we create it, but only the input at index `input` should be
	 * signed for here. It may be called multiple times for same output(s) if a fee-bump is
	 * needed with regards to an upcoming timelock expiration.
	 * 
	 * `witness_script` is either an offered or received script as defined in BOLT3 for HTLC
	 * outputs.
	 * 
	 * `amount` is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_point` is the dynamic point corresponding to the channel state
	 * detected onchain. It has been generated by our counterparty and is used to derive
	 * channel state keys, which are then included in the witness script and committed to in the
	 * BIP 143 signature.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	public Result_ECDSASignatureNoneZ sign_counterparty_htlc_transaction(byte[] htlc_tx, long input, long amount, byte[] per_commitment_point, org.ldk.structs.HTLCOutputInCommitment htlc) {
		long ret = bindings.EcdsaChannelSigner_sign_counterparty_htlc_transaction(this.ptr, InternalUtils.encodeUint8Array(htlc_tx), input, amount, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(per_commitment_point, 33)), htlc.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(htlc_tx);
		GC.KeepAlive(input);
		GC.KeepAlive(amount);
		GC.KeepAlive(per_commitment_point);
		GC.KeepAlive(htlc);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(htlc); };
		return ret_hu_conv;
	}

	/**
	 * Create a signature for a (proposed) closing transaction.
	 * 
	 * Note that, due to rounding, there may be one \"missing\" satoshi, and either party may have
	 * chosen to forgo their output as dust.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelManager::signer_unblocked`] must be called.
	 * 
	 * [`ChannelManager::signer_unblocked`]: crate::ln::channelmanager::ChannelManager::signer_unblocked
	 */
	public Result_ECDSASignatureNoneZ sign_closing_transaction(org.ldk.structs.ClosingTransaction closing_tx) {
		long ret = bindings.EcdsaChannelSigner_sign_closing_transaction(this.ptr, closing_tx.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(closing_tx);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(closing_tx); };
		return ret_hu_conv;
	}

	/**
	 * Computes the signature for a commitment transaction's anchor output used as an
	 * input within `anchor_tx`, which spends the commitment transaction, at index `input`.
	 * 
	 * An `Err` can be returned to signal that the signer is unavailable/cannot produce a valid
	 * signature and should be retried later. Once the signer is ready to provide a signature after
	 * previously returning an `Err`, [`ChannelMonitor::signer_unblocked`] must be called on its
	 * monitor or [`ChainMonitor::signer_unblocked`] called to attempt unblocking all monitors.
	 * 
	 * [`ChannelMonitor::signer_unblocked`]: crate::chain::channelmonitor::ChannelMonitor::signer_unblocked
	 * [`ChainMonitor::signer_unblocked`]: crate::chain::chainmonitor::ChainMonitor::signer_unblocked
	 */
	public Result_ECDSASignatureNoneZ sign_holder_anchor_input(byte[] anchor_tx, long input) {
		long ret = bindings.EcdsaChannelSigner_sign_holder_anchor_input(this.ptr, InternalUtils.encodeUint8Array(anchor_tx), input);
		GC.KeepAlive(this);
		GC.KeepAlive(anchor_tx);
		GC.KeepAlive(input);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Signs a channel announcement message with our funding key proving it comes from one of the
	 * channel participants.
	 * 
	 * Channel announcements also require a signature from each node's network key. Our node
	 * signature is computed through [`NodeSigner::sign_gossip_message`].
	 * 
	 * This method is *not* asynchronous. If an `Err` is returned, the channel will not be
	 * publicly announced and our counterparty may (though likely will not) close the channel on
	 * us for violating the protocol.
	 * 
	 * [`NodeSigner::sign_gossip_message`]: crate::sign::NodeSigner::sign_gossip_message
	 */
	public Result_ECDSASignatureNoneZ sign_channel_announcement_with_funding_key(org.ldk.structs.UnsignedChannelAnnouncement msg) {
		long ret = bindings.EcdsaChannelSigner_sign_channel_announcement_with_funding_key(this.ptr, msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Signs the input of a splicing funding transaction with our funding key.
	 * 
	 * In splicing, the previous funding transaction output is spent as the input of
	 * the new funding transaction, and is a 2-of-2 multisig.
	 * 
	 * `input_index`: The index of the input within the new funding transaction `tx`,
	 * spending the previous funding transaction's output
	 * 
	 * `input_value`: The value of the previous funding transaction output.
	 * 
	 * This method is *not* asynchronous. If an `Err` is returned, the channel will be immediately
	 * closed.
	 */
	public Result_ECDSASignatureNoneZ sign_splicing_funding_input(byte[] tx, long input_index, long input_value) {
		long ret = bindings.EcdsaChannelSigner_sign_splicing_funding_input(this.ptr, InternalUtils.encodeUint8Array(tx), input_index, input_value);
		GC.KeepAlive(this);
		GC.KeepAlive(tx);
		GC.KeepAlive(input_index);
		GC.KeepAlive(input_value);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.EcdsaChannelSigner_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of a EcdsaChannelSigner
	 */
	public EcdsaChannelSigner clone() {
		long ret = bindings.EcdsaChannelSigner_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		EcdsaChannelSigner ret_hu_conv = new EcdsaChannelSigner(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
