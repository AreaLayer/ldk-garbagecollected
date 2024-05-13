using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Error when signing messages.
 */
public class SignError : CommonBase {
	protected SignError(object _dummy, long ptr) : base(ptr) { }
	~SignError() {
		if (ptr != 0) { bindings.SignError_free(ptr); }
	}

	internal static SignError constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKSignError_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new SignError_Signing(ptr);
			case 1: return new SignError_Verification(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A SignError of type Signing */
	public class SignError_Signing : SignError {
		internal SignError_Signing(long ptr) : base(null, ptr) {
		}
	}
	/** A SignError of type Verification */
	public class SignError_Verification : SignError {
		public Secp256k1Error verification;
		internal SignError_Verification(long ptr) : base(null, ptr) {
			this.verification = bindings.LDKSignError_Verification_get_verification(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = bindings.SignError_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the SignError
	 */
	public SignError clone() {
		long ret = bindings.SignError_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignError ret_hu_conv = org.ldk.structs.SignError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Signing-variant SignError
	 */
	public static SignError signing() {
		long ret = bindings.SignError_signing();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignError ret_hu_conv = org.ldk.structs.SignError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Verification-variant SignError
	 */
	public static SignError verification(Secp256k1Error a) {
		long ret = bindings.SignError_verification(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignError ret_hu_conv = org.ldk.structs.SignError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
