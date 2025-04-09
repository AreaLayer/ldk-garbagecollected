using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A response to a [`LSPS1CreateOrderRequest`].
 */
public class LSPS1CreateOrderResponse : CommonBase {
	internal LSPS1CreateOrderResponse(object _dummy, long ptr) : base(ptr) { }
	~LSPS1CreateOrderResponse() {
		if (ptr != 0) { bindings.LSPS1CreateOrderResponse_free(ptr); }
	}

	/**
	 * The id of the channel order.
	 */
	public org.ldk.structs.LSPS1OrderId get_order_id() {
		long ret = bindings.LSPS1CreateOrderResponse_get_order_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The id of the channel order.
	 */
	public void set_order_id(org.ldk.structs.LSPS1OrderId val) {
		bindings.LSPS1CreateOrderResponse_set_order_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The parameters of channel order.
	 */
	public org.ldk.structs.LSPS1OrderParams get_order() {
		long ret = bindings.LSPS1CreateOrderResponse_get_order(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The parameters of channel order.
	 */
	public void set_order(org.ldk.structs.LSPS1OrderParams val) {
		bindings.LSPS1CreateOrderResponse_set_order(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The datetime when the order was created
	 */
	public org.ldk.structs.LSPSDateTime get_created_at() {
		long ret = bindings.LSPS1CreateOrderResponse_get_created_at(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The datetime when the order was created
	 */
	public void set_created_at(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS1CreateOrderResponse_set_created_at(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The current state of the order.
	 */
	public LSPS1OrderState get_order_state() {
		LSPS1OrderState ret = bindings.LSPS1CreateOrderResponse_get_order_state(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The current state of the order.
	 */
	public void set_order_state(LSPS1OrderState val) {
		bindings.LSPS1CreateOrderResponse_set_order_state(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Contains details about how to pay for the order.
	 */
	public org.ldk.structs.LSPS1PaymentInfo get_payment() {
		long ret = bindings.LSPS1CreateOrderResponse_get_payment(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Contains details about how to pay for the order.
	 */
	public void set_payment(org.ldk.structs.LSPS1PaymentInfo val) {
		bindings.LSPS1CreateOrderResponse_set_payment(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Contains information about the channel state.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.LSPS1ChannelInfo get_channel() {
		long ret = bindings.LSPS1CreateOrderResponse_get_channel(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ChannelInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Contains information about the channel state.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_channel(org.ldk.structs.LSPS1ChannelInfo val) {
		bindings.LSPS1CreateOrderResponse_set_channel(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1CreateOrderResponse given each field
	 * 
	 * Note that channel_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static org.ldk.structs.LSPS1CreateOrderResponse of(org.ldk.structs.LSPS1OrderId order_id_arg, org.ldk.structs.LSPS1OrderParams order_arg, org.ldk.structs.LSPSDateTime created_at_arg, LSPS1OrderState order_state_arg, org.ldk.structs.LSPS1PaymentInfo payment_arg, org.ldk.structs.LSPS1ChannelInfo channel_arg) {
		long ret = bindings.LSPS1CreateOrderResponse_new(order_id_arg.ptr, order_arg.ptr, created_at_arg.ptr, order_state_arg, payment_arg.ptr, channel_arg == null ? 0 : channel_arg.ptr);
		GC.KeepAlive(order_id_arg);
		GC.KeepAlive(order_arg);
		GC.KeepAlive(created_at_arg);
		GC.KeepAlive(order_state_arg);
		GC.KeepAlive(payment_arg);
		GC.KeepAlive(channel_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1CreateOrderResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1CreateOrderResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1CreateOrderResponse_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1CreateOrderResponse
	 */
	public org.ldk.structs.LSPS1CreateOrderResponse clone() {
		long ret = bindings.LSPS1CreateOrderResponse_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1CreateOrderResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1CreateOrderResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1CreateOrderResponses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1CreateOrderResponse b) {
		bool ret = bindings.LSPS1CreateOrderResponse_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1CreateOrderResponse)) return false;
		return this.eq((LSPS1CreateOrderResponse)o);
	}
}
} } }
