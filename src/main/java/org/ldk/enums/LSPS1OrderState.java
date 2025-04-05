package org.ldk.enums;

/**
 * An object representing the status of an order.
 */
public enum LSPS1OrderState {
	/**
	 * The order has been created.
	 */
	LDKLSPS1OrderState_Created,
	/**
	 * The LSP has opened the channel and published the funding transaction.
	 */
	LDKLSPS1OrderState_Completed,
	/**
	 * The order failed.
	 */
	LDKLSPS1OrderState_Failed,
	; static native void init();
	static { org.ldk.impl.bindings.run_statics(); init(); }
}