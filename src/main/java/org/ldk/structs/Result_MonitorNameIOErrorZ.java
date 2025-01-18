package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_MonitorNameIOErrorZ extends CommonBase {
	private Result_MonitorNameIOErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_MonitorNameIOErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_MonitorNameIOErrorZ_free(ptr); ptr = 0; }
	}

	static Result_MonitorNameIOErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_MonitorNameIOErrorZ_is_ok(ptr)) {
			return new Result_MonitorNameIOErrorZ_OK(null, ptr);
		} else {
			return new Result_MonitorNameIOErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_MonitorNameIOErrorZ_OK extends Result_MonitorNameIOErrorZ {
		public final MonitorName res;
		private Result_MonitorNameIOErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_MonitorNameIOErrorZ_get_ok(ptr);
			org.ldk.structs.MonitorName res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.MonitorName(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_MonitorNameIOErrorZ_Err extends Result_MonitorNameIOErrorZ {
		public final IOError err;
		private Result_MonitorNameIOErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.err = bindings.CResult_MonitorNameIOErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_MonitorNameIOErrorZ in the success state.
	 */
	public static Result_MonitorNameIOErrorZ ok(org.ldk.structs.MonitorName o) {
		long ret = bindings.CResult_MonitorNameIOErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MonitorNameIOErrorZ ret_hu_conv = Result_MonitorNameIOErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o); };
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
	public static Result_MonitorNameIOErrorZ err(org.ldk.enums.IOError e) {
		long ret = bindings.CResult_MonitorNameIOErrorZ_err(e);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MonitorNameIOErrorZ ret_hu_conv = Result_MonitorNameIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_MonitorNameIOErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
