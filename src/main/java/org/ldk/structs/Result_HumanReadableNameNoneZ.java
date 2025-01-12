package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_HumanReadableNameNoneZ extends CommonBase {
	private Result_HumanReadableNameNoneZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_HumanReadableNameNoneZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_HumanReadableNameNoneZ_free(ptr); ptr = 0; }
	}

	static Result_HumanReadableNameNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_HumanReadableNameNoneZ_is_ok(ptr)) {
			return new Result_HumanReadableNameNoneZ_OK(null, ptr);
		} else {
			return new Result_HumanReadableNameNoneZ_Err(null, ptr);
		}
	}
	public static final class Result_HumanReadableNameNoneZ_OK extends Result_HumanReadableNameNoneZ {
		public final HumanReadableName res;
		private Result_HumanReadableNameNoneZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_HumanReadableNameNoneZ_get_ok(ptr);
			org.ldk.structs.HumanReadableName res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.HumanReadableName(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_HumanReadableNameNoneZ_Err extends Result_HumanReadableNameNoneZ {
		private Result_HumanReadableNameNoneZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	/**
	 * Creates a new CResult_HumanReadableNameNoneZ in the success state.
	 */
	public static Result_HumanReadableNameNoneZ ok(org.ldk.structs.HumanReadableName o) {
		long ret = bindings.CResult_HumanReadableNameNoneZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameNoneZ ret_hu_conv = Result_HumanReadableNameNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_HumanReadableNameNoneZ in the error state.
	 */
	public static Result_HumanReadableNameNoneZ err() {
		long ret = bindings.CResult_HumanReadableNameNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameNoneZ ret_hu_conv = Result_HumanReadableNameNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_HumanReadableNameNoneZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_HumanReadableNameNoneZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_HumanReadableNameNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_HumanReadableNameNoneZ clone() {
		long ret = bindings.CResult_HumanReadableNameNoneZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HumanReadableNameNoneZ ret_hu_conv = Result_HumanReadableNameNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
