using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_DNSSECQueryDNSResolverContextZ : CommonBase {
	internal TwoTuple_DNSSECQueryDNSResolverContextZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_DNSSECQueryDNSResolverContextZ() {
		if (ptr != 0) { bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_free(ptr); }
	}

	/**
	 * 
	 */
	public DNSSECQuery get_a() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSSECQuery ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DNSSECQuery(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public DNSResolverContext get_b() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverContext ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DNSResolverContext(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_DNSSECQueryDNSResolverContextZ clone() {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_DNSSECQueryDNSResolverContextZ ret_hu_conv = new TwoTuple_DNSSECQueryDNSResolverContextZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_DNSSECQueryDNSResolverContextZ from the contained elements.
	 */
	public static TwoTuple_DNSSECQueryDNSResolverContextZ of(org.ldk.structs.DNSSECQuery a, org.ldk.structs.DNSResolverContext b) {
		long ret = bindings.C2Tuple_DNSSECQueryDNSResolverContextZ_new(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_DNSSECQueryDNSResolverContextZ ret_hu_conv = new TwoTuple_DNSSECQueryDNSResolverContextZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
