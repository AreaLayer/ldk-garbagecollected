using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Client-side configuration options for bLIP-51 / LSPS1 channel requests.
 */
public class LSPS1ClientConfig : CommonBase {
	internal LSPS1ClientConfig(object _dummy, long ptr) : base(ptr) { }
	~LSPS1ClientConfig() {
		if (ptr != 0) { bindings.LSPS1ClientConfig_free(ptr); }
	}

	/**
	 * The maximally allowed channel fees.
	 */
	public org.ldk.structs.Option_u64Z get_max_channel_fees_msat() {
		long ret = bindings.LSPS1ClientConfig_get_max_channel_fees_msat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The maximally allowed channel fees.
	 */
	public void set_max_channel_fees_msat(org.ldk.structs.Option_u64Z val) {
		bindings.LSPS1ClientConfig_set_max_channel_fees_msat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1ClientConfig given each field
	 */
	public static org.ldk.structs.LSPS1ClientConfig of(org.ldk.structs.Option_u64Z max_channel_fees_msat_arg) {
		long ret = bindings.LSPS1ClientConfig_new(max_channel_fees_msat_arg.ptr);
		GC.KeepAlive(max_channel_fees_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1ClientConfig_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1ClientConfig
	 */
	public org.ldk.structs.LSPS1ClientConfig clone() {
		long ret = bindings.LSPS1ClientConfig_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
