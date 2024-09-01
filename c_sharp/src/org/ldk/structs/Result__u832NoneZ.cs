using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result__u832NoneZ : CommonBase {
	Result__u832NoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result__u832NoneZ() {
		if (ptr != 0) { bindings.CResult__u832NoneZ_free(ptr); }
	}

	internal static Result__u832NoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult__u832NoneZ_is_ok(ptr)) {
			return new Result__u832NoneZ_OK(null, ptr);
		} else {
			return new Result__u832NoneZ_Err(null, ptr);
		}
	}
	public class Result__u832NoneZ_OK : Result__u832NoneZ {
		public readonly byte[] res;
		internal Result__u832NoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult__u832NoneZ_get_ok(ptr);
			byte[] res_conv = InternalUtils.decodeUint8Array(res);
			this.res = res_conv;
		}
	}

	public class Result__u832NoneZ_Err : Result__u832NoneZ {
		internal Result__u832NoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult__u832NoneZ in the success state.
	 */
	public static Result__u832NoneZ ok(byte[] o) {
		long ret = bindings.CResult__u832NoneZ_ok(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(o, 32)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result__u832NoneZ ret_hu_conv = Result__u832NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult__u832NoneZ in the error state.
	 */
	public static Result__u832NoneZ err() {
		long ret = bindings.CResult__u832NoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result__u832NoneZ ret_hu_conv = Result__u832NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult__u832NoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult__u832NoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult__u832NoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result__u832NoneZ clone() {
		long ret = bindings.CResult__u832NoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result__u832NoneZ ret_hu_conv = Result__u832NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
