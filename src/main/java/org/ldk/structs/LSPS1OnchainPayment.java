package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Details regarding a detected on-chain payment.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1OnchainPayment extends CommonBase {
	LSPS1OnchainPayment(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1OnchainPayment_free(ptr); }
	}

	/**
	 * The outpoint of the payment.
	 */
	public String get_outpoint() {
		String ret = bindings.LSPS1OnchainPayment_get_outpoint(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The outpoint of the payment.
	 */
	public void set_outpoint(java.lang.String val) {
		bindings.LSPS1OnchainPayment_set_outpoint(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The amount of satoshi paid.
	 */
	public long get_sat() {
		long ret = bindings.LSPS1OnchainPayment_get_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The amount of satoshi paid.
	 */
	public void set_sat(long val) {
		bindings.LSPS1OnchainPayment_set_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Indicates if the LSP regards the transaction as sufficiently confirmed.
	 */
	public boolean get_confirmed() {
		boolean ret = bindings.LSPS1OnchainPayment_get_confirmed(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates if the LSP regards the transaction as sufficiently confirmed.
	 */
	public void set_confirmed(boolean val) {
		bindings.LSPS1OnchainPayment_set_confirmed(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1OnchainPayment given each field
	 */
	public static LSPS1OnchainPayment of(java.lang.String outpoint_arg, long sat_arg, boolean confirmed_arg) {
		long ret = bindings.LSPS1OnchainPayment_new(outpoint_arg, sat_arg, confirmed_arg);
		Reference.reachabilityFence(outpoint_arg);
		Reference.reachabilityFence(sat_arg);
		Reference.reachabilityFence(confirmed_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OnchainPayment ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OnchainPayment(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1OnchainPayment_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1OnchainPayment
	 */
	public LSPS1OnchainPayment clone() {
		long ret = bindings.LSPS1OnchainPayment_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OnchainPayment ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OnchainPayment(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1OnchainPayments contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1OnchainPayment b) {
		boolean ret = bindings.LSPS1OnchainPayment_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1OnchainPayment)) return false;
		return this.eq((LSPS1OnchainPayment)o);
	}
}
