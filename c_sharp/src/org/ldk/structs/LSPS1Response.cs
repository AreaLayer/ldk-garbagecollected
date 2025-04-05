using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum that captures all the valid JSON-RPC responses in the bLIP-51 / LSPS1 protocol.
 */
public class LSPS1Response : CommonBase {
	protected LSPS1Response(object _dummy, long ptr) : base(ptr) { }
	~LSPS1Response() {
		if (ptr != 0) { bindings.LSPS1Response_free(ptr); }
	}

	internal static LSPS1Response constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS1Response_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS1Response_GetInfo(ptr);
			case 1: return new LSPS1Response_GetInfoError(ptr);
			case 2: return new LSPS1Response_CreateOrder(ptr);
			case 3: return new LSPS1Response_CreateOrderError(ptr);
			case 4: return new LSPS1Response_GetOrder(ptr);
			case 5: return new LSPS1Response_GetOrderError(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS1Response of type GetInfo */
	public class LSPS1Response_GetInfo : LSPS1Response {
		public org.ldk.structs.LSPS1GetInfoResponse get_info;
		internal LSPS1Response_GetInfo(long ptr) : base(null, ptr) {
			long get_info = bindings.LDKLSPS1Response_GetInfo_get_get_info(ptr);
			org.ldk.structs.LSPS1GetInfoResponse get_info_hu_conv = null; if (get_info < 0 || get_info > 4096) { get_info_hu_conv = new org.ldk.structs.LSPS1GetInfoResponse(null, get_info); }
			if (get_info_hu_conv != null) { get_info_hu_conv.ptrs_to.AddLast(this); };
			this.get_info = get_info_hu_conv;
		}
	}
	/** A LSPS1Response of type GetInfoError */
	public class LSPS1Response_GetInfoError : LSPS1Response {
		public org.ldk.structs.LSPSResponseError get_info_error;
		internal LSPS1Response_GetInfoError(long ptr) : base(null, ptr) {
			long get_info_error = bindings.LDKLSPS1Response_GetInfoError_get_get_info_error(ptr);
			org.ldk.structs.LSPSResponseError get_info_error_hu_conv = null; if (get_info_error < 0 || get_info_error > 4096) { get_info_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, get_info_error); }
			if (get_info_error_hu_conv != null) { get_info_error_hu_conv.ptrs_to.AddLast(this); };
			this.get_info_error = get_info_error_hu_conv;
		}
	}
	/** A LSPS1Response of type CreateOrder */
	public class LSPS1Response_CreateOrder : LSPS1Response {
		public org.ldk.structs.LSPS1CreateOrderResponse create_order;
		internal LSPS1Response_CreateOrder(long ptr) : base(null, ptr) {
			long create_order = bindings.LDKLSPS1Response_CreateOrder_get_create_order(ptr);
			org.ldk.structs.LSPS1CreateOrderResponse create_order_hu_conv = null; if (create_order < 0 || create_order > 4096) { create_order_hu_conv = new org.ldk.structs.LSPS1CreateOrderResponse(null, create_order); }
			if (create_order_hu_conv != null) { create_order_hu_conv.ptrs_to.AddLast(this); };
			this.create_order = create_order_hu_conv;
		}
	}
	/** A LSPS1Response of type CreateOrderError */
	public class LSPS1Response_CreateOrderError : LSPS1Response {
		public org.ldk.structs.LSPSResponseError create_order_error;
		internal LSPS1Response_CreateOrderError(long ptr) : base(null, ptr) {
			long create_order_error = bindings.LDKLSPS1Response_CreateOrderError_get_create_order_error(ptr);
			org.ldk.structs.LSPSResponseError create_order_error_hu_conv = null; if (create_order_error < 0 || create_order_error > 4096) { create_order_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, create_order_error); }
			if (create_order_error_hu_conv != null) { create_order_error_hu_conv.ptrs_to.AddLast(this); };
			this.create_order_error = create_order_error_hu_conv;
		}
	}
	/** A LSPS1Response of type GetOrder */
	public class LSPS1Response_GetOrder : LSPS1Response {
		public org.ldk.structs.LSPS1CreateOrderResponse get_order;
		internal LSPS1Response_GetOrder(long ptr) : base(null, ptr) {
			long get_order = bindings.LDKLSPS1Response_GetOrder_get_get_order(ptr);
			org.ldk.structs.LSPS1CreateOrderResponse get_order_hu_conv = null; if (get_order < 0 || get_order > 4096) { get_order_hu_conv = new org.ldk.structs.LSPS1CreateOrderResponse(null, get_order); }
			if (get_order_hu_conv != null) { get_order_hu_conv.ptrs_to.AddLast(this); };
			this.get_order = get_order_hu_conv;
		}
	}
	/** A LSPS1Response of type GetOrderError */
	public class LSPS1Response_GetOrderError : LSPS1Response {
		public org.ldk.structs.LSPSResponseError get_order_error;
		internal LSPS1Response_GetOrderError(long ptr) : base(null, ptr) {
			long get_order_error = bindings.LDKLSPS1Response_GetOrderError_get_get_order_error(ptr);
			org.ldk.structs.LSPSResponseError get_order_error_hu_conv = null; if (get_order_error < 0 || get_order_error > 4096) { get_order_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, get_order_error); }
			if (get_order_error_hu_conv != null) { get_order_error_hu_conv.ptrs_to.AddLast(this); };
			this.get_order_error = get_order_error_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS1Response_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Response
	 */
	public org.ldk.structs.LSPS1Response clone() {
		long ret = bindings.LSPS1Response_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS1Response
	 */
	public static org.ldk.structs.LSPS1Response get_info(org.ldk.structs.LSPS1GetInfoResponse a) {
		long ret = bindings.LSPS1Response_get_info(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfoError-variant LSPS1Response
	 */
	public static org.ldk.structs.LSPS1Response get_info_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS1Response_get_info_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CreateOrder-variant LSPS1Response
	 */
	public static org.ldk.structs.LSPS1Response create_order(org.ldk.structs.LSPS1CreateOrderResponse a) {
		long ret = bindings.LSPS1Response_create_order(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CreateOrderError-variant LSPS1Response
	 */
	public static org.ldk.structs.LSPS1Response create_order_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS1Response_create_order_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetOrder-variant LSPS1Response
	 */
	public static org.ldk.structs.LSPS1Response get_order(org.ldk.structs.LSPS1CreateOrderResponse a) {
		long ret = bindings.LSPS1Response_get_order(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetOrderError-variant LSPS1Response
	 */
	public static org.ldk.structs.LSPS1Response get_order_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS1Response_get_order_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Response ret_hu_conv = org.ldk.structs.LSPS1Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Responses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS1Response b) {
		bool ret = bindings.LSPS1Response_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1Response)) return false;
		return this.eq((LSPS1Response)o);
	}
}
} } }
