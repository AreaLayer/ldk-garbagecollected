using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class ThreeTuple_StrStrStrZ : CommonBase {
	internal ThreeTuple_StrStrStrZ(object _dummy, long ptr) : base(ptr) { }
	~ThreeTuple_StrStrStrZ() {
		if (ptr != 0) { bindings.C3Tuple_StrStrStrZ_free(ptr); }
	}

	/**
	 * 
	 */
	public string get_a() {
		long ret = bindings.C3Tuple_StrStrStrZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public string get_b() {
		long ret = bindings.C3Tuple_StrStrStrZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public string get_c() {
		long ret = bindings.C3Tuple_StrStrStrZ_get_c(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C3Tuple_StrStrStrZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public ThreeTuple_StrStrStrZ clone() {
		long ret = bindings.C3Tuple_StrStrStrZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_StrStrStrZ ret_hu_conv = new ThreeTuple_StrStrStrZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C3Tuple_StrStrStrZ from the contained elements.
	 */
	public static ThreeTuple_StrStrStrZ of(string a, string b, string c) {
		long ret = bindings.C3Tuple_StrStrStrZ_new(InternalUtils.encodeString(a), InternalUtils.encodeString(b), InternalUtils.encodeString(c));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		GC.KeepAlive(c);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_StrStrStrZ ret_hu_conv = new ThreeTuple_StrStrStrZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
