using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_boolboolZ : CommonBase {
	internal TwoTuple_boolboolZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_boolboolZ() {
		if (ptr != 0) { bindings.C2Tuple_boolboolZ_free(ptr); }
	}

	/**
	 * 
	 */
	public bool get_a() {
		bool ret = bindings.C2Tuple_boolboolZ_get_a(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * 
	 */
	public bool get_b() {
		bool ret = bindings.C2Tuple_boolboolZ_get_b(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_boolboolZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_boolboolZ clone() {
		long ret = bindings.C2Tuple_boolboolZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_boolboolZ ret_hu_conv = new TwoTuple_boolboolZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_boolboolZ from the contained elements.
	 */
	public static TwoTuple_boolboolZ of(bool a, bool b) {
		long ret = bindings.C2Tuple_boolboolZ_new(a, b);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_boolboolZ ret_hu_conv = new TwoTuple_boolboolZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
