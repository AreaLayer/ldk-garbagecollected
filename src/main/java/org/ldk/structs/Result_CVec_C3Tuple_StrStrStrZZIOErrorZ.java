package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_CVec_C3Tuple_StrStrStrZZIOErrorZ extends CommonBase {
	private Result_CVec_C3Tuple_StrStrStrZZIOErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_free(ptr); ptr = 0; }
	}

	static Result_CVec_C3Tuple_StrStrStrZZIOErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_is_ok(ptr)) {
			return new Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_OK(null, ptr);
		} else {
			return new Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_OK extends Result_CVec_C3Tuple_StrStrStrZZIOErrorZ {
		public final ThreeTuple_StrStrStrZ[] res;
		private Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long[] res = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_get_ok(ptr);
			int res_conv_23_len = res.length;
			ThreeTuple_StrStrStrZ[] res_conv_23_arr = new ThreeTuple_StrStrStrZ[res_conv_23_len];
			for (int x = 0; x < res_conv_23_len; x++) {
				long res_conv_23 = res[x];
				ThreeTuple_StrStrStrZ res_conv_23_hu_conv = new ThreeTuple_StrStrStrZ(null, res_conv_23);
				if (res_conv_23_hu_conv != null) { res_conv_23_hu_conv.ptrs_to.add(this); };
				res_conv_23_arr[x] = res_conv_23_hu_conv;
			}
			this.res = res_conv_23_arr;
		}
	}

	public static final class Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_Err extends Result_CVec_C3Tuple_StrStrStrZZIOErrorZ {
		public final IOError err;
		private Result_CVec_C3Tuple_StrStrStrZZIOErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.err = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ in the success state.
	 */
	public static Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ok(ThreeTuple_StrStrStrZ[] o) {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_ok(o != null ? Arrays.stream(o).mapToLong(o_conv_23 -> o_conv_23.ptr).toArray() : null);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ in the error state.
	 */
	public static Result_CVec_C3Tuple_StrStrStrZZIOErrorZ err(org.ldk.enums.IOError e) {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_err(e);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_C3Tuple_StrStrStrZZIOErrorZ clone() {
		long ret = bindings.CResult_CVec_C3Tuple_StrStrStrZZIOErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
