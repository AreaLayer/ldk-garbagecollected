using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UnsignedInvoiceRequestBolt12SemanticErrorZ : CommonBase {
	Result_UnsignedInvoiceRequestBolt12SemanticErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UnsignedInvoiceRequestBolt12SemanticErrorZ() {
		if (ptr != 0) { bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_free(ptr); }
	}

	internal static Result_UnsignedInvoiceRequestBolt12SemanticErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_is_ok(ptr)) {
			return new Result_UnsignedInvoiceRequestBolt12SemanticErrorZ_OK(null, ptr);
		} else {
			return new Result_UnsignedInvoiceRequestBolt12SemanticErrorZ_Err(null, ptr);
		}
	}
	public class Result_UnsignedInvoiceRequestBolt12SemanticErrorZ_OK : Result_UnsignedInvoiceRequestBolt12SemanticErrorZ {
		public readonly UnsignedInvoiceRequest res;
		internal Result_UnsignedInvoiceRequestBolt12SemanticErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_get_ok(ptr);
			org.ldk.structs.UnsignedInvoiceRequest res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UnsignedInvoiceRequest(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UnsignedInvoiceRequestBolt12SemanticErrorZ_Err : Result_UnsignedInvoiceRequestBolt12SemanticErrorZ {
		public readonly Bolt12SemanticError err;
		internal Result_UnsignedInvoiceRequestBolt12SemanticErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ in the success state.
	 */
	public static Result_UnsignedInvoiceRequestBolt12SemanticErrorZ ok(org.ldk.structs.UnsignedInvoiceRequest o) {
		long ret = bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedInvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedInvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ in the error state.
	 */
	public static Result_UnsignedInvoiceRequestBolt12SemanticErrorZ err(Bolt12SemanticError e) {
		long ret = bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_err(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedInvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedInvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UnsignedInvoiceRequestBolt12SemanticErrorZ clone() {
		long ret = bindings.CResult_UnsignedInvoiceRequestBolt12SemanticErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedInvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedInvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
