using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Lightning payment using BOLT 11.
 */
public class LSPS1Bolt11PaymentInfo : CommonBase {
	internal LSPS1Bolt11PaymentInfo(object _dummy, long ptr) : base(ptr) { }
	~LSPS1Bolt11PaymentInfo() {
		if (ptr != 0) { bindings.LSPS1Bolt11PaymentInfo_free(ptr); }
	}

	/**
	 * Indicates the current state of the payment.
	 */
	public LSPS1PaymentState get_state() {
		LSPS1PaymentState ret = bindings.LSPS1Bolt11PaymentInfo_get_state(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates the current state of the payment.
	 */
	public void set_state(LSPS1PaymentState val) {
		bindings.LSPS1Bolt11PaymentInfo_set_state(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The datetime when the payment option expires.
	 */
	public org.ldk.structs.LSPSDateTime get_expires_at() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_expires_at(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The datetime when the payment option expires.
	 */
	public void set_expires_at(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS1Bolt11PaymentInfo_set_expires_at(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The total fee the LSP will charge to open this channel in satoshi.
	 */
	public long get_fee_total_sat() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_fee_total_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The total fee the LSP will charge to open this channel in satoshi.
	 */
	public void set_fee_total_sat(long val) {
		bindings.LSPS1Bolt11PaymentInfo_set_fee_total_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The amount the client needs to pay to have the requested channel openend.
	 */
	public long get_order_total_sat() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_order_total_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The amount the client needs to pay to have the requested channel openend.
	 */
	public void set_order_total_sat(long val) {
		bindings.LSPS1Bolt11PaymentInfo_set_order_total_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A BOLT11 invoice the client can pay to have to channel opened.
	 */
	public org.ldk.structs.Bolt11Invoice get_invoice() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_invoice(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11Invoice ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt11Invoice(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * A BOLT11 invoice the client can pay to have to channel opened.
	 */
	public void set_invoice(org.ldk.structs.Bolt11Invoice val) {
		bindings.LSPS1Bolt11PaymentInfo_set_invoice(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1Bolt11PaymentInfo given each field
	 */
	public static org.ldk.structs.LSPS1Bolt11PaymentInfo of(LSPS1PaymentState state_arg, org.ldk.structs.LSPSDateTime expires_at_arg, long fee_total_sat_arg, long order_total_sat_arg, org.ldk.structs.Bolt11Invoice invoice_arg) {
		long ret = bindings.LSPS1Bolt11PaymentInfo_new(state_arg, expires_at_arg.ptr, fee_total_sat_arg, order_total_sat_arg, invoice_arg.ptr);
		GC.KeepAlive(state_arg);
		GC.KeepAlive(expires_at_arg);
		GC.KeepAlive(fee_total_sat_arg);
		GC.KeepAlive(order_total_sat_arg);
		GC.KeepAlive(invoice_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Bolt11PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Bolt11PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Bolt11PaymentInfo
	 */
	public org.ldk.structs.LSPS1Bolt11PaymentInfo clone() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Bolt11PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Bolt11PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Bolt11PaymentInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1Bolt11PaymentInfo b) {
		bool ret = bindings.LSPS1Bolt11PaymentInfo_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1Bolt11PaymentInfo)) return false;
		return this.eq((LSPS1Bolt11PaymentInfo)o);
	}
}
} } }
