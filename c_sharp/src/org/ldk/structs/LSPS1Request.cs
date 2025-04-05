using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum that captures all the valid JSON-RPC requests in the bLIP-51 / LSPS1 protocol.
 */
public class LSPS1Request : CommonBase {
	protected LSPS1Request(object _dummy, long ptr) : base(ptr) { }
	~LSPS1Request() {
		if (ptr != 0) { bindings.LSPS1Request_free(ptr); }
	}

	internal static LSPS1Request constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS1Request_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS1Request_GetInfo(ptr);
			case 1: return new LSPS1Request_CreateOrder(ptr);
			case 2: return new LSPS1Request_GetOrder(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS1Request of type GetInfo */
	public class LSPS1Request_GetInfo : LSPS1Request {
		public org.ldk.structs.LSPS1GetInfoRequest get_info;
		internal LSPS1Request_GetInfo(long ptr) : base(null, ptr) {
			long get_info = bindings.LDKLSPS1Request_GetInfo_get_get_info(ptr);
			org.ldk.structs.LSPS1GetInfoRequest get_info_hu_conv = null; if (get_info < 0 || get_info > 4096) { get_info_hu_conv = new org.ldk.structs.LSPS1GetInfoRequest(null, get_info); }
			if (get_info_hu_conv != null) { get_info_hu_conv.ptrs_to.AddLast(this); };
			this.get_info = get_info_hu_conv;
		}
	}
	/** A LSPS1Request of type CreateOrder */
	public class LSPS1Request_CreateOrder : LSPS1Request {
		public org.ldk.structs.LSPS1CreateOrderRequest create_order;
		internal LSPS1Request_CreateOrder(long ptr) : base(null, ptr) {
			long create_order = bindings.LDKLSPS1Request_CreateOrder_get_create_order(ptr);
			org.ldk.structs.LSPS1CreateOrderRequest create_order_hu_conv = null; if (create_order < 0 || create_order > 4096) { create_order_hu_conv = new org.ldk.structs.LSPS1CreateOrderRequest(null, create_order); }
			if (create_order_hu_conv != null) { create_order_hu_conv.ptrs_to.AddLast(this); };
			this.create_order = create_order_hu_conv;
		}
	}
	/** A LSPS1Request of type GetOrder */
	public class LSPS1Request_GetOrder : LSPS1Request {
		public org.ldk.structs.LSPS1GetOrderRequest get_order;
		internal LSPS1Request_GetOrder(long ptr) : base(null, ptr) {
			long get_order = bindings.LDKLSPS1Request_GetOrder_get_get_order(ptr);
			org.ldk.structs.LSPS1GetOrderRequest get_order_hu_conv = null; if (get_order < 0 || get_order > 4096) { get_order_hu_conv = new org.ldk.structs.LSPS1GetOrderRequest(null, get_order); }
			if (get_order_hu_conv != null) { get_order_hu_conv.ptrs_to.AddLast(this); };
			this.get_order = get_order_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS1Request_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Request
	 */
	public org.ldk.structs.LSPS1Request clone() {
		long ret = bindings.LSPS1Request_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS1Request
	 */
	public static org.ldk.structs.LSPS1Request get_info(org.ldk.structs.LSPS1GetInfoRequest a) {
		long ret = bindings.LSPS1Request_get_info(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CreateOrder-variant LSPS1Request
	 */
	public static org.ldk.structs.LSPS1Request create_order(org.ldk.structs.LSPS1CreateOrderRequest a) {
		long ret = bindings.LSPS1Request_create_order(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetOrder-variant LSPS1Request
	 */
	public static org.ldk.structs.LSPS1Request get_order(org.ldk.structs.LSPS1GetOrderRequest a) {
		long ret = bindings.LSPS1Request_get_order(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Request ret_hu_conv = org.ldk.structs.LSPS1Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Requests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS1Request b) {
		bool ret = bindings.LSPS1Request_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1Request)) return false;
		return this.eq((LSPS1Request)o);
	}
}
} } }
