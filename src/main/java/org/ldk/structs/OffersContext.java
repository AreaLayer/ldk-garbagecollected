package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Contains data specific to an [`OffersMessage`].
 * 
 * [`OffersMessage`]: crate::onion_message::offers::OffersMessage
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class OffersContext extends CommonBase {
	private OffersContext(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.OffersContext_free(ptr); }
	}
	static OffersContext constr_from_ptr(long ptr) {
		bindings.LDKOffersContext raw_val = bindings.LDKOffersContext_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKOffersContext.InvoiceRequest.class) {
			return new InvoiceRequest(ptr, (bindings.LDKOffersContext.InvoiceRequest)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKOffersContext.OutboundPayment.class) {
			return new OutboundPayment(ptr, (bindings.LDKOffersContext.OutboundPayment)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKOffersContext.InboundPayment.class) {
			return new InboundPayment(ptr, (bindings.LDKOffersContext.InboundPayment)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Context used by a [`BlindedMessagePath`] within an [`Offer`].
	 * 
	 * This variant is intended to be received when handling an [`InvoiceRequest`].
	 * 
	 * [`Offer`]: crate::offers::offer::Offer
	 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
	 */
	public final static class InvoiceRequest extends OffersContext {
		/**
		 * A nonce used for authenticating that an [`InvoiceRequest`] is for a valid [`Offer`] and
		 * for deriving the offer's signing keys.
		 * 
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		 * [`Offer`]: crate::offers::offer::Offer
		*/
		public final org.ldk.structs.Nonce nonce;
		private InvoiceRequest(long ptr, bindings.LDKOffersContext.InvoiceRequest obj) {
			super(null, ptr);
			long nonce = obj.nonce;
			org.ldk.structs.Nonce nonce_hu_conv = null; if (nonce < 0 || nonce > 4096) { nonce_hu_conv = new org.ldk.structs.Nonce(null, nonce); }
			if (nonce_hu_conv != null) { nonce_hu_conv.ptrs_to.add(this); };
			this.nonce = nonce_hu_conv;
		}
	}
	/**
	 * Context used by a [`BlindedMessagePath`] within a [`Refund`] or as a reply path for an
	 * [`InvoiceRequest`].
	 * 
	 * This variant is intended to be received when handling a [`Bolt12Invoice`] or an
	 * [`InvoiceError`].
	 * 
	 * [`Refund`]: crate::offers::refund::Refund
	 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
	 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
	 * [`InvoiceError`]: crate::offers::invoice_error::InvoiceError
	 */
	public final static class OutboundPayment extends OffersContext {
		/**
		 * Payment ID used when creating a [`Refund`] or [`InvoiceRequest`].
		 * 
		 * [`Refund`]: crate::offers::refund::Refund
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		*/
		public final byte[] payment_id;
		/**
		 * A nonce used for authenticating that a [`Bolt12Invoice`] is for a valid [`Refund`] or
		 * [`InvoiceRequest`] and for deriving their signing keys.
		 * 
		 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
		 * [`Refund`]: crate::offers::refund::Refund
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		*/
		public final org.ldk.structs.Nonce nonce;
		/**
		 * Authentication code for the [`PaymentId`], which should be checked when the context is
		 * used with an [`InvoiceError`].
		 * 
		 * [`InvoiceError`]: crate::offers::invoice_error::InvoiceError
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		*/
		@Nullable public final byte[] hmac;
		private OutboundPayment(long ptr, bindings.LDKOffersContext.OutboundPayment obj) {
			super(null, ptr);
			this.payment_id = obj.payment_id;
			long nonce = obj.nonce;
			org.ldk.structs.Nonce nonce_hu_conv = null; if (nonce < 0 || nonce > 4096) { nonce_hu_conv = new org.ldk.structs.Nonce(null, nonce); }
			if (nonce_hu_conv != null) { nonce_hu_conv.ptrs_to.add(this); };
			this.nonce = nonce_hu_conv;
			this.hmac = obj.hmac;
		}
	}
	/**
	 * Context used by a [`BlindedMessagePath`] as a reply path for a [`Bolt12Invoice`].
	 * 
	 * This variant is intended to be received when handling an [`InvoiceError`].
	 * 
	 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
	 * [`InvoiceError`]: crate::offers::invoice_error::InvoiceError
	 */
	public final static class InboundPayment extends OffersContext {
		/**
		 * The same payment hash as [`Bolt12Invoice::payment_hash`].
		 * 
		 * [`Bolt12Invoice::payment_hash`]: crate::offers::invoice::Bolt12Invoice::payment_hash
		*/
		public final byte[] payment_hash;
		private InboundPayment(long ptr, bindings.LDKOffersContext.InboundPayment obj) {
			super(null, ptr);
			this.payment_hash = obj.payment_hash;
		}
	}
	long clone_ptr() {
		long ret = bindings.OffersContext_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the OffersContext
	 */
	public OffersContext clone() {
		long ret = bindings.OffersContext_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoiceRequest-variant OffersContext
	 */
	public static OffersContext invoice_request(org.ldk.structs.Nonce nonce) {
		long ret = bindings.OffersContext_invoice_request(nonce.ptr);
		Reference.reachabilityFence(nonce);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OutboundPayment-variant OffersContext
	 */
	public static OffersContext outbound_payment(byte[] payment_id, org.ldk.structs.Nonce nonce, byte[] hmac) {
		long ret = bindings.OffersContext_outbound_payment(InternalUtils.check_arr_len(payment_id, 32), nonce.ptr, InternalUtils.check_arr_len(hmac, 32));
		Reference.reachabilityFence(payment_id);
		Reference.reachabilityFence(nonce);
		Reference.reachabilityFence(hmac);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InboundPayment-variant OffersContext
	 */
	public static OffersContext inbound_payment(byte[] payment_hash) {
		long ret = bindings.OffersContext_inbound_payment(InternalUtils.check_arr_len(payment_hash, 32));
		Reference.reachabilityFence(payment_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two OffersContexts contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.OffersContext b) {
		boolean ret = bindings.OffersContext_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof OffersContext)) return false;
		return this.eq((OffersContext)o);
	}
	/**
	 * Serialize the OffersContext object into a byte array which can be read by OffersContext_read
	 */
	public byte[] write() {
		byte[] ret = bindings.OffersContext_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a OffersContext from a byte array, created by OffersContext_write
	 */
	public static Result_OffersContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.OffersContext_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersContextDecodeErrorZ ret_hu_conv = Result_OffersContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
