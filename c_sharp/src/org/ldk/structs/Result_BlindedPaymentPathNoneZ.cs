using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_BlindedPaymentPathNoneZ : CommonBase {
	Result_BlindedPaymentPathNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_BlindedPaymentPathNoneZ() {
		if (ptr != 0) { bindings.CResult_BlindedPaymentPathNoneZ_free(ptr); }
	}

	internal static Result_BlindedPaymentPathNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_BlindedPaymentPathNoneZ_is_ok(ptr)) {
			return new Result_BlindedPaymentPathNoneZ_OK(null, ptr);
		} else {
			return new Result_BlindedPaymentPathNoneZ_Err(null, ptr);
		}
	}
	public class Result_BlindedPaymentPathNoneZ_OK : Result_BlindedPaymentPathNoneZ {
		public readonly BlindedPaymentPath res;
		internal Result_BlindedPaymentPathNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_BlindedPaymentPathNoneZ_get_ok(ptr);
			org.ldk.structs.BlindedPaymentPath res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.BlindedPaymentPath(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_BlindedPaymentPathNoneZ_Err : Result_BlindedPaymentPathNoneZ {
		internal Result_BlindedPaymentPathNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_BlindedPaymentPathNoneZ in the success state.
	 */
	public static Result_BlindedPaymentPathNoneZ ok(org.ldk.structs.BlindedPaymentPath o) {
		long ret = bindings.CResult_BlindedPaymentPathNoneZ_ok(o.ptr);
		GC.KeepAlive(o);
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
	public bool is_ok() {
		bool ret = bindings.CResult_BlindedPaymentPathNoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_BlindedPaymentPathNoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_BlindedPaymentPathNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_BlindedPaymentPathNoneZ clone() {
		long ret = bindings.CResult_BlindedPaymentPathNoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPaymentPathNoneZ ret_hu_conv = Result_BlindedPaymentPathNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
