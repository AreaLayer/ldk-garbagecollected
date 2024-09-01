using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ReleaseHeldHtlcDecodeErrorZ : CommonBase {
	Result_ReleaseHeldHtlcDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ReleaseHeldHtlcDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_free(ptr); }
	}

	internal static Result_ReleaseHeldHtlcDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_is_ok(ptr)) {
			return new Result_ReleaseHeldHtlcDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ReleaseHeldHtlcDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ReleaseHeldHtlcDecodeErrorZ_OK : Result_ReleaseHeldHtlcDecodeErrorZ {
		public readonly ReleaseHeldHtlc res;
		internal Result_ReleaseHeldHtlcDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.ReleaseHeldHtlc res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ReleaseHeldHtlcDecodeErrorZ_Err : Result_ReleaseHeldHtlcDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ReleaseHeldHtlcDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ReleaseHeldHtlcDecodeErrorZ in the success state.
	 */
	public static Result_ReleaseHeldHtlcDecodeErrorZ ok(org.ldk.structs.ReleaseHeldHtlc o) {
		long ret = bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReleaseHeldHtlcDecodeErrorZ ret_hu_conv = Result_ReleaseHeldHtlcDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ReleaseHeldHtlcDecodeErrorZ in the error state.
	 */
	public static Result_ReleaseHeldHtlcDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReleaseHeldHtlcDecodeErrorZ ret_hu_conv = Result_ReleaseHeldHtlcDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ReleaseHeldHtlcDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ReleaseHeldHtlcDecodeErrorZ clone() {
		long ret = bindings.CResult_ReleaseHeldHtlcDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReleaseHeldHtlcDecodeErrorZ ret_hu_conv = Result_ReleaseHeldHtlcDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
