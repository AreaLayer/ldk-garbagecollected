using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ : CommonBase {
	Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_free(ptr); }
	}

	internal static Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_is_ok(ptr)) {
			return new Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ_OK : Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ {
		public readonly Option_OutboundHTLCStateDetailsZ res;
		internal Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.Option_OutboundHTLCStateDetailsZ res_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ_Err : Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ ok(org.ldk.structs.Option_OutboundHTLCStateDetailsZ o) {
		long ret = bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ ret_hu_conv = Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ ret_hu_conv = Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ clone() {
		long ret = bindings.CResult_COption_OutboundHTLCStateDetailsZDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ ret_hu_conv = Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
