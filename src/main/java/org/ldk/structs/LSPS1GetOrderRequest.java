package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A request made to an LSP to retrieve information about an previously made order.
 * 
 * Please refer to the [bLIP-51 / LSPS1
 * specification](https://github.com/lightning/blips/blob/master/blip-0051.md#21-lsps1get_order)
 * for more information.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1GetOrderRequest extends CommonBase {
	LSPS1GetOrderRequest(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1GetOrderRequest_free(ptr); }
	}

	/**
	 * The id of the order.
	 */
	public LSPS1OrderId get_order_id() {
		long ret = bindings.LSPS1GetOrderRequest_get_order_id(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The id of the order.
	 */
	public void set_order_id(org.ldk.structs.LSPS1OrderId val) {
		bindings.LSPS1GetOrderRequest_set_order_id(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1GetOrderRequest given each field
	 */
	public static LSPS1GetOrderRequest of(org.ldk.structs.LSPS1OrderId order_id_arg) {
		long ret = bindings.LSPS1GetOrderRequest_new(order_id_arg.ptr);
		Reference.reachabilityFence(order_id_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetOrderRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetOrderRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1GetOrderRequest_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1GetOrderRequest
	 */
	public LSPS1GetOrderRequest clone() {
		long ret = bindings.LSPS1GetOrderRequest_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetOrderRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetOrderRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1GetOrderRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1GetOrderRequest b) {
		boolean ret = bindings.LSPS1GetOrderRequest_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1GetOrderRequest)) return false;
		return this.eq((LSPS1GetOrderRequest)o);
	}
}
