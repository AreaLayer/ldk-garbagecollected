using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Possible BOLT 12 Offers messages sent and received via an [`OnionMessage`].
 * 
 * [`OnionMessage`]: crate::ln::msgs::OnionMessage
 */
public class OffersMessage : CommonBase {
	protected OffersMessage(object _dummy, long ptr) : base(ptr) { }
	~OffersMessage() {
		if (ptr != 0) { bindings.OffersMessage_free(ptr); }
	}

	internal static OffersMessage constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKOffersMessage_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new OffersMessage_InvoiceRequest(ptr);
			case 1: return new OffersMessage_Invoice(ptr);
			case 2: return new OffersMessage_InvoiceError(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A OffersMessage of type InvoiceRequest */
	public class OffersMessage_InvoiceRequest : OffersMessage {
		public org.ldk.structs.InvoiceRequest invoice_request;
		internal OffersMessage_InvoiceRequest(long ptr) : base(null, ptr) {
			long invoice_request = bindings.LDKOffersMessage_InvoiceRequest_get_invoice_request(ptr);
			org.ldk.structs.InvoiceRequest invoice_request_hu_conv = null; if (invoice_request < 0 || invoice_request > 4096) { invoice_request_hu_conv = new org.ldk.structs.InvoiceRequest(null, invoice_request); }
			if (invoice_request_hu_conv != null) { invoice_request_hu_conv.ptrs_to.AddLast(this); };
			this.invoice_request = invoice_request_hu_conv;
		}
	}
	/** A OffersMessage of type Invoice */
	public class OffersMessage_Invoice : OffersMessage {
		public org.ldk.structs.Bolt12Invoice invoice;
		internal OffersMessage_Invoice(long ptr) : base(null, ptr) {
			long invoice = bindings.LDKOffersMessage_Invoice_get_invoice(ptr);
			org.ldk.structs.Bolt12Invoice invoice_hu_conv = null; if (invoice < 0 || invoice > 4096) { invoice_hu_conv = new org.ldk.structs.Bolt12Invoice(null, invoice); }
			if (invoice_hu_conv != null) { invoice_hu_conv.ptrs_to.AddLast(this); };
			this.invoice = invoice_hu_conv;
		}
	}
	/** A OffersMessage of type InvoiceError */
	public class OffersMessage_InvoiceError : OffersMessage {
		public org.ldk.structs.InvoiceError invoice_error;
		internal OffersMessage_InvoiceError(long ptr) : base(null, ptr) {
			long invoice_error = bindings.LDKOffersMessage_InvoiceError_get_invoice_error(ptr);
			org.ldk.structs.InvoiceError invoice_error_hu_conv = null; if (invoice_error < 0 || invoice_error > 4096) { invoice_error_hu_conv = new org.ldk.structs.InvoiceError(null, invoice_error); }
			if (invoice_error_hu_conv != null) { invoice_error_hu_conv.ptrs_to.AddLast(this); };
			this.invoice_error = invoice_error_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.OffersMessage_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OffersMessage
	 */
	public org.ldk.structs.OffersMessage clone() {
		long ret = bindings.OffersMessage_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersMessage ret_hu_conv = org.ldk.structs.OffersMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoiceRequest-variant OffersMessage
	 */
	public static org.ldk.structs.OffersMessage invoice_request(org.ldk.structs.InvoiceRequest a) {
		long ret = bindings.OffersMessage_invoice_request(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersMessage ret_hu_conv = org.ldk.structs.OffersMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Invoice-variant OffersMessage
	 */
	public static org.ldk.structs.OffersMessage invoice(org.ldk.structs.Bolt12Invoice a) {
		long ret = bindings.OffersMessage_invoice(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersMessage ret_hu_conv = org.ldk.structs.OffersMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoiceError-variant OffersMessage
	 */
	public static org.ldk.structs.OffersMessage invoice_error(org.ldk.structs.InvoiceError a) {
		long ret = bindings.OffersMessage_invoice_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersMessage ret_hu_conv = org.ldk.structs.OffersMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new OnionMessageContents which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned OnionMessageContents must be freed before this_arg is
	 */
	public org.ldk.structs.OnionMessageContents as_OnionMessageContents() {
		long ret = bindings.OffersMessage_as_OnionMessageContents(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the OffersMessage object into a byte array which can be read by OffersMessage_read
	 */
	public byte[] write() {
		long ret = bindings.OffersMessage_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a OffersMessage from a byte array, created by OffersMessage_write
	 */
	public static org.ldk.structs.Result_OffersMessageDecodeErrorZ read(byte[] ser, long arg_a, org.ldk.structs.Logger arg_b) {
		long ret = bindings.OffersMessage_read(InternalUtils.encodeUint8Array(ser), arg_a, arg_b.ptr);
		GC.KeepAlive(ser);
		GC.KeepAlive(arg_a);
		GC.KeepAlive(arg_b);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersMessageDecodeErrorZ ret_hu_conv = Result_OffersMessageDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_b); };
		return ret_hu_conv;
	}

}
} } }
