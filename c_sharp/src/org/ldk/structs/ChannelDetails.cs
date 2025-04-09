using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Details of a channel, as returned by [`ChannelManager::list_channels`] and [`ChannelManager::list_usable_channels`]
 * 
 * Balances of a channel are available through [`ChainMonitor::get_claimable_balances`] and
 * [`ChannelMonitor::get_claimable_balances`], calculated with respect to the corresponding on-chain
 * transactions.
 * 
 * [`ChannelManager::list_channels`]: crate::ln::channelmanager::ChannelManager::list_channels
 * [`ChannelManager::list_usable_channels`]: crate::ln::channelmanager::ChannelManager::list_usable_channels
 * [`ChainMonitor::get_claimable_balances`]: crate::chain::chainmonitor::ChainMonitor::get_claimable_balances
 * [`ChannelMonitor::get_claimable_balances`]: crate::chain::channelmonitor::ChannelMonitor::get_claimable_balances
 */
public class ChannelDetails : CommonBase {
	internal ChannelDetails(object _dummy, long ptr) : base(ptr) { }
	~ChannelDetails() {
		if (ptr != 0) { bindings.ChannelDetails_free(ptr); }
	}

	/**
	 * The channel's ID (prior to funding transaction generation, this is a random 32 bytes,
	 * thereafter this is the txid of the funding transaction xor the funding transaction output).
	 * Note that this means this value is *not* persistent - it can change once during the
	 * lifetime of the channel.
	 */
	public org.ldk.structs.ChannelId get_channel_id() {
		long ret = bindings.ChannelDetails_get_channel_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The channel's ID (prior to funding transaction generation, this is a random 32 bytes,
	 * thereafter this is the txid of the funding transaction xor the funding transaction output).
	 * Note that this means this value is *not* persistent - it can change once during the
	 * lifetime of the channel.
	 */
	public void set_channel_id(org.ldk.structs.ChannelId val) {
		bindings.ChannelDetails_set_channel_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Parameters which apply to our counterparty. See individual fields for more information.
	 */
	public org.ldk.structs.ChannelCounterparty get_counterparty() {
		long ret = bindings.ChannelDetails_get_counterparty(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelCounterparty ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelCounterparty(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Parameters which apply to our counterparty. See individual fields for more information.
	 */
	public void set_counterparty(org.ldk.structs.ChannelCounterparty val) {
		bindings.ChannelDetails_set_counterparty(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The Channel's funding transaction output, if we've negotiated the funding transaction with
	 * our counterparty already.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.OutPoint get_funding_txo() {
		long ret = bindings.ChannelDetails_get_funding_txo(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The Channel's funding transaction output, if we've negotiated the funding transaction with
	 * our counterparty already.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_funding_txo(org.ldk.structs.OutPoint val) {
		bindings.ChannelDetails_set_funding_txo(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The features which this channel operates with. See individual features for more info.
	 * 
	 * `None` until negotiation completes and the channel type is finalized.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.ChannelTypeFeatures get_channel_type() {
		long ret = bindings.ChannelDetails_get_channel_type(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The features which this channel operates with. See individual features for more info.
	 * 
	 * `None` until negotiation completes and the channel type is finalized.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_channel_type(org.ldk.structs.ChannelTypeFeatures val) {
		bindings.ChannelDetails_set_channel_type(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The position of the funding transaction in the chain. None if the funding transaction has
	 * not yet been confirmed and the channel fully opened.
	 * 
	 * Note that if [`inbound_scid_alias`] is set, it must be used for invoices and inbound
	 * payments instead of this. See [`get_inbound_payment_scid`].
	 * 
	 * For channels with [`confirmations_required`] set to `Some(0)`, [`outbound_scid_alias`] may
	 * be used in place of this in outbound routes. See [`get_outbound_payment_scid`].
	 * 
	 * [`inbound_scid_alias`]: Self::inbound_scid_alias
	 * [`outbound_scid_alias`]: Self::outbound_scid_alias
	 * [`get_inbound_payment_scid`]: Self::get_inbound_payment_scid
	 * [`get_outbound_payment_scid`]: Self::get_outbound_payment_scid
	 * [`confirmations_required`]: Self::confirmations_required
	 */
	public org.ldk.structs.Option_u64Z get_short_channel_id() {
		long ret = bindings.ChannelDetails_get_short_channel_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The position of the funding transaction in the chain. None if the funding transaction has
	 * not yet been confirmed and the channel fully opened.
	 * 
	 * Note that if [`inbound_scid_alias`] is set, it must be used for invoices and inbound
	 * payments instead of this. See [`get_inbound_payment_scid`].
	 * 
	 * For channels with [`confirmations_required`] set to `Some(0)`, [`outbound_scid_alias`] may
	 * be used in place of this in outbound routes. See [`get_outbound_payment_scid`].
	 * 
	 * [`inbound_scid_alias`]: Self::inbound_scid_alias
	 * [`outbound_scid_alias`]: Self::outbound_scid_alias
	 * [`get_inbound_payment_scid`]: Self::get_inbound_payment_scid
	 * [`get_outbound_payment_scid`]: Self::get_outbound_payment_scid
	 * [`confirmations_required`]: Self::confirmations_required
	 */
	public void set_short_channel_id(org.ldk.structs.Option_u64Z val) {
		bindings.ChannelDetails_set_short_channel_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * An optional [`short_channel_id`] alias for this channel, randomly generated by us and
	 * usable in place of [`short_channel_id`] to reference the channel in outbound routes when
	 * the channel has not yet been confirmed (as long as [`confirmations_required`] is
	 * `Some(0)`).
	 * 
	 * This will be `None` as long as the channel is not available for routing outbound payments.
	 * 
	 * [`short_channel_id`]: Self::short_channel_id
	 * [`confirmations_required`]: Self::confirmations_required
	 */
	public org.ldk.structs.Option_u64Z get_outbound_scid_alias() {
		long ret = bindings.ChannelDetails_get_outbound_scid_alias(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An optional [`short_channel_id`] alias for this channel, randomly generated by us and
	 * usable in place of [`short_channel_id`] to reference the channel in outbound routes when
	 * the channel has not yet been confirmed (as long as [`confirmations_required`] is
	 * `Some(0)`).
	 * 
	 * This will be `None` as long as the channel is not available for routing outbound payments.
	 * 
	 * [`short_channel_id`]: Self::short_channel_id
	 * [`confirmations_required`]: Self::confirmations_required
	 */
	public void set_outbound_scid_alias(org.ldk.structs.Option_u64Z val) {
		bindings.ChannelDetails_set_outbound_scid_alias(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * An optional [`short_channel_id`] alias for this channel, randomly generated by our
	 * counterparty and usable in place of [`short_channel_id`] in invoice route hints. Our
	 * counterparty will recognize the alias provided here in place of the [`short_channel_id`]
	 * when they see a payment to be routed to us.
	 * 
	 * Our counterparty may choose to rotate this value at any time, though will always recognize
	 * previous values for inbound payment forwarding.
	 * 
	 * [`short_channel_id`]: Self::short_channel_id
	 */
	public org.ldk.structs.Option_u64Z get_inbound_scid_alias() {
		long ret = bindings.ChannelDetails_get_inbound_scid_alias(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An optional [`short_channel_id`] alias for this channel, randomly generated by our
	 * counterparty and usable in place of [`short_channel_id`] in invoice route hints. Our
	 * counterparty will recognize the alias provided here in place of the [`short_channel_id`]
	 * when they see a payment to be routed to us.
	 * 
	 * Our counterparty may choose to rotate this value at any time, though will always recognize
	 * previous values for inbound payment forwarding.
	 * 
	 * [`short_channel_id`]: Self::short_channel_id
	 */
	public void set_inbound_scid_alias(org.ldk.structs.Option_u64Z val) {
		bindings.ChannelDetails_set_inbound_scid_alias(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The value, in satoshis, of this channel as appears in the funding output
	 */
	public long get_channel_value_satoshis() {
		long ret = bindings.ChannelDetails_get_channel_value_satoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The value, in satoshis, of this channel as appears in the funding output
	 */
	public void set_channel_value_satoshis(long val) {
		bindings.ChannelDetails_set_channel_value_satoshis(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The value, in satoshis, that must always be held in the channel for us. This value ensures
	 * that if we broadcast a revoked state, our counterparty can punish us by claiming at least
	 * this value on chain.
	 * 
	 * This value is not included in [`outbound_capacity_msat`] as it can never be spent.
	 * 
	 * This value will be `None` for outbound channels until the counterparty accepts the channel.
	 * 
	 * [`outbound_capacity_msat`]: ChannelDetails::outbound_capacity_msat
	 */
	public org.ldk.structs.Option_u64Z get_unspendable_punishment_reserve() {
		long ret = bindings.ChannelDetails_get_unspendable_punishment_reserve(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The value, in satoshis, that must always be held in the channel for us. This value ensures
	 * that if we broadcast a revoked state, our counterparty can punish us by claiming at least
	 * this value on chain.
	 * 
	 * This value is not included in [`outbound_capacity_msat`] as it can never be spent.
	 * 
	 * This value will be `None` for outbound channels until the counterparty accepts the channel.
	 * 
	 * [`outbound_capacity_msat`]: ChannelDetails::outbound_capacity_msat
	 */
	public void set_unspendable_punishment_reserve(org.ldk.structs.Option_u64Z val) {
		bindings.ChannelDetails_set_unspendable_punishment_reserve(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The `user_channel_id` value passed in to [`ChannelManager::create_channel`] for outbound
	 * channels, or to [`ChannelManager::accept_inbound_channel`] for inbound channels if
	 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
	 * `user_channel_id` will be randomized for an inbound channel.  This may be zero for objects
	 * serialized with LDK versions prior to 0.0.113.
	 * 
	 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
	 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
	 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
	 */
	public org.ldk.util.UInt128 get_user_channel_id() {
		long ret = bindings.ChannelDetails_get_user_channel_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.util.UInt128 ret_conv = new org.ldk.util.UInt128(ret);
		bindings.free_buffer(ret);
		return ret_conv;
	}

	/**
	 * The `user_channel_id` value passed in to [`ChannelManager::create_channel`] for outbound
	 * channels, or to [`ChannelManager::accept_inbound_channel`] for inbound channels if
	 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
	 * `user_channel_id` will be randomized for an inbound channel.  This may be zero for objects
	 * serialized with LDK versions prior to 0.0.113.
	 * 
	 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
	 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
	 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
	 */
	public void set_user_channel_id(org.ldk.util.UInt128 val) {
		bindings.ChannelDetails_set_user_channel_id(this.ptr, InternalUtils.encodeUint8Array(val.getLEBytes()));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The currently negotiated fee rate denominated in satoshi per 1000 weight units,
	 * which is applied to commitment and HTLC transactions.
	 * 
	 * This value will be `None` for objects serialized with LDK versions prior to 0.0.115.
	 */
	public org.ldk.structs.Option_u32Z get_feerate_sat_per_1000_weight() {
		long ret = bindings.ChannelDetails_get_feerate_sat_per_1000_weight(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u32Z ret_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The currently negotiated fee rate denominated in satoshi per 1000 weight units,
	 * which is applied to commitment and HTLC transactions.
	 * 
	 * This value will be `None` for objects serialized with LDK versions prior to 0.0.115.
	 */
	public void set_feerate_sat_per_1000_weight(org.ldk.structs.Option_u32Z val) {
		bindings.ChannelDetails_set_feerate_sat_per_1000_weight(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The available outbound capacity for sending HTLCs to the remote peer. This does not include
	 * any pending HTLCs which are not yet fully resolved (and, thus, whose balance is not
	 * available for inclusion in new outbound HTLCs). This further does not include any pending
	 * outgoing HTLCs which are awaiting some other resolution to be sent.
	 * 
	 * This value is not exact. Due to various in-flight changes, feerate changes, and our
	 * conflict-avoidance policy, exactly this amount is not likely to be spendable. However, we
	 * should be able to spend nearly this amount.
	 */
	public long get_outbound_capacity_msat() {
		long ret = bindings.ChannelDetails_get_outbound_capacity_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The available outbound capacity for sending HTLCs to the remote peer. This does not include
	 * any pending HTLCs which are not yet fully resolved (and, thus, whose balance is not
	 * available for inclusion in new outbound HTLCs). This further does not include any pending
	 * outgoing HTLCs which are awaiting some other resolution to be sent.
	 * 
	 * This value is not exact. Due to various in-flight changes, feerate changes, and our
	 * conflict-avoidance policy, exactly this amount is not likely to be spendable. However, we
	 * should be able to spend nearly this amount.
	 */
	public void set_outbound_capacity_msat(long val) {
		bindings.ChannelDetails_set_outbound_capacity_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The available outbound capacity for sending a single HTLC to the remote peer. This is
	 * similar to [`ChannelDetails::outbound_capacity_msat`] but it may be further restricted by
	 * the current state and per-HTLC limit(s). This is intended for use when routing, allowing us
	 * to use a limit as close as possible to the HTLC limit we can currently send.
	 * 
	 * See also [`ChannelDetails::next_outbound_htlc_minimum_msat`] and
	 * [`ChannelDetails::outbound_capacity_msat`].
	 */
	public long get_next_outbound_htlc_limit_msat() {
		long ret = bindings.ChannelDetails_get_next_outbound_htlc_limit_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The available outbound capacity for sending a single HTLC to the remote peer. This is
	 * similar to [`ChannelDetails::outbound_capacity_msat`] but it may be further restricted by
	 * the current state and per-HTLC limit(s). This is intended for use when routing, allowing us
	 * to use a limit as close as possible to the HTLC limit we can currently send.
	 * 
	 * See also [`ChannelDetails::next_outbound_htlc_minimum_msat`] and
	 * [`ChannelDetails::outbound_capacity_msat`].
	 */
	public void set_next_outbound_htlc_limit_msat(long val) {
		bindings.ChannelDetails_set_next_outbound_htlc_limit_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum value for sending a single HTLC to the remote peer. This is the equivalent of
	 * [`ChannelDetails::next_outbound_htlc_limit_msat`] but represents a lower-bound, rather than
	 * an upper-bound. This is intended for use when routing, allowing us to ensure we pick a
	 * route which is valid.
	 */
	public long get_next_outbound_htlc_minimum_msat() {
		long ret = bindings.ChannelDetails_get_next_outbound_htlc_minimum_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum value for sending a single HTLC to the remote peer. This is the equivalent of
	 * [`ChannelDetails::next_outbound_htlc_limit_msat`] but represents a lower-bound, rather than
	 * an upper-bound. This is intended for use when routing, allowing us to ensure we pick a
	 * route which is valid.
	 */
	public void set_next_outbound_htlc_minimum_msat(long val) {
		bindings.ChannelDetails_set_next_outbound_htlc_minimum_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The available inbound capacity for the remote peer to send HTLCs to us. This does not
	 * include any pending HTLCs which are not yet fully resolved (and, thus, whose balance is not
	 * available for inclusion in new inbound HTLCs).
	 * Note that there are some corner cases not fully handled here, so the actual available
	 * inbound capacity may be slightly higher than this.
	 * 
	 * This value is not exact. Due to various in-flight changes, feerate changes, and our
	 * counterparty's conflict-avoidance policy, exactly this amount is not likely to be spendable.
	 * However, our counterparty should be able to spend nearly this amount.
	 */
	public long get_inbound_capacity_msat() {
		long ret = bindings.ChannelDetails_get_inbound_capacity_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The available inbound capacity for the remote peer to send HTLCs to us. This does not
	 * include any pending HTLCs which are not yet fully resolved (and, thus, whose balance is not
	 * available for inclusion in new inbound HTLCs).
	 * Note that there are some corner cases not fully handled here, so the actual available
	 * inbound capacity may be slightly higher than this.
	 * 
	 * This value is not exact. Due to various in-flight changes, feerate changes, and our
	 * counterparty's conflict-avoidance policy, exactly this amount is not likely to be spendable.
	 * However, our counterparty should be able to spend nearly this amount.
	 */
	public void set_inbound_capacity_msat(long val) {
		bindings.ChannelDetails_set_inbound_capacity_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of required confirmations on the funding transaction before the funding will be
	 * considered \"locked\". This number is selected by the channel fundee (i.e. us if
	 * [`is_outbound`] is *not* set), and can be selected for inbound channels with
	 * [`ChannelHandshakeConfig::minimum_depth`] or limited for outbound channels with
	 * [`ChannelHandshakeLimits::max_minimum_depth`].
	 * 
	 * This value will be `None` for outbound channels until the counterparty accepts the channel.
	 * 
	 * [`is_outbound`]: ChannelDetails::is_outbound
	 * [`ChannelHandshakeConfig::minimum_depth`]: crate::util::config::ChannelHandshakeConfig::minimum_depth
	 * [`ChannelHandshakeLimits::max_minimum_depth`]: crate::util::config::ChannelHandshakeLimits::max_minimum_depth
	 */
	public org.ldk.structs.Option_u32Z get_confirmations_required() {
		long ret = bindings.ChannelDetails_get_confirmations_required(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u32Z ret_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The number of required confirmations on the funding transaction before the funding will be
	 * considered \"locked\". This number is selected by the channel fundee (i.e. us if
	 * [`is_outbound`] is *not* set), and can be selected for inbound channels with
	 * [`ChannelHandshakeConfig::minimum_depth`] or limited for outbound channels with
	 * [`ChannelHandshakeLimits::max_minimum_depth`].
	 * 
	 * This value will be `None` for outbound channels until the counterparty accepts the channel.
	 * 
	 * [`is_outbound`]: ChannelDetails::is_outbound
	 * [`ChannelHandshakeConfig::minimum_depth`]: crate::util::config::ChannelHandshakeConfig::minimum_depth
	 * [`ChannelHandshakeLimits::max_minimum_depth`]: crate::util::config::ChannelHandshakeLimits::max_minimum_depth
	 */
	public void set_confirmations_required(org.ldk.structs.Option_u32Z val) {
		bindings.ChannelDetails_set_confirmations_required(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The current number of confirmations on the funding transaction.
	 * 
	 * This value will be `None` for objects serialized with LDK versions prior to 0.0.113.
	 */
	public org.ldk.structs.Option_u32Z get_confirmations() {
		long ret = bindings.ChannelDetails_get_confirmations(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u32Z ret_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The current number of confirmations on the funding transaction.
	 * 
	 * This value will be `None` for objects serialized with LDK versions prior to 0.0.113.
	 */
	public void set_confirmations(org.ldk.structs.Option_u32Z val) {
		bindings.ChannelDetails_set_confirmations(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of blocks (after our commitment transaction confirms) that we will need to wait
	 * until we can claim our funds after we force-close the channel. During this time our
	 * counterparty is allowed to punish us if we broadcasted a stale state. If our counterparty
	 * force-closes the channel and broadcasts a commitment transaction we do not have to wait any
	 * time to claim our non-HTLC-encumbered funds.
	 * 
	 * This value will be `None` for outbound channels until the counterparty accepts the channel.
	 */
	public org.ldk.structs.Option_u16Z get_force_close_spend_delay() {
		long ret = bindings.ChannelDetails_get_force_close_spend_delay(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u16Z ret_hu_conv = org.ldk.structs.Option_u16Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The number of blocks (after our commitment transaction confirms) that we will need to wait
	 * until we can claim our funds after we force-close the channel. During this time our
	 * counterparty is allowed to punish us if we broadcasted a stale state. If our counterparty
	 * force-closes the channel and broadcasts a commitment transaction we do not have to wait any
	 * time to claim our non-HTLC-encumbered funds.
	 * 
	 * This value will be `None` for outbound channels until the counterparty accepts the channel.
	 */
	public void set_force_close_spend_delay(org.ldk.structs.Option_u16Z val) {
		bindings.ChannelDetails_set_force_close_spend_delay(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * True if the channel was initiated (and thus funded) by us.
	 */
	public bool get_is_outbound() {
		bool ret = bindings.ChannelDetails_get_is_outbound(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * True if the channel was initiated (and thus funded) by us.
	 */
	public void set_is_outbound(bool val) {
		bindings.ChannelDetails_set_is_outbound(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * True if the channel is confirmed, channel_ready messages have been exchanged, and the
	 * channel is not currently being shut down. `channel_ready` message exchange implies the
	 * required confirmation count has been reached (and we were connected to the peer at some
	 * point after the funding transaction received enough confirmations). The required
	 * confirmation count is provided in [`confirmations_required`].
	 * 
	 * [`confirmations_required`]: ChannelDetails::confirmations_required
	 */
	public bool get_is_channel_ready() {
		bool ret = bindings.ChannelDetails_get_is_channel_ready(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * True if the channel is confirmed, channel_ready messages have been exchanged, and the
	 * channel is not currently being shut down. `channel_ready` message exchange implies the
	 * required confirmation count has been reached (and we were connected to the peer at some
	 * point after the funding transaction received enough confirmations). The required
	 * confirmation count is provided in [`confirmations_required`].
	 * 
	 * [`confirmations_required`]: ChannelDetails::confirmations_required
	 */
	public void set_is_channel_ready(bool val) {
		bindings.ChannelDetails_set_is_channel_ready(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The stage of the channel's shutdown.
	 * `None` for `ChannelDetails` serialized on LDK versions prior to 0.0.116.
	 * 
	 * Returns a copy of the field.
	 */
	public org.ldk.structs.Option_ChannelShutdownStateZ get_channel_shutdown_state() {
		long ret = bindings.ChannelDetails_get_channel_shutdown_state(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ChannelShutdownStateZ ret_hu_conv = org.ldk.structs.Option_ChannelShutdownStateZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The stage of the channel's shutdown.
	 * `None` for `ChannelDetails` serialized on LDK versions prior to 0.0.116.
	 */
	public void set_channel_shutdown_state(org.ldk.structs.Option_ChannelShutdownStateZ val) {
		bindings.ChannelDetails_set_channel_shutdown_state(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * True if the channel is (a) confirmed and channel_ready messages have been exchanged, (b)
	 * the peer is connected, and (c) the channel is not currently negotiating a shutdown.
	 * 
	 * This is a strict superset of `is_channel_ready`.
	 */
	public bool get_is_usable() {
		bool ret = bindings.ChannelDetails_get_is_usable(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * True if the channel is (a) confirmed and channel_ready messages have been exchanged, (b)
	 * the peer is connected, and (c) the channel is not currently negotiating a shutdown.
	 * 
	 * This is a strict superset of `is_channel_ready`.
	 */
	public void set_is_usable(bool val) {
		bindings.ChannelDetails_set_is_usable(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * True if this channel is (or will be) publicly-announced.
	 */
	public bool get_is_announced() {
		bool ret = bindings.ChannelDetails_get_is_announced(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * True if this channel is (or will be) publicly-announced.
	 */
	public void set_is_announced(bool val) {
		bindings.ChannelDetails_set_is_announced(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The smallest value HTLC (in msat) we will accept, for this channel. This field
	 * is only `None` for `ChannelDetails` objects serialized prior to LDK 0.0.107
	 */
	public org.ldk.structs.Option_u64Z get_inbound_htlc_minimum_msat() {
		long ret = bindings.ChannelDetails_get_inbound_htlc_minimum_msat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The smallest value HTLC (in msat) we will accept, for this channel. This field
	 * is only `None` for `ChannelDetails` objects serialized prior to LDK 0.0.107
	 */
	public void set_inbound_htlc_minimum_msat(org.ldk.structs.Option_u64Z val) {
		bindings.ChannelDetails_set_inbound_htlc_minimum_msat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The largest value HTLC (in msat) we currently will accept, for this channel.
	 */
	public org.ldk.structs.Option_u64Z get_inbound_htlc_maximum_msat() {
		long ret = bindings.ChannelDetails_get_inbound_htlc_maximum_msat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The largest value HTLC (in msat) we currently will accept, for this channel.
	 */
	public void set_inbound_htlc_maximum_msat(org.ldk.structs.Option_u64Z val) {
		bindings.ChannelDetails_set_inbound_htlc_maximum_msat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Set of configurable parameters that affect channel operation.
	 * 
	 * This field is only `None` for `ChannelDetails` objects serialized prior to LDK 0.0.109.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.ChannelConfig get_config() {
		long ret = bindings.ChannelDetails_get_config(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Set of configurable parameters that affect channel operation.
	 * 
	 * This field is only `None` for `ChannelDetails` objects serialized prior to LDK 0.0.109.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_config(org.ldk.structs.ChannelConfig val) {
		bindings.ChannelDetails_set_config(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Pending inbound HTLCs.
	 * 
	 * This field is empty for objects serialized with LDK versions prior to 0.0.122.
	 */
	public InboundHTLCDetails[] get_pending_inbound_htlcs() {
		long ret = bindings.ChannelDetails_get_pending_inbound_htlcs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_20_len = InternalUtils.getArrayLength(ret);
		InboundHTLCDetails[] ret_conv_20_arr = new InboundHTLCDetails[ret_conv_20_len];
		for (int u = 0; u < ret_conv_20_len; u++) {
			long ret_conv_20 = InternalUtils.getU64ArrayElem(ret, u);
			org.ldk.structs.InboundHTLCDetails ret_conv_20_hu_conv = null; if (ret_conv_20 < 0 || ret_conv_20 > 4096) { ret_conv_20_hu_conv = new org.ldk.structs.InboundHTLCDetails(null, ret_conv_20); }
			if (ret_conv_20_hu_conv != null) { ret_conv_20_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_20_arr[u] = ret_conv_20_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_20_arr;
	}

	/**
	 * Pending inbound HTLCs.
	 * 
	 * This field is empty for objects serialized with LDK versions prior to 0.0.122.
	 */
	public void set_pending_inbound_htlcs(InboundHTLCDetails[] val) {
		bindings.ChannelDetails_set_pending_inbound_htlcs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_20 => val_conv_20.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Pending outbound HTLCs.
	 * 
	 * This field is empty for objects serialized with LDK versions prior to 0.0.122.
	 */
	public OutboundHTLCDetails[] get_pending_outbound_htlcs() {
		long ret = bindings.ChannelDetails_get_pending_outbound_htlcs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_21_len = InternalUtils.getArrayLength(ret);
		OutboundHTLCDetails[] ret_conv_21_arr = new OutboundHTLCDetails[ret_conv_21_len];
		for (int v = 0; v < ret_conv_21_len; v++) {
			long ret_conv_21 = InternalUtils.getU64ArrayElem(ret, v);
			org.ldk.structs.OutboundHTLCDetails ret_conv_21_hu_conv = null; if (ret_conv_21 < 0 || ret_conv_21 > 4096) { ret_conv_21_hu_conv = new org.ldk.structs.OutboundHTLCDetails(null, ret_conv_21); }
			if (ret_conv_21_hu_conv != null) { ret_conv_21_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_21_arr[v] = ret_conv_21_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_21_arr;
	}

	/**
	 * Pending outbound HTLCs.
	 * 
	 * This field is empty for objects serialized with LDK versions prior to 0.0.122.
	 */
	public void set_pending_outbound_htlcs(OutboundHTLCDetails[] val) {
		bindings.ChannelDetails_set_pending_outbound_htlcs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_21 => val_conv_21.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ChannelDetails given each field
	 * 
	 * Note that funding_txo_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that channel_type_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that config_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static org.ldk.structs.ChannelDetails of(org.ldk.structs.ChannelId channel_id_arg, org.ldk.structs.ChannelCounterparty counterparty_arg, org.ldk.structs.OutPoint funding_txo_arg, org.ldk.structs.ChannelTypeFeatures channel_type_arg, org.ldk.structs.Option_u64Z short_channel_id_arg, org.ldk.structs.Option_u64Z outbound_scid_alias_arg, org.ldk.structs.Option_u64Z inbound_scid_alias_arg, long channel_value_satoshis_arg, org.ldk.structs.Option_u64Z unspendable_punishment_reserve_arg, org.ldk.util.UInt128 user_channel_id_arg, org.ldk.structs.Option_u32Z feerate_sat_per_1000_weight_arg, long outbound_capacity_msat_arg, long next_outbound_htlc_limit_msat_arg, long next_outbound_htlc_minimum_msat_arg, long inbound_capacity_msat_arg, org.ldk.structs.Option_u32Z confirmations_required_arg, org.ldk.structs.Option_u32Z confirmations_arg, org.ldk.structs.Option_u16Z force_close_spend_delay_arg, bool is_outbound_arg, bool is_channel_ready_arg, org.ldk.structs.Option_ChannelShutdownStateZ channel_shutdown_state_arg, bool is_usable_arg, bool is_announced_arg, org.ldk.structs.Option_u64Z inbound_htlc_minimum_msat_arg, org.ldk.structs.Option_u64Z inbound_htlc_maximum_msat_arg, org.ldk.structs.ChannelConfig config_arg, InboundHTLCDetails[] pending_inbound_htlcs_arg, OutboundHTLCDetails[] pending_outbound_htlcs_arg) {
		long ret = bindings.ChannelDetails_new(channel_id_arg.ptr, counterparty_arg.ptr, funding_txo_arg == null ? 0 : funding_txo_arg.ptr, channel_type_arg == null ? 0 : channel_type_arg.ptr, short_channel_id_arg.ptr, outbound_scid_alias_arg.ptr, inbound_scid_alias_arg.ptr, channel_value_satoshis_arg, unspendable_punishment_reserve_arg.ptr, InternalUtils.encodeUint8Array(user_channel_id_arg.getLEBytes()), feerate_sat_per_1000_weight_arg.ptr, outbound_capacity_msat_arg, next_outbound_htlc_limit_msat_arg, next_outbound_htlc_minimum_msat_arg, inbound_capacity_msat_arg, confirmations_required_arg.ptr, confirmations_arg.ptr, force_close_spend_delay_arg.ptr, is_outbound_arg, is_channel_ready_arg, channel_shutdown_state_arg.ptr, is_usable_arg, is_announced_arg, inbound_htlc_minimum_msat_arg.ptr, inbound_htlc_maximum_msat_arg.ptr, config_arg == null ? 0 : config_arg.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(pending_inbound_htlcs_arg, pending_inbound_htlcs_arg_conv_20 => pending_inbound_htlcs_arg_conv_20.ptr)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(pending_outbound_htlcs_arg, pending_outbound_htlcs_arg_conv_21 => pending_outbound_htlcs_arg_conv_21.ptr)));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(counterparty_arg);
		GC.KeepAlive(funding_txo_arg);
		GC.KeepAlive(channel_type_arg);
		GC.KeepAlive(short_channel_id_arg);
		GC.KeepAlive(outbound_scid_alias_arg);
		GC.KeepAlive(inbound_scid_alias_arg);
		GC.KeepAlive(channel_value_satoshis_arg);
		GC.KeepAlive(unspendable_punishment_reserve_arg);
		GC.KeepAlive(user_channel_id_arg);
		GC.KeepAlive(feerate_sat_per_1000_weight_arg);
		GC.KeepAlive(outbound_capacity_msat_arg);
		GC.KeepAlive(next_outbound_htlc_limit_msat_arg);
		GC.KeepAlive(next_outbound_htlc_minimum_msat_arg);
		GC.KeepAlive(inbound_capacity_msat_arg);
		GC.KeepAlive(confirmations_required_arg);
		GC.KeepAlive(confirmations_arg);
		GC.KeepAlive(force_close_spend_delay_arg);
		GC.KeepAlive(is_outbound_arg);
		GC.KeepAlive(is_channel_ready_arg);
		GC.KeepAlive(channel_shutdown_state_arg);
		GC.KeepAlive(is_usable_arg);
		GC.KeepAlive(is_announced_arg);
		GC.KeepAlive(inbound_htlc_minimum_msat_arg);
		GC.KeepAlive(inbound_htlc_maximum_msat_arg);
		GC.KeepAlive(config_arg);
		GC.KeepAlive(pending_inbound_htlcs_arg);
		GC.KeepAlive(pending_outbound_htlcs_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ChannelDetails_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelDetails
	 */
	public org.ldk.structs.ChannelDetails clone() {
		long ret = bindings.ChannelDetails_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Gets the current SCID which should be used to identify this channel for inbound payments.
	 * This should be used for providing invoice hints or in any other context where our
	 * counterparty will forward a payment to us.
	 * 
	 * This is either the [`ChannelDetails::inbound_scid_alias`], if set, or the
	 * [`ChannelDetails::short_channel_id`]. See those for more information.
	 */
	public org.ldk.structs.Option_u64Z get_inbound_payment_scid() {
		long ret = bindings.ChannelDetails_get_inbound_payment_scid(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Gets the current SCID which should be used to identify this channel for outbound payments.
	 * This should be used in [`Route`]s to describe the first hop or in other contexts where
	 * we're sending or forwarding a payment outbound over this channel.
	 * 
	 * This is either the [`ChannelDetails::short_channel_id`], if set, or the
	 * [`ChannelDetails::outbound_scid_alias`]. See those for more information.
	 * 
	 * [`Route`]: crate::routing::router::Route
	 */
	public org.ldk.structs.Option_u64Z get_outbound_payment_scid() {
		long ret = bindings.ChannelDetails_get_outbound_payment_scid(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ChannelDetails object into a byte array which can be read by ChannelDetails_read
	 */
	public byte[] write() {
		long ret = bindings.ChannelDetails_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelDetails from a byte array, created by ChannelDetails_write
	 */
	public static org.ldk.structs.Result_ChannelDetailsDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelDetails_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelDetailsDecodeErrorZ ret_hu_conv = Result_ChannelDetailsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
