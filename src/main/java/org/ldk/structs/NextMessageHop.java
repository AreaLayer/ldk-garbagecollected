package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The next hop to forward an onion message along its path.
 * 
 * Note that payment blinded paths always specify their next hop using an explicit node id.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class NextMessageHop extends CommonBase {
	private NextMessageHop(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.NextMessageHop_free(ptr); }
	}
	static NextMessageHop constr_from_ptr(long ptr) {
		bindings.LDKNextMessageHop raw_val = bindings.LDKNextMessageHop_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKNextMessageHop.NodeId.class) {
			return new NodeId(ptr, (bindings.LDKNextMessageHop.NodeId)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKNextMessageHop.ShortChannelId.class) {
			return new ShortChannelId(ptr, (bindings.LDKNextMessageHop.ShortChannelId)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * The node id of the next hop.
	 */
	public final static class NodeId extends NextMessageHop {
		public final byte[] node_id;
		private NodeId(long ptr, bindings.LDKNextMessageHop.NodeId obj) {
			super(null, ptr);
			this.node_id = obj.node_id;
		}
	}
	/**
	 * The short channel id leading to the next hop.
	 */
	public final static class ShortChannelId extends NextMessageHop {
		public final long short_channel_id;
		private ShortChannelId(long ptr, bindings.LDKNextMessageHop.ShortChannelId obj) {
			super(null, ptr);
			this.short_channel_id = obj.short_channel_id;
		}
	}
	long clone_ptr() {
		long ret = bindings.NextMessageHop_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the NextMessageHop
	 */
	public NextMessageHop clone() {
		long ret = bindings.NextMessageHop_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NextMessageHop ret_hu_conv = org.ldk.structs.NextMessageHop.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new NodeId-variant NextMessageHop
	 */
	public static NextMessageHop node_id(byte[] a) {
		long ret = bindings.NextMessageHop_node_id(InternalUtils.check_arr_len(a, 33));
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NextMessageHop ret_hu_conv = org.ldk.structs.NextMessageHop.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ShortChannelId-variant NextMessageHop
	 */
	public static NextMessageHop short_channel_id(long a) {
		long ret = bindings.NextMessageHop_short_channel_id(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NextMessageHop ret_hu_conv = org.ldk.structs.NextMessageHop.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the NextMessageHop.
	 */
	public long hash() {
		long ret = bindings.NextMessageHop_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two NextMessageHops contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.NextMessageHop b) {
		boolean ret = bindings.NextMessageHop_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof NextMessageHop)) return false;
		return this.eq((NextMessageHop)o);
	}
}
