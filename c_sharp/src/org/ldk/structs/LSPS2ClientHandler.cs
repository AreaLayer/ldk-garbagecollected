using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The main object allowing to send and receive bLIP-52 / LSPS2 messages.
 * 
 * Note that currently only the 'client-trusts-LSP' trust model is supported, i.e., we don't
 * provide any additional API guidance to allow withholding the preimage until the channel is
 * opened. Please refer to the [`bLIP-52 / LSPS2 specification`] for more information.
 * 
 * [`bLIP-52 / LSPS2 specification`]: https://github.com/lightning/blips/blob/master/blip-0052.md#trust-models
 */
public class LSPS2ClientHandler : CommonBase {
	internal LSPS2ClientHandler(object _dummy, long ptr) : base(ptr) { }
	~LSPS2ClientHandler() {
		if (ptr != 0) { bindings.LSPS2ClientHandler_free(ptr); }
	}

	/**
	 * Request the channel opening parameters from the LSP.
	 * 
	 * This initiates the JIT-channel flow that, at the end of it, will have the LSP
	 * open a channel with sufficient inbound liquidity to be able to receive the payment.
	 * 
	 * The user will receive the LSP's response via an [`OpeningParametersReady`] event.
	 * 
	 * `counterparty_node_id` is the `node_id` of the LSP you would like to use.
	 * 
	 * `token` is an optional `String` that will be provided to the LSP.
	 * It can be used by the LSP as an API key, coupon code, or some other way to identify a user.
	 * 
	 * Returns the used [`LSPSRequestId`], which will be returned via [`OpeningParametersReady`].
	 * 
	 * [`OpeningParametersReady`]: crate::lsps2::event::LSPS2ClientEvent::OpeningParametersReady
	 */
	public org.ldk.structs.LSPSRequestId request_opening_params(byte[] counterparty_node_id, org.ldk.structs.Option_StrZ token) {
		long ret = bindings.LSPS2ClientHandler_request_opening_params(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), token.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(token);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSRequestId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSRequestId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Confirms a set of chosen channel opening parameters to use for the JIT channel and
	 * requests the necessary invoice generation parameters from the LSP.
	 * 
	 * Should be called in response to receiving a [`OpeningParametersReady`] event.
	 * 
	 * The user will receive the LSP's response via an [`InvoiceParametersReady`] event.
	 * 
	 * If `payment_size_msat` is [`Option::Some`] then the invoice will be for a fixed amount
	 * and MPP can be used to pay it.
	 * 
	 * If `payment_size_msat` is [`Option::None`] then the invoice can be for an arbitrary amount
	 * but MPP can no longer be used to pay it.
	 * 
	 * The client agrees to paying an opening fee equal to
	 * `max(min_fee_msat, proportional*(payment_size_msat/1_000_000))`.
	 * 
	 * [`OpeningParametersReady`]: crate::lsps2::event::LSPS2ClientEvent::OpeningParametersReady
	 * [`InvoiceParametersReady`]: crate::lsps2::event::LSPS2ClientEvent::InvoiceParametersReady
	 */
	public org.ldk.structs.Result_LSPSRequestIdAPIErrorZ select_opening_params(byte[] counterparty_node_id, org.ldk.structs.Option_u64Z payment_size_msat, org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params) {
		long ret = bindings.LSPS2ClientHandler_select_opening_params(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), payment_size_msat.ptr, opening_fee_params.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(payment_size_msat);
		GC.KeepAlive(opening_fee_params);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_LSPSRequestIdAPIErrorZ ret_hu_conv = Result_LSPSRequestIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
