using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Non-relayable information received in the latest node_announcement from this node.
 */
public class NodeAnnouncementDetails : CommonBase {
	internal NodeAnnouncementDetails(object _dummy, long ptr) : base(ptr) { }
	~NodeAnnouncementDetails() {
		if (ptr != 0) { bindings.NodeAnnouncementDetails_free(ptr); }
	}

	/**
	 * Protocol features the node announced support for
	 */
	public NodeFeatures get_features() {
		long ret = bindings.NodeAnnouncementDetails_get_features(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Protocol features the node announced support for
	 */
	public void set_features(org.ldk.structs.NodeFeatures val) {
		bindings.NodeAnnouncementDetails_set_features(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * When the last known update to the node state was issued.
	 * Value is opaque, as set in the announcement.
	 */
	public int get_last_update() {
		int ret = bindings.NodeAnnouncementDetails_get_last_update(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * When the last known update to the node state was issued.
	 * Value is opaque, as set in the announcement.
	 */
	public void set_last_update(int val) {
		bindings.NodeAnnouncementDetails_set_last_update(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Color assigned to the node
	 */
	public byte[] get_rgb() {
		long ret = bindings.NodeAnnouncementDetails_get_rgb(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Color assigned to the node
	 */
	public void set_rgb(byte[] val) {
		bindings.NodeAnnouncementDetails_set_rgb(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 3)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Moniker assigned to the node.
	 * May be invalid or malicious (eg control chars),
	 * should not be exposed to the user.
	 */
	public NodeAlias get_alias() {
		long ret = bindings.NodeAnnouncementDetails_get_alias(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAlias ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAlias(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Moniker assigned to the node.
	 * May be invalid or malicious (eg control chars),
	 * should not be exposed to the user.
	 */
	public void set_alias(org.ldk.structs.NodeAlias val) {
		bindings.NodeAnnouncementDetails_set_alias(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Internet-level addresses via which one can connect to the node
	 * 
	 * Returns a copy of the field.
	 */
	public SocketAddress[] get_addresses() {
		long ret = bindings.NodeAnnouncementDetails_get_addresses(this.ptr);
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
	 * Internet-level addresses via which one can connect to the node
	 */
	public void set_addresses(SocketAddress[] val) {
		bindings.NodeAnnouncementDetails_set_addresses(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_15 => val_conv_15.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new NodeAnnouncementDetails given each field
	 */
	public static NodeAnnouncementDetails of(org.ldk.structs.NodeFeatures features_arg, int last_update_arg, byte[] rgb_arg, org.ldk.structs.NodeAlias alias_arg, SocketAddress[] addresses_arg) {
		long ret = bindings.NodeAnnouncementDetails_new(features_arg.ptr, last_update_arg, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(rgb_arg, 3)), alias_arg.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(addresses_arg, addresses_arg_conv_15 => addresses_arg_conv_15.ptr)));
		GC.KeepAlive(features_arg);
		GC.KeepAlive(last_update_arg);
		GC.KeepAlive(rgb_arg);
		GC.KeepAlive(alias_arg);
		GC.KeepAlive(addresses_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncementDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.NodeAnnouncementDetails_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the NodeAnnouncementDetails
	 */
	public NodeAnnouncementDetails clone() {
		long ret = bindings.NodeAnnouncementDetails_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncementDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two NodeAnnouncementDetailss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.NodeAnnouncementDetails b) {
		bool ret = bindings.NodeAnnouncementDetails_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is NodeAnnouncementDetails)) return false;
		return this.eq((NodeAnnouncementDetails)o);
	}
}
} } }
