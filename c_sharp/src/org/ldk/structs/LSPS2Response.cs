using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum that captures all the valid JSON-RPC responses in the bLIP-52 / LSPS2 protocol.
 */
public class LSPS2Response : CommonBase {
	protected LSPS2Response(object _dummy, long ptr) : base(ptr) { }
	~LSPS2Response() {
		if (ptr != 0) { bindings.LSPS2Response_free(ptr); }
	}

	internal static LSPS2Response constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS2Response_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS2Response_GetInfo(ptr);
			case 1: return new LSPS2Response_GetInfoError(ptr);
			case 2: return new LSPS2Response_Buy(ptr);
			case 3: return new LSPS2Response_BuyError(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS2Response of type GetInfo */
	public class LSPS2Response_GetInfo : LSPS2Response {
		public org.ldk.structs.LSPS2GetInfoResponse get_info;
		internal LSPS2Response_GetInfo(long ptr) : base(null, ptr) {
			long get_info = bindings.LDKLSPS2Response_GetInfo_get_get_info(ptr);
			org.ldk.structs.LSPS2GetInfoResponse get_info_hu_conv = null; if (get_info < 0 || get_info > 4096) { get_info_hu_conv = new org.ldk.structs.LSPS2GetInfoResponse(null, get_info); }
			if (get_info_hu_conv != null) { get_info_hu_conv.ptrs_to.AddLast(this); };
			this.get_info = get_info_hu_conv;
		}
	}
	/** A LSPS2Response of type GetInfoError */
	public class LSPS2Response_GetInfoError : LSPS2Response {
		public org.ldk.structs.LSPSResponseError get_info_error;
		internal LSPS2Response_GetInfoError(long ptr) : base(null, ptr) {
			long get_info_error = bindings.LDKLSPS2Response_GetInfoError_get_get_info_error(ptr);
			org.ldk.structs.LSPSResponseError get_info_error_hu_conv = null; if (get_info_error < 0 || get_info_error > 4096) { get_info_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, get_info_error); }
			if (get_info_error_hu_conv != null) { get_info_error_hu_conv.ptrs_to.AddLast(this); };
			this.get_info_error = get_info_error_hu_conv;
		}
	}
	/** A LSPS2Response of type Buy */
	public class LSPS2Response_Buy : LSPS2Response {
		public org.ldk.structs.LSPS2BuyResponse buy;
		internal LSPS2Response_Buy(long ptr) : base(null, ptr) {
			long buy = bindings.LDKLSPS2Response_Buy_get_buy(ptr);
			org.ldk.structs.LSPS2BuyResponse buy_hu_conv = null; if (buy < 0 || buy > 4096) { buy_hu_conv = new org.ldk.structs.LSPS2BuyResponse(null, buy); }
			if (buy_hu_conv != null) { buy_hu_conv.ptrs_to.AddLast(this); };
			this.buy = buy_hu_conv;
		}
	}
	/** A LSPS2Response of type BuyError */
	public class LSPS2Response_BuyError : LSPS2Response {
		public org.ldk.structs.LSPSResponseError buy_error;
		internal LSPS2Response_BuyError(long ptr) : base(null, ptr) {
			long buy_error = bindings.LDKLSPS2Response_BuyError_get_buy_error(ptr);
			org.ldk.structs.LSPSResponseError buy_error_hu_conv = null; if (buy_error < 0 || buy_error > 4096) { buy_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, buy_error); }
			if (buy_error_hu_conv != null) { buy_error_hu_conv.ptrs_to.AddLast(this); };
			this.buy_error = buy_error_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS2Response_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2Response
	 */
	public org.ldk.structs.LSPS2Response clone() {
		long ret = bindings.LSPS2Response_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS2Response
	 */
	public static org.ldk.structs.LSPS2Response get_info(org.ldk.structs.LSPS2GetInfoResponse a) {
		long ret = bindings.LSPS2Response_get_info(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfoError-variant LSPS2Response
	 */
	public static org.ldk.structs.LSPS2Response get_info_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS2Response_get_info_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Buy-variant LSPS2Response
	 */
	public static org.ldk.structs.LSPS2Response buy(org.ldk.structs.LSPS2BuyResponse a) {
		long ret = bindings.LSPS2Response_buy(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BuyError-variant LSPS2Response
	 */
	public static org.ldk.structs.LSPS2Response buy_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS2Response_buy_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2Responses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS2Response b) {
		bool ret = bindings.LSPS2Response_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2Response)) return false;
		return this.eq((LSPS2Response)o);
	}
}
} } }
