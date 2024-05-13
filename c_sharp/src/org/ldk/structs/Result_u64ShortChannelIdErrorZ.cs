using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_u64ShortChannelIdErrorZ : CommonBase {
	Result_u64ShortChannelIdErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_u64ShortChannelIdErrorZ() {
		if (ptr != 0) { bindings.CResult_u64ShortChannelIdErrorZ_free(ptr); }
	}

	internal static Result_u64ShortChannelIdErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_u64ShortChannelIdErrorZ_is_ok(ptr)) {
			return new Result_u64ShortChannelIdErrorZ_OK(null, ptr);
		} else {
			return new Result_u64ShortChannelIdErrorZ_Err(null, ptr);
		}
	}
	public class Result_u64ShortChannelIdErrorZ_OK : Result_u64ShortChannelIdErrorZ {
		public readonly long res;
		internal Result_u64ShortChannelIdErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			this.res = bindings.CResult_u64ShortChannelIdErrorZ_get_ok(ptr);
		}
	}

	public class Result_u64ShortChannelIdErrorZ_Err : Result_u64ShortChannelIdErrorZ {
		public readonly ShortChannelIdError err;
		internal Result_u64ShortChannelIdErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = bindings.CResult_u64ShortChannelIdErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_u64ShortChannelIdErrorZ in the success state.
	 */
	public static Result_u64ShortChannelIdErrorZ ok(long o) {
		long ret = bindings.CResult_u64ShortChannelIdErrorZ_ok(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64ShortChannelIdErrorZ ret_hu_conv = Result_u64ShortChannelIdErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_u64ShortChannelIdErrorZ in the error state.
	 */
	public static Result_u64ShortChannelIdErrorZ err(ShortChannelIdError e) {
		long ret = bindings.CResult_u64ShortChannelIdErrorZ_err(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64ShortChannelIdErrorZ ret_hu_conv = Result_u64ShortChannelIdErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_u64ShortChannelIdErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
