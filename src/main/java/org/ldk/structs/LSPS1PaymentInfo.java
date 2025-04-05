package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Details regarding how to pay for an order.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1PaymentInfo extends CommonBase {
	LSPS1PaymentInfo(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1PaymentInfo_free(ptr); }
	}

	/**
	 * A Lightning payment using BOLT 11.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public LSPS1Bolt11PaymentInfo get_bolt11() {
		long ret = bindings.LSPS1PaymentInfo_get_bolt11(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Bolt11PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Bolt11PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * A Lightning payment using BOLT 11.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_bolt11(@Nullable org.ldk.structs.LSPS1Bolt11PaymentInfo val) {
		bindings.LSPS1PaymentInfo_set_bolt11(this.ptr, val == null ? 0 : val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * An onchain payment.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public LSPS1OnchainPaymentInfo get_onchain() {
		long ret = bindings.LSPS1PaymentInfo_get_onchain(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OnchainPaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OnchainPaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * An onchain payment.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_onchain(@Nullable org.ldk.structs.LSPS1OnchainPaymentInfo val) {
		bindings.LSPS1PaymentInfo_set_onchain(this.ptr, val == null ? 0 : val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1PaymentInfo given each field
	 * 
	 * Note that bolt11_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that onchain_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static LSPS1PaymentInfo of(@Nullable org.ldk.structs.LSPS1Bolt11PaymentInfo bolt11_arg, @Nullable org.ldk.structs.LSPS1OnchainPaymentInfo onchain_arg) {
		long ret = bindings.LSPS1PaymentInfo_new(bolt11_arg == null ? 0 : bolt11_arg.ptr, onchain_arg == null ? 0 : onchain_arg.ptr);
		Reference.reachabilityFence(bolt11_arg);
		Reference.reachabilityFence(onchain_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1PaymentInfo_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1PaymentInfo
	 */
	public LSPS1PaymentInfo clone() {
		long ret = bindings.LSPS1PaymentInfo_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1PaymentInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1PaymentInfo b) {
		boolean ret = bindings.LSPS1PaymentInfo_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1PaymentInfo)) return false;
		return this.eq((LSPS1PaymentInfo)o);
	}
}
