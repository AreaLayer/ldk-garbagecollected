package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::lightning::ln::channel_state::InboundHTLCStateDetails or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_InboundHTLCStateDetailsZ extends CommonBase {
	private Option_InboundHTLCStateDetailsZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_InboundHTLCStateDetailsZ_free(ptr); }
	}
	static Option_InboundHTLCStateDetailsZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_InboundHTLCStateDetailsZ raw_val = bindings.LDKCOption_InboundHTLCStateDetailsZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_InboundHTLCStateDetailsZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_InboundHTLCStateDetailsZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_InboundHTLCStateDetailsZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_InboundHTLCStateDetailsZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_InboundHTLCStateDetailsZ contains a crate::lightning::ln::channel_state::InboundHTLCStateDetails
	 */
	public final static class Some extends Option_InboundHTLCStateDetailsZ {
		public final org.ldk.enums.InboundHTLCStateDetails some;
		private Some(long ptr, bindings.LDKCOption_InboundHTLCStateDetailsZ.Some obj) {
			super(null, ptr);
			this.some = obj.some;
		}
	}
	/**
	 * When we're in this state, this COption_InboundHTLCStateDetailsZ contains nothing
	 */
	public final static class None extends Option_InboundHTLCStateDetailsZ {
		private None(long ptr, bindings.LDKCOption_InboundHTLCStateDetailsZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_InboundHTLCStateDetailsZ containing a crate::lightning::ln::channel_state::InboundHTLCStateDetails
	 */
	public static Option_InboundHTLCStateDetailsZ some(org.ldk.enums.InboundHTLCStateDetails o) {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_some(o);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_InboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_InboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_InboundHTLCStateDetailsZ containing nothing
	 */
	public static Option_InboundHTLCStateDetailsZ none() {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_InboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_InboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_InboundHTLCStateDetailsZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_InboundHTLCStateDetailsZ clone() {
		long ret = bindings.COption_InboundHTLCStateDetailsZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_InboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_InboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
