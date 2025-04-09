using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_OutPointCVec_u64ZZ : CommonBase {
	internal TwoTuple_OutPointCVec_u64ZZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_OutPointCVec_u64ZZ() {
		if (ptr != 0) { bindings.C2Tuple_OutPointCVec_u64ZZ_free(ptr); }
	}

	/**
	 * 
	 */
	public org.ldk.structs.OutPoint get_a() {
		long ret = bindings.C2Tuple_OutPointCVec_u64ZZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public long[] get_b() {
		long ret = bindings.C2Tuple_OutPointCVec_u64ZZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		long[] ret_conv = InternalUtils.decodeUint64Array(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_OutPointCVec_u64ZZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.TwoTuple_OutPointCVec_u64ZZ clone() {
		long ret = bindings.C2Tuple_OutPointCVec_u64ZZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OutPointCVec_u64ZZ ret_hu_conv = new TwoTuple_OutPointCVec_u64ZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_OutPointCVec_u64ZZ from the contained elements.
	 */
	public static org.ldk.structs.TwoTuple_OutPointCVec_u64ZZ of(org.ldk.structs.OutPoint a, long[] b) {
		long ret = bindings.C2Tuple_OutPointCVec_u64ZZ_new(a.ptr, InternalUtils.encodeUint64Array(b));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OutPointCVec_u64ZZ ret_hu_conv = new TwoTuple_OutPointCVec_u64ZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
