using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The destination of an onion message.
 */
public class Destination : CommonBase {
	protected Destination(object _dummy, long ptr) : base(ptr) { }
	~Destination() {
		if (ptr != 0) { bindings.Destination_free(ptr); }
	}

	internal static Destination constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKDestination_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Destination_Node(ptr);
			case 1: return new Destination_BlindedPath(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Destination of type Node */
	public class Destination_Node : Destination {
		public byte[] node;
		internal Destination_Node(long ptr) : base(null, ptr) {
			long node = bindings.LDKDestination_Node_get_node(ptr);
			byte[] node_conv = InternalUtils.decodeUint8Array(node);
			this.node = node_conv;
		}
	}
	/** A Destination of type BlindedPath */
	public class Destination_BlindedPath : Destination {
		public org.ldk.structs.BlindedMessagePath blinded_path;
		internal Destination_BlindedPath(long ptr) : base(null, ptr) {
			long blinded_path = bindings.LDKDestination_BlindedPath_get_blinded_path(ptr);
			org.ldk.structs.BlindedMessagePath blinded_path_hu_conv = null; if (blinded_path < 0 || blinded_path > 4096) { blinded_path_hu_conv = new org.ldk.structs.BlindedMessagePath(null, blinded_path); }
			if (blinded_path_hu_conv != null) { blinded_path_hu_conv.ptrs_to.AddLast(this); };
			this.blinded_path = blinded_path_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.Destination_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Destination
	 */
	public org.ldk.structs.Destination clone() {
		long ret = bindings.Destination_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Node-variant Destination
	 */
	public static org.ldk.structs.Destination node(byte[] a) {
		long ret = bindings.Destination_node(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 33)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BlindedPath-variant Destination
	 */
	public static org.ldk.structs.Destination blinded_path(org.ldk.structs.BlindedMessagePath a) {
		long ret = bindings.Destination_blinded_path(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Destination.
	 */
	public long hash() {
		long ret = bindings.Destination_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Destinations contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.Destination b) {
		bool ret = bindings.Destination_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Destination)) return false;
		return this.eq((Destination)o);
	}
	/**
	 * Attempts to resolve the [`IntroductionNode::DirectedShortChannelId`] of a
	 * [`Destination::BlindedPath`] to a [`IntroductionNode::NodeId`], if applicable, using the
	 * provided [`ReadOnlyNetworkGraph`].
	 */
	public void resolve(org.ldk.structs.ReadOnlyNetworkGraph network_graph) {
		bindings.Destination_resolve(this.ptr, network_graph.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(network_graph);
		if (this != null) { this.ptrs_to.AddLast(network_graph); };
	}

}
} } }
