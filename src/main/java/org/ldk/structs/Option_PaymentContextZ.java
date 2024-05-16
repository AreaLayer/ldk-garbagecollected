package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::lightning::blinded_path::payment::PaymentContext or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_PaymentContextZ extends CommonBase {
	private Option_PaymentContextZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_PaymentContextZ_free(ptr); }
	}
	static Option_PaymentContextZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_PaymentContextZ raw_val = bindings.LDKCOption_PaymentContextZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_PaymentContextZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_PaymentContextZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_PaymentContextZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_PaymentContextZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_PaymentContextZ contains a crate::lightning::blinded_path::payment::PaymentContext
	 */
	public final static class Some extends Option_PaymentContextZ {
		public final org.ldk.structs.PaymentContext some;
		private Some(long ptr, bindings.LDKCOption_PaymentContextZ.Some obj) {
			super(null, ptr);
			long some = obj.some;
			org.ldk.structs.PaymentContext some_hu_conv = org.ldk.structs.PaymentContext.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.add(this); };
			this.some = some_hu_conv;
		}
	}
	/**
	 * When we're in this state, this COption_PaymentContextZ contains nothing
	 */
	public final static class None extends Option_PaymentContextZ {
		private None(long ptr, bindings.LDKCOption_PaymentContextZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_PaymentContextZ containing a crate::lightning::blinded_path::payment::PaymentContext
	 */
	public static Option_PaymentContextZ some(org.ldk.structs.PaymentContext o) {
		long ret = bindings.COption_PaymentContextZ_some(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentContextZ ret_hu_conv = org.ldk.structs.Option_PaymentContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_PaymentContextZ containing nothing
	 */
	public static Option_PaymentContextZ none() {
		long ret = bindings.COption_PaymentContextZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentContextZ ret_hu_conv = org.ldk.structs.Option_PaymentContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_PaymentContextZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_PaymentContextZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_PaymentContextZ clone() {
		long ret = bindings.COption_PaymentContextZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentContextZ ret_hu_conv = org.ldk.structs.Option_PaymentContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
