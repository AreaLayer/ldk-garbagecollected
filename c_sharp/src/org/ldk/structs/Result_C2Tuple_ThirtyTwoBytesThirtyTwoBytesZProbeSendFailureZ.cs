using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ : CommonBase {
	Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ(object _dummy, long ptr) : base(ptr) { }
	~Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ() {
		if (ptr != 0) { bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_free(ptr); }
	}

	internal static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ constr_from_ptr(long ptr) {
		if (bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_is_ok(ptr)) {
			return new Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_Err(null, ptr);
		}
	}
	public class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_OK : Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ {
		public readonly TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ res;
		internal Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_get_ok(ptr);
			TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ res_hu_conv = new TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_Err : Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ {
		public readonly ProbeSendFailure err;
		internal Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_get_err(ptr);
			org.ldk.structs.ProbeSendFailure err_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ in the success state.
	 */
	public static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ok(org.ldk.structs.TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ o) {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ in the error state.
	 */
	public static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ err(org.ldk.structs.ProbeSendFailure e) {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ clone() {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
