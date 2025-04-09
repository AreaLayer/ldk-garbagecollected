using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_AsyncPaymentsContextDecodeErrorZ : CommonBase {
	Result_AsyncPaymentsContextDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_AsyncPaymentsContextDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_AsyncPaymentsContextDecodeErrorZ_free(ptr); }
	}

	internal static Result_AsyncPaymentsContextDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_AsyncPaymentsContextDecodeErrorZ_is_ok(ptr)) {
			return new Result_AsyncPaymentsContextDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_AsyncPaymentsContextDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_AsyncPaymentsContextDecodeErrorZ_OK : Result_AsyncPaymentsContextDecodeErrorZ {
		public readonly AsyncPaymentsContext res;
		internal Result_AsyncPaymentsContextDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_AsyncPaymentsContextDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.AsyncPaymentsContext res_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_AsyncPaymentsContextDecodeErrorZ_Err : Result_AsyncPaymentsContextDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_AsyncPaymentsContextDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_AsyncPaymentsContextDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_AsyncPaymentsContextDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_AsyncPaymentsContextDecodeErrorZ ok(org.ldk.structs.AsyncPaymentsContext o) {
		long ret = bindings.CResult_AsyncPaymentsContextDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsContextDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_AsyncPaymentsContextDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_AsyncPaymentsContextDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_AsyncPaymentsContextDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsContextDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_AsyncPaymentsContextDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_AsyncPaymentsContextDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_AsyncPaymentsContextDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_AsyncPaymentsContextDecodeErrorZ clone() {
		long ret = bindings.CResult_AsyncPaymentsContextDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsContextDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
