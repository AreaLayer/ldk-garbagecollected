using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Data to construct a [`BlindedHop`] for receiving a payment. This payload is custom to LDK and
 * may not be valid if received by another lightning implementation.
 * 
 * Can only be constructed by calling [`UnauthenticatedReceiveTlvs::authenticate`].
 */
public class ReceiveTlvs : CommonBase {
	internal ReceiveTlvs(object _dummy, long ptr) : base(ptr) { }
	~ReceiveTlvs() {
		if (ptr != 0) { bindings.ReceiveTlvs_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.ReceiveTlvs_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ReceiveTlvs
	 */
	public ReceiveTlvs clone() {
		long ret = bindings.ReceiveTlvs_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns the underlying TLVs.
	 */
	public UnauthenticatedReceiveTlvs tlvs() {
		long ret = bindings.ReceiveTlvs_tlvs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnauthenticatedReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnauthenticatedReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ReceiveTlvs object into a byte array which can be read by ReceiveTlvs_read
	 */
	public byte[] write() {
		long ret = bindings.ReceiveTlvs_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
