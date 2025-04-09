using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_BestBlockDecodeErrorZ : CommonBase {
	Result_BestBlockDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_BestBlockDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_BestBlockDecodeErrorZ_free(ptr); }
	}

	internal static Result_BestBlockDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_BestBlockDecodeErrorZ_is_ok(ptr)) {
			return new Result_BestBlockDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_BestBlockDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_BestBlockDecodeErrorZ_OK : Result_BestBlockDecodeErrorZ {
		public readonly BestBlock res;
		internal Result_BestBlockDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_BestBlockDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.BestBlock res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.BestBlock(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_BestBlockDecodeErrorZ_Err : Result_BestBlockDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_BestBlockDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_BestBlockDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_BestBlockDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_BestBlockDecodeErrorZ ok(org.ldk.structs.BestBlock o) {
		long ret = bindings.CResult_BestBlockDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BestBlockDecodeErrorZ ret_hu_conv = Result_BestBlockDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_BestBlockDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_BestBlockDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_BestBlockDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BestBlockDecodeErrorZ ret_hu_conv = Result_BestBlockDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_BestBlockDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_BestBlockDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_BestBlockDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_BestBlockDecodeErrorZ clone() {
		long ret = bindings.CResult_BestBlockDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BestBlockDecodeErrorZ ret_hu_conv = Result_BestBlockDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
