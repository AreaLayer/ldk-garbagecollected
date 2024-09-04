package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A [`channel_announcement`] message to be sent to or received from a peer.
 * 
 * [`channel_announcement`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-channel_announcement-message
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ChannelAnnouncement extends CommonBase {
	ChannelAnnouncement(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ChannelAnnouncement_free(ptr); }
	}

	/**
	 * Authentication of the announcement by the first public node
	 */
	public byte[] get_node_signature_1() {
		byte[] ret = bindings.ChannelAnnouncement_get_node_signature_1(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Authentication of the announcement by the first public node
	 */
	public void set_node_signature_1(byte[] val) {
		bindings.ChannelAnnouncement_set_node_signature_1(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Authentication of the announcement by the second public node
	 */
	public byte[] get_node_signature_2() {
		byte[] ret = bindings.ChannelAnnouncement_get_node_signature_2(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Authentication of the announcement by the second public node
	 */
	public void set_node_signature_2(byte[] val) {
		bindings.ChannelAnnouncement_set_node_signature_2(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Proof of funding UTXO ownership by the first public node
	 */
	public byte[] get_bitcoin_signature_1() {
		byte[] ret = bindings.ChannelAnnouncement_get_bitcoin_signature_1(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Proof of funding UTXO ownership by the first public node
	 */
	public void set_bitcoin_signature_1(byte[] val) {
		bindings.ChannelAnnouncement_set_bitcoin_signature_1(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Proof of funding UTXO ownership by the second public node
	 */
	public byte[] get_bitcoin_signature_2() {
		byte[] ret = bindings.ChannelAnnouncement_get_bitcoin_signature_2(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Proof of funding UTXO ownership by the second public node
	 */
	public void set_bitcoin_signature_2(byte[] val) {
		bindings.ChannelAnnouncement_set_bitcoin_signature_2(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The actual announcement
	 */
	public UnsignedChannelAnnouncement get_contents() {
		long ret = bindings.ChannelAnnouncement_get_contents(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedChannelAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedChannelAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The actual announcement
	 */
	public void set_contents(org.ldk.structs.UnsignedChannelAnnouncement val) {
		bindings.ChannelAnnouncement_set_contents(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new ChannelAnnouncement given each field
	 */
	public static ChannelAnnouncement of(byte[] node_signature_1_arg, byte[] node_signature_2_arg, byte[] bitcoin_signature_1_arg, byte[] bitcoin_signature_2_arg, org.ldk.structs.UnsignedChannelAnnouncement contents_arg) {
		long ret = bindings.ChannelAnnouncement_new(InternalUtils.check_arr_len(node_signature_1_arg, 64), InternalUtils.check_arr_len(node_signature_2_arg, 64), InternalUtils.check_arr_len(bitcoin_signature_1_arg, 64), InternalUtils.check_arr_len(bitcoin_signature_2_arg, 64), contents_arg.ptr);
		Reference.reachabilityFence(node_signature_1_arg);
		Reference.reachabilityFence(node_signature_2_arg);
		Reference.reachabilityFence(bitcoin_signature_1_arg);
		Reference.reachabilityFence(bitcoin_signature_2_arg);
		Reference.reachabilityFence(contents_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.ChannelAnnouncement_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelAnnouncement
	 */
	public ChannelAnnouncement clone() {
		long ret = bindings.ChannelAnnouncement_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelAnnouncement.
	 */
	public long hash() {
		long ret = bindings.ChannelAnnouncement_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ChannelAnnouncements contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.ChannelAnnouncement b) {
		boolean ret = bindings.ChannelAnnouncement_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof ChannelAnnouncement)) return false;
		return this.eq((ChannelAnnouncement)o);
	}
	/**
	 * Serialize the ChannelAnnouncement object into a byte array which can be read by ChannelAnnouncement_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelAnnouncement_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a ChannelAnnouncement from a byte array, created by ChannelAnnouncement_write
	 */
	public static Result_ChannelAnnouncementDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelAnnouncement_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelAnnouncementDecodeErrorZ ret_hu_conv = Result_ChannelAnnouncementDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
