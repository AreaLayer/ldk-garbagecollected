using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_OfferIdDecodeErrorZ : CommonBase {
	Result_OfferIdDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_OfferIdDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_OfferIdDecodeErrorZ_free(ptr); }
	}

	internal static Result_OfferIdDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_OfferIdDecodeErrorZ_is_ok(ptr)) {
			return new Result_OfferIdDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_OfferIdDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_OfferIdDecodeErrorZ_OK : Result_OfferIdDecodeErrorZ {
		public readonly OfferId res;
		internal Result_OfferIdDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_OfferIdDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.OfferId res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.OfferId(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_OfferIdDecodeErrorZ_Err : Result_OfferIdDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_OfferIdDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_OfferIdDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_OfferIdDecodeErrorZ in the success state.
	 */
	public static Result_OfferIdDecodeErrorZ ok(org.ldk.structs.OfferId o) {
		long ret = bindings.CResult_OfferIdDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferIdDecodeErrorZ ret_hu_conv = Result_OfferIdDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OfferIdDecodeErrorZ in the error state.
	 */
	public static Result_OfferIdDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_OfferIdDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferIdDecodeErrorZ ret_hu_conv = Result_OfferIdDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_OfferIdDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_OfferIdDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_OfferIdDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_OfferIdDecodeErrorZ clone() {
		long ret = bindings.CResult_OfferIdDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferIdDecodeErrorZ ret_hu_conv = Result_OfferIdDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
