package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A response to a [`LSPS2GetInfoRequest`]
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2GetInfoResponse extends CommonBase {
	LSPS2GetInfoResponse(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2GetInfoResponse_free(ptr); }
	}

	/**
	 * A set of opening fee parameters.
	 */
	public LSPS2OpeningFeeParams[] get_opening_fee_params_menu() {
		long[] ret = bindings.LSPS2GetInfoResponse_get_opening_fee_params_menu(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_23_len = ret.length;
		LSPS2OpeningFeeParams[] ret_conv_23_arr = new LSPS2OpeningFeeParams[ret_conv_23_len];
		for (int x = 0; x < ret_conv_23_len; x++) {
			long ret_conv_23 = ret[x];
			org.ldk.structs.LSPS2OpeningFeeParams ret_conv_23_hu_conv = null; if (ret_conv_23 < 0 || ret_conv_23 > 4096) { ret_conv_23_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, ret_conv_23); }
			if (ret_conv_23_hu_conv != null) { ret_conv_23_hu_conv.ptrs_to.add(this); };
			ret_conv_23_arr[x] = ret_conv_23_hu_conv;
		}
		return ret_conv_23_arr;
	}

	/**
	 * A set of opening fee parameters.
	 */
	public void set_opening_fee_params_menu(LSPS2OpeningFeeParams[] val) {
		bindings.LSPS2GetInfoResponse_set_opening_fee_params_menu(this.ptr, val != null ? Arrays.stream(val).mapToLong(val_conv_23 -> val_conv_23.ptr).toArray() : null);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS2GetInfoResponse given each field
	 */
	public static LSPS2GetInfoResponse of(LSPS2OpeningFeeParams[] opening_fee_params_menu_arg) {
		long ret = bindings.LSPS2GetInfoResponse_new(opening_fee_params_menu_arg != null ? Arrays.stream(opening_fee_params_menu_arg).mapToLong(opening_fee_params_menu_arg_conv_23 -> opening_fee_params_menu_arg_conv_23.ptr).toArray() : null);
		Reference.reachabilityFence(opening_fee_params_menu_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS2GetInfoResponse_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2GetInfoResponse
	 */
	public LSPS2GetInfoResponse clone() {
		long ret = bindings.LSPS2GetInfoResponse_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2GetInfoResponses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS2GetInfoResponse b) {
		boolean ret = bindings.LSPS2GetInfoResponse_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2GetInfoResponse)) return false;
		return this.eq((LSPS2GetInfoResponse)o);
	}
}
