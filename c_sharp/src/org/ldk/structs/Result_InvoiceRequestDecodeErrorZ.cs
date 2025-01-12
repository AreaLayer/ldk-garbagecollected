using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_InvoiceRequestDecodeErrorZ : CommonBase {
	Result_InvoiceRequestDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_InvoiceRequestDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_InvoiceRequestDecodeErrorZ_free(ptr); }
	}

	internal static Result_InvoiceRequestDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_InvoiceRequestDecodeErrorZ_is_ok(ptr)) {
			return new Result_InvoiceRequestDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_InvoiceRequestDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_InvoiceRequestDecodeErrorZ_OK : Result_InvoiceRequestDecodeErrorZ {
		public readonly InvoiceRequest res;
		internal Result_InvoiceRequestDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_InvoiceRequestDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.InvoiceRequest res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.InvoiceRequest(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_InvoiceRequestDecodeErrorZ_Err : Result_InvoiceRequestDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_InvoiceRequestDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_InvoiceRequestDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_InvoiceRequestDecodeErrorZ in the success state.
	 */
	public static Result_InvoiceRequestDecodeErrorZ ok(org.ldk.structs.InvoiceRequest o) {
		long ret = bindings.CResult_InvoiceRequestDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestDecodeErrorZ ret_hu_conv = Result_InvoiceRequestDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_InvoiceRequestDecodeErrorZ in the error state.
	 */
	public static Result_InvoiceRequestDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_InvoiceRequestDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestDecodeErrorZ ret_hu_conv = Result_InvoiceRequestDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_InvoiceRequestDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_InvoiceRequestDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_InvoiceRequestDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_InvoiceRequestDecodeErrorZ clone() {
		long ret = bindings.CResult_InvoiceRequestDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestDecodeErrorZ ret_hu_conv = Result_InvoiceRequestDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
