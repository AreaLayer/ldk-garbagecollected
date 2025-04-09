using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_InvoiceRequestBolt12SemanticErrorZ : CommonBase {
	Result_InvoiceRequestBolt12SemanticErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_InvoiceRequestBolt12SemanticErrorZ() {
		if (ptr != 0) { bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_free(ptr); }
	}

	internal static Result_InvoiceRequestBolt12SemanticErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_is_ok(ptr)) {
			return new Result_InvoiceRequestBolt12SemanticErrorZ_OK(null, ptr);
		} else {
			return new Result_InvoiceRequestBolt12SemanticErrorZ_Err(null, ptr);
		}
	}
	public class Result_InvoiceRequestBolt12SemanticErrorZ_OK : Result_InvoiceRequestBolt12SemanticErrorZ {
		public readonly InvoiceRequest res;
		internal Result_InvoiceRequestBolt12SemanticErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_get_ok(ptr);
			org.ldk.structs.InvoiceRequest res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.InvoiceRequest(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_InvoiceRequestBolt12SemanticErrorZ_Err : Result_InvoiceRequestBolt12SemanticErrorZ {
		public readonly Bolt12SemanticError err;
		internal Result_InvoiceRequestBolt12SemanticErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_InvoiceRequestBolt12SemanticErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_InvoiceRequestBolt12SemanticErrorZ ok(org.ldk.structs.InvoiceRequest o) {
		long ret = bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_InvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_InvoiceRequestBolt12SemanticErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_InvoiceRequestBolt12SemanticErrorZ err(Bolt12SemanticError e) {
		long ret = bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_err(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_InvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_InvoiceRequestBolt12SemanticErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_InvoiceRequestBolt12SemanticErrorZ clone() {
		long ret = bindings.CResult_InvoiceRequestBolt12SemanticErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_InvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
