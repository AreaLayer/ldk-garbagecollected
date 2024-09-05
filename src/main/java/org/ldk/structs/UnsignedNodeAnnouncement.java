package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The unsigned part of a [`node_announcement`] message.
 * 
 * [`node_announcement`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-node_announcement-message
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class UnsignedNodeAnnouncement extends CommonBase {
	UnsignedNodeAnnouncement(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.UnsignedNodeAnnouncement_free(ptr); }
	}

	/**
	 * The advertised features
	 */
	public NodeFeatures get_features() {
		long ret = bindings.UnsignedNodeAnnouncement_get_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The advertised features
	 */
	public void set_features(org.ldk.structs.NodeFeatures val) {
		bindings.UnsignedNodeAnnouncement_set_features(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * A strictly monotonic announcement counter, with gaps allowed
	 */
	public int get_timestamp() {
		int ret = bindings.UnsignedNodeAnnouncement_get_timestamp(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A strictly monotonic announcement counter, with gaps allowed
	 */
	public void set_timestamp(int val) {
		bindings.UnsignedNodeAnnouncement_set_timestamp(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The `node_id` this announcement originated from (don't rebroadcast the `node_announcement` back
	 * to this node).
	 */
	public NodeId get_node_id() {
		long ret = bindings.UnsignedNodeAnnouncement_get_node_id(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The `node_id` this announcement originated from (don't rebroadcast the `node_announcement` back
	 * to this node).
	 */
	public void set_node_id(org.ldk.structs.NodeId val) {
		bindings.UnsignedNodeAnnouncement_set_node_id(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * An RGB color for UI purposes
	 */
	public byte[] get_rgb() {
		byte[] ret = bindings.UnsignedNodeAnnouncement_get_rgb(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * An RGB color for UI purposes
	 */
	public void set_rgb(byte[] val) {
		bindings.UnsignedNodeAnnouncement_set_rgb(this.ptr, InternalUtils.check_arr_len(val, 3));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * An alias, for UI purposes.
	 * 
	 * This should be sanitized before use. There is no guarantee of uniqueness.
	 */
	public NodeAlias get_alias() {
		long ret = bindings.UnsignedNodeAnnouncement_get_alias(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAlias ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAlias(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * An alias, for UI purposes.
	 * 
	 * This should be sanitized before use. There is no guarantee of uniqueness.
	 */
	public void set_alias(org.ldk.structs.NodeAlias val) {
		bindings.UnsignedNodeAnnouncement_set_alias(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * List of addresses on which this node is reachable
	 * 
	 * Returns a copy of the field.
	 */
	public SocketAddress[] get_addresses() {
		long[] ret = bindings.UnsignedNodeAnnouncement_get_addresses(this.ptr);
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
	 * List of addresses on which this node is reachable
	 */
	public void set_addresses(SocketAddress[] val) {
		bindings.UnsignedNodeAnnouncement_set_addresses(this.ptr, val != null ? Arrays.stream(val).mapToLong(val_conv_15 -> val_conv_15.ptr).toArray() : null);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Excess address data which was signed as a part of the message which we do not (yet) understand how
	 * to decode.
	 * 
	 * This is stored to ensure forward-compatibility as new address types are added to the lightning gossip protocol.
	 * 
	 * Returns a copy of the field.
	 */
	public byte[] get_excess_address_data() {
		byte[] ret = bindings.UnsignedNodeAnnouncement_get_excess_address_data(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Excess address data which was signed as a part of the message which we do not (yet) understand how
	 * to decode.
	 * 
	 * This is stored to ensure forward-compatibility as new address types are added to the lightning gossip protocol.
	 */
	public void set_excess_address_data(byte[] val) {
		bindings.UnsignedNodeAnnouncement_set_excess_address_data(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Excess data which was signed as a part of the message which we do not (yet) understand how
	 * to decode.
	 * 
	 * This is stored to ensure forward-compatibility as new fields are added to the lightning gossip protocol.
	 * 
	 * Returns a copy of the field.
	 */
	public byte[] get_excess_data() {
		byte[] ret = bindings.UnsignedNodeAnnouncement_get_excess_data(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Excess data which was signed as a part of the message which we do not (yet) understand how
	 * to decode.
	 * 
	 * This is stored to ensure forward-compatibility as new fields are added to the lightning gossip protocol.
	 */
	public void set_excess_data(byte[] val) {
		bindings.UnsignedNodeAnnouncement_set_excess_data(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new UnsignedNodeAnnouncement given each field
	 */
	public static UnsignedNodeAnnouncement of(org.ldk.structs.NodeFeatures features_arg, int timestamp_arg, org.ldk.structs.NodeId node_id_arg, byte[] rgb_arg, org.ldk.structs.NodeAlias alias_arg, SocketAddress[] addresses_arg, byte[] excess_address_data_arg, byte[] excess_data_arg) {
		long ret = bindings.UnsignedNodeAnnouncement_new(features_arg.ptr, timestamp_arg, node_id_arg.ptr, InternalUtils.check_arr_len(rgb_arg, 3), alias_arg.ptr, addresses_arg != null ? Arrays.stream(addresses_arg).mapToLong(addresses_arg_conv_15 -> addresses_arg_conv_15.ptr).toArray() : null, excess_address_data_arg, excess_data_arg);
		Reference.reachabilityFence(features_arg);
		Reference.reachabilityFence(timestamp_arg);
		Reference.reachabilityFence(node_id_arg);
		Reference.reachabilityFence(rgb_arg);
		Reference.reachabilityFence(alias_arg);
		Reference.reachabilityFence(addresses_arg);
		Reference.reachabilityFence(excess_address_data_arg);
		Reference.reachabilityFence(excess_data_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedNodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedNodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.UnsignedNodeAnnouncement_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the UnsignedNodeAnnouncement
	 */
	public UnsignedNodeAnnouncement clone() {
		long ret = bindings.UnsignedNodeAnnouncement_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedNodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedNodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the UnsignedNodeAnnouncement.
	 */
	public long hash() {
		long ret = bindings.UnsignedNodeAnnouncement_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two UnsignedNodeAnnouncements contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.UnsignedNodeAnnouncement b) {
		boolean ret = bindings.UnsignedNodeAnnouncement_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof UnsignedNodeAnnouncement)) return false;
		return this.eq((UnsignedNodeAnnouncement)o);
	}
	/**
	 * Serialize the UnsignedNodeAnnouncement object into a byte array which can be read by UnsignedNodeAnnouncement_read
	 */
	public byte[] write() {
		byte[] ret = bindings.UnsignedNodeAnnouncement_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a UnsignedNodeAnnouncement from a byte array, created by UnsignedNodeAnnouncement_write
	 */
	public static Result_UnsignedNodeAnnouncementDecodeErrorZ read(byte[] ser) {
		long ret = bindings.UnsignedNodeAnnouncement_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedNodeAnnouncementDecodeErrorZ ret_hu_conv = Result_UnsignedNodeAnnouncementDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
