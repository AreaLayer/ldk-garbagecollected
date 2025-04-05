package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The main object allowing to send and receive bLIP-51 / LSPS1 messages.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1ClientHandler extends CommonBase {
	LSPS1ClientHandler(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
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
	public LSPSRequestId request_supported_options(byte[] counterparty_node_id) {
		long ret = bindings.LSPS1ClientHandler_request_supported_options(this.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(counterparty_node_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Places an order with the connected LSP given its `counterparty_node_id`.
	 * 
	 * The client agrees to paying channel fees according to the provided parameters.
	 */
	public LSPSRequestId create_order(byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderParams order, org.ldk.structs.Option_AddressZ refund_onchain_address) {
		long ret = bindings.LSPS1ClientHandler_create_order(this.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), order.ptr, refund_onchain_address.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(order);
		Reference.reachabilityFence(refund_onchain_address);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		if (this != null) { this.ptrs_to.add(refund_onchain_address); };
		return ret_hu_conv;
	}

	/**
	 * Queries the status of a pending payment, i.e., whether a payment has been received by the LSP.
	 * 
	 * Upon success an [`LSPS1ClientEvent::OrderStatus`] event will be emitted.
	 * 
	 * [`LSPS1ClientEvent::OrderStatus`]: crate::lsps1::event::LSPS1ClientEvent::OrderStatus
	 */
	public LSPSRequestId check_order_status(byte[] counterparty_node_id, org.ldk.structs.LSPS1OrderId order_id) {
		long ret = bindings.LSPS1ClientHandler_check_order_status(this.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), order_id.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(order_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
