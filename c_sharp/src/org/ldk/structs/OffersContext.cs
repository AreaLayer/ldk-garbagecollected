using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Contains data specific to an [`OffersMessage`].
 * 
 * [`OffersMessage`]: crate::onion_message::offers::OffersMessage
 */
public class OffersContext : CommonBase {
	protected OffersContext(object _dummy, long ptr) : base(ptr) { }
	~OffersContext() {
		if (ptr != 0) { bindings.OffersContext_free(ptr); }
	}

	internal static OffersContext constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKOffersContext_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new OffersContext_InvoiceRequest(ptr);
			case 1: return new OffersContext_OutboundPayment(ptr);
			case 2: return new OffersContext_InboundPayment(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A OffersContext of type InvoiceRequest */
	public class OffersContext_InvoiceRequest : OffersContext {
		/**
		 * A nonce used for authenticating that an [`InvoiceRequest`] is for a valid [`Offer`] and
		 * for deriving the offer's signing keys.
		 * 
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		 * [`Offer`]: crate::offers::offer::Offer
		 */
		public org.ldk.structs.Nonce nonce;
		internal OffersContext_InvoiceRequest(long ptr) : base(null, ptr) {
			long nonce = bindings.LDKOffersContext_InvoiceRequest_get_nonce(ptr);
			org.ldk.structs.Nonce nonce_hu_conv = null; if (nonce < 0 || nonce > 4096) { nonce_hu_conv = new org.ldk.structs.Nonce(null, nonce); }
			if (nonce_hu_conv != null) { nonce_hu_conv.ptrs_to.AddLast(this); };
			this.nonce = nonce_hu_conv;
		}
	}
	/** A OffersContext of type OutboundPayment */
	public class OffersContext_OutboundPayment : OffersContext {
		/**
		 * Payment ID used when creating a [`Refund`] or [`InvoiceRequest`].
		 * 
		 * [`Refund`]: crate::offers::refund::Refund
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		 */
		public byte[] payment_id;
		/**
		 * A nonce used for authenticating that a [`Bolt12Invoice`] is for a valid [`Refund`] or
		 * [`InvoiceRequest`] and for deriving their signing keys.
		 * 
		 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
		 * [`Refund`]: crate::offers::refund::Refund
		 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
		 */
		public org.ldk.structs.Nonce nonce;
		/**
		 * Authentication code for the [`PaymentId`], which should be checked when the context is
		 * used with an [`InvoiceError`].
		 * 
		 * [`InvoiceError`]: crate::offers::invoice_error::InvoiceError
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public byte[] hmac;
		internal OffersContext_OutboundPayment(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKOffersContext_OutboundPayment_get_payment_id(ptr);
			byte[] payment_id_conv = InternalUtils.decodeUint8Array(payment_id);
			this.payment_id = payment_id_conv;
			long nonce = bindings.LDKOffersContext_OutboundPayment_get_nonce(ptr);
			org.ldk.structs.Nonce nonce_hu_conv = null; if (nonce < 0 || nonce > 4096) { nonce_hu_conv = new org.ldk.structs.Nonce(null, nonce); }
			if (nonce_hu_conv != null) { nonce_hu_conv.ptrs_to.AddLast(this); };
			this.nonce = nonce_hu_conv;
			long hmac = bindings.LDKOffersContext_OutboundPayment_get_hmac(ptr);
			byte[] hmac_conv = InternalUtils.decodeUint8Array(hmac);
			this.hmac = hmac_conv;
		}
	}
	/** A OffersContext of type InboundPayment */
	public class OffersContext_InboundPayment : OffersContext {
		/**
		 * The same payment hash as [`Bolt12Invoice::payment_hash`].
		 * 
		 * [`Bolt12Invoice::payment_hash`]: crate::offers::invoice::Bolt12Invoice::payment_hash
		 */
		public byte[] payment_hash;
		/**
		 * A nonce used for authenticating that a received [`InvoiceError`] is for a valid
		 * sent [`Bolt12Invoice`].
		 * 
		 * [`InvoiceError`]: crate::offers::invoice_error::InvoiceError
		 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
		 */
		public org.ldk.structs.Nonce nonce;
		/**
		 * Authentication code for the [`PaymentHash`], which should be checked when the context is
		 * used to log the received [`InvoiceError`].
		 * 
		 * [`InvoiceError`]: crate::offers::invoice_error::InvoiceError
		 */
		public byte[] hmac;
		internal OffersContext_InboundPayment(long ptr) : base(null, ptr) {
			long payment_hash = bindings.LDKOffersContext_InboundPayment_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			long nonce = bindings.LDKOffersContext_InboundPayment_get_nonce(ptr);
			org.ldk.structs.Nonce nonce_hu_conv = null; if (nonce < 0 || nonce > 4096) { nonce_hu_conv = new org.ldk.structs.Nonce(null, nonce); }
			if (nonce_hu_conv != null) { nonce_hu_conv.ptrs_to.AddLast(this); };
			this.nonce = nonce_hu_conv;
			long hmac = bindings.LDKOffersContext_InboundPayment_get_hmac(ptr);
			byte[] hmac_conv = InternalUtils.decodeUint8Array(hmac);
			this.hmac = hmac_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.OffersContext_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OffersContext
	 */
	public org.ldk.structs.OffersContext clone() {
		long ret = bindings.OffersContext_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoiceRequest-variant OffersContext
	 */
	public static org.ldk.structs.OffersContext invoice_request(org.ldk.structs.Nonce nonce) {
		long ret = bindings.OffersContext_invoice_request(nonce.ptr);
		GC.KeepAlive(nonce);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OutboundPayment-variant OffersContext
	 */
	public static org.ldk.structs.OffersContext outbound_payment(byte[] payment_id, org.ldk.structs.Nonce nonce, byte[] hmac) {
		long ret = bindings.OffersContext_outbound_payment(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)), nonce.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(hmac, 32)));
		GC.KeepAlive(payment_id);
		GC.KeepAlive(nonce);
		GC.KeepAlive(hmac);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InboundPayment-variant OffersContext
	 */
	public static org.ldk.structs.OffersContext inbound_payment(byte[] payment_hash, org.ldk.structs.Nonce nonce, byte[] hmac) {
		long ret = bindings.OffersContext_inbound_payment(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), nonce.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(hmac, 32)));
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(nonce);
		GC.KeepAlive(hmac);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersContext ret_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two OffersContexts contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.OffersContext b) {
		bool ret = bindings.OffersContext_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is OffersContext)) return false;
		return this.eq((OffersContext)o);
	}
	/**
	 * Serialize the OffersContext object into a byte array which can be read by OffersContext_read
	 */
	public byte[] write() {
		long ret = bindings.OffersContext_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a OffersContext from a byte array, created by OffersContext_write
	 */
	public static org.ldk.structs.Result_OffersContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.OffersContext_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersContextDecodeErrorZ ret_hu_conv = Result_OffersContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
