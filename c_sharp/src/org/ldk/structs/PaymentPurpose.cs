using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Some information provided on receipt of payment depends on whether the payment received is a
 * spontaneous payment or a \"conventional\" lightning payment that's paying an invoice.
 */
public class PaymentPurpose : CommonBase {
	protected PaymentPurpose(object _dummy, long ptr) : base(ptr) { }
	~PaymentPurpose() {
		if (ptr != 0) { bindings.PaymentPurpose_free(ptr); }
	}

	internal static PaymentPurpose constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKPaymentPurpose_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new PaymentPurpose_Bolt11InvoicePayment(ptr);
			case 1: return new PaymentPurpose_Bolt12OfferPayment(ptr);
			case 2: return new PaymentPurpose_Bolt12RefundPayment(ptr);
			case 3: return new PaymentPurpose_SpontaneousPayment(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A PaymentPurpose of type Bolt11InvoicePayment */
	public class PaymentPurpose_Bolt11InvoicePayment : PaymentPurpose {
		/**
		 * The preimage to the payment_hash, if the payment hash (and secret) were fetched via
		 * [`ChannelManager::create_inbound_payment`]. When handling [`Event::PaymentClaimable`],
		 * this can be passed directly to [`ChannelManager::claim_funds`] to claim the payment. No
		 * action is needed when seen in [`Event::PaymentClaimed`].
		 * 
		 * [`ChannelManager::create_inbound_payment`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		 */
		public Option_ThirtyTwoBytesZ payment_preimage;
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
		public byte[] payment_secret;
		internal PaymentPurpose_Bolt11InvoicePayment(long ptr) : base(null, ptr) {
			long payment_preimage = bindings.LDKPaymentPurpose_Bolt11InvoicePayment_get_payment_preimage(ptr);
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_preimage);
			if (payment_preimage_hu_conv != null) { payment_preimage_hu_conv.ptrs_to.AddLast(this); };
			this.payment_preimage = payment_preimage_hu_conv;
			long payment_secret = bindings.LDKPaymentPurpose_Bolt11InvoicePayment_get_payment_secret(ptr);
			byte[] payment_secret_conv = InternalUtils.decodeUint8Array(payment_secret);
			this.payment_secret = payment_secret_conv;
		}
	}
	/** A PaymentPurpose of type Bolt12OfferPayment */
	public class PaymentPurpose_Bolt12OfferPayment : PaymentPurpose {
		/**
		 * The preimage to the payment hash. When handling [`Event::PaymentClaimable`], this can be
		 * passed directly to [`ChannelManager::claim_funds`], if provided. No action is needed
		 * when seen in [`Event::PaymentClaimed`].
		 * 
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		 */
		public Option_ThirtyTwoBytesZ payment_preimage;
		/**
		 * The secret used to authenticate the sender to the recipient, preventing a number of
		 * de-anonymization attacks while routing a payment.
		 * 
		 * See [`PaymentPurpose::Bolt11InvoicePayment::payment_secret`] for further details.
		 */
		public byte[] payment_secret;
		/**
		 * The context of the payment such as information about the corresponding [`Offer`] and
		 * [`InvoiceRequest`].
		 * 
		 * [`Offer`]: crate::offers::offer::Offer
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		 */
		public Bolt12OfferContext payment_context;
		internal PaymentPurpose_Bolt12OfferPayment(long ptr) : base(null, ptr) {
			long payment_preimage = bindings.LDKPaymentPurpose_Bolt12OfferPayment_get_payment_preimage(ptr);
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_preimage);
			if (payment_preimage_hu_conv != null) { payment_preimage_hu_conv.ptrs_to.AddLast(this); };
			this.payment_preimage = payment_preimage_hu_conv;
			long payment_secret = bindings.LDKPaymentPurpose_Bolt12OfferPayment_get_payment_secret(ptr);
			byte[] payment_secret_conv = InternalUtils.decodeUint8Array(payment_secret);
			this.payment_secret = payment_secret_conv;
			long payment_context = bindings.LDKPaymentPurpose_Bolt12OfferPayment_get_payment_context(ptr);
			org.ldk.structs.Bolt12OfferContext payment_context_hu_conv = null; if (payment_context < 0 || payment_context > 4096) { payment_context_hu_conv = new org.ldk.structs.Bolt12OfferContext(null, payment_context); }
			if (payment_context_hu_conv != null) { payment_context_hu_conv.ptrs_to.AddLast(this); };
			this.payment_context = payment_context_hu_conv;
		}
	}
	/** A PaymentPurpose of type Bolt12RefundPayment */
	public class PaymentPurpose_Bolt12RefundPayment : PaymentPurpose {
		/**
		 * The preimage to the payment hash. When handling [`Event::PaymentClaimable`], this can be
		 * passed directly to [`ChannelManager::claim_funds`], if provided. No action is needed
		 * when seen in [`Event::PaymentClaimed`].
		 * 
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		 */
		public Option_ThirtyTwoBytesZ payment_preimage;
		/**
		 * The secret used to authenticate the sender to the recipient, preventing a number of
		 * de-anonymization attacks while routing a payment.
		 * 
		 * See [`PaymentPurpose::Bolt11InvoicePayment::payment_secret`] for further details.
		 */
		public byte[] payment_secret;
		/**
		 * The context of the payment such as information about the corresponding [`Refund`].
		 * 
		 * [`Refund`]: crate::offers::refund::Refund
		 */
		public Bolt12RefundContext payment_context;
		internal PaymentPurpose_Bolt12RefundPayment(long ptr) : base(null, ptr) {
			long payment_preimage = bindings.LDKPaymentPurpose_Bolt12RefundPayment_get_payment_preimage(ptr);
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_preimage);
			if (payment_preimage_hu_conv != null) { payment_preimage_hu_conv.ptrs_to.AddLast(this); };
			this.payment_preimage = payment_preimage_hu_conv;
			long payment_secret = bindings.LDKPaymentPurpose_Bolt12RefundPayment_get_payment_secret(ptr);
			byte[] payment_secret_conv = InternalUtils.decodeUint8Array(payment_secret);
			this.payment_secret = payment_secret_conv;
			long payment_context = bindings.LDKPaymentPurpose_Bolt12RefundPayment_get_payment_context(ptr);
			org.ldk.structs.Bolt12RefundContext payment_context_hu_conv = null; if (payment_context < 0 || payment_context > 4096) { payment_context_hu_conv = new org.ldk.structs.Bolt12RefundContext(null, payment_context); }
			if (payment_context_hu_conv != null) { payment_context_hu_conv.ptrs_to.AddLast(this); };
			this.payment_context = payment_context_hu_conv;
		}
	}
	/** A PaymentPurpose of type SpontaneousPayment */
	public class PaymentPurpose_SpontaneousPayment : PaymentPurpose {
		public byte[] spontaneous_payment;
		internal PaymentPurpose_SpontaneousPayment(long ptr) : base(null, ptr) {
			long spontaneous_payment = bindings.LDKPaymentPurpose_SpontaneousPayment_get_spontaneous_payment(ptr);
			byte[] spontaneous_payment_conv = InternalUtils.decodeUint8Array(spontaneous_payment);
			this.spontaneous_payment = spontaneous_payment_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.PaymentPurpose_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentPurpose
	 */
	public PaymentPurpose clone() {
		long ret = bindings.PaymentPurpose_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bolt11InvoicePayment-variant PaymentPurpose
	 */
	public static PaymentPurpose bolt11_invoice_payment(org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage, byte[] payment_secret) {
		long ret = bindings.PaymentPurpose_bolt11_invoice_payment(payment_preimage.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_secret, 32)));
		GC.KeepAlive(payment_preimage);
		GC.KeepAlive(payment_secret);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bolt12OfferPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose bolt12_offer_payment(org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage, byte[] payment_secret, org.ldk.structs.Bolt12OfferContext payment_context) {
		long ret = bindings.PaymentPurpose_bolt12_offer_payment(payment_preimage.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_secret, 32)), payment_context.ptr);
		GC.KeepAlive(payment_preimage);
		GC.KeepAlive(payment_secret);
		GC.KeepAlive(payment_context);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bolt12RefundPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose bolt12_refund_payment(org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage, byte[] payment_secret, org.ldk.structs.Bolt12RefundContext payment_context) {
		long ret = bindings.PaymentPurpose_bolt12_refund_payment(payment_preimage.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_secret, 32)), payment_context.ptr);
		GC.KeepAlive(payment_preimage);
		GC.KeepAlive(payment_secret);
		GC.KeepAlive(payment_context);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SpontaneousPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose spontaneous_payment(byte[] a) {
		long ret = bindings.PaymentPurpose_spontaneous_payment(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 32)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two PaymentPurposes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.PaymentPurpose b) {
		bool ret = bindings.PaymentPurpose_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is PaymentPurpose)) return false;
		return this.eq((PaymentPurpose)o);
	}
	/**
	 * Returns the preimage for this payment, if it is known.
	 */
	public Option_ThirtyTwoBytesZ preimage() {
		long ret = bindings.PaymentPurpose_preimage(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ThirtyTwoBytesZ ret_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the PaymentPurpose object into a byte array which can be read by PaymentPurpose_read
	 */
	public byte[] write() {
		long ret = bindings.PaymentPurpose_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a PaymentPurpose from a byte array, created by PaymentPurpose_write
	 */
	public static Result_PaymentPurposeDecodeErrorZ read(byte[] ser) {
		long ret = bindings.PaymentPurpose_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentPurposeDecodeErrorZ ret_hu_conv = Result_PaymentPurposeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
