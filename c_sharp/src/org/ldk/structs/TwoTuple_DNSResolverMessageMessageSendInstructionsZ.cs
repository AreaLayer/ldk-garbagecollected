using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_DNSResolverMessageMessageSendInstructionsZ : CommonBase {
	internal TwoTuple_DNSResolverMessageMessageSendInstructionsZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_DNSResolverMessageMessageSendInstructionsZ() {
		if (ptr != 0) { bindings.C2Tuple_DNSResolverMessageMessageSendInstructionsZ_free(ptr); }
	}

	/**
	 * 
	 */
	public DNSResolverMessage get_a() {
		long ret = bindings.C2Tuple_DNSResolverMessageMessageSendInstructionsZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverMessage ret_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public MessageSendInstructions get_b() {
		long ret = bindings.C2Tuple_DNSResolverMessageMessageSendInstructionsZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_DNSResolverMessageMessageSendInstructionsZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_DNSResolverMessageMessageSendInstructionsZ clone() {
		long ret = bindings.C2Tuple_DNSResolverMessageMessageSendInstructionsZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_DNSResolverMessageMessageSendInstructionsZ ret_hu_conv = new TwoTuple_DNSResolverMessageMessageSendInstructionsZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_DNSResolverMessageMessageSendInstructionsZ from the contained elements.
	 */
	public static TwoTuple_DNSResolverMessageMessageSendInstructionsZ of(org.ldk.structs.DNSResolverMessage a, org.ldk.structs.MessageSendInstructions b) {
		long ret = bindings.C2Tuple_DNSResolverMessageMessageSendInstructionsZ_new(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_DNSResolverMessageMessageSendInstructionsZ ret_hu_conv = new TwoTuple_DNSResolverMessageMessageSendInstructionsZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
