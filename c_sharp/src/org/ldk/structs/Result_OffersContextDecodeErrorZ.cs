using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_OffersContextDecodeErrorZ : CommonBase {
	Result_OffersContextDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_OffersContextDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_OffersContextDecodeErrorZ_free(ptr); }
	}

	internal static Result_OffersContextDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_OffersContextDecodeErrorZ_is_ok(ptr)) {
			return new Result_OffersContextDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_OffersContextDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_OffersContextDecodeErrorZ_OK : Result_OffersContextDecodeErrorZ {
		public readonly OffersContext res;
		internal Result_OffersContextDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_OffersContextDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.OffersContext res_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_OffersContextDecodeErrorZ_Err : Result_OffersContextDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_OffersContextDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_OffersContextDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_OffersContextDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_OffersContextDecodeErrorZ ok(org.ldk.structs.OffersContext o) {
		long ret = bindings.CResult_OffersContextDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersContextDecodeErrorZ ret_hu_conv = Result_OffersContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OffersContextDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_OffersContextDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_OffersContextDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersContextDecodeErrorZ ret_hu_conv = Result_OffersContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_OffersContextDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_OffersContextDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_OffersContextDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_OffersContextDecodeErrorZ clone() {
		long ret = bindings.CResult_OffersContextDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersContextDecodeErrorZ ret_hu_conv = Result_OffersContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
