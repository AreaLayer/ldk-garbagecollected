using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_MessageContextDecodeErrorZ : CommonBase {
	Result_MessageContextDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_MessageContextDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_MessageContextDecodeErrorZ_free(ptr); }
	}

	internal static Result_MessageContextDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_MessageContextDecodeErrorZ_is_ok(ptr)) {
			return new Result_MessageContextDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_MessageContextDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_MessageContextDecodeErrorZ_OK : Result_MessageContextDecodeErrorZ {
		public readonly MessageContext res;
		internal Result_MessageContextDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_MessageContextDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.MessageContext res_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_MessageContextDecodeErrorZ_Err : Result_MessageContextDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_MessageContextDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_MessageContextDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_MessageContextDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_MessageContextDecodeErrorZ ok(org.ldk.structs.MessageContext o) {
		long ret = bindings.CResult_MessageContextDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MessageContextDecodeErrorZ ret_hu_conv = Result_MessageContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_MessageContextDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_MessageContextDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_MessageContextDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MessageContextDecodeErrorZ ret_hu_conv = Result_MessageContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_MessageContextDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_MessageContextDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_MessageContextDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_MessageContextDecodeErrorZ clone() {
		long ret = bindings.CResult_MessageContextDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MessageContextDecodeErrorZ ret_hu_conv = Result_MessageContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
