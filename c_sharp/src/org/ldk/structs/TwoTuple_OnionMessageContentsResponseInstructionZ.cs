using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_OnionMessageContentsResponseInstructionZ : CommonBase {
	internal TwoTuple_OnionMessageContentsResponseInstructionZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_OnionMessageContentsResponseInstructionZ() {
		if (ptr != 0) { bindings.C2Tuple_OnionMessageContentsResponseInstructionZ_free(ptr); }
	}

	/**
	 * 
	 */
	public org.ldk.structs.OnionMessageContents get_a() {
		long ret = bindings.C2Tuple_OnionMessageContentsResponseInstructionZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public org.ldk.structs.ResponseInstruction get_b() {
		long ret = bindings.C2Tuple_OnionMessageContentsResponseInstructionZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ResponseInstruction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ResponseInstruction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_OnionMessageContentsResponseInstructionZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.TwoTuple_OnionMessageContentsResponseInstructionZ clone() {
		long ret = bindings.C2Tuple_OnionMessageContentsResponseInstructionZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OnionMessageContentsResponseInstructionZ ret_hu_conv = new TwoTuple_OnionMessageContentsResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_OnionMessageContentsResponseInstructionZ from the contained elements.
	 */
	public static org.ldk.structs.TwoTuple_OnionMessageContentsResponseInstructionZ of(org.ldk.structs.OnionMessageContents a, org.ldk.structs.ResponseInstruction b) {
		long ret = bindings.C2Tuple_OnionMessageContentsResponseInstructionZ_new(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OnionMessageContentsResponseInstructionZ ret_hu_conv = new TwoTuple_OnionMessageContentsResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

}
} } }
