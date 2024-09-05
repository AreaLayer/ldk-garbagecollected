package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result__u832NoneZ extends CommonBase {
	private Result__u832NoneZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult__u832NoneZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult__u832NoneZ_free(ptr); ptr = 0; }
	}

	static Result__u832NoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult__u832NoneZ_is_ok(ptr)) {
			return new Result__u832NoneZ_OK(null, ptr);
		} else {
			return new Result__u832NoneZ_Err(null, ptr);
		}
	}
	public static final class Result__u832NoneZ_OK extends Result__u832NoneZ {
		public final byte[] res;
		private Result__u832NoneZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.res = bindings.CResult__u832NoneZ_get_ok(ptr);
		}
	}

	public static final class Result__u832NoneZ_Err extends Result__u832NoneZ {
		private Result__u832NoneZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	/**
	 * Creates a new CResult__u832NoneZ in the success state.
	 */
	public static Result__u832NoneZ ok(byte[] o) {
		long ret = bindings.CResult__u832NoneZ_ok(InternalUtils.check_arr_len(o, 32));
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result__u832NoneZ ret_hu_conv = Result__u832NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult__u832NoneZ in the error state.
	 */
	public static Result__u832NoneZ err() {
		long ret = bindings.CResult__u832NoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result__u832NoneZ ret_hu_conv = Result__u832NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult__u832NoneZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult__u832NoneZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult__u832NoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result__u832NoneZ clone() {
		long ret = bindings.CResult__u832NoneZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result__u832NoneZ ret_hu_conv = Result__u832NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
