using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_Bolt12RefundContextDecodeErrorZ : CommonBase {
	Result_Bolt12RefundContextDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_Bolt12RefundContextDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_Bolt12RefundContextDecodeErrorZ_free(ptr); }
	}

	internal static Result_Bolt12RefundContextDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_Bolt12RefundContextDecodeErrorZ_is_ok(ptr)) {
			return new Result_Bolt12RefundContextDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_Bolt12RefundContextDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_Bolt12RefundContextDecodeErrorZ_OK : Result_Bolt12RefundContextDecodeErrorZ {
		public readonly Bolt12RefundContext res;
		internal Result_Bolt12RefundContextDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_Bolt12RefundContextDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.Bolt12RefundContext res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Bolt12RefundContext(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_Bolt12RefundContextDecodeErrorZ_Err : Result_Bolt12RefundContextDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_Bolt12RefundContextDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_Bolt12RefundContextDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_Bolt12RefundContextDecodeErrorZ in the success state.
	 */
	public static Result_Bolt12RefundContextDecodeErrorZ ok(org.ldk.structs.Bolt12RefundContext o) {
		long ret = bindings.CResult_Bolt12RefundContextDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt12RefundContextDecodeErrorZ ret_hu_conv = Result_Bolt12RefundContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_Bolt12RefundContextDecodeErrorZ in the error state.
	 */
	public static Result_Bolt12RefundContextDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_Bolt12RefundContextDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt12RefundContextDecodeErrorZ ret_hu_conv = Result_Bolt12RefundContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_Bolt12RefundContextDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_Bolt12RefundContextDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_Bolt12RefundContextDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_Bolt12RefundContextDecodeErrorZ clone() {
		long ret = bindings.CResult_Bolt12RefundContextDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt12RefundContextDecodeErrorZ ret_hu_conv = Result_Bolt12RefundContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
