namespace org { namespace ldk { namespace enums {/**
 * Indicates an immediate error on [`ChannelManager::send_payment`]. Further errors may be
 * surfaced later via [`Event::PaymentPathFailed`] and [`Event::PaymentFailed`].
 * 
 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
 * [`Event::PaymentPathFailed`]: crate::events::Event::PaymentPathFailed
 * [`Event::PaymentFailed`]: crate::events::Event::PaymentFailed
 */
public enum RetryableSendFailure {
	/**
	 * The provided [`PaymentParameters::expiry_time`] indicated that the payment has expired. Note
	 * that this error is *not* caused by [`Retry::Timeout`].
	 * 
	 * [`PaymentParameters::expiry_time`]: crate::routing::router::PaymentParameters::expiry_time
	 */
	LDKRetryableSendFailure_PaymentExpired,
	/**
	 * We were unable to find a route to the destination.
	 */
	LDKRetryableSendFailure_RouteNotFound,
	/**
	 * Indicates that a payment for the provided [`PaymentId`] is already in-flight and has not
	 * yet completed (i.e. generated an [`Event::PaymentSent`] or [`Event::PaymentFailed`]).
	 * 
	 * [`PaymentId`]: crate::ln::channelmanager::PaymentId
	 * [`Event::PaymentSent`]: crate::events::Event::PaymentSent
	 * [`Event::PaymentFailed`]: crate::events::Event::PaymentFailed
	 */
	LDKRetryableSendFailure_DuplicatePayment,
	/**
	 * The [`RecipientOnionFields::payment_metadata`], [`RecipientOnionFields::custom_tlvs`], or
	 * [`BlindedPaymentPath`]s provided are too large and caused us to exceed the maximum onion
	 * packet size of 1300 bytes.
	 * 
	 * [`BlindedPaymentPath`]: crate::blinded_path::payment::BlindedPaymentPath
	 */
	LDKRetryableSendFailure_OnionPacketSizeExceeded,
}} } }
