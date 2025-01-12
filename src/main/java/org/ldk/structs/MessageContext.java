package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Additional data included by the recipient in a [`BlindedMessagePath`].
 * 
 * This data is encrypted by the recipient and will be given to the corresponding message handler
 * when handling a message sent over the [`BlindedMessagePath`]. The recipient can use this data to
 * authenticate the message or for further processing if needed.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class MessageContext extends CommonBase {
	private MessageContext(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.MessageContext_free(ptr); }
	}
	static MessageContext constr_from_ptr(long ptr) {
		bindings.LDKMessageContext raw_val = bindings.LDKMessageContext_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKMessageContext.Offers.class) {
			return new Offers(ptr, (bindings.LDKMessageContext.Offers)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKMessageContext.AsyncPayments.class) {
			return new AsyncPayments(ptr, (bindings.LDKMessageContext.AsyncPayments)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKMessageContext.DNSResolver.class) {
			return new DNSResolver(ptr, (bindings.LDKMessageContext.DNSResolver)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKMessageContext.Custom.class) {
			return new Custom(ptr, (bindings.LDKMessageContext.Custom)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Context specific to an [`OffersMessage`].
	 * 
	 * [`OffersMessage`]: crate::onion_message::offers::OffersMessage
	 */
	public final static class Offers extends MessageContext {
		public final org.ldk.structs.OffersContext offers;
		private Offers(long ptr, bindings.LDKMessageContext.Offers obj) {
			super(null, ptr);
			long offers = obj.offers;
			org.ldk.structs.OffersContext offers_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(offers);
			if (offers_hu_conv != null) { offers_hu_conv.ptrs_to.add(this); };
			this.offers = offers_hu_conv;
		}
	}
	/**
	 * Context specific to an [`AsyncPaymentsMessage`].
	 * 
	 * [`AsyncPaymentsMessage`]: crate::onion_message::async_payments::AsyncPaymentsMessage
	 */
	public final static class AsyncPayments extends MessageContext {
		public final org.ldk.structs.AsyncPaymentsContext async_payments;
		private AsyncPayments(long ptr, bindings.LDKMessageContext.AsyncPayments obj) {
			super(null, ptr);
			long async_payments = obj.async_payments;
			org.ldk.structs.AsyncPaymentsContext async_payments_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(async_payments);
			if (async_payments_hu_conv != null) { async_payments_hu_conv.ptrs_to.add(this); };
			this.async_payments = async_payments_hu_conv;
		}
	}
	/**
	 * Represents a context for a blinded path used in a reply path when requesting a DNSSEC proof
	 * in a [`DNSResolverMessage`].
	 * 
	 * [`DNSResolverMessage`]: crate::onion_message::dns_resolution::DNSResolverMessage
	 */
	public final static class DNSResolver extends MessageContext {
		public final org.ldk.structs.DNSResolverContext dns_resolver;
		private DNSResolver(long ptr, bindings.LDKMessageContext.DNSResolver obj) {
			super(null, ptr);
			long dns_resolver = obj.dns_resolver;
			org.ldk.structs.DNSResolverContext dns_resolver_hu_conv = null; if (dns_resolver < 0 || dns_resolver > 4096) { dns_resolver_hu_conv = new org.ldk.structs.DNSResolverContext(null, dns_resolver); }
			if (dns_resolver_hu_conv != null) { dns_resolver_hu_conv.ptrs_to.add(this); };
			this.dns_resolver = dns_resolver_hu_conv;
		}
	}
	/**
	 * Context specific to a [`CustomOnionMessageHandler::CustomMessage`].
	 * 
	 * [`CustomOnionMessageHandler::CustomMessage`]: crate::onion_message::messenger::CustomOnionMessageHandler::CustomMessage
	 */
	public final static class Custom extends MessageContext {
		public final byte[] custom;
		private Custom(long ptr, bindings.LDKMessageContext.Custom obj) {
			super(null, ptr);
			this.custom = obj.custom;
		}
	}
	long clone_ptr() {
		long ret = bindings.MessageContext_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the MessageContext
	 */
	public MessageContext clone() {
		long ret = bindings.MessageContext_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Offers-variant MessageContext
	 */
	public static MessageContext offers(org.ldk.structs.OffersContext a) {
		long ret = bindings.MessageContext_offers(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new AsyncPayments-variant MessageContext
	 */
	public static MessageContext async_payments(org.ldk.structs.AsyncPaymentsContext a) {
		long ret = bindings.MessageContext_async_payments(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DNSResolver-variant MessageContext
	 */
	public static MessageContext dnsresolver(org.ldk.structs.DNSResolverContext a) {
		long ret = bindings.MessageContext_dnsresolver(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Custom-variant MessageContext
	 */
	public static MessageContext custom(byte[] a) {
		long ret = bindings.MessageContext_custom(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the MessageContext object into a byte array which can be read by MessageContext_read
	 */
	public byte[] write() {
		byte[] ret = bindings.MessageContext_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a MessageContext from a byte array, created by MessageContext_write
	 */
	public static Result_MessageContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.MessageContext_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MessageContextDecodeErrorZ ret_hu_conv = Result_MessageContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
