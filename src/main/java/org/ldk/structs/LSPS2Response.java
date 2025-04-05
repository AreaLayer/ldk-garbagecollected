package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum that captures all the valid JSON-RPC responses in the bLIP-52 / LSPS2 protocol.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2Response extends CommonBase {
	private LSPS2Response(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2Response_free(ptr); }
	}
	static LSPS2Response constr_from_ptr(long ptr) {
		bindings.LDKLSPS2Response raw_val = bindings.LDKLSPS2Response_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS2Response.GetInfo.class) {
			return new GetInfo(ptr, (bindings.LDKLSPS2Response.GetInfo)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2Response.GetInfoError.class) {
			return new GetInfoError(ptr, (bindings.LDKLSPS2Response.GetInfoError)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2Response.Buy.class) {
			return new Buy(ptr, (bindings.LDKLSPS2Response.Buy)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2Response.BuyError.class) {
			return new BuyError(ptr, (bindings.LDKLSPS2Response.BuyError)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A successful response to a [`LSPS2Request::GetInfo`] request.
	 */
	public final static class GetInfo extends LSPS2Response {
		public final org.ldk.structs.LSPS2GetInfoResponse get_info;
		private GetInfo(long ptr, bindings.LDKLSPS2Response.GetInfo obj) {
			super(null, ptr);
			long get_info = obj.get_info;
			org.ldk.structs.LSPS2GetInfoResponse get_info_hu_conv = null; if (get_info < 0 || get_info > 4096) { get_info_hu_conv = new org.ldk.structs.LSPS2GetInfoResponse(null, get_info); }
			if (get_info_hu_conv != null) { get_info_hu_conv.ptrs_to.add(this); };
			this.get_info = get_info_hu_conv;
		}
	}
	/**
	 * An error response to a [`LSPS2Request::GetInfo`] request.
	 */
	public final static class GetInfoError extends LSPS2Response {
		public final org.ldk.structs.LSPSResponseError get_info_error;
		private GetInfoError(long ptr, bindings.LDKLSPS2Response.GetInfoError obj) {
			super(null, ptr);
			long get_info_error = obj.get_info_error;
			org.ldk.structs.LSPSResponseError get_info_error_hu_conv = null; if (get_info_error < 0 || get_info_error > 4096) { get_info_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, get_info_error); }
			if (get_info_error_hu_conv != null) { get_info_error_hu_conv.ptrs_to.add(this); };
			this.get_info_error = get_info_error_hu_conv;
		}
	}
	/**
	 * A successful response to a [`LSPS2Request::Buy`] request.
	 */
	public final static class Buy extends LSPS2Response {
		public final org.ldk.structs.LSPS2BuyResponse buy;
		private Buy(long ptr, bindings.LDKLSPS2Response.Buy obj) {
			super(null, ptr);
			long buy = obj.buy;
			org.ldk.structs.LSPS2BuyResponse buy_hu_conv = null; if (buy < 0 || buy > 4096) { buy_hu_conv = new org.ldk.structs.LSPS2BuyResponse(null, buy); }
			if (buy_hu_conv != null) { buy_hu_conv.ptrs_to.add(this); };
			this.buy = buy_hu_conv;
		}
	}
	/**
	 * An error response to a [`LSPS2Request::Buy`] request.
	 */
	public final static class BuyError extends LSPS2Response {
		public final org.ldk.structs.LSPSResponseError buy_error;
		private BuyError(long ptr, bindings.LDKLSPS2Response.BuyError obj) {
			super(null, ptr);
			long buy_error = obj.buy_error;
			org.ldk.structs.LSPSResponseError buy_error_hu_conv = null; if (buy_error < 0 || buy_error > 4096) { buy_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, buy_error); }
			if (buy_error_hu_conv != null) { buy_error_hu_conv.ptrs_to.add(this); };
			this.buy_error = buy_error_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS2Response_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2Response
	 */
	public LSPS2Response clone() {
		long ret = bindings.LSPS2Response_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS2Response
	 */
	public static LSPS2Response get_info(org.ldk.structs.LSPS2GetInfoResponse a) {
		long ret = bindings.LSPS2Response_get_info(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfoError-variant LSPS2Response
	 */
	public static LSPS2Response get_info_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS2Response_get_info_error(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Buy-variant LSPS2Response
	 */
	public static LSPS2Response buy(org.ldk.structs.LSPS2BuyResponse a) {
		long ret = bindings.LSPS2Response_buy(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BuyError-variant LSPS2Response
	 */
	public static LSPS2Response buy_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS2Response_buy_error(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Response ret_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2Responses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS2Response b) {
		boolean ret = bindings.LSPS2Response_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2Response)) return false;
		return this.eq((LSPS2Response)o);
	}
}
