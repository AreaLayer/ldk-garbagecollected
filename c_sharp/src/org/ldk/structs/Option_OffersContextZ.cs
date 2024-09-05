using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::blinded_path::message::OffersContext or not
 */
public class Option_OffersContextZ : CommonBase {
	protected Option_OffersContextZ(object _dummy, long ptr) : base(ptr) { }
	~Option_OffersContextZ() {
		if (ptr != 0) { bindings.COption_OffersContextZ_free(ptr); }
	}

	internal static Option_OffersContextZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_OffersContextZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_OffersContextZ_Some(ptr);
			case 1: return new Option_OffersContextZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_OffersContextZ of type Some */
	public class Option_OffersContextZ_Some : Option_OffersContextZ {
		public OffersContext some;
		internal Option_OffersContextZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_OffersContextZ_Some_get_some(ptr);
			org.ldk.structs.OffersContext some_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_OffersContextZ of type None */
	public class Option_OffersContextZ_None : Option_OffersContextZ {
		internal Option_OffersContextZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_OffersContextZ containing a crate::lightning::blinded_path::message::OffersContext
	 */
	public static Option_OffersContextZ some(org.ldk.structs.OffersContext o) {
		long ret = bindings.COption_OffersContextZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OffersContextZ ret_hu_conv = org.ldk.structs.Option_OffersContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_OffersContextZ containing nothing
	 */
	public static Option_OffersContextZ none() {
		long ret = bindings.COption_OffersContextZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OffersContextZ ret_hu_conv = org.ldk.structs.Option_OffersContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_OffersContextZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_OffersContextZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_OffersContextZ clone() {
		long ret = bindings.COption_OffersContextZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OffersContextZ ret_hu_conv = org.ldk.structs.Option_OffersContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
