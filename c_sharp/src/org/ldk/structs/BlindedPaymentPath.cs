using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A blinded path to be used for sending or receiving a payment, hiding the identity of the
 * recipient.
 */
public class BlindedPaymentPath : CommonBase {
	internal BlindedPaymentPath(object _dummy, long ptr) : base(ptr) { }
	~BlindedPaymentPath() {
		if (ptr != 0) { bindings.BlindedPaymentPath_free(ptr); }
	}

	/**
	 * The [`BlindedPayInfo`] used to pay this blinded path.
	 */
	public BlindedPayInfo get_payinfo() {
		long ret = bindings.BlindedPaymentPath_get_payinfo(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPayInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPayInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The [`BlindedPayInfo`] used to pay this blinded path.
	 */
	public void set_payinfo(org.ldk.structs.BlindedPayInfo val) {
		bindings.BlindedPaymentPath_set_payinfo(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = bindings.BlindedPaymentPath_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BlindedPaymentPath
	 */
	public BlindedPaymentPath clone() {
		long ret = bindings.BlindedPaymentPath_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPaymentPath ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPaymentPath(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the BlindedPaymentPath.
	 */
	public long hash() {
		long ret = bindings.BlindedPaymentPath_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two BlindedPaymentPaths contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.BlindedPaymentPath b) {
		bool ret = bindings.BlindedPaymentPath_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is BlindedPaymentPath)) return false;
		return this.eq((BlindedPaymentPath)o);
	}
	/**
	 * Create a one-hop blinded path for a payment.
	 */
	public static Result_BlindedPaymentPathNoneZ one_hop(byte[] payee_node_id, org.ldk.structs.ReceiveTlvs payee_tlvs, short min_final_cltv_expiry_delta, org.ldk.structs.EntropySource entropy_source) {
		long ret = bindings.BlindedPaymentPath_one_hop(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payee_node_id, 33)), payee_tlvs.ptr, min_final_cltv_expiry_delta, entropy_source.ptr);
		GC.KeepAlive(payee_node_id);
		GC.KeepAlive(payee_tlvs);
		GC.KeepAlive(min_final_cltv_expiry_delta);
		GC.KeepAlive(entropy_source);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPaymentPathNoneZ ret_hu_conv = Result_BlindedPaymentPathNoneZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Create a blinded path for a payment, to be forwarded along `intermediate_nodes`.
	 * 
	 * Errors if:
	 * a provided node id is invalid
	 * [`BlindedPayInfo`] calculation results in an integer overflow
	 * any unknown features are required in the provided [`ForwardTlvs`]
	 */
	public static Result_BlindedPaymentPathNoneZ of(PaymentForwardNode[] intermediate_nodes, byte[] payee_node_id, org.ldk.structs.ReceiveTlvs payee_tlvs, long htlc_maximum_msat, short min_final_cltv_expiry_delta, org.ldk.structs.EntropySource entropy_source) {
		long ret = bindings.BlindedPaymentPath_new(InternalUtils.encodeUint64Array(InternalUtils.mapArray(intermediate_nodes, intermediate_nodes_conv_20 => intermediate_nodes_conv_20.ptr)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payee_node_id, 33)), payee_tlvs.ptr, htlc_maximum_msat, min_final_cltv_expiry_delta, entropy_source.ptr);
		GC.KeepAlive(intermediate_nodes);
		GC.KeepAlive(payee_node_id);
		GC.KeepAlive(payee_tlvs);
		GC.KeepAlive(htlc_maximum_msat);
		GC.KeepAlive(min_final_cltv_expiry_delta);
		GC.KeepAlive(entropy_source);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPaymentPathNoneZ ret_hu_conv = Result_BlindedPaymentPathNoneZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Returns the introduction [`NodeId`] of the blinded path, if it is publicly reachable (i.e.,
	 * it is found in the network graph).
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public NodeId public_introduction_node_id(org.ldk.structs.ReadOnlyNetworkGraph network_graph) {
		long ret = bindings.BlindedPaymentPath_public_introduction_node_id(this.ptr, network_graph.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(network_graph);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		if (this != null) { this.ptrs_to.AddLast(network_graph); };
		return ret_hu_conv;
	}

	/**
	 * The [`IntroductionNode`] of the blinded path.
	 */
	public IntroductionNode introduction_node() {
		long ret = bindings.BlindedPaymentPath_introduction_node(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.IntroductionNode ret_hu_conv = org.ldk.structs.IntroductionNode.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Used by the [`IntroductionNode`] to decrypt its [`encrypted_payload`] to forward the payment.
	 * 
	 * [`encrypted_payload`]: BlindedHop::encrypted_payload
	 */
	public byte[] blinding_point() {
		long ret = bindings.BlindedPaymentPath_blinding_point(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The [`BlindedHop`]s within the blinded path.
	 */
	public BlindedHop[] blinded_hops() {
		long ret = bindings.BlindedPaymentPath_blinded_hops(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_12_len = InternalUtils.getArrayLength(ret);
		BlindedHop[] ret_conv_12_arr = new BlindedHop[ret_conv_12_len];
		for (int m = 0; m < ret_conv_12_len; m++) {
			long ret_conv_12 = InternalUtils.getU64ArrayElem(ret, m);
			org.ldk.structs.BlindedHop ret_conv_12_hu_conv = null; if (ret_conv_12 < 0 || ret_conv_12 > 4096) { ret_conv_12_hu_conv = new org.ldk.structs.BlindedHop(null, ret_conv_12); }
			if (ret_conv_12_hu_conv != null) { ret_conv_12_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_12_arr[m] = ret_conv_12_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_12_arr;
	}

	/**
	 * Advance the blinded onion payment path by one hop, making the second hop into the new
	 * introduction node.
	 * 
	 * Will only modify `self` when returning `Ok`.
	 */
	public Result_NoneNoneZ advance_path_by_one(org.ldk.structs.NodeSigner node_signer, org.ldk.structs.NodeIdLookUp node_id_lookup) {
		long ret = bindings.BlindedPaymentPath_advance_path_by_one(this.ptr, node_signer.ptr, node_id_lookup.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(node_signer);
		GC.KeepAlive(node_id_lookup);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(node_signer); };
		if (this != null) { this.ptrs_to.AddLast(node_id_lookup); };
		return ret_hu_conv;
	}

}
} } }
