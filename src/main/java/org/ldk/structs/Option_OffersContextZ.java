package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::lightning::blinded_path::message::OffersContext or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_OffersContextZ extends CommonBase {
	private Option_OffersContextZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_OffersContextZ_free(ptr); }
	}
	static Option_OffersContextZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_OffersContextZ raw_val = bindings.LDKCOption_OffersContextZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_OffersContextZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_OffersContextZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_OffersContextZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_OffersContextZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_OffersContextZ contains a crate::lightning::blinded_path::message::OffersContext
	 */
	public final static class Some extends Option_OffersContextZ {
		public final org.ldk.structs.OffersContext some;
		private Some(long ptr, bindings.LDKCOption_OffersContextZ.Some obj) {
			super(null, ptr);
			long some = obj.some;
			org.ldk.structs.OffersContext some_hu_conv = org.ldk.structs.OffersContext.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.add(this); };
			this.some = some_hu_conv;
		}
	}
	/**
	 * When we're in this state, this COption_OffersContextZ contains nothing
	 */
	public final static class None extends Option_OffersContextZ {
		private None(long ptr, bindings.LDKCOption_OffersContextZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_OffersContextZ containing a crate::lightning::blinded_path::message::OffersContext
	 */
	public static Option_OffersContextZ some(org.ldk.structs.OffersContext o) {
		long ret = bindings.COption_OffersContextZ_some(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OffersContextZ ret_hu_conv = org.ldk.structs.Option_OffersContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_OffersContextZ containing nothing
	 */
	public static Option_OffersContextZ none() {
		long ret = bindings.COption_OffersContextZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OffersContextZ ret_hu_conv = org.ldk.structs.Option_OffersContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_OffersContextZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_OffersContextZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_OffersContextZ clone() {
		long ret = bindings.COption_OffersContextZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OffersContextZ ret_hu_conv = org.ldk.structs.Option_OffersContextZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
