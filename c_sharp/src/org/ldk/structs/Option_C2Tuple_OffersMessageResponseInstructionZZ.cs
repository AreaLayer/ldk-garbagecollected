using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::derived::C2Tuple_OffersMessageResponseInstructionZ or not
 */
public class Option_C2Tuple_OffersMessageResponseInstructionZZ : CommonBase {
	protected Option_C2Tuple_OffersMessageResponseInstructionZZ(object _dummy, long ptr) : base(ptr) { }
	~Option_C2Tuple_OffersMessageResponseInstructionZZ() {
		if (ptr != 0) { bindings.COption_C2Tuple_OffersMessageResponseInstructionZZ_free(ptr); }
	}

	internal static Option_C2Tuple_OffersMessageResponseInstructionZZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_C2Tuple_OffersMessageResponseInstructionZZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_C2Tuple_OffersMessageResponseInstructionZZ_Some(ptr);
			case 1: return new Option_C2Tuple_OffersMessageResponseInstructionZZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_C2Tuple_OffersMessageResponseInstructionZZ of type Some */
	public class Option_C2Tuple_OffersMessageResponseInstructionZZ_Some : Option_C2Tuple_OffersMessageResponseInstructionZZ {
		public TwoTuple_OffersMessageResponseInstructionZ some;
		internal Option_C2Tuple_OffersMessageResponseInstructionZZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_C2Tuple_OffersMessageResponseInstructionZZ_Some_get_some(ptr);
			TwoTuple_OffersMessageResponseInstructionZ some_hu_conv = new TwoTuple_OffersMessageResponseInstructionZ(null, some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_C2Tuple_OffersMessageResponseInstructionZZ of type None */
	public class Option_C2Tuple_OffersMessageResponseInstructionZZ_None : Option_C2Tuple_OffersMessageResponseInstructionZZ {
		internal Option_C2Tuple_OffersMessageResponseInstructionZZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_C2Tuple_OffersMessageResponseInstructionZZ containing a crate::c_types::derived::C2Tuple_OffersMessageResponseInstructionZ
	 */
	public static Option_C2Tuple_OffersMessageResponseInstructionZZ some(org.ldk.structs.TwoTuple_OffersMessageResponseInstructionZ o) {
		long ret = bindings.COption_C2Tuple_OffersMessageResponseInstructionZZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_OffersMessageResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_OffersMessageResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_C2Tuple_OffersMessageResponseInstructionZZ containing nothing
	 */
	public static Option_C2Tuple_OffersMessageResponseInstructionZZ none() {
		long ret = bindings.COption_C2Tuple_OffersMessageResponseInstructionZZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_OffersMessageResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_OffersMessageResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_C2Tuple_OffersMessageResponseInstructionZZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_C2Tuple_OffersMessageResponseInstructionZZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_C2Tuple_OffersMessageResponseInstructionZZ clone() {
		long ret = bindings.COption_C2Tuple_OffersMessageResponseInstructionZZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_OffersMessageResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_OffersMessageResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
