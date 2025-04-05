using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Information received in the latest node_announcement from this node.
 */
public class NodeAnnouncementInfo : CommonBase {
	protected NodeAnnouncementInfo(object _dummy, long ptr) : base(ptr) { }
	~NodeAnnouncementInfo() {
		if (ptr != 0) { bindings.NodeAnnouncementInfo_free(ptr); }
	}

	internal static NodeAnnouncementInfo constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKNodeAnnouncementInfo_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new NodeAnnouncementInfo_Relayed(ptr);
			case 1: return new NodeAnnouncementInfo_Local(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A NodeAnnouncementInfo of type Relayed */
	public class NodeAnnouncementInfo_Relayed : NodeAnnouncementInfo {
		public org.ldk.structs.NodeAnnouncement relayed;
		internal NodeAnnouncementInfo_Relayed(long ptr) : base(null, ptr) {
			long relayed = bindings.LDKNodeAnnouncementInfo_Relayed_get_relayed(ptr);
			org.ldk.structs.NodeAnnouncement relayed_hu_conv = null; if (relayed < 0 || relayed > 4096) { relayed_hu_conv = new org.ldk.structs.NodeAnnouncement(null, relayed); }
			if (relayed_hu_conv != null) { relayed_hu_conv.ptrs_to.AddLast(this); };
			this.relayed = relayed_hu_conv;
		}
	}
	/** A NodeAnnouncementInfo of type Local */
	public class NodeAnnouncementInfo_Local : NodeAnnouncementInfo {
		public org.ldk.structs.NodeAnnouncementDetails local;
		internal NodeAnnouncementInfo_Local(long ptr) : base(null, ptr) {
			long local = bindings.LDKNodeAnnouncementInfo_Local_get_local(ptr);
			org.ldk.structs.NodeAnnouncementDetails local_hu_conv = null; if (local < 0 || local > 4096) { local_hu_conv = new org.ldk.structs.NodeAnnouncementDetails(null, local); }
			if (local_hu_conv != null) { local_hu_conv.ptrs_to.AddLast(this); };
			this.local = local_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.NodeAnnouncementInfo_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the NodeAnnouncementInfo
	 */
	public org.ldk.structs.NodeAnnouncementInfo clone() {
		long ret = bindings.NodeAnnouncementInfo_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementInfo ret_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Relayed-variant NodeAnnouncementInfo
	 */
	public static org.ldk.structs.NodeAnnouncementInfo relayed(org.ldk.structs.NodeAnnouncement a) {
		long ret = bindings.NodeAnnouncementInfo_relayed(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementInfo ret_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Local-variant NodeAnnouncementInfo
	 */
	public static org.ldk.structs.NodeAnnouncementInfo local(org.ldk.structs.NodeAnnouncementDetails a) {
		long ret = bindings.NodeAnnouncementInfo_local(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementInfo ret_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two NodeAnnouncementInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.NodeAnnouncementInfo b) {
		bool ret = bindings.NodeAnnouncementInfo_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is NodeAnnouncementInfo)) return false;
		return this.eq((NodeAnnouncementInfo)o);
	}
	/**
	 * Protocol features the node announced support for
	 */
	public org.ldk.structs.NodeFeatures features() {
		long ret = bindings.NodeAnnouncementInfo_features(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * When the last known update to the node state was issued.
	 * 
	 * Value may or may not be a timestamp, depending on the policy of the origin node.
	 */
	public int last_update() {
		int ret = bindings.NodeAnnouncementInfo_last_update(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Color assigned to the node
	 */
	public byte[] rgb() {
		long ret = bindings.NodeAnnouncementInfo_rgb(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Moniker assigned to the node.
	 * 
	 * May be invalid or malicious (eg control chars), should not be exposed to the user.
	 */
	public org.ldk.structs.NodeAlias alias() {
		long ret = bindings.NodeAnnouncementInfo_alias(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAlias ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAlias(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Internet-level addresses via which one can connect to the node
	 */
	public SocketAddress[] addresses() {
		long ret = bindings.NodeAnnouncementInfo_addresses(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_15_len = InternalUtils.getArrayLength(ret);
		SocketAddress[] ret_conv_15_arr = new SocketAddress[ret_conv_15_len];
		for (int p = 0; p < ret_conv_15_len; p++) {
			long ret_conv_15 = InternalUtils.getU64ArrayElem(ret, p);
			org.ldk.structs.SocketAddress ret_conv_15_hu_conv = org.ldk.structs.SocketAddress.constr_from_ptr(ret_conv_15);
			if (ret_conv_15_hu_conv != null) { ret_conv_15_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_15_arr[p] = ret_conv_15_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_15_arr;
	}

	/**
	 * An initial announcement of the node
	 * 
	 * Not stored if contains excess data to prevent DoS.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.NodeAnnouncement announcement_message() {
		long ret = bindings.NodeAnnouncementInfo_announcement_message(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the NodeAnnouncementInfo object into a byte array which can be read by NodeAnnouncementInfo_read
	 */
	public byte[] write() {
		long ret = bindings.NodeAnnouncementInfo_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a NodeAnnouncementInfo from a byte array, created by NodeAnnouncementInfo_write
	 */
	public static org.ldk.structs.Result_NodeAnnouncementInfoDecodeErrorZ read(byte[] ser) {
		long ret = bindings.NodeAnnouncementInfo_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeAnnouncementInfoDecodeErrorZ ret_hu_conv = Result_NodeAnnouncementInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
