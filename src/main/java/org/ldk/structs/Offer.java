package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An `Offer` is a potentially long-lived proposal for payment of a good or service.
 * 
 * An offer is a precursor to an [`InvoiceRequest`]. A merchant publishes an offer from which a
 * customer may request an [`Bolt12Invoice`] for a specific quantity and using an amount sufficient
 * to cover that quantity (i.e., at least `quantity * amount`). See [`Offer::amount`].
 * 
 * Offers may be denominated in currency other than bitcoin but are ultimately paid using the
 * latter.
 * 
 * Through the use of [`BlindedPath`]s, offers provide recipient privacy.
 * 
 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Offer extends CommonBase {
	Offer(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Offer_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.Offer_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Offer
	 */
	public Offer clone() {
		long ret = bindings.Offer_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Offer ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Offer(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The chains that may be used when paying a requested invoice (e.g., bitcoin mainnet).
	 * Payments must be denominated in units of the minimal lightning-payable unit (e.g., msats)
	 * for the selected chain.
	 */
	public byte[][] chains() {
		byte[][] ret = bindings.Offer_chains(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Opaque bytes set by the originator. Useful for authentication and validating fields since it
	 * is reflected in `invoice_request` messages along with all the other fields from the `offer`.
	 */
	public Option_CVec_u8ZZ metadata() {
		long ret = bindings.Offer_metadata(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_u8ZZ ret_hu_conv = org.ldk.structs.Option_CVec_u8ZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The minimum amount required for a successful payment of a single item.
	 */
	public Option_AmountZ amount() {
		long ret = bindings.Offer_amount(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AmountZ ret_hu_conv = org.ldk.structs.Option_AmountZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * A complete description of the purpose of the payment. Intended to be displayed to the user
	 * but with the caveat that it has not been verified in any way.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public PrintableString description() {
		long ret = bindings.Offer_description(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Features pertaining to the offer.
	 */
	public OfferFeatures offer_features() {
		long ret = bindings.Offer_offer_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OfferFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OfferFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Duration since the Unix epoch when an invoice should no longer be requested.
	 * 
	 * If `None`, the offer does not expire.
	 */
	public Option_u64Z absolute_expiry() {
		long ret = bindings.Offer_absolute_expiry(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The issuer of the offer, possibly beginning with `user@domain` or `domain`. Intended to be
	 * displayed to the user but with the caveat that it has not been verified in any way.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public PrintableString issuer() {
		long ret = bindings.Offer_issuer(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Paths to the recipient originating from publicly reachable nodes. Blinded paths provide
	 * recipient privacy by obfuscating its node id.
	 */
	public BlindedPath[] paths() {
		long[] ret = bindings.Offer_paths(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_13_len = ret.length;
		BlindedPath[] ret_conv_13_arr = new BlindedPath[ret_conv_13_len];
		for (int n = 0; n < ret_conv_13_len; n++) {
			long ret_conv_13 = ret[n];
			org.ldk.structs.BlindedPath ret_conv_13_hu_conv = null; if (ret_conv_13 < 0 || ret_conv_13 > 4096) { ret_conv_13_hu_conv = new org.ldk.structs.BlindedPath(null, ret_conv_13); }
			if (ret_conv_13_hu_conv != null) { ret_conv_13_hu_conv.ptrs_to.add(this); };
			ret_conv_13_arr[n] = ret_conv_13_hu_conv;
		}
		return ret_conv_13_arr;
	}

	/**
	 * The quantity of items supported.
	 */
	public Quantity supported_quantity() {
		long ret = bindings.Offer_supported_quantity(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The public key used by the recipient to sign invoices.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public byte[] signing_pubkey() {
		byte[] ret = bindings.Offer_signing_pubkey(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Returns the id of the offer.
	 */
	public OfferId id() {
		long ret = bindings.Offer_id(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OfferId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OfferId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns whether the given chain is supported by the offer.
	 */
	public boolean supports_chain(byte[] chain) {
		boolean ret = bindings.Offer_supports_chain(this.ptr, InternalUtils.check_arr_len(chain, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(chain);
		return ret;
	}

	/**
	 * Whether the offer has expired.
	 */
	public boolean is_expired() {
		boolean ret = bindings.Offer_is_expired(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Whether the offer has expired given the duration since the Unix epoch.
	 */
	public boolean is_expired_no_std(long duration_since_epoch) {
		boolean ret = bindings.Offer_is_expired_no_std(this.ptr, duration_since_epoch);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(duration_since_epoch);
		return ret;
	}

	/**
	 * Returns whether the given quantity is valid for the offer.
	 */
	public boolean is_valid_quantity(long quantity) {
		boolean ret = bindings.Offer_is_valid_quantity(this.ptr, quantity);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(quantity);
		return ret;
	}

	/**
	 * Returns whether a quantity is expected in an [`InvoiceRequest`] for the offer.
	 * 
	 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
	 */
	public boolean expects_quantity() {
		boolean ret = bindings.Offer_expects_quantity(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Similar to [`Offer::request_invoice`] except it:
	 * - derives the [`InvoiceRequest::payer_id`] such that a different key can be used for each
	 * request,
	 * - sets [`InvoiceRequest::payer_metadata`] when [`InvoiceRequestBuilder::build`] is called
	 * such that it can be used by [`Bolt12Invoice::verify`] to determine if the invoice was
	 * requested using a base [`ExpandedKey`] from which the payer id was derived, and
	 * - includes the [`PaymentId`] encrypted in [`InvoiceRequest::payer_metadata`] so that it can
	 * be used when sending the payment for the requested invoice.
	 * 
	 * Useful to protect the sender's privacy.
	 * 
	 * [`InvoiceRequest::payer_id`]: crate::offers::invoice_request::InvoiceRequest::payer_id
	 * [`InvoiceRequest::payer_metadata`]: crate::offers::invoice_request::InvoiceRequest::payer_metadata
	 * [`Bolt12Invoice::verify`]: crate::offers::invoice::Bolt12Invoice::verify
	 * [`ExpandedKey`]: crate::ln::inbound_payment::ExpandedKey
	 */
	public Result_InvoiceRequestWithDerivedPayerIdBuilderBolt12SemanticErrorZ request_invoice_deriving_payer_id(org.ldk.structs.ExpandedKey expanded_key, org.ldk.structs.EntropySource entropy_source, byte[] payment_id) {
		long ret = bindings.Offer_request_invoice_deriving_payer_id(this.ptr, expanded_key.ptr, entropy_source.ptr, InternalUtils.check_arr_len(payment_id, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(expanded_key);
		Reference.reachabilityFence(entropy_source);
		Reference.reachabilityFence(payment_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestWithDerivedPayerIdBuilderBolt12SemanticErrorZ ret_hu_conv = Result_InvoiceRequestWithDerivedPayerIdBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(expanded_key); };
		if (this != null) { this.ptrs_to.add(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Similar to [`Offer::request_invoice_deriving_payer_id`] except uses `payer_id` for the
	 * [`InvoiceRequest::payer_id`] instead of deriving a different key for each request.
	 * 
	 * Useful for recurring payments using the same `payer_id` with different invoices.
	 * 
	 * [`InvoiceRequest::payer_id`]: crate::offers::invoice_request::InvoiceRequest::payer_id
	 */
	public Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ request_invoice_deriving_metadata(byte[] payer_id, org.ldk.structs.ExpandedKey expanded_key, org.ldk.structs.EntropySource entropy_source, byte[] payment_id) {
		long ret = bindings.Offer_request_invoice_deriving_metadata(this.ptr, InternalUtils.check_arr_len(payer_id, 33), expanded_key.ptr, entropy_source.ptr, InternalUtils.check_arr_len(payment_id, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(payer_id);
		Reference.reachabilityFence(expanded_key);
		Reference.reachabilityFence(entropy_source);
		Reference.reachabilityFence(payment_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ ret_hu_conv = Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(expanded_key); };
		if (this != null) { this.ptrs_to.add(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Creates an [`InvoiceRequestBuilder`] for the offer with the given `metadata` and `payer_id`,
	 * which will be reflected in the `Bolt12Invoice` response.
	 * 
	 * The `metadata` is useful for including information about the derivation of `payer_id` such
	 * that invoice response handling can be stateless. Also serves as payer-provided entropy while
	 * hashing in the signature calculation.
	 * 
	 * This should not leak any information such as by using a simple BIP-32 derivation path.
	 * Otherwise, payments may be correlated.
	 * 
	 * Errors if the offer contains unknown required features.
	 * 
	 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
	 */
	public Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ request_invoice(byte[] metadata, byte[] payer_id) {
		long ret = bindings.Offer_request_invoice(this.ptr, metadata, InternalUtils.check_arr_len(payer_id, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(metadata);
		Reference.reachabilityFence(payer_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ ret_hu_conv = Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Offer.
	 */
	public long hash() {
		long ret = bindings.Offer_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Serialize the Offer object into a byte array which can be read by Offer_read
	 */
	public byte[] write() {
		byte[] ret = bindings.Offer_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a Offer object from a string
	 */
	public static Result_OfferBolt12ParseErrorZ from_str(java.lang.String s) {
		long ret = bindings.Offer_from_str(s);
		Reference.reachabilityFence(s);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferBolt12ParseErrorZ ret_hu_conv = Result_OfferBolt12ParseErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
