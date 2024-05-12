package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Quantity of items supported by an [`Offer`].
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Quantity extends CommonBase {
	private Quantity(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Quantity_free(ptr); }
	}
	static Quantity constr_from_ptr(long ptr) {
		bindings.LDKQuantity raw_val = bindings.LDKQuantity_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKQuantity.Bounded.class) {
			return new Bounded(ptr, (bindings.LDKQuantity.Bounded)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKQuantity.Unbounded.class) {
			return new Unbounded(ptr, (bindings.LDKQuantity.Unbounded)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKQuantity.One.class) {
			return new One(ptr, (bindings.LDKQuantity.One)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Up to a specific number of items (inclusive). Use when more than one item can be requested
	 * but is limited (e.g., because of per customer or inventory limits).
	 * 
	 * May be used with `NonZeroU64::new(1)` but prefer to use [`Quantity::One`] if only one item
	 * is supported.
	 */
	public final static class Bounded extends Quantity {
		public final long bounded;
		private Bounded(long ptr, bindings.LDKQuantity.Bounded obj) {
			super(null, ptr);
			this.bounded = obj.bounded;
		}
	}
	/**
	 * One or more items. Use when more than one item can be requested without any limit.
	 */
	public final static class Unbounded extends Quantity {
		private Unbounded(long ptr, bindings.LDKQuantity.Unbounded obj) {
			super(null, ptr);
		}
	}
	/**
	 * Only one item. Use when only a single item can be requested.
	 */
	public final static class One extends Quantity {
		private One(long ptr, bindings.LDKQuantity.One obj) {
			super(null, ptr);
		}
	}
	long clone_ptr() {
		long ret = bindings.Quantity_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Quantity
	 */
	public Quantity clone() {
		long ret = bindings.Quantity_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Bounded-variant Quantity
	 */
	public static Quantity bounded(long a) {
		long ret = bindings.Quantity_bounded(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Unbounded-variant Quantity
	 */
	public static Quantity unbounded() {
		long ret = bindings.Quantity_unbounded();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new One-variant Quantity
	 */
	public static Quantity one() {
		long ret = bindings.Quantity_one();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = org.ldk.structs.Quantity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
