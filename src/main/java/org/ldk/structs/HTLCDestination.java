package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Intended destination of a failed HTLC as indicated in [`Event::HTLCHandlingFailed`].
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class HTLCDestination extends CommonBase {
	private HTLCDestination(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.HTLCDestination_free(ptr); }
	}
	static HTLCDestination constr_from_ptr(long ptr) {
		bindings.LDKHTLCDestination raw_val = bindings.LDKHTLCDestination_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKHTLCDestination.NextHopChannel.class) {
			return new NextHopChannel(ptr, (bindings.LDKHTLCDestination.NextHopChannel)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKHTLCDestination.UnknownNextHop.class) {
			return new UnknownNextHop(ptr, (bindings.LDKHTLCDestination.UnknownNextHop)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKHTLCDestination.InvalidForward.class) {
			return new InvalidForward(ptr, (bindings.LDKHTLCDestination.InvalidForward)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKHTLCDestination.InvalidOnion.class) {
			return new InvalidOnion(ptr, (bindings.LDKHTLCDestination.InvalidOnion)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKHTLCDestination.FailedPayment.class) {
			return new FailedPayment(ptr, (bindings.LDKHTLCDestination.FailedPayment)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * We tried forwarding to a channel but failed to do so. An example of such an instance is when
	 * there is insufficient capacity in our outbound channel.
	 */
	public final static class NextHopChannel extends HTLCDestination {
		/**
		 * The `node_id` of the next node. For backwards compatibility, this field is
		 * marked as optional, versions prior to 0.0.110 may not always be able to provide
		 * counterparty node information.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		*/
		@Nullable public final byte[] node_id;
		/**
		 * The outgoing `channel_id` between us and the next node.
		*/
		public final org.ldk.structs.ChannelId channel_id;
		private NextHopChannel(long ptr, bindings.LDKHTLCDestination.NextHopChannel obj) {
			super(null, ptr);
			this.node_id = obj.node_id;
			long channel_id = obj.channel_id;
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.add(this); };
			this.channel_id = channel_id_hu_conv;
		}
	}
	/**
	 * Scenario where we are unsure of the next node to forward the HTLC to.
	 */
	public final static class UnknownNextHop extends HTLCDestination {
		/**
		 * Short channel id we are requesting to forward an HTLC to.
		*/
		public final long requested_forward_scid;
		private UnknownNextHop(long ptr, bindings.LDKHTLCDestination.UnknownNextHop obj) {
			super(null, ptr);
			this.requested_forward_scid = obj.requested_forward_scid;
		}
	}
	/**
	 * We couldn't forward to the outgoing scid. An example would be attempting to send a duplicate
	 * intercept HTLC.
	 */
	public final static class InvalidForward extends HTLCDestination {
		/**
		 * Short channel id we are requesting to forward an HTLC to.
		*/
		public final long requested_forward_scid;
		private InvalidForward(long ptr, bindings.LDKHTLCDestination.InvalidForward obj) {
			super(null, ptr);
			this.requested_forward_scid = obj.requested_forward_scid;
		}
	}
	/**
	 * We couldn't decode the incoming onion to obtain the forwarding details.
	 */
	public final static class InvalidOnion extends HTLCDestination {
		private InvalidOnion(long ptr, bindings.LDKHTLCDestination.InvalidOnion obj) {
			super(null, ptr);
		}
	}
	/**
	 * Failure scenario where an HTLC may have been forwarded to be intended for us,
	 * but is invalid for some reason, so we reject it.
	 * 
	 * Some of the reasons may include:
	 * HTLC Timeouts
	 * Excess HTLCs for a payment that we have already fully received, over-paying for the
	 * payment,
	 * The counterparty node modified the HTLC in transit,
	 * A probing attack where an intermediary node is trying to detect if we are the ultimate
	 * recipient for a payment.
	 */
	public final static class FailedPayment extends HTLCDestination {
		/**
		 * The payment hash of the payment we attempted to process.
		*/
		public final byte[] payment_hash;
		private FailedPayment(long ptr, bindings.LDKHTLCDestination.FailedPayment obj) {
			super(null, ptr);
			this.payment_hash = obj.payment_hash;
		}
	}
	long clone_ptr() {
		long ret = bindings.HTLCDestination_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the HTLCDestination
	 */
	public HTLCDestination clone() {
		long ret = bindings.HTLCDestination_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new NextHopChannel-variant HTLCDestination
	 */
	public static HTLCDestination next_hop_channel(byte[] node_id, org.ldk.structs.ChannelId channel_id) {
		long ret = bindings.HTLCDestination_next_hop_channel(InternalUtils.check_arr_len(node_id, 33), channel_id.ptr);
		Reference.reachabilityFence(node_id);
		Reference.reachabilityFence(channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new UnknownNextHop-variant HTLCDestination
	 */
	public static HTLCDestination unknown_next_hop(long requested_forward_scid) {
		long ret = bindings.HTLCDestination_unknown_next_hop(requested_forward_scid);
		Reference.reachabilityFence(requested_forward_scid);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvalidForward-variant HTLCDestination
	 */
	public static HTLCDestination invalid_forward(long requested_forward_scid) {
		long ret = bindings.HTLCDestination_invalid_forward(requested_forward_scid);
		Reference.reachabilityFence(requested_forward_scid);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvalidOnion-variant HTLCDestination
	 */
	public static HTLCDestination invalid_onion() {
		long ret = bindings.HTLCDestination_invalid_onion();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new FailedPayment-variant HTLCDestination
	 */
	public static HTLCDestination failed_payment(byte[] payment_hash) {
		long ret = bindings.HTLCDestination_failed_payment(InternalUtils.check_arr_len(payment_hash, 32));
		Reference.reachabilityFence(payment_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two HTLCDestinations contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.HTLCDestination b) {
		boolean ret = bindings.HTLCDestination_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof HTLCDestination)) return false;
		return this.eq((HTLCDestination)o);
	}
	/**
	 * Serialize the HTLCDestination object into a byte array which can be read by HTLCDestination_read
	 */
	public byte[] write() {
		byte[] ret = bindings.HTLCDestination_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
