package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An event which an bLIP-51 / LSPS1 client should take some action in response to.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1ClientEvent extends CommonBase {
	private LSPS1ClientEvent(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1ClientEvent_free(ptr); }
	}
	static LSPS1ClientEvent constr_from_ptr(long ptr) {
		bindings.LDKLSPS1ClientEvent raw_val = bindings.LDKLSPS1ClientEvent_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS1ClientEvent.SupportedOptionsReady.class) {
			return new SupportedOptionsReady(ptr, (bindings.LDKLSPS1ClientEvent.SupportedOptionsReady)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1ClientEvent.SupportedOptionsRequestFailed.class) {
			return new SupportedOptionsRequestFailed(ptr, (bindings.LDKLSPS1ClientEvent.SupportedOptionsRequestFailed)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1ClientEvent.OrderCreated.class) {
			return new OrderCreated(ptr, (bindings.LDKLSPS1ClientEvent.OrderCreated)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1ClientEvent.OrderStatus.class) {
			return new OrderStatus(ptr, (bindings.LDKLSPS1ClientEvent.OrderStatus)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1ClientEvent.OrderRequestFailed.class) {
			return new OrderRequestFailed(ptr, (bindings.LDKLSPS1ClientEvent.OrderRequestFailed)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A request previously issued via [`LSPS1ClientHandler::request_supported_options`]
	 * succeeded as the LSP returned the options it supports.
	 * 
	 * You must check whether LSP supports the parameters the client wants and then call
	 * [`LSPS1ClientHandler::create_order`] to place an order.
	 * 
	 * [`LSPS1ClientHandler::request_supported_options`]: crate::lsps1::client::LSPS1ClientHandler::request_supported_options
	 * [`LSPS1ClientHandler::create_order`]: crate::lsps1::client::LSPS1ClientHandler::create_order
	 */
	public final static class SupportedOptionsReady extends LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `get_info` request, as returned by
		 * [`LSPS1ClientHandler::request_supported_options`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::request_supported_options`]: crate::lsps1::client::LSPS1ClientHandler::request_supported_options
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP that provided this response.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * All options supported by the LSP.
		*/
		public final org.ldk.structs.LSPS1Options supported_options;
		private SupportedOptionsReady(long ptr, bindings.LDKLSPS1ClientEvent.SupportedOptionsReady obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long supported_options = obj.supported_options;
			org.ldk.structs.LSPS1Options supported_options_hu_conv = null; if (supported_options < 0 || supported_options > 4096) { supported_options_hu_conv = new org.ldk.structs.LSPS1Options(null, supported_options); }
			if (supported_options_hu_conv != null) { supported_options_hu_conv.ptrs_to.add(this); };
			this.supported_options = supported_options_hu_conv;
		}
	}
	/**
	 * A request previously issued via [`LSPS1ClientHandler::request_supported_options`]
	 * failed as the LSP returned an error response.
	 * 
	 * [`LSPS1ClientHandler::request_supported_options`]: crate::lsps1::client::LSPS1ClientHandler::request_supported_options
	 */
	public final static class SupportedOptionsRequestFailed extends LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `get_info` request, as returned by
		 * [`LSPS1ClientHandler::request_supported_options`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::request_supported_options`]: crate::lsps1::client::LSPS1ClientHandler::request_supported_options
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP that provided this response.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * The error that was returned.
		*/
		public final org.ldk.structs.LSPSResponseError error;
		private SupportedOptionsRequestFailed(long ptr, bindings.LDKLSPS1ClientEvent.SupportedOptionsRequestFailed obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long error = obj.error;
			org.ldk.structs.LSPSResponseError error_hu_conv = null; if (error < 0 || error > 4096) { error_hu_conv = new org.ldk.structs.LSPSResponseError(null, error); }
			if (error_hu_conv != null) { error_hu_conv.ptrs_to.add(this); };
			this.error = error_hu_conv;
		}
	}
	/**
	 * Confirmation from the LSP about the order created by the client.
	 * 
	 * When the payment is confirmed, the LSP will open a channel to you
	 * with the below agreed upon parameters.
	 * 
	 * You must pay the invoice or onchain address if you want to continue and then
	 * call [`LSPS1ClientHandler::check_order_status`] with the order id
	 * to get information from LSP about progress of the order.
	 * 
	 * [`LSPS1ClientHandler::check_order_status`]: crate::lsps1::client::LSPS1ClientHandler::check_order_status
	 */
	public final static class OrderCreated extends LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `create_order` request, as returned by
		 * [`LSPS1ClientHandler::create_order`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::create_order`]: crate::lsps1::client::LSPS1ClientHandler::create_order
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * The id of the channel order.
		*/
		public final org.ldk.structs.LSPS1OrderId order_id;
		/**
		 * The order created by client and approved by LSP.
		*/
		public final org.ldk.structs.LSPS1OrderParams order;
		/**
		 * The details regarding payment of the order
		*/
		public final org.ldk.structs.LSPS1PaymentInfo payment;
		/**
		 * The details regarding state of the channel ordered.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		*/
		@Nullable public final org.ldk.structs.LSPS1ChannelInfo channel;
		private OrderCreated(long ptr, bindings.LDKLSPS1ClientEvent.OrderCreated obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long order_id = obj.order_id;
			org.ldk.structs.LSPS1OrderId order_id_hu_conv = null; if (order_id < 0 || order_id > 4096) { order_id_hu_conv = new org.ldk.structs.LSPS1OrderId(null, order_id); }
			if (order_id_hu_conv != null) { order_id_hu_conv.ptrs_to.add(this); };
			this.order_id = order_id_hu_conv;
			long order = obj.order;
			org.ldk.structs.LSPS1OrderParams order_hu_conv = null; if (order < 0 || order > 4096) { order_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, order); }
			if (order_hu_conv != null) { order_hu_conv.ptrs_to.add(this); };
			this.order = order_hu_conv;
			long payment = obj.payment;
			org.ldk.structs.LSPS1PaymentInfo payment_hu_conv = null; if (payment < 0 || payment > 4096) { payment_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, payment); }
			if (payment_hu_conv != null) { payment_hu_conv.ptrs_to.add(this); };
			this.payment = payment_hu_conv;
			long channel = obj.channel;
			org.ldk.structs.LSPS1ChannelInfo channel_hu_conv = null; if (channel < 0 || channel > 4096) { channel_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, channel); }
			if (channel_hu_conv != null) { channel_hu_conv.ptrs_to.add(this); };
			this.channel = channel_hu_conv;
		}
	}
	/**
	 * Information from the LSP about the status of a previously created order.
	 * 
	 * Will be emitted in response to calling [`LSPS1ClientHandler::check_order_status`].
	 * 
	 * [`LSPS1ClientHandler::check_order_status`]: crate::lsps1::client::LSPS1ClientHandler::check_order_status
	 */
	public final static class OrderStatus extends LSPS1ClientEvent {
		/**
		 * The identifier of the issued bLIP-51 / LSPS1 `get_order` request, as returned by
		 * [`LSPS1ClientHandler::check_order_status`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::check_order_status`]: crate::lsps1::client::LSPS1ClientHandler::check_order_status
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * The id of the channel order.
		*/
		public final org.ldk.structs.LSPS1OrderId order_id;
		/**
		 * The order created by client and approved by LSP.
		*/
		public final org.ldk.structs.LSPS1OrderParams order;
		/**
		 * The details regarding payment of the order
		*/
		public final org.ldk.structs.LSPS1PaymentInfo payment;
		/**
		 * The details regarding state of the channel ordered.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		*/
		@Nullable public final org.ldk.structs.LSPS1ChannelInfo channel;
		private OrderStatus(long ptr, bindings.LDKLSPS1ClientEvent.OrderStatus obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long order_id = obj.order_id;
			org.ldk.structs.LSPS1OrderId order_id_hu_conv = null; if (order_id < 0 || order_id > 4096) { order_id_hu_conv = new org.ldk.structs.LSPS1OrderId(null, order_id); }
			if (order_id_hu_conv != null) { order_id_hu_conv.ptrs_to.add(this); };
			this.order_id = order_id_hu_conv;
			long order = obj.order;
			org.ldk.structs.LSPS1OrderParams order_hu_conv = null; if (order < 0 || order > 4096) { order_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, order); }
			if (order_hu_conv != null) { order_hu_conv.ptrs_to.add(this); };
			this.order = order_hu_conv;
			long payment = obj.payment;
			org.ldk.structs.LSPS1PaymentInfo payment_hu_conv = null; if (payment < 0 || payment > 4096) { payment_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, payment); }
			if (payment_hu_conv != null) { payment_hu_conv.ptrs_to.add(this); };
			this.payment = payment_hu_conv;
			long channel = obj.channel;
			org.ldk.structs.LSPS1ChannelInfo channel_hu_conv = null; if (channel < 0 || channel > 4096) { channel_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, channel); }
			if (channel_hu_conv != null) { channel_hu_conv.ptrs_to.add(this); };
			this.channel = channel_hu_conv;
		}
	}
	/**
	 * A request previously issued via [`LSPS1ClientHandler::create_order`] or [`LSPS1ClientHandler::check_order_status`].
	 * failed as the LSP returned an error response.
	 * 
	 * [`LSPS1ClientHandler::create_order`]: crate::lsps1::client::LSPS1ClientHandler::create_order
	 * [`LSPS1ClientHandler::check_order_status`]: crate::lsps1::client::LSPS1ClientHandler::check_order_status
	 */
	public final static class OrderRequestFailed extends LSPS1ClientEvent {
		/**
		 * The identifier of the issued LSPS1 `create_order` or `get_order` request, as returned by
		 * [`LSPS1ClientHandler::create_order`] or [`LSPS1ClientHandler::check_order_status`].
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS1ClientHandler::create_order`]: crate::lsps1::client::LSPS1ClientHandler::create_order
		 * [`LSPS1ClientHandler::check_order_status`]: crate::lsps1::client::LSPS1ClientHandler::check_order_status
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * The error that was returned.
		*/
		public final org.ldk.structs.LSPSResponseError error;
		private OrderRequestFailed(long ptr, bindings.LDKLSPS1ClientEvent.OrderRequestFailed obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long error = obj.error;
			org.ldk.structs.LSPSResponseError error_hu_conv = null; if (error < 0 || error > 4096) { error_hu_conv = new org.ldk.structs.LSPSResponseError(null, error); }
			if (error_hu_conv != null) { error_hu_conv.ptrs_to.add(this); };
			this.error = error_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS1ClientEvent_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1ClientEvent
	 */
	public LSPS1ClientEvent clone() {
		long ret = bindings.LSPS1ClientEvent_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SupportedOptionsReady-variant LSPS1ClientEvent
	 */
	public static LSPS1ClientEvent supported_options_ready(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS1Options supported_options) {
		long ret = bindings.LSPS1ClientEvent_supported_options_ready(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), supported_options.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(supported_options);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SupportedOptionsRequestFailed-variant LSPS1ClientEvent
	 */
	public static LSPS1ClientEvent supported_options_request_failed(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPSResponseError error) {
		long ret = bindings.LSPS1ClientEvent_supported_options_request_failed(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), error.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(error);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OrderCreated-variant LSPS1ClientEvent
	 */
	public static LSPS1ClientEvent order_created(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderId order_id, org.ldk.structs.LSPS1OrderParams order, org.ldk.structs.LSPS1PaymentInfo payment, org.ldk.structs.LSPS1ChannelInfo channel) {
		long ret = bindings.LSPS1ClientEvent_order_created(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), order_id.ptr, order.ptr, payment.ptr, channel.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(order_id);
		Reference.reachabilityFence(order);
		Reference.reachabilityFence(payment);
		Reference.reachabilityFence(channel);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OrderStatus-variant LSPS1ClientEvent
	 */
	public static LSPS1ClientEvent order_status(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderId order_id, org.ldk.structs.LSPS1OrderParams order, org.ldk.structs.LSPS1PaymentInfo payment, org.ldk.structs.LSPS1ChannelInfo channel) {
		long ret = bindings.LSPS1ClientEvent_order_status(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), order_id.ptr, order.ptr, payment.ptr, channel.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(order_id);
		Reference.reachabilityFence(order);
		Reference.reachabilityFence(payment);
		Reference.reachabilityFence(channel);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OrderRequestFailed-variant LSPS1ClientEvent
	 */
	public static LSPS1ClientEvent order_request_failed(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPSResponseError error) {
		long ret = bindings.LSPS1ClientEvent_order_request_failed(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), error.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(error);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ClientEvent ret_hu_conv = org.ldk.structs.LSPS1ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1ClientEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS1ClientEvent b) {
		boolean ret = bindings.LSPS1ClientEvent_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1ClientEvent)) return false;
		return this.eq((LSPS1ClientEvent)o);
	}
}
