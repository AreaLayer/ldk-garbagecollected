package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Per-channel data used to build transactions in conjunction with the per-commitment data (CommitmentTransaction).
 * The fields are organized by holder/counterparty.
 * 
 * Normally, this is converted to the broadcaster/countersignatory-organized DirectedChannelTransactionParameters
 * before use, via the as_holder_broadcastable and as_counterparty_broadcastable functions.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ChannelTransactionParameters extends CommonBase {
	ChannelTransactionParameters(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ChannelTransactionParameters_free(ptr); }
	}

	/**
	 * Holder public keys
	 */
	public ChannelPublicKeys get_holder_pubkeys() {
		long ret = bindings.ChannelTransactionParameters_get_holder_pubkeys(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelPublicKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelPublicKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Holder public keys
	 */
	public void set_holder_pubkeys(org.ldk.structs.ChannelPublicKeys val) {
		bindings.ChannelTransactionParameters_set_holder_pubkeys(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The contest delay selected by the holder, which applies to counterparty-broadcast transactions
	 */
	public short get_holder_selected_contest_delay() {
		short ret = bindings.ChannelTransactionParameters_get_holder_selected_contest_delay(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The contest delay selected by the holder, which applies to counterparty-broadcast transactions
	 */
	public void set_holder_selected_contest_delay(short val) {
		bindings.ChannelTransactionParameters_set_holder_selected_contest_delay(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Whether the holder is the initiator of this channel.
	 * This is an input to the commitment number obscure factor computation.
	 */
	public boolean get_is_outbound_from_holder() {
		boolean ret = bindings.ChannelTransactionParameters_get_is_outbound_from_holder(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Whether the holder is the initiator of this channel.
	 * This is an input to the commitment number obscure factor computation.
	 */
	public void set_is_outbound_from_holder(boolean val) {
		bindings.ChannelTransactionParameters_set_is_outbound_from_holder(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The late-bound counterparty channel transaction parameters.
	 * These parameters are populated at the point in the protocol where the counterparty provides them.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public CounterpartyChannelTransactionParameters get_counterparty_parameters() {
		long ret = bindings.ChannelTransactionParameters_get_counterparty_parameters(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CounterpartyChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CounterpartyChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The late-bound counterparty channel transaction parameters.
	 * These parameters are populated at the point in the protocol where the counterparty provides them.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_counterparty_parameters(@Nullable org.ldk.structs.CounterpartyChannelTransactionParameters val) {
		bindings.ChannelTransactionParameters_set_counterparty_parameters(this.ptr, val == null ? 0 : val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The late-bound funding outpoint
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public OutPoint get_funding_outpoint() {
		long ret = bindings.ChannelTransactionParameters_get_funding_outpoint(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The late-bound funding outpoint
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_funding_outpoint(@Nullable org.ldk.structs.OutPoint val) {
		bindings.ChannelTransactionParameters_set_funding_outpoint(this.ptr, val == null ? 0 : val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * This channel's type, as negotiated during channel open. For old objects where this field
	 * wasn't serialized, it will default to static_remote_key at deserialization.
	 */
	public ChannelTypeFeatures get_channel_type_features() {
		long ret = bindings.ChannelTransactionParameters_get_channel_type_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * This channel's type, as negotiated during channel open. For old objects where this field
	 * wasn't serialized, it will default to static_remote_key at deserialization.
	 */
	public void set_channel_type_features(org.ldk.structs.ChannelTypeFeatures val) {
		bindings.ChannelTransactionParameters_set_channel_type_features(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new ChannelTransactionParameters given each field
	 * 
	 * Note that counterparty_parameters_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that funding_outpoint_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static ChannelTransactionParameters of(org.ldk.structs.ChannelPublicKeys holder_pubkeys_arg, short holder_selected_contest_delay_arg, boolean is_outbound_from_holder_arg, @Nullable org.ldk.structs.CounterpartyChannelTransactionParameters counterparty_parameters_arg, @Nullable org.ldk.structs.OutPoint funding_outpoint_arg, org.ldk.structs.ChannelTypeFeatures channel_type_features_arg) {
		long ret = bindings.ChannelTransactionParameters_new(holder_pubkeys_arg.ptr, holder_selected_contest_delay_arg, is_outbound_from_holder_arg, counterparty_parameters_arg == null ? 0 : counterparty_parameters_arg.ptr, funding_outpoint_arg == null ? 0 : funding_outpoint_arg.ptr, channel_type_features_arg.ptr);
		Reference.reachabilityFence(holder_pubkeys_arg);
		Reference.reachabilityFence(holder_selected_contest_delay_arg);
		Reference.reachabilityFence(is_outbound_from_holder_arg);
		Reference.reachabilityFence(counterparty_parameters_arg);
		Reference.reachabilityFence(funding_outpoint_arg);
		Reference.reachabilityFence(channel_type_features_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.ChannelTransactionParameters_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelTransactionParameters
	 */
	public ChannelTransactionParameters clone() {
		long ret = bindings.ChannelTransactionParameters_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelTransactionParameters.
	 */
	public long hash() {
		long ret = bindings.ChannelTransactionParameters_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ChannelTransactionParameterss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.ChannelTransactionParameters b) {
		boolean ret = bindings.ChannelTransactionParameters_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof ChannelTransactionParameters)) return false;
		return this.eq((ChannelTransactionParameters)o);
	}
	/**
	 * Whether the late bound parameters are populated.
	 */
	public boolean is_populated() {
		boolean ret = bindings.ChannelTransactionParameters_is_populated(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Convert the holder/counterparty parameters to broadcaster/countersignatory-organized parameters,
	 * given that the holder is the broadcaster.
	 * 
	 * self.is_populated() must be true before calling this function.
	 */
	public DirectedChannelTransactionParameters as_holder_broadcastable() {
		long ret = bindings.ChannelTransactionParameters_as_holder_broadcastable(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DirectedChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DirectedChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Convert the holder/counterparty parameters to broadcaster/countersignatory-organized parameters,
	 * given that the counterparty is the broadcaster.
	 * 
	 * self.is_populated() must be true before calling this function.
	 */
	public DirectedChannelTransactionParameters as_counterparty_broadcastable() {
		long ret = bindings.ChannelTransactionParameters_as_counterparty_broadcastable(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DirectedChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DirectedChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ChannelTransactionParameters object into a byte array which can be read by ChannelTransactionParameters_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelTransactionParameters_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a ChannelTransactionParameters from a byte array, created by ChannelTransactionParameters_write
	 */
	public static Result_ChannelTransactionParametersDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelTransactionParameters_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelTransactionParametersDecodeErrorZ ret_hu_conv = Result_ChannelTransactionParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
