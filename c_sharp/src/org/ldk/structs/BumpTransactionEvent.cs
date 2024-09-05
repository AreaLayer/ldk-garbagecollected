using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Represents the different types of transactions, originating from LDK, to be bumped.
 */
public class BumpTransactionEvent : CommonBase {
	protected BumpTransactionEvent(object _dummy, long ptr) : base(ptr) { }
	~BumpTransactionEvent() {
		if (ptr != 0) { bindings.BumpTransactionEvent_free(ptr); }
	}

	internal static BumpTransactionEvent constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKBumpTransactionEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new BumpTransactionEvent_ChannelClose(ptr);
			case 1: return new BumpTransactionEvent_HTLCResolution(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A BumpTransactionEvent of type ChannelClose */
	public class BumpTransactionEvent_ChannelClose : BumpTransactionEvent {
		/**
		 * The `channel_id` of the channel which has been closed.
		 */
		public ChannelId channel_id;
		/**
		 * Counterparty in the closed channel.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The unique identifier for the claim of the anchor output in the commitment transaction.
		 * 
		 * The identifier must map to the set of external UTXOs assigned to the claim, such that
		 * they can be reused when a new claim with the same identifier needs to be made, resulting
		 * in a fee-bumping attempt.
		 */
		public byte[] claim_id;
		/**
		 * The target feerate that the transaction package, which consists of the commitment
		 * transaction and the to-be-crafted child anchor transaction, must meet.
		 */
		public int package_target_feerate_sat_per_1000_weight;
		/**
		 * The channel's commitment transaction to bump the fee of. This transaction should be
		 * broadcast along with the anchor transaction constructed as a result of consuming this
		 * event.
		 */
		public byte[] commitment_tx;
		/**
		 * The absolute fee in satoshis of the commitment transaction. This can be used along the
		 * with weight of the commitment transaction to determine its feerate.
		 */
		public long commitment_tx_fee_satoshis;
		/**
		 * The descriptor to sign the anchor input of the anchor transaction constructed as a
		 * result of consuming this event.
		 */
		public AnchorDescriptor anchor_descriptor;
		/**
		 * The set of pending HTLCs on the commitment transaction that need to be resolved once the
		 * commitment transaction confirms.
		 */
		public HTLCOutputInCommitment[] pending_htlcs;
		internal BumpTransactionEvent_ChannelClose(long ptr) : base(null, ptr) {
			long channel_id = bindings.LDKBumpTransactionEvent_ChannelClose_get_channel_id(ptr);
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.channel_id = channel_id_hu_conv;
			long counterparty_node_id = bindings.LDKBumpTransactionEvent_ChannelClose_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long claim_id = bindings.LDKBumpTransactionEvent_ChannelClose_get_claim_id(ptr);
			byte[] claim_id_conv = InternalUtils.decodeUint8Array(claim_id);
			this.claim_id = claim_id_conv;
			this.package_target_feerate_sat_per_1000_weight = bindings.LDKBumpTransactionEvent_ChannelClose_get_package_target_feerate_sat_per_1000_weight(ptr);
			long commitment_tx = bindings.LDKBumpTransactionEvent_ChannelClose_get_commitment_tx(ptr);
			byte[] commitment_tx_conv = InternalUtils.decodeUint8Array(commitment_tx);
			this.commitment_tx = commitment_tx_conv;
			this.commitment_tx_fee_satoshis = bindings.LDKBumpTransactionEvent_ChannelClose_get_commitment_tx_fee_satoshis(ptr);
			long anchor_descriptor = bindings.LDKBumpTransactionEvent_ChannelClose_get_anchor_descriptor(ptr);
			org.ldk.structs.AnchorDescriptor anchor_descriptor_hu_conv = null; if (anchor_descriptor < 0 || anchor_descriptor > 4096) { anchor_descriptor_hu_conv = new org.ldk.structs.AnchorDescriptor(null, anchor_descriptor); }
			if (anchor_descriptor_hu_conv != null) { anchor_descriptor_hu_conv.ptrs_to.AddLast(this); };
			this.anchor_descriptor = anchor_descriptor_hu_conv;
			long pending_htlcs = bindings.LDKBumpTransactionEvent_ChannelClose_get_pending_htlcs(ptr);
			int pending_htlcs_conv_24_len = InternalUtils.getArrayLength(pending_htlcs);
			HTLCOutputInCommitment[] pending_htlcs_conv_24_arr = new HTLCOutputInCommitment[pending_htlcs_conv_24_len];
			for (int y = 0; y < pending_htlcs_conv_24_len; y++) {
				long pending_htlcs_conv_24 = InternalUtils.getU64ArrayElem(pending_htlcs, y);
				org.ldk.structs.HTLCOutputInCommitment pending_htlcs_conv_24_hu_conv = null; if (pending_htlcs_conv_24 < 0 || pending_htlcs_conv_24 > 4096) { pending_htlcs_conv_24_hu_conv = new org.ldk.structs.HTLCOutputInCommitment(null, pending_htlcs_conv_24); }
				if (pending_htlcs_conv_24_hu_conv != null) { pending_htlcs_conv_24_hu_conv.ptrs_to.AddLast(this); };
				pending_htlcs_conv_24_arr[y] = pending_htlcs_conv_24_hu_conv;
			}
			bindings.free_buffer(pending_htlcs);
			this.pending_htlcs = pending_htlcs_conv_24_arr;
		}
	}
	/** A BumpTransactionEvent of type HTLCResolution */
	public class BumpTransactionEvent_HTLCResolution : BumpTransactionEvent {
		/**
		 * The `channel_id` of the channel which has been closed.
		 */
		public ChannelId channel_id;
		/**
		 * Counterparty in the closed channel.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The unique identifier for the claim of the HTLCs in the confirmed commitment
		 * transaction.
		 * 
		 * The identifier must map to the set of external UTXOs assigned to the claim, such that
		 * they can be reused when a new claim with the same identifier needs to be made, resulting
		 * in a fee-bumping attempt.
		 */
		public byte[] claim_id;
		/**
		 * The target feerate that the resulting HTLC transaction must meet.
		 */
		public int target_feerate_sat_per_1000_weight;
		/**
		 * The set of pending HTLCs on the confirmed commitment that need to be claimed, preferably
		 * by the same transaction.
		 */
		public HTLCDescriptor[] htlc_descriptors;
		/**
		 * The locktime required for the resulting HTLC transaction.
		 */
		public int tx_lock_time;
		internal BumpTransactionEvent_HTLCResolution(long ptr) : base(null, ptr) {
			long channel_id = bindings.LDKBumpTransactionEvent_HTLCResolution_get_channel_id(ptr);
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.channel_id = channel_id_hu_conv;
			long counterparty_node_id = bindings.LDKBumpTransactionEvent_HTLCResolution_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long claim_id = bindings.LDKBumpTransactionEvent_HTLCResolution_get_claim_id(ptr);
			byte[] claim_id_conv = InternalUtils.decodeUint8Array(claim_id);
			this.claim_id = claim_id_conv;
			this.target_feerate_sat_per_1000_weight = bindings.LDKBumpTransactionEvent_HTLCResolution_get_target_feerate_sat_per_1000_weight(ptr);
			long htlc_descriptors = bindings.LDKBumpTransactionEvent_HTLCResolution_get_htlc_descriptors(ptr);
			int htlc_descriptors_conv_16_len = InternalUtils.getArrayLength(htlc_descriptors);
			HTLCDescriptor[] htlc_descriptors_conv_16_arr = new HTLCDescriptor[htlc_descriptors_conv_16_len];
			for (int q = 0; q < htlc_descriptors_conv_16_len; q++) {
				long htlc_descriptors_conv_16 = InternalUtils.getU64ArrayElem(htlc_descriptors, q);
				org.ldk.structs.HTLCDescriptor htlc_descriptors_conv_16_hu_conv = null; if (htlc_descriptors_conv_16 < 0 || htlc_descriptors_conv_16 > 4096) { htlc_descriptors_conv_16_hu_conv = new org.ldk.structs.HTLCDescriptor(null, htlc_descriptors_conv_16); }
				if (htlc_descriptors_conv_16_hu_conv != null) { htlc_descriptors_conv_16_hu_conv.ptrs_to.AddLast(this); };
				htlc_descriptors_conv_16_arr[q] = htlc_descriptors_conv_16_hu_conv;
			}
			bindings.free_buffer(htlc_descriptors);
			this.htlc_descriptors = htlc_descriptors_conv_16_arr;
			this.tx_lock_time = bindings.LDKBumpTransactionEvent_HTLCResolution_get_tx_lock_time(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = bindings.BumpTransactionEvent_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BumpTransactionEvent
	 */
	public BumpTransactionEvent clone() {
		long ret = bindings.BumpTransactionEvent_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BumpTransactionEvent ret_hu_conv = org.ldk.structs.BumpTransactionEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ChannelClose-variant BumpTransactionEvent
	 */
	public static BumpTransactionEvent channel_close(org.ldk.structs.ChannelId channel_id, byte[] counterparty_node_id, byte[] claim_id, int package_target_feerate_sat_per_1000_weight, byte[] commitment_tx, long commitment_tx_fee_satoshis, org.ldk.structs.AnchorDescriptor anchor_descriptor, HTLCOutputInCommitment[] pending_htlcs) {
		long ret = bindings.BumpTransactionEvent_channel_close(channel_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(claim_id, 32)), package_target_feerate_sat_per_1000_weight, InternalUtils.encodeUint8Array(commitment_tx), commitment_tx_fee_satoshis, anchor_descriptor.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(pending_htlcs, pending_htlcs_conv_24 => pending_htlcs_conv_24.ptr)));
		GC.KeepAlive(channel_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(claim_id);
		GC.KeepAlive(package_target_feerate_sat_per_1000_weight);
		GC.KeepAlive(commitment_tx);
		GC.KeepAlive(commitment_tx_fee_satoshis);
		GC.KeepAlive(anchor_descriptor);
		GC.KeepAlive(pending_htlcs);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BumpTransactionEvent ret_hu_conv = org.ldk.structs.BumpTransactionEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new HTLCResolution-variant BumpTransactionEvent
	 */
	public static BumpTransactionEvent htlcresolution(org.ldk.structs.ChannelId channel_id, byte[] counterparty_node_id, byte[] claim_id, int target_feerate_sat_per_1000_weight, HTLCDescriptor[] htlc_descriptors, int tx_lock_time) {
		long ret = bindings.BumpTransactionEvent_htlcresolution(channel_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(claim_id, 32)), target_feerate_sat_per_1000_weight, InternalUtils.encodeUint64Array(InternalUtils.mapArray(htlc_descriptors, htlc_descriptors_conv_16 => htlc_descriptors_conv_16.ptr)), tx_lock_time);
		GC.KeepAlive(channel_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(claim_id);
		GC.KeepAlive(target_feerate_sat_per_1000_weight);
		GC.KeepAlive(htlc_descriptors);
		GC.KeepAlive(tx_lock_time);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BumpTransactionEvent ret_hu_conv = org.ldk.structs.BumpTransactionEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two BumpTransactionEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.BumpTransactionEvent b) {
		bool ret = bindings.BumpTransactionEvent_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is BumpTransactionEvent)) return false;
		return this.eq((BumpTransactionEvent)o);
	}
}
} } }
