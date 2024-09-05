package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_EcdsaChannelSignerDecodeErrorZ extends CommonBase {
	private Result_EcdsaChannelSignerDecodeErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_EcdsaChannelSignerDecodeErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_EcdsaChannelSignerDecodeErrorZ_free(ptr); ptr = 0; }
	}

	static Result_EcdsaChannelSignerDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_EcdsaChannelSignerDecodeErrorZ_is_ok(ptr)) {
			return new Result_EcdsaChannelSignerDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_EcdsaChannelSignerDecodeErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_EcdsaChannelSignerDecodeErrorZ_OK extends Result_EcdsaChannelSignerDecodeErrorZ {
		public final EcdsaChannelSigner res;
		private Result_EcdsaChannelSignerDecodeErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_get_ok(ptr);
			EcdsaChannelSigner ret_hu_conv = new EcdsaChannelSigner(null, res);
			if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
			this.res = ret_hu_conv;
		}
	}

	public static final class Result_EcdsaChannelSignerDecodeErrorZ_Err extends Result_EcdsaChannelSignerDecodeErrorZ {
		public final DecodeError err;
		private Result_EcdsaChannelSignerDecodeErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_EcdsaChannelSignerDecodeErrorZ in the success state.
	 */
	public static Result_EcdsaChannelSignerDecodeErrorZ ok(org.ldk.structs.EcdsaChannelSigner o) {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_EcdsaChannelSignerDecodeErrorZ ret_hu_conv = Result_EcdsaChannelSignerDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_EcdsaChannelSignerDecodeErrorZ in the error state.
	 */
	public static Result_EcdsaChannelSignerDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_EcdsaChannelSignerDecodeErrorZ ret_hu_conv = Result_EcdsaChannelSignerDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_EcdsaChannelSignerDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_EcdsaChannelSignerDecodeErrorZ clone() {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_EcdsaChannelSignerDecodeErrorZ ret_hu_conv = Result_EcdsaChannelSignerDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
