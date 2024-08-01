package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::lightning::offers::offer::Quantity or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_QuantityZ extends CommonBase {
	private Option_QuantityZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_QuantityZ_free(ptr); }
	}
	static Option_QuantityZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_QuantityZ raw_val = bindings.LDKCOption_QuantityZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_QuantityZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_QuantityZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_QuantityZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_QuantityZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_QuantityZ contains a crate::lightning::offers::offer::Quantity
	 */
	public final static class Some extends Option_QuantityZ {
		public final org.ldk.structs.Quantity some;
		private Some(long ptr, bindings.LDKCOption_QuantityZ.Some obj) {
			super(null, ptr);
			long some = obj.some;
			org.ldk.structs.Quantity some_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.add(this); };
			this.some = some_hu_conv;
		}
	}
	/**
	 * When we're in this state, this COption_QuantityZ contains nothing
	 */
	public final static class None extends Option_QuantityZ {
		private None(long ptr, bindings.LDKCOption_QuantityZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_QuantityZ containing a crate::lightning::offers::offer::Quantity
	 */
	public static Option_QuantityZ some(org.ldk.structs.Quantity o) {
		long ret = bindings.COption_QuantityZ_some(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_QuantityZ ret_hu_conv = org.ldk.structs.Option_QuantityZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_QuantityZ containing nothing
	 */
	public static Option_QuantityZ none() {
		long ret = bindings.COption_QuantityZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_QuantityZ ret_hu_conv = org.ldk.structs.Option_QuantityZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_QuantityZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_QuantityZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_QuantityZ clone() {
		long ret = bindings.COption_QuantityZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_QuantityZ ret_hu_conv = org.ldk.structs.Option_QuantityZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
