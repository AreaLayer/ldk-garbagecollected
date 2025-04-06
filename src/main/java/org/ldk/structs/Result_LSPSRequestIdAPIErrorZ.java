package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_LSPSRequestIdAPIErrorZ extends CommonBase {
	private Result_LSPSRequestIdAPIErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_LSPSRequestIdAPIErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_LSPSRequestIdAPIErrorZ_free(ptr); ptr = 0; }
	}

	static Result_LSPSRequestIdAPIErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_LSPSRequestIdAPIErrorZ_is_ok(ptr)) {
			return new Result_LSPSRequestIdAPIErrorZ_OK(null, ptr);
		} else {
			return new Result_LSPSRequestIdAPIErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_LSPSRequestIdAPIErrorZ_OK extends Result_LSPSRequestIdAPIErrorZ {
		public final LSPSRequestId res;
		private Result_LSPSRequestIdAPIErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_LSPSRequestIdAPIErrorZ_get_ok(ptr);
			org.ldk.structs.LSPSRequestId res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.LSPSRequestId(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_LSPSRequestIdAPIErrorZ_Err extends Result_LSPSRequestIdAPIErrorZ {
		public final APIError err;
		private Result_LSPSRequestIdAPIErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_LSPSRequestIdAPIErrorZ_get_err(ptr);
			org.ldk.structs.APIError err_hu_conv = org.ldk.structs.APIError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_LSPSRequestIdAPIErrorZ in the success state.
	 */
	public static Result_LSPSRequestIdAPIErrorZ ok(org.ldk.structs.LSPSRequestId o) {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSRequestIdAPIErrorZ ret_hu_conv = Result_LSPSRequestIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_LSPSRequestIdAPIErrorZ in the error state.
	 */
	public static Result_LSPSRequestIdAPIErrorZ err(org.ldk.structs.APIError e) {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSRequestIdAPIErrorZ ret_hu_conv = Result_LSPSRequestIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_LSPSRequestIdAPIErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_LSPSRequestIdAPIErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_LSPSRequestIdAPIErrorZ clone() {
		long ret = bindings.CResult_LSPSRequestIdAPIErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSRequestIdAPIErrorZ ret_hu_conv = Result_LSPSRequestIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
