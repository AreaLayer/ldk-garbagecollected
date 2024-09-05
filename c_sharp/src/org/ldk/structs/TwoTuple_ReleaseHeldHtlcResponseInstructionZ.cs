using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_ReleaseHeldHtlcResponseInstructionZ : CommonBase {
	internal TwoTuple_ReleaseHeldHtlcResponseInstructionZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_ReleaseHeldHtlcResponseInstructionZ() {
		if (ptr != 0) { bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_free(ptr); }
	}

	/**
	 * 
	 */
	public ReleaseHeldHtlc get_a() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReleaseHeldHtlc ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public ResponseInstruction get_b() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ResponseInstruction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ResponseInstruction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_ReleaseHeldHtlcResponseInstructionZ clone() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ReleaseHeldHtlcResponseInstructionZ ret_hu_conv = new TwoTuple_ReleaseHeldHtlcResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_ReleaseHeldHtlcResponseInstructionZ from the contained elements.
	 */
	public static TwoTuple_ReleaseHeldHtlcResponseInstructionZ of(org.ldk.structs.ReleaseHeldHtlc a, org.ldk.structs.ResponseInstruction b) {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_new(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ReleaseHeldHtlcResponseInstructionZ ret_hu_conv = new TwoTuple_ReleaseHeldHtlcResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
