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
public class TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ extends CommonBase {
	TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ_free(ptr); }
	}

	/**
	 * 
	 */
	public TwoTuple_HumanReadableNameThirtyTwoBytesZ[] get_a() {
		long[] ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_43_len = ret.length;
		TwoTuple_HumanReadableNameThirtyTwoBytesZ[] ret_conv_43_arr = new TwoTuple_HumanReadableNameThirtyTwoBytesZ[ret_conv_43_len];
		for (int r = 0; r < ret_conv_43_len; r++) {
			long ret_conv_43 = ret[r];
			TwoTuple_HumanReadableNameThirtyTwoBytesZ ret_conv_43_hu_conv = new TwoTuple_HumanReadableNameThirtyTwoBytesZ(null, ret_conv_43);
			if (ret_conv_43_hu_conv != null) { ret_conv_43_hu_conv.ptrs_to.add(this); };
			ret_conv_43_arr[r] = ret_conv_43_hu_conv;
		}
		return ret_conv_43_arr;
	}

	/**
	 * 
	 */
	public Offer get_b() {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Offer ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Offer(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ clone() {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ ret_hu_conv = new TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ from the contained elements.
	 */
	public static TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ of(TwoTuple_HumanReadableNameThirtyTwoBytesZ[] a, org.ldk.structs.Offer b) {
		long ret = bindings.C2Tuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ_new(a != null ? Arrays.stream(a).mapToLong(a_conv_43 -> a_conv_43.ptr).toArray() : null, b.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ ret_hu_conv = new TwoTuple_CVec_C2Tuple_HumanReadableNameThirtyTwoBytesZZOfferZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
