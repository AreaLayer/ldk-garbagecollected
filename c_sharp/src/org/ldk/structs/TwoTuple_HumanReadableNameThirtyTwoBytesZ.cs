using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_HumanReadableNameThirtyTwoBytesZ : CommonBase {
	internal TwoTuple_HumanReadableNameThirtyTwoBytesZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_HumanReadableNameThirtyTwoBytesZ() {
		if (ptr != 0) { bindings.C2Tuple_HumanReadableNameThirtyTwoBytesZ_free(ptr); }
	}

	/**
	 * 
	 */
	public HumanReadableName get_a() {
		long ret = bindings.C2Tuple_HumanReadableNameThirtyTwoBytesZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HumanReadableName ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HumanReadableName(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public byte[] get_b() {
		long ret = bindings.C2Tuple_HumanReadableNameThirtyTwoBytesZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_HumanReadableNameThirtyTwoBytesZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_HumanReadableNameThirtyTwoBytesZ clone() {
		long ret = bindings.C2Tuple_HumanReadableNameThirtyTwoBytesZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_HumanReadableNameThirtyTwoBytesZ ret_hu_conv = new TwoTuple_HumanReadableNameThirtyTwoBytesZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_HumanReadableNameThirtyTwoBytesZ from the contained elements.
	 */
	public static TwoTuple_HumanReadableNameThirtyTwoBytesZ of(org.ldk.structs.HumanReadableName a, byte[] b) {
		long ret = bindings.C2Tuple_HumanReadableNameThirtyTwoBytesZ_new(a.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(b, 32)));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_HumanReadableNameThirtyTwoBytesZ ret_hu_conv = new TwoTuple_HumanReadableNameThirtyTwoBytesZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
