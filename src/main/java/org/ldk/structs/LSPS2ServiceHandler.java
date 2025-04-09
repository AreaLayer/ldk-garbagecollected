package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The main object allowing to send and receive bLIP-52 / LSPS2 messages.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2ServiceHandler extends CommonBase {
	LSPS2ServiceHandler(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2ServiceHandler_free(ptr); }
	}

	/**
	 * Used by LSP to inform a client requesting a JIT Channel the token they used is invalid.
	 * 
	 * Should be called in response to receiving a [`LSPS2ServiceEvent::GetInfo`] event.
	 * 
	 * [`LSPS2ServiceEvent::GetInfo`]: crate::lsps2::event::LSPS2ServiceEvent::GetInfo
	 */
	public Result_NoneAPIErrorZ invalid_token_provided(byte[] counterparty_node_id, org.ldk.structs.LSPSRequestId request_id) {
		long ret = bindings.LSPS2ServiceHandler_invalid_token_provided(this.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), request_id.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(request_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Used by LSP to provide fee parameters to a client requesting a JIT Channel.
	 * 
	 * Should be called in response to receiving a [`LSPS2ServiceEvent::GetInfo`] event.
	 * 
	 * [`LSPS2ServiceEvent::GetInfo`]: crate::lsps2::event::LSPS2ServiceEvent::GetInfo
	 */
	public Result_NoneAPIErrorZ opening_fee_params_generated(byte[] counterparty_node_id, org.ldk.structs.LSPSRequestId request_id, LSPS2RawOpeningFeeParams[] opening_fee_params_menu) {
		long ret = bindings.LSPS2ServiceHandler_opening_fee_params_generated(this.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), request_id.ptr, opening_fee_params_menu != null ? Arrays.stream(opening_fee_params_menu).mapToLong(opening_fee_params_menu_conv_26 -> opening_fee_params_menu_conv_26.ptr).toArray() : null);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(opening_fee_params_menu);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		for (LSPS2RawOpeningFeeParams opening_fee_params_menu_conv_26: opening_fee_params_menu) { if (this != null) { this.ptrs_to.add(opening_fee_params_menu_conv_26); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid this being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after this call, opening_fee_params_menu_conv_26 is reset to null and is now a dummy object.
		opening_fee_params_menu_conv_26.ptr = 0;; };
		return ret_hu_conv;
	}

	/**
	 * Used by LSP to provide client with the intercept scid and cltv_expiry_delta to use in their invoice.
	 * 
	 * Should be called in response to receiving a [`LSPS2ServiceEvent::BuyRequest`] event.
	 * 
	 * [`LSPS2ServiceEvent::BuyRequest`]: crate::lsps2::event::LSPS2ServiceEvent::BuyRequest
	 */
	public Result_NoneAPIErrorZ invoice_parameters_generated(byte[] counterparty_node_id, org.ldk.structs.LSPSRequestId request_id, long intercept_scid, int cltv_expiry_delta, boolean client_trusts_lsp, org.ldk.util.UInt128 user_channel_id) {
		long ret = bindings.LSPS2ServiceHandler_invoice_parameters_generated(this.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), request_id.ptr, intercept_scid, cltv_expiry_delta, client_trusts_lsp, user_channel_id.getLEBytes());
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(intercept_scid);
		Reference.reachabilityFence(cltv_expiry_delta);
		Reference.reachabilityFence(client_trusts_lsp);
		Reference.reachabilityFence(user_channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Forward [`Event::HTLCIntercepted`] event parameters into this function.
	 * 
	 * Will fail the intercepted HTLC if the intercept scid matches a payment we are expecting
	 * but the payment amount is incorrect or the expiry has passed.
	 * 
	 * Will generate a [`LSPS2ServiceEvent::OpenChannel`] event if the intercept scid matches a payment we are expected
	 * and the payment amount is correct and the offer has not expired.
	 * 
	 * Will do nothing if the intercept scid does not match any of the ones we gave out.
	 * 
	 * [`Event::HTLCIntercepted`]: lightning::events::Event::HTLCIntercepted
	 * [`LSPS2ServiceEvent::OpenChannel`]: crate::lsps2::event::LSPS2ServiceEvent::OpenChannel
	 */
	public Result_NoneAPIErrorZ htlc_intercepted(long intercept_scid, byte[] intercept_id, long expected_outbound_amount_msat, byte[] payment_hash) {
		long ret = bindings.LSPS2ServiceHandler_htlc_intercepted(this.ptr, intercept_scid, InternalUtils.check_arr_len(intercept_id, 32), expected_outbound_amount_msat, InternalUtils.check_arr_len(payment_hash, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(intercept_scid);
		Reference.reachabilityFence(intercept_id);
		Reference.reachabilityFence(expected_outbound_amount_msat);
		Reference.reachabilityFence(payment_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Forward [`Event::HTLCHandlingFailed`] event parameter into this function.
	 * 
	 * Will attempt to forward the next payment in the queue if one is present.
	 * Will do nothing if the intercept scid does not match any of the ones we gave out
	 * or if the payment queue is empty
	 * 
	 * [`Event::HTLCHandlingFailed`]: lightning::events::Event::HTLCHandlingFailed
	 */
	public Result_NoneAPIErrorZ htlc_handling_failed(org.ldk.structs.HTLCDestination failed_next_destination) {
		long ret = bindings.LSPS2ServiceHandler_htlc_handling_failed(this.ptr, failed_next_destination.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(failed_next_destination);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Forward [`Event::PaymentForwarded`] event parameter into this function.
	 * 
	 * Will register the forwarded payment as having paid the JIT channel fee, and forward any held
	 * and future HTLCs for the SCID of the initial invoice. In the future, this will verify the
	 * `skimmed_fee_msat` in [`Event::PaymentForwarded`].
	 * 
	 * Note that `next_channel_id` is required to be provided. Therefore, the corresponding
	 * [`Event::PaymentForwarded`] events need to be generated and serialized by LDK versions
	 * greater or equal to 0.0.107.
	 * 
	 * [`Event::PaymentForwarded`]: lightning::events::Event::PaymentForwarded
	 */
	public Result_NoneAPIErrorZ payment_forwarded(org.ldk.structs.ChannelId next_channel_id) {
		long ret = bindings.LSPS2ServiceHandler_payment_forwarded(this.ptr, next_channel_id.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(next_channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Forward [`Event::ChannelReady`] event parameters into this function.
	 * 
	 * Will forward the intercepted HTLC if it matches a channel
	 * we need to forward a payment over otherwise it will be ignored.
	 * 
	 * [`Event::ChannelReady`]: lightning::events::Event::ChannelReady
	 */
	public Result_NoneAPIErrorZ channel_ready(org.ldk.util.UInt128 user_channel_id, org.ldk.structs.ChannelId channel_id, byte[] counterparty_node_id) {
		long ret = bindings.LSPS2ServiceHandler_channel_ready(this.ptr, user_channel_id.getLEBytes(), channel_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(user_channel_id);
		Reference.reachabilityFence(channel_id);
		Reference.reachabilityFence(counterparty_node_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(channel_id); };
		return ret_hu_conv;
	}

}
