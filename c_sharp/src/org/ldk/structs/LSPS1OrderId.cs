using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The identifier of an order.
 */
public class LSPS1OrderId : CommonBase {
	internal LSPS1OrderId(object _dummy, long ptr) : base(ptr) { }
	~LSPS1OrderId() {
		if (ptr != 0) { bindings.LSPS1OrderId_free(ptr); }
	}

	public string get_a() {
		long ret = bindings.LSPS1OrderId_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	public void set_a(string val) {
		bindings.LSPS1OrderId_set_a(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1OrderId given each field
	 */
	public static org.ldk.structs.LSPS1OrderId of(string a_arg) {
		long ret = bindings.LSPS1OrderId_new(InternalUtils.encodeString(a_arg));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1OrderId_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1OrderId
	 */
	public org.ldk.structs.LSPS1OrderId clone() {
		long ret = bindings.LSPS1OrderId_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1OrderIds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1OrderId b) {
		bool ret = bindings.LSPS1OrderId_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1OrderId)) return false;
		return this.eq((LSPS1OrderId)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the LSPS1OrderId.
	 */
	public long hash() {
		long ret = bindings.LSPS1OrderId_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
}
} } }
