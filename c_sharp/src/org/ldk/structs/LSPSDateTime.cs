using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An object representing datetimes as described in bLIP-50 / LSPS0.
 */
public class LSPSDateTime : CommonBase {
	internal LSPSDateTime(object _dummy, long ptr) : base(ptr) { }
	~LSPSDateTime() {
		if (ptr != 0) { bindings.LSPSDateTime_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.LSPSDateTime_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSDateTime
	 */
	public org.ldk.structs.LSPSDateTime clone() {
		long ret = bindings.LSPSDateTime_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSDateTimes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPSDateTime b) {
		bool ret = bindings.LSPSDateTime_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPSDateTime)) return false;
		return this.eq((LSPSDateTime)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the LSPSDateTime.
	 */
	public long hash() {
		long ret = bindings.LSPSDateTime_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Returns the LSPSDateTime as RFC3339 formatted string.
	 */
	public string to_rfc3339() {
		long ret = bindings.LSPSDateTime_to_rfc3339(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * Returns if the given time is in the past.
	 */
	public bool is_past() {
		bool ret = bindings.LSPSDateTime_is_past(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a LSPSDateTime object from a string
	 */
	public static org.ldk.structs.Result_LSPSDateTimeNoneZ from_str(string s) {
		long ret = bindings.LSPSDateTime_from_str(InternalUtils.encodeString(s));
		GC.KeepAlive(s);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Get the string representation of a LSPSDateTime object
	 */
	public string to_str() {
		long ret = bindings.LSPSDateTime_to_str(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

}
} } }
