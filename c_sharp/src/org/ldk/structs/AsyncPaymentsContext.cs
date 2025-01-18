using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Contains data specific to an [`AsyncPaymentsMessage`].
 * 
 * [`AsyncPaymentsMessage`]: crate::onion_message::async_payments::AsyncPaymentsMessage
 */
public class AsyncPaymentsContext : CommonBase {
	protected AsyncPaymentsContext(object _dummy, long ptr) : base(ptr) { }
	~AsyncPaymentsContext() {
		if (ptr != 0) { bindings.AsyncPaymentsContext_free(ptr); }
	}

	internal static AsyncPaymentsContext constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKAsyncPaymentsContext_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new AsyncPaymentsContext_OutboundPayment(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A AsyncPaymentsContext of type OutboundPayment */
	public class AsyncPaymentsContext_OutboundPayment : AsyncPaymentsContext {
		/**
		 * ID used when payment to the originating [`Offer`] was initiated. Useful for us to identify
		 * which of our pending outbound payments should be released to its often-offline payee.
		 * 
		 * [`Offer`]: crate::offers::offer::Offer
		 */
		public byte[] payment_id;
		/**
		 * A nonce used for authenticating that a [`ReleaseHeldHtlc`] message is valid for a preceding
		 * [`HeldHtlcAvailable`] message.
		 * 
		 * [`ReleaseHeldHtlc`]: crate::onion_message::async_payments::ReleaseHeldHtlc
		 * [`HeldHtlcAvailable`]: crate::onion_message::async_payments::HeldHtlcAvailable
		 */
		public Nonce nonce;
		/**
		 * Authentication code for the [`PaymentId`].
		 * 
		 * Prevents the recipient from being able to deanonymize us by creating a blinded path to us
		 * containing the expected [`PaymentId`].
		 */
		public byte[] hmac;
		internal AsyncPaymentsContext_OutboundPayment(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKAsyncPaymentsContext_OutboundPayment_get_payment_id(ptr);
			byte[] payment_id_conv = InternalUtils.decodeUint8Array(payment_id);
			this.payment_id = payment_id_conv;
			long nonce = bindings.LDKAsyncPaymentsContext_OutboundPayment_get_nonce(ptr);
			org.ldk.structs.Nonce nonce_hu_conv = null; if (nonce < 0 || nonce > 4096) { nonce_hu_conv = new org.ldk.structs.Nonce(null, nonce); }
			if (nonce_hu_conv != null) { nonce_hu_conv.ptrs_to.AddLast(this); };
			this.nonce = nonce_hu_conv;
			long hmac = bindings.LDKAsyncPaymentsContext_OutboundPayment_get_hmac(ptr);
			byte[] hmac_conv = InternalUtils.decodeUint8Array(hmac);
			this.hmac = hmac_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.AsyncPaymentsContext_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the AsyncPaymentsContext
	 */
	public AsyncPaymentsContext clone() {
		long ret = bindings.AsyncPaymentsContext_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsContext ret_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OutboundPayment-variant AsyncPaymentsContext
	 */
	public static AsyncPaymentsContext outbound_payment(byte[] payment_id, org.ldk.structs.Nonce nonce, byte[] hmac) {
		long ret = bindings.AsyncPaymentsContext_outbound_payment(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)), nonce.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(hmac, 32)));
		GC.KeepAlive(payment_id);
		GC.KeepAlive(nonce);
		GC.KeepAlive(hmac);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsContext ret_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the AsyncPaymentsContext object into a byte array which can be read by AsyncPaymentsContext_read
	 */
	public byte[] write() {
		long ret = bindings.AsyncPaymentsContext_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a AsyncPaymentsContext from a byte array, created by AsyncPaymentsContext_write
	 */
	public static Result_AsyncPaymentsContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.AsyncPaymentsContext_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsContextDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
