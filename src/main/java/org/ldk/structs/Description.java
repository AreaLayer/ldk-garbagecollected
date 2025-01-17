package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Description string
 * 
 * # Invariants
 * The description can be at most 639 __bytes__ long
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Description extends CommonBase {
	Description(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Description_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.Description_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Description
	 */
	public Description clone() {
		long ret = bindings.Description_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Description ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Description(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Description.
	 */
	public long hash() {
		long ret = bindings.Description_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Descriptions contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.Description b) {
		boolean ret = bindings.Description_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof Description)) return false;
		return this.eq((Description)o);
	}
	/**
	 * Creates a new `Description` if `description` is at most 1023 * 5 bits (i.e., 639 bytes)
	 * long, and returns [`CreationError::DescriptionTooLong`] otherwise.
	 * 
	 * Please note that single characters may use more than one byte due to UTF8 encoding.
	 */
	public static Result_DescriptionCreationErrorZ of(java.lang.String description) {
		long ret = bindings.Description_new(description);
		Reference.reachabilityFence(description);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DescriptionCreationErrorZ ret_hu_conv = Result_DescriptionCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates an empty `Description`.
	 */
	public static Description empty() {
		long ret = bindings.Description_empty();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Description ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Description(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Returns the underlying description [`UntrustedString`]
	 */
	public UntrustedString into_inner() {
		long ret = bindings.Description_into_inner(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UntrustedString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UntrustedString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		;
		return ret_hu_conv;
	}

	/**
	 * Get a reference to the underlying description [`UntrustedString`]
	 */
	public UntrustedString as_inner() {
		long ret = bindings.Description_as_inner(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UntrustedString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UntrustedString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Get the string representation of a Description object
	 */
	public String to_str() {
		String ret = bindings.Description_to_str(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
