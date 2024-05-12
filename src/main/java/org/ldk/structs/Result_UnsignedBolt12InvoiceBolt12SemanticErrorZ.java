package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ extends CommonBase {
	private Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_free(ptr); ptr = 0; }
	}

	static Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_is_ok(ptr)) {
			return new Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ_OK(null, ptr);
		} else {
			return new Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ_OK extends Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ {
		public final UnsignedBolt12Invoice res;
		private Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_get_ok(ptr);
			org.ldk.structs.UnsignedBolt12Invoice res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UnsignedBolt12Invoice(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ_Err extends Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ {
		public final Bolt12SemanticError err;
		private Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.err = bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ in the success state.
	 */
	public static Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ ok(org.ldk.structs.UnsignedBolt12Invoice o) {
		long ret = bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ in the error state.
	 */
	public static Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ err(org.ldk.enums.Bolt12SemanticError e) {
		long ret = bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_err(e);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ clone() {
		long ret = bindings.CResult_UnsignedBolt12InvoiceBolt12SemanticErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
