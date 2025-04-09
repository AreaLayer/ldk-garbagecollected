using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::routing::gossip::NodeAnnouncementInfo or not
 */
public class Option_NodeAnnouncementInfoZ : CommonBase {
	protected Option_NodeAnnouncementInfoZ(object _dummy, long ptr) : base(ptr) { }
	~Option_NodeAnnouncementInfoZ() {
		if (ptr != 0) { bindings.COption_NodeAnnouncementInfoZ_free(ptr); }
	}

	internal static Option_NodeAnnouncementInfoZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_NodeAnnouncementInfoZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_NodeAnnouncementInfoZ_Some(ptr);
			case 1: return new Option_NodeAnnouncementInfoZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_NodeAnnouncementInfoZ of type Some */
	public class Option_NodeAnnouncementInfoZ_Some : Option_NodeAnnouncementInfoZ {
		public org.ldk.structs.NodeAnnouncementInfo some;
		internal Option_NodeAnnouncementInfoZ_Some(long ptr) : base(null, ptr) {
			long some = bindings.LDKCOption_NodeAnnouncementInfoZ_Some_get_some(ptr);
			org.ldk.structs.NodeAnnouncementInfo some_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_NodeAnnouncementInfoZ of type None */
	public class Option_NodeAnnouncementInfoZ_None : Option_NodeAnnouncementInfoZ {
		internal Option_NodeAnnouncementInfoZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_NodeAnnouncementInfoZ containing a crate::lightning::routing::gossip::NodeAnnouncementInfo
	 */
	public static org.ldk.structs.Option_NodeAnnouncementInfoZ some(org.ldk.structs.NodeAnnouncementInfo o) {
		long ret = bindings.COption_NodeAnnouncementInfoZ_some(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_NodeAnnouncementInfoZ ret_hu_conv = org.ldk.structs.Option_NodeAnnouncementInfoZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_NodeAnnouncementInfoZ containing nothing
	 */
	public static org.ldk.structs.Option_NodeAnnouncementInfoZ none() {
		long ret = bindings.COption_NodeAnnouncementInfoZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_NodeAnnouncementInfoZ ret_hu_conv = org.ldk.structs.Option_NodeAnnouncementInfoZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_NodeAnnouncementInfoZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_NodeAnnouncementInfoZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Option_NodeAnnouncementInfoZ clone() {
		long ret = bindings.COption_NodeAnnouncementInfoZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_NodeAnnouncementInfoZ ret_hu_conv = org.ldk.structs.Option_NodeAnnouncementInfoZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
