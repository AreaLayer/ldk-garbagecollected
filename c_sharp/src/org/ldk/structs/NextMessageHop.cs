using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The next hop to forward an onion message along its path.
 * 
 * Note that payment blinded paths always specify their next hop using an explicit node id.
 */
public class NextMessageHop : CommonBase {
	protected NextMessageHop(object _dummy, long ptr) : base(ptr) { }
	~NextMessageHop() {
		if (ptr != 0) { bindings.NextMessageHop_free(ptr); }
	}

	internal static NextMessageHop constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKNextMessageHop_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new NextMessageHop_NodeId(ptr);
			case 1: return new NextMessageHop_ShortChannelId(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A NextMessageHop of type NodeId */
	public class NextMessageHop_NodeId : NextMessageHop {
		public byte[] node_id;
		internal NextMessageHop_NodeId(long ptr) : base(null, ptr) {
			long node_id = bindings.LDKNextMessageHop_NodeId_get_node_id(ptr);
			byte[] node_id_conv = InternalUtils.decodeUint8Array(node_id);
			this.node_id = node_id_conv;
		}
	}
	/** A NextMessageHop of type ShortChannelId */
	public class NextMessageHop_ShortChannelId : NextMessageHop {
		public long short_channel_id;
		internal NextMessageHop_ShortChannelId(long ptr) : base(null, ptr) {
			this.short_channel_id = bindings.LDKNextMessageHop_ShortChannelId_get_short_channel_id(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = bindings.NextMessageHop_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the NextMessageHop
	 */
	public NextMessageHop clone() {
		long ret = bindings.NextMessageHop_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NextMessageHop ret_hu_conv = org.ldk.structs.NextMessageHop.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new NodeId-variant NextMessageHop
	 */
	public static NextMessageHop node_id(byte[] a) {
		long ret = bindings.NextMessageHop_node_id(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 33)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NextMessageHop ret_hu_conv = org.ldk.structs.NextMessageHop.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ShortChannelId-variant NextMessageHop
	 */
	public static NextMessageHop short_channel_id(long a) {
		long ret = bindings.NextMessageHop_short_channel_id(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NextMessageHop ret_hu_conv = org.ldk.structs.NextMessageHop.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the NextMessageHop.
	 */
	public long hash() {
		long ret = bindings.NextMessageHop_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two NextMessageHops contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.NextMessageHop b) {
		bool ret = bindings.NextMessageHop_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is NextMessageHop)) return false;
		return this.eq((NextMessageHop)o);
	}
}
} } }
