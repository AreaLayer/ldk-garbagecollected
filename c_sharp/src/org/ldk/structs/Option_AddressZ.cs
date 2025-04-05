using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::Address or not
 */
public class Option_AddressZ : CommonBase {
	protected Option_AddressZ(object _dummy, long ptr) : base(ptr) { }
	~Option_AddressZ() {
		if (ptr != 0) { bindings.COption_AddressZ_free(ptr); }
	}

	internal static Option_AddressZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_AddressZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_AddressZ_Some(ptr);
			case 1: return new Option_AddressZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_AddressZ of type Some */
	public class Option_AddressZ_Some : Option_AddressZ {
		public org.ldk.structs.Address some;
		internal Option_AddressZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_AddressZ_Some_get_some(ptr);
			Address some_conv = new Address(null, some);
			this.some = some_conv;
		}
	}
	/** A Option_AddressZ of type None */
	public class Option_AddressZ_None : Option_AddressZ {
		internal Option_AddressZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_AddressZ containing a crate::c_types::Address
	 */
	public static org.ldk.structs.Option_AddressZ some(org.ldk.structs.Address o) {
		long ret = bindings.COption_AddressZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AddressZ ret_hu_conv = org.ldk.structs.Option_AddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_AddressZ containing nothing
	 */
	public static org.ldk.structs.Option_AddressZ none() {
		long ret = bindings.COption_AddressZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AddressZ ret_hu_conv = org.ldk.structs.Option_AddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
