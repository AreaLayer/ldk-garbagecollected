package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An event which an LSPS2 client should take some action in response to.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2ClientEvent extends CommonBase {
	private LSPS2ClientEvent(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2ClientEvent_free(ptr); }
	}
	static LSPS2ClientEvent constr_from_ptr(long ptr) {
		bindings.LDKLSPS2ClientEvent raw_val = bindings.LDKLSPS2ClientEvent_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS2ClientEvent.OpeningParametersReady.class) {
			return new OpeningParametersReady(ptr, (bindings.LDKLSPS2ClientEvent.OpeningParametersReady)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2ClientEvent.InvoiceParametersReady.class) {
			return new InvoiceParametersReady(ptr, (bindings.LDKLSPS2ClientEvent.InvoiceParametersReady)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Information from the LSP about their current fee rates and channel parameters.
	 * 
	 * You must call [`LSPS2ClientHandler::select_opening_params`] with the fee parameter
	 * you want to use if you wish to proceed opening a channel.
	 * 
	 * [`LSPS2ClientHandler::select_opening_params`]: crate::lsps2::client::LSPS2ClientHandler::select_opening_params
	 */
	public final static class OpeningParametersReady extends LSPS2ClientEvent {
		/**
		 * The identifier of the issued bLIP-52 / LSPS2 `get_info` request, as returned by
		 * [`LSPS2ClientHandler::request_opening_params`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS2ClientHandler::request_opening_params`]: crate::lsps2::client::LSPS2ClientHandler::request_opening_params
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP that provided this response.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * The menu of fee parameters the LSP is offering at this time.
		 * You must select one of these if you wish to proceed.
		*/
		public final LSPS2OpeningFeeParams[] opening_fee_params_menu;
		private OpeningParametersReady(long ptr, bindings.LDKLSPS2ClientEvent.OpeningParametersReady obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			long[] opening_fee_params_menu = obj.opening_fee_params_menu;
			int opening_fee_params_menu_conv_23_len = opening_fee_params_menu.length;
			LSPS2OpeningFeeParams[] opening_fee_params_menu_conv_23_arr = new LSPS2OpeningFeeParams[opening_fee_params_menu_conv_23_len];
			for (int x = 0; x < opening_fee_params_menu_conv_23_len; x++) {
				long opening_fee_params_menu_conv_23 = opening_fee_params_menu[x];
				org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params_menu_conv_23_hu_conv = null; if (opening_fee_params_menu_conv_23 < 0 || opening_fee_params_menu_conv_23 > 4096) { opening_fee_params_menu_conv_23_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, opening_fee_params_menu_conv_23); }
				if (opening_fee_params_menu_conv_23_hu_conv != null) { opening_fee_params_menu_conv_23_hu_conv.ptrs_to.add(this); };
				opening_fee_params_menu_conv_23_arr[x] = opening_fee_params_menu_conv_23_hu_conv;
			}
			this.opening_fee_params_menu = opening_fee_params_menu_conv_23_arr;
		}
	}
	/**
	 * Provides the necessary information to generate a payable invoice that then may be given to
	 * the payer.
	 * 
	 * When the invoice is paid, the LSP will open a channel with the previously agreed upon
	 * parameters to you.
	 */
	public final static class InvoiceParametersReady extends LSPS2ClientEvent {
		/**
		 * The identifier of the issued bLIP-52 / LSPS2 `buy` request, as returned by
		 * [`LSPS2ClientHandler::select_opening_params`].
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS2ClientHandler::select_opening_params`]: crate::lsps2::client::LSPS2ClientHandler::select_opening_params
		*/
		public final org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * The intercept short channel id to use in the route hint.
		*/
		public final long intercept_scid;
		/**
		 * The `cltv_expiry_delta` to use in the route hint.
		*/
		public final int cltv_expiry_delta;
		/**
		 * The initial payment size you specified.
		*/
		public final org.ldk.structs.Option_u64Z payment_size_msat;
		private InvoiceParametersReady(long ptr, bindings.LDKLSPS2ClientEvent.InvoiceParametersReady obj) {
			super(null, ptr);
			long request_id = obj.request_id;
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.add(this); };
			this.request_id = request_id_hu_conv;
			this.counterparty_node_id = obj.counterparty_node_id;
			this.intercept_scid = obj.intercept_scid;
			this.cltv_expiry_delta = obj.cltv_expiry_delta;
			long payment_size_msat = obj.payment_size_msat;
			org.ldk.structs.Option_u64Z payment_size_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(payment_size_msat);
			if (payment_size_msat_hu_conv != null) { payment_size_msat_hu_conv.ptrs_to.add(this); };
			this.payment_size_msat = payment_size_msat_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS2ClientEvent_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ClientEvent
	 */
	public LSPS2ClientEvent clone() {
		long ret = bindings.LSPS2ClientEvent_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientEvent ret_hu_conv = org.ldk.structs.LSPS2ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OpeningParametersReady-variant LSPS2ClientEvent
	 */
	public static LSPS2ClientEvent opening_parameters_ready(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, LSPS2OpeningFeeParams[] opening_fee_params_menu) {
		long ret = bindings.LSPS2ClientEvent_opening_parameters_ready(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), opening_fee_params_menu != null ? Arrays.stream(opening_fee_params_menu).mapToLong(opening_fee_params_menu_conv_23 -> opening_fee_params_menu_conv_23.ptr).toArray() : null);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(opening_fee_params_menu);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientEvent ret_hu_conv = org.ldk.structs.LSPS2ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoiceParametersReady-variant LSPS2ClientEvent
	 */
	public static LSPS2ClientEvent invoice_parameters_ready(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, long intercept_scid, int cltv_expiry_delta, org.ldk.structs.Option_u64Z payment_size_msat) {
		long ret = bindings.LSPS2ClientEvent_invoice_parameters_ready(request_id.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33), intercept_scid, cltv_expiry_delta, payment_size_msat.ptr);
		Reference.reachabilityFence(request_id);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(intercept_scid);
		Reference.reachabilityFence(cltv_expiry_delta);
		Reference.reachabilityFence(payment_size_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientEvent ret_hu_conv = org.ldk.structs.LSPS2ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2ClientEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS2ClientEvent b) {
		boolean ret = bindings.LSPS2ClientEvent_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2ClientEvent)) return false;
		return this.eq((LSPS2ClientEvent)o);
	}
}
