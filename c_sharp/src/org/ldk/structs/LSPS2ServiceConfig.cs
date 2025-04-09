using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Server-side configuration options for JIT channels.
 */
public class LSPS2ServiceConfig : CommonBase {
	internal LSPS2ServiceConfig(object _dummy, long ptr) : base(ptr) { }
	~LSPS2ServiceConfig() {
		if (ptr != 0) { bindings.LSPS2ServiceConfig_free(ptr); }
	}

	/**
	 * Used to calculate the promise for channel parameters supplied to clients.
	 * 
	 * Note: If this changes then old promises given out will be considered invalid.
	 */
	public byte[] get_promise_secret() {
		long ret = bindings.LSPS2ServiceConfig_get_promise_secret(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Used to calculate the promise for channel parameters supplied to clients.
	 * 
	 * Note: If this changes then old promises given out will be considered invalid.
	 */
	public void set_promise_secret(byte[] val) {
		bindings.LSPS2ServiceConfig_set_promise_secret(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS2ServiceConfig given each field
	 */
	public static org.ldk.structs.LSPS2ServiceConfig of(byte[] promise_secret_arg) {
		long ret = bindings.LSPS2ServiceConfig_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(promise_secret_arg, 32)));
		GC.KeepAlive(promise_secret_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ServiceConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2ServiceConfig_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ServiceConfig
	 */
	public org.ldk.structs.LSPS2ServiceConfig clone() {
		long ret = bindings.LSPS2ServiceConfig_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2ServiceConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
