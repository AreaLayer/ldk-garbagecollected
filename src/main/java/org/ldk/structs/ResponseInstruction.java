package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Instructions for how and where to send the response to an onion message.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ResponseInstruction extends CommonBase {
	ResponseInstruction(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ResponseInstruction_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.ResponseInstruction_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ResponseInstruction
	 */
	public ResponseInstruction clone() {
		long ret = bindings.ResponseInstruction_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ResponseInstruction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ResponseInstruction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Converts this [`ResponseInstruction`] into a [`MessageSendInstructions`] so that it can be
	 * used to send the response via a normal message sending method.
	 */
	public MessageSendInstructions into_instructions() {
		long ret = bindings.ResponseInstruction_into_instructions(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		;
		return ret_hu_conv;
	}

}
