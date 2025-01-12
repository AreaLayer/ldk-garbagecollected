package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Contains data specific to an [`AsyncPaymentsMessage`].
 * 
 * [`AsyncPaymentsMessage`]: crate::onion_message::async_payments::AsyncPaymentsMessage
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class AsyncPaymentsContext extends CommonBase {
	private AsyncPaymentsContext(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.AsyncPaymentsContext_free(ptr); }
	}
	static AsyncPaymentsContext constr_from_ptr(long ptr) {
		bindings.LDKAsyncPaymentsContext raw_val = bindings.LDKAsyncPaymentsContext_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKAsyncPaymentsContext.OutboundPayment.class) {
			return new OutboundPayment(ptr, (bindings.LDKAsyncPaymentsContext.OutboundPayment)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Context contained within the reply [`BlindedMessagePath`] we put in outbound
	 * [`HeldHtlcAvailable`] messages, provided back to us in corresponding [`ReleaseHeldHtlc`]
	 * messages.
	 * 
	 * [`HeldHtlcAvailable`]: crate::onion_message::async_payments::HeldHtlcAvailable
	 * [`ReleaseHeldHtlc`]: crate::onion_message::async_payments::ReleaseHeldHtlc
	 */
	public final static class OutboundPayment extends AsyncPaymentsContext {
		/**
		 * ID used when payment to the originating [`Offer`] was initiated. Useful for us to identify
		 * which of our pending outbound payments should be released to its often-offline payee.
		 * 
		 * [`Offer`]: crate::offers::offer::Offer
		*/
		public final byte[] payment_id;
		/**
		 * A nonce used for authenticating that a [`ReleaseHeldHtlc`] message is valid for a preceding
		 * [`HeldHtlcAvailable`] message.
		 * 
		 * [`ReleaseHeldHtlc`]: crate::onion_message::async_payments::ReleaseHeldHtlc
		 * [`HeldHtlcAvailable`]: crate::onion_message::async_payments::HeldHtlcAvailable
		*/
		public final org.ldk.structs.Nonce nonce;
		/**
		 * Authentication code for the [`PaymentId`].
		 * 
		 * Prevents the recipient from being able to deanonymize us by creating a blinded path to us
		 * containing the expected [`PaymentId`].
		*/
		public final byte[] hmac;
		private OutboundPayment(long ptr, bindings.LDKAsyncPaymentsContext.OutboundPayment obj) {
			super(null, ptr);
			this.payment_id = obj.payment_id;
			long nonce = obj.nonce;
			org.ldk.structs.Nonce nonce_hu_conv = null; if (nonce < 0 || nonce > 4096) { nonce_hu_conv = new org.ldk.structs.Nonce(null, nonce); }
			if (nonce_hu_conv != null) { nonce_hu_conv.ptrs_to.add(this); };
			this.nonce = nonce_hu_conv;
			this.hmac = obj.hmac;
		}
	}
	long clone_ptr() {
		long ret = bindings.AsyncPaymentsContext_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the AsyncPaymentsContext
	 */
	public AsyncPaymentsContext clone() {
		long ret = bindings.AsyncPaymentsContext_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsContext ret_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OutboundPayment-variant AsyncPaymentsContext
	 */
	public static AsyncPaymentsContext outbound_payment(byte[] payment_id, org.ldk.structs.Nonce nonce, byte[] hmac) {
		long ret = bindings.AsyncPaymentsContext_outbound_payment(InternalUtils.check_arr_len(payment_id, 32), nonce.ptr, InternalUtils.check_arr_len(hmac, 32));
		Reference.reachabilityFence(payment_id);
		Reference.reachabilityFence(nonce);
		Reference.reachabilityFence(hmac);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsContext ret_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the AsyncPaymentsContext object into a byte array which can be read by AsyncPaymentsContext_read
	 */
	public byte[] write() {
		byte[] ret = bindings.AsyncPaymentsContext_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a AsyncPaymentsContext from a byte array, created by AsyncPaymentsContext_write
	 */
	public static Result_AsyncPaymentsContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.AsyncPaymentsContext_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsContextDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
