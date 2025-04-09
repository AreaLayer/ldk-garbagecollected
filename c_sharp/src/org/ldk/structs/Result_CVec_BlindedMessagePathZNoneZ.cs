using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_BlindedMessagePathZNoneZ : CommonBase {
	Result_CVec_BlindedMessagePathZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_BlindedMessagePathZNoneZ() {
		if (ptr != 0) { bindings.CResult_CVec_BlindedMessagePathZNoneZ_free(ptr); }
	}

	internal static Result_CVec_BlindedMessagePathZNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_CVec_BlindedMessagePathZNoneZ_is_ok(ptr)) {
			return new Result_CVec_BlindedMessagePathZNoneZ_OK(null, ptr);
		} else {
			return new Result_CVec_BlindedMessagePathZNoneZ_Err(null, ptr);
		}
	}
	public class Result_CVec_BlindedMessagePathZNoneZ_OK : Result_CVec_BlindedMessagePathZNoneZ {
		public readonly BlindedMessagePath[] res;
		internal Result_CVec_BlindedMessagePathZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_CVec_BlindedMessagePathZNoneZ_get_ok(ptr);
			int res_conv_20_len = InternalUtils.getArrayLength(res);
			BlindedMessagePath[] res_conv_20_arr = new BlindedMessagePath[res_conv_20_len];
			for (int u = 0; u < res_conv_20_len; u++) {
				long res_conv_20 = InternalUtils.getU64ArrayElem(res, u);
				org.ldk.structs.BlindedMessagePath res_conv_20_hu_conv = null; if (res_conv_20 < 0 || res_conv_20 > 4096) { res_conv_20_hu_conv = new org.ldk.structs.BlindedMessagePath(null, res_conv_20); }
				if (res_conv_20_hu_conv != null) { res_conv_20_hu_conv.ptrs_to.AddLast(this); };
				res_conv_20_arr[u] = res_conv_20_hu_conv;
			}
			bindings.free_buffer(res);
			this.res = res_conv_20_arr;
		}
	}

	public class Result_CVec_BlindedMessagePathZNoneZ_Err : Result_CVec_BlindedMessagePathZNoneZ {
		internal Result_CVec_BlindedMessagePathZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_CVec_BlindedMessagePathZNoneZ in the success state.
	 */
	public static org.ldk.structs.Result_CVec_BlindedMessagePathZNoneZ ok(BlindedMessagePath[] o) {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_ok(InternalUtils.encodeUint64Array(InternalUtils.mapArray(o, o_conv_20 => o_conv_20.ptr)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedMessagePathZNoneZ ret_hu_conv = Result_CVec_BlindedMessagePathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_BlindedMessagePathZNoneZ in the error state.
	 */
	public static org.ldk.structs.Result_CVec_BlindedMessagePathZNoneZ err() {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedMessagePathZNoneZ ret_hu_conv = Result_CVec_BlindedMessagePathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_BlindedMessagePathZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_CVec_BlindedMessagePathZNoneZ clone() {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedMessagePathZNoneZ ret_hu_conv = Result_CVec_BlindedMessagePathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
