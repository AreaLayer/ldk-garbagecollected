using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ : CommonBase {
	internal TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ() {
		if (ptr != 0) { bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ_free(ptr); }
	}

	/**
	 * 
	 */
	public TwoTuple_HumanReadableNameThirtyTwoBytesZ[] get_a() {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_43_len = InternalUtils.getArrayLength(ret);
		TwoTuple_HumanReadableNameThirtyTwoBytesZ[] ret_conv_43_arr = new TwoTuple_HumanReadableNameThirtyTwoBytesZ[ret_conv_43_len];
		for (int r = 0; r < ret_conv_43_len; r++) {
			long ret_conv_43 = InternalUtils.getU64ArrayElem(ret, r);
			TwoTuple_HumanReadableNameThirtyTwoBytesZ ret_conv_43_hu_conv = new TwoTuple_HumanReadableNameThirtyTwoBytesZ(null, ret_conv_43);
			if (ret_conv_43_hu_conv != null) { ret_conv_43_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_43_arr[r] = ret_conv_43_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_43_arr;
	}

	/**
	 * 
	 */
	public string get_b() {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ clone() {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ ret_hu_conv = new TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ from the contained elements.
	 */
	public static org.ldk.structs.TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ of(TwoTuple_HumanReadableNameThirtyTwoBytesZ[] a, string b) {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ_new(InternalUtils.encodeUint64Array(InternalUtils.mapArray(a, a_conv_43 => a_conv_43.ptr)), InternalUtils.encodeString(b));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ ret_hu_conv = new TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZStrZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
