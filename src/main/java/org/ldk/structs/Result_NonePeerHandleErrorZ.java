package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_NonePeerHandleErrorZ extends CommonBase {
	private Result_NonePeerHandleErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_NonePeerHandleErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_NonePeerHandleErrorZ_free(ptr); ptr = 0; }
	}

	static Result_NonePeerHandleErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_NonePeerHandleErrorZ_is_ok(ptr)) {
			return new Result_NonePeerHandleErrorZ_OK(null, ptr);
		} else {
			return new Result_NonePeerHandleErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_NonePeerHandleErrorZ_OK extends Result_NonePeerHandleErrorZ {
		private Result_NonePeerHandleErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	public static final class Result_NonePeerHandleErrorZ_Err extends Result_NonePeerHandleErrorZ {
		public final PeerHandleError err;
		private Result_NonePeerHandleErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_NonePeerHandleErrorZ_get_err(ptr);
			org.ldk.structs.PeerHandleError err_hu_conv = null; if (err < 0 || err > 4096) { err_hu_conv = new org.ldk.structs.PeerHandleError(null, err); }
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NonePeerHandleErrorZ in the success state.
	 */
	public static Result_NonePeerHandleErrorZ ok() {
		long ret = bindings.CResult_NonePeerHandleErrorZ_ok();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePeerHandleErrorZ ret_hu_conv = Result_NonePeerHandleErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NonePeerHandleErrorZ in the error state.
	 */
	public static Result_NonePeerHandleErrorZ err(org.ldk.structs.PeerHandleError e) {
		long ret = bindings.CResult_NonePeerHandleErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePeerHandleErrorZ ret_hu_conv = Result_NonePeerHandleErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_NonePeerHandleErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_NonePeerHandleErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NonePeerHandleErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NonePeerHandleErrorZ clone() {
		long ret = bindings.CResult_NonePeerHandleErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePeerHandleErrorZ ret_hu_conv = Result_NonePeerHandleErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
