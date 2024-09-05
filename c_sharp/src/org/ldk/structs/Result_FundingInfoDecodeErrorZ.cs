using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_FundingInfoDecodeErrorZ : CommonBase {
	Result_FundingInfoDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_FundingInfoDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_FundingInfoDecodeErrorZ_free(ptr); }
	}

	internal static Result_FundingInfoDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_FundingInfoDecodeErrorZ_is_ok(ptr)) {
			return new Result_FundingInfoDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_FundingInfoDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_FundingInfoDecodeErrorZ_OK : Result_FundingInfoDecodeErrorZ {
		public readonly FundingInfo res;
		internal Result_FundingInfoDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_FundingInfoDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.FundingInfo res_hu_conv = org.ldk.structs.FundingInfo.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_FundingInfoDecodeErrorZ_Err : Result_FundingInfoDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_FundingInfoDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_FundingInfoDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_FundingInfoDecodeErrorZ in the success state.
	 */
	public static Result_FundingInfoDecodeErrorZ ok(org.ldk.structs.FundingInfo o) {
		long ret = bindings.CResult_FundingInfoDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingInfoDecodeErrorZ ret_hu_conv = Result_FundingInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_FundingInfoDecodeErrorZ in the error state.
	 */
	public static Result_FundingInfoDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_FundingInfoDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingInfoDecodeErrorZ ret_hu_conv = Result_FundingInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_FundingInfoDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_FundingInfoDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_FundingInfoDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_FundingInfoDecodeErrorZ clone() {
		long ret = bindings.CResult_FundingInfoDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingInfoDecodeErrorZ ret_hu_conv = Result_FundingInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
