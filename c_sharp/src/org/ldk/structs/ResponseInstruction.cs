using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Instructions for how and where to send the response to an onion message.
 */
public class ResponseInstruction : CommonBase {
	internal ResponseInstruction(object _dummy, long ptr) : base(ptr) { }
	~ResponseInstruction() {
		if (ptr != 0) { bindings.ResponseInstruction_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.ResponseInstruction_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ResponseInstruction
	 */
	public ResponseInstruction clone() {
		long ret = bindings.ResponseInstruction_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ResponseInstruction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ResponseInstruction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Converts this [`ResponseInstruction`] into a [`MessageSendInstructions`] so that it can be
	 * used to send the response via a normal message sending method.
	 */
	public MessageSendInstructions into_instructions() {
		long ret = bindings.ResponseInstruction_into_instructions(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		;
		return ret_hu_conv;
	}

}
} } }
