package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Client-side configuration options for bLIP-51 / LSPS1 channel requests.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1ClientConfig extends CommonBase {
	LSPS1ClientConfig(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1ClientConfig_free(ptr); }
	}

	/**
	 * The maximally allowed channel fees.
	 */
	public Option_u64Z get_max_channel_fees_msat() {
		long ret = bindings.LSPS1ClientConfig_get_max_channel_fees_msat(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The maximally allowed channel fees.
	 */
	public void set_max_channel_fees_msat(org.ldk.structs.Option_u64Z val) {
		bindings.LSPS1ClientConfig_set_max_channel_fees_msat(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1ClientConfig given each field
	 */
	public static LSPS1ClientConfig of(org.ldk.structs.Option_u64Z max_channel_fees_msat_arg) {
		long ret = bindings.LSPS1ClientConfig_new(max_channel_fees_msat_arg.ptr);
		Reference.reachabilityFence(max_channel_fees_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1ClientConfig_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1ClientConfig
	 */
	public LSPS1ClientConfig clone() {
		long ret = bindings.LSPS1ClientConfig_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ClientConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
