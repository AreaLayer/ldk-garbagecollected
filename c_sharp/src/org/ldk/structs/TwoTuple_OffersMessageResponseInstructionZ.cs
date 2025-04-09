using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_OffersMessageResponseInstructionZ : CommonBase {
	internal TwoTuple_OffersMessageResponseInstructionZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_OffersMessageResponseInstructionZ() {
		if (ptr != 0) { bindings.C2Tuple_OffersMessageResponseInstructionZ_free(ptr); }
	}

	/**
	 * 
	 */
	public org.ldk.structs.OffersMessage get_a() {
		long ret = bindings.C2Tuple_OffersMessageResponseInstructionZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OffersMessage ret_hu_conv = org.ldk.structs.OffersMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public org.ldk.structs.ResponseInstruction get_b() {
		long ret = bindings.C2Tuple_OffersMessageResponseInstructionZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ResponseInstruction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ResponseInstruction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_OffersMessageResponseInstructionZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.TwoTuple_OffersMessageResponseInstructionZ clone() {
		long ret = bindings.C2Tuple_OffersMessageResponseInstructionZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OffersMessageResponseInstructionZ ret_hu_conv = new TwoTuple_OffersMessageResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_OffersMessageResponseInstructionZ from the contained elements.
	 */
	public static org.ldk.structs.TwoTuple_OffersMessageResponseInstructionZ of(org.ldk.structs.OffersMessage a, org.ldk.structs.ResponseInstruction b) {
		long ret = bindings.C2Tuple_OffersMessageResponseInstructionZ_new(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OffersMessageResponseInstructionZ ret_hu_conv = new TwoTuple_OffersMessageResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
