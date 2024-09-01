using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_AsyncPaymentsMessageDecodeErrorZ : CommonBase {
	Result_AsyncPaymentsMessageDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_AsyncPaymentsMessageDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_free(ptr); }
	}

	internal static Result_AsyncPaymentsMessageDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_is_ok(ptr)) {
			return new Result_AsyncPaymentsMessageDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_AsyncPaymentsMessageDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_AsyncPaymentsMessageDecodeErrorZ_OK : Result_AsyncPaymentsMessageDecodeErrorZ {
		public readonly AsyncPaymentsMessage res;
		internal Result_AsyncPaymentsMessageDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.AsyncPaymentsMessage res_hu_conv = org.ldk.structs.AsyncPaymentsMessage.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_AsyncPaymentsMessageDecodeErrorZ_Err : Result_AsyncPaymentsMessageDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_AsyncPaymentsMessageDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_AsyncPaymentsMessageDecodeErrorZ in the success state.
	 */
	public static Result_AsyncPaymentsMessageDecodeErrorZ ok(org.ldk.structs.AsyncPaymentsMessage o) {
		long ret = bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsMessageDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_AsyncPaymentsMessageDecodeErrorZ in the error state.
	 */
	public static Result_AsyncPaymentsMessageDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsMessageDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_AsyncPaymentsMessageDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_AsyncPaymentsMessageDecodeErrorZ clone() {
		long ret = bindings.CResult_AsyncPaymentsMessageDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsMessageDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
