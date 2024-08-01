package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::lightning::routing::gossip::NodeAnnouncementInfo or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_NodeAnnouncementInfoZ extends CommonBase {
	private Option_NodeAnnouncementInfoZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_NodeAnnouncementInfoZ_free(ptr); }
	}
	static Option_NodeAnnouncementInfoZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_NodeAnnouncementInfoZ raw_val = bindings.LDKCOption_NodeAnnouncementInfoZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_NodeAnnouncementInfoZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_NodeAnnouncementInfoZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_NodeAnnouncementInfoZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_NodeAnnouncementInfoZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_NodeAnnouncementInfoZ contains a crate::lightning::routing::gossip::NodeAnnouncementInfo
	 */
	public final static class Some extends Option_NodeAnnouncementInfoZ {
		public final org.ldk.structs.NodeAnnouncementInfo some;
		private Some(long ptr, bindings.LDKCOption_NodeAnnouncementInfoZ.Some obj) {
			super(null, ptr);
			long some = obj.some;
			org.ldk.structs.NodeAnnouncementInfo some_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.add(this); };
			this.some = some_hu_conv;
		}
	}
	/**
	 * When we're in this state, this COption_NodeAnnouncementInfoZ contains nothing
	 */
	public final static class None extends Option_NodeAnnouncementInfoZ {
		private None(long ptr, bindings.LDKCOption_NodeAnnouncementInfoZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_NodeAnnouncementInfoZ containing a crate::lightning::routing::gossip::NodeAnnouncementInfo
	 */
	public static Option_NodeAnnouncementInfoZ some(org.ldk.structs.NodeAnnouncementInfo o) {
		long ret = bindings.COption_NodeAnnouncementInfoZ_some(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_NodeAnnouncementInfoZ ret_hu_conv = org.ldk.structs.Option_NodeAnnouncementInfoZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_NodeAnnouncementInfoZ containing nothing
	 */
	public static Option_NodeAnnouncementInfoZ none() {
		long ret = bindings.COption_NodeAnnouncementInfoZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_NodeAnnouncementInfoZ ret_hu_conv = org.ldk.structs.Option_NodeAnnouncementInfoZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.COption_NodeAnnouncementInfoZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new COption_NodeAnnouncementInfoZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_NodeAnnouncementInfoZ clone() {
		long ret = bindings.COption_NodeAnnouncementInfoZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_NodeAnnouncementInfoZ ret_hu_conv = org.ldk.structs.Option_NodeAnnouncementInfoZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
