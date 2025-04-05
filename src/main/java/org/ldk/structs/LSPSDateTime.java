package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An object representing datetimes as described in bLIP-50 / LSPS0.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPSDateTime extends CommonBase {
	LSPSDateTime(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPSDateTime_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.LSPSDateTime_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSDateTime
	 */
	public LSPSDateTime clone() {
		long ret = bindings.LSPSDateTime_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSDateTimes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPSDateTime b) {
		boolean ret = bindings.LSPSDateTime_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPSDateTime)) return false;
		return this.eq((LSPSDateTime)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the LSPSDateTime.
	 */
	public long hash() {
		long ret = bindings.LSPSDateTime_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Returns the LSPSDateTime as RFC3339 formatted string.
	 */
	public String to_rfc3339() {
		String ret = bindings.LSPSDateTime_to_rfc3339(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Returns if the given time is in the past.
	 */
	public boolean is_past() {
		boolean ret = bindings.LSPSDateTime_is_past(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a LSPSDateTime object from a string
	 */
	public static Result_LSPSDateTimeNoneZ from_str(java.lang.String s) {
		long ret = bindings.LSPSDateTime_from_str(s);
		Reference.reachabilityFence(s);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSDateTimeNoneZ ret_hu_conv = Result_LSPSDateTimeNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Get the string representation of a LSPSDateTime object
	 */
	public String to_str() {
		String ret = bindings.LSPSDateTime_to_str(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
