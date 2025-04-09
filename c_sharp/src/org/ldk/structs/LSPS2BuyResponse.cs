using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A response to a [`LSPS2BuyRequest`].
 * 
 * Includes information needed to construct an invoice.
 */
public class LSPS2BuyResponse : CommonBase {
	internal LSPS2BuyResponse(object _dummy, long ptr) : base(ptr) { }
	~LSPS2BuyResponse() {
		if (ptr != 0) { bindings.LSPS2BuyResponse_free(ptr); }
	}

	/**
	 * The intercept short channel id used by LSP to identify need to open channel.
	 */
	public org.ldk.structs.LSPS2InterceptScid get_jit_channel_scid() {
		long ret = bindings.LSPS2BuyResponse_get_jit_channel_scid(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2InterceptScid ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2InterceptScid(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The intercept short channel id used by LSP to identify need to open channel.
	 */
	public void set_jit_channel_scid(org.ldk.structs.LSPS2InterceptScid val) {
		bindings.LSPS2BuyResponse_set_jit_channel_scid(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The locktime expiry delta the lsp requires.
	 */
	public int get_lsp_cltv_expiry_delta() {
		int ret = bindings.LSPS2BuyResponse_get_lsp_cltv_expiry_delta(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The locktime expiry delta the lsp requires.
	 */
	public void set_lsp_cltv_expiry_delta(int val) {
		bindings.LSPS2BuyResponse_set_lsp_cltv_expiry_delta(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A flag that indicates who is trusting who.
	 */
	public bool get_client_trusts_lsp() {
		bool ret = bindings.LSPS2BuyResponse_get_client_trusts_lsp(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A flag that indicates who is trusting who.
	 */
	public void set_client_trusts_lsp(bool val) {
		bindings.LSPS2BuyResponse_set_client_trusts_lsp(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS2BuyResponse given each field
	 */
	public static org.ldk.structs.LSPS2BuyResponse of(org.ldk.structs.LSPS2InterceptScid jit_channel_scid_arg, int lsp_cltv_expiry_delta_arg, bool client_trusts_lsp_arg) {
		long ret = bindings.LSPS2BuyResponse_new(jit_channel_scid_arg.ptr, lsp_cltv_expiry_delta_arg, client_trusts_lsp_arg);
		GC.KeepAlive(jit_channel_scid_arg);
		GC.KeepAlive(lsp_cltv_expiry_delta_arg);
		GC.KeepAlive(client_trusts_lsp_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2BuyResponse_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2BuyResponse
	 */
	public org.ldk.structs.LSPS2BuyResponse clone() {
		long ret = bindings.LSPS2BuyResponse_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2BuyResponses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS2BuyResponse b) {
		bool ret = bindings.LSPS2BuyResponse_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2BuyResponse)) return false;
		return this.eq((LSPS2BuyResponse)o);
	}
}
} } }
