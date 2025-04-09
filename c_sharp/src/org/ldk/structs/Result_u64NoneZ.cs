using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_u64NoneZ : CommonBase {
	Result_u64NoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_u64NoneZ() {
		if (ptr != 0) { bindings.CResult_u64NoneZ_free(ptr); }
	}

	internal static Result_u64NoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_u64NoneZ_is_ok(ptr)) {
			return new Result_u64NoneZ_OK(null, ptr);
		} else {
			return new Result_u64NoneZ_Err(null, ptr);
		}
	}
	public class Result_u64NoneZ_OK : Result_u64NoneZ {
		public readonly long res;
		internal Result_u64NoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			this.res = bindings.CResult_u64NoneZ_get_ok(ptr);
		}
	}

	public class Result_u64NoneZ_Err : Result_u64NoneZ {
		internal Result_u64NoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_u64NoneZ in the success state.
	 */
	public static org.ldk.structs.Result_u64NoneZ ok(long o) {
		long ret = bindings.CResult_u64NoneZ_ok(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_u64NoneZ in the error state.
	 */
	public static org.ldk.structs.Result_u64NoneZ err() {
		long ret = bindings.CResult_u64NoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_u64NoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_u64NoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_u64NoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_u64NoneZ clone() {
		long ret = bindings.CResult_u64NoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
