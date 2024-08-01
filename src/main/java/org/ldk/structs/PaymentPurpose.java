package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Some information provided on receipt of payment depends on whether the payment received is a
 * spontaneous payment or a \"conventional\" lightning payment that's paying an invoice.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class PaymentPurpose extends CommonBase {
	private PaymentPurpose(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.PaymentPurpose_free(ptr); }
	}
	static PaymentPurpose constr_from_ptr(long ptr) {
		bindings.LDKPaymentPurpose raw_val = bindings.LDKPaymentPurpose_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKPaymentPurpose.Bolt11InvoicePayment.class) {
			return new Bolt11InvoicePayment(ptr, (bindings.LDKPaymentPurpose.Bolt11InvoicePayment)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKPaymentPurpose.Bolt12OfferPayment.class) {
			return new Bolt12OfferPayment(ptr, (bindings.LDKPaymentPurpose.Bolt12OfferPayment)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKPaymentPurpose.Bolt12RefundPayment.class) {
			return new Bolt12RefundPayment(ptr, (bindings.LDKPaymentPurpose.Bolt12RefundPayment)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKPaymentPurpose.SpontaneousPayment.class) {
			return new SpontaneousPayment(ptr, (bindings.LDKPaymentPurpose.SpontaneousPayment)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A payment for a BOLT 11 invoice.
	 */
	public final static class Bolt11InvoicePayment extends PaymentPurpose {
		/**
		 * The preimage to the payment_hash, if the payment hash (and secret) were fetched via
		 * [`ChannelManager::create_inbound_payment`]. When handling [`Event::PaymentClaimable`],
		 * this can be passed directly to [`ChannelManager::claim_funds`] to claim the payment. No
		 * action is needed when seen in [`Event::PaymentClaimed`].
		 * 
		 * [`ChannelManager::create_inbound_payment`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		*/
		public final org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage;
		/**
		 * The \"payment secret\". This authenticates the sender to the recipient, preventing a
		 * number of deanonymization attacks during the routing process.
		 * It is provided here for your reference, however its accuracy is enforced directly by
		 * [`ChannelManager`] using the values you previously provided to
		 * [`ChannelManager::create_inbound_payment`] or
		 * [`ChannelManager::create_inbound_payment_for_hash`].
		 * 
		 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
		 * [`ChannelManager::create_inbound_payment`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment
		 * [`ChannelManager::create_inbound_payment_for_hash`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment_for_hash
		*/
		public final byte[] payment_secret;
		private Bolt11InvoicePayment(long ptr, bindings.LDKPaymentPurpose.Bolt11InvoicePayment obj) {
			super(null, ptr);
			long payment_preimage = obj.payment_preimage;
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_preimage);
			if (payment_preimage_hu_conv != null) { payment_preimage_hu_conv.ptrs_to.add(this); };
			this.payment_preimage = payment_preimage_hu_conv;
			this.payment_secret = obj.payment_secret;
		}
	}
	/**
	 * A payment for a BOLT 12 [`Offer`].
	 * 
	 * [`Offer`]: crate::offers::offer::Offer
	 */
	public final static class Bolt12OfferPayment extends PaymentPurpose {
		/**
		 * The preimage to the payment hash. When handling [`Event::PaymentClaimable`], this can be
		 * passed directly to [`ChannelManager::claim_funds`], if provided. No action is needed
		 * when seen in [`Event::PaymentClaimed`].
		 * 
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		*/
		public final org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage;
		/**
		 * The secret used to authenticate the sender to the recipient, preventing a number of
		 * de-anonymization attacks while routing a payment.
		 * 
		 * See [`PaymentPurpose::Bolt11InvoicePayment::payment_secret`] for further details.
		*/
		public final byte[] payment_secret;
		/**
		 * The context of the payment such as information about the corresponding [`Offer`] and
		 * [`InvoiceRequest`].
		 * 
		 * [`Offer`]: crate::offers::offer::Offer
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		*/
		public final org.ldk.structs.Bolt12OfferContext payment_context;
		private Bolt12OfferPayment(long ptr, bindings.LDKPaymentPurpose.Bolt12OfferPayment obj) {
			super(null, ptr);
			long payment_preimage = obj.payment_preimage;
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_preimage);
			if (payment_preimage_hu_conv != null) { payment_preimage_hu_conv.ptrs_to.add(this); };
			this.payment_preimage = payment_preimage_hu_conv;
			this.payment_secret = obj.payment_secret;
			long payment_context = obj.payment_context;
			org.ldk.structs.Bolt12OfferContext payment_context_hu_conv = null; if (payment_context < 0 || payment_context > 4096) { payment_context_hu_conv = new org.ldk.structs.Bolt12OfferContext(null, payment_context); }
			if (payment_context_hu_conv != null) { payment_context_hu_conv.ptrs_to.add(this); };
			this.payment_context = payment_context_hu_conv;
		}
	}
	/**
	 * A payment for a BOLT 12 [`Refund`].
	 * 
	 * [`Refund`]: crate::offers::refund::Refund
	 */
	public final static class Bolt12RefundPayment extends PaymentPurpose {
		/**
		 * The preimage to the payment hash. When handling [`Event::PaymentClaimable`], this can be
		 * passed directly to [`ChannelManager::claim_funds`], if provided. No action is needed
		 * when seen in [`Event::PaymentClaimed`].
		 * 
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		*/
		public final org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage;
		/**
		 * The secret used to authenticate the sender to the recipient, preventing a number of
		 * de-anonymization attacks while routing a payment.
		 * 
		 * See [`PaymentPurpose::Bolt11InvoicePayment::payment_secret`] for further details.
		*/
		public final byte[] payment_secret;
		/**
		 * The context of the payment such as information about the corresponding [`Refund`].
		 * 
		 * [`Refund`]: crate::offers::refund::Refund
		*/
		public final org.ldk.structs.Bolt12RefundContext payment_context;
		private Bolt12RefundPayment(long ptr, bindings.LDKPaymentPurpose.Bolt12RefundPayment obj) {
			super(null, ptr);
			long payment_preimage = obj.payment_preimage;
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_preimage);
			if (payment_preimage_hu_conv != null) { payment_preimage_hu_conv.ptrs_to.add(this); };
			this.payment_preimage = payment_preimage_hu_conv;
			this.payment_secret = obj.payment_secret;
			long payment_context = obj.payment_context;
			org.ldk.structs.Bolt12RefundContext payment_context_hu_conv = null; if (payment_context < 0 || payment_context > 4096) { payment_context_hu_conv = new org.ldk.structs.Bolt12RefundContext(null, payment_context); }
			if (payment_context_hu_conv != null) { payment_context_hu_conv.ptrs_to.add(this); };
			this.payment_context = payment_context_hu_conv;
		}
	}
	/**
	 * Because this is a spontaneous payment, the payer generated their own preimage rather than us
	 * (the payee) providing a preimage.
	 */
	public final static class SpontaneousPayment extends PaymentPurpose {
		public final byte[] spontaneous_payment;
		private SpontaneousPayment(long ptr, bindings.LDKPaymentPurpose.SpontaneousPayment obj) {
			super(null, ptr);
			this.spontaneous_payment = obj.spontaneous_payment;
		}
	}
	long clone_ptr() {
		long ret = bindings.PaymentPurpose_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentPurpose
	 */
	public PaymentPurpose clone() {
		long ret = bindings.PaymentPurpose_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bolt11InvoicePayment-variant PaymentPurpose
	 */
	public static PaymentPurpose bolt11_invoice_payment(org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage, byte[] payment_secret) {
		long ret = bindings.PaymentPurpose_bolt11_invoice_payment(payment_preimage.ptr, InternalUtils.check_arr_len(payment_secret, 32));
		Reference.reachabilityFence(payment_preimage);
		Reference.reachabilityFence(payment_secret);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bolt12OfferPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose bolt12_offer_payment(org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage, byte[] payment_secret, org.ldk.structs.Bolt12OfferContext payment_context) {
		long ret = bindings.PaymentPurpose_bolt12_offer_payment(payment_preimage.ptr, InternalUtils.check_arr_len(payment_secret, 32), payment_context.ptr);
		Reference.reachabilityFence(payment_preimage);
		Reference.reachabilityFence(payment_secret);
		Reference.reachabilityFence(payment_context);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bolt12RefundPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose bolt12_refund_payment(org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage, byte[] payment_secret, org.ldk.structs.Bolt12RefundContext payment_context) {
		long ret = bindings.PaymentPurpose_bolt12_refund_payment(payment_preimage.ptr, InternalUtils.check_arr_len(payment_secret, 32), payment_context.ptr);
		Reference.reachabilityFence(payment_preimage);
		Reference.reachabilityFence(payment_secret);
		Reference.reachabilityFence(payment_context);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SpontaneousPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose spontaneous_payment(byte[] a) {
		long ret = bindings.PaymentPurpose_spontaneous_payment(InternalUtils.check_arr_len(a, 32));
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two PaymentPurposes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.PaymentPurpose b) {
		boolean ret = bindings.PaymentPurpose_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof PaymentPurpose)) return false;
		return this.eq((PaymentPurpose)o);
	}
	/**
	 * Returns the preimage for this payment, if it is known.
	 */
	public Option_ThirtyTwoBytesZ preimage() {
		long ret = bindings.PaymentPurpose_preimage(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ThirtyTwoBytesZ ret_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the PaymentPurpose object into a byte array which can be read by PaymentPurpose_read
	 */
	public byte[] write() {
		byte[] ret = bindings.PaymentPurpose_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a PaymentPurpose from a byte array, created by PaymentPurpose_write
	 */
	public static Result_PaymentPurposeDecodeErrorZ read(byte[] ser) {
		long ret = bindings.PaymentPurpose_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentPurposeDecodeErrorZ ret_hu_conv = Result_PaymentPurposeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
