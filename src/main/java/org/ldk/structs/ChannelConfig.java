package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Options which apply on a per-channel basis and may change at runtime or based on negotiation
 * with our counterparty.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ChannelConfig extends CommonBase {
	ChannelConfig(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ChannelConfig_free(ptr); }
	}

	/**
	 * Amount (in millionths of a satoshi) charged per satoshi for payments forwarded outbound
	 * over the channel.
	 * This may be allowed to change at runtime in a later update, however doing so must result in
	 * update messages sent to notify all nodes of our updated relay fee.
	 * 
	 * Default value: `0`
	 */
	public int get_forwarding_fee_proportional_millionths() {
		int ret = bindings.ChannelConfig_get_forwarding_fee_proportional_millionths(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Amount (in millionths of a satoshi) charged per satoshi for payments forwarded outbound
	 * over the channel.
	 * This may be allowed to change at runtime in a later update, however doing so must result in
	 * update messages sent to notify all nodes of our updated relay fee.
	 * 
	 * Default value: `0`
	 */
	public void set_forwarding_fee_proportional_millionths(int val) {
		bindings.ChannelConfig_set_forwarding_fee_proportional_millionths(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Amount (in milli-satoshi) charged for payments forwarded outbound over the channel, in
	 * excess of [`forwarding_fee_proportional_millionths`].
	 * This may be allowed to change at runtime in a later update, however doing so must result in
	 * update messages sent to notify all nodes of our updated relay fee.
	 * 
	 * The default value of a single satoshi roughly matches the market rate on many routing nodes
	 * as of July 2021. Adjusting it upwards or downwards may change whether nodes route through
	 * this node.
	 * 
	 * Default value: `1000`
	 * 
	 * [`forwarding_fee_proportional_millionths`]: ChannelConfig::forwarding_fee_proportional_millionths
	 */
	public int get_forwarding_fee_base_msat() {
		int ret = bindings.ChannelConfig_get_forwarding_fee_base_msat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Amount (in milli-satoshi) charged for payments forwarded outbound over the channel, in
	 * excess of [`forwarding_fee_proportional_millionths`].
	 * This may be allowed to change at runtime in a later update, however doing so must result in
	 * update messages sent to notify all nodes of our updated relay fee.
	 * 
	 * The default value of a single satoshi roughly matches the market rate on many routing nodes
	 * as of July 2021. Adjusting it upwards or downwards may change whether nodes route through
	 * this node.
	 * 
	 * Default value: `1000`
	 * 
	 * [`forwarding_fee_proportional_millionths`]: ChannelConfig::forwarding_fee_proportional_millionths
	 */
	public void set_forwarding_fee_base_msat(int val) {
		bindings.ChannelConfig_set_forwarding_fee_base_msat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The difference in the CLTV value between incoming HTLCs and an outbound HTLC forwarded over
	 * the channel this config applies to.
	 * 
	 * This is analogous to [`ChannelHandshakeConfig::our_to_self_delay`] but applies to in-flight
	 * HTLC balance when a channel appears on-chain whereas
	 * [`ChannelHandshakeConfig::our_to_self_delay`] applies to the remaining
	 * (non-HTLC-encumbered) balance.
	 * 
	 * Thus, for HTLC-encumbered balances to be enforced on-chain when a channel is force-closed,
	 * we (or one of our watchtowers) MUST be online to check for broadcast of the current
	 * commitment transaction at least once per this many blocks (minus some margin to allow us
	 * enough time to broadcast and confirm a transaction, possibly with time in between to RBF
	 * the spending transaction).
	 * 
	 * Default value: `72` (12 hours at an average of 6 blocks/hour)
	 * 
	 * Minimum value: [`MIN_CLTV_EXPIRY_DELTA`] (Any values less than this will be treated as
	 * [`MIN_CLTV_EXPIRY_DELTA`] instead.)
	 * 
	 * [`MIN_CLTV_EXPIRY_DELTA`]: crate::ln::channelmanager::MIN_CLTV_EXPIRY_DELTA
	 */
	public short get_cltv_expiry_delta() {
		short ret = bindings.ChannelConfig_get_cltv_expiry_delta(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The difference in the CLTV value between incoming HTLCs and an outbound HTLC forwarded over
	 * the channel this config applies to.
	 * 
	 * This is analogous to [`ChannelHandshakeConfig::our_to_self_delay`] but applies to in-flight
	 * HTLC balance when a channel appears on-chain whereas
	 * [`ChannelHandshakeConfig::our_to_self_delay`] applies to the remaining
	 * (non-HTLC-encumbered) balance.
	 * 
	 * Thus, for HTLC-encumbered balances to be enforced on-chain when a channel is force-closed,
	 * we (or one of our watchtowers) MUST be online to check for broadcast of the current
	 * commitment transaction at least once per this many blocks (minus some margin to allow us
	 * enough time to broadcast and confirm a transaction, possibly with time in between to RBF
	 * the spending transaction).
	 * 
	 * Default value: `72` (12 hours at an average of 6 blocks/hour)
	 * 
	 * Minimum value: [`MIN_CLTV_EXPIRY_DELTA`] (Any values less than this will be treated as
	 * [`MIN_CLTV_EXPIRY_DELTA`] instead.)
	 * 
	 * [`MIN_CLTV_EXPIRY_DELTA`]: crate::ln::channelmanager::MIN_CLTV_EXPIRY_DELTA
	 */
	public void set_cltv_expiry_delta(short val) {
		bindings.ChannelConfig_set_cltv_expiry_delta(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Limit our total exposure to potential loss to on-chain fees on close, including in-flight
	 * HTLCs which are burned to fees as they are too small to claim on-chain and fees on
	 * commitment transaction(s) broadcasted by our counterparty in excess of our own fee estimate.
	 * 
	 * # HTLC-based Dust Exposure
	 * 
	 * When an HTLC present in one of our channels is below a \"dust\" threshold, the HTLC will
	 * not be claimable on-chain, instead being turned into additional miner fees if either
	 * party force-closes the channel. Because the threshold is per-HTLC, our total exposure
	 * to such payments may be substantial if there are many dust HTLCs present when the
	 * channel is force-closed.
	 * 
	 * The dust threshold for each HTLC is based on the `dust_limit_satoshis` for each party in a
	 * channel negotiated throughout the channel open process, along with the fees required to have
	 * a broadcastable HTLC spending transaction. When a channel supports anchor outputs
	 * (specifically the zero fee HTLC transaction variant), this threshold no longer takes into
	 * account the HTLC transaction fee as it is zero. Because of this, you may want to set this
	 * value to a fixed limit for channels using anchor outputs, while the fee rate multiplier
	 * variant is primarily intended for use with pre-anchor channels.
	 * 
	 * The selected limit is applied for sent, forwarded, and received HTLCs and limits the total
	 * exposure across all three types per-channel.
	 * 
	 * # Transaction Fee Dust Exposure
	 * 
	 * Further, counterparties broadcasting a commitment transaction in a force-close may result
	 * in other balance being burned to fees, and thus all fees on commitment and HTLC
	 * transactions in excess of our local fee estimates are included in the dust calculation.
	 * 
	 * Because of this, another way to look at this limit is to divide it by 43,000 (or 218,750
	 * for non-anchor channels) and see it as the maximum feerate disagreement (in sats/vB) per
	 * non-dust HTLC we're allowed to have with our peers before risking a force-closure for
	 * inbound channels.
	 * 
	 * Thus, for the default value of 10_000 * a current feerate estimate of 10 sat/vB (or 2,500
	 * sat/KW), we risk force-closure if we disagree with our peer by:
	 * `10_000 * 2_500 / 43_000 / (483*2)` = 0.6 sat/vB for anchor channels with 483 HTLCs in
	 * both directions (the maximum),
	 * `10_000 * 2_500 / 43_000 / (50*2)` = 5.8 sat/vB for anchor channels with 50 HTLCs in both
	 * directions (the LDK default max from [`ChannelHandshakeConfig::our_max_accepted_htlcs`])
	 * `10_000 * 2_500 / 218_750 / (483*2)` = 0.1 sat/vB for non-anchor channels with 483 HTLCs
	 * in both directions (the maximum),
	 * `10_000 * 2_500 / 218_750 / (50*2)` = 1.1 sat/vB for non-anchor channels with 50 HTLCs
	 * in both (the LDK default maximum from [`ChannelHandshakeConfig::our_max_accepted_htlcs`])
	 * 
	 * Note that when using [`MaxDustHTLCExposure::FeeRateMultiplier`] this maximum disagreement
	 * will scale linearly with increases (or decreases) in the our feerate estimates. Further,
	 * for anchor channels we expect our counterparty to use a relatively low feerate estimate
	 * while we use [`ConfirmationTarget::MaximumFeeEstimate`] (which should be relatively high)
	 * and feerate disagreement force-closures should only occur when theirs is higher than ours.
	 * 
	 * Default value: [`MaxDustHTLCExposure::FeeRateMultiplier`] with a multiplier of `10_000`
	 * 
	 * [`ConfirmationTarget::MaximumFeeEstimate`]: crate::chain::chaininterface::ConfirmationTarget::MaximumFeeEstimate
	 */
	public MaxDustHTLCExposure get_max_dust_htlc_exposure() {
		long ret = bindings.ChannelConfig_get_max_dust_htlc_exposure(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MaxDustHTLCExposure ret_hu_conv = org.ldk.structs.MaxDustHTLCExposure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Limit our total exposure to potential loss to on-chain fees on close, including in-flight
	 * HTLCs which are burned to fees as they are too small to claim on-chain and fees on
	 * commitment transaction(s) broadcasted by our counterparty in excess of our own fee estimate.
	 * 
	 * # HTLC-based Dust Exposure
	 * 
	 * When an HTLC present in one of our channels is below a \"dust\" threshold, the HTLC will
	 * not be claimable on-chain, instead being turned into additional miner fees if either
	 * party force-closes the channel. Because the threshold is per-HTLC, our total exposure
	 * to such payments may be substantial if there are many dust HTLCs present when the
	 * channel is force-closed.
	 * 
	 * The dust threshold for each HTLC is based on the `dust_limit_satoshis` for each party in a
	 * channel negotiated throughout the channel open process, along with the fees required to have
	 * a broadcastable HTLC spending transaction. When a channel supports anchor outputs
	 * (specifically the zero fee HTLC transaction variant), this threshold no longer takes into
	 * account the HTLC transaction fee as it is zero. Because of this, you may want to set this
	 * value to a fixed limit for channels using anchor outputs, while the fee rate multiplier
	 * variant is primarily intended for use with pre-anchor channels.
	 * 
	 * The selected limit is applied for sent, forwarded, and received HTLCs and limits the total
	 * exposure across all three types per-channel.
	 * 
	 * # Transaction Fee Dust Exposure
	 * 
	 * Further, counterparties broadcasting a commitment transaction in a force-close may result
	 * in other balance being burned to fees, and thus all fees on commitment and HTLC
	 * transactions in excess of our local fee estimates are included in the dust calculation.
	 * 
	 * Because of this, another way to look at this limit is to divide it by 43,000 (or 218,750
	 * for non-anchor channels) and see it as the maximum feerate disagreement (in sats/vB) per
	 * non-dust HTLC we're allowed to have with our peers before risking a force-closure for
	 * inbound channels.
	 * 
	 * Thus, for the default value of 10_000 * a current feerate estimate of 10 sat/vB (or 2,500
	 * sat/KW), we risk force-closure if we disagree with our peer by:
	 * `10_000 * 2_500 / 43_000 / (483*2)` = 0.6 sat/vB for anchor channels with 483 HTLCs in
	 * both directions (the maximum),
	 * `10_000 * 2_500 / 43_000 / (50*2)` = 5.8 sat/vB for anchor channels with 50 HTLCs in both
	 * directions (the LDK default max from [`ChannelHandshakeConfig::our_max_accepted_htlcs`])
	 * `10_000 * 2_500 / 218_750 / (483*2)` = 0.1 sat/vB for non-anchor channels with 483 HTLCs
	 * in both directions (the maximum),
	 * `10_000 * 2_500 / 218_750 / (50*2)` = 1.1 sat/vB for non-anchor channels with 50 HTLCs
	 * in both (the LDK default maximum from [`ChannelHandshakeConfig::our_max_accepted_htlcs`])
	 * 
	 * Note that when using [`MaxDustHTLCExposure::FeeRateMultiplier`] this maximum disagreement
	 * will scale linearly with increases (or decreases) in the our feerate estimates. Further,
	 * for anchor channels we expect our counterparty to use a relatively low feerate estimate
	 * while we use [`ConfirmationTarget::MaximumFeeEstimate`] (which should be relatively high)
	 * and feerate disagreement force-closures should only occur when theirs is higher than ours.
	 * 
	 * Default value: [`MaxDustHTLCExposure::FeeRateMultiplier`] with a multiplier of `10_000`
	 * 
	 * [`ConfirmationTarget::MaximumFeeEstimate`]: crate::chain::chaininterface::ConfirmationTarget::MaximumFeeEstimate
	 */
	public void set_max_dust_htlc_exposure(org.ldk.structs.MaxDustHTLCExposure val) {
		bindings.ChannelConfig_set_max_dust_htlc_exposure(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The additional fee we're willing to pay to avoid waiting for the counterparty's
	 * `to_self_delay` to reclaim funds.
	 * 
	 * When we close a channel cooperatively with our counterparty, we negotiate a fee for the
	 * closing transaction which both sides find acceptable, ultimately paid by the channel
	 * funder/initiator.
	 * 
	 * When we are the funder, because we have to pay the channel closing fee, we bound the
	 * acceptable fee by our [`ChannelCloseMinimum`] and [`NonAnchorChannelFee`] fees, with the upper bound increased by
	 * this value. Because the on-chain fee we'd pay to force-close the channel is kept near our
	 * [`NonAnchorChannelFee`] feerate during normal operation, this value represents the additional fee we're
	 * willing to pay in order to avoid waiting for our counterparty's to_self_delay to reclaim our
	 * funds.
	 * 
	 * When we are not the funder, we require the closing transaction fee pay at least our
	 * [`ChannelCloseMinimum`] fee estimate, but allow our counterparty to pay as much fee as they like.
	 * Thus, this value is ignored when we are not the funder.
	 * 
	 * Default value: `1000`
	 * 
	 * [`NonAnchorChannelFee`]: crate::chain::chaininterface::ConfirmationTarget::NonAnchorChannelFee
	 * [`ChannelCloseMinimum`]: crate::chain::chaininterface::ConfirmationTarget::ChannelCloseMinimum
	 */
	public long get_force_close_avoidance_max_fee_satoshis() {
		long ret = bindings.ChannelConfig_get_force_close_avoidance_max_fee_satoshis(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The additional fee we're willing to pay to avoid waiting for the counterparty's
	 * `to_self_delay` to reclaim funds.
	 * 
	 * When we close a channel cooperatively with our counterparty, we negotiate a fee for the
	 * closing transaction which both sides find acceptable, ultimately paid by the channel
	 * funder/initiator.
	 * 
	 * When we are the funder, because we have to pay the channel closing fee, we bound the
	 * acceptable fee by our [`ChannelCloseMinimum`] and [`NonAnchorChannelFee`] fees, with the upper bound increased by
	 * this value. Because the on-chain fee we'd pay to force-close the channel is kept near our
	 * [`NonAnchorChannelFee`] feerate during normal operation, this value represents the additional fee we're
	 * willing to pay in order to avoid waiting for our counterparty's to_self_delay to reclaim our
	 * funds.
	 * 
	 * When we are not the funder, we require the closing transaction fee pay at least our
	 * [`ChannelCloseMinimum`] fee estimate, but allow our counterparty to pay as much fee as they like.
	 * Thus, this value is ignored when we are not the funder.
	 * 
	 * Default value: `1000`
	 * 
	 * [`NonAnchorChannelFee`]: crate::chain::chaininterface::ConfirmationTarget::NonAnchorChannelFee
	 * [`ChannelCloseMinimum`]: crate::chain::chaininterface::ConfirmationTarget::ChannelCloseMinimum
	 */
	public void set_force_close_avoidance_max_fee_satoshis(long val) {
		bindings.ChannelConfig_set_force_close_avoidance_max_fee_satoshis(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * If set, allows this channel's counterparty to skim an additional fee off this node's inbound
	 * HTLCs. Useful for liquidity providers to offload on-chain channel costs to end users.
	 * 
	 * Usage:
	 * - The payee will set this option and set its invoice route hints to use [intercept scids]
	 * generated by this channel's counterparty.
	 * - The counterparty will get an [`HTLCIntercepted`] event upon payment forward, and call
	 * [`forward_intercepted_htlc`] with less than the amount provided in
	 * [`HTLCIntercepted::expected_outbound_amount_msat`]. The difference between the expected and
	 * actual forward amounts is their fee. See
	 * <https://github.com/BitcoinAndLightningLayerSpecs/lsp/tree/main/LSPS2#flow-lsp-trusts-client-model>
	 * for how this feature may be used in the LSP use case.
	 * 
	 * # Note
	 * It's important for payee wallet software to verify that [`PaymentClaimable::amount_msat`] is
	 * as-expected if this feature is activated, otherwise they may lose money!
	 * [`PaymentClaimable::counterparty_skimmed_fee_msat`] provides the fee taken by the
	 * counterparty.
	 * 
	 * # Note
	 * Switching this config flag on may break compatibility with versions of LDK prior to 0.0.116.
	 * Unsetting this flag between restarts may lead to payment receive failures.
	 * 
	 * Default value: `false`
	 * 
	 * [intercept scids]: crate::ln::channelmanager::ChannelManager::get_intercept_scid
	 * [`forward_intercepted_htlc`]: crate::ln::channelmanager::ChannelManager::forward_intercepted_htlc
	 * [`HTLCIntercepted`]: crate::events::Event::HTLCIntercepted
	 * [`HTLCIntercepted::expected_outbound_amount_msat`]: crate::events::Event::HTLCIntercepted::expected_outbound_amount_msat
	 * [`PaymentClaimable::amount_msat`]: crate::events::Event::PaymentClaimable::amount_msat
	 * [`PaymentClaimable::counterparty_skimmed_fee_msat`]: crate::events::Event::PaymentClaimable::counterparty_skimmed_fee_msat
	 */
	public boolean get_accept_underpaying_htlcs() {
		boolean ret = bindings.ChannelConfig_get_accept_underpaying_htlcs(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * If set, allows this channel's counterparty to skim an additional fee off this node's inbound
	 * HTLCs. Useful for liquidity providers to offload on-chain channel costs to end users.
	 * 
	 * Usage:
	 * - The payee will set this option and set its invoice route hints to use [intercept scids]
	 * generated by this channel's counterparty.
	 * - The counterparty will get an [`HTLCIntercepted`] event upon payment forward, and call
	 * [`forward_intercepted_htlc`] with less than the amount provided in
	 * [`HTLCIntercepted::expected_outbound_amount_msat`]. The difference between the expected and
	 * actual forward amounts is their fee. See
	 * <https://github.com/BitcoinAndLightningLayerSpecs/lsp/tree/main/LSPS2#flow-lsp-trusts-client-model>
	 * for how this feature may be used in the LSP use case.
	 * 
	 * # Note
	 * It's important for payee wallet software to verify that [`PaymentClaimable::amount_msat`] is
	 * as-expected if this feature is activated, otherwise they may lose money!
	 * [`PaymentClaimable::counterparty_skimmed_fee_msat`] provides the fee taken by the
	 * counterparty.
	 * 
	 * # Note
	 * Switching this config flag on may break compatibility with versions of LDK prior to 0.0.116.
	 * Unsetting this flag between restarts may lead to payment receive failures.
	 * 
	 * Default value: `false`
	 * 
	 * [intercept scids]: crate::ln::channelmanager::ChannelManager::get_intercept_scid
	 * [`forward_intercepted_htlc`]: crate::ln::channelmanager::ChannelManager::forward_intercepted_htlc
	 * [`HTLCIntercepted`]: crate::events::Event::HTLCIntercepted
	 * [`HTLCIntercepted::expected_outbound_amount_msat`]: crate::events::Event::HTLCIntercepted::expected_outbound_amount_msat
	 * [`PaymentClaimable::amount_msat`]: crate::events::Event::PaymentClaimable::amount_msat
	 * [`PaymentClaimable::counterparty_skimmed_fee_msat`]: crate::events::Event::PaymentClaimable::counterparty_skimmed_fee_msat
	 */
	public void set_accept_underpaying_htlcs(boolean val) {
		bindings.ChannelConfig_set_accept_underpaying_htlcs(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new ChannelConfig given each field
	 */
	public static ChannelConfig of(int forwarding_fee_proportional_millionths_arg, int forwarding_fee_base_msat_arg, short cltv_expiry_delta_arg, org.ldk.structs.MaxDustHTLCExposure max_dust_htlc_exposure_arg, long force_close_avoidance_max_fee_satoshis_arg, boolean accept_underpaying_htlcs_arg) {
		long ret = bindings.ChannelConfig_new(forwarding_fee_proportional_millionths_arg, forwarding_fee_base_msat_arg, cltv_expiry_delta_arg, max_dust_htlc_exposure_arg.ptr, force_close_avoidance_max_fee_satoshis_arg, accept_underpaying_htlcs_arg);
		Reference.reachabilityFence(forwarding_fee_proportional_millionths_arg);
		Reference.reachabilityFence(forwarding_fee_base_msat_arg);
		Reference.reachabilityFence(cltv_expiry_delta_arg);
		Reference.reachabilityFence(max_dust_htlc_exposure_arg);
		Reference.reachabilityFence(force_close_avoidance_max_fee_satoshis_arg);
		Reference.reachabilityFence(accept_underpaying_htlcs_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.ChannelConfig_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelConfig
	 */
	public ChannelConfig clone() {
		long ret = bindings.ChannelConfig_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ChannelConfigs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.ChannelConfig b) {
		boolean ret = bindings.ChannelConfig_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof ChannelConfig)) return false;
		return this.eq((ChannelConfig)o);
	}
	/**
	 * Applies the given [`ChannelConfigUpdate`] as a partial update to the [`ChannelConfig`].
	 */
	public void apply(org.ldk.structs.ChannelConfigUpdate update) {
		bindings.ChannelConfig_apply(this.ptr, update.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(update);
		if (this != null) { this.ptrs_to.add(update); };
	}

	/**
	 * Creates a "default" ChannelConfig. See struct and individual field documentaiton for details on which values are used.
	 */
	public static ChannelConfig with_default() {
		long ret = bindings.ChannelConfig_default();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ChannelConfig object into a byte array which can be read by ChannelConfig_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelConfig_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a ChannelConfig from a byte array, created by ChannelConfig_write
	 */
	public static Result_ChannelConfigDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelConfig_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelConfigDecodeErrorZ ret_hu_conv = Result_ChannelConfigDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
