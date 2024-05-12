package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The destination of an onion message.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Destination extends CommonBase {
	private Destination(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Destination_free(ptr); }
	}
	static Destination constr_from_ptr(long ptr) {
		bindings.LDKDestination raw_val = bindings.LDKDestination_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKDestination.Node.class) {
			return new Node(ptr, (bindings.LDKDestination.Node)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKDestination.BlindedPath.class) {
			return new BlindedPath(ptr, (bindings.LDKDestination.BlindedPath)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * We're sending this onion message to a node.
	 */
	public final static class Node extends Destination {
		public final byte[] node;
		private Node(long ptr, bindings.LDKDestination.Node obj) {
			super(null, ptr);
			this.node = obj.node;
		}
	}
	/**
	 * We're sending this onion message to a blinded path.
	 */
	public final static class BlindedPath extends Destination {
		public final org.ldk.structs.BlindedPath blinded_path;
		private BlindedPath(long ptr, bindings.LDKDestination.BlindedPath obj) {
			super(null, ptr);
			long blinded_path = obj.blinded_path;
			org.ldk.structs.BlindedPath blinded_path_hu_conv = null; if (blinded_path < 0 || blinded_path > 4096) { blinded_path_hu_conv = new org.ldk.structs.BlindedPath(null, blinded_path); }
			if (blinded_path_hu_conv != null) { blinded_path_hu_conv.ptrs_to.add(this); };
			this.blinded_path = blinded_path_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.Destination_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Destination
	 */
	public Destination clone() {
		long ret = bindings.Destination_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Node-variant Destination
	 */
	public static Destination node(byte[] a) {
		long ret = bindings.Destination_node(InternalUtils.check_arr_len(a, 33));
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BlindedPath-variant Destination
	 */
	public static Destination blinded_path(org.ldk.structs.BlindedPath a) {
		long ret = bindings.Destination_blinded_path(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(a); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Destination.
	 */
	public long hash() {
		long ret = bindings.Destination_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Destinations contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.Destination b) {
		boolean ret = bindings.Destination_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof Destination)) return false;
		return this.eq((Destination)o);
	}
	/**
	 * Attempts to resolve the [`IntroductionNode::DirectedShortChannelId`] of a
	 * [`Destination::BlindedPath`] to a [`IntroductionNode::NodeId`], if applicable, using the
	 * provided [`ReadOnlyNetworkGraph`].
	 */
	public void resolve(org.ldk.structs.ReadOnlyNetworkGraph network_graph) {
		bindings.Destination_resolve(this.ptr, network_graph.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(network_graph);
		if (this != null) { this.ptrs_to.add(network_graph); };
	}

}
