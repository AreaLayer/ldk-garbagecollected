package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Data to construct a [`BlindedHop`] for receiving a payment. This payload is custom to LDK and
 * may not be valid if received by another lightning implementation.
 * 
 * Can only be constructed by calling [`UnauthenticatedReceiveTlvs::authenticate`].
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ReceiveTlvs extends CommonBase {
	ReceiveTlvs(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ReceiveTlvs_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.ReceiveTlvs_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ReceiveTlvs
	 */
	public ReceiveTlvs clone() {
		long ret = bindings.ReceiveTlvs_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns the underlying TLVs.
	 */
	public UnauthenticatedReceiveTlvs tlvs() {
		long ret = bindings.ReceiveTlvs_tlvs(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnauthenticatedReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnauthenticatedReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ReceiveTlvs object into a byte array which can be read by ReceiveTlvs_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ReceiveTlvs_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
