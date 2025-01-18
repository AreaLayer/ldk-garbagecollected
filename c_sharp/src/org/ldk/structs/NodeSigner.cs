
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of NodeSigner */
public interface NodeSignerInterface {
	/**Get the [`ExpandedKey`] for use in encrypting and decrypting inbound payment data.
	 * 
	 * If the implementor of this trait supports [phantom node payments], then every node that is
	 * intended to be included in the phantom invoice route hints must return the same value from
	 * this method.
	 * 
	 * This method must return the same value each time it is called.
	 * 
	 * [phantom node payments]: PhantomKeysManager
	 */
	ExpandedKey get_inbound_payment_key();
	/**Get node id based on the provided [`Recipient`].
	 * 
	 * This method must return the same value each time it is called with a given [`Recipient`]
	 * parameter.
	 * 
	 * Errors if the [`Recipient`] variant is not supported by the implementation.
	 */
	Result_PublicKeyNoneZ get_node_id(Recipient recipient);
	/**Gets the ECDH shared secret of our node secret and `other_key`, multiplying by `tweak` if
	 * one is provided. Note that this tweak can be applied to `other_key` instead of our node
	 * secret, though this is less efficient.
	 * 
	 * Note that if this fails while attempting to forward an HTLC, LDK will panic. The error
	 * should be resolved to allow LDK to resume forwarding HTLCs.
	 * 
	 * Errors if the [`Recipient`] variant is not supported by the implementation.
	 */
	Result_ThirtyTwoBytesNoneZ ecdh(Recipient recipient, byte[] other_key, Option_BigEndianScalarZ tweak);
	/**Sign an invoice.
	 * 
	 * By parameterizing by the raw invoice bytes instead of the hash, we allow implementors of
	 * this trait to parse the invoice and make sure they're signing what they expect, rather than
	 * blindly signing the hash.
	 * 
	 * The `hrp_bytes` are ASCII bytes, while the `invoice_data` is base32.
	 * 
	 * The secret key used to sign the invoice is dependent on the [`Recipient`].
	 * 
	 * Errors if the [`Recipient`] variant is not supported by the implementation.
	 */
	Result_RecoverableSignatureNoneZ sign_invoice(RawBolt11Invoice invoice, Recipient recipient);
	/**Signs the [`TaggedHash`] of a BOLT 12 invoice.
	 * 
	 * Implementors may check that the `invoice` is expected rather than blindly signing the tagged
	 * hash. An `Ok` result should sign `invoice.tagged_hash().as_digest()` with the node's signing
	 * key or an ephemeral key to preserve privacy, whichever is associated with
	 * [`UnsignedBolt12Invoice::signing_pubkey`].
	 * 
	 * [`TaggedHash`]: crate::offers::merkle::TaggedHash
	 */
	Result_SchnorrSignatureNoneZ sign_bolt12_invoice(UnsignedBolt12Invoice invoice);
	/**Sign a gossip message.
	 * 
	 * Note that if this fails, LDK may panic and the message will not be broadcast to the network
	 * or a possible channel counterparty. If LDK panics, the error should be resolved to allow the
	 * message to be broadcast, as otherwise it may prevent one from receiving funds over the
	 * corresponding channel.
	 */
	Result_ECDSASignatureNoneZ sign_gossip_message(UnsignedGossipMessage msg);
}

/**
 * A trait that can handle cryptographic operations at the scope level of a node.
 */
public class NodeSigner : CommonBase {
	internal bindings.LDKNodeSigner bindings_instance;
	internal long instance_idx;

