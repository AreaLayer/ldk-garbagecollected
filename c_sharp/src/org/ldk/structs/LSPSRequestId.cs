using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A JSON-RPC request's `id`.
 * 
 * Please refer to the [JSON-RPC 2.0 specification](https://www.jsonrpc.org/specification#request_object) for
 * more information.
 */
public class LSPSRequestId : CommonBase {
	internal LSPSRequestId(object _dummy, long ptr) : base(ptr) { }
	~LSPSRequestId() {
		if (ptr != 0) { bindings.LSPSRequestId_free(ptr); }
	}

	public string get_a() {
		long ret = bindings.LSPSRequestId_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	public void set_a(string val) {
		bindings.LSPSRequestId_set_a(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPSRequestId given each field
	 */
	public static org.ldk.structs.LSPSRequestId of(string a_arg) {
		long ret = bindings.LSPSRequestId_new(InternalUtils.encodeString(a_arg));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPSRequestId_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSRequestId
	 */
	public org.ldk.structs.LSPSRequestId clone() {
		long ret = bindings.LSPSRequestId_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSRequestIds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPSRequestId b) {
		bool ret = bindings.LSPSRequestId_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPSRequestId)) return false;
		return this.eq((LSPSRequestId)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the LSPSRequestId.
	 */
	public long hash() {
		long ret = bindings.LSPSRequestId_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
}
} } }
