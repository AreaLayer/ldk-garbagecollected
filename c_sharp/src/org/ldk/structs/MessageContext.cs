using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Additional data included by the recipient in a [`BlindedMessagePath`].
 * 
 * This data is encrypted by the recipient and will be given to the corresponding message handler
 * when handling a message sent over the [`BlindedMessagePath`]. The recipient can use this data to
 * authenticate the message or for further processing if needed.
 */
public class MessageContext : CommonBase {
	protected MessageContext(object _dummy, long ptr) : base(ptr) { }
	~MessageContext() {
		if (ptr != 0) { bindings.MessageContext_free(ptr); }
	}

	internal static MessageContext constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKMessageContext_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new MessageContext_Offers(ptr);
			case 1: return new MessageContext_Custom(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A MessageContext of type Offers */
	public class MessageContext_Offers : MessageContext {
		public OffersContext offers;
		internal MessageContext_Offers(long ptr) : base(null, ptr) {
			long offers = bindings.LDKMessageContext_Offers_get_offers(ptr);
			org.ldk.structs.OffersContext offers_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(offers);
			if (offers_hu_conv != null) { offers_hu_conv.ptrs_to.AddLast(this); };
			this.offers = offers_hu_conv;
		}
	}
	/** A MessageContext of type Custom */
	public class MessageContext_Custom : MessageContext {
		public byte[] custom;
		internal MessageContext_Custom(long ptr) : base(null, ptr) {
			long custom = bindings.LDKMessageContext_Custom_get_custom(ptr);
			byte[] custom_conv = InternalUtils.decodeUint8Array(custom);
			this.custom = custom_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.MessageContext_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the MessageContext
	 */
	public MessageContext clone() {
		long ret = bindings.MessageContext_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Offers-variant MessageContext
	 */
	public static MessageContext offers(org.ldk.structs.OffersContext a) {
		long ret = bindings.MessageContext_offers(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Custom-variant MessageContext
	 */
	public static MessageContext custom(byte[] a) {
		long ret = bindings.MessageContext_custom(InternalUtils.encodeUint8Array(a));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageContext ret_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the MessageContext object into a byte array which can be read by MessageContext_read
	 */
	public byte[] write() {
		long ret = bindings.MessageContext_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a MessageContext from a byte array, created by MessageContext_write
	 */
	public static Result_MessageContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.MessageContext_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MessageContextDecodeErrorZ ret_hu_conv = Result_MessageContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }