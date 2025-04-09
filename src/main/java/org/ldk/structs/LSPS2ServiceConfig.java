package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Server-side configuration options for JIT channels.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2ServiceConfig extends CommonBase {
	LSPS2ServiceConfig(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2ServiceConfig_free(ptr); }
	}

	/**
	 * Used to calculate the promise for channel parameters supplied to clients.
	 * 
	 * Note: If this changes then old promises given out will be considered invalid.
	 */
	public byte[] get_promise_secret() {
		byte[] ret = bindings.LSPS2ServiceConfig_get_promise_secret(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Used to calculate the promise for channel parameters supplied to clients.
	 * 
	 * Note: If this changes then old promises given out will be considered invalid.
	 */
	public void set_promise_secret(byte[] val) {
		bindings.LSPS2ServiceConfig_set_promise_secret(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS2ServiceConfig given each field
	 */
	public static LSPS2ServiceConfig of(byte[] promise_secret_arg) {
		long ret = bindings.LSPS2ServiceConfig_new(InternalUtils.check_arr_len(promise_secret_arg, 32));
		Reference.reachabilityFence(promise_secret_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ServiceConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS2ServiceConfig_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ServiceConfig
	 */
	public LSPS2ServiceConfig clone() {
		long ret = bindings.LSPS2ServiceConfig_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ServiceConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
