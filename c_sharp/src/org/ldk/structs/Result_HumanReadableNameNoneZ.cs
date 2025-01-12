using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_HumanReadableNameNoneZ : CommonBase {
	Result_HumanReadableNameNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_HumanReadableNameNoneZ() {
		if (ptr != 0) { bindings.CResult_HumanReadableNameNoneZ_free(ptr); }
	}

	internal static Result_HumanReadableNameNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_HumanReadableNameNoneZ_is_ok(ptr)) {
			return new Result_HumanReadableNameNoneZ_OK(null, ptr);
		} else {
			return new Result_HumanReadableNameNoneZ_Err(null, ptr);
		}
	}
	public class Result_HumanReadableNameNoneZ_OK : Result_HumanReadableNameNoneZ {
		public readonly HumanReadableName res;
		internal Result_HumanReadableNameNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_HumanReadableNameNoneZ_get_ok(ptr);
			org.ldk.structs.HumanReadableName res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.HumanReadableName(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_HumanReadableNameNoneZ_Err : Result_HumanReadableNameNoneZ {
		internal Result_HumanReadableNameNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_HumanReadableNameNoneZ in the success state.
	 */
	public static Result_HumanReadableNameNoneZ ok(org.ldk.structs.HumanReadableName o) {
		long ret = bindings.CResult_HumanReadableNameNoneZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameNoneZ ret_hu_conv = Result_HumanReadableNameNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_HumanReadableNameNoneZ in the error state.
	 */
	public static Result_HumanReadableNameNoneZ err() {
		long ret = bindings.CResult_HumanReadableNameNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameNoneZ ret_hu_conv = Result_HumanReadableNameNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_HumanReadableNameNoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_HumanReadableNameNoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_HumanReadableNameNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_HumanReadableNameNoneZ clone() {
		long ret = bindings.CResult_HumanReadableNameNoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameNoneZ ret_hu_conv = Result_HumanReadableNameNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
