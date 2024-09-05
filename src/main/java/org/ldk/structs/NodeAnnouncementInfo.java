package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Information received in the latest node_announcement from this node.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class NodeAnnouncementInfo extends CommonBase {
	private NodeAnnouncementInfo(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.NodeAnnouncementInfo_free(ptr); }
	}
	static NodeAnnouncementInfo constr_from_ptr(long ptr) {
		bindings.LDKNodeAnnouncementInfo raw_val = bindings.LDKNodeAnnouncementInfo_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKNodeAnnouncementInfo.Relayed.class) {
			return new Relayed(ptr, (bindings.LDKNodeAnnouncementInfo.Relayed)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKNodeAnnouncementInfo.Local.class) {
			return new Local(ptr, (bindings.LDKNodeAnnouncementInfo.Local)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * An initial announcement of the node
	 * Everything else is useful only for sending out for initial routing sync.
	 * Not stored if contains excess data to prevent DoS.
	 */
	public final static class Relayed extends NodeAnnouncementInfo {
		public final org.ldk.structs.NodeAnnouncement relayed;
		private Relayed(long ptr, bindings.LDKNodeAnnouncementInfo.Relayed obj) {
			super(null, ptr);
			long relayed = obj.relayed;
			org.ldk.structs.NodeAnnouncement relayed_hu_conv = null; if (relayed < 0 || relayed > 4096) { relayed_hu_conv = new org.ldk.structs.NodeAnnouncement(null, relayed); }
			if (relayed_hu_conv != null) { relayed_hu_conv.ptrs_to.add(this); };
			this.relayed = relayed_hu_conv;
		}
	}
	/**
	 * Non-relayable information received in the latest node_announcement from this node.
	 */
	public final static class Local extends NodeAnnouncementInfo {
		public final org.ldk.structs.NodeAnnouncementDetails local;
		private Local(long ptr, bindings.LDKNodeAnnouncementInfo.Local obj) {
			super(null, ptr);
			long local = obj.local;
			org.ldk.structs.NodeAnnouncementDetails local_hu_conv = null; if (local < 0 || local > 4096) { local_hu_conv = new org.ldk.structs.NodeAnnouncementDetails(null, local); }
			if (local_hu_conv != null) { local_hu_conv.ptrs_to.add(this); };
			this.local = local_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.NodeAnnouncementInfo_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the NodeAnnouncementInfo
	 */
	public NodeAnnouncementInfo clone() {
		long ret = bindings.NodeAnnouncementInfo_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementInfo ret_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Relayed-variant NodeAnnouncementInfo
	 */
	public static NodeAnnouncementInfo relayed(org.ldk.structs.NodeAnnouncement a) {
		long ret = bindings.NodeAnnouncementInfo_relayed(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementInfo ret_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Local-variant NodeAnnouncementInfo
	 */
	public static NodeAnnouncementInfo local(org.ldk.structs.NodeAnnouncementDetails a) {
		long ret = bindings.NodeAnnouncementInfo_local(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementInfo ret_hu_conv = org.ldk.structs.NodeAnnouncementInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two NodeAnnouncementInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.NodeAnnouncementInfo b) {
		boolean ret = bindings.NodeAnnouncementInfo_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof NodeAnnouncementInfo)) return false;
		return this.eq((NodeAnnouncementInfo)o);
	}
	/**
	 * Protocol features the node announced support for
	 */
	public NodeFeatures features() {
		long ret = bindings.NodeAnnouncementInfo_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * When the last known update to the node state was issued.
	 * 
	 * Value may or may not be a timestamp, depending on the policy of the origin node.
	 */
	public int last_update() {
		int ret = bindings.NodeAnnouncementInfo_last_update(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Color assigned to the node
	 */
	public byte[] rgb() {
		byte[] ret = bindings.NodeAnnouncementInfo_rgb(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Moniker assigned to the node.
	 * 
	 * May be invalid or malicious (eg control chars), should not be exposed to the user.
	 */
	public NodeAlias alias() {
		long ret = bindings.NodeAnnouncementInfo_alias(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAlias ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAlias(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Internet-level addresses via which one can connect to the node
	 */
	public SocketAddress[] addresses() {
		long[] ret = bindings.NodeAnnouncementInfo_addresses(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_15_len = ret.length;
		SocketAddress[] ret_conv_15_arr = new SocketAddress[ret_conv_15_len];
		for (int p = 0; p < ret_conv_15_len; p++) {
			long ret_conv_15 = ret[p];
			org.ldk.structs.SocketAddress ret_conv_15_hu_conv = org.ldk.structs.SocketAddress.constr_from_ptr(ret_conv_15);
			if (ret_conv_15_hu_conv != null) { ret_conv_15_hu_conv.ptrs_to.add(this); };
			ret_conv_15_arr[p] = ret_conv_15_hu_conv;
		}
		return ret_conv_15_arr;
	}

	/**
	 * An initial announcement of the node
	 * 
	 * Not stored if contains excess data to prevent DoS.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public NodeAnnouncement announcement_message() {
		long ret = bindings.NodeAnnouncementInfo_announcement_message(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the NodeAnnouncementInfo object into a byte array which can be read by NodeAnnouncementInfo_read
	 */
	public byte[] write() {
		byte[] ret = bindings.NodeAnnouncementInfo_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a NodeAnnouncementInfo from a byte array, created by NodeAnnouncementInfo_write
	 */
	public static Result_NodeAnnouncementInfoDecodeErrorZ read(byte[] ser) {
		long ret = bindings.NodeAnnouncementInfo_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeAnnouncementInfoDecodeErrorZ ret_hu_conv = Result_NodeAnnouncementInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
