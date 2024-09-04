package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_Bolt11InvoiceSignOrCreationErrorZ extends CommonBase {
	private Result_Bolt11InvoiceSignOrCreationErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_free(ptr); ptr = 0; }
	}

	static Result_Bolt11InvoiceSignOrCreationErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_is_ok(ptr)) {
			return new Result_Bolt11InvoiceSignOrCreationErrorZ_OK(null, ptr);
		} else {
			return new Result_Bolt11InvoiceSignOrCreationErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_Bolt11InvoiceSignOrCreationErrorZ_OK extends Result_Bolt11InvoiceSignOrCreationErrorZ {
		public final Bolt11Invoice res;
		private Result_Bolt11InvoiceSignOrCreationErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_get_ok(ptr);
			org.ldk.structs.Bolt11Invoice res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Bolt11Invoice(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_Bolt11InvoiceSignOrCreationErrorZ_Err extends Result_Bolt11InvoiceSignOrCreationErrorZ {
		public final SignOrCreationError err;
		private Result_Bolt11InvoiceSignOrCreationErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_get_err(ptr);
			org.ldk.structs.SignOrCreationError err_hu_conv = org.ldk.structs.SignOrCreationError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_Bolt11InvoiceSignOrCreationErrorZ in the success state.
	 */
	public static Result_Bolt11InvoiceSignOrCreationErrorZ ok(org.ldk.structs.Bolt11Invoice o) {
		long ret = bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt11InvoiceSignOrCreationErrorZ ret_hu_conv = Result_Bolt11InvoiceSignOrCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_Bolt11InvoiceSignOrCreationErrorZ in the error state.
	 */
	public static Result_Bolt11InvoiceSignOrCreationErrorZ err(org.ldk.structs.SignOrCreationError e) {
		long ret = bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt11InvoiceSignOrCreationErrorZ ret_hu_conv = Result_Bolt11InvoiceSignOrCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_Bolt11InvoiceSignOrCreationErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_Bolt11InvoiceSignOrCreationErrorZ clone() {
		long ret = bindings.CResult_Bolt11InvoiceSignOrCreationErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt11InvoiceSignOrCreationErrorZ ret_hu_conv = Result_Bolt11InvoiceSignOrCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
