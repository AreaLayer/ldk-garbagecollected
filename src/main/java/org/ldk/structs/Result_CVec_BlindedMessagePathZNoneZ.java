package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_CVec_BlindedMessagePathZNoneZ extends CommonBase {
	private Result_CVec_BlindedMessagePathZNoneZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_CVec_BlindedMessagePathZNoneZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_CVec_BlindedMessagePathZNoneZ_free(ptr); ptr = 0; }
	}

	static Result_CVec_BlindedMessagePathZNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_CVec_BlindedMessagePathZNoneZ_is_ok(ptr)) {
			return new Result_CVec_BlindedMessagePathZNoneZ_OK(null, ptr);
		} else {
			return new Result_CVec_BlindedMessagePathZNoneZ_Err(null, ptr);
		}
	}
	public static final class Result_CVec_BlindedMessagePathZNoneZ_OK extends Result_CVec_BlindedMessagePathZNoneZ {
		public final BlindedMessagePath[] res;
		private Result_CVec_BlindedMessagePathZNoneZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long[] res = bindings.CResult_CVec_BlindedMessagePathZNoneZ_get_ok(ptr);
			int res_conv_20_len = res.length;
			BlindedMessagePath[] res_conv_20_arr = new BlindedMessagePath[res_conv_20_len];
			for (int u = 0; u < res_conv_20_len; u++) {
				long res_conv_20 = res[u];
				org.ldk.structs.BlindedMessagePath res_conv_20_hu_conv = null; if (res_conv_20 < 0 || res_conv_20 > 4096) { res_conv_20_hu_conv = new org.ldk.structs.BlindedMessagePath(null, res_conv_20); }
				if (res_conv_20_hu_conv != null) { res_conv_20_hu_conv.ptrs_to.add(this); };
				res_conv_20_arr[u] = res_conv_20_hu_conv;
			}
			this.res = res_conv_20_arr;
		}
	}

	public static final class Result_CVec_BlindedMessagePathZNoneZ_Err extends Result_CVec_BlindedMessagePathZNoneZ {
		private Result_CVec_BlindedMessagePathZNoneZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	/**
	 * Creates a new CResult_CVec_BlindedMessagePathZNoneZ in the success state.
	 */
	public static Result_CVec_BlindedMessagePathZNoneZ ok(BlindedMessagePath[] o) {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_ok(o != null ? Arrays.stream(o).mapToLong(o_conv_20 -> o_conv_20.ptr).toArray() : null);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedMessagePathZNoneZ ret_hu_conv = Result_CVec_BlindedMessagePathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_BlindedMessagePathZNoneZ in the error state.
	 */
	public static Result_CVec_BlindedMessagePathZNoneZ err() {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedMessagePathZNoneZ ret_hu_conv = Result_CVec_BlindedMessagePathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_BlindedMessagePathZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_BlindedMessagePathZNoneZ clone() {
		long ret = bindings.CResult_CVec_BlindedMessagePathZNoneZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_BlindedMessagePathZNoneZ ret_hu_conv = Result_CVec_BlindedMessagePathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
