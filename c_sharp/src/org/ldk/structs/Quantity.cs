using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Quantity of items supported by an [`Offer`].
 */
public class Quantity : CommonBase {
	protected Quantity(object _dummy, long ptr) : base(ptr) { }
	~Quantity() {
		if (ptr != 0) { bindings.Quantity_free(ptr); }
	}

	internal static Quantity constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKQuantity_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Quantity_Bounded(ptr);
			case 1: return new Quantity_Unbounded(ptr);
			case 2: return new Quantity_One(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Quantity of type Bounded */
	public class Quantity_Bounded : Quantity {
		public long bounded;
		internal Quantity_Bounded(long ptr) : base(null, ptr) {
			this.bounded = bindings.LDKQuantity_Bounded_get_bounded(ptr);
		}
	}
	/** A Quantity of type Unbounded */
	public class Quantity_Unbounded : Quantity {
		internal Quantity_Unbounded(long ptr) : base(null, ptr) {
		}
	}
	/** A Quantity of type One */
	public class Quantity_One : Quantity {
		internal Quantity_One(long ptr) : base(null, ptr) {
		}
	}
	internal long clone_ptr() {
		long ret = bindings.Quantity_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Quantity
	 */
	public org.ldk.structs.Quantity clone() {
		long ret = bindings.Quantity_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bounded-variant Quantity
	 */
	public static org.ldk.structs.Quantity bounded(long a) {
		long ret = bindings.Quantity_bounded(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Unbounded-variant Quantity
	 */
	public static org.ldk.structs.Quantity unbounded() {
		long ret = bindings.Quantity_unbounded();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new One-variant Quantity
	 */
	public static org.ldk.structs.Quantity one() {
		long ret = bindings.Quantity_one();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
