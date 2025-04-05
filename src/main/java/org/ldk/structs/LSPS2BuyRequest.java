package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A request to buy a JIT channel.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2BuyRequest extends CommonBase {
	LSPS2BuyRequest(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2BuyRequest_free(ptr); }
	}

	/**
	 * The fee parameters you would like to use.
	 */
	public LSPS2OpeningFeeParams get_opening_fee_params() {
		long ret = bindings.LSPS2BuyRequest_get_opening_fee_params(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2OpeningFeeParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The fee parameters you would like to use.
	 */
	public void set_opening_fee_params(org.ldk.structs.LSPS2OpeningFeeParams val) {
		bindings.LSPS2BuyRequest_set_opening_fee_params(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The size of the initial payment you expect to receive.
	 */
	public Option_u64Z get_payment_size_msat() {
		long ret = bindings.LSPS2BuyRequest_get_payment_size_msat(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The size of the initial payment you expect to receive.
	 */
	public void set_payment_size_msat(org.ldk.structs.Option_u64Z val) {
		bindings.LSPS2BuyRequest_set_payment_size_msat(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS2BuyRequest given each field
	 */
	public static LSPS2BuyRequest of(org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params_arg, org.ldk.structs.Option_u64Z payment_size_msat_arg) {
		long ret = bindings.LSPS2BuyRequest_new(opening_fee_params_arg.ptr, payment_size_msat_arg.ptr);
		Reference.reachabilityFence(opening_fee_params_arg);
		Reference.reachabilityFence(payment_size_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS2BuyRequest_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2BuyRequest
	 */
	public LSPS2BuyRequest clone() {
		long ret = bindings.LSPS2BuyRequest_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2BuyRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS2BuyRequest b) {
		boolean ret = bindings.LSPS2BuyRequest_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2BuyRequest)) return false;
		return this.eq((LSPS2BuyRequest)o);
	}
}
