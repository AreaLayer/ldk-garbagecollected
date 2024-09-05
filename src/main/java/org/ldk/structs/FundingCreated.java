package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A [`funding_created`] message to be sent to or received from a peer.
 * 
 * Used in V1 channel establishment
 * 
 * [`funding_created`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#the-funding_created-message
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class FundingCreated extends CommonBase {
	FundingCreated(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.FundingCreated_free(ptr); }
	}

	/**
	 * A temporary channel ID, until the funding is established
	 */
	public ChannelId get_temporary_channel_id() {
		long ret = bindings.FundingCreated_get_temporary_channel_id(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * A temporary channel ID, until the funding is established
	 */
	public void set_temporary_channel_id(org.ldk.structs.ChannelId val) {
		bindings.FundingCreated_set_temporary_channel_id(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The funding transaction ID
	 */
	public byte[] get_funding_txid() {
		byte[] ret = bindings.FundingCreated_get_funding_txid(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The funding transaction ID
	 */
	public void set_funding_txid(byte[] val) {
		bindings.FundingCreated_set_funding_txid(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The specific output index funding this channel
	 */
	public short get_funding_output_index() {
		short ret = bindings.FundingCreated_get_funding_output_index(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The specific output index funding this channel
	 */
	public void set_funding_output_index(short val) {
		bindings.FundingCreated_set_funding_output_index(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The signature of the channel initiator (funder) on the initial commitment transaction
	 */
	public byte[] get_signature() {
		byte[] ret = bindings.FundingCreated_get_signature(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The signature of the channel initiator (funder) on the initial commitment transaction
	 */
	public void set_signature(byte[] val) {
		bindings.FundingCreated_set_signature(this.ptr, InternalUtils.check_arr_len(val, 64));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new FundingCreated given each field
	 */
	public static FundingCreated of(org.ldk.structs.ChannelId temporary_channel_id_arg, byte[] funding_txid_arg, short funding_output_index_arg, byte[] signature_arg) {
		long ret = bindings.FundingCreated_new(temporary_channel_id_arg.ptr, InternalUtils.check_arr_len(funding_txid_arg, 32), funding_output_index_arg, InternalUtils.check_arr_len(signature_arg, 64));
		Reference.reachabilityFence(temporary_channel_id_arg);
		Reference.reachabilityFence(funding_txid_arg);
		Reference.reachabilityFence(funding_output_index_arg);
		Reference.reachabilityFence(signature_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingCreated ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingCreated(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.FundingCreated_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the FundingCreated
	 */
	public FundingCreated clone() {
		long ret = bindings.FundingCreated_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingCreated ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingCreated(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the FundingCreated.
	 */
	public long hash() {
		long ret = bindings.FundingCreated_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two FundingCreateds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.FundingCreated b) {
		boolean ret = bindings.FundingCreated_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof FundingCreated)) return false;
		return this.eq((FundingCreated)o);
	}
	/**
	 * Serialize the FundingCreated object into a byte array which can be read by FundingCreated_read
	 */
	public byte[] write() {
		byte[] ret = bindings.FundingCreated_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a FundingCreated from a byte array, created by FundingCreated_write
	 */
	public static Result_FundingCreatedDecodeErrorZ read(byte[] ser) {
		long ret = bindings.FundingCreated_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingCreatedDecodeErrorZ ret_hu_conv = Result_FundingCreatedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
