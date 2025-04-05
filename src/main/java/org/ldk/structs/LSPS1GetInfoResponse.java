package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A response to a [`LSPS1GetInfoRequest`].
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1GetInfoResponse extends CommonBase {
	LSPS1GetInfoResponse(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1GetInfoResponse_free(ptr); }
	}

	/**
	 * All options supported by the LSP.
	 */
	public LSPS1Options get_options() {
		long ret = bindings.LSPS1GetInfoResponse_get_options(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Options ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Options(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * All options supported by the LSP.
	 */
	public void set_options(org.ldk.structs.LSPS1Options val) {
		bindings.LSPS1GetInfoResponse_set_options(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1GetInfoResponse given each field
	 */
	public static LSPS1GetInfoResponse of(org.ldk.structs.LSPS1Options options_arg) {
		long ret = bindings.LSPS1GetInfoResponse_new(options_arg.ptr);
		Reference.reachabilityFence(options_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetInfoResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetInfoResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1GetInfoResponse_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1GetInfoResponse
	 */
	public LSPS1GetInfoResponse clone() {
		long ret = bindings.LSPS1GetInfoResponse_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetInfoResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetInfoResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1GetInfoResponses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1GetInfoResponse b) {
		boolean ret = bindings.LSPS1GetInfoResponse_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1GetInfoResponse)) return false;
		return this.eq((LSPS1GetInfoResponse)o);
	}
}
