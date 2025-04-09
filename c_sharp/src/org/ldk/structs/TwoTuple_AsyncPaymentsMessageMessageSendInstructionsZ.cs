using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ : CommonBase {
	internal TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ() {
		if (ptr != 0) { bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_free(ptr); }
	}

	/**
	 * 
	 */
	public org.ldk.structs.AsyncPaymentsMessage get_a() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsMessage ret_hu_conv = org.ldk.structs.AsyncPaymentsMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public org.ldk.structs.MessageSendInstructions get_b() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ clone() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ ret_hu_conv = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ from the contained elements.
	 */
	public static org.ldk.structs.TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ of(org.ldk.structs.AsyncPaymentsMessage a, org.ldk.structs.MessageSendInstructions b) {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_new(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ ret_hu_conv = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
