package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_OfferBolt12SemanticErrorZ extends CommonBase {
	private Result_OfferBolt12SemanticErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_OfferBolt12SemanticErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_OfferBolt12SemanticErrorZ_free(ptr); ptr = 0; }
	}

	static Result_OfferBolt12SemanticErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_OfferBolt12SemanticErrorZ_is_ok(ptr)) {
			return new Result_OfferBolt12SemanticErrorZ_OK(null, ptr);
		} else {
			return new Result_OfferBolt12SemanticErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_OfferBolt12SemanticErrorZ_OK extends Result_OfferBolt12SemanticErrorZ {
		public final Offer res;
		private Result_OfferBolt12SemanticErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_OfferBolt12SemanticErrorZ_get_ok(ptr);
			org.ldk.structs.Offer res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Offer(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_OfferBolt12SemanticErrorZ_Err extends Result_OfferBolt12SemanticErrorZ {
		public final Bolt12SemanticError err;
		private Result_OfferBolt12SemanticErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.err = bindings.CResult_OfferBolt12SemanticErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_OfferBolt12SemanticErrorZ in the success state.
	 */
	public static Result_OfferBolt12SemanticErrorZ ok(org.ldk.structs.Offer o) {
		long ret = bindings.CResult_OfferBolt12SemanticErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferBolt12SemanticErrorZ ret_hu_conv = Result_OfferBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OfferBolt12SemanticErrorZ in the error state.
	 */
	public static Result_OfferBolt12SemanticErrorZ err(org.ldk.enums.Bolt12SemanticError e) {
		long ret = bindings.CResult_OfferBolt12SemanticErrorZ_err(e);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferBolt12SemanticErrorZ ret_hu_conv = Result_OfferBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_OfferBolt12SemanticErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_OfferBolt12SemanticErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_OfferBolt12SemanticErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_OfferBolt12SemanticErrorZ clone() {
		long ret = bindings.CResult_OfferBolt12SemanticErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OfferBolt12SemanticErrorZ ret_hu_conv = Result_OfferBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
