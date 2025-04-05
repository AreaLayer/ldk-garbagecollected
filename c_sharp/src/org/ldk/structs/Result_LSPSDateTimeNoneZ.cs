using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_LSPSDateTimeNoneZ : CommonBase {
	Result_LSPSDateTimeNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_LSPSDateTimeNoneZ() {
		if (ptr != 0) { bindings.CResult_LSPSDateTimeNoneZ_free(ptr); }
	}

	internal static Result_LSPSDateTimeNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_LSPSDateTimeNoneZ_is_ok(ptr)) {
			return new Result_LSPSDateTimeNoneZ_OK(null, ptr);
		} else {
			return new Result_LSPSDateTimeNoneZ_Err(null, ptr);
		}
	}
	public class Result_LSPSDateTimeNoneZ_OK : Result_LSPSDateTimeNoneZ {
		public readonly LSPSDateTime res;
		internal Result_LSPSDateTimeNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_LSPSDateTimeNoneZ_get_ok(ptr);
			org.ldk.structs.LSPSDateTime res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.LSPSDateTime(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_LSPSDateTimeNoneZ_Err : Result_LSPSDateTimeNoneZ {
		internal Result_LSPSDateTimeNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_LSPSDateTimeNoneZ in the success state.
	 */
	public static org.ldk.structs.Result_LSPSDateTimeNoneZ ok(org.ldk.structs.LSPSDateTime o) {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_LSPSDateTimeNoneZ in the error state.
	 */
	public static org.ldk.structs.Result_LSPSDateTimeNoneZ err() {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_LSPSDateTimeNoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_LSPSDateTimeNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_LSPSDateTimeNoneZ clone() {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
