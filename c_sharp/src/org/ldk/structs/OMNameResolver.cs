using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A stateful resolver which maps BIP 353 Human Readable Names to URIs and BOLT12 [`Offer`]s.
 * 
 * It does not directly implement [`DNSResolverMessageHandler`] but implements all the core logic
 * which is required in a client which intends to.
 * 
 * It relies on being made aware of the passage of time with regular calls to
 * [`Self::new_best_block`] in order to time out existing queries. Queries time out after two
 * blocks.
 */
public class OMNameResolver : CommonBase {
	internal OMNameResolver(object _dummy, long ptr) : base(ptr) { }
	~OMNameResolver() {
		if (ptr != 0) { bindings.OMNameResolver_free(ptr); }
	}

	/**
	 * Builds a new [`OMNameResolver`].
	 */
	public static org.ldk.structs.OMNameResolver of(int latest_block_time, int latest_block_height) {
		long ret = bindings.OMNameResolver_new(latest_block_time, latest_block_height);
		GC.KeepAlive(latest_block_time);
		GC.KeepAlive(latest_block_height);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OMNameResolver ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OMNameResolver(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Informs the [`OMNameResolver`] of the passage of time in the form of a new best Bitcoin
	 * block.
	 * 
	 * This will call back to resolve some pending queries which have timed out.
	 */
	public void new_best_block(int height, int time) {
		bindings.OMNameResolver_new_best_block(this.ptr, height, time);
		GC.KeepAlive(this);
		GC.KeepAlive(height);
		GC.KeepAlive(time);
	}

	/**
	 * Begins the process of resolving a BIP 353 Human Readable Name.
	 * 
	 * Returns a [`DNSSECQuery`] onion message and a [`DNSResolverContext`] which should be sent
	 * to a resolver (with the context used to generate the blinded response path) on success.
	 */
	public org.ldk.structs.Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ resolve_name(byte[] payment_id, org.ldk.structs.HumanReadableName name, org.ldk.structs.EntropySource entropy_source) {
		long ret = bindings.OMNameResolver_resolve_name(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)), name.ptr, entropy_source.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(payment_id);
		GC.KeepAlive(name);
		GC.KeepAlive(entropy_source);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ ret_hu_conv = Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Handles a [`DNSSECProof`] message, attempting to verify it and match it against a pending
	 * query.
	 * 
	 * If verification succeeds, the resulting bitcoin: URI is parsed to find a contained
	 * [`Offer`].
	 * 
	 * Note that a single proof for a wildcard DNS entry may complete several requests for
	 * different [`HumanReadableName`]s.
	 * 
	 * If an [`Offer`] is found, it, as well as the [`PaymentId`] and original `name` passed to
	 * [`Self::resolve_name`] are returned.
	 */
	public org.ldk.structs.Option_C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZZ handle_dnssec_proof_for_offer(org.ldk.structs.DNSSECProof msg, org.ldk.structs.DNSResolverContext context) {
		long ret = bindings.OMNameResolver_handle_dnssec_proof_for_offer(this.ptr, msg.ptr, context.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		GC.KeepAlive(context);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Handles a [`DNSSECProof`] message, attempting to verify it and match it against any pending
	 * queries.
	 * 
	 * If verification succeeds, all matching [`PaymentId`] and [`HumanReadableName`]s passed to
	 * [`Self::resolve_name`], as well as the resolved bitcoin: URI are returned.
	 * 
	 * Note that a single proof for a wildcard DNS entry may complete several requests for
	 * different [`HumanReadableName`]s.
	 * 
	 * This method is useful for those who handle bitcoin: URIs already, handling more than just
	 * BOLT12 [`Offer`]s.
	 */
	public org.ldk.structs.Option_C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZZ handle_dnssec_proof_for_uri(org.ldk.structs.DNSSECProof msg, org.ldk.structs.DNSResolverContext context) {
		long ret = bindings.OMNameResolver_handle_dnssec_proof_for_uri(this.ptr, msg.ptr, context.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		GC.KeepAlive(context);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
