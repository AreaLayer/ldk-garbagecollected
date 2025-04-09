using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An event which an bLIP-51 / LSPS1 client should take some action in response to.
 */
public class LSPS1ClientEvent : CommonBase {
	protected LSPS1ClientEvent(object _dummy, long ptr) : base(ptr) { }
	~LSPS1ClientEvent() {
		if (ptr != 0) { bindings.LSPS1ClientEvent_free(ptr); }
	}

	internal static LSPS1ClientEvent constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS1ClientEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS1ClientEvent_SupportedOptionsReady(ptr);
			case 1: return new LSPS1ClientEvent_SupportedOptionsRequestFailed(ptr);
			case 2: return new LSPS1ClientEvent_OrderCreated(ptr);
			case 3: return new LSPS1ClientEvent_OrderStatus(ptr);
			case 4: return new LSPS1ClientEvent_OrderRequestFailed(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS1ClientEvent of type SupportedOptionsReady */
	public class LSPS1ClientEvent_SupportedOptionsReady : LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `get_info` request, as returned by
		 * [`LSPS1ClientHandler::request_supported_options`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::request_supported_options`]: crate::lsps1::client::LSPS1ClientHandler::request_supported_options
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP that provided this response.
		 */
		public byte[] counterparty_node_id;
		/**
		 * All options supported by the LSP.
		 */
		public org.ldk.structs.LSPS1Options supported_options;
		internal LSPS1ClientEvent_SupportedOptionsReady(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS1ClientEvent_SupportedOptionsReady_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS1ClientEvent_SupportedOptionsReady_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long supported_options = bindings.LDKLSPS1ClientEvent_SupportedOptionsReady_get_supported_options(ptr);
			org.ldk.structs.LSPS1Options supported_options_hu_conv = null; if (supported_options < 0 || supported_options > 4096) { supported_options_hu_conv = new org.ldk.structs.LSPS1Options(null, supported_options); }
			if (supported_options_hu_conv != null) { supported_options_hu_conv.ptrs_to.AddLast(this); };
			this.supported_options = supported_options_hu_conv;
		}
	}
	/** A LSPS1ClientEvent of type SupportedOptionsRequestFailed */
	public class LSPS1ClientEvent_SupportedOptionsRequestFailed : LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `get_info` request, as returned by
		 * [`LSPS1ClientHandler::request_supported_options`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::request_supported_options`]: crate::lsps1::client::LSPS1ClientHandler::request_supported_options
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP that provided this response.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The error that was returned.
		 */
		public org.ldk.structs.LSPSResponseError error;
		internal LSPS1ClientEvent_SupportedOptionsRequestFailed(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS1ClientEvent_SupportedOptionsRequestFailed_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS1ClientEvent_SupportedOptionsRequestFailed_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long error = bindings.LDKLSPS1ClientEvent_SupportedOptionsRequestFailed_get_error(ptr);
			org.ldk.structs.LSPSResponseError error_hu_conv = null; if (error < 0 || error > 4096) { error_hu_conv = new org.ldk.structs.LSPSResponseError(null, error); }
			if (error_hu_conv != null) { error_hu_conv.ptrs_to.AddLast(this); };
			this.error = error_hu_conv;
		}
	}
	/** A LSPS1ClientEvent of type OrderCreated */
	public class LSPS1ClientEvent_OrderCreated : LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `create_order` request, as returned by
		 * [`LSPS1ClientHandler::create_order`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::create_order`]: crate::lsps1::client::LSPS1ClientHandler::create_order
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The id of the channel order.
		 */
		public org.ldk.structs.LSPS1OrderId order_id;
		/**
		 * The order created by client and approved by LSP.
		 */
		public org.ldk.structs.LSPS1OrderParams order;
		/**
		 * The details regarding payment of the order
		 */
		public org.ldk.structs.LSPS1PaymentInfo payment;
		/**
		 * The details regarding state of the channel ordered.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public org.ldk.structs.LSPS1ChannelInfo channel;
		internal LSPS1ClientEvent_OrderCreated(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS1ClientEvent_OrderCreated_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS1ClientEvent_OrderCreated_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long order_id = bindings.LDKLSPS1ClientEvent_OrderCreated_get_order_id(ptr);
			org.ldk.structs.LSPS1OrderId order_id_hu_conv = null; if (order_id < 0 || order_id > 4096) { order_id_hu_conv = new org.ldk.structs.LSPS1OrderId(null, order_id); }
			if (order_id_hu_conv != null) { order_id_hu_conv.ptrs_to.AddLast(this); };
			this.order_id = order_id_hu_conv;
			long order = bindings.LDKLSPS1ClientEvent_OrderCreated_get_order(ptr);
			org.ldk.structs.LSPS1OrderParams order_hu_conv = null; if (order < 0 || order > 4096) { order_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, order); }
			if (order_hu_conv != null) { order_hu_conv.ptrs_to.AddLast(this); };
			this.order = order_hu_conv;
			long payment = bindings.LDKLSPS1ClientEvent_OrderCreated_get_payment(ptr);
			org.ldk.structs.LSPS1PaymentInfo payment_hu_conv = null; if (payment < 0 || payment > 4096) { payment_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, payment); }
			if (payment_hu_conv != null) { payment_hu_conv.ptrs_to.AddLast(this); };
			this.payment = payment_hu_conv;
			long channel = bindings.LDKLSPS1ClientEvent_OrderCreated_get_channel(ptr);
			org.ldk.structs.LSPS1ChannelInfo channel_hu_conv = null; if (channel < 0 || channel > 4096) { channel_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, channel); }
			if (channel_hu_conv != null) { channel_hu_conv.ptrs_to.AddLast(this); };
			this.channel = channel_hu_conv;
		}
	}
	/** A LSPS1ClientEvent of type OrderStatus */
	public class LSPS1ClientEvent_OrderStatus : LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `get_order` request, as returned by
		 * [`LSPS1ClientHandler::check_order_status`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::check_order_status`]: crate::lsps1::client::LSPS1ClientHandler::check_order_status
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The id of the channel order.
		 */
		public org.ldk.structs.LSPS1OrderId order_id;
		/**
		 * The order created by client and approved by LSP.
		 */
		public org.ldk.structs.LSPS1OrderParams order;
		/**
		 * The details regarding payment of the order
		 */
		public org.ldk.structs.LSPS1PaymentInfo payment;
		/**
		 * The details regarding state of the channel ordered.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public org.ldk.structs.LSPS1ChannelInfo channel;
		internal LSPS1ClientEvent_OrderStatus(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS1ClientEvent_OrderStatus_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS1ClientEvent_OrderStatus_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long order_id = bindings.LDKLSPS1ClientEvent_OrderStatus_get_order_id(ptr);
			org.ldk.structs.LSPS1OrderId order_id_hu_conv = null; if (order_id < 0 || order_id > 4096) { order_id_hu_conv = new org.ldk.structs.LSPS1OrderId(null, order_id); }
			if (order_id_hu_conv != null) { order_id_hu_conv.ptrs_to.AddLast(this); };
			this.order_id = order_id_hu_conv;
			long order = bindings.LDKLSPS1ClientEvent_OrderStatus_get_order(ptr);
			org.ldk.structs.LSPS1OrderParams order_hu_conv = null; if (order < 0 || order > 4096) { order_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, order); }
			if (order_hu_conv != null) { order_hu_conv.ptrs_to.AddLast(this); };
			this.order = order_hu_conv;
			long payment = bindings.LDKLSPS1ClientEvent_OrderStatus_get_payment(ptr);
			org.ldk.structs.LSPS1PaymentInfo payment_hu_conv = null; if (payment < 0 || payment > 4096) { payment_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, payment); }
			if (payment_hu_conv != null) { payment_hu_conv.ptrs_to.AddLast(this); };
			this.payment = payment_hu_conv;
			long channel = bindings.LDKLSPS1ClientEvent_OrderStatus_get_channel(ptr);
			org.ldk.structs.LSPS1ChannelInfo channel_hu_conv = null; if (channel < 0 || channel > 4096) { channel_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, channel); }
			if (channel_hu_conv != null) { channel_hu_conv.ptrs_to.AddLast(this); };
			this.channel = channel_hu_conv;
		}
	}
	/** A LSPS1ClientEvent of type OrderRequestFailed */
	public class LSPS1ClientEvent_OrderRequestFailed : LSPS1ClientEvent {
		/**
		 * The identifier of the issued LSPS1 `create_order` or `get_order` request, as returned by
		 * [`LSPS1ClientHandler::create_order`] or [`LSPS1ClientHandler::check_order_status`].
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::create_order`]: crate::lsps1::client::LSPS1ClientHandler::create_order
		 * [`LSPS1ClientHandler::check_order_status`]: crate::lsps1::client::LSPS1ClientHandler::check_order_status
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The error that was returned.
		 */
		public org.ldk.structs.LSPSResponseError error;
		internal LSPS1ClientEvent_OrderRequestFailed(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS1ClientEvent_OrderRequestFailed_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS1ClientEvent_OrderRequestFailed_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long error = bindings.LDKLSPS1ClientEvent_OrderRequestFailed_get_error(ptr);
			org.ldk.structs.LSPSResponseError error_hu_conv = null; if (error < 0 || error > 4096) { error_hu_conv = new org.ldk.structs.LSPSResponseError(null, error); }
			if (error_hu_conv != null) { error_hu_conv.ptrs_to.AddLast(this); };
			this.error = error_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS1ClientEvent_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1ClientEvent
	 */
	public org.ldk.structs.LSPS1ClientEvent clone() {
		long ret = bindings.LSPS1ClientEvent_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SupportedOptionsReady-variant LSPS1ClientEvent
	 */
	public static org.ldk.structs.LSPS1ClientEvent supported_options_ready(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS1Options supported_options) {
		long ret = bindings.LSPS1ClientEvent_supported_options_ready(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), supported_options.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(supported_options);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SupportedOptionsRequestFailed-variant LSPS1ClientEvent
	 */
	public static org.ldk.structs.LSPS1ClientEvent supported_options_request_failed(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPSResponseError error) {
		long ret = bindings.LSPS1ClientEvent_supported_options_request_failed(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), error.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(error);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OrderCreated-variant LSPS1ClientEvent
	 */
	public static org.ldk.structs.LSPS1ClientEvent order_created(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderId order_id, org.ldk.structs.LSPS1OrderParams order, org.ldk.structs.LSPS1PaymentInfo payment, org.ldk.structs.LSPS1ChannelInfo channel) {
		long ret = bindings.LSPS1ClientEvent_order_created(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), order_id.ptr, order.ptr, payment.ptr, channel.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(order_id);
		GC.KeepAlive(order);
		GC.KeepAlive(payment);
		GC.KeepAlive(channel);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OrderStatus-variant LSPS1ClientEvent
	 */
	public static org.ldk.structs.LSPS1ClientEvent order_status(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderId order_id, org.ldk.structs.LSPS1OrderParams order, org.ldk.structs.LSPS1PaymentInfo payment, org.ldk.structs.LSPS1ChannelInfo channel) {
		long ret = bindings.LSPS1ClientEvent_order_status(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), order_id.ptr, order.ptr, payment.ptr, channel.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(order_id);
		GC.KeepAlive(order);
		GC.KeepAlive(payment);
		GC.KeepAlive(channel);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OrderRequestFailed-variant LSPS1ClientEvent
	 */
	public static org.ldk.structs.LSPS1ClientEvent order_request_failed(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPSResponseError error) {
		long ret = bindings.LSPS1ClientEvent_order_request_failed(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), error.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(error);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1ClientEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS1ClientEvent b) {
		bool ret = bindings.LSPS1ClientEvent_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1ClientEvent)) return false;
		return this.eq((LSPS1ClientEvent)o);
	}
}
} } }
