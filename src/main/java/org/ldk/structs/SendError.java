package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Errors that may occur when [sending an onion message].
 * 
 * [sending an onion message]: OnionMessenger::send_onion_message
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class SendError extends CommonBase {
	private SendError(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.SendError_free(ptr); }
	}
	static SendError constr_from_ptr(long ptr) {
		bindings.LDKSendError raw_val = bindings.LDKSendError_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKSendError.Secp256k1.class) {
			return new Secp256k1(ptr, (bindings.LDKSendError.Secp256k1)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.TooBigPacket.class) {
			return new TooBigPacket(ptr, (bindings.LDKSendError.TooBigPacket)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.TooFewBlindedHops.class) {
			return new TooFewBlindedHops(ptr, (bindings.LDKSendError.TooFewBlindedHops)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.InvalidFirstHop.class) {
			return new InvalidFirstHop(ptr, (bindings.LDKSendError.InvalidFirstHop)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.PathNotFound.class) {
			return new PathNotFound(ptr, (bindings.LDKSendError.PathNotFound)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.InvalidMessage.class) {
			return new InvalidMessage(ptr, (bindings.LDKSendError.InvalidMessage)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.BufferFull.class) {
			return new BufferFull(ptr, (bindings.LDKSendError.BufferFull)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.GetNodeIdFailed.class) {
			return new GetNodeIdFailed(ptr, (bindings.LDKSendError.GetNodeIdFailed)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.UnresolvedIntroductionNode.class) {
			return new UnresolvedIntroductionNode(ptr, (bindings.LDKSendError.UnresolvedIntroductionNode)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSendError.BlindedPathAdvanceFailed.class) {
			return new BlindedPathAdvanceFailed(ptr, (bindings.LDKSendError.BlindedPathAdvanceFailed)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Errored computing onion message packet keys.
	 */
	public final static class Secp256k1 extends SendError {
		public final org.ldk.enums.Secp256k1Error secp256k1;
		private Secp256k1(long ptr, bindings.LDKSendError.Secp256k1 obj) {
			super(null, ptr);
			this.secp256k1 = obj.secp256k1;
		}
	}
	/**
	 * Because implementations such as Eclair will drop onion messages where the message packet
	 * exceeds 32834 bytes, we refuse to send messages where the packet exceeds this size.
	 */
	public final static class TooBigPacket extends SendError {
		private TooBigPacket(long ptr, bindings.LDKSendError.TooBigPacket obj) {
			super(null, ptr);
		}
	}
	/**
	 * The provided [`Destination`] was an invalid [`BlindedMessagePath`] due to not having any
	 * blinded hops.
	 */
	public final static class TooFewBlindedHops extends SendError {
		private TooFewBlindedHops(long ptr, bindings.LDKSendError.TooFewBlindedHops obj) {
			super(null, ptr);
		}
	}
	/**
	 * The first hop is not a peer and doesn't have a known [`SocketAddress`].
	 */
	public final static class InvalidFirstHop extends SendError {
		public final byte[] invalid_first_hop;
		private InvalidFirstHop(long ptr, bindings.LDKSendError.InvalidFirstHop obj) {
			super(null, ptr);
			this.invalid_first_hop = obj.invalid_first_hop;
		}
	}
	/**
	 * Indicates that a path could not be found by the [`MessageRouter`].
	 * 
	 * This occurs when either:
	 * - No path from the sender to the destination was found to send the onion message
	 * - No reply path to the sender could be created when responding to an onion message
	 */
	public final static class PathNotFound extends SendError {
		private PathNotFound(long ptr, bindings.LDKSendError.PathNotFound obj) {
			super(null, ptr);
		}
	}
	/**
	 * Onion message contents must have a TLV type >= 64.
	 */
	public final static class InvalidMessage extends SendError {
		private InvalidMessage(long ptr, bindings.LDKSendError.InvalidMessage obj) {
			super(null, ptr);
		}
	}
	/**
	 * Our next-hop peer's buffer was full or our total outbound buffer was full.
	 */
	public final static class BufferFull extends SendError {
		private BufferFull(long ptr, bindings.LDKSendError.BufferFull obj) {
			super(null, ptr);
		}
	}
	/**
	 * Failed to retrieve our node id from the provided [`NodeSigner`].
	 * 
	 * [`NodeSigner`]: crate::sign::NodeSigner
	 */
	public final static class GetNodeIdFailed extends SendError {
		private GetNodeIdFailed(long ptr, bindings.LDKSendError.GetNodeIdFailed obj) {
			super(null, ptr);
		}
	}
	/**
	 * The provided [`Destination`] has a blinded path with an unresolved introduction node. An
	 * attempt to resolve it in the [`MessageRouter`] when finding an [`OnionMessagePath`] likely
	 * failed.
	 */
	public final static class UnresolvedIntroductionNode extends SendError {
		private UnresolvedIntroductionNode(long ptr, bindings.LDKSendError.UnresolvedIntroductionNode obj) {
			super(null, ptr);
		}
	}
	/**
	 * We attempted to send to a blinded path where we are the introduction node, and failed to
	 * advance the blinded path to make the second hop the new introduction node. Either
	 * [`NodeSigner::ecdh`] failed, we failed to tweak the current blinding point to get the
	 * new blinding point, or we were attempting to send to ourselves.
	 */
	public final static class BlindedPathAdvanceFailed extends SendError {
		private BlindedPathAdvanceFailed(long ptr, bindings.LDKSendError.BlindedPathAdvanceFailed obj) {
			super(null, ptr);
		}
	}
	long clone_ptr() {
		long ret = bindings.SendError_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the SendError
	 */
	public SendError clone() {
		long ret = bindings.SendError_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Secp256k1-variant SendError
	 */
	public static SendError secp256k1(org.ldk.enums.Secp256k1Error a) {
		long ret = bindings.SendError_secp256k1(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new TooBigPacket-variant SendError
	 */
	public static SendError too_big_packet() {
		long ret = bindings.SendError_too_big_packet();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new TooFewBlindedHops-variant SendError
	 */
	public static SendError too_few_blinded_hops() {
		long ret = bindings.SendError_too_few_blinded_hops();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvalidFirstHop-variant SendError
	 */
	public static SendError invalid_first_hop(byte[] a) {
		long ret = bindings.SendError_invalid_first_hop(InternalUtils.check_arr_len(a, 33));
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PathNotFound-variant SendError
	 */
	public static SendError path_not_found() {
		long ret = bindings.SendError_path_not_found();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvalidMessage-variant SendError
	 */
	public static SendError invalid_message() {
		long ret = bindings.SendError_invalid_message();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BufferFull-variant SendError
	 */
	public static SendError buffer_full() {
		long ret = bindings.SendError_buffer_full();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new GetNodeIdFailed-variant SendError
	 */
	public static SendError get_node_id_failed() {
		long ret = bindings.SendError_get_node_id_failed();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new UnresolvedIntroductionNode-variant SendError
	 */
	public static SendError unresolved_introduction_node() {
		long ret = bindings.SendError_unresolved_introduction_node();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BlindedPathAdvanceFailed-variant SendError
	 */
	public static SendError blinded_path_advance_failed() {
		long ret = bindings.SendError_blinded_path_advance_failed();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SendError ret_hu_conv = org.ldk.structs.SendError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the SendError.
	 */
	public long hash() {
		long ret = bindings.SendError_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two SendErrors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.SendError b) {
		boolean ret = bindings.SendError_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof SendError)) return false;
		return this.eq((SendError)o);
	}
}
