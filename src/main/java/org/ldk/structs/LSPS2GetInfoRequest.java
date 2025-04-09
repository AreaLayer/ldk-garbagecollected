package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A request made to an LSP to learn their current channel fees and parameters.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2GetInfoRequest extends CommonBase {
	LSPS2GetInfoRequest(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2GetInfoRequest_free(ptr); }
	}

	/**
	 * An optional token to provide to the LSP.
	 */
	public Option_StrZ get_token() {
		long ret = bindings.LSPS2GetInfoRequest_get_token(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * An optional token to provide to the LSP.
	 */
	public void set_token(org.ldk.structs.Option_StrZ val) {
		bindings.LSPS2GetInfoRequest_set_token(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS2GetInfoRequest given each field
	 */
	public static LSPS2GetInfoRequest of(org.ldk.structs.Option_StrZ token_arg) {
		long ret = bindings.LSPS2GetInfoRequest_new(token_arg.ptr);
		Reference.reachabilityFence(token_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS2GetInfoRequest_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2GetInfoRequest
	 */
	public LSPS2GetInfoRequest clone() {
		long ret = bindings.LSPS2GetInfoRequest_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2GetInfoRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS2GetInfoRequest b) {
		boolean ret = bindings.LSPS2GetInfoRequest_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2GetInfoRequest)) return false;
		return this.eq((LSPS2GetInfoRequest)o);
	}
}
