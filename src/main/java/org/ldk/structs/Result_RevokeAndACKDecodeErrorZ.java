package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_RevokeAndACKDecodeErrorZ extends CommonBase {
	private Result_RevokeAndACKDecodeErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_RevokeAndACKDecodeErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_RevokeAndACKDecodeErrorZ_free(ptr); ptr = 0; }
	}

	static Result_RevokeAndACKDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_RevokeAndACKDecodeErrorZ_is_ok(ptr)) {
			return new Result_RevokeAndACKDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_RevokeAndACKDecodeErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_RevokeAndACKDecodeErrorZ_OK extends Result_RevokeAndACKDecodeErrorZ {
		public final RevokeAndACK res;
		private Result_RevokeAndACKDecodeErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_RevokeAndACKDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.RevokeAndACK res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.RevokeAndACK(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_RevokeAndACKDecodeErrorZ_Err extends Result_RevokeAndACKDecodeErrorZ {
		public final DecodeError err;
		private Result_RevokeAndACKDecodeErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_RevokeAndACKDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_RevokeAndACKDecodeErrorZ in the success state.
	 */
	public static Result_RevokeAndACKDecodeErrorZ ok(org.ldk.structs.RevokeAndACK o) {
		long ret = bindings.CResult_RevokeAndACKDecodeErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RevokeAndACKDecodeErrorZ ret_hu_conv = Result_RevokeAndACKDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RevokeAndACKDecodeErrorZ in the error state.
	 */
	public static Result_RevokeAndACKDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_RevokeAndACKDecodeErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RevokeAndACKDecodeErrorZ ret_hu_conv = Result_RevokeAndACKDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_RevokeAndACKDecodeErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_RevokeAndACKDecodeErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RevokeAndACKDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RevokeAndACKDecodeErrorZ clone() {
		long ret = bindings.CResult_RevokeAndACKDecodeErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RevokeAndACKDecodeErrorZ ret_hu_conv = Result_RevokeAndACKDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
