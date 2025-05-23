using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_InFlightHtlcsDecodeErrorZ : CommonBase {
	Result_InFlightHtlcsDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_InFlightHtlcsDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_InFlightHtlcsDecodeErrorZ_free(ptr); }
	}

	internal static Result_InFlightHtlcsDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_InFlightHtlcsDecodeErrorZ_is_ok(ptr)) {
			return new Result_InFlightHtlcsDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_InFlightHtlcsDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_InFlightHtlcsDecodeErrorZ_OK : Result_InFlightHtlcsDecodeErrorZ {
		public readonly InFlightHtlcs res;
		internal Result_InFlightHtlcsDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_InFlightHtlcsDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.InFlightHtlcs res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.InFlightHtlcs(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_InFlightHtlcsDecodeErrorZ_Err : Result_InFlightHtlcsDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_InFlightHtlcsDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_InFlightHtlcsDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_InFlightHtlcsDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_InFlightHtlcsDecodeErrorZ ok(org.ldk.structs.InFlightHtlcs o) {
		long ret = bindings.CResult_InFlightHtlcsDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InFlightHtlcsDecodeErrorZ ret_hu_conv = Result_InFlightHtlcsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_InFlightHtlcsDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_InFlightHtlcsDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_InFlightHtlcsDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InFlightHtlcsDecodeErrorZ ret_hu_conv = Result_InFlightHtlcsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_InFlightHtlcsDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_InFlightHtlcsDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_InFlightHtlcsDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_InFlightHtlcsDecodeErrorZ clone() {
		long ret = bindings.CResult_InFlightHtlcsDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InFlightHtlcsDecodeErrorZ ret_hu_conv = Result_InFlightHtlcsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
