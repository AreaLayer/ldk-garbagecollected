package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Releases the HTLC corresponding to an inbound [`HeldHtlcAvailable`] message.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ReleaseHeldHtlc extends CommonBase {
	ReleaseHeldHtlc(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ReleaseHeldHtlc_free(ptr); }
	}

	/**
	 * Used to release the HTLC held upstream if it matches the corresponding
	 * [`HeldHtlcAvailable::payment_release_secret`].
	 */
	public byte[] get_payment_release_secret() {
		byte[] ret = bindings.ReleaseHeldHtlc_get_payment_release_secret(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Used to release the HTLC held upstream if it matches the corresponding
	 * [`HeldHtlcAvailable::payment_release_secret`].
	 */
	public void set_payment_release_secret(byte[] val) {
		bindings.ReleaseHeldHtlc_set_payment_release_secret(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new ReleaseHeldHtlc given each field
	 */
	public static ReleaseHeldHtlc of(byte[] payment_release_secret_arg) {
		long ret = bindings.ReleaseHeldHtlc_new(InternalUtils.check_arr_len(payment_release_secret_arg, 32));
		Reference.reachabilityFence(payment_release_secret_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReleaseHeldHtlc ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.ReleaseHeldHtlc_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ReleaseHeldHtlc
	 */
	public ReleaseHeldHtlc clone() {
		long ret = bindings.ReleaseHeldHtlc_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReleaseHeldHtlc ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new OnionMessageContents which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned OnionMessageContents must be freed before this_arg is
	 */
	public OnionMessageContents as_OnionMessageContents() {
		long ret = bindings.ReleaseHeldHtlc_as_OnionMessageContents(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ReleaseHeldHtlc object into a byte array which can be read by ReleaseHeldHtlc_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ReleaseHeldHtlc_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a ReleaseHeldHtlc from a byte array, created by ReleaseHeldHtlc_write
	 */
	public static Result_ReleaseHeldHtlcDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ReleaseHeldHtlc_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReleaseHeldHtlcDecodeErrorZ ret_hu_conv = Result_ReleaseHeldHtlcDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
