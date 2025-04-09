package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A JSON-RPC request's `id`.
 * 
 * Please refer to the [JSON-RPC 2.0 specification](https://www.jsonrpc.org/specification#request_object) for
 * more information.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPSRequestId extends CommonBase {
	LSPSRequestId(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPSRequestId_free(ptr); }
	}

	public String get_a() {
		String ret = bindings.LSPSRequestId_get_a(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	public void set_a(java.lang.String val) {
		bindings.LSPSRequestId_set_a(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPSRequestId given each field
	 */
	public static LSPSRequestId of(java.lang.String a_arg) {
		long ret = bindings.LSPSRequestId_new(a_arg);
		Reference.reachabilityFence(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPSRequestId_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSRequestId
	 */
	public LSPSRequestId clone() {
		long ret = bindings.LSPSRequestId_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSRequestIds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPSRequestId b) {
		boolean ret = bindings.LSPSRequestId_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPSRequestId)) return false;
		return this.eq((LSPSRequestId)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the LSPSRequestId.
	 */
	public long hash() {
		long ret = bindings.LSPSRequestId_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
}
