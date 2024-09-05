using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::offers::offer::Quantity or not
 */
public class Option_QuantityZ : CommonBase {
	protected Option_QuantityZ(object _dummy, long ptr) : base(ptr) { }
	~Option_QuantityZ() {
		if (ptr != 0) { bindings.COption_QuantityZ_free(ptr); }
	}

	internal static Option_QuantityZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_QuantityZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_QuantityZ_Some(ptr);
			case 1: return new Option_QuantityZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_QuantityZ of type Some */
	public class Option_QuantityZ_Some : Option_QuantityZ {
		public Quantity some;
		internal Option_QuantityZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_QuantityZ_Some_get_some(ptr);
			org.ldk.structs.Quantity some_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_QuantityZ of type None */
	public class Option_QuantityZ_None : Option_QuantityZ {
		internal Option_QuantityZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_QuantityZ containing a crate::lightning::offers::offer::Quantity
	 */
	public static Option_QuantityZ some(org.ldk.structs.Quantity o) {
		long ret = bindings.COption_QuantityZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_QuantityZ ret_hu_conv = org.ldk.structs.Option_QuantityZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_QuantityZ containing nothing
	 */
	public static Option_QuantityZ none() {
		long ret = bindings.COption_QuantityZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_QuantityZ ret_hu_conv = org.ldk.structs.Option_QuantityZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_QuantityZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_QuantityZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_QuantityZ clone() {
		long ret = bindings.COption_QuantityZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_QuantityZ ret_hu_conv = org.ldk.structs.Option_QuantityZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
