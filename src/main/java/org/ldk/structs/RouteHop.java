package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A hop in a route, and additional metadata about it. \"Hop\" is defined as a node and the channel
 * that leads to it.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class RouteHop extends CommonBase {
	RouteHop(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.RouteHop_free(ptr); }
	}

	/**
	 * The node_id of the node at this hop.
	 */
	public byte[] get_pubkey() {
		byte[] ret = bindings.RouteHop_get_pubkey(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The node_id of the node at this hop.
	 */
	public void set_pubkey(byte[] val) {
		bindings.RouteHop_set_pubkey(this.ptr, InternalUtils.check_arr_len(val, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The node_announcement features of the node at this hop. For the last hop, these may be
	 * amended to match the features present in the invoice this node generated.
	 */
	public NodeFeatures get_node_features() {
		long ret = bindings.RouteHop_get_node_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The node_announcement features of the node at this hop. For the last hop, these may be
	 * amended to match the features present in the invoice this node generated.
	 */
	public void set_node_features(org.ldk.structs.NodeFeatures val) {
		bindings.RouteHop_set_node_features(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The channel that should be used from the previous hop to reach this node.
	 */
	public long get_short_channel_id() {
		long ret = bindings.RouteHop_get_short_channel_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The channel that should be used from the previous hop to reach this node.
	 */
	public void set_short_channel_id(long val) {
		bindings.RouteHop_set_short_channel_id(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The channel_announcement features of the channel that should be used from the previous hop
	 * to reach this node.
	 */
	public ChannelFeatures get_channel_features() {
		long ret = bindings.RouteHop_get_channel_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The channel_announcement features of the channel that should be used from the previous hop
	 * to reach this node.
	 */
	public void set_channel_features(org.ldk.structs.ChannelFeatures val) {
		bindings.RouteHop_set_channel_features(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The fee taken on this hop (for paying for the use of the *next* channel in the path).
	 * If this is the last hop in [`Path::hops`]:
	 * if we're sending to a [`BlindedPaymentPath`], this is the fee paid for use of the entire
	 * blinded path
	 * otherwise, this is the full value of this [`Path`]'s part of the payment
	 */
	public long get_fee_msat() {
		long ret = bindings.RouteHop_get_fee_msat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The fee taken on this hop (for paying for the use of the *next* channel in the path).
	 * If this is the last hop in [`Path::hops`]:
	 * if we're sending to a [`BlindedPaymentPath`], this is the fee paid for use of the entire
	 * blinded path
	 * otherwise, this is the full value of this [`Path`]'s part of the payment
	 */
	public void set_fee_msat(long val) {
		bindings.RouteHop_set_fee_msat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The CLTV delta added for this hop.
	 * If this is the last hop in [`Path::hops`]:
	 * if we're sending to a [`BlindedPaymentPath`], this is the CLTV delta for the entire blinded
	 * path
	 * otherwise, this is the CLTV delta expected at the destination
	 */
	public int get_cltv_expiry_delta() {
		int ret = bindings.RouteHop_get_cltv_expiry_delta(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The CLTV delta added for this hop.
	 * If this is the last hop in [`Path::hops`]:
	 * if we're sending to a [`BlindedPaymentPath`], this is the CLTV delta for the entire blinded
	 * path
	 * otherwise, this is the CLTV delta expected at the destination
	 */
	public void set_cltv_expiry_delta(int val) {
		bindings.RouteHop_set_cltv_expiry_delta(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Indicates whether this hop is possibly announced in the public network graph.
	 * 
	 * Will be `true` if there is a possibility that the channel is publicly known, i.e., if we
	 * either know for sure it's announced in the public graph, or if any public channels exist
	 * for which the given `short_channel_id` could be an alias for. Will be `false` if we believe
	 * the channel to be unannounced.
	 * 
	 * Will be `true` for objects serialized with LDK version 0.0.116 and before.
	 */
	public boolean get_maybe_announced_channel() {
		boolean ret = bindings.RouteHop_get_maybe_announced_channel(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Indicates whether this hop is possibly announced in the public network graph.
	 * 
	 * Will be `true` if there is a possibility that the channel is publicly known, i.e., if we
	 * either know for sure it's announced in the public graph, or if any public channels exist
	 * for which the given `short_channel_id` could be an alias for. Will be `false` if we believe
	 * the channel to be unannounced.
	 * 
	 * Will be `true` for objects serialized with LDK version 0.0.116 and before.
	 */
	public void set_maybe_announced_channel(boolean val) {
		bindings.RouteHop_set_maybe_announced_channel(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new RouteHop given each field
	 */
	public static RouteHop of(byte[] pubkey_arg, org.ldk.structs.NodeFeatures node_features_arg, long short_channel_id_arg, org.ldk.structs.ChannelFeatures channel_features_arg, long fee_msat_arg, int cltv_expiry_delta_arg, boolean maybe_announced_channel_arg) {
		long ret = bindings.RouteHop_new(InternalUtils.check_arr_len(pubkey_arg, 33), node_features_arg.ptr, short_channel_id_arg, channel_features_arg.ptr, fee_msat_arg, cltv_expiry_delta_arg, maybe_announced_channel_arg);
		Reference.reachabilityFence(pubkey_arg);
		Reference.reachabilityFence(node_features_arg);
		Reference.reachabilityFence(short_channel_id_arg);
		Reference.reachabilityFence(channel_features_arg);
		Reference.reachabilityFence(fee_msat_arg);
		Reference.reachabilityFence(cltv_expiry_delta_arg);
		Reference.reachabilityFence(maybe_announced_channel_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteHop ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteHop(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.RouteHop_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the RouteHop
	 */
	public RouteHop clone() {
		long ret = bindings.RouteHop_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteHop ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteHop(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the RouteHop.
	 */
	public long hash() {
		long ret = bindings.RouteHop_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two RouteHops contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.RouteHop b) {
		boolean ret = bindings.RouteHop_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof RouteHop)) return false;
		return this.eq((RouteHop)o);
	}
	/**
	 * Serialize the RouteHop object into a byte array which can be read by RouteHop_read
	 */
	public byte[] write() {
		byte[] ret = bindings.RouteHop_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a RouteHop from a byte array, created by RouteHop_write
	 */
	public static Result_RouteHopDecodeErrorZ read(byte[] ser) {
		long ret = bindings.RouteHop_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RouteHopDecodeErrorZ ret_hu_conv = Result_RouteHopDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
