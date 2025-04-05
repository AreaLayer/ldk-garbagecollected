using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_HumanReadableNameDecodeErrorZ : CommonBase {
	Result_HumanReadableNameDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_HumanReadableNameDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_HumanReadableNameDecodeErrorZ_free(ptr); }
	}

	internal static Result_HumanReadableNameDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_HumanReadableNameDecodeErrorZ_is_ok(ptr)) {
			return new Result_HumanReadableNameDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_HumanReadableNameDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_HumanReadableNameDecodeErrorZ_OK : Result_HumanReadableNameDecodeErrorZ {
		public readonly HumanReadableName res;
		internal Result_HumanReadableNameDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_HumanReadableNameDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.HumanReadableName res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.HumanReadableName(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_HumanReadableNameDecodeErrorZ_Err : Result_HumanReadableNameDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_HumanReadableNameDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_HumanReadableNameDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_HumanReadableNameDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_HumanReadableNameDecodeErrorZ ok(org.ldk.structs.HumanReadableName o) {
		long ret = bindings.CResult_HumanReadableNameDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameDecodeErrorZ ret_hu_conv = Result_HumanReadableNameDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_HumanReadableNameDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_HumanReadableNameDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_HumanReadableNameDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameDecodeErrorZ ret_hu_conv = Result_HumanReadableNameDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_HumanReadableNameDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_HumanReadableNameDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_HumanReadableNameDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_HumanReadableNameDecodeErrorZ clone() {
		long ret = bindings.CResult_HumanReadableNameDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameDecodeErrorZ ret_hu_conv = Result_HumanReadableNameDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
