package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Builds an [`Offer`] for the \"offer to be paid\" flow.
 * 
 * See [module-level documentation] for usage.
 * 
 * [module-level documentation]: self
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class OfferWithExplicitMetadataBuilder extends CommonBase {
	OfferWithExplicitMetadataBuilder(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.OfferWithExplicitMetadataBuilder_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.OfferWithExplicitMetadataBuilder_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the OfferWithExplicitMetadataBuilder
	 */
	public OfferWithExplicitMetadataBuilder clone() {
		long ret = bindings.OfferWithExplicitMetadataBuilder_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OfferWithExplicitMetadataBuilder ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OfferWithExplicitMetadataBuilder(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new builder for an offer using the `signing_pubkey` for signing invoices. The
	 * associated secret key must be remembered while the offer is valid.
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
		long ret = bindings.OfferWithExplicitMetadataBuilder_new(InternalUtils.check_arr_len(signing_pubkey, 33));
		Reference.reachabilityFence(signing_pubkey);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OfferWithExplicitMetadataBuilder ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OfferWithExplicitMetadataBuilder(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Sets the [`Offer::metadata`] to the given bytes.
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public Result_NoneBolt12SemanticErrorZ metadata(byte[] metadata) {
		long ret = bindings.OfferWithExplicitMetadataBuilder_metadata(this.ptr, metadata);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(metadata);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
		;
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
	public void chain(org.ldk.enums.Network network) {
		bindings.OfferWithExplicitMetadataBuilder_chain(this.ptr, network);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(network);
		;
	}

	/**
	 * Sets the [`Offer::amount`] as an [`Amount::Bitcoin`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void amount_msats(long amount_msats) {
		bindings.OfferWithExplicitMetadataBuilder_amount_msats(this.ptr, amount_msats);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(amount_msats);
		;
	}

	/**
	 * Sets the [`Offer::absolute_expiry`] as seconds since the Unix epoch.
	 * Any expiry that has already passed is valid and can be checked for using [`Offer::is_expired`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void absolute_expiry(long absolute_expiry) {
		bindings.OfferWithExplicitMetadataBuilder_absolute_expiry(this.ptr, absolute_expiry);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(absolute_expiry);
		;
	}

	/**
	 * Sets the [`Offer::description`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void description(java.lang.String description) {
		bindings.OfferWithExplicitMetadataBuilder_description(this.ptr, description);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(description);
		;
	}

	/**
	 * Sets the [`Offer::issuer`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void issuer(java.lang.String issuer) {
		bindings.OfferWithExplicitMetadataBuilder_issuer(this.ptr, issuer);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(issuer);
		;
	}

	/**
	 * Adds a blinded path to [`Offer::paths`]. Must include at least one path if only connected by
	 * private channels or if [`Offer::issuer_signing_pubkey`] is not a public node id.
	 * 
	 * Successive calls to this method will add another blinded path. Caller is responsible for not
	 * adding duplicate paths.
	 */
	public void path(org.ldk.structs.BlindedMessagePath path) {
		bindings.OfferWithExplicitMetadataBuilder_path(this.ptr, path.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(path);
		;
	}

	/**
	 * Sets the quantity of items for [`Offer::supported_quantity`]. If not called, defaults to
	 * [`Quantity::One`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void supported_quantity(org.ldk.structs.Quantity quantity) {
		bindings.OfferWithExplicitMetadataBuilder_supported_quantity(this.ptr, quantity.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(quantity);
		;
	}

	/**
	 * Builds an [`Offer`] from the builder's settings.
	 */
	public Result_OfferBolt12SemanticErrorZ build() {
		long ret = bindings.OfferWithExplicitMetadataBuilder_build(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferBolt12SemanticErrorZ ret_hu_conv = Result_OfferBolt12SemanticErrorZ.constr_from_ptr(ret);
		;
		return ret_hu_conv;
	}

}
