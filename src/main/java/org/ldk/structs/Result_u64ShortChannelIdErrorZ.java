package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_u64ShortChannelIdErrorZ extends CommonBase {
	private Result_u64ShortChannelIdErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_u64ShortChannelIdErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_u64ShortChannelIdErrorZ_free(ptr); ptr = 0; }
	}

	static Result_u64ShortChannelIdErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_u64ShortChannelIdErrorZ_is_ok(ptr)) {
			return new Result_u64ShortChannelIdErrorZ_OK(null, ptr);
		} else {
			return new Result_u64ShortChannelIdErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_u64ShortChannelIdErrorZ_OK extends Result_u64ShortChannelIdErrorZ {
		public final long res;
		private Result_u64ShortChannelIdErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.res = bindings.CResult_u64ShortChannelIdErrorZ_get_ok(ptr);
		}
	}

	public static final class Result_u64ShortChannelIdErrorZ_Err extends Result_u64ShortChannelIdErrorZ {
		public final ShortChannelIdError err;
		private Result_u64ShortChannelIdErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.err = bindings.CResult_u64ShortChannelIdErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_u64ShortChannelIdErrorZ in the success state.
	 */
	public static Result_u64ShortChannelIdErrorZ ok(long o) {
		long ret = bindings.CResult_u64ShortChannelIdErrorZ_ok(o);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64ShortChannelIdErrorZ ret_hu_conv = Result_u64ShortChannelIdErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_u64ShortChannelIdErrorZ in the error state.
	 */
	public static Result_u64ShortChannelIdErrorZ err(org.ldk.enums.ShortChannelIdError e) {
		long ret = bindings.CResult_u64ShortChannelIdErrorZ_err(e);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64ShortChannelIdErrorZ ret_hu_conv = Result_u64ShortChannelIdErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_u64ShortChannelIdErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
