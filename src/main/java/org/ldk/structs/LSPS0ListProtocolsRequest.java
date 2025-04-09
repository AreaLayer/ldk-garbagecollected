package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A `list_protocols` request.
 * 
 * Please refer to the [bLIP-50 / LSPS0
 * specification](https://github.com/lightning/blips/blob/master/blip-0050.md#lsps-specification-support-query)
 * for more information.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS0ListProtocolsRequest extends CommonBase {
	LSPS0ListProtocolsRequest(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS0ListProtocolsRequest_free(ptr); }
	}

	/**
	 * Constructs a new LSPS0ListProtocolsRequest given each field
	 */
	public static LSPS0ListProtocolsRequest of() {
		long ret = bindings.LSPS0ListProtocolsRequest_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ListProtocolsRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS0ListProtocolsRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS0ListProtocolsRequest_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0ListProtocolsRequest
	 */
	public LSPS0ListProtocolsRequest clone() {
		long ret = bindings.LSPS0ListProtocolsRequest_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ListProtocolsRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS0ListProtocolsRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0ListProtocolsRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS0ListProtocolsRequest b) {
		boolean ret = bindings.LSPS0ListProtocolsRequest_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS0ListProtocolsRequest)) return false;
		return this.eq((LSPS0ListProtocolsRequest)o);
	}
}
