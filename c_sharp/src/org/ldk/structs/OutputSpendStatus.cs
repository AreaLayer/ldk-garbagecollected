using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The current status of the output spend.
 */
public class OutputSpendStatus : CommonBase {
	protected OutputSpendStatus(object _dummy, long ptr) : base(ptr) { }
	~OutputSpendStatus() {
		if (ptr != 0) { bindings.OutputSpendStatus_free(ptr); }
	}

	internal static OutputSpendStatus constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKOutputSpendStatus_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new OutputSpendStatus_PendingInitialBroadcast(ptr);
			case 1: return new OutputSpendStatus_PendingFirstConfirmation(ptr);
			case 2: return new OutputSpendStatus_PendingThresholdConfirmations(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A OutputSpendStatus of type PendingInitialBroadcast */
	public class OutputSpendStatus_PendingInitialBroadcast : OutputSpendStatus {
		/**
		 * The height at which we will first generate and broadcast a spending transaction.
		 */
		public Option_u32Z delayed_until_height;
		internal OutputSpendStatus_PendingInitialBroadcast(long ptr) : base(null, ptr) {
			long delayed_until_height = bindings.LDKOutputSpendStatus_PendingInitialBroadcast_get_delayed_until_height(ptr);
			org.ldk.structs.Option_u32Z delayed_until_height_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(delayed_until_height);
			if (delayed_until_height_hu_conv != null) { delayed_until_height_hu_conv.ptrs_to.AddLast(this); };
			this.delayed_until_height = delayed_until_height_hu_conv;
		}
	}
	/** A OutputSpendStatus of type PendingFirstConfirmation */
	public class OutputSpendStatus_PendingFirstConfirmation : OutputSpendStatus {
		/**
		 * The hash of the chain tip when we first broadcast a transaction spending this output.
		 */
		public byte[] first_broadcast_hash;
		/**
		 * The best height when we last broadcast a transaction spending this output.
		 */
		public int latest_broadcast_height;
		/**
		 * The transaction spending this output we last broadcasted.
		 */
		public byte[] latest_spending_tx;
		internal OutputSpendStatus_PendingFirstConfirmation(long ptr) : base(null, ptr) {
			long first_broadcast_hash = bindings.LDKOutputSpendStatus_PendingFirstConfirmation_get_first_broadcast_hash(ptr);
			byte[] first_broadcast_hash_conv = InternalUtils.decodeUint8Array(first_broadcast_hash);
			this.first_broadcast_hash = first_broadcast_hash_conv;
			this.latest_broadcast_height = bindings.LDKOutputSpendStatus_PendingFirstConfirmation_get_latest_broadcast_height(ptr);
			long latest_spending_tx = bindings.LDKOutputSpendStatus_PendingFirstConfirmation_get_latest_spending_tx(ptr);
			byte[] latest_spending_tx_conv = InternalUtils.decodeUint8Array(latest_spending_tx);
			this.latest_spending_tx = latest_spending_tx_conv;
		}
	}
	/** A OutputSpendStatus of type PendingThresholdConfirmations */
	public class OutputSpendStatus_PendingThresholdConfirmations : OutputSpendStatus {
		/**
		 * The hash of the chain tip when we first broadcast a transaction spending this output.
		 */
		public byte[] first_broadcast_hash;
		/**
		 * The best height when we last broadcast a transaction spending this output.
		 */
		public int latest_broadcast_height;
		/**
		 * The transaction spending this output we saw confirmed on-chain.
		 */
		public byte[] latest_spending_tx;
		/**
		 * The height at which the spending transaction was confirmed.
		 */
		public int confirmation_height;
		/**
		 * The hash of the block in which the spending transaction was confirmed.
		 */
		public byte[] confirmation_hash;
		internal OutputSpendStatus_PendingThresholdConfirmations(long ptr) : base(null, ptr) {
			long first_broadcast_hash = bindings.LDKOutputSpendStatus_PendingThresholdConfirmations_get_first_broadcast_hash(ptr);
			byte[] first_broadcast_hash_conv = InternalUtils.decodeUint8Array(first_broadcast_hash);
			this.first_broadcast_hash = first_broadcast_hash_conv;
			this.latest_broadcast_height = bindings.LDKOutputSpendStatus_PendingThresholdConfirmations_get_latest_broadcast_height(ptr);
			long latest_spending_tx = bindings.LDKOutputSpendStatus_PendingThresholdConfirmations_get_latest_spending_tx(ptr);
			byte[] latest_spending_tx_conv = InternalUtils.decodeUint8Array(latest_spending_tx);
			this.latest_spending_tx = latest_spending_tx_conv;
			this.confirmation_height = bindings.LDKOutputSpendStatus_PendingThresholdConfirmations_get_confirmation_height(ptr);
			long confirmation_hash = bindings.LDKOutputSpendStatus_PendingThresholdConfirmations_get_confirmation_hash(ptr);
			byte[] confirmation_hash_conv = InternalUtils.decodeUint8Array(confirmation_hash);
			this.confirmation_hash = confirmation_hash_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.OutputSpendStatus_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OutputSpendStatus
	 */
	public OutputSpendStatus clone() {
		long ret = bindings.OutputSpendStatus_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PendingInitialBroadcast-variant OutputSpendStatus
	 */
	public static OutputSpendStatus pending_initial_broadcast(org.ldk.structs.Option_u32Z delayed_until_height) {
		long ret = bindings.OutputSpendStatus_pending_initial_broadcast(delayed_until_height.ptr);
		GC.KeepAlive(delayed_until_height);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(delayed_until_height); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PendingFirstConfirmation-variant OutputSpendStatus
	 */
	public static OutputSpendStatus pending_first_confirmation(byte[] first_broadcast_hash, int latest_broadcast_height, byte[] latest_spending_tx) {
		long ret = bindings.OutputSpendStatus_pending_first_confirmation(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(first_broadcast_hash, 32)), latest_broadcast_height, InternalUtils.encodeUint8Array(latest_spending_tx));
		GC.KeepAlive(first_broadcast_hash);
		GC.KeepAlive(latest_broadcast_height);
		GC.KeepAlive(latest_spending_tx);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PendingThresholdConfirmations-variant OutputSpendStatus
	 */
	public static OutputSpendStatus pending_threshold_confirmations(byte[] first_broadcast_hash, int latest_broadcast_height, byte[] latest_spending_tx, int confirmation_height, byte[] confirmation_hash) {
		long ret = bindings.OutputSpendStatus_pending_threshold_confirmations(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(first_broadcast_hash, 32)), latest_broadcast_height, InternalUtils.encodeUint8Array(latest_spending_tx), confirmation_height, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(confirmation_hash, 32)));
		GC.KeepAlive(first_broadcast_hash);
		GC.KeepAlive(latest_broadcast_height);
		GC.KeepAlive(latest_spending_tx);
		GC.KeepAlive(confirmation_height);
		GC.KeepAlive(confirmation_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSpendStatus ret_hu_conv = org.ldk.structs.OutputSpendStatus.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two OutputSpendStatuss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.OutputSpendStatus b) {
		bool ret = bindings.OutputSpendStatus_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is OutputSpendStatus)) return false;
		return this.eq((OutputSpendStatus)o);
	}
	/**
	 * Serialize the OutputSpendStatus object into a byte array which can be read by OutputSpendStatus_read
	 */
	public byte[] write() {
		long ret = bindings.OutputSpendStatus_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a OutputSpendStatus from a byte array, created by OutputSpendStatus_write
	 */
	public static Result_OutputSpendStatusDecodeErrorZ read(byte[] ser) {
		long ret = bindings.OutputSpendStatus_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutputSpendStatusDecodeErrorZ ret_hu_conv = Result_OutputSpendStatusDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
