package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::lightning::ln::channel_state::OutboundHTLCStateDetails or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_OutboundHTLCStateDetailsZ extends CommonBase {
	private Option_OutboundHTLCStateDetailsZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_OutboundHTLCStateDetailsZ_free(ptr); }
	}
	static Option_OutboundHTLCStateDetailsZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_OutboundHTLCStateDetailsZ raw_val = bindings.LDKCOption_OutboundHTLCStateDetailsZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_OutboundHTLCStateDetailsZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_OutboundHTLCStateDetailsZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_OutboundHTLCStateDetailsZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_OutboundHTLCStateDetailsZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_OutboundHTLCStateDetailsZ contains a crate::lightning::ln::channel_state::OutboundHTLCStateDetails
	 */
	public final static class Some extends Option_OutboundHTLCStateDetailsZ {
		public final org.ldk.enums.OutboundHTLCStateDetails some;
		private Some(long ptr, bindings.LDKCOption_OutboundHTLCStateDetailsZ.Some obj) {
			super(null, ptr);
			this.some = obj.some;
		}
	}
	/**
	 * When we're in this state, this COption_OutboundHTLCStateDetailsZ contains nothing
	 */
	public final static class None extends Option_OutboundHTLCStateDetailsZ {
		private None(long ptr, bindings.LDKCOption_OutboundHTLCStateDetailsZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_OutboundHTLCStateDetailsZ containing a crate::lightning::ln::channel_state::OutboundHTLCStateDetails
	 */
	public static Option_OutboundHTLCStateDetailsZ some(org.ldk.enums.OutboundHTLCStateDetails o) {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_some(o);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OutboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_OutboundHTLCStateDetailsZ containing nothing
	 */
	public static Option_OutboundHTLCStateDetailsZ none() {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OutboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_OutboundHTLCStateDetailsZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_OutboundHTLCStateDetailsZ clone() {
		long ret = bindings.COption_OutboundHTLCStateDetailsZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OutboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
