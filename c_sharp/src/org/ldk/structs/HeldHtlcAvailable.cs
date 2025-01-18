using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An HTLC destined for the recipient of this message is being held upstream. The reply path
 * accompanying this onion message should be used to send a [`ReleaseHeldHtlc`] response, which
 * will cause the upstream HTLC to be released.
 */
public class HeldHtlcAvailable : CommonBase {
	internal HeldHtlcAvailable(object _dummy, long ptr) : base(ptr) { }
	~HeldHtlcAvailable() {
		if (ptr != 0) { bindings.HeldHtlcAvailable_free(ptr); }
	}

	/**
	 * Constructs a new HeldHtlcAvailable given each field
	 */
	public static HeldHtlcAvailable of() {
		long ret = bindings.HeldHtlcAvailable_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HeldHtlcAvailable ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HeldHtlcAvailable(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.HeldHtlcAvailable_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the HeldHtlcAvailable
	 */
	public HeldHtlcAvailable clone() {
		long ret = bindings.HeldHtlcAvailable_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HeldHtlcAvailable ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HeldHtlcAvailable(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the HeldHtlcAvailable object into a byte array which can be read by HeldHtlcAvailable_read
	 */
	public byte[] write() {
		long ret = bindings.HeldHtlcAvailable_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a HeldHtlcAvailable from a byte array, created by HeldHtlcAvailable_write
	 */
	public static Result_HeldHtlcAvailableDecodeErrorZ read(byte[] ser) {
		long ret = bindings.HeldHtlcAvailable_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HeldHtlcAvailableDecodeErrorZ ret_hu_conv = Result_HeldHtlcAvailableDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
