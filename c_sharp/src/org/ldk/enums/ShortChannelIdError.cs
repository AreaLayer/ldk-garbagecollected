namespace org { namespace ldk { namespace enums {/**
 * A `short_channel_id` construction error
 */
public enum ShortChannelIdError {
	/**
	 * Block height too high
	 */
	LDKShortChannelIdError_BlockOverflow,
	/**
	 * Tx index too high
	 */
	LDKShortChannelIdError_TxIndexOverflow,
	/**
	 * Vout index too high
	 */
	LDKShortChannelIdError_VoutIndexOverflow,
}} } }
