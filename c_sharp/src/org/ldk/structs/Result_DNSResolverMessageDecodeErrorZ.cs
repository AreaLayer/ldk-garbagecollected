using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_DNSResolverMessageDecodeErrorZ : CommonBase {
	Result_DNSResolverMessageDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_DNSResolverMessageDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_DNSResolverMessageDecodeErrorZ_free(ptr); }
	}

	internal static Result_DNSResolverMessageDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_DNSResolverMessageDecodeErrorZ_is_ok(ptr)) {
			return new Result_DNSResolverMessageDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_DNSResolverMessageDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_DNSResolverMessageDecodeErrorZ_OK : Result_DNSResolverMessageDecodeErrorZ {
		public readonly DNSResolverMessage res;
		internal Result_DNSResolverMessageDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_DNSResolverMessageDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.DNSResolverMessage res_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_DNSResolverMessageDecodeErrorZ_Err : Result_DNSResolverMessageDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_DNSResolverMessageDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_DNSResolverMessageDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_DNSResolverMessageDecodeErrorZ in the success state.
	 */
	public static Result_DNSResolverMessageDecodeErrorZ ok(org.ldk.structs.DNSResolverMessage o) {
		long ret = bindings.CResult_DNSResolverMessageDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DNSResolverMessageDecodeErrorZ ret_hu_conv = Result_DNSResolverMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_DNSResolverMessageDecodeErrorZ in the error state.
	 */
	public static Result_DNSResolverMessageDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_DNSResolverMessageDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DNSResolverMessageDecodeErrorZ ret_hu_conv = Result_DNSResolverMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_DNSResolverMessageDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_DNSResolverMessageDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_DNSResolverMessageDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_DNSResolverMessageDecodeErrorZ clone() {
		long ret = bindings.CResult_DNSResolverMessageDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DNSResolverMessageDecodeErrorZ ret_hu_conv = Result_DNSResolverMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
