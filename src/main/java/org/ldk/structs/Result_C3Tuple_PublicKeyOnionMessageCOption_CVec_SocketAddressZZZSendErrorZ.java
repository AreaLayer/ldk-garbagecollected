package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ extends CommonBase {
	private Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_free(ptr); ptr = 0; }
	}

	static Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_is_ok(ptr)) {
			return new Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_OK(null, ptr);
		} else {
			return new Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_OK extends Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ {
		public final ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ res;
		private Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_get_ok(ptr);
			ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ res_hu_conv = new ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_Err extends Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ {
		public final SendError err;
		private Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_get_err(ptr);
			org.ldk.structs.SendError err_hu_conv = org.ldk.structs.SendError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ in the success state.
	 */
	public static Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ ok(org.ldk.structs.ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ o) {
		long ret = bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ ret_hu_conv = Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ in the error state.
	 */
	public static Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ err(org.ldk.structs.SendError e) {
		long ret = bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ ret_hu_conv = Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ clone() {
		long ret = bindings.CResult_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ ret_hu_conv = Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
