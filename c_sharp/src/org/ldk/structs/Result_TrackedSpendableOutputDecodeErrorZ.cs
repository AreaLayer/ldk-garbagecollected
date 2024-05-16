using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_TrackedSpendableOutputDecodeErrorZ : CommonBase {
	Result_TrackedSpendableOutputDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_TrackedSpendableOutputDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_TrackedSpendableOutputDecodeErrorZ_free(ptr); }
	}

	internal static Result_TrackedSpendableOutputDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_TrackedSpendableOutputDecodeErrorZ_is_ok(ptr)) {
			return new Result_TrackedSpendableOutputDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_TrackedSpendableOutputDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_TrackedSpendableOutputDecodeErrorZ_OK : Result_TrackedSpendableOutputDecodeErrorZ {
		public readonly TrackedSpendableOutput res;
		internal Result_TrackedSpendableOutputDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_TrackedSpendableOutputDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.TrackedSpendableOutput res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.TrackedSpendableOutput(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_TrackedSpendableOutputDecodeErrorZ_Err : Result_TrackedSpendableOutputDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_TrackedSpendableOutputDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_TrackedSpendableOutputDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_TrackedSpendableOutputDecodeErrorZ in the success state.
	 */
	public static Result_TrackedSpendableOutputDecodeErrorZ ok(org.ldk.structs.TrackedSpendableOutput o) {
		long ret = bindings.CResult_TrackedSpendableOutputDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TrackedSpendableOutputDecodeErrorZ ret_hu_conv = Result_TrackedSpendableOutputDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_TrackedSpendableOutputDecodeErrorZ in the error state.
	 */
	public static Result_TrackedSpendableOutputDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_TrackedSpendableOutputDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TrackedSpendableOutputDecodeErrorZ ret_hu_conv = Result_TrackedSpendableOutputDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_TrackedSpendableOutputDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_TrackedSpendableOutputDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_TrackedSpendableOutputDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_TrackedSpendableOutputDecodeErrorZ clone() {
		long ret = bindings.CResult_TrackedSpendableOutputDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TrackedSpendableOutputDecodeErrorZ ret_hu_conv = Result_TrackedSpendableOutputDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
