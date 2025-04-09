package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An error returned in response to an JSON-RPC request.
 * 
 * Please refer to the [JSON-RPC 2.0 specification](https://www.jsonrpc.org/specification#error_object) for
 * more information.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPSResponseError extends CommonBase {
	LSPSResponseError(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPSResponseError_free(ptr); }
	}

	/**
	 * A string providing a short description of the error.
	 */
	public String get_message() {
		String ret = bindings.LSPSResponseError_get_message(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A string providing a short description of the error.
	 */
	public void set_message(java.lang.String val) {
		bindings.LSPSResponseError_set_message(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * A primitive or structured value that contains additional information about the error.
	 */
	public Option_StrZ get_data() {
		long ret = bindings.LSPSResponseError_get_data(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * A primitive or structured value that contains additional information about the error.
	 */
	public void set_data(org.ldk.structs.Option_StrZ val) {
		bindings.LSPSResponseError_set_data(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	long clone_ptr() {
		long ret = bindings.LSPSResponseError_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSResponseError
	 */
	public LSPSResponseError clone() {
		long ret = bindings.LSPSResponseError_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSResponseError ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSResponseError(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSResponseErrors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPSResponseError b) {
		boolean ret = bindings.LSPSResponseError_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPSResponseError)) return false;
		return this.eq((LSPSResponseError)o);
	}
}
