package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::c_types::ECDSASignature or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_ECDSASignatureZ extends CommonBase {
	private Option_ECDSASignatureZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_ECDSASignatureZ_free(ptr); }
	}
	static Option_ECDSASignatureZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_ECDSASignatureZ raw_val = bindings.LDKCOption_ECDSASignatureZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_ECDSASignatureZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_ECDSASignatureZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_ECDSASignatureZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_ECDSASignatureZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_ECDSASignatureZ contains a crate::c_types::ECDSASignature
	 */
	public final static class Some extends Option_ECDSASignatureZ {
		public final byte[] some;
		private Some(long ptr, bindings.LDKCOption_ECDSASignatureZ.Some obj) {
			super(null, ptr);
			this.some = obj.some;
		}
	}
	/**
	 * When we're in this state, this COption_ECDSASignatureZ contains nothing
	 */
	public final static class None extends Option_ECDSASignatureZ {
		private None(long ptr, bindings.LDKCOption_ECDSASignatureZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_ECDSASignatureZ containing a crate::c_types::ECDSASignature
	 */
	public static Option_ECDSASignatureZ some(byte[] o) {
		long ret = bindings.COption_ECDSASignatureZ_some(InternalUtils.check_arr_len(o, 64));
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ECDSASignatureZ ret_hu_conv = org.ldk.structs.Option_ECDSASignatureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_ECDSASignatureZ containing nothing
	 */
	public static Option_ECDSASignatureZ none() {
		long ret = bindings.COption_ECDSASignatureZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ECDSASignatureZ ret_hu_conv = org.ldk.structs.Option_ECDSASignatureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_ECDSASignatureZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_ECDSASignatureZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_ECDSASignatureZ clone() {
		long ret = bindings.COption_ECDSASignatureZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ECDSASignatureZ ret_hu_conv = org.ldk.structs.Option_ECDSASignatureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
