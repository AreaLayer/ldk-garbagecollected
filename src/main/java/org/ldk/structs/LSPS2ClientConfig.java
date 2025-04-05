package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Client-side configuration options for JIT channels.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2ClientConfig extends CommonBase {
	LSPS2ClientConfig(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2ClientConfig_free(ptr); }
	}

	/**
	 * Constructs a new LSPS2ClientConfig given each field
	 */
	public static LSPS2ClientConfig of() {
		long ret = bindings.LSPS2ClientConfig_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS2ClientConfig_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ClientConfig
	 */
	public LSPS2ClientConfig clone() {
		long ret = bindings.LSPS2ClientConfig_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
