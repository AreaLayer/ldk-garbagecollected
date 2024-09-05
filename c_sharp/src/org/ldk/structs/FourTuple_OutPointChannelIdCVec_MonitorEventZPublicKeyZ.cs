using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ : CommonBase {
	internal FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ(object _dummy, long ptr) : base(ptr) { }
	~FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ() {
		if (ptr != 0) { bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_free(ptr); }
	}

	/**
	 * 
	 */
	public OutPoint get_a() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_a(this.ptr);
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
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public MonitorEvent[] get_c() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_c(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_14_len = InternalUtils.getArrayLength(ret);
		MonitorEvent[] ret_conv_14_arr = new MonitorEvent[ret_conv_14_len];
		for (int o = 0; o < ret_conv_14_len; o++) {
			long ret_conv_14 = InternalUtils.getU64ArrayElem(ret, o);
			org.ldk.structs.MonitorEvent ret_conv_14_hu_conv = org.ldk.structs.MonitorEvent.constr_from_ptr(ret_conv_14);
			if (ret_conv_14_hu_conv != null) { ret_conv_14_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_14_arr[o] = ret_conv_14_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_14_arr;
	}

	/**
	 * 
	 */
	public byte[] get_d() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_d(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ clone() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ ret_hu_conv = new FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ from the contained elements.
	 */
	public static FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ of(org.ldk.structs.OutPoint a, org.ldk.structs.ChannelId b, MonitorEvent[] c, byte[] d) {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_new(a.ptr, b.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(c, c_conv_14 => c_conv_14.ptr)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(d, 33)));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		GC.KeepAlive(c);
		GC.KeepAlive(d);
		if (ret >= 0 && ret <= 4096) { return null; }
		FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ ret_hu_conv = new FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
