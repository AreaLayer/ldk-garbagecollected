package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A Tuple
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ extends CommonBase {
	FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_free(ptr); }
	}

	/**
	 * 
	 */
	public OutPoint get_a() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public ChannelId get_b() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public MonitorEvent[] get_c() {
		long[] ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_c(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_14_len = ret.length;
		MonitorEvent[] ret_conv_14_arr = new MonitorEvent[ret_conv_14_len];
		for (int o = 0; o < ret_conv_14_len; o++) {
			long ret_conv_14 = ret[o];
			org.ldk.structs.MonitorEvent ret_conv_14_hu_conv = org.ldk.structs.MonitorEvent.constr_from_ptr(ret_conv_14);
			if (ret_conv_14_hu_conv != null) { ret_conv_14_hu_conv.ptrs_to.add(this); };
			ret_conv_14_arr[o] = ret_conv_14_hu_conv;
		}
		return ret_conv_14_arr;
	}

	/**
	 * 
	 */
	public byte[] get_d() {
		byte[] ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_get_d(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ clone() {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ ret_hu_conv = new FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ from the contained elements.
	 */
	public static FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ of(org.ldk.structs.OutPoint a, org.ldk.structs.ChannelId b, MonitorEvent[] c, byte[] d) {
		long ret = bindings.C4Tuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ_new(a.ptr, b.ptr, c != null ? Arrays.stream(c).mapToLong(c_conv_14 -> c_conv_14.ptr).toArray() : null, InternalUtils.check_arr_len(d, 33));
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		Reference.reachabilityFence(c);
		Reference.reachabilityFence(d);
		if (ret >= 0 && ret <= 4096) { return null; }
		FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ ret_hu_conv = new FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(a); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b); };
		for (MonitorEvent c_conv_14: c) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(c_conv_14); }; };
		return ret_hu_conv;
	}

}
