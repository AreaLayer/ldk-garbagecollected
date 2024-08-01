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
public class TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ extends CommonBase {
	TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_free(ptr); }
	}

	/**
	 * 
	 */
	public AsyncPaymentsMessage get_a() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsMessage ret_hu_conv = org.ldk.structs.AsyncPaymentsMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public MessageSendInstructions get_b() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ clone() {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ ret_hu_conv = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ from the contained elements.
	 */
	public static TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ of(org.ldk.structs.AsyncPaymentsMessage a, org.ldk.structs.MessageSendInstructions b) {
		long ret = bindings.C2Tuple_AsyncPaymentsMessageMessageSendInstructionsZ_new(a.ptr, b.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ ret_hu_conv = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
