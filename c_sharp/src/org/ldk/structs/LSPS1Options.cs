using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An object representing the supported protocol options.
 */
public class LSPS1Options : CommonBase {
	internal LSPS1Options(object _dummy, long ptr) : base(ptr) { }
	~LSPS1Options() {
		if (ptr != 0) { bindings.LSPS1Options_free(ptr); }
	}

	/**
	 * The smallest number of confirmations needed for the LSP to accept a channel as confirmed.
	 */
	public short get_min_required_channel_confirmations() {
		short ret = bindings.LSPS1Options_get_min_required_channel_confirmations(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The smallest number of confirmations needed for the LSP to accept a channel as confirmed.
	 */
	public void set_min_required_channel_confirmations(short val) {
		bindings.LSPS1Options_set_min_required_channel_confirmations(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The smallest number of blocks in which the LSP can confirm the funding transaction.
	 */
	public short get_min_funding_confirms_within_blocks() {
		short ret = bindings.LSPS1Options_get_min_funding_confirms_within_blocks(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The smallest number of blocks in which the LSP can confirm the funding transaction.
	 */
	public void set_min_funding_confirms_within_blocks(short val) {
		bindings.LSPS1Options_set_min_funding_confirms_within_blocks(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Indicates if the LSP supports zero reserve.
	 */
	public bool get_supports_zero_channel_reserve() {
		bool ret = bindings.LSPS1Options_get_supports_zero_channel_reserve(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates if the LSP supports zero reserve.
	 */
	public void set_supports_zero_channel_reserve(bool val) {
		bindings.LSPS1Options_set_supports_zero_channel_reserve(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of blocks a channel can be leased for.
	 */
	public int get_max_channel_expiry_blocks() {
		int ret = bindings.LSPS1Options_get_max_channel_expiry_blocks(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of blocks a channel can be leased for.
	 */
	public void set_max_channel_expiry_blocks(int val) {
		bindings.LSPS1Options_set_max_channel_expiry_blocks(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum number of satoshi that the client MUST request.
	 */
	public long get_min_initial_client_balance_sat() {
		long ret = bindings.LSPS1Options_get_min_initial_client_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum number of satoshi that the client MUST request.
	 */
	public void set_min_initial_client_balance_sat(long val) {
		bindings.LSPS1Options_set_min_initial_client_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of satoshi that the client MUST request.
	 */
	public long get_max_initial_client_balance_sat() {
		long ret = bindings.LSPS1Options_get_max_initial_client_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of satoshi that the client MUST request.
	 */
	public void set_max_initial_client_balance_sat(long val) {
		bindings.LSPS1Options_set_max_initial_client_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum number of satoshi that the LSP will provide to the channel.
	 */
	public long get_min_initial_lsp_balance_sat() {
		long ret = bindings.LSPS1Options_get_min_initial_lsp_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum number of satoshi that the LSP will provide to the channel.
	 */
	public void set_min_initial_lsp_balance_sat(long val) {
		bindings.LSPS1Options_set_min_initial_lsp_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of satoshi that the LSP will provide to the channel.
	 */
	public long get_max_initial_lsp_balance_sat() {
		long ret = bindings.LSPS1Options_get_max_initial_lsp_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of satoshi that the LSP will provide to the channel.
	 */
	public void set_max_initial_lsp_balance_sat(long val) {
		bindings.LSPS1Options_set_max_initial_lsp_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimal channel size.
	 */
	public long get_min_channel_balance_sat() {
		long ret = bindings.LSPS1Options_get_min_channel_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimal channel size.
	 */
	public void set_min_channel_balance_sat(long val) {
		bindings.LSPS1Options_set_min_channel_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximal channel size.
	 */
	public long get_max_channel_balance_sat() {
		long ret = bindings.LSPS1Options_get_max_channel_balance_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximal channel size.
	 */
	public void set_max_channel_balance_sat(long val) {
		bindings.LSPS1Options_set_max_channel_balance_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1Options given each field
	 */
	public static org.ldk.structs.LSPS1Options of(short min_required_channel_confirmations_arg, short min_funding_confirms_within_blocks_arg, bool supports_zero_channel_reserve_arg, int max_channel_expiry_blocks_arg, long min_initial_client_balance_sat_arg, long max_initial_client_balance_sat_arg, long min_initial_lsp_balance_sat_arg, long max_initial_lsp_balance_sat_arg, long min_channel_balance_sat_arg, long max_channel_balance_sat_arg) {
		long ret = bindings.LSPS1Options_new(min_required_channel_confirmations_arg, min_funding_confirms_within_blocks_arg, supports_zero_channel_reserve_arg, max_channel_expiry_blocks_arg, min_initial_client_balance_sat_arg, max_initial_client_balance_sat_arg, min_initial_lsp_balance_sat_arg, max_initial_lsp_balance_sat_arg, min_channel_balance_sat_arg, max_channel_balance_sat_arg);
		GC.KeepAlive(min_required_channel_confirmations_arg);
		GC.KeepAlive(min_funding_confirms_within_blocks_arg);
		GC.KeepAlive(supports_zero_channel_reserve_arg);
		GC.KeepAlive(max_channel_expiry_blocks_arg);
		GC.KeepAlive(min_initial_client_balance_sat_arg);
		GC.KeepAlive(max_initial_client_balance_sat_arg);
		GC.KeepAlive(min_initial_lsp_balance_sat_arg);
		GC.KeepAlive(max_initial_lsp_balance_sat_arg);
		GC.KeepAlive(min_channel_balance_sat_arg);
		GC.KeepAlive(max_channel_balance_sat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Options ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Options(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1Options_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1Options
	 */
	public org.ldk.structs.LSPS1Options clone() {
		long ret = bindings.LSPS1Options_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Options ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Options(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1Optionss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1Options b) {
		bool ret = bindings.LSPS1Options_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1Options)) return false;
		return this.eq((LSPS1Options)o);
	}
}
} } }
