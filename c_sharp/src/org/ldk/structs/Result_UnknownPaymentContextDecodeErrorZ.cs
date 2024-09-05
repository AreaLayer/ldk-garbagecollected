using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UnknownPaymentContextDecodeErrorZ : CommonBase {
	Result_UnknownPaymentContextDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UnknownPaymentContextDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_UnknownPaymentContextDecodeErrorZ_free(ptr); }
	}

	internal static Result_UnknownPaymentContextDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_UnknownPaymentContextDecodeErrorZ_is_ok(ptr)) {
			return new Result_UnknownPaymentContextDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_UnknownPaymentContextDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_UnknownPaymentContextDecodeErrorZ_OK : Result_UnknownPaymentContextDecodeErrorZ {
		public readonly UnknownPaymentContext res;
		internal Result_UnknownPaymentContextDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_UnknownPaymentContextDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.UnknownPaymentContext res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UnknownPaymentContext(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UnknownPaymentContextDecodeErrorZ_Err : Result_UnknownPaymentContextDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_UnknownPaymentContextDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_UnknownPaymentContextDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_UnknownPaymentContextDecodeErrorZ in the success state.
	 */
	public static Result_UnknownPaymentContextDecodeErrorZ ok(org.ldk.structs.UnknownPaymentContext o) {
		long ret = bindings.CResult_UnknownPaymentContextDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnknownPaymentContextDecodeErrorZ ret_hu_conv = Result_UnknownPaymentContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UnknownPaymentContextDecodeErrorZ in the error state.
	 */
	public static Result_UnknownPaymentContextDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_UnknownPaymentContextDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnknownPaymentContextDecodeErrorZ ret_hu_conv = Result_UnknownPaymentContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_UnknownPaymentContextDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_UnknownPaymentContextDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UnknownPaymentContextDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UnknownPaymentContextDecodeErrorZ clone() {
		long ret = bindings.CResult_UnknownPaymentContextDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnknownPaymentContextDecodeErrorZ ret_hu_conv = Result_UnknownPaymentContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
