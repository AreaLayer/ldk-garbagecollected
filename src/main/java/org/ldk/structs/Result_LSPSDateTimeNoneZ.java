package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_LSPSDateTimeNoneZ extends CommonBase {
	private Result_LSPSDateTimeNoneZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_LSPSDateTimeNoneZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_LSPSDateTimeNoneZ_free(ptr); ptr = 0; }
	}

	static Result_LSPSDateTimeNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_LSPSDateTimeNoneZ_is_ok(ptr)) {
			return new Result_LSPSDateTimeNoneZ_OK(null, ptr);
		} else {
			return new Result_LSPSDateTimeNoneZ_Err(null, ptr);
		}
	}
	public static final class Result_LSPSDateTimeNoneZ_OK extends Result_LSPSDateTimeNoneZ {
		public final LSPSDateTime res;
		private Result_LSPSDateTimeNoneZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_LSPSDateTimeNoneZ_get_ok(ptr);
			org.ldk.structs.LSPSDateTime res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.LSPSDateTime(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_LSPSDateTimeNoneZ_Err extends Result_LSPSDateTimeNoneZ {
		private Result_LSPSDateTimeNoneZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	/**
	 * Creates a new CResult_LSPSDateTimeNoneZ in the success state.
	 */
	public static Result_LSPSDateTimeNoneZ ok(org.ldk.structs.LSPSDateTime o) {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_LSPSDateTimeNoneZ in the error state.
	 */
	public static Result_LSPSDateTimeNoneZ err() {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_LSPSDateTimeNoneZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_LSPSDateTimeNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_LSPSDateTimeNoneZ clone() {
		long ret = bindings.CResult_LSPSDateTimeNoneZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
