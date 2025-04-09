using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ : CommonBase {
	Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ() {
		if (ptr != 0) { bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_free(ptr); }
	}

	internal static Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_is_ok(ptr)) {
			return new Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_OK(null, ptr);
		} else {
			return new Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_Err(null, ptr);
		}
	}
	public class Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_OK : Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ {
		public readonly RefundMaybeWithDerivedMetadataBuilder res;
		internal Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_get_ok(ptr);
			org.ldk.structs.RefundMaybeWithDerivedMetadataBuilder res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.RefundMaybeWithDerivedMetadataBuilder(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_Err : Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ {
		public readonly Bolt12SemanticError err;
		internal Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_get_err(ptr);
		}
	}

	/**
	 * Creates a new CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ ok(org.ldk.structs.RefundMaybeWithDerivedMetadataBuilder o) {
		long ret = bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ ret_hu_conv = Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ err(Bolt12SemanticError e) {
		long ret = bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_err(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ ret_hu_conv = Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ clone() {
		long ret = bindings.CResult_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ ret_hu_conv = Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
