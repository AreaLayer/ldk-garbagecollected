package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Recoverable signature
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Bolt11InvoiceSignature extends CommonBase {
	Bolt11InvoiceSignature(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Bolt11InvoiceSignature_free(ptr); }
	}

	public byte[] get_a() {
		byte[] ret = bindings.Bolt11InvoiceSignature_get_a(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	public void set_a(byte[] val) {
		bindings.Bolt11InvoiceSignature_set_a(this.ptr, InternalUtils.check_arr_len(val, 68));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new Bolt11InvoiceSignature given each field
	 */
	public static Bolt11InvoiceSignature of(byte[] a_arg) {
		long ret = bindings.Bolt11InvoiceSignature_new(InternalUtils.check_arr_len(a_arg, 68));
		Reference.reachabilityFence(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceSignature ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt11InvoiceSignature(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.Bolt11InvoiceSignature_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Bolt11InvoiceSignature
	 */
	public Bolt11InvoiceSignature clone() {
		long ret = bindings.Bolt11InvoiceSignature_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceSignature ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt11InvoiceSignature(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Bolt11InvoiceSignature.
	 */
	public long hash() {
		long ret = bindings.Bolt11InvoiceSignature_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Bolt11InvoiceSignatures contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.Bolt11InvoiceSignature b) {
		boolean ret = bindings.Bolt11InvoiceSignature_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof Bolt11InvoiceSignature)) return false;
		return this.eq((Bolt11InvoiceSignature)o);
	}
}
