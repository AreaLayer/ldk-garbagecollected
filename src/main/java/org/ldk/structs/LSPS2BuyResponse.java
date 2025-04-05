package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A response to a [`LSPS2BuyRequest`].
 * 
 * Includes information needed to construct an invoice.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2BuyResponse extends CommonBase {
	LSPS2BuyResponse(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2BuyResponse_free(ptr); }
	}

	/**
	 * The intercept short channel id used by LSP to identify need to open channel.
	 */
	public LSPS2InterceptScid get_jit_channel_scid() {
		long ret = bindings.LSPS2BuyResponse_get_jit_channel_scid(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2InterceptScid ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2InterceptScid(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The intercept short channel id used by LSP to identify need to open channel.
	 */
	public void set_jit_channel_scid(org.ldk.structs.LSPS2InterceptScid val) {
		bindings.LSPS2BuyResponse_set_jit_channel_scid(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The locktime expiry delta the lsp requires.
	 */
	public int get_lsp_cltv_expiry_delta() {
		int ret = bindings.LSPS2BuyResponse_get_lsp_cltv_expiry_delta(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The locktime expiry delta the lsp requires.
	 */
	public void set_lsp_cltv_expiry_delta(int val) {
		bindings.LSPS2BuyResponse_set_lsp_cltv_expiry_delta(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * A flag that indicates who is trusting who.
	 */
	public boolean get_client_trusts_lsp() {
		boolean ret = bindings.LSPS2BuyResponse_get_client_trusts_lsp(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A flag that indicates who is trusting who.
	 */
	public void set_client_trusts_lsp(boolean val) {
		bindings.LSPS2BuyResponse_set_client_trusts_lsp(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS2BuyResponse given each field
	 */
	public static LSPS2BuyResponse of(org.ldk.structs.LSPS2InterceptScid jit_channel_scid_arg, int lsp_cltv_expiry_delta_arg, boolean client_trusts_lsp_arg) {
		long ret = bindings.LSPS2BuyResponse_new(jit_channel_scid_arg.ptr, lsp_cltv_expiry_delta_arg, client_trusts_lsp_arg);
		Reference.reachabilityFence(jit_channel_scid_arg);
		Reference.reachabilityFence(lsp_cltv_expiry_delta_arg);
		Reference.reachabilityFence(client_trusts_lsp_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS2BuyResponse_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2BuyResponse
	 */
	public LSPS2BuyResponse clone() {
		long ret = bindings.LSPS2BuyResponse_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2BuyResponses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS2BuyResponse b) {
		boolean ret = bindings.LSPS2BuyResponse_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2BuyResponse)) return false;
		return this.eq((LSPS2BuyResponse)o);
	}
}
