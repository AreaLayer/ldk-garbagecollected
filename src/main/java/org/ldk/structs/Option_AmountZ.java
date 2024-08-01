package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::lightning::offers::offer::Amount or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_AmountZ extends CommonBase {
	private Option_AmountZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_AmountZ_free(ptr); }
	}
	static Option_AmountZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_AmountZ raw_val = bindings.LDKCOption_AmountZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_AmountZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_AmountZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_AmountZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_AmountZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_AmountZ contains a crate::lightning::offers::offer::Amount
	 */
	public final static class Some extends Option_AmountZ {
		public final org.ldk.structs.Amount some;
		private Some(long ptr, bindings.LDKCOption_AmountZ.Some obj) {
			super(null, ptr);
			long some = obj.some;
			org.ldk.structs.Amount some_hu_conv = org.ldk.structs.Amount.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.add(this); };
			this.some = some_hu_conv;
		}
	}
	/**
	 * When we're in this state, this COption_AmountZ contains nothing
	 */
	public final static class None extends Option_AmountZ {
		private None(long ptr, bindings.LDKCOption_AmountZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_AmountZ containing a crate::lightning::offers::offer::Amount
	 */
	public static Option_AmountZ some(org.ldk.structs.Amount o) {
		long ret = bindings.COption_AmountZ_some(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AmountZ ret_hu_conv = org.ldk.structs.Option_AmountZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_AmountZ containing nothing
	 */
	public static Option_AmountZ none() {
		long ret = bindings.COption_AmountZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AmountZ ret_hu_conv = org.ldk.structs.Option_AmountZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_AmountZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_AmountZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_AmountZ clone() {
		long ret = bindings.COption_AmountZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AmountZ ret_hu_conv = org.ldk.structs.Option_AmountZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
