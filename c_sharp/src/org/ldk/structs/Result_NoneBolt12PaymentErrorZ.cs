using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NoneBolt12PaymentErrorZ : CommonBase {
	Result_NoneBolt12PaymentErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NoneBolt12PaymentErrorZ() {
		if (ptr != 0) { bindings.CResult_NoneBolt12PaymentErrorZ_free(ptr); }
	}

	internal static Result_NoneBolt12PaymentErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_NoneBolt12PaymentErrorZ_is_ok(ptr)) {
			return new Result_NoneBolt12PaymentErrorZ_OK(null, ptr);
		} else {
			return new Result_NoneBolt12PaymentErrorZ_Err(null, ptr);
		}
	}
	public class Result_NoneBolt12PaymentErrorZ_OK : Result_NoneBolt12PaymentErrorZ {
		internal Result_NoneBolt12PaymentErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NoneBolt12PaymentErrorZ_Err : Result_NoneBolt12PaymentErrorZ {
		public readonly Bolt12PaymentError err;
		internal Result_NoneBolt12PaymentErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_NoneBolt12PaymentErrorZ_get_err(ptr);
			org.ldk.structs.Bolt12PaymentError err_hu_conv = org.ldk.structs.Bolt12PaymentError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NoneBolt12PaymentErrorZ in the success state.
	 */
	public static Result_NoneBolt12PaymentErrorZ ok() {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_ok();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12PaymentErrorZ ret_hu_conv = Result_NoneBolt12PaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NoneBolt12PaymentErrorZ in the error state.
	 */
	public static Result_NoneBolt12PaymentErrorZ err(org.ldk.structs.Bolt12PaymentError e) {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12PaymentErrorZ ret_hu_conv = Result_NoneBolt12PaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_NoneBolt12PaymentErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NoneBolt12PaymentErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NoneBolt12PaymentErrorZ clone() {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12PaymentErrorZ ret_hu_conv = Result_NoneBolt12PaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
