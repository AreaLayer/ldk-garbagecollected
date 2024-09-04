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
public class ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ extends CommonBase {
	ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ_free(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		byte[] ret = bindings.C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * 
	 */
	public RecipientOnionFields get_b() {
		long ret = bindings.C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RecipientOnionFields ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RecipientOnionFields(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public RouteParameters get_c() {
		long ret = bindings.C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ_get_c(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ clone() {
		long ret = bindings.C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ ret_hu_conv = new ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ from the contained elements.
	 */
	public static ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ of(byte[] a, org.ldk.structs.RecipientOnionFields b, org.ldk.structs.RouteParameters c) {
		long ret = bindings.C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ_new(InternalUtils.check_arr_len(a, 32), b.ptr, c.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		Reference.reachabilityFence(c);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ ret_hu_conv = new ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
