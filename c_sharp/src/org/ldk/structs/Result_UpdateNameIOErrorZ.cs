using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UpdateNameIOErrorZ : CommonBase {
	Result_UpdateNameIOErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UpdateNameIOErrorZ() {
		if (ptr != 0) { bindings.CResult_UpdateNameIOErrorZ_free(ptr); }
	}

	internal static Result_UpdateNameIOErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_UpdateNameIOErrorZ_is_ok(ptr)) {
			return new Result_UpdateNameIOErrorZ_OK(null, ptr);
		} else {
			return new Result_UpdateNameIOErrorZ_Err(null, ptr);
		}
	}
	public class Result_UpdateNameIOErrorZ_OK : Result_UpdateNameIOErrorZ {
		public readonly UpdateName res;
		internal Result_UpdateNameIOErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_UpdateNameIOErrorZ_get_ok(ptr);
			org.ldk.structs.UpdateName res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UpdateName(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UpdateNameIOErrorZ_Err : Result_UpdateNameIOErrorZ {
		public readonly IOError err;
		internal Result_UpdateNameIOErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = bindings.CResult_UpdateNameIOErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_UpdateNameIOErrorZ in the success state.
	 */
	public static Result_UpdateNameIOErrorZ ok(org.ldk.structs.UpdateName o) {
		long ret = bindings.CResult_UpdateNameIOErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateNameIOErrorZ ret_hu_conv = Result_UpdateNameIOErrorZ.constr_from_ptr(ret);
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
	 * Creates a new CResult_UpdateNameIOErrorZ in the error state.
	 */
	public static Result_UpdateNameIOErrorZ err(IOError e) {
		long ret = bindings.CResult_UpdateNameIOErrorZ_err(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateNameIOErrorZ ret_hu_conv = Result_UpdateNameIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_UpdateNameIOErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
