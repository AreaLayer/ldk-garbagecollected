namespace org { namespace ldk { namespace enums {/**
 * Errors that may occur when constructing a new [`RawBolt11Invoice`] or [`Bolt11Invoice`]
 */
public enum CreationError {
	/**
	 * The supplied description string was longer than 639 __bytes__ (see [`Description::new`])
	 */
	LDKCreationError_DescriptionTooLong,
	/**
	 * The specified route has too many hops and can't be encoded
	 */
	LDKCreationError_RouteTooLong,
	/**
	 * The Unix timestamp of the supplied date is less than zero or greater than 35-bits
	 */
	LDKCreationError_TimestampOutOfBounds,
	/**
	 * The supplied millisatoshi amount was greater than the total bitcoin supply.
	 */
	LDKCreationError_InvalidAmount,
	/**
	 * Route hints were required for this invoice and were missing.
	 */
	LDKCreationError_MissingRouteHints,
	/**
	 * The provided `min_final_cltv_expiry_delta` was less than rust-lightning's minimum.
	 */
	LDKCreationError_MinFinalCltvExpiryDeltaTooShort,
}} } }
