namespace org { namespace ldk { namespace enums {/**
 * The state of a payment.
 * 
 * Note*: Previously, the spec also knew a `CANCELLED` state for BOLT11 payments, which has since
 * been deprecated and `REFUNDED` should be used instead.
 */
public enum LSPS1PaymentState {
	/**
	 * A payment is expected.
	 */
	LDKLSPS1PaymentState_ExpectPayment,
	/**
	 * A sufficient payment has been received.
	 */
	LDKLSPS1PaymentState_Paid,
	/**
	 * The payment has been refunded.
	 */
	LDKLSPS1PaymentState_Refunded,
}} } }
