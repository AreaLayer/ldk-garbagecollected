package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The unblinded node in a blinded path.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class IntroductionNode extends CommonBase {
	private IntroductionNode(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.IntroductionNode_free(ptr); }
	}
	static IntroductionNode constr_from_ptr(long ptr) {
		bindings.LDKIntroductionNode raw_val = bindings.LDKIntroductionNode_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKIntroductionNode.NodeId.class) {
			return new NodeId(ptr, (bindings.LDKIntroductionNode.NodeId)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKIntroductionNode.DirectedShortChannelId.class) {
			return new DirectedShortChannelId(ptr, (bindings.LDKIntroductionNode.DirectedShortChannelId)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * The node id of the introduction node.
	 */
	public final static class NodeId extends IntroductionNode {
		public final byte[] node_id;
		private NodeId(long ptr, bindings.LDKIntroductionNode.NodeId obj) {
			super(null, ptr);
			this.node_id = obj.node_id;
		}
	}
	/**
	 * The short channel id of the channel leading to the introduction node. The [`Direction`]
	 * identifies which side of the channel is the introduction node.
	 */
	public final static class DirectedShortChannelId extends IntroductionNode {
		public final org.ldk.enums.Direction _0;
		public final long _1;
		private DirectedShortChannelId(long ptr, bindings.LDKIntroductionNode.DirectedShortChannelId obj) {
			super(null, ptr);
			this._0 = obj._0;
			this._1 = obj._1;
		}
	}
	long clone_ptr() {
		long ret = bindings.IntroductionNode_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the IntroductionNode
	 */
	public IntroductionNode clone() {
		long ret = bindings.IntroductionNode_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.IntroductionNode ret_hu_conv = org.ldk.structs.IntroductionNode.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new NodeId-variant IntroductionNode
	 */
	public static IntroductionNode node_id(byte[] a) {
		long ret = bindings.IntroductionNode_node_id(InternalUtils.check_arr_len(a, 33));
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.IntroductionNode ret_hu_conv = org.ldk.structs.IntroductionNode.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DirectedShortChannelId-variant IntroductionNode
	 */
	public static IntroductionNode directed_short_channel_id(org.ldk.enums.Direction a, long b) {
		long ret = bindings.IntroductionNode_directed_short_channel_id(a, b);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.IntroductionNode ret_hu_conv = org.ldk.structs.IntroductionNode.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the IntroductionNode.
	 */
	public long hash() {
		long ret = bindings.IntroductionNode_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two IntroductionNodes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.IntroductionNode b) {
		boolean ret = bindings.IntroductionNode_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof IntroductionNode)) return false;
		return this.eq((IntroductionNode)o);
	}
}
