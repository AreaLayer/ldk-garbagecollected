using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_FundingCreatedDecodeErrorZ : CommonBase {
	Result_FundingCreatedDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_FundingCreatedDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_FundingCreatedDecodeErrorZ_free(ptr); }
	}

	internal static Result_FundingCreatedDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_FundingCreatedDecodeErrorZ_is_ok(ptr)) {
			return new Result_FundingCreatedDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_FundingCreatedDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_FundingCreatedDecodeErrorZ_OK : Result_FundingCreatedDecodeErrorZ {
		public readonly FundingCreated res;
		internal Result_FundingCreatedDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_FundingCreatedDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.FundingCreated res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.FundingCreated(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_FundingCreatedDecodeErrorZ_Err : Result_FundingCreatedDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_FundingCreatedDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_FundingCreatedDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_FundingCreatedDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_FundingCreatedDecodeErrorZ ok(org.ldk.structs.FundingCreated o) {
		long ret = bindings.CResult_FundingCreatedDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingCreatedDecodeErrorZ ret_hu_conv = Result_FundingCreatedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_FundingCreatedDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_FundingCreatedDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_FundingCreatedDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingCreatedDecodeErrorZ ret_hu_conv = Result_FundingCreatedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_FundingCreatedDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_FundingCreatedDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_FundingCreatedDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_FundingCreatedDecodeErrorZ clone() {
		long ret = bindings.CResult_FundingCreatedDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingCreatedDecodeErrorZ ret_hu_conv = Result_FundingCreatedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
