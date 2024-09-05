package org.ldk.enums;

/**
 * Indicates whether the balance is derived from a cooperative close, a force-close
 * (for holder or counterparty), or whether it is for an HTLC.
 */
public enum BalanceSource {
	/**
	 * The channel was force closed by the holder.
	 */
	LDKBalanceSource_HolderForceClosed,
	/**
	 * The channel was force closed by the counterparty.
	 */
	LDKBalanceSource_CounterpartyForceClosed,
	/**
	 * The channel was cooperatively closed.
	 */
	LDKBalanceSource_CoopClose,
	/**
	 * This balance is the result of an HTLC.
	 */
	LDKBalanceSource_Htlc,
	; static native void init();
	static { org.ldk.impl.bindings.run_statics(); init(); }
}