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
public class TwoTuple_ReleaseHeldHtlcResponseInstructionZ extends CommonBase {
	TwoTuple_ReleaseHeldHtlcResponseInstructionZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_free(ptr); }
	}

	/**
	 * 
	 */
	public ReleaseHeldHtlc get_a() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReleaseHeldHtlc ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public ResponseInstruction get_b() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ResponseInstruction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ResponseInstruction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_ReleaseHeldHtlcResponseInstructionZ clone() {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ReleaseHeldHtlcResponseInstructionZ ret_hu_conv = new TwoTuple_ReleaseHeldHtlcResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_ReleaseHeldHtlcResponseInstructionZ from the contained elements.
	 */
	public static TwoTuple_ReleaseHeldHtlcResponseInstructionZ of(org.ldk.structs.ReleaseHeldHtlc a, org.ldk.structs.ResponseInstruction b) {
		long ret = bindings.C2Tuple_ReleaseHeldHtlcResponseInstructionZ_new(a.ptr, b.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ReleaseHeldHtlcResponseInstructionZ ret_hu_conv = new TwoTuple_ReleaseHeldHtlcResponseInstructionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
