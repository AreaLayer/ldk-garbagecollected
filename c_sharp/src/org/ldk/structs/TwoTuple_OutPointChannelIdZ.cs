using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_OutPointChannelIdZ : CommonBase {
	internal TwoTuple_OutPointChannelIdZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_OutPointChannelIdZ() {
		if (ptr != 0) { bindings.C2Tuple_OutPointChannelIdZ_free(ptr); }
	}

	/**
	 * 
	 */
	public OutPoint get_a() {
		long ret = bindings.C2Tuple_OutPointChannelIdZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public ChannelId get_b() {
		long ret = bindings.C2Tuple_OutPointChannelIdZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_OutPointChannelIdZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_OutPointChannelIdZ clone() {
		long ret = bindings.C2Tuple_OutPointChannelIdZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OutPointChannelIdZ ret_hu_conv = new TwoTuple_OutPointChannelIdZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_OutPointChannelIdZ from the contained elements.
	 */
	public static TwoTuple_OutPointChannelIdZ of(org.ldk.structs.OutPoint a, org.ldk.structs.ChannelId b) {
		long ret = bindings.C2Tuple_OutPointChannelIdZ_new(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OutPointChannelIdZ ret_hu_conv = new TwoTuple_OutPointChannelIdZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
