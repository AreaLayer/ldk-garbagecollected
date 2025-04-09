using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::ECDSASignature or not
 */
public class Option_ECDSASignatureZ : CommonBase {
	protected Option_ECDSASignatureZ(object _dummy, long ptr) : base(ptr) { }
	~Option_ECDSASignatureZ() {
		if (ptr != 0) { bindings.COption_ECDSASignatureZ_free(ptr); }
	}

	internal static Option_ECDSASignatureZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_ECDSASignatureZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_ECDSASignatureZ_Some(ptr);
			case 1: return new Option_ECDSASignatureZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_ECDSASignatureZ of type Some */
	public class Option_ECDSASignatureZ_Some : Option_ECDSASignatureZ {
		public byte[] some;
		internal Option_ECDSASignatureZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_ECDSASignatureZ_Some_get_some(ptr);
			byte[] some_conv = InternalUtils.decodeUint8Array(some);
			this.some = some_conv;
		}
	}
	/** A Option_ECDSASignatureZ of type None */
	public class Option_ECDSASignatureZ_None : Option_ECDSASignatureZ {
		internal Option_ECDSASignatureZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_ECDSASignatureZ containing a crate::c_types::ECDSASignature
	 */
	public static org.ldk.structs.Option_ECDSASignatureZ some(byte[] o) {
		long ret = bindings.COption_ECDSASignatureZ_some(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(o, 64)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ECDSASignatureZ ret_hu_conv = org.ldk.structs.Option_ECDSASignatureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_ECDSASignatureZ containing nothing
	 */
	public static org.ldk.structs.Option_ECDSASignatureZ none() {
		long ret = bindings.COption_ECDSASignatureZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ECDSASignatureZ ret_hu_conv = org.ldk.structs.Option_ECDSASignatureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_ECDSASignatureZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_ECDSASignatureZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Option_ECDSASignatureZ clone() {
		long ret = bindings.COption_ECDSASignatureZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ECDSASignatureZ ret_hu_conv = org.ldk.structs.Option_ECDSASignatureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
