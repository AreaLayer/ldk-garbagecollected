using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Builds an [`Offer`] for the \"offer to be paid\" flow.
 * 
 * See [module-level documentation] for usage.
 * 
 * [module-level documentation]: self
 */
public class OfferWithExplicitMetadataBuilder : CommonBase {
	internal OfferWithExplicitMetadataBuilder(object _dummy, long ptr) : base(ptr) { }
	~OfferWithExplicitMetadataBuilder() {
		if (ptr != 0) { bindings.OfferWithExplicitMetadataBuilder_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.OfferWithExplicitMetadataBuilder_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OfferWithExplicitMetadataBuilder
	 */
	public OfferWithExplicitMetadataBuilder clone() {
		long ret = bindings.OfferWithExplicitMetadataBuilder_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OfferWithExplicitMetadataBuilder ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OfferWithExplicitMetadataBuilder(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new builder for an offer using the [`Offer::signing_pubkey`] for signing invoices.
	 * The associated secret key must be remembered while the offer is valid.
	 * 
	 * Use a different pubkey per offer to avoid correlating offers.
	 * 
	 * # Note
	 * 
	 * If constructing an [`Offer`] for use with a [`ChannelManager`], use
	 * [`ChannelManager::create_offer_builder`] instead of [`OfferBuilder::new`].
	 * 
	 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
	 * [`ChannelManager::create_offer_builder`]: crate::ln::channelmanager::ChannelManager::create_offer_builder
	 */
	public static OfferWithExplicitMetadataBuilder of(byte[] signing_pubkey) {
		long ret = bindings.OfferWithExplicitMetadataBuilder_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(signing_pubkey, 33)));
		GC.KeepAlive(signing_pubkey);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OfferWithExplicitMetadataBuilder ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OfferWithExplicitMetadataBuilder(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Sets the [`Offer::metadata`] to the given bytes.
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public Result_NoneBolt12SemanticErrorZ metadata(byte[] metadata) {
		long ret = bindings.OfferWithExplicitMetadataBuilder_metadata(this.ptr, InternalUtils.encodeUint8Array(metadata));
		GC.KeepAlive(this);
		GC.KeepAlive(metadata);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Adds the chain hash of the given [`Network`] to [`Offer::chains`]. If not called,
	 * the chain hash of [`Network::Bitcoin`] is assumed to be the only one supported.
	 * 
	 * See [`Offer::chains`] on how this relates to the payment currency.
	 * 
	 * Successive calls to this method will add another chain hash.
	 */
	public void chain(Network network) {
		bindings.OfferWithExplicitMetadataBuilder_chain(this.ptr, network);
		GC.KeepAlive(this);
		GC.KeepAlive(network);
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Sets the [`Offer::amount`] as an [`Amount::Bitcoin`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void amount_msats(long amount_msats) {
		bindings.OfferWithExplicitMetadataBuilder_amount_msats(this.ptr, amount_msats);
		GC.KeepAlive(this);
		GC.KeepAlive(amount_msats);
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Sets the [`Offer::absolute_expiry`] as seconds since the Unix epoch. Any expiry that has
	 * already passed is valid and can be checked for using [`Offer::is_expired`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void absolute_expiry(long absolute_expiry) {
		bindings.OfferWithExplicitMetadataBuilder_absolute_expiry(this.ptr, absolute_expiry);
		GC.KeepAlive(this);
		GC.KeepAlive(absolute_expiry);
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Sets the [`Offer::description`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void description(string description) {
		bindings.OfferWithExplicitMetadataBuilder_description(this.ptr, InternalUtils.encodeString(description));
		GC.KeepAlive(this);
		GC.KeepAlive(description);
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Sets the [`Offer::issuer`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void issuer(string issuer) {
		bindings.OfferWithExplicitMetadataBuilder_issuer(this.ptr, InternalUtils.encodeString(issuer));
		GC.KeepAlive(this);
		GC.KeepAlive(issuer);
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Adds a blinded path to [`Offer::paths`]. Must include at least one path if only connected by
	 * private channels or if [`Offer::signing_pubkey`] is not a public node id.
	 * 
	 * Successive calls to this method will add another blinded path. Caller is responsible for not
	 * adding duplicate paths.
	 */
	public void path(org.ldk.structs.BlindedPath path) {
		bindings.OfferWithExplicitMetadataBuilder_path(this.ptr, path.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(path);
		if (this != null) { this.ptrs_to.AddLast(path); };
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Sets the quantity of items for [`Offer::supported_quantity`]. If not called, defaults to
	 * [`Quantity::One`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void supported_quantity(org.ldk.structs.Quantity quantity) {
		bindings.OfferWithExplicitMetadataBuilder_supported_quantity(this.ptr, quantity.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(quantity);
		if (this != null) { this.ptrs_to.AddLast(quantity); };
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Builds an [`Offer`] from the builder's settings.
	 */
	public Result_OfferBolt12SemanticErrorZ build() {
		long ret = bindings.OfferWithExplicitMetadataBuilder_build(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferBolt12SemanticErrorZ ret_hu_conv = Result_OfferBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
