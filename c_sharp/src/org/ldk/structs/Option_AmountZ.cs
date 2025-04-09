using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::offers::offer::Amount or not
 */
public class Option_AmountZ : CommonBase {
	protected Option_AmountZ(object _dummy, long ptr) : base(ptr) { }
	~Option_AmountZ() {
		if (ptr != 0) { bindings.COption_AmountZ_free(ptr); }
	}

	internal static Option_AmountZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_AmountZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_AmountZ_Some(ptr);
			case 1: return new Option_AmountZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_AmountZ of type Some */
	public class Option_AmountZ_Some : Option_AmountZ {
		public org.ldk.structs.Amount some;
		internal Option_AmountZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_AmountZ_Some_get_some(ptr);
			org.ldk.structs.Amount some_hu_conv = org.ldk.structs.Amount.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_AmountZ of type None */
	public class Option_AmountZ_None : Option_AmountZ {
		internal Option_AmountZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_AmountZ containing a crate::lightning::offers::offer::Amount
	 */
	public static org.ldk.structs.Option_AmountZ some(org.ldk.structs.Amount o) {
		long ret = bindings.COption_AmountZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AmountZ ret_hu_conv = org.ldk.structs.Option_AmountZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_AmountZ containing nothing
	 */
	public static org.ldk.structs.Option_AmountZ none() {
		long ret = bindings.COption_AmountZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AmountZ ret_hu_conv = org.ldk.structs.Option_AmountZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_AmountZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_AmountZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Option_AmountZ clone() {
		long ret = bindings.COption_AmountZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AmountZ ret_hu_conv = org.ldk.structs.Option_AmountZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
