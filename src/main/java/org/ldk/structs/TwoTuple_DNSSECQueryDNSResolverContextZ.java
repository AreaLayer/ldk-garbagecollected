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
public class TwoTuple_DNSSECQueryDNSResolverContextZ extends CommonBase {
	TwoTuple_DNSSECQueryDNSResolverContextZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_free(ptr); }
	}

	/**
	 * 
	 */
	public DNSSECQuery get_a() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSSECQuery ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DNSSECQuery(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public DNSResolverContext get_b() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverContext ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DNSResolverContext(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_DNSSECQueryDNSResolverContextZ clone() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_DNSSECQueryDNSResolverContextZ ret_hu_conv = new TwoTuple_DNSSECQueryDNSResolverContextZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_DNSSECQueryDNSResolverContextZ from the contained elements.
	 */
	public static TwoTuple_DNSSECQueryDNSResolverContextZ of(org.ldk.structs.DNSSECQuery a, org.ldk.structs.DNSResolverContext b) {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_new(a.ptr, b.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_DNSSECQueryDNSResolverContextZ ret_hu_conv = new TwoTuple_DNSSECQueryDNSResolverContextZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
