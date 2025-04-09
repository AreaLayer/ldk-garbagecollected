using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A response to a [`LSPS2GetInfoRequest`]
 */
public class LSPS2GetInfoResponse : CommonBase {
	internal LSPS2GetInfoResponse(object _dummy, long ptr) : base(ptr) { }
	~LSPS2GetInfoResponse() {
		if (ptr != 0) { bindings.LSPS2GetInfoResponse_free(ptr); }
	}

	/**
	 * A set of opening fee parameters.
	 */
	public LSPS2OpeningFeeParams[] get_opening_fee_params_menu() {
		long ret = bindings.LSPS2GetInfoResponse_get_opening_fee_params_menu(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_23_len = InternalUtils.getArrayLength(ret);
		LSPS2OpeningFeeParams[] ret_conv_23_arr = new LSPS2OpeningFeeParams[ret_conv_23_len];
		for (int x = 0; x < ret_conv_23_len; x++) {
			long ret_conv_23 = InternalUtils.getU64ArrayElem(ret, x);
			org.ldk.structs.LSPS2OpeningFeeParams ret_conv_23_hu_conv = null; if (ret_conv_23 < 0 || ret_conv_23 > 4096) { ret_conv_23_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, ret_conv_23); }
			if (ret_conv_23_hu_conv != null) { ret_conv_23_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_23_arr[x] = ret_conv_23_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_23_arr;
	}

	/**
	 * A set of opening fee parameters.
	 */
	public void set_opening_fee_params_menu(LSPS2OpeningFeeParams[] val) {
		bindings.LSPS2GetInfoResponse_set_opening_fee_params_menu(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_23 => val_conv_23.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS2GetInfoResponse given each field
	 */
	public static org.ldk.structs.LSPS2GetInfoResponse of(LSPS2OpeningFeeParams[] opening_fee_params_menu_arg) {
		long ret = bindings.LSPS2GetInfoResponse_new(InternalUtils.encodeUint64Array(InternalUtils.mapArray(opening_fee_params_menu_arg, opening_fee_params_menu_arg_conv_23 => opening_fee_params_menu_arg_conv_23.ptr)));
		GC.KeepAlive(opening_fee_params_menu_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2GetInfoResponse_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2GetInfoResponse
	 */
	public org.ldk.structs.LSPS2GetInfoResponse clone() {
		long ret = bindings.LSPS2GetInfoResponse_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2GetInfoResponses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS2GetInfoResponse b) {
		bool ret = bindings.LSPS2GetInfoResponse_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2GetInfoResponse)) return false;
		return this.eq((LSPS2GetInfoResponse)o);
	}
}
} } }
