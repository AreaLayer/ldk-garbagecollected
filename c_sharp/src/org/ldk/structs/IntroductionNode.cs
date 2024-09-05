using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The unblinded node in a blinded path.
 */
public class IntroductionNode : CommonBase {
	protected IntroductionNode(object _dummy, long ptr) : base(ptr) { }
	~IntroductionNode() {
		if (ptr != 0) { bindings.IntroductionNode_free(ptr); }
	}

	internal static IntroductionNode constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKIntroductionNode_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new IntroductionNode_NodeId(ptr);
			case 1: return new IntroductionNode_DirectedShortChannelId(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A IntroductionNode of type NodeId */
	public class IntroductionNode_NodeId : IntroductionNode {
		public byte[] node_id;
		internal IntroductionNode_NodeId(long ptr) : base(null, ptr) {
			long node_id = bindings.LDKIntroductionNode_NodeId_get_node_id(ptr);
			byte[] node_id_conv = InternalUtils.decodeUint8Array(node_id);
			this.node_id = node_id_conv;
		}
	}
	/** A IntroductionNode of type DirectedShortChannelId */
	public class IntroductionNode_DirectedShortChannelId : IntroductionNode {
		public Direction _0;
		public long _1;
		internal IntroductionNode_DirectedShortChannelId(long ptr) : base(null, ptr) {
			this._0 = bindings.LDKIntroductionNode_DirectedShortChannelId_get__0(ptr);
			this._1 = bindings.LDKIntroductionNode_DirectedShortChannelId_get__1(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = bindings.IntroductionNode_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the IntroductionNode
	 */
	public IntroductionNode clone() {
		long ret = bindings.IntroductionNode_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.IntroductionNode ret_hu_conv = org.ldk.structs.IntroductionNode.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new NodeId-variant IntroductionNode
	 */
	public static IntroductionNode node_id(byte[] a) {
		long ret = bindings.IntroductionNode_node_id(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 33)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.IntroductionNode ret_hu_conv = org.ldk.structs.IntroductionNode.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DirectedShortChannelId-variant IntroductionNode
	 */
	public static IntroductionNode directed_short_channel_id(Direction a, long b) {
		long ret = bindings.IntroductionNode_directed_short_channel_id(a, b);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.IntroductionNode ret_hu_conv = org.ldk.structs.IntroductionNode.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the IntroductionNode.
	 */
	public long hash() {
		long ret = bindings.IntroductionNode_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two IntroductionNodes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.IntroductionNode b) {
		bool ret = bindings.IntroductionNode_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is IntroductionNode)) return false;
		return this.eq((IntroductionNode)o);
	}
}
} } }
