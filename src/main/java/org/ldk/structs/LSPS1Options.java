package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An object representing the supported protocol options.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1Options extends CommonBase {
	LSPS1Options(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1Options_free(ptr); }
	}

	/**
	 * The smallest number of confirmations needed for the LSP to accept a channel as confirmed.
	 */
	public short get_min_required_channel_confirmations() {
		short ret = bindings.LSPS1Options_get_min_required_channel_confirmations(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The smallest number of confirmations needed for the LSP to accept a channel as confirmed.
	 */
	public void set_min_required_channel_confirmations(short val) {
		bindings.LSPS1Options_set_min_required_channel_confirmations(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The smallest number of blocks in which the LSP can confirm the funding transaction.
	 */
	public short get_min_funding_confirms_within_blocks() {
		short ret = bindings.LSPS1Options_get_min_funding_confirms_within_blocks(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The smallest number of blocks in which the LSP can confirm the funding transaction.
	 */
	public void set_min_funding_confirms_within_blocks(short val) {
		bindings.LSPS1Options_set_min_funding_confirms_within_blocks(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Indicates if the LSP supports zero reserve.
	 */
	public boolean get_supports_zero_channel_reserve() {
		boolean ret = bindings.LSPS1Options_get_supports_zero_channel_reserve(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates if the LSP supports zero reserve.
	 */
	public void set_supports_zero_channel_reserve(boolean val) {
		bindings.LSPS1Options_set_supports_zero_channel_reserve(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The maximum number of blocks a channel can be leased for.
	 */
	public int get_max_channel_expiry_blocks() {
		int ret = bindings.LSPS1Options_get_max_channel_expiry_blocks(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The maximum number of blocks a channel can be leased for.
	 */
	public void set_max_channel_expiry_blocks(int val) {
		bindings.LSPS1Options_set_max_channel_expiry_blocks(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The minimum number of satoshi that the client MUST request.
	 */
	public long get_min_initial_client_balance_sat() {
		long ret = bindings.LSPS1Options_get_min_initial_client_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The minimum number of satoshi that the client MUST request.
	 */
	public void set_min_initial_client_balance_sat(long val) {
		bindings.LSPS1Options_set_min_initial_client_balance_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The maximum number of satoshi that the client MUST request.
	 */
	public long get_max_initial_client_balance_sat() {
		long ret = bindings.LSPS1Options_get_max_initial_client_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The maximum number of satoshi that the client MUST request.
	 */
	public void set_max_initial_client_balance_sat(long val) {
		bindings.LSPS1Options_set_max_initial_client_balance_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The minimum number of satoshi that the LSP will provide to the channel.
	 */
	public long get_min_initial_lsp_balance_sat() {
		long ret = bindings.LSPS1Options_get_min_initial_lsp_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The minimum number of satoshi that the LSP will provide to the channel.
	 */
	public void set_min_initial_lsp_balance_sat(long val) {
		bindings.LSPS1Options_set_min_initial_lsp_balance_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The maximum number of satoshi that the LSP will provide to the channel.
	 */
	public long get_max_initial_lsp_balance_sat() {
		long ret = bindings.LSPS1Options_get_max_initial_lsp_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The maximum number of satoshi that the LSP will provide to the channel.
	 */
	public void set_max_initial_lsp_balance_sat(long val) {
		bindings.LSPS1Options_set_max_initial_lsp_balance_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The minimal channel size.
	 */
	public long get_min_channel_balance_sat() {
		long ret = bindings.LSPS1Options_get_min_channel_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The minimal channel size.
	 */
	public void set_min_channel_balance_sat(long val) {
		bindings.LSPS1Options_set_min_channel_balance_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The maximal channel size.
	 */
	public long get_max_channel_balance_sat() {
		long ret = bindings.LSPS1Options_get_max_channel_balance_sat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The maximal channel size.
	 */
	public void set_max_channel_balance_sat(long val) {
		bindings.LSPS1Options_set_max_channel_balance_sat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1Options given each field
	 */
	public static LSPS1Options of(short min_required_channel_confirmations_arg, short min_funding_confirms_within_blocks_arg, boolean supports_zero_channel_reserve_arg, int max_channel_expiry_blocks_arg, long min_initial_client_balance_sat_arg, long max_initial_client_balance_sat_arg, long min_initial_lsp_balance_sat_arg, long max_initial_lsp_balance_sat_arg, long min_channel_balance_sat_arg, long max_channel_balance_sat_arg) {
		long ret = bindings.LSPS1Options_new(min_required_channel_confirmations_arg, min_funding_confirms_within_blocks_arg, supports_zero_channel_reserve_arg, max_channel_expiry_blocks_arg, min_initial_client_balance_sat_arg, max_initial_client_balance_sat_arg, min_initial_lsp_balance_sat_arg, max_initial_lsp_balance_sat_arg, min_channel_balance_sat_arg, max_channel_balance_sat_arg);
		Reference.reachabilityFence(min_required_channel_confirmations_arg);
		Reference.reachabilityFence(min_funding_confirms_within_blocks_arg);
		Reference.reachabilityFence(supports_zero_channel_reserve_arg);
		Reference.reachabilityFence(max_channel_expiry_blocks_arg);
		Reference.reachabilityFence(min_initial_client_balance_sat_arg);
		Reference.reachabilityFence(max_initial_client_balance_sat_arg);
		Reference.reachabilityFence(min_initial_lsp_balance_sat_arg);
		Reference.reachabilityFence(max_initial_lsp_balance_sat_arg);
		Reference.reachabilityFence(min_channel_balance_sat_arg);
		Reference.reachabilityFence(max_channel_balance_sat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Options ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Options(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1Options_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Options
	 */
	public LSPS1Options clone() {
		long ret = bindings.LSPS1Options_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Options ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Options(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Optionss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1Options b) {
		boolean ret = bindings.LSPS1Options_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1Options)) return false;
		return this.eq((LSPS1Options)o);
	}
}
