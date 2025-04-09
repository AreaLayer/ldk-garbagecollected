package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum that captures all the valid JSON-RPC requests in the bLIP-52 / LSPS2 protocol.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2Request extends CommonBase {
	private LSPS2Request(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2Request_free(ptr); }
	}
	static LSPS2Request constr_from_ptr(long ptr) {
		bindings.LDKLSPS2Request raw_val = bindings.LDKLSPS2Request_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS2Request.GetInfo.class) {
			return new GetInfo(ptr, (bindings.LDKLSPS2Request.GetInfo)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2Request.Buy.class) {
			return new Buy(ptr, (bindings.LDKLSPS2Request.Buy)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A request to learn an LSP's channel fees and parameters.
	 */
	public final static class GetInfo extends LSPS2Request {
		public final org.ldk.structs.LSPS2GetInfoRequest get_info;
		private GetInfo(long ptr, bindings.LDKLSPS2Request.GetInfo obj) {
			super(null, ptr);
			long get_info = obj.get_info;
			org.ldk.structs.LSPS2GetInfoRequest get_info_hu_conv = null; if (get_info < 0 || get_info > 4096) { get_info_hu_conv = new org.ldk.structs.LSPS2GetInfoRequest(null, get_info); }
			if (get_info_hu_conv != null) { get_info_hu_conv.ptrs_to.add(this); };
			this.get_info = get_info_hu_conv;
		}
	}
	/**
	 * A request to buy a JIT channel from an LSP.
	 */
	public final static class Buy extends LSPS2Request {
		public final org.ldk.structs.LSPS2BuyRequest buy;
		private Buy(long ptr, bindings.LDKLSPS2Request.Buy obj) {
			super(null, ptr);
			long buy = obj.buy;
			org.ldk.structs.LSPS2BuyRequest buy_hu_conv = null; if (buy < 0 || buy > 4096) { buy_hu_conv = new org.ldk.structs.LSPS2BuyRequest(null, buy); }
			if (buy_hu_conv != null) { buy_hu_conv.ptrs_to.add(this); };
			this.buy = buy_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS2Request_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2Request
	 */
	public LSPS2Request clone() {
		long ret = bindings.LSPS2Request_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Request ret_hu_conv = org.ldk.structs.LSPS2Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetInfo-variant LSPS2Request
	 */
	public static LSPS2Request get_info(org.ldk.structs.LSPS2GetInfoRequest a) {
		long ret = bindings.LSPS2Request_get_info(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Request ret_hu_conv = org.ldk.structs.LSPS2Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Buy-variant LSPS2Request
	 */
	public static LSPS2Request buy(org.ldk.structs.LSPS2BuyRequest a) {
		long ret = bindings.LSPS2Request_buy(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Request ret_hu_conv = org.ldk.structs.LSPS2Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2Requests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS2Request b) {
		boolean ret = bindings.LSPS2Request_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2Request)) return false;
		return this.eq((LSPS2Request)o);
	}
}
