package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The current status of the output spend.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class OutputSpendStatus extends CommonBase {
	private OutputSpendStatus(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.OutputSpendStatus_free(ptr); }
	}
	static OutputSpendStatus constr_from_ptr(long ptr) {
		bindings.LDKOutputSpendStatus raw_val = bindings.LDKOutputSpendStatus_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKOutputSpendStatus.PendingInitialBroadcast.class) {
			return new PendingInitialBroadcast(ptr, (bindings.LDKOutputSpendStatus.PendingInitialBroadcast)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKOutputSpendStatus.PendingFirstConfirmation.class) {
			return new PendingFirstConfirmation(ptr, (bindings.LDKOutputSpendStatus.PendingFirstConfirmation)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKOutputSpendStatus.PendingThresholdConfirmations.class) {
			return new PendingThresholdConfirmations(ptr, (bindings.LDKOutputSpendStatus.PendingThresholdConfirmations)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * The output is tracked but an initial spending transaction hasn't been generated and
	 * broadcasted yet.
	 */
	public final static class PendingInitialBroadcast extends OutputSpendStatus {
		/**
		 * The height at which we will first generate and broadcast a spending transaction.
		*/
		public final org.ldk.structs.Option_u32Z delayed_until_height;
		private PendingInitialBroadcast(long ptr, bindings.LDKOutputSpendStatus.PendingInitialBroadcast obj) {
			super(null, ptr);
			long delayed_until_height = obj.delayed_until_height;
			org.ldk.structs.Option_u32Z delayed_until_height_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(delayed_until_height);
			if (delayed_until_height_hu_conv != null) { delayed_until_height_hu_conv.ptrs_to.add(this); };
			this.delayed_until_height = delayed_until_height_hu_conv;
		}
	}
	/**
	 * A transaction spending the output has been broadcasted but is pending its first confirmation on-chain.
	 */
	public final static class PendingFirstConfirmation extends OutputSpendStatus {
		/**
		 * The hash of the chain tip when we first broadcast a transaction spending this output.
		*/
		public final byte[] first_broadcast_hash;
		/**
		 * The best height when we last broadcast a transaction spending this output.
		*/
		public final int latest_broadcast_height;
		/**
		 * The transaction spending this output we last broadcasted.
		*/
		public final byte[] latest_spending_tx;
		private PendingFirstConfirmation(long ptr, bindings.LDKOutputSpendStatus.PendingFirstConfirmation obj) {
			super(null, ptr);
			this.first_broadcast_hash = obj.first_broadcast_hash;
			this.latest_broadcast_height = obj.latest_broadcast_height;
			this.latest_spending_tx = obj.latest_spending_tx;
		}
	}
	/**
	 * A transaction spending the output has been confirmed on-chain but will be tracked until it
	 * reaches at least [`PRUNE_DELAY_BLOCKS`] confirmations to ensure [`Event::SpendableOutputs`]
	 * stemming from lingering [`ChannelMonitor`]s can safely be replayed.
	 * 
	 * [`Event::SpendableOutputs`]: crate::events::Event::SpendableOutputs
	 * [`ChannelMonitor`]: crate::chain::channelmonitor::ChannelMonitor
	 */
	public final static class PendingThresholdConfirmations extends OutputSpendStatus {
		/**
		 * The hash of the chain tip when we first broadcast a transaction spending this output.
		*/
		public final byte[] first_broadcast_hash;
		/**
		 * The best height when we last broadcast a transaction spending this output.
		*/
		public final int latest_broadcast_height;
		/**
		 * The transaction spending this output we saw confirmed on-chain.
		*/
		public final byte[] latest_spending_tx;
		/**
		 * The height at which the spending transaction was confirmed.
		*/
		public final int confirmation_height;
		/**
		 * The hash of the block in which the spending transaction was confirmed.
		*/
		public final byte[] confirmation_hash;
		private PendingThresholdConfirmations(long ptr, bindings.LDKOutputSpendStatus.PendingThresholdConfirmations obj) {
			super(null, ptr);
			this.first_broadcast_hash = obj.first_broadcast_hash;
			this.latest_broadcast_height = obj.latest_broadcast_height;
			this.latest_spending_tx = obj.latest_spending_tx;
			this.confirmation_height = obj.confirmation_height;
			this.confirmation_hash = obj.confirmation_hash;
		}
	}
	long clone_ptr() {
		long ret = bindings.OutputSpendStatus_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the OutputSpendStatus
	 */
	public OutputSpendStatus clone() {
		long ret = bindings.OutputSpendStatus_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PendingInitialBroadcast-variant OutputSpendStatus
	 */
	public static OutputSpendStatus pending_initial_broadcast(org.ldk.structs.Option_u32Z delayed_until_height) {
		long ret = bindings.OutputSpendStatus_pending_initial_broadcast(delayed_until_height.ptr);
		Reference.reachabilityFence(delayed_until_height);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PendingFirstConfirmation-variant OutputSpendStatus
	 */
	public static OutputSpendStatus pending_first_confirmation(byte[] first_broadcast_hash, int latest_broadcast_height, byte[] latest_spending_tx) {
		long ret = bindings.OutputSpendStatus_pending_first_confirmation(InternalUtils.check_arr_len(first_broadcast_hash, 32), latest_broadcast_height, latest_spending_tx);
		Reference.reachabilityFence(first_broadcast_hash);
		Reference.reachabilityFence(latest_broadcast_height);
		Reference.reachabilityFence(latest_spending_tx);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PendingThresholdConfirmations-variant OutputSpendStatus
	 */
	public static OutputSpendStatus pending_threshold_confirmations(byte[] first_broadcast_hash, int latest_broadcast_height, byte[] latest_spending_tx, int confirmation_height, byte[] confirmation_hash) {
		long ret = bindings.OutputSpendStatus_pending_threshold_confirmations(InternalUtils.check_arr_len(first_broadcast_hash, 32), latest_broadcast_height, latest_spending_tx, confirmation_height, InternalUtils.check_arr_len(confirmation_hash, 32));
		Reference.reachabilityFence(first_broadcast_hash);
		Reference.reachabilityFence(latest_broadcast_height);
		Reference.reachabilityFence(latest_spending_tx);
		Reference.reachabilityFence(confirmation_height);
		Reference.reachabilityFence(confirmation_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two OutputSpendStatuss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.OutputSpendStatus b) {
		boolean ret = bindings.OutputSpendStatus_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof OutputSpendStatus)) return false;
		return this.eq((OutputSpendStatus)o);
	}
	/**
	 * Serialize the OutputSpendStatus object into a byte array which can be read by OutputSpendStatus_read
	 */
	public byte[] write() {
		byte[] ret = bindings.OutputSpendStatus_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a OutputSpendStatus from a byte array, created by OutputSpendStatus_write
	 */
	public static Result_OutputSpendStatusDecodeErrorZ read(byte[] ser) {
		long ret = bindings.OutputSpendStatus_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutputSpendStatusDecodeErrorZ ret_hu_conv = Result_OutputSpendStatusDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
