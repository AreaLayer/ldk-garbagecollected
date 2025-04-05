using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NoneReplayEventZ : CommonBase {
	Result_NoneReplayEventZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NoneReplayEventZ() {
		if (ptr != 0) { bindings.CResult_NoneReplayEventZ_free(ptr); }
	}

	internal static Result_NoneReplayEventZ constr_from_ptr(long ptr) {
		if (bindings.CResult_NoneReplayEventZ_is_ok(ptr)) {
			return new Result_NoneReplayEventZ_OK(null, ptr);
		} else {
			return new Result_NoneReplayEventZ_Err(null, ptr);
		}
	}
	public class Result_NoneReplayEventZ_OK : Result_NoneReplayEventZ {
		internal Result_NoneReplayEventZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NoneReplayEventZ_Err : Result_NoneReplayEventZ {
		public readonly ReplayEvent err;
		internal Result_NoneReplayEventZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_NoneReplayEventZ_get_err(ptr);
			org.ldk.structs.ReplayEvent err_hu_conv = null; if (err < 0 || err > 4096) { err_hu_conv = new org.ldk.structs.ReplayEvent(null, err); }
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NoneReplayEventZ in the success state.
	 */
	public static org.ldk.structs.Result_NoneReplayEventZ ok() {
		long ret = bindings.CResult_NoneReplayEventZ_ok();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneReplayEventZ ret_hu_conv = Result_NoneReplayEventZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NoneReplayEventZ in the error state.
	 */
	public static org.ldk.structs.Result_NoneReplayEventZ err(org.ldk.structs.ReplayEvent e) {
		long ret = bindings.CResult_NoneReplayEventZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneReplayEventZ ret_hu_conv = Result_NoneReplayEventZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_NoneReplayEventZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_NoneReplayEventZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NoneReplayEventZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_NoneReplayEventZ clone() {
		long ret = bindings.CResult_NoneReplayEventZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneReplayEventZ ret_hu_conv = Result_NoneReplayEventZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
