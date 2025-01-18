package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An HTLC destined for the recipient of this message is being held upstream. The reply path
 * accompanying this onion message should be used to send a [`ReleaseHeldHtlc`] response, which
 * will cause the upstream HTLC to be released.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class HeldHtlcAvailable extends CommonBase {
	HeldHtlcAvailable(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.HeldHtlcAvailable_free(ptr); }
	}

	/**
	 * Constructs a new HeldHtlcAvailable given each field
	 */
	public static HeldHtlcAvailable of() {
		long ret = bindings.HeldHtlcAvailable_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HeldHtlcAvailable ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HeldHtlcAvailable(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.HeldHtlcAvailable_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the HeldHtlcAvailable
	 */
	public HeldHtlcAvailable clone() {
		long ret = bindings.HeldHtlcAvailable_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HeldHtlcAvailable ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HeldHtlcAvailable(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the HeldHtlcAvailable object into a byte array which can be read by HeldHtlcAvailable_read
	 */
	public byte[] write() {
		byte[] ret = bindings.HeldHtlcAvailable_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a HeldHtlcAvailable from a byte array, created by HeldHtlcAvailable_write
	 */
	public static Result_HeldHtlcAvailableDecodeErrorZ read(byte[] ser) {
		long ret = bindings.HeldHtlcAvailable_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HeldHtlcAvailableDecodeErrorZ ret_hu_conv = Result_HeldHtlcAvailableDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
