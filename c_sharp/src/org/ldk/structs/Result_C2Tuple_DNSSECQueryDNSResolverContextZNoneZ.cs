using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ : CommonBase {
	Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ() {
		if (ptr != 0) { bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_free(ptr); }
	}

	internal static Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_is_ok(ptr)) {
			return new Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_Err(null, ptr);
		}
	}
	public class Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_OK : Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ {
		public readonly TwoTuple_DNSSECQueryDNSResolverContextZ res;
		internal Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_get_ok(ptr);
			TwoTuple_DNSSECQueryDNSResolverContextZ res_hu_conv = new TwoTuple_DNSSECQueryDNSResolverContextZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_Err : Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ {
		internal Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ in the success state.
	 */
	public static Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ ok(org.ldk.structs.TwoTuple_DNSSECQueryDNSResolverContextZ o) {
		long ret = bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ ret_hu_conv = Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ in the error state.
	 */
	public static Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ err() {
		long ret = bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ ret_hu_conv = Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ clone() {
		long ret = bindings.CResult_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ ret_hu_conv = Result_C2Tuple_DNSSECQueryDNSResolverContextZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
