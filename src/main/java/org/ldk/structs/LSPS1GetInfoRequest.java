package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A request made to an LSP to retrieve the supported options.
 * 
 * Please refer to the [bLIP-51 / LSPS1
 * specification](https://github.com/lightning/blips/blob/master/blip-0051.md#1-lsps1get_info) for
 * more information.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1GetInfoRequest extends CommonBase {
	LSPS1GetInfoRequest(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1GetInfoRequest_free(ptr); }
	}

	/**
	 * Constructs a new LSPS1GetInfoRequest given each field
	 */
	public static LSPS1GetInfoRequest of() {
		long ret = bindings.LSPS1GetInfoRequest_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1GetInfoRequest_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1GetInfoRequest
	 */
	public LSPS1GetInfoRequest clone() {
		long ret = bindings.LSPS1GetInfoRequest_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1GetInfoRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1GetInfoRequest b) {
		boolean ret = bindings.LSPS1GetInfoRequest_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1GetInfoRequest)) return false;
		return this.eq((LSPS1GetInfoRequest)o);
	}
}
