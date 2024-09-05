using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_EcdsaChannelSignerDecodeErrorZ : CommonBase {
	Result_EcdsaChannelSignerDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_EcdsaChannelSignerDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_EcdsaChannelSignerDecodeErrorZ_free(ptr); }
	}

	internal static Result_EcdsaChannelSignerDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_EcdsaChannelSignerDecodeErrorZ_is_ok(ptr)) {
			return new Result_EcdsaChannelSignerDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_EcdsaChannelSignerDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_EcdsaChannelSignerDecodeErrorZ_OK : Result_EcdsaChannelSignerDecodeErrorZ {
		public readonly EcdsaChannelSigner res;
		internal Result_EcdsaChannelSignerDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_get_ok(ptr);
			EcdsaChannelSigner ret_hu_conv = new EcdsaChannelSigner(null, res);
			if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
			this.res = ret_hu_conv;
		}
	}

	public class Result_EcdsaChannelSignerDecodeErrorZ_Err : Result_EcdsaChannelSignerDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_EcdsaChannelSignerDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_EcdsaChannelSignerDecodeErrorZ in the success state.
	 */
	public static Result_EcdsaChannelSignerDecodeErrorZ ok(org.ldk.structs.EcdsaChannelSigner o) {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_EcdsaChannelSignerDecodeErrorZ ret_hu_conv = Result_EcdsaChannelSignerDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_EcdsaChannelSignerDecodeErrorZ in the error state.
	 */
	public static Result_EcdsaChannelSignerDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_EcdsaChannelSignerDecodeErrorZ ret_hu_conv = Result_EcdsaChannelSignerDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_EcdsaChannelSignerDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_EcdsaChannelSignerDecodeErrorZ clone() {
		long ret = bindings.CResult_EcdsaChannelSignerDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_EcdsaChannelSignerDecodeErrorZ ret_hu_conv = Result_EcdsaChannelSignerDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
