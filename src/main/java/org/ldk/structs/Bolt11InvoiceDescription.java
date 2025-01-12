package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Represents the description of an invoice which has to be either a directly included string or
 * a hash of a description provided out of band.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Bolt11InvoiceDescription extends CommonBase {
	private Bolt11InvoiceDescription(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Bolt11InvoiceDescription_free(ptr); }
	}
	static Bolt11InvoiceDescription constr_from_ptr(long ptr) {
		bindings.LDKBolt11InvoiceDescription raw_val = bindings.LDKBolt11InvoiceDescription_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKBolt11InvoiceDescription.Direct.class) {
			return new Direct(ptr, (bindings.LDKBolt11InvoiceDescription.Direct)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKBolt11InvoiceDescription.Hash.class) {
			return new Hash(ptr, (bindings.LDKBolt11InvoiceDescription.Hash)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Description of what the invoice is for
	 */
	public final static class Direct extends Bolt11InvoiceDescription {
		public final org.ldk.structs.Description direct;
		private Direct(long ptr, bindings.LDKBolt11InvoiceDescription.Direct obj) {
			super(null, ptr);
			long direct = obj.direct;
			org.ldk.structs.Description direct_hu_conv = null; if (direct < 0 || direct > 4096) { direct_hu_conv = new org.ldk.structs.Description(null, direct); }
			if (direct_hu_conv != null) { direct_hu_conv.ptrs_to.add(this); };
			this.direct = direct_hu_conv;
		}
	}
	/**
	 * Hash of the description of what the invoice is for
	 */
	public final static class Hash extends Bolt11InvoiceDescription {
		public final org.ldk.structs.Sha256 hash;
		private Hash(long ptr, bindings.LDKBolt11InvoiceDescription.Hash obj) {
			super(null, ptr);
			long hash = obj.hash;
			org.ldk.structs.Sha256 hash_hu_conv = null; if (hash < 0 || hash > 4096) { hash_hu_conv = new org.ldk.structs.Sha256(null, hash); }
			if (hash_hu_conv != null) { hash_hu_conv.ptrs_to.add(this); };
			this.hash = hash_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.Bolt11InvoiceDescription_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Bolt11InvoiceDescription
	 */
	public Bolt11InvoiceDescription clone() {
		long ret = bindings.Bolt11InvoiceDescription_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceDescription ret_hu_conv = org.ldk.structs.Bolt11InvoiceDescription.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Direct-variant Bolt11InvoiceDescription
	 */
	public static Bolt11InvoiceDescription direct(org.ldk.structs.Description a) {
		long ret = bindings.Bolt11InvoiceDescription_direct(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceDescription ret_hu_conv = org.ldk.structs.Bolt11InvoiceDescription.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Hash-variant Bolt11InvoiceDescription
	 */
	public static Bolt11InvoiceDescription hash(org.ldk.structs.Sha256 a) {
		long ret = bindings.Bolt11InvoiceDescription_hash(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceDescription ret_hu_conv = org.ldk.structs.Bolt11InvoiceDescription.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two Bolt11InvoiceDescriptions contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.Bolt11InvoiceDescription b) {
		boolean ret = bindings.Bolt11InvoiceDescription_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof Bolt11InvoiceDescription)) return false;
		return this.eq((Bolt11InvoiceDescription)o);
	}
	/**
	 * Get the string representation of a Bolt11InvoiceDescription object
	 */
	public String to_str() {
		String ret = bindings.Bolt11InvoiceDescription_to_str(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
