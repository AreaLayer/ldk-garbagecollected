using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_PendingHTLCInfoInboundHTLCErrZ : CommonBase {
	Result_PendingHTLCInfoInboundHTLCErrZ(object _dummy, long ptr) : base(ptr) { }
	~Result_PendingHTLCInfoInboundHTLCErrZ() {
		if (ptr != 0) { bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_free(ptr); }
	}

	internal static Result_PendingHTLCInfoInboundHTLCErrZ constr_from_ptr(long ptr) {
		if (bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_is_ok(ptr)) {
			return new Result_PendingHTLCInfoInboundHTLCErrZ_OK(null, ptr);
		} else {
			return new Result_PendingHTLCInfoInboundHTLCErrZ_Err(null, ptr);
		}
	}
	public class Result_PendingHTLCInfoInboundHTLCErrZ_OK : Result_PendingHTLCInfoInboundHTLCErrZ {
		public readonly PendingHTLCInfo res;
		internal Result_PendingHTLCInfoInboundHTLCErrZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_get_ok(ptr);
			org.ldk.structs.PendingHTLCInfo res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.PendingHTLCInfo(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_PendingHTLCInfoInboundHTLCErrZ_Err : Result_PendingHTLCInfoInboundHTLCErrZ {
		public readonly InboundHTLCErr err;
		internal Result_PendingHTLCInfoInboundHTLCErrZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_get_err(ptr);
			org.ldk.structs.InboundHTLCErr err_hu_conv = null; if (err < 0 || err > 4096) { err_hu_conv = new org.ldk.structs.InboundHTLCErr(null, err); }
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_PendingHTLCInfoInboundHTLCErrZ in the success state.
	 */
	public static org.ldk.structs.Result_PendingHTLCInfoInboundHTLCErrZ ok(org.ldk.structs.PendingHTLCInfo o) {
		long ret = bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PendingHTLCInfoInboundHTLCErrZ ret_hu_conv = Result_PendingHTLCInfoInboundHTLCErrZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_PendingHTLCInfoInboundHTLCErrZ in the error state.
	 */
	public static org.ldk.structs.Result_PendingHTLCInfoInboundHTLCErrZ err(org.ldk.structs.InboundHTLCErr e) {
		long ret = bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PendingHTLCInfoInboundHTLCErrZ ret_hu_conv = Result_PendingHTLCInfoInboundHTLCErrZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_PendingHTLCInfoInboundHTLCErrZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_PendingHTLCInfoInboundHTLCErrZ clone() {
		long ret = bindings.CResult_PendingHTLCInfoInboundHTLCErrZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PendingHTLCInfoInboundHTLCErrZ ret_hu_conv = Result_PendingHTLCInfoInboundHTLCErrZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
