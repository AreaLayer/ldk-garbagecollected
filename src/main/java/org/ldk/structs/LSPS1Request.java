package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum that captures all the valid JSON-RPC requests in the bLIP-51 / LSPS1 protocol.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1Request extends CommonBase {
	private LSPS1Request(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1Request_free(ptr); }
	}
	static LSPS1Request constr_from_ptr(long ptr) {
		bindings.LDKLSPS1Request raw_val = bindings.LDKLSPS1Request_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS1Request.GetInfo.class) {
			return new GetInfo(ptr, (bindings.LDKLSPS1Request.GetInfo)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1Request.CreateOrder.class) {
			return new CreateOrder(ptr, (bindings.LDKLSPS1Request.CreateOrder)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS1Request.GetOrder.class) {
			return new GetOrder(ptr, (bindings.LDKLSPS1Request.GetOrder)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A request to learn about the options supported by the LSP.
	 */
	public final static class GetInfo extends LSPS1Request {
		public final org.ldk.structs.LSPS1GetInfoRequest get_info;
		private GetInfo(long ptr, bindings.LDKLSPS1Request.GetInfo obj) {
			super(null, ptr);
			long get_info = obj.get_info;
			org.ldk.structs.LSPS1GetInfoRequest get_info_hu_conv = null; if (get_info < 0 || get_info > 4096) { get_info_hu_conv = new org.ldk.structs.LSPS1GetInfoRequest(null, get_info); }
			if (get_info_hu_conv != null) { get_info_hu_conv.ptrs_to.add(this); };
			this.get_info = get_info_hu_conv;
		}
	}
	/**
	 * A request to create a channel order.
	 */
	public final static class CreateOrder extends LSPS1Request {
		public final org.ldk.structs.LSPS1CreateOrderRequest create_order;
		private CreateOrder(long ptr, bindings.LDKLSPS1Request.CreateOrder obj) {
			super(null, ptr);
			long create_order = obj.create_order;
			org.ldk.structs.LSPS1CreateOrderRequest create_order_hu_conv = null; if (create_order < 0 || create_order > 4096) { create_order_hu_conv = new org.ldk.structs.LSPS1CreateOrderRequest(null, create_order); }
			if (create_order_hu_conv != null) { create_order_hu_conv.ptrs_to.add(this); };
			this.create_order = create_order_hu_conv;
		}
	}
	/**
	 * A request to query a previously created channel order.
	 */
	public final static class GetOrder extends LSPS1Request {
		public final org.ldk.structs.LSPS1GetOrderRequest get_order;
		private GetOrder(long ptr, bindings.LDKLSPS1Request.GetOrder obj) {
			super(null, ptr);
			long get_order = obj.get_order;
			org.ldk.structs.LSPS1GetOrderRequest get_order_hu_conv = null; if (get_order < 0 || get_order > 4096) { get_order_hu_conv = new org.ldk.structs.LSPS1GetOrderRequest(null, get_order); }
			if (get_order_hu_conv != null) { get_order_hu_conv.ptrs_to.add(this); };
			this.get_order = get_order_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS1Request_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Request
	 */
	public LSPS1Request clone() {
		long ret = bindings.LSPS1Request_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS1Request
	 */
	public static LSPS1Request get_info(org.ldk.structs.LSPS1GetInfoRequest a) {
		long ret = bindings.LSPS1Request_get_info(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CreateOrder-variant LSPS1Request
	 */
	public static LSPS1Request create_order(org.ldk.structs.LSPS1CreateOrderRequest a) {
		long ret = bindings.LSPS1Request_create_order(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetOrder-variant LSPS1Request
	 */
	public static LSPS1Request get_order(org.ldk.structs.LSPS1GetOrderRequest a) {
		long ret = bindings.LSPS1Request_get_order(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Requests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS1Request b) {
		boolean ret = bindings.LSPS1Request_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1Request)) return false;
		return this.eq((LSPS1Request)o);
	}
}
