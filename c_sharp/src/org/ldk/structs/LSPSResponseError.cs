using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An error returned in response to an JSON-RPC request.
 * 
 * Please refer to the [JSON-RPC 2.0 specification](https://www.jsonrpc.org/specification#error_object) for
 * more information.
 */
public class LSPSResponseError : CommonBase {
	internal LSPSResponseError(object _dummy, long ptr) : base(ptr) { }
	~LSPSResponseError() {
		if (ptr != 0) { bindings.LSPSResponseError_free(ptr); }
	}

	/**
	 * A string providing a short description of the error.
	 */
	public string get_message() {
		long ret = bindings.LSPSResponseError_get_message(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * A string providing a short description of the error.
	 */
	public void set_message(string val) {
		bindings.LSPSResponseError_set_message(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A primitive or structured value that contains additional information about the error.
	 */
	public org.ldk.structs.Option_StrZ get_data() {
		long ret = bindings.LSPSResponseError_get_data(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * A primitive or structured value that contains additional information about the error.
	 */
	public void set_data(org.ldk.structs.Option_StrZ val) {
		bindings.LSPSResponseError_set_data(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = bindings.LSPSResponseError_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSResponseError
	 */
	public org.ldk.structs.LSPSResponseError clone() {
		long ret = bindings.LSPSResponseError_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSResponseError ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSResponseError(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSResponseErrors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPSResponseError b) {
		bool ret = bindings.LSPSResponseError_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPSResponseError)) return false;
		return this.eq((LSPSResponseError)o);
	}
}
} } }
