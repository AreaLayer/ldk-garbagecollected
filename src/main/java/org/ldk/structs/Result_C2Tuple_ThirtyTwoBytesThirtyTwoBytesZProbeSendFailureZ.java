package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ extends CommonBase {
	private Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_free(ptr); ptr = 0; }
	}

	static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ constr_from_ptr(long ptr) {
		if (bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_is_ok(ptr)) {
			return new Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_Err(null, ptr);
		}
	}
	public static final class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_OK extends Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ {
		public final TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ res;
		private Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_get_ok(ptr);
			TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ res_hu_conv = new TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_Err extends Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ {
		public final ProbeSendFailure err;
		private Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_get_err(ptr);
			org.ldk.structs.ProbeSendFailure err_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ in the success state.
	 */
	public static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ok(org.ldk.structs.TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ o) {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ in the error state.
	 */
	public static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ err(org.ldk.structs.ProbeSendFailure e) {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ clone() {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
