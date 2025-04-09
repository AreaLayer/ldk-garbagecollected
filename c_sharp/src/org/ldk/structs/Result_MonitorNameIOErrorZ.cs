using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_MonitorNameIOErrorZ : CommonBase {
	Result_MonitorNameIOErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_MonitorNameIOErrorZ() {
		if (ptr != 0) { bindings.CResult_MonitorNameIOErrorZ_free(ptr); }
	}

	internal static Result_MonitorNameIOErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_MonitorNameIOErrorZ_is_ok(ptr)) {
			return new Result_MonitorNameIOErrorZ_OK(null, ptr);
		} else {
			return new Result_MonitorNameIOErrorZ_Err(null, ptr);
		}
	}
	public class Result_MonitorNameIOErrorZ_OK : Result_MonitorNameIOErrorZ {
		public readonly MonitorName res;
		internal Result_MonitorNameIOErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_MonitorNameIOErrorZ_get_ok(ptr);
			org.ldk.structs.MonitorName res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.MonitorName(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_MonitorNameIOErrorZ_Err : Result_MonitorNameIOErrorZ {
		public readonly IOError err;
		internal Result_MonitorNameIOErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = bindings.CResult_MonitorNameIOErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_MonitorNameIOErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_MonitorNameIOErrorZ ok(org.ldk.structs.MonitorName o) {
		long ret = bindings.CResult_MonitorNameIOErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MonitorNameIOErrorZ ret_hu_conv = Result_MonitorNameIOErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid ret_hu_conv being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after ret_hu_conv call, o is reset to null and is now a dummy object.
		o.ptr = 0;;
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_MonitorNameIOErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_MonitorNameIOErrorZ err(IOError e) {
		long ret = bindings.CResult_MonitorNameIOErrorZ_err(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MonitorNameIOErrorZ ret_hu_conv = Result_MonitorNameIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_MonitorNameIOErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
