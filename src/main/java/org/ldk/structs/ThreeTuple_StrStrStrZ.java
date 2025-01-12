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
public class ThreeTuple_StrStrStrZ extends CommonBase {
	ThreeTuple_StrStrStrZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C3Tuple_StrStrStrZ_free(ptr); }
	}

	/**
	 * 
	 */
	public String get_a() {
		String ret = bindings.C3Tuple_StrStrStrZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * 
	 */
	public String get_b() {
		String ret = bindings.C3Tuple_StrStrStrZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * 
	 */
	public String get_c() {
		String ret = bindings.C3Tuple_StrStrStrZ_get_c(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.C3Tuple_StrStrStrZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public ThreeTuple_StrStrStrZ clone() {
		long ret = bindings.C3Tuple_StrStrStrZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_StrStrStrZ ret_hu_conv = new ThreeTuple_StrStrStrZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C3Tuple_StrStrStrZ from the contained elements.
	 */
	public static ThreeTuple_StrStrStrZ of(java.lang.String a, java.lang.String b, java.lang.String c) {
		long ret = bindings.C3Tuple_StrStrStrZ_new(a, b, c);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		Reference.reachabilityFence(c);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_StrStrStrZ ret_hu_conv = new ThreeTuple_StrStrStrZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
