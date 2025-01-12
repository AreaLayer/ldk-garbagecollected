package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_NoneBolt12PaymentErrorZ extends CommonBase {
	private Result_NoneBolt12PaymentErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_NoneBolt12PaymentErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_NoneBolt12PaymentErrorZ_free(ptr); ptr = 0; }
	}

	static Result_NoneBolt12PaymentErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_NoneBolt12PaymentErrorZ_is_ok(ptr)) {
			return new Result_NoneBolt12PaymentErrorZ_OK(null, ptr);
		} else {
			return new Result_NoneBolt12PaymentErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_NoneBolt12PaymentErrorZ_OK extends Result_NoneBolt12PaymentErrorZ {
		private Result_NoneBolt12PaymentErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	public static final class Result_NoneBolt12PaymentErrorZ_Err extends Result_NoneBolt12PaymentErrorZ {
		public final Bolt12PaymentError err;
		private Result_NoneBolt12PaymentErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_NoneBolt12PaymentErrorZ_get_err(ptr);
			org.ldk.structs.Bolt12PaymentError err_hu_conv = org.ldk.structs.Bolt12PaymentError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NoneBolt12PaymentErrorZ in the success state.
	 */
	public static Result_NoneBolt12PaymentErrorZ ok() {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_ok();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12PaymentErrorZ ret_hu_conv = Result_NoneBolt12PaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NoneBolt12PaymentErrorZ in the error state.
	 */
	public static Result_NoneBolt12PaymentErrorZ err(org.ldk.structs.Bolt12PaymentError e) {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12PaymentErrorZ ret_hu_conv = Result_NoneBolt12PaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_NoneBolt12PaymentErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NoneBolt12PaymentErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NoneBolt12PaymentErrorZ clone() {
		long ret = bindings.CResult_NoneBolt12PaymentErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12PaymentErrorZ ret_hu_conv = Result_NoneBolt12PaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
