package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A request made to an LSP to create an order.
 * 
 * Please refer to the [bLIP-51 / LSPS1
 * specification](https://github.com/lightning/blips/blob/master/blip-0051.md#2-lsps1create_order)
 * for more information.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1CreateOrderRequest extends CommonBase {
	LSPS1CreateOrderRequest(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1CreateOrderRequest_free(ptr); }
	}

	/**
	 * The order made.
	 */
	public LSPS1OrderParams get_order() {
		long ret = bindings.LSPS1CreateOrderRequest_get_order(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The order made.
	 */
	public void set_order(org.ldk.structs.LSPS1OrderParams val) {
		bindings.LSPS1CreateOrderRequest_set_order(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The address where the LSP will send the funds if the order fails.
	 */
	public Option_AddressZ get_refund_onchain_address() {
		long ret = bindings.LSPS1CreateOrderRequest_get_refund_onchain_address(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AddressZ ret_hu_conv = org.ldk.structs.Option_AddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The address where the LSP will send the funds if the order fails.
	 */
	public void set_refund_onchain_address(org.ldk.structs.Option_AddressZ val) {
		bindings.LSPS1CreateOrderRequest_set_refund_onchain_address(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
		if (this != null) { this.ptrs_to.add(val); };
	}

	/**
	 * Constructs a new LSPS1CreateOrderRequest given each field
	 */
	public static LSPS1CreateOrderRequest of(org.ldk.structs.LSPS1OrderParams order_arg, org.ldk.structs.Option_AddressZ refund_onchain_address_arg) {
		long ret = bindings.LSPS1CreateOrderRequest_new(order_arg.ptr, refund_onchain_address_arg.ptr);
		Reference.reachabilityFence(order_arg);
		Reference.reachabilityFence(refund_onchain_address_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1CreateOrderRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1CreateOrderRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(refund_onchain_address_arg); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1CreateOrderRequest_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1CreateOrderRequest
	 */
	public LSPS1CreateOrderRequest clone() {
		long ret = bindings.LSPS1CreateOrderRequest_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1CreateOrderRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1CreateOrderRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1CreateOrderRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1CreateOrderRequest b) {
		boolean ret = bindings.LSPS1CreateOrderRequest_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1CreateOrderRequest)) return false;
		return this.eq((LSPS1CreateOrderRequest)o);
	}
}
