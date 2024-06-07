using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::ln::channel_state::OutboundHTLCStateDetails or not
 */
public class Option_OutboundHTLCStateDetailsZ : CommonBase {
	protected Option_OutboundHTLCStateDetailsZ(object _dummy, long ptr) : base(ptr) { }
	~Option_OutboundHTLCStateDetailsZ() {
		if (ptr != 0) { bindings.COption_OutboundHTLCStateDetailsZ_free(ptr); }
	}

	internal static Option_OutboundHTLCStateDetailsZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_OutboundHTLCStateDetailsZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_OutboundHTLCStateDetailsZ_Some(ptr);
			case 1: return new Option_OutboundHTLCStateDetailsZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_OutboundHTLCStateDetailsZ of type Some */
	public class Option_OutboundHTLCStateDetailsZ_Some : Option_OutboundHTLCStateDetailsZ {
		public OutboundHTLCStateDetails some;
		internal Option_OutboundHTLCStateDetailsZ_Some(long ptr) : base(null, ptr) {
			this.some = bindings.LDKCOption_OutboundHTLCStateDetailsZ_Some_get_some(ptr);
		}
	}
	/** A Option_OutboundHTLCStateDetailsZ of type None */
	public class Option_OutboundHTLCStateDetailsZ_None : Option_OutboundHTLCStateDetailsZ {
		internal Option_OutboundHTLCStateDetailsZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_OutboundHTLCStateDetailsZ containing a crate::lightning::ln::channel_state::OutboundHTLCStateDetails
	 */
	public static Option_OutboundHTLCStateDetailsZ some(OutboundHTLCStateDetails o) {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_some(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OutboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_OutboundHTLCStateDetailsZ containing nothing
	 */
	public static Option_OutboundHTLCStateDetailsZ none() {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OutboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_OutboundHTLCStateDetailsZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_OutboundHTLCStateDetailsZ clone() {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OutboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
