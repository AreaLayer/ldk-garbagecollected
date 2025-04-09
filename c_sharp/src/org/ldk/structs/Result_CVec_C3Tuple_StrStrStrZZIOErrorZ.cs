using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_C3Tuple_StrStrStrZZIOErrorZ : CommonBase {
	Result_CVec_C3Tuple_StrStrStrZZIOErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_C3Tuple_StrStrStrZZIOErrorZ() {
		if (ptr != 0) { bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_free(ptr); }
	}

	internal static Result_CVec_C3Tuple_StrStrStrZZIOErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_is_ok(ptr)) {
			return new Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_OK(null, ptr);
		} else {
			return new Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_Err(null, ptr);
		}
	}
	public class Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_OK : Result_CVec_C3Tuple_StrStrStrZZIOErrorZ {
		public readonly ThreeTuple_StrStrStrZ[] res;
		internal Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_get_ok(ptr);
			int res_conv_23_len = InternalUtils.getArrayLength(res);
			ThreeTuple_StrStrStrZ[] res_conv_23_arr = new ThreeTuple_StrStrStrZ[res_conv_23_len];
			for (int x = 0; x < res_conv_23_len; x++) {
				long res_conv_23 = InternalUtils.getU64ArrayElem(res, x);
				ThreeTuple_StrStrStrZ res_conv_23_hu_conv = new ThreeTuple_StrStrStrZ(null, res_conv_23);
				if (res_conv_23_hu_conv != null) { res_conv_23_hu_conv.ptrs_to.AddLast(this); };
				res_conv_23_arr[x] = res_conv_23_hu_conv;
			}
			bindings.free_buffer(res);
			this.res = res_conv_23_arr;
		}
	}

	public class Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_Err : Result_CVec_C3Tuple_StrStrStrZZIOErrorZ {
		public readonly IOError err;
		internal Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ok(ThreeTuple_StrStrStrZ[] o) {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_ok(InternalUtils.encodeUint64Array(InternalUtils.mapArray(o, o_conv_23 => o_conv_23.ptr)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_CVec_C3Tuple_StrStrStrZZIOErrorZ err(IOError e) {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_err(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_CVec_C3Tuple_StrStrStrZZIOErrorZ clone() {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
