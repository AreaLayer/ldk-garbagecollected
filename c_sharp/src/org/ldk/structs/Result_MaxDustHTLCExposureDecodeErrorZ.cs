using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_MaxDustHTLCExposureDecodeErrorZ : CommonBase {
	Result_MaxDustHTLCExposureDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_MaxDustHTLCExposureDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_free(ptr); }
	}

	internal static Result_MaxDustHTLCExposureDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_is_ok(ptr)) {
			return new Result_MaxDustHTLCExposureDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_MaxDustHTLCExposureDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_MaxDustHTLCExposureDecodeErrorZ_OK : Result_MaxDustHTLCExposureDecodeErrorZ {
		public readonly MaxDustHTLCExposure res;
		internal Result_MaxDustHTLCExposureDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.MaxDustHTLCExposure res_hu_conv = org.ldk.structs.MaxDustHTLCExposure.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_MaxDustHTLCExposureDecodeErrorZ_Err : Result_MaxDustHTLCExposureDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_MaxDustHTLCExposureDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_MaxDustHTLCExposureDecodeErrorZ ok(org.ldk.structs.MaxDustHTLCExposure o) {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_MaxDustHTLCExposureDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_MaxDustHTLCExposureDecodeErrorZ clone() {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
