namespace org { namespace ldk { namespace enums {/**
 * Exposes the state of pending outbound HTLCs.
 * 
 * At a high level, an HTLC being forwarded from one Lightning node to another Lightning node goes
 * through the following states in the state machine:
 * - Announced for addition by the originating node through the update_add_htlc message.
 * - Added to the commitment transaction of the receiving node and originating node in turn
 * through the exchange of commitment_signed and revoke_and_ack messages.
 * - Announced for resolution (fulfillment or failure) by the receiving node through either one of
 * the update_fulfill_htlc, update_fail_htlc, and update_fail_malformed_htlc messages.
 * - Removed from the commitment transaction of the originating node and receiving node in turn
 * through the exchange of commitment_signed and revoke_and_ack messages.
 * 
 * This can be used to inspect what next message an HTLC is waiting for to advance its state.
 */
public enum OutboundHTLCStateDetails {
	/**
	 * We are awaiting the appropriate revoke_and_ack's from the remote before the HTLC is added
	 * on the remote's commitment transaction after update_add_htlc.
	 */
	LDKOutboundHTLCStateDetails_AwaitingRemoteRevokeToAdd,
	/**
	 * The HTLC has been added to the remote's commitment transaction by sending commitment_signed
	 * and receiving revoke_and_ack in return.
	 * 
	 * The HTLC will remain in this state until the remote node resolves the HTLC, or until we
	 * unilaterally close the channel due to a timeout with an uncooperative remote node.
	 */
	LDKOutboundHTLCStateDetails_Committed,
	/**
	 * The HTLC has been fulfilled successfully by the remote with a preimage in update_fulfill_htlc,
	 * and we removed the HTLC from our commitment transaction by receiving commitment_signed and
	 * returning revoke_and_ack. We are awaiting the appropriate revoke_and_ack's from the remote
	 * for the removal from its commitment transaction.
	 */
	LDKOutboundHTLCStateDetails_AwaitingRemoteRevokeToRemoveSuccess,
	/**
	 * The HTLC has been failed by the remote with update_fail_htlc or update_fail_malformed_htlc,
	 * and we removed the HTLC from our commitment transaction by receiving commitment_signed and
	 * returning revoke_and_ack. We are awaiting the appropriate revoke_and_ack's from the remote
	 * for the removal from its commitment transaction.
	 */
	LDKOutboundHTLCStateDetails_AwaitingRemoteRevokeToRemoveFailure,
}} } }
