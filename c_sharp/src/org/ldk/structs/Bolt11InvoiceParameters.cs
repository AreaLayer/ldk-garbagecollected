using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Parameters used with [`create_bolt11_invoice`].
 * 
 * [`create_bolt11_invoice`]: ChannelManager::create_bolt11_invoice
 */
public class Bolt11InvoiceParameters : CommonBase {
	internal Bolt11InvoiceParameters(object _dummy, long ptr) : base(ptr) { }
	~Bolt11InvoiceParameters() {
		if (ptr != 0) { bindings.Bolt11InvoiceParameters_free(ptr); }
	}

	/**
	 * The amount for the invoice, if any.
	 */
	public org.ldk.structs.Option_u64Z get_amount_msats() {
		long ret = bindings.Bolt11InvoiceParameters_get_amount_msats(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The amount for the invoice, if any.
	 */
	public void set_amount_msats(org.ldk.structs.Option_u64Z val) {
		bindings.Bolt11InvoiceParameters_set_amount_msats(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The description for what the invoice is for, or hash of such description.
	 */
	public org.ldk.structs.Bolt11InvoiceDescription get_description() {
		long ret = bindings.Bolt11InvoiceParameters_get_description(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceDescription ret_hu_conv = org.ldk.structs.Bolt11InvoiceDescription.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The description for what the invoice is for, or hash of such description.
	 */
	public void set_description(org.ldk.structs.Bolt11InvoiceDescription val) {
		bindings.Bolt11InvoiceParameters_set_description(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The invoice expiration relative to its creation time. If not set, the invoice will expire in
	 * [`DEFAULT_EXPIRY_TIME`] by default.
	 * 
	 * The creation time used is the duration since the Unix epoch for `std` builds. For non-`std`
	 * builds, the highest block timestamp seen is used instead. In the latter case, use a long
	 * enough expiry to account for the average block time.
	 */
	public org.ldk.structs.Option_u32Z get_invoice_expiry_delta_secs() {
		long ret = bindings.Bolt11InvoiceParameters_get_invoice_expiry_delta_secs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u32Z ret_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The invoice expiration relative to its creation time. If not set, the invoice will expire in
	 * [`DEFAULT_EXPIRY_TIME`] by default.
	 * 
	 * The creation time used is the duration since the Unix epoch for `std` builds. For non-`std`
	 * builds, the highest block timestamp seen is used instead. In the latter case, use a long
	 * enough expiry to account for the average block time.
	 */
	public void set_invoice_expiry_delta_secs(org.ldk.structs.Option_u32Z val) {
		bindings.Bolt11InvoiceParameters_set_invoice_expiry_delta_secs(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum `cltv_expiry` for the last HTLC in the route. If not set, will use
	 * [`MIN_FINAL_CLTV_EXPIRY_DELTA`].
	 * 
	 * If set, must be at least [`MIN_FINAL_CLTV_EXPIRY_DELTA`], and a three-block buffer will be
	 * added as well to allow for up to a few new block confirmations during routing.
	 */
	public org.ldk.structs.Option_u16Z get_min_final_cltv_expiry_delta() {
		long ret = bindings.Bolt11InvoiceParameters_get_min_final_cltv_expiry_delta(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u16Z ret_hu_conv = org.ldk.structs.Option_u16Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The minimum `cltv_expiry` for the last HTLC in the route. If not set, will use
	 * [`MIN_FINAL_CLTV_EXPIRY_DELTA`].
	 * 
	 * If set, must be at least [`MIN_FINAL_CLTV_EXPIRY_DELTA`], and a three-block buffer will be
	 * added as well to allow for up to a few new block confirmations during routing.
	 */
	public void set_min_final_cltv_expiry_delta(org.ldk.structs.Option_u16Z val) {
		bindings.Bolt11InvoiceParameters_set_min_final_cltv_expiry_delta(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The payment hash used in the invoice. If not set, a payment hash will be generated using a
	 * preimage that can be reproduced by [`ChannelManager`] without storing any state.
	 * 
	 * Uses the payment hash if set. This may be useful if you're building an on-chain swap or
	 * involving another protocol where the payment hash is also involved outside the scope of
	 * lightning.
	 */
	public org.ldk.structs.Option_ThirtyTwoBytesZ get_payment_hash() {
		long ret = bindings.Bolt11InvoiceParameters_get_payment_hash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ThirtyTwoBytesZ ret_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The payment hash used in the invoice. If not set, a payment hash will be generated using a
	 * preimage that can be reproduced by [`ChannelManager`] without storing any state.
	 * 
	 * Uses the payment hash if set. This may be useful if you're building an on-chain swap or
	 * involving another protocol where the payment hash is also involved outside the scope of
	 * lightning.
	 */
	public void set_payment_hash(org.ldk.structs.Option_ThirtyTwoBytesZ val) {
		bindings.Bolt11InvoiceParameters_set_payment_hash(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new Bolt11InvoiceParameters given each field
	 */
	public static org.ldk.structs.Bolt11InvoiceParameters of(org.ldk.structs.Option_u64Z amount_msats_arg, org.ldk.structs.Bolt11InvoiceDescription description_arg, org.ldk.structs.Option_u32Z invoice_expiry_delta_secs_arg, org.ldk.structs.Option_u16Z min_final_cltv_expiry_delta_arg, org.ldk.structs.Option_ThirtyTwoBytesZ payment_hash_arg) {
		long ret = bindings.Bolt11InvoiceParameters_new(amount_msats_arg.ptr, description_arg.ptr, invoice_expiry_delta_secs_arg.ptr, min_final_cltv_expiry_delta_arg.ptr, payment_hash_arg.ptr);
		GC.KeepAlive(amount_msats_arg);
		GC.KeepAlive(description_arg);
		GC.KeepAlive(invoice_expiry_delta_secs_arg);
		GC.KeepAlive(min_final_cltv_expiry_delta_arg);
		GC.KeepAlive(payment_hash_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt11InvoiceParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Creates a "default" Bolt11InvoiceParameters. See struct and individual field documentaiton for details on which values are used.
	 */
	public static org.ldk.structs.Bolt11InvoiceParameters with_default() {
		long ret = bindings.Bolt11InvoiceParameters_default();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt11InvoiceParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
