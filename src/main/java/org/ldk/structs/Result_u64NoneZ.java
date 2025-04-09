package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_u64NoneZ extends CommonBase {
	private Result_u64NoneZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_u64NoneZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_u64NoneZ_free(ptr); ptr = 0; }
	}

	static Result_u64NoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_u64NoneZ_is_ok(ptr)) {
			return new Result_u64NoneZ_OK(null, ptr);
		} else {
			return new Result_u64NoneZ_Err(null, ptr);
		}
	}
	public static final class Result_u64NoneZ_OK extends Result_u64NoneZ {
		public final long res;
		private Result_u64NoneZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.res = bindings.CResult_u64NoneZ_get_ok(ptr);
		}
	}

	public static final class Result_u64NoneZ_Err extends Result_u64NoneZ {
		private Result_u64NoneZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	/**
	 * Creates a new CResult_u64NoneZ in the success state.
	 */
	public static Result_u64NoneZ ok(long o) {
		long ret = bindings.CResult_u64NoneZ_ok(o);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_u64NoneZ in the error state.
	 */
	public static Result_u64NoneZ err() {
		long ret = bindings.CResult_u64NoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_u64NoneZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_u64NoneZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_u64NoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_u64NoneZ clone() {
		long ret = bindings.CResult_u64NoneZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
