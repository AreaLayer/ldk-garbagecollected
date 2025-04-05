using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A request made to an LSP to retrieve information about an previously made order.
 * 
 * Please refer to the [bLIP-51 / LSPS1
 * specification](https://github.com/lightning/blips/blob/master/blip-0051.md#21-lsps1get_order)
 * for more information.
 */
public class LSPS1GetOrderRequest : CommonBase {
	internal LSPS1GetOrderRequest(object _dummy, long ptr) : base(ptr) { }
	~LSPS1GetOrderRequest() {
		if (ptr != 0) { bindings.LSPS1GetOrderRequest_free(ptr); }
	}

	/**
	 * The id of the order.
	 */
	public org.ldk.structs.LSPS1OrderId get_order_id() {
		long ret = bindings.LSPS1GetOrderRequest_get_order_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The id of the order.
	 */
	public void set_order_id(org.ldk.structs.LSPS1OrderId val) {
		bindings.LSPS1GetOrderRequest_set_order_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1GetOrderRequest given each field
	 */
	public static org.ldk.structs.LSPS1GetOrderRequest of(org.ldk.structs.LSPS1OrderId order_id_arg) {
		long ret = bindings.LSPS1GetOrderRequest_new(order_id_arg.ptr);
		GC.KeepAlive(order_id_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetOrderRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetOrderRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1GetOrderRequest_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1GetOrderRequest
	 */
	public org.ldk.structs.LSPS1GetOrderRequest clone() {
		long ret = bindings.LSPS1GetOrderRequest_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetOrderRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetOrderRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1GetOrderRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1GetOrderRequest b) {
		bool ret = bindings.LSPS1GetOrderRequest_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1GetOrderRequest)) return false;
		return this.eq((LSPS1GetOrderRequest)o);
	}
}
} } }
