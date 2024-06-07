using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::ln::channel_state::InboundHTLCStateDetails or not
 */
public class Option_InboundHTLCStateDetailsZ : CommonBase {
	protected Option_InboundHTLCStateDetailsZ(object _dummy, long ptr) : base(ptr) { }
	~Option_InboundHTLCStateDetailsZ() {
		if (ptr != 0) { bindings.COption_InboundHTLCStateDetailsZ_free(ptr); }
	}

	internal static Option_InboundHTLCStateDetailsZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_InboundHTLCStateDetailsZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_InboundHTLCStateDetailsZ_Some(ptr);
			case 1: return new Option_InboundHTLCStateDetailsZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_InboundHTLCStateDetailsZ of type Some */
	public class Option_InboundHTLCStateDetailsZ_Some : Option_InboundHTLCStateDetailsZ {
		public InboundHTLCStateDetails some;
		internal Option_InboundHTLCStateDetailsZ_Some(long ptr) : base(null, ptr) {
			this.some = bindings.LDKCOption_InboundHTLCStateDetailsZ_Some_get_some(ptr);
		}
	}
	/** A Option_InboundHTLCStateDetailsZ of type None */
	public class Option_InboundHTLCStateDetailsZ_None : Option_InboundHTLCStateDetailsZ {
		internal Option_InboundHTLCStateDetailsZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_InboundHTLCStateDetailsZ containing a crate::lightning::ln::channel_state::InboundHTLCStateDetails
	 */
	public static Option_InboundHTLCStateDetailsZ some(InboundHTLCStateDetails o) {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_some(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_InboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_InboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_InboundHTLCStateDetailsZ containing nothing
	 */
	public static Option_InboundHTLCStateDetailsZ none() {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_InboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_InboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_InboundHTLCStateDetailsZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_InboundHTLCStateDetailsZ clone() {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_InboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_InboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
