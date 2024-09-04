package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_InitFeaturesDecodeErrorZ extends CommonBase {
	private Result_InitFeaturesDecodeErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_InitFeaturesDecodeErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_InitFeaturesDecodeErrorZ_free(ptr); ptr = 0; }
	}

	static Result_InitFeaturesDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_InitFeaturesDecodeErrorZ_is_ok(ptr)) {
			return new Result_InitFeaturesDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_InitFeaturesDecodeErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_InitFeaturesDecodeErrorZ_OK extends Result_InitFeaturesDecodeErrorZ {
		public final InitFeatures res;
		private Result_InitFeaturesDecodeErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_InitFeaturesDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.InitFeatures res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.InitFeatures(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_InitFeaturesDecodeErrorZ_Err extends Result_InitFeaturesDecodeErrorZ {
		public final DecodeError err;
		private Result_InitFeaturesDecodeErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_InitFeaturesDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_InitFeaturesDecodeErrorZ in the success state.
	 */
	public static Result_InitFeaturesDecodeErrorZ ok(org.ldk.structs.InitFeatures o) {
		long ret = bindings.CResult_InitFeaturesDecodeErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitFeaturesDecodeErrorZ ret_hu_conv = Result_InitFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_InitFeaturesDecodeErrorZ in the error state.
	 */
	public static Result_InitFeaturesDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_InitFeaturesDecodeErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitFeaturesDecodeErrorZ ret_hu_conv = Result_InitFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_InitFeaturesDecodeErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_InitFeaturesDecodeErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_InitFeaturesDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_InitFeaturesDecodeErrorZ clone() {
		long ret = bindings.CResult_InitFeaturesDecodeErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitFeaturesDecodeErrorZ ret_hu_conv = Result_InitFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
