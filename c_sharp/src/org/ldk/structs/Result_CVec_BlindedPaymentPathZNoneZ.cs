using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_BlindedPaymentPathZNoneZ : CommonBase {
	Result_CVec_BlindedPaymentPathZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_BlindedPaymentPathZNoneZ() {
		if (ptr != 0) { bindings.CResult_CVec_BlindedPaymentPathZNoneZ_free(ptr); }
	}

	internal static Result_CVec_BlindedPaymentPathZNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_CVec_BlindedPaymentPathZNoneZ_is_ok(ptr)) {
			return new Result_CVec_BlindedPaymentPathZNoneZ_OK(null, ptr);
		} else {
			return new Result_CVec_BlindedPaymentPathZNoneZ_Err(null, ptr);
		}
	}
	public class Result_CVec_BlindedPaymentPathZNoneZ_OK : Result_CVec_BlindedPaymentPathZNoneZ {
		public readonly BlindedPaymentPath[] res;
		internal Result_CVec_BlindedPaymentPathZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_CVec_BlindedPaymentPathZNoneZ_get_ok(ptr);
			int res_conv_20_len = InternalUtils.getArrayLength(res);
			BlindedPaymentPath[] res_conv_20_arr = new BlindedPaymentPath[res_conv_20_len];
			for (int u = 0; u < res_conv_20_len; u++) {
				long res_conv_20 = InternalUtils.getU64ArrayElem(res, u);
				org.ldk.structs.BlindedPaymentPath res_conv_20_hu_conv = null; if (res_conv_20 < 0 || res_conv_20 > 4096) { res_conv_20_hu_conv = new org.ldk.structs.BlindedPaymentPath(null, res_conv_20); }
				if (res_conv_20_hu_conv != null) { res_conv_20_hu_conv.ptrs_to.AddLast(this); };
				res_conv_20_arr[u] = res_conv_20_hu_conv;
			}
			bindings.free_buffer(res);
			this.res = res_conv_20_arr;
		}
	}

	public class Result_CVec_BlindedPaymentPathZNoneZ_Err : Result_CVec_BlindedPaymentPathZNoneZ {
		internal Result_CVec_BlindedPaymentPathZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_CVec_BlindedPaymentPathZNoneZ in the success state.
	 */
	public static Result_CVec_BlindedPaymentPathZNoneZ ok(BlindedPaymentPath[] o) {
		long ret = bindings.CResult_CVec_BlindedPaymentPathZNoneZ_ok(InternalUtils.encodeUint64Array(InternalUtils.mapArray(o, o_conv_20 => o_conv_20.ptr)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedPaymentPathZNoneZ ret_hu_conv = Result_CVec_BlindedPaymentPathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_BlindedPaymentPathZNoneZ in the error state.
	 */
	public static Result_CVec_BlindedPaymentPathZNoneZ err() {
		long ret = bindings.CResult_CVec_BlindedPaymentPathZNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedPaymentPathZNoneZ ret_hu_conv = Result_CVec_BlindedPaymentPathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_CVec_BlindedPaymentPathZNoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_CVec_BlindedPaymentPathZNoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_BlindedPaymentPathZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_BlindedPaymentPathZNoneZ clone() {
		long ret = bindings.CResult_CVec_BlindedPaymentPathZNoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedPaymentPathZNoneZ ret_hu_conv = Result_CVec_BlindedPaymentPathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
