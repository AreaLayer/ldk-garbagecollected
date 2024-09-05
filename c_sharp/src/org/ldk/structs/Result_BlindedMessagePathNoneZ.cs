using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_BlindedMessagePathNoneZ : CommonBase {
	Result_BlindedMessagePathNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_BlindedMessagePathNoneZ() {
		if (ptr != 0) { bindings.CResult_BlindedMessagePathNoneZ_free(ptr); }
	}

	internal static Result_BlindedMessagePathNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_BlindedMessagePathNoneZ_is_ok(ptr)) {
			return new Result_BlindedMessagePathNoneZ_OK(null, ptr);
		} else {
			return new Result_BlindedMessagePathNoneZ_Err(null, ptr);
		}
	}
	public class Result_BlindedMessagePathNoneZ_OK : Result_BlindedMessagePathNoneZ {
		public readonly BlindedMessagePath res;
		internal Result_BlindedMessagePathNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_BlindedMessagePathNoneZ_get_ok(ptr);
			org.ldk.structs.BlindedMessagePath res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.BlindedMessagePath(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_BlindedMessagePathNoneZ_Err : Result_BlindedMessagePathNoneZ {
		internal Result_BlindedMessagePathNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_BlindedMessagePathNoneZ in the success state.
	 */
	public static Result_BlindedMessagePathNoneZ ok(org.ldk.structs.BlindedMessagePath o) {
		long ret = bindings.CResult_BlindedMessagePathNoneZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedMessagePathNoneZ ret_hu_conv = Result_BlindedMessagePathNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_BlindedMessagePathNoneZ in the error state.
	 */
	public static Result_BlindedMessagePathNoneZ err() {
		long ret = bindings.CResult_BlindedMessagePathNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedMessagePathNoneZ ret_hu_conv = Result_BlindedMessagePathNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_BlindedMessagePathNoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_BlindedMessagePathNoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_BlindedMessagePathNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_BlindedMessagePathNoneZ clone() {
		long ret = bindings.CResult_BlindedMessagePathNoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedMessagePathNoneZ ret_hu_conv = Result_BlindedMessagePathNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
