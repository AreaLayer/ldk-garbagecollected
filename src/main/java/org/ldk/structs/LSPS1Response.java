package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum that captures all the valid JSON-RPC responses in the bLIP-51 / LSPS1 protocol.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1Response extends CommonBase {
	private LSPS1Response(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1Response_free(ptr); }
	}
	static LSPS1Response constr_from_ptr(long ptr) {
		bindings.LDKLSPS1Response raw_val = bindings.LDKLSPS1Response_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS1Response.GetInfo.class) {
			return new GetInfo(ptr, (bindings.LDKLSPS1Response.GetInfo)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1Response.GetInfoError.class) {
			return new GetInfoError(ptr, (bindings.LDKLSPS1Response.GetInfoError)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1Response.CreateOrder.class) {
			return new CreateOrder(ptr, (bindings.LDKLSPS1Response.CreateOrder)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1Response.CreateOrderError.class) {
			return new CreateOrderError(ptr, (bindings.LDKLSPS1Response.CreateOrderError)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1Response.GetOrder.class) {
			return new GetOrder(ptr, (bindings.LDKLSPS1Response.GetOrder)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1Response.GetOrderError.class) {
			return new GetOrderError(ptr, (bindings.LDKLSPS1Response.GetOrderError)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A successful response to a [`LSPS1GetInfoRequest`].
	 */
	public final static class GetInfo extends LSPS1Response {
		public final org.ldk.structs.LSPS1GetInfoResponse get_info;
		private GetInfo(long ptr, bindings.LDKLSPS1Response.GetInfo obj) {
			super(null, ptr);
			long get_info = obj.get_info;
			org.ldk.structs.LSPS1GetInfoResponse get_info_hu_conv = null; if (get_info < 0 || get_info > 4096) { get_info_hu_conv = new org.ldk.structs.LSPS1GetInfoResponse(null, get_info); }
			if (get_info_hu_conv != null) { get_info_hu_conv.ptrs_to.add(this); };
			this.get_info = get_info_hu_conv;
		}
	}
	/**
	 * An error response to a [`LSPS1GetInfoRequest`].
	 */
	public final static class GetInfoError extends LSPS1Response {
		public final org.ldk.structs.LSPSResponseError get_info_error;
		private GetInfoError(long ptr, bindings.LDKLSPS1Response.GetInfoError obj) {
			super(null, ptr);
			long get_info_error = obj.get_info_error;
			org.ldk.structs.LSPSResponseError get_info_error_hu_conv = null; if (get_info_error < 0 || get_info_error > 4096) { get_info_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, get_info_error); }
			if (get_info_error_hu_conv != null) { get_info_error_hu_conv.ptrs_to.add(this); };
			this.get_info_error = get_info_error_hu_conv;
		}
	}
	/**
	 * A successful response to a [`LSPS1CreateOrderRequest`].
	 */
	public final static class CreateOrder extends LSPS1Response {
		public final org.ldk.structs.LSPS1CreateOrderResponse create_order;
		private CreateOrder(long ptr, bindings.LDKLSPS1Response.CreateOrder obj) {
			super(null, ptr);
			long create_order = obj.create_order;
			org.ldk.structs.LSPS1CreateOrderResponse create_order_hu_conv = null; if (create_order < 0 || create_order > 4096) { create_order_hu_conv = new org.ldk.structs.LSPS1CreateOrderResponse(null, create_order); }
			if (create_order_hu_conv != null) { create_order_hu_conv.ptrs_to.add(this); };
			this.create_order = create_order_hu_conv;
		}
	}
	/**
	 * An error response to a [`LSPS1CreateOrderRequest`].
	 */
	public final static class CreateOrderError extends LSPS1Response {
		public final org.ldk.structs.LSPSResponseError create_order_error;
		private CreateOrderError(long ptr, bindings.LDKLSPS1Response.CreateOrderError obj) {
			super(null, ptr);
			long create_order_error = obj.create_order_error;
			org.ldk.structs.LSPSResponseError create_order_error_hu_conv = null; if (create_order_error < 0 || create_order_error > 4096) { create_order_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, create_order_error); }
			if (create_order_error_hu_conv != null) { create_order_error_hu_conv.ptrs_to.add(this); };
			this.create_order_error = create_order_error_hu_conv;
		}
	}
	/**
	 * A successful response to a [`LSPS1GetOrderRequest`].
	 */
	public final static class GetOrder extends LSPS1Response {
		public final org.ldk.structs.LSPS1CreateOrderResponse get_order;
		private GetOrder(long ptr, bindings.LDKLSPS1Response.GetOrder obj) {
			super(null, ptr);
			long get_order = obj.get_order;
			org.ldk.structs.LSPS1CreateOrderResponse get_order_hu_conv = null; if (get_order < 0 || get_order > 4096) { get_order_hu_conv = new org.ldk.structs.LSPS1CreateOrderResponse(null, get_order); }
			if (get_order_hu_conv != null) { get_order_hu_conv.ptrs_to.add(this); };
			this.get_order = get_order_hu_conv;
		}
	}
	/**
	 * An error response to a [`LSPS1GetOrderRequest`].
	 */
	public final static class GetOrderError extends LSPS1Response {
		public final org.ldk.structs.LSPSResponseError get_order_error;
		private GetOrderError(long ptr, bindings.LDKLSPS1Response.GetOrderError obj) {
			super(null, ptr);
			long get_order_error = obj.get_order_error;
			org.ldk.structs.LSPSResponseError get_order_error_hu_conv = null; if (get_order_error < 0 || get_order_error > 4096) { get_order_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, get_order_error); }
			if (get_order_error_hu_conv != null) { get_order_error_hu_conv.ptrs_to.add(this); };
			this.get_order_error = get_order_error_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS1Response_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Response
	 */
	public LSPS1Response clone() {
		long ret = bindings.LSPS1Response_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS1Response
	 */
	public static LSPS1Response get_info(org.ldk.structs.LSPS1GetInfoResponse a) {
		long ret = bindings.LSPS1Response_get_info(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfoError-variant LSPS1Response
	 */
	public static LSPS1Response get_info_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS1Response_get_info_error(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CreateOrder-variant LSPS1Response
	 */
	public static LSPS1Response create_order(org.ldk.structs.LSPS1CreateOrderResponse a) {
		long ret = bindings.LSPS1Response_create_order(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CreateOrderError-variant LSPS1Response
	 */
	public static LSPS1Response create_order_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS1Response_create_order_error(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetOrder-variant LSPS1Response
	 */
	public static LSPS1Response get_order(org.ldk.structs.LSPS1CreateOrderResponse a) {
		long ret = bindings.LSPS1Response_get_order(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetOrderError-variant LSPS1Response
	 */
	public static LSPS1Response get_order_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS1Response_get_order_error(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Responses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS1Response b) {
		boolean ret = bindings.LSPS1Response_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1Response)) return false;
		return this.eq((LSPS1Response)o);
	}
}
