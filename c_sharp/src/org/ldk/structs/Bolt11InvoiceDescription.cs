using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Represents the description of an invoice which has to be either a directly included string or
 * a hash of a description provided out of band.
 */
public class Bolt11InvoiceDescription : CommonBase {
	protected Bolt11InvoiceDescription(object _dummy, long ptr) : base(ptr) { }
	~Bolt11InvoiceDescription() {
		if (ptr != 0) { bindings.Bolt11InvoiceDescription_free(ptr); }
	}

	internal static Bolt11InvoiceDescription constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKBolt11InvoiceDescription_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Bolt11InvoiceDescription_Direct(ptr);
			case 1: return new Bolt11InvoiceDescription_Hash(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Bolt11InvoiceDescription of type Direct */
	public class Bolt11InvoiceDescription_Direct : Bolt11InvoiceDescription {
		public Description direct;
		internal Bolt11InvoiceDescription_Direct(long ptr) : base(null, ptr) {
			long direct = bindings.LDKBolt11InvoiceDescription_Direct_get_direct(ptr);
			org.ldk.structs.Description direct_hu_conv = null; if (direct < 0 || direct > 4096) { direct_hu_conv = new org.ldk.structs.Description(null, direct); }
			if (direct_hu_conv != null) { direct_hu_conv.ptrs_to.AddLast(this); };
			this.direct = direct_hu_conv;
		}
	}
	/** A Bolt11InvoiceDescription of type Hash */
	public class Bolt11InvoiceDescription_Hash : Bolt11InvoiceDescription {
		public Sha256 hash;
		internal Bolt11InvoiceDescription_Hash(long ptr) : base(null, ptr) {
			long hash = bindings.LDKBolt11InvoiceDescription_Hash_get_hash(ptr);
			org.ldk.structs.Sha256 hash_hu_conv = null; if (hash < 0 || hash > 4096) { hash_hu_conv = new org.ldk.structs.Sha256(null, hash); }
			if (hash_hu_conv != null) { hash_hu_conv.ptrs_to.AddLast(this); };
			this.hash = hash_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.Bolt11InvoiceDescription_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Bolt11InvoiceDescription
	 */
	public Bolt11InvoiceDescription clone() {
		long ret = bindings.Bolt11InvoiceDescription_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceDescription ret_hu_conv = org.ldk.structs.Bolt11InvoiceDescription.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Direct-variant Bolt11InvoiceDescription
	 */
	public static Bolt11InvoiceDescription direct(org.ldk.structs.Description a) {
		long ret = bindings.Bolt11InvoiceDescription_direct(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceDescription ret_hu_conv = org.ldk.structs.Bolt11InvoiceDescription.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Hash-variant Bolt11InvoiceDescription
	 */
	public static Bolt11InvoiceDescription hash(org.ldk.structs.Sha256 a) {
		long ret = bindings.Bolt11InvoiceDescription_hash(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceDescription ret_hu_conv = org.ldk.structs.Bolt11InvoiceDescription.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two Bolt11InvoiceDescriptions contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.Bolt11InvoiceDescription b) {
		bool ret = bindings.Bolt11InvoiceDescription_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Bolt11InvoiceDescription)) return false;
		return this.eq((Bolt11InvoiceDescription)o);
	}
	/**
	 * Get the string representation of a Bolt11InvoiceDescription object
	 */
	public string to_str() {
		long ret = bindings.Bolt11InvoiceDescription_to_str(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

}
} } }
