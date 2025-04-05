using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An event which an LSPS2 client should take some action in response to.
 */
public class LSPS2ClientEvent : CommonBase {
	protected LSPS2ClientEvent(object _dummy, long ptr) : base(ptr) { }
	~LSPS2ClientEvent() {
		if (ptr != 0) { bindings.LSPS2ClientEvent_free(ptr); }
	}

	internal static LSPS2ClientEvent constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS2ClientEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS2ClientEvent_OpeningParametersReady(ptr);
			case 1: return new LSPS2ClientEvent_InvoiceParametersReady(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS2ClientEvent of type OpeningParametersReady */
	public class LSPS2ClientEvent_OpeningParametersReady : LSPS2ClientEvent {
		/**
		 * The identifier of the issued bLIP-52 / LSPS2 `get_info` request, as returned by
		 * [`LSPS2ClientHandler::request_opening_params`]
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS2ClientHandler::request_opening_params`]: crate::lsps2::client::LSPS2ClientHandler::request_opening_params
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP that provided this response.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The menu of fee parameters the LSP is offering at this time.
		 * You must select one of these if you wish to proceed.
		 */
		public LSPS2OpeningFeeParams[] opening_fee_params_menu;
		internal LSPS2ClientEvent_OpeningParametersReady(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS2ClientEvent_OpeningParametersReady_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS2ClientEvent_OpeningParametersReady_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long opening_fee_params_menu = bindings.LDKLSPS2ClientEvent_OpeningParametersReady_get_opening_fee_params_menu(ptr);
			int opening_fee_params_menu_conv_23_len = InternalUtils.getArrayLength(opening_fee_params_menu);
			LSPS2OpeningFeeParams[] opening_fee_params_menu_conv_23_arr = new LSPS2OpeningFeeParams[opening_fee_params_menu_conv_23_len];
			for (int x = 0; x < opening_fee_params_menu_conv_23_len; x++) {
				long opening_fee_params_menu_conv_23 = InternalUtils.getU64ArrayElem(opening_fee_params_menu, x);
				org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params_menu_conv_23_hu_conv = null; if (opening_fee_params_menu_conv_23 < 0 || opening_fee_params_menu_conv_23 > 4096) { opening_fee_params_menu_conv_23_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, opening_fee_params_menu_conv_23); }
				if (opening_fee_params_menu_conv_23_hu_conv != null) { opening_fee_params_menu_conv_23_hu_conv.ptrs_to.AddLast(this); };
				opening_fee_params_menu_conv_23_arr[x] = opening_fee_params_menu_conv_23_hu_conv;
			}
			bindings.free_buffer(opening_fee_params_menu);
			this.opening_fee_params_menu = opening_fee_params_menu_conv_23_arr;
		}
	}
	/** A LSPS2ClientEvent of type InvoiceParametersReady */
	public class LSPS2ClientEvent_InvoiceParametersReady : LSPS2ClientEvent {
		/**
		 * The identifier of the issued bLIP-52 / LSPS2 `buy` request, as returned by
		 * [`LSPS2ClientHandler::select_opening_params`].
		 * 
		 * This can be used to track which request this event corresponds to.
		 * 
		 * [`LSPS2ClientHandler::select_opening_params`]: crate::lsps2::client::LSPS2ClientHandler::select_opening_params
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the LSP.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The intercept short channel id to use in the route hint.
		 */
		public long intercept_scid;
		/**
		 * The `cltv_expiry_delta` to use in the route hint.
		 */
		public int cltv_expiry_delta;
		/**
		 * The initial payment size you specified.
		 */
		public org.ldk.structs.Option_u64Z payment_size_msat;
		internal LSPS2ClientEvent_InvoiceParametersReady(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS2ClientEvent_InvoiceParametersReady_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS2ClientEvent_InvoiceParametersReady_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			this.intercept_scid = bindings.LDKLSPS2ClientEvent_InvoiceParametersReady_get_intercept_scid(ptr);
			this.cltv_expiry_delta = bindings.LDKLSPS2ClientEvent_InvoiceParametersReady_get_cltv_expiry_delta(ptr);
			long payment_size_msat = bindings.LDKLSPS2ClientEvent_InvoiceParametersReady_get_payment_size_msat(ptr);
			org.ldk.structs.Option_u64Z payment_size_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(payment_size_msat);
			if (payment_size_msat_hu_conv != null) { payment_size_msat_hu_conv.ptrs_to.AddLast(this); };
			this.payment_size_msat = payment_size_msat_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS2ClientEvent_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ClientEvent
	 */
	public org.ldk.structs.LSPS2ClientEvent clone() {
		long ret = bindings.LSPS2ClientEvent_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientEvent ret_hu_conv = org.ldk.structs.LSPS2ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OpeningParametersReady-variant LSPS2ClientEvent
	 */
	public static org.ldk.structs.LSPS2ClientEvent opening_parameters_ready(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, LSPS2OpeningFeeParams[] opening_fee_params_menu) {
		long ret = bindings.LSPS2ClientEvent_opening_parameters_ready(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(opening_fee_params_menu, opening_fee_params_menu_conv_23 => opening_fee_params_menu_conv_23.ptr)));
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(opening_fee_params_menu);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientEvent ret_hu_conv = org.ldk.structs.LSPS2ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoiceParametersReady-variant LSPS2ClientEvent
	 */
	public static org.ldk.structs.LSPS2ClientEvent invoice_parameters_ready(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, long intercept_scid, int cltv_expiry_delta, org.ldk.structs.Option_u64Z payment_size_msat) {
		long ret = bindings.LSPS2ClientEvent_invoice_parameters_ready(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), intercept_scid, cltv_expiry_delta, payment_size_msat.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(intercept_scid);
		GC.KeepAlive(cltv_expiry_delta);
		GC.KeepAlive(payment_size_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ClientEvent ret_hu_conv = org.ldk.structs.LSPS2ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2ClientEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS2ClientEvent b) {
		bool ret = bindings.LSPS2ClientEvent_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2ClientEvent)) return false;
		return this.eq((LSPS2ClientEvent)o);
	}
}
} } }
