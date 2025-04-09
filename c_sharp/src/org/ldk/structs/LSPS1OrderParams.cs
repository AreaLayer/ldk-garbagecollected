using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An object representing an bLIP-51 / LSPS1 channel order.
 */
public class LSPS1OrderParams : CommonBase {
	internal LSPS1OrderParams(object _dummy, long ptr) : base(ptr) { }
	~LSPS1OrderParams() {
		if (ptr != 0) { bindings.LSPS1OrderParams_free(ptr); }
	}

	/**
	 * Indicates how many satoshi the LSP will provide on their side.
	 */
	public long get_lsp_balance_sat() {
		long ret = bindings.LSPS1OrderParams_get_lsp_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates how many satoshi the LSP will provide on their side.
	 */
	public void set_lsp_balance_sat(long val) {
		bindings.LSPS1OrderParams_set_lsp_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Indicates how many satoshi the client will provide on their side.
	 * 
	 * The client sends these funds to the LSP, who will push them back to the client upon opening
	 * the channel.
	 */
	public long get_client_balance_sat() {
		long ret = bindings.LSPS1OrderParams_get_client_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates how many satoshi the client will provide on their side.
	 * 
	 * The client sends these funds to the LSP, who will push them back to the client upon opening
	 * the channel.
	 */
	public void set_client_balance_sat(long val) {
		bindings.LSPS1OrderParams_set_client_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of confirmations the funding tx must have before the LSP sends `channel_ready`.
	 */
	public short get_required_channel_confirmations() {
		short ret = bindings.LSPS1OrderParams_get_required_channel_confirmations(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The number of confirmations the funding tx must have before the LSP sends `channel_ready`.
	 */
	public void set_required_channel_confirmations(short val) {
		bindings.LSPS1OrderParams_set_required_channel_confirmations(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of blocks the client wants to wait until the funding transaction is confirmed.
	 */
	public short get_funding_confirms_within_blocks() {
		short ret = bindings.LSPS1OrderParams_get_funding_confirms_within_blocks(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of blocks the client wants to wait until the funding transaction is confirmed.
	 */
	public void set_funding_confirms_within_blocks(short val) {
		bindings.LSPS1OrderParams_set_funding_confirms_within_blocks(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Indicates how long the channel is leased for in block time.
	 */
	public int get_channel_expiry_blocks() {
		int ret = bindings.LSPS1OrderParams_get_channel_expiry_blocks(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates how long the channel is leased for in block time.
	 */
	public void set_channel_expiry_blocks(int val) {
		bindings.LSPS1OrderParams_set_channel_expiry_blocks(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * May contain arbitrary associated data like a coupon code or a authentication token.
	 */
	public org.ldk.structs.Option_StrZ get_token() {
		long ret = bindings.LSPS1OrderParams_get_token(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * May contain arbitrary associated data like a coupon code or a authentication token.
	 */
	public void set_token(org.ldk.structs.Option_StrZ val) {
		bindings.LSPS1OrderParams_set_token(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Indicates if the channel should be announced to the network.
	 */
	public bool get_announce_channel() {
		bool ret = bindings.LSPS1OrderParams_get_announce_channel(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates if the channel should be announced to the network.
	 */
	public void set_announce_channel(bool val) {
		bindings.LSPS1OrderParams_set_announce_channel(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1OrderParams given each field
	 */
	public static org.ldk.structs.LSPS1OrderParams of(long lsp_balance_sat_arg, long client_balance_sat_arg, short required_channel_confirmations_arg, short funding_confirms_within_blocks_arg, int channel_expiry_blocks_arg, org.ldk.structs.Option_StrZ token_arg, bool announce_channel_arg) {
		long ret = bindings.LSPS1OrderParams_new(lsp_balance_sat_arg, client_balance_sat_arg, required_channel_confirmations_arg, funding_confirms_within_blocks_arg, channel_expiry_blocks_arg, token_arg.ptr, announce_channel_arg);
		GC.KeepAlive(lsp_balance_sat_arg);
		GC.KeepAlive(client_balance_sat_arg);
		GC.KeepAlive(required_channel_confirmations_arg);
		GC.KeepAlive(funding_confirms_within_blocks_arg);
		GC.KeepAlive(channel_expiry_blocks_arg);
		GC.KeepAlive(token_arg);
		GC.KeepAlive(announce_channel_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1OrderParams_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1OrderParams
	 */
	public org.ldk.structs.LSPS1OrderParams clone() {
		long ret = bindings.LSPS1OrderParams_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1OrderParamss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1OrderParams b) {
		bool ret = bindings.LSPS1OrderParams_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1OrderParams)) return false;
		return this.eq((LSPS1OrderParams)o);
	}
}
} } }
