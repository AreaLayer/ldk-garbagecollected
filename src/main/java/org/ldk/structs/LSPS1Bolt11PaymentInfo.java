package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A Lightning payment using BOLT 11.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1Bolt11PaymentInfo extends CommonBase {
	LSPS1Bolt11PaymentInfo(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1Bolt11PaymentInfo_free(ptr); }
	}

	/**
	 * Indicates the current state of the payment.
	 */
	public LSPS1PaymentState get_state() {
		LSPS1PaymentState ret = bindings.LSPS1Bolt11PaymentInfo_get_state(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates the current state of the payment.
	 */
	public void set_state(org.ldk.enums.LSPS1PaymentState val) {
		bindings.LSPS1Bolt11PaymentInfo_set_state(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The datetime when the payment option expires.
	 */
	public LSPSDateTime get_expires_at() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_expires_at(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The datetime when the payment option expires.
	 */
	public void set_expires_at(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS1Bolt11PaymentInfo_set_expires_at(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The total fee the LSP will charge to open this channel in satoshi.
	 */
	public long get_fee_total_sat() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_fee_total_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The total fee the LSP will charge to open this channel in satoshi.
	 */
	public void set_fee_total_sat(long val) {
		bindings.LSPS1Bolt11PaymentInfo_set_fee_total_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The amount the client needs to pay to have the requested channel openend.
	 */
	public long get_order_total_sat() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_order_total_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The amount the client needs to pay to have the requested channel openend.
	 */
	public void set_order_total_sat(long val) {
		bindings.LSPS1Bolt11PaymentInfo_set_order_total_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * A BOLT11 invoice the client can pay to have to channel opened.
	 */
	public Bolt11Invoice get_invoice() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_get_invoice(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11Invoice ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt11Invoice(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * A BOLT11 invoice the client can pay to have to channel opened.
	 */
	public void set_invoice(org.ldk.structs.Bolt11Invoice val) {
		bindings.LSPS1Bolt11PaymentInfo_set_invoice(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1Bolt11PaymentInfo given each field
	 */
	public static LSPS1Bolt11PaymentInfo of(org.ldk.enums.LSPS1PaymentState state_arg, org.ldk.structs.LSPSDateTime expires_at_arg, long fee_total_sat_arg, long order_total_sat_arg, org.ldk.structs.Bolt11Invoice invoice_arg) {
		long ret = bindings.LSPS1Bolt11PaymentInfo_new(state_arg, expires_at_arg.ptr, fee_total_sat_arg, order_total_sat_arg, invoice_arg.ptr);
		Reference.reachabilityFence(state_arg);
		Reference.reachabilityFence(expires_at_arg);
		Reference.reachabilityFence(fee_total_sat_arg);
		Reference.reachabilityFence(order_total_sat_arg);
		Reference.reachabilityFence(invoice_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Bolt11PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Bolt11PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Bolt11PaymentInfo
	 */
	public LSPS1Bolt11PaymentInfo clone() {
		long ret = bindings.LSPS1Bolt11PaymentInfo_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Bolt11PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Bolt11PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Bolt11PaymentInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1Bolt11PaymentInfo b) {
		boolean ret = bindings.LSPS1Bolt11PaymentInfo_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1Bolt11PaymentInfo)) return false;
		return this.eq((LSPS1Bolt11PaymentInfo)o);
	}
}
