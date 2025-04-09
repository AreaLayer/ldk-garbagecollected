using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::blinded_path::payment::PaymentContext or not
 */
public class Option_PaymentContextZ : CommonBase {
	protected Option_PaymentContextZ(object _dummy, long ptr) : base(ptr) { }
	~Option_PaymentContextZ() {
		if (ptr != 0) { bindings.COption_PaymentContextZ_free(ptr); }
	}

	internal static Option_PaymentContextZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_PaymentContextZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_PaymentContextZ_Some(ptr);
			case 1: return new Option_PaymentContextZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_PaymentContextZ of type Some */
	public class Option_PaymentContextZ_Some : Option_PaymentContextZ {
		public org.ldk.structs.PaymentContext some;
		internal Option_PaymentContextZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_PaymentContextZ_Some_get_some(ptr);
			org.ldk.structs.PaymentContext some_hu_conv = org.ldk.structs.PaymentContext.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_PaymentContextZ of type None */
	public class Option_PaymentContextZ_None : Option_PaymentContextZ {
		internal Option_PaymentContextZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_PaymentContextZ containing a crate::lightning::blinded_path::payment::PaymentContext
	 */
	public static org.ldk.structs.Option_PaymentContextZ some(org.ldk.structs.PaymentContext o) {
		long ret = bindings.COption_PaymentContextZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentContextZ ret_hu_conv = org.ldk.structs.Option_PaymentContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_PaymentContextZ containing nothing
	 */
	public static org.ldk.structs.Option_PaymentContextZ none() {
		long ret = bindings.COption_PaymentContextZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentContextZ ret_hu_conv = org.ldk.structs.Option_PaymentContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_PaymentContextZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_PaymentContextZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Option_PaymentContextZ clone() {
		long ret = bindings.COption_PaymentContextZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentContextZ ret_hu_conv = org.ldk.structs.Option_PaymentContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
