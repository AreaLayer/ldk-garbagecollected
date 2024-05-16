package org.ldk.enums;

/**
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
	; static native void init();
	static { org.ldk.impl.bindings.run_statics(); init(); }
}