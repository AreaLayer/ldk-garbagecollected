using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Client-side configuration options for JIT channels.
 */
public class LSPS2ClientConfig : CommonBase {
	internal LSPS2ClientConfig(object _dummy, long ptr) : base(ptr) { }
	~LSPS2ClientConfig() {
		if (ptr != 0) { bindings.LSPS2ClientConfig_free(ptr); }
	}

	/**
	 * Constructs a new LSPS2ClientConfig given each field
	 */
	public static org.ldk.structs.LSPS2ClientConfig of() {
		long ret = bindings.LSPS2ClientConfig_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2ClientConfig_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ClientConfig
	 */
	public org.ldk.structs.LSPS2ClientConfig clone() {
		long ret = bindings.LSPS2ClientConfig_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
