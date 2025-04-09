using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::derived::C2Tuple_DNSResolverMessageResponseInstructionZ or not
 */
public class Option_C2Tuple_DNSResolverMessageResponseInstructionZZ : CommonBase {
	protected Option_C2Tuple_DNSResolverMessageResponseInstructionZZ(object _dummy, long ptr) : base(ptr) { }
	~Option_C2Tuple_DNSResolverMessageResponseInstructionZZ() {
		if (ptr != 0) { bindings.COption_C2Tuple_DNSResolverMessageResponseInstructionZZ_free(ptr); }
	}

	internal static Option_C2Tuple_DNSResolverMessageResponseInstructionZZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_C2Tuple_DNSResolverMessageResponseInstructionZZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_C2Tuple_DNSResolverMessageResponseInstructionZZ_Some(ptr);
			case 1: return new Option_C2Tuple_DNSResolverMessageResponseInstructionZZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_C2Tuple_DNSResolverMessageResponseInstructionZZ of type Some */
	public class Option_C2Tuple_DNSResolverMessageResponseInstructionZZ_Some : Option_C2Tuple_DNSResolverMessageResponseInstructionZZ {
		public org.ldk.structs.TwoTuple_DNSResolverMessageResponseInstructionZ some;
		internal Option_C2Tuple_DNSResolverMessageResponseInstructionZZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_C2Tuple_DNSResolverMessageResponseInstructionZZ_Some_get_some(ptr);
			TwoTuple_DNSResolverMessageResponseInstructionZ some_hu_conv = new TwoTuple_DNSResolverMessageResponseInstructionZ(null, some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_C2Tuple_DNSResolverMessageResponseInstructionZZ of type None */
	public class Option_C2Tuple_DNSResolverMessageResponseInstructionZZ_None : Option_C2Tuple_DNSResolverMessageResponseInstructionZZ {
		internal Option_C2Tuple_DNSResolverMessageResponseInstructionZZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_C2Tuple_DNSResolverMessageResponseInstructionZZ containing a crate::c_types::derived::C2Tuple_DNSResolverMessageResponseInstructionZ
	 */
	public static org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ some(org.ldk.structs.TwoTuple_DNSResolverMessageResponseInstructionZ o) {
		long ret = bindings.COption_C2Tuple_DNSResolverMessageResponseInstructionZZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_C2Tuple_DNSResolverMessageResponseInstructionZZ containing nothing
	 */
	public static org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ none() {
		long ret = bindings.COption_C2Tuple_DNSResolverMessageResponseInstructionZZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_C2Tuple_DNSResolverMessageResponseInstructionZZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_C2Tuple_DNSResolverMessageResponseInstructionZZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ clone() {
		long ret = bindings.COption_C2Tuple_DNSResolverMessageResponseInstructionZZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_DNSResolverMessageResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