	internal NodeSigner(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~NodeSigner() {
		if (ptr != 0) { bindings.NodeSigner_free(ptr); }
	}

	private class LDKNodeSignerHolder { internal NodeSigner held; }
	private class LDKNodeSignerImpl : bindings.LDKNodeSigner {
		internal LDKNodeSignerImpl(NodeSignerInterface arg, LDKNodeSignerHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private NodeSignerInterface arg;
		private LDKNodeSignerHolder impl_holder;
		public long get_inbound_payment_key() {
			ExpandedKey ret = arg.get_inbound_payment_key();
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long get_node_id(Recipient _recipient) {
			Result_PublicKeyNoneZ ret = arg.get_node_id(_recipient);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long ecdh(Recipient _recipient, long _other_key, long _tweak) {
			byte[] _other_key_conv = InternalUtils.decodeUint8Array(_other_key);
			org.ldk.structs.Option_BigEndianScalarZ _tweak_hu_conv = org.ldk.structs.Option_BigEndianScalarZ.constr_from_ptr(_tweak);
			if (_tweak_hu_conv != null) { _tweak_hu_conv.ptrs_to.AddLast(this); };
			Result_ThirtyTwoBytesNoneZ ret = arg.ecdh(_recipient, _other_key_conv, _tweak_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_invoice(long _invoice, Recipient _recipient) {
			org.ldk.structs.RawBolt11Invoice _invoice_hu_conv = null; if (_invoice < 0 || _invoice > 4096) { _invoice_hu_conv = new org.ldk.structs.RawBolt11Invoice(null, _invoice); }
			Result_RecoverableSignatureNoneZ ret = arg.sign_invoice(_invoice_hu_conv, _recipient);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_bolt12_invoice(long _invoice) {
			org.ldk.structs.UnsignedBolt12Invoice _invoice_hu_conv = null; if (_invoice < 0 || _invoice > 4096) { _invoice_hu_conv = new org.ldk.structs.UnsignedBolt12Invoice(null, _invoice); }
			Result_SchnorrSignatureNoneZ ret = arg.sign_bolt12_invoice(_invoice_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public long sign_gossip_message(long _msg) {
			org.ldk.structs.UnsignedGossipMessage _msg_hu_conv = org.ldk.structs.UnsignedGossipMessage.constr_from_ptr(_msg);
			if (_msg_hu_conv != null) { _msg_hu_conv.ptrs_to.AddLast(this); };
			Result_ECDSASignatureNoneZ ret = arg.sign_gossip_message(_msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
	}

	/** Creates a new instance of NodeSigner from a given implementation */
	public static NodeSigner new_impl(NodeSignerInterface arg) {
		LDKNodeSignerHolder impl_holder = new LDKNodeSignerHolder();
		LDKNodeSignerImpl impl = new LDKNodeSignerImpl(arg, impl_holder);
		long[] ptr_idx = bindings.LDKNodeSigner_new(impl);

		impl_holder.held = new NodeSigner(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Get the [`ExpandedKey`] for use in encrypting and decrypting inbound payment data.
	 * 
	 * If the implementor of this trait supports [phantom node payments], then every node that is
	 * intended to be included in the phantom invoice route hints must return the same value from
	 * this method.
	 * 
	 * This method must return the same value each time it is called.
	 * 
	 * [phantom node payments]: PhantomKeysManager
	 */
	public ExpandedKey get_inbound_payment_key() {
		long ret = bindings.NodeSigner_get_inbound_payment_key(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ExpandedKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ExpandedKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Get node id based on the provided [`Recipient`].
	 * 
	 * This method must return the same value each time it is called with a given [`Recipient`]
	 * parameter.
	 * 
	 * Errors if the [`Recipient`] variant is not supported by the implementation.
	 */
	public Result_PublicKeyNoneZ get_node_id(Recipient recipient) {
		long ret = bindings.NodeSigner_get_node_id(this.ptr, recipient);
		GC.KeepAlive(this);
		GC.KeepAlive(recipient);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeyNoneZ ret_hu_conv = Result_PublicKeyNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Gets the ECDH shared secret of our node secret and `other_key`, multiplying by `tweak` if
	 * one is provided. Note that this tweak can be applied to `other_key` instead of our node
	 * secret, though this is less efficient.
	 * 
	 * Note that if this fails while attempting to forward an HTLC, LDK will panic. The error
	 * should be resolved to allow LDK to resume forwarding HTLCs.
	 * 
	 * Errors if the [`Recipient`] variant is not supported by the implementation.
	 */
	public Result_ThirtyTwoBytesNoneZ ecdh(Recipient recipient, byte[] other_key, org.ldk.structs.Option_BigEndianScalarZ tweak) {
		long ret = bindings.NodeSigner_ecdh(this.ptr, recipient, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(other_key, 33)), tweak.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(recipient);
		GC.KeepAlive(other_key);
		GC.KeepAlive(tweak);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ThirtyTwoBytesNoneZ ret_hu_conv = Result_ThirtyTwoBytesNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Sign an invoice.
	 * 
	 * By parameterizing by the raw invoice bytes instead of the hash, we allow implementors of
	 * this trait to parse the invoice and make sure they're signing what they expect, rather than
	 * blindly signing the hash.
	 * 
	 * The `hrp_bytes` are ASCII bytes, while the `invoice_data` is base32.
	 * 
	 * The secret key used to sign the invoice is dependent on the [`Recipient`].
	 * 
	 * Errors if the [`Recipient`] variant is not supported by the implementation.
	 */
	public Result_RecoverableSignatureNoneZ sign_invoice(org.ldk.structs.RawBolt11Invoice invoice, Recipient recipient) {
		long ret = bindings.NodeSigner_sign_invoice(this.ptr, invoice.ptr, recipient);
		GC.KeepAlive(this);
		GC.KeepAlive(invoice);
		GC.KeepAlive(recipient);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecoverableSignatureNoneZ ret_hu_conv = Result_RecoverableSignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(invoice); };
		return ret_hu_conv;
	}

	/**
	 * Signs the [`TaggedHash`] of a BOLT 12 invoice.
	 * 
	 * Implementors may check that the `invoice` is expected rather than blindly signing the tagged
	 * hash. An `Ok` result should sign `invoice.tagged_hash().as_digest()` with the node's signing
	 * key or an ephemeral key to preserve privacy, whichever is associated with
	 * [`UnsignedBolt12Invoice::signing_pubkey`].
	 * 
	 * [`TaggedHash`]: crate::offers::merkle::TaggedHash
	 */
	public Result_SchnorrSignatureNoneZ sign_bolt12_invoice(org.ldk.structs.UnsignedBolt12Invoice invoice) {
		long ret = bindings.NodeSigner_sign_bolt12_invoice(this.ptr, invoice.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(invoice);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SchnorrSignatureNoneZ ret_hu_conv = Result_SchnorrSignatureNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(invoice); };
		return ret_hu_conv;
	}

	/**
	 * Sign a gossip message.
	 * 
	 * Note that if this fails, LDK may panic and the message will not be broadcast to the network
	 * or a possible channel counterparty. If LDK panics, the error should be resolved to allow the
	 * message to be broadcast, as otherwise it may prevent one from receiving funds over the
	 * corresponding channel.
	 */
	public Result_ECDSASignatureNoneZ sign_gossip_message(org.ldk.structs.UnsignedGossipMessage msg) {
		long ret = bindings.NodeSigner_sign_gossip_message(this.ptr, msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ECDSASignatureNoneZ ret_hu_conv = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
