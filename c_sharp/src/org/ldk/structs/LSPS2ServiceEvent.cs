using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An event which an bLIP-52 / LSPS2 server should take some action in response to.
 */
public class LSPS2ServiceEvent : CommonBase {
	protected LSPS2ServiceEvent(object _dummy, long ptr) : base(ptr) { }
	~LSPS2ServiceEvent() {
		if (ptr != 0) { bindings.LSPS2ServiceEvent_free(ptr); }
	}

	internal static LSPS2ServiceEvent constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS2ServiceEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS2ServiceEvent_GetInfo(ptr);
			case 1: return new LSPS2ServiceEvent_BuyRequest(ptr);
			case 2: return new LSPS2ServiceEvent_OpenChannel(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS2ServiceEvent of type GetInfo */
	public class LSPS2ServiceEvent_GetInfo : LSPS2ServiceEvent {
		/**
		 * An identifier that must be passed to [`LSPS2ServiceHandler::opening_fee_params_generated`].
		 * 
		 * [`LSPS2ServiceHandler::opening_fee_params_generated`]: crate::lsps2::service::LSPS2ServiceHandler::opening_fee_params_generated
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The node id of the client making the information request.
		 */
		public byte[] counterparty_node_id;
		/**
		 * An optional token that can be used as an API key, coupon code, etc.
		 */
		public org.ldk.structs.Option_StrZ token;
		internal LSPS2ServiceEvent_GetInfo(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS2ServiceEvent_GetInfo_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS2ServiceEvent_GetInfo_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long token = bindings.LDKLSPS2ServiceEvent_GetInfo_get_token(ptr);
			org.ldk.structs.Option_StrZ token_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(token);
			if (token_hu_conv != null) { token_hu_conv.ptrs_to.AddLast(this); };
			this.token = token_hu_conv;
		}
	}
	/** A LSPS2ServiceEvent of type BuyRequest */
	public class LSPS2ServiceEvent_BuyRequest : LSPS2ServiceEvent {
		/**
		 * An identifier that must be passed into [`LSPS2ServiceHandler::invoice_parameters_generated`].
		 * 
		 * [`LSPS2ServiceHandler::invoice_parameters_generated`]: crate::lsps2::service::LSPS2ServiceHandler::invoice_parameters_generated
		 */
		public org.ldk.structs.LSPSRequestId request_id;
		/**
		 * The client node id that is making this request.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The channel parameters they have selected.
		 */
		public org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params;
		/**
		 * The size of the initial payment they would like to receive.
		 */
		public org.ldk.structs.Option_u64Z payment_size_msat;
		internal LSPS2ServiceEvent_BuyRequest(long ptr) : base(null, ptr) {
			long request_id = bindings.LDKLSPS2ServiceEvent_BuyRequest_get_request_id(ptr);
			org.ldk.structs.LSPSRequestId request_id_hu_conv = null; if (request_id < 0 || request_id > 4096) { request_id_hu_conv = new org.ldk.structs.LSPSRequestId(null, request_id); }
			if (request_id_hu_conv != null) { request_id_hu_conv.ptrs_to.AddLast(this); };
			this.request_id = request_id_hu_conv;
			long counterparty_node_id = bindings.LDKLSPS2ServiceEvent_BuyRequest_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long opening_fee_params = bindings.LDKLSPS2ServiceEvent_BuyRequest_get_opening_fee_params(ptr);
			org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params_hu_conv = null; if (opening_fee_params < 0 || opening_fee_params > 4096) { opening_fee_params_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, opening_fee_params); }
			if (opening_fee_params_hu_conv != null) { opening_fee_params_hu_conv.ptrs_to.AddLast(this); };
			this.opening_fee_params = opening_fee_params_hu_conv;
			long payment_size_msat = bindings.LDKLSPS2ServiceEvent_BuyRequest_get_payment_size_msat(ptr);
			org.ldk.structs.Option_u64Z payment_size_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(payment_size_msat);
			if (payment_size_msat_hu_conv != null) { payment_size_msat_hu_conv.ptrs_to.AddLast(this); };
			this.payment_size_msat = payment_size_msat_hu_conv;
		}
	}
	/** A LSPS2ServiceEvent of type OpenChannel */
	public class LSPS2ServiceEvent_OpenChannel : LSPS2ServiceEvent {
		/**
		 * The node to open channel with.
		 */
		public byte[] their_network_key;
		/**
		 * The amount to forward after fees.
		 */
		public long amt_to_forward_msat;
		/**
		 * The fee earned for opening the channel.
		 */
		public long opening_fee_msat;
		/**
		 * A user specified id used to track channel open.
		 */
		public org.ldk.util.UInt128 user_channel_id;
		/**
		 * The intercept short channel id to use in the route hint.
		 */
		public long intercept_scid;
		internal LSPS2ServiceEvent_OpenChannel(long ptr) : base(null, ptr) {
			long their_network_key = bindings.LDKLSPS2ServiceEvent_OpenChannel_get_their_network_key(ptr);
			byte[] their_network_key_conv = InternalUtils.decodeUint8Array(their_network_key);
			this.their_network_key = their_network_key_conv;
			this.amt_to_forward_msat = bindings.LDKLSPS2ServiceEvent_OpenChannel_get_amt_to_forward_msat(ptr);
			this.opening_fee_msat = bindings.LDKLSPS2ServiceEvent_OpenChannel_get_opening_fee_msat(ptr);
			long user_channel_id = bindings.LDKLSPS2ServiceEvent_OpenChannel_get_user_channel_id(ptr);
			org.ldk.util.UInt128 user_channel_id_conv = new org.ldk.util.UInt128(user_channel_id);
			bindings.free_buffer(user_channel_id);
			this.user_channel_id = user_channel_id_conv;
			this.intercept_scid = bindings.LDKLSPS2ServiceEvent_OpenChannel_get_intercept_scid(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS2ServiceEvent_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2ServiceEvent
	 */
	public org.ldk.structs.LSPS2ServiceEvent clone() {
		long ret = bindings.LSPS2ServiceEvent_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS2ServiceEvent
	 */
	public static org.ldk.structs.LSPS2ServiceEvent get_info(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.Option_StrZ token) {
		long ret = bindings.LSPS2ServiceEvent_get_info(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), token.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(token);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BuyRequest-variant LSPS2ServiceEvent
	 */
	public static org.ldk.structs.LSPS2ServiceEvent buy_request(org.ldk.structs.LSPSRequestId request_id, byte[] counterparty_node_id, org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params, org.ldk.structs.Option_u64Z payment_size_msat) {
		long ret = bindings.LSPS2ServiceEvent_buy_request(request_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), opening_fee_params.ptr, payment_size_msat.ptr);
		GC.KeepAlive(request_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(opening_fee_params);
		GC.KeepAlive(payment_size_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OpenChannel-variant LSPS2ServiceEvent
	 */
	public static org.ldk.structs.LSPS2ServiceEvent open_channel(byte[] their_network_key, long amt_to_forward_msat, long opening_fee_msat, org.ldk.util.UInt128 user_channel_id, long intercept_scid) {
		long ret = bindings.LSPS2ServiceEvent_open_channel(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(their_network_key, 33)), amt_to_forward_msat, opening_fee_msat, InternalUtils.encodeUint8Array(user_channel_id.getLEBytes()), intercept_scid);
		GC.KeepAlive(their_network_key);
		GC.KeepAlive(amt_to_forward_msat);
		GC.KeepAlive(opening_fee_msat);
		GC.KeepAlive(user_channel_id);
		GC.KeepAlive(intercept_scid);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2ServiceEvent ret_hu_conv = org.ldk.structs.LSPS2ServiceEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2ServiceEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS2ServiceEvent b) {
		bool ret = bindings.LSPS2ServiceEvent_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2ServiceEvent)) return false;
		return this.eq((LSPS2ServiceEvent)o);
	}
}
} } }
