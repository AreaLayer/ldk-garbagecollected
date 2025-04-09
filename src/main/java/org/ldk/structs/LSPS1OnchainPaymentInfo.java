package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An onchain payment.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1OnchainPaymentInfo extends CommonBase {
	LSPS1OnchainPaymentInfo(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1OnchainPaymentInfo_free(ptr); }
	}

	/**
	 * Indicates the current state of the payment.
	 */
	public LSPS1PaymentState get_state() {
		LSPS1PaymentState ret = bindings.LSPS1OnchainPaymentInfo_get_state(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates the current state of the payment.
	 */
	public void set_state(org.ldk.enums.LSPS1PaymentState val) {
		bindings.LSPS1OnchainPaymentInfo_set_state(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The datetime when the payment option expires.
	 */
	public LSPSDateTime get_expires_at() {
		long ret = bindings.LSPS1OnchainPaymentInfo_get_expires_at(this.ptr);
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
		bindings.LSPS1OnchainPaymentInfo_set_expires_at(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The total fee the LSP will charge to open this channel in satoshi.
	 */
	public long get_fee_total_sat() {
		long ret = bindings.LSPS1OnchainPaymentInfo_get_fee_total_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The total fee the LSP will charge to open this channel in satoshi.
	 */
	public void set_fee_total_sat(long val) {
		bindings.LSPS1OnchainPaymentInfo_set_fee_total_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The amount the client needs to pay to have the requested channel openend.
	 */
	public long get_order_total_sat() {
		long ret = bindings.LSPS1OnchainPaymentInfo_get_order_total_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The amount the client needs to pay to have the requested channel openend.
	 */
	public void set_order_total_sat(long val) {
		bindings.LSPS1OnchainPaymentInfo_set_order_total_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * An on-chain address the client can send [`Self::order_total_sat`] to to have the channel
	 * opened.
	 */
	public Address get_address() {
		long ret = bindings.LSPS1OnchainPaymentInfo_get_address(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Address ret_conv = new Address(null, ret);
		return ret_conv;
	}

	/**
	 * An on-chain address the client can send [`Self::order_total_sat`] to to have the channel
	 * opened.
	 */
	public void set_address(org.ldk.structs.Address val) {
		bindings.LSPS1OnchainPaymentInfo_set_address(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The minimum number of block confirmations that are required for the on-chain payment to be
	 * considered confirmed.
	 */
	public Option_u16Z get_min_onchain_payment_confirmations() {
		long ret = bindings.LSPS1OnchainPaymentInfo_get_min_onchain_payment_confirmations(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u16Z ret_hu_conv = org.ldk.structs.Option_u16Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The minimum number of block confirmations that are required for the on-chain payment to be
	 * considered confirmed.
	 */
	public void set_min_onchain_payment_confirmations(org.ldk.structs.Option_u16Z val) {
		bindings.LSPS1OnchainPaymentInfo_set_min_onchain_payment_confirmations(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The address where the LSP will send the funds if the order fails.
	 */
	public Option_AddressZ get_refund_onchain_address() {
		long ret = bindings.LSPS1OnchainPaymentInfo_get_refund_onchain_address(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AddressZ ret_hu_conv = org.ldk.structs.Option_AddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The address where the LSP will send the funds if the order fails.
	 */
	public void set_refund_onchain_address(org.ldk.structs.Option_AddressZ val) {
		bindings.LSPS1OnchainPaymentInfo_set_refund_onchain_address(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
		if (this != null) { this.ptrs_to.add(val); };
	}

	long clone_ptr() {
		long ret = bindings.LSPS1OnchainPaymentInfo_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1OnchainPaymentInfo
	 */
	public LSPS1OnchainPaymentInfo clone() {
		long ret = bindings.LSPS1OnchainPaymentInfo_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OnchainPaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OnchainPaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1OnchainPaymentInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1OnchainPaymentInfo b) {
		boolean ret = bindings.LSPS1OnchainPaymentInfo_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1OnchainPaymentInfo)) return false;
		return this.eq((LSPS1OnchainPaymentInfo)o);
	}
}
