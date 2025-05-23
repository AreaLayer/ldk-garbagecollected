package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A [`channel_update`] message to be sent to or received from a peer.
 * 
 * [`channel_update`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-channel_update-message
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ChannelUpdate extends CommonBase {
	ChannelUpdate(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ChannelUpdate_free(ptr); }
	}

	/**
	 * A signature of the channel update
	 */
	public byte[] get_signature() {
		byte[] ret = bindings.ChannelUpdate_get_signature(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A signature of the channel update
	 */
	public void set_signature(byte[] val) {
		bindings.ChannelUpdate_set_signature(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The actual channel update
	 */
	public UnsignedChannelUpdate get_contents() {
		long ret = bindings.ChannelUpdate_get_contents(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The actual channel update
	 */
	public void set_contents(org.ldk.structs.UnsignedChannelUpdate val) {
		bindings.ChannelUpdate_set_contents(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new ChannelUpdate given each field
	 */
	public static ChannelUpdate of(byte[] signature_arg, org.ldk.structs.UnsignedChannelUpdate contents_arg) {
		long ret = bindings.ChannelUpdate_new(InternalUtils.check_arr_len(signature_arg, 64), contents_arg.ptr);
		Reference.reachabilityFence(signature_arg);
		Reference.reachabilityFence(contents_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.ChannelUpdate_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelUpdate
	 */
	public ChannelUpdate clone() {
		long ret = bindings.ChannelUpdate_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelUpdate.
	 */
	public long hash() {
		long ret = bindings.ChannelUpdate_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ChannelUpdates contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.ChannelUpdate b) {
		boolean ret = bindings.ChannelUpdate_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof ChannelUpdate)) return false;
		return this.eq((ChannelUpdate)o);
	}
	/**
	 * Serialize the ChannelUpdate object into a byte array which can be read by ChannelUpdate_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelUpdate_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a ChannelUpdate from a byte array, created by ChannelUpdate_write
	 */
	public static Result_ChannelUpdateDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelUpdate_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelUpdateDecodeErrorZ ret_hu_conv = Result_ChannelUpdateDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
