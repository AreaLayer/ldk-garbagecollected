package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An object representing an bLIP-51 / LSPS1 channel order.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1OrderParams extends CommonBase {
	LSPS1OrderParams(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1OrderParams_free(ptr); }
	}

	/**
	 * Indicates how many satoshi the LSP will provide on their side.
	 */
	public long get_lsp_balance_sat() {
		long ret = bindings.LSPS1OrderParams_get_lsp_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates how many satoshi the LSP will provide on their side.
	 */
	public void set_lsp_balance_sat(long val) {
		bindings.LSPS1OrderParams_set_lsp_balance_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Indicates how many satoshi the client will provide on their side.
	 * 
	 * The client sends these funds to the LSP, who will push them back to the client upon opening
	 * the channel.
	 */
	public long get_client_balance_sat() {
		long ret = bindings.LSPS1OrderParams_get_client_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
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
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The number of confirmations the funding tx must have before the LSP sends `channel_ready`.
	 */
	public short get_required_channel_confirmations() {
		short ret = bindings.LSPS1OrderParams_get_required_channel_confirmations(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The number of confirmations the funding tx must have before the LSP sends `channel_ready`.
	 */
	public void set_required_channel_confirmations(short val) {
		bindings.LSPS1OrderParams_set_required_channel_confirmations(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The maximum number of blocks the client wants to wait until the funding transaction is confirmed.
	 */
	public short get_funding_confirms_within_blocks() {
		short ret = bindings.LSPS1OrderParams_get_funding_confirms_within_blocks(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The maximum number of blocks the client wants to wait until the funding transaction is confirmed.
	 */
	public void set_funding_confirms_within_blocks(short val) {
		bindings.LSPS1OrderParams_set_funding_confirms_within_blocks(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Indicates how long the channel is leased for in block time.
	 */
	public int get_channel_expiry_blocks() {
		int ret = bindings.LSPS1OrderParams_get_channel_expiry_blocks(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates how long the channel is leased for in block time.
	 */
	public void set_channel_expiry_blocks(int val) {
		bindings.LSPS1OrderParams_set_channel_expiry_blocks(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * May contain arbitrary associated data like a coupon code or a authentication token.
	 */
	public Option_StrZ get_token() {
		long ret = bindings.LSPS1OrderParams_get_token(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * May contain arbitrary associated data like a coupon code or a authentication token.
	 */
	public void set_token(org.ldk.structs.Option_StrZ val) {
		bindings.LSPS1OrderParams_set_token(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Indicates if the channel should be announced to the network.
	 */
	public boolean get_announce_channel() {
		boolean ret = bindings.LSPS1OrderParams_get_announce_channel(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates if the channel should be announced to the network.
	 */
	public void set_announce_channel(boolean val) {
		bindings.LSPS1OrderParams_set_announce_channel(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1OrderParams given each field
	 */
	public static LSPS1OrderParams of(long lsp_balance_sat_arg, long client_balance_sat_arg, short required_channel_confirmations_arg, short funding_confirms_within_blocks_arg, int channel_expiry_blocks_arg, org.ldk.structs.Option_StrZ token_arg, boolean announce_channel_arg) {
		long ret = bindings.LSPS1OrderParams_new(lsp_balance_sat_arg, client_balance_sat_arg, required_channel_confirmations_arg, funding_confirms_within_blocks_arg, channel_expiry_blocks_arg, token_arg.ptr, announce_channel_arg);
		Reference.reachabilityFence(lsp_balance_sat_arg);
		Reference.reachabilityFence(client_balance_sat_arg);
		Reference.reachabilityFence(required_channel_confirmations_arg);
		Reference.reachabilityFence(funding_confirms_within_blocks_arg);
		Reference.reachabilityFence(channel_expiry_blocks_arg);
		Reference.reachabilityFence(token_arg);
		Reference.reachabilityFence(announce_channel_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1OrderParams_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1OrderParams
	 */
	public LSPS1OrderParams clone() {
		long ret = bindings.LSPS1OrderParams_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OrderParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OrderParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1OrderParamss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1OrderParams b) {
		boolean ret = bindings.LSPS1OrderParams_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1OrderParams)) return false;
		return this.eq((LSPS1OrderParams)o);
	}
}
