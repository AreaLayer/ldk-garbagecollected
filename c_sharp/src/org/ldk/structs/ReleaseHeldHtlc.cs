using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Releases the HTLC corresponding to an inbound [`HeldHtlcAvailable`] message.
 */
public class ReleaseHeldHtlc : CommonBase {
	internal ReleaseHeldHtlc(object _dummy, long ptr) : base(ptr) { }
	~ReleaseHeldHtlc() {
		if (ptr != 0) { bindings.ReleaseHeldHtlc_free(ptr); }
	}

	/**
	 * Constructs a new ReleaseHeldHtlc given each field
	 */
	public static org.ldk.structs.ReleaseHeldHtlc of() {
		long ret = bindings.ReleaseHeldHtlc_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReleaseHeldHtlc ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ReleaseHeldHtlc_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ReleaseHeldHtlc
	 */
	public org.ldk.structs.ReleaseHeldHtlc clone() {
		long ret = bindings.ReleaseHeldHtlc_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReleaseHeldHtlc ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new OnionMessageContents which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned OnionMessageContents must be freed before this_arg is
	 */
	public org.ldk.structs.OnionMessageContents as_OnionMessageContents() {
		long ret = bindings.ReleaseHeldHtlc_as_OnionMessageContents(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ReleaseHeldHtlc object into a byte array which can be read by ReleaseHeldHtlc_read
	 */
	public byte[] write() {
		long ret = bindings.ReleaseHeldHtlc_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ReleaseHeldHtlc from a byte array, created by ReleaseHeldHtlc_write
	 */
	public static org.ldk.structs.Result_ReleaseHeldHtlcDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ReleaseHeldHtlc_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReleaseHeldHtlcDecodeErrorZ ret_hu_conv = Result_ReleaseHeldHtlcDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
