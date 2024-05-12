package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Error when signing messages.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class SignError extends CommonBase {
	private SignError(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.SignError_free(ptr); }
	}
	static SignError constr_from_ptr(long ptr) {
		bindings.LDKSignError raw_val = bindings.LDKSignError_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKSignError.Signing.class) {
			return new Signing(ptr, (bindings.LDKSignError.Signing)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSignError.Verification.class) {
			return new Verification(ptr, (bindings.LDKSignError.Verification)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * User-defined error when signing the message.
	 */
	public final static class Signing extends SignError {
		private Signing(long ptr, bindings.LDKSignError.Signing obj) {
			super(null, ptr);
		}
	}
	/**
	 * Error when verifying the produced signature using the given pubkey.
	 */
	public final static class Verification extends SignError {
		public final org.ldk.enums.Secp256k1Error verification;
		private Verification(long ptr, bindings.LDKSignError.Verification obj) {
			super(null, ptr);
			this.verification = obj.verification;
		}
	}
	long clone_ptr() {
		long ret = bindings.SignError_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the SignError
	 */
	public SignError clone() {
		long ret = bindings.SignError_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignError ret_hu_conv = org.ldk.structs.SignError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Signing-variant SignError
	 */
	public static SignError signing() {
		long ret = bindings.SignError_signing();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignError ret_hu_conv = org.ldk.structs.SignError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Verification-variant SignError
	 */
	public static SignError verification(org.ldk.enums.Secp256k1Error a) {
		long ret = bindings.SignError_verification(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignError ret_hu_conv = org.ldk.structs.SignError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
