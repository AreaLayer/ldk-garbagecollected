using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::blinded_path::message::MessageContext or not
 */
public class Option_MessageContextZ : CommonBase {
	protected Option_MessageContextZ(object _dummy, long ptr) : base(ptr) { }
	~Option_MessageContextZ() {
		if (ptr != 0) { bindings.COption_MessageContextZ_free(ptr); }
	}

	internal static Option_MessageContextZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_MessageContextZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_MessageContextZ_Some(ptr);
			case 1: return new Option_MessageContextZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_MessageContextZ of type Some */
	public class Option_MessageContextZ_Some : Option_MessageContextZ {
		public MessageContext some;
		internal Option_MessageContextZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_MessageContextZ_Some_get_some(ptr);
			org.ldk.structs.MessageContext some_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_MessageContextZ of type None */
	public class Option_MessageContextZ_None : Option_MessageContextZ {
		internal Option_MessageContextZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_MessageContextZ containing a crate::lightning::blinded_path::message::MessageContext
	 */
	public static Option_MessageContextZ some(org.ldk.structs.MessageContext o) {
		long ret = bindings.COption_MessageContextZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_MessageContextZ ret_hu_conv = org.ldk.structs.Option_MessageContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_MessageContextZ containing nothing
	 */
	public static Option_MessageContextZ none() {
		long ret = bindings.COption_MessageContextZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_MessageContextZ ret_hu_conv = org.ldk.structs.Option_MessageContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_MessageContextZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_MessageContextZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_MessageContextZ clone() {
		long ret = bindings.COption_MessageContextZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_MessageContextZ ret_hu_conv = org.ldk.structs.Option_MessageContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
