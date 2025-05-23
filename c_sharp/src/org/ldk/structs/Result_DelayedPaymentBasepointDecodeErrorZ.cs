using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_DelayedPaymentBasepointDecodeErrorZ : CommonBase {
	Result_DelayedPaymentBasepointDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_DelayedPaymentBasepointDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_free(ptr); }
	}

	internal static Result_DelayedPaymentBasepointDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_is_ok(ptr)) {
			return new Result_DelayedPaymentBasepointDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_DelayedPaymentBasepointDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_DelayedPaymentBasepointDecodeErrorZ_OK : Result_DelayedPaymentBasepointDecodeErrorZ {
		public readonly DelayedPaymentBasepoint res;
		internal Result_DelayedPaymentBasepointDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.DelayedPaymentBasepoint res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.DelayedPaymentBasepoint(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_DelayedPaymentBasepointDecodeErrorZ_Err : Result_DelayedPaymentBasepointDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_DelayedPaymentBasepointDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_DelayedPaymentBasepointDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_DelayedPaymentBasepointDecodeErrorZ ok(org.ldk.structs.DelayedPaymentBasepoint o) {
		long ret = bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentBasepointDecodeErrorZ ret_hu_conv = Result_DelayedPaymentBasepointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_DelayedPaymentBasepointDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_DelayedPaymentBasepointDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentBasepointDecodeErrorZ ret_hu_conv = Result_DelayedPaymentBasepointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_DelayedPaymentBasepointDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_DelayedPaymentBasepointDecodeErrorZ clone() {
		long ret = bindings.CResult_DelayedPaymentBasepointDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentBasepointDecodeErrorZ ret_hu_conv = Result_DelayedPaymentBasepointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
