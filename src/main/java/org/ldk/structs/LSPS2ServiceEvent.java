package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An event which an bLIP-52 / LSPS2 server should take some action in response to.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2ServiceEvent extends CommonBase {
	private LSPS2ServiceEvent(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2ServiceEvent_free(ptr); }
	}
	static LSPS2ServiceEvent constr_from_ptr(long ptr) {
		bindings.LDKLSPS2ServiceEvent raw_val = bindings.LDKLSPS2ServiceEvent_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS2ServiceEvent.GetInfo.class) {
			return new GetInfo(ptr, (bindings.LDKLSPS2ServiceEvent.GetInfo)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2ServiceEvent.BuyRequest.class) {
			return new BuyRequest(ptr, (bindings.LDKLSPS2ServiceEvent.BuyRequest)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2ServiceEvent.OpenChannel.class) {
			return new OpenChannel(ptr, (bindings.LDKLSPS2ServiceEvent.OpenChannel)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A request from a client for information about JIT Channel parameters.
	 * 
	 * You must calculate the parameters for this client and pass them to
	 * [`LSPS2ServiceHandler::opening_fee_params_generated`].
	 * 
	 * If an unrecognized or stale token is provided you can use
	 * `[LSPS2ServiceHandler::invalid_token_provided`] to error the request.
	 * 
	 * [`LSPS2ServiceHandler::opening_fee_params_generated`]: crate::lsps2::service::LSPS2ServiceHandler::opening_fee_params_generated
	 * [`LSPS2ServiceHandler::invalid_token_provided`]: crate::lsps2::service::LSPS2ServiceHandler::invalid_token_provided
	 */
	public final static class GetInfo extends LSPS2ServiceEvent {
		/**
		 * An identifier that must be passed to [`LSPS2ServiceHandler::opening_fee_params_generated`].
		 * 
		 * [`LSPS2ServiceHandler::opening_fee_params_generated`]: crate::lsps2::service::LSPS2ServiceHandler::opening_fee_params_generated
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the client making the information request.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * An optional token that can be used as an API key, coupon code, etc.
		*/
		public final org.ldk.structs.Option_StrZ token;
		private GetInfo(long ptr, bindings.LDKLSPS2ServiceEvent.GetInfo obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long token = obj.token;
			org.ldk.structs.Option_StrZ token_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(token);
			if (token_hu_conv != null) { token_hu_conv.ptrs_to.add(this); };
			this.token = token_hu_conv;
		}
	}
	/**
	 * A client has selected a opening fee parameter to use and would like to
	 * purchase a channel with an optional initial payment size.
	 * 
	 * If `payment_size_msat` is [`Option::Some`] then the payer is allowed to use MPP.
	 * If `payment_size_msat` is [`Option::None`] then the payer cannot use MPP.
	 * 
	 * You must generate an intercept scid and `cltv_expiry_delta` for them to use
	 * and call [`LSPS2ServiceHandler::invoice_parameters_generated`].
	 * 
	 * [`LSPS2ServiceHandler::invoice_parameters_generated`]: crate::lsps2::service::LSPS2ServiceHandler::invoice_parameters_generated
	 */
	public final static class BuyRequest extends LSPS2ServiceEvent {
		/**
		 * An identifier that must be passed into [`LSPS2ServiceHandler::invoice_parameters_generated`].
		 * 
		 * [`LSPS2ServiceHandler::invoice_parameters_generated`]: crate::lsps2::service::LSPS2ServiceHandler::invoice_parameters_generated
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The client node id that is making this request.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * The channel parameters they have selected.
		*/
		public final org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params;
		/**
		 * The size of the initial payment they would like to receive.
		*/
		public final org.ldk.structs.Option_u64Z payment_size_msat;
		private BuyRequest(long ptr, bindings.LDKLSPS2ServiceEvent.BuyRequest obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long opening_fee_params = obj.opening_fee_params;
			org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params_hu_conv = null; if (opening_fee_params < 0 || opening_fee_params > 4096) { opening_fee_params_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, opening_fee_params); }
			if (opening_fee_params_hu_conv != null) { opening_fee_params_hu_conv.ptrs_to.add(this); };
			this.opening_fee_params = opening_fee_params_hu_conv;
			long payment_size_msat = obj.payment_size_msat;
			org.ldk.structs.Option_u64Z payment_size_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(payment_size_msat);
			if (payment_size_msat_hu_conv != null) { payment_size_msat_hu_conv.ptrs_to.add(this); };
			this.payment_size_msat = payment_size_msat_hu_conv;
		}
	}
	/**
	 * You should open a channel using [`ChannelManager::create_channel`].
	 * 
	 * [`ChannelManager::create_channel`]: lightning::ln::channelmanager::ChannelManager::create_channel
	 */
	public final static class OpenChannel extends LSPS2ServiceEvent {
		/**
		 * The node to open channel with.
		*/
		public final byte[] their_network_key;
		/**
		 * The amount to forward after fees.
		*/
		public final long amt_to_forward_msat;
		/**
		 * The fee earned for opening the channel.
		*/
		public final long opening_fee_msat;
		/**
		 * A user specified id used to track channel open.
		*/
		public final org.ldk.util.UInt128 user_channel_id;
		/**
		 * The intercept short channel id to use in the route hint.
		*/
		public final long intercept_scid;
		private OpenChannel(long ptr, bindings.LDKLSPS2ServiceEvent.OpenChannel obj) {
			super(null, ptr);
			this.their_network_key = obj.their_network_key;
			this.amt_to_forward_msat = obj.amt_to_forward_msat;
			this.opening_fee_msat = obj.opening_fee_msat;
			byte[] user_channel_id = obj.user_channel_id;
			org.ldk.util.UInt128 user_channel_id_conv = new org.ldk.util.UInt128(user_channel_id);
			this.user_channel_id = user_channel_id_conv;
			this.intercept_scid = obj.intercept_scid;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS2ServiceEvent_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ServiceEvent
	 */
	public LSPS2ServiceEvent clone() {
		long ret = bindings.LSPS2ServiceEvent_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS2ServiceEvent
	 */
	public static LSPS2ServiceEvent get_info(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.Option_StrZ token) {
		long ret = bindings.LSPS2ServiceEvent_get_info(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), token.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(token);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BuyRequest-variant LSPS2ServiceEvent
	 */
	public static LSPS2ServiceEvent buy_request(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params, org.ldk.structs.Option_u64Z payment_size_msat) {
		long ret = bindings.LSPS2ServiceEvent_buy_request(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), opening_fee_params.ptr, payment_size_msat.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(opening_fee_params);
		Reference.reachabilityFence(payment_size_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OpenChannel-variant LSPS2ServiceEvent
	 */
	public static LSPS2ServiceEvent open_channel(byte[] their_network_key, long amt_to_forward_msat, long opening_fee_msat, org.ldk.util.UInt128 user_channel_id, long intercept_scid) {
		long ret = bindings.LSPS2ServiceEvent_open_channel(InternalUtils.check_arr_len(their_network_key, 33), amt_to_forward_msat, opening_fee_msat, user_channel_id.getLEBytes(), intercept_scid);
		Reference.reachabilityFence(their_network_key);
		Reference.reachabilityFence(amt_to_forward_msat);
		Reference.reachabilityFence(opening_fee_msat);
		Reference.reachabilityFence(user_channel_id);
		Reference.reachabilityFence(intercept_scid);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2ServiceEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS2ServiceEvent b) {
		boolean ret = bindings.LSPS2ServiceEvent_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2ServiceEvent)) return false;
		return this.eq((LSPS2ServiceEvent)o);
	}
}
