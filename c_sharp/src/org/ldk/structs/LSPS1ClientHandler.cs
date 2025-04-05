using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The main object allowing to send and receive bLIP-51 / LSPS1 messages.
 */
public class LSPS1ClientHandler : CommonBase {
	internal LSPS1ClientHandler(object _dummy, long ptr) : base(ptr) { }
	~LSPS1ClientHandler() {
		if (ptr != 0) { bindings.LSPS1ClientHandler_free(ptr); }
	}

	/**
	 * Request the supported options from the LSP.
	 * 
	 * The user will receive the LSP's response via an [`SupportedOptionsReady`] event.
	 * 
	 * `counterparty_node_id` is the `node_id` of the LSP you would like to use.
	 * 
	 * Returns the used [`LSPSRequestId`], which will be returned via [`SupportedOptionsReady`].
	 * 
	 * [`SupportedOptionsReady`]: crate::lsps1::event::LSPS1ClientEvent::SupportedOptionsReady
	 */
	public org.ldk.structs.LSPSRequestId request_supported_options(byte[] counterparty_node_id) {
		long ret = bindings.LSPS1ClientHandler_request_supported_options(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(counterparty_node_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Places an order with the connected LSP given its `counterparty_node_id`.
	 * 
	 * The client agrees to paying channel fees according to the provided parameters.
	 */
	public org.ldk.structs.LSPSRequestId create_order(byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderParams order, org.ldk.structs.Option_AddressZ refund_onchain_address) {
		long ret = bindings.LSPS1ClientHandler_create_order(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), order.ptr, refund_onchain_address.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(order);
		GC.KeepAlive(refund_onchain_address);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		if (this != null) { this.ptrs_to.AddLast(refund_onchain_address); };
		return ret_hu_conv;
	}

	/**
	 * Queries the status of a pending payment, i.e., whether a payment has been received by the LSP.
	 * 
	 * Upon success an [`LSPS1ClientEvent::OrderStatus`] event will be emitted.
	 * 
	 * [`LSPS1ClientEvent::OrderStatus`]: crate::lsps1::event::LSPS1ClientEvent::OrderStatus
	 */
	public org.ldk.structs.LSPSRequestId check_order_status(byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderId order_id) {
		long ret = bindings.LSPS1ClientHandler_check_order_status(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), order_id.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(order_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
