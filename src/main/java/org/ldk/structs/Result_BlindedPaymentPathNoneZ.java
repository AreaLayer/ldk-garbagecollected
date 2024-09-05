package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_BlindedPaymentPathNoneZ extends CommonBase {
	private Result_BlindedPaymentPathNoneZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_BlindedPaymentPathNoneZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_BlindedPaymentPathNoneZ_free(ptr); ptr = 0; }
	}

	static Result_BlindedPaymentPathNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_BlindedPaymentPathNoneZ_is_ok(ptr)) {
			return new Result_BlindedPaymentPathNoneZ_OK(null, ptr);
		} else {
			return new Result_BlindedPaymentPathNoneZ_Err(null, ptr);
		}
	}
	public static final class Result_BlindedPaymentPathNoneZ_OK extends Result_BlindedPaymentPathNoneZ {
		public final BlindedPaymentPath res;
		private Result_BlindedPaymentPathNoneZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_BlindedPaymentPathNoneZ_get_ok(ptr);
			org.ldk.structs.BlindedPaymentPath res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.BlindedPaymentPath(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_BlindedPaymentPathNoneZ_Err extends Result_BlindedPaymentPathNoneZ {
		private Result_BlindedPaymentPathNoneZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	/**
	 * Creates a new CResult_BlindedPaymentPathNoneZ in the success state.
	 */
	public static Result_BlindedPaymentPathNoneZ ok(org.ldk.structs.BlindedPaymentPath o) {
		long ret = bindings.CResult_BlindedPaymentPathNoneZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPaymentPathNoneZ ret_hu_conv = Result_BlindedPaymentPathNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_BlindedPaymentPathNoneZ in the error state.
	 */
	public static Result_BlindedPaymentPathNoneZ err() {
		long ret = bindings.CResult_BlindedPaymentPathNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPaymentPathNoneZ ret_hu_conv = Result_BlindedPaymentPathNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_BlindedPaymentPathNoneZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_BlindedPaymentPathNoneZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_BlindedPaymentPathNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_BlindedPaymentPathNoneZ clone() {
		long ret = bindings.CResult_BlindedPaymentPathNoneZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPaymentPathNoneZ ret_hu_conv = Result_BlindedPaymentPathNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
