using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_LSPSRequestIdAPIErrorZ : CommonBase {
	Result_LSPSRequestIdAPIErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_LSPSRequestIdAPIErrorZ() {
		if (ptr != 0) { bindings.CResult_LSPSRequestIdAPIErrorZ_free(ptr); }
	}

	internal static Result_LSPSRequestIdAPIErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_LSPSRequestIdAPIErrorZ_is_ok(ptr)) {
			return new Result_LSPSRequestIdAPIErrorZ_OK(null, ptr);
		} else {
			return new Result_LSPSRequestIdAPIErrorZ_Err(null, ptr);
		}
	}
	public class Result_LSPSRequestIdAPIErrorZ_OK : Result_LSPSRequestIdAPIErrorZ {
		public readonly LSPSRequestId res;
		internal Result_LSPSRequestIdAPIErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_LSPSRequestIdAPIErrorZ_get_ok(ptr);
			org.ldk.structs.LSPSRequestId res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.LSPSRequestId(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_LSPSRequestIdAPIErrorZ_Err : Result_LSPSRequestIdAPIErrorZ {
		public readonly APIError err;
		internal Result_LSPSRequestIdAPIErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_LSPSRequestIdAPIErrorZ_get_err(ptr);
			org.ldk.structs.APIError err_hu_conv = org.ldk.structs.APIError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_LSPSRequestIdAPIErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_LSPSRequestIdAPIErrorZ ok(org.ldk.structs.LSPSRequestId o) {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSRequestIdAPIErrorZ ret_hu_conv = Result_LSPSRequestIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_LSPSRequestIdAPIErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_LSPSRequestIdAPIErrorZ err(org.ldk.structs.APIError e) {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSRequestIdAPIErrorZ ret_hu_conv = Result_LSPSRequestIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_LSPSRequestIdAPIErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_LSPSRequestIdAPIErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_LSPSRequestIdAPIErrorZ clone() {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSRequestIdAPIErrorZ ret_hu_conv = Result_LSPSRequestIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
