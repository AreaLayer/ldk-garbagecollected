package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Late-bound per-channel counterparty data used to build transactions.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class CounterpartyChannelTransactionParameters extends CommonBase {
	CounterpartyChannelTransactionParameters(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.CounterpartyChannelTransactionParameters_free(ptr); }
	}

	/**
	 * Counter-party public keys
	 */
	public ChannelPublicKeys get_pubkeys() {
		long ret = bindings.CounterpartyChannelTransactionParameters_get_pubkeys(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelPublicKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelPublicKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Counter-party public keys
	 */
	public void set_pubkeys(org.ldk.structs.ChannelPublicKeys val) {
		bindings.CounterpartyChannelTransactionParameters_set_pubkeys(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The contest delay selected by the counterparty, which applies to holder-broadcast transactions
	 */
	public short get_selected_contest_delay() {
		short ret = bindings.CounterpartyChannelTransactionParameters_get_selected_contest_delay(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The contest delay selected by the counterparty, which applies to holder-broadcast transactions
	 */
	public void set_selected_contest_delay(short val) {
		bindings.CounterpartyChannelTransactionParameters_set_selected_contest_delay(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new CounterpartyChannelTransactionParameters given each field
	 */
	public static CounterpartyChannelTransactionParameters of(org.ldk.structs.ChannelPublicKeys pubkeys_arg, short selected_contest_delay_arg) {
		long ret = bindings.CounterpartyChannelTransactionParameters_new(pubkeys_arg.ptr, selected_contest_delay_arg);
		Reference.reachabilityFence(pubkeys_arg);
		Reference.reachabilityFence(selected_contest_delay_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CounterpartyChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CounterpartyChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.CounterpartyChannelTransactionParameters_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the CounterpartyChannelTransactionParameters
	 */
	public CounterpartyChannelTransactionParameters clone() {
		long ret = bindings.CounterpartyChannelTransactionParameters_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CounterpartyChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CounterpartyChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the CounterpartyChannelTransactionParameters.
	 */
	public long hash() {
		long ret = bindings.CounterpartyChannelTransactionParameters_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two CounterpartyChannelTransactionParameterss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.CounterpartyChannelTransactionParameters b) {
		boolean ret = bindings.CounterpartyChannelTransactionParameters_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof CounterpartyChannelTransactionParameters)) return false;
		return this.eq((CounterpartyChannelTransactionParameters)o);
	}
	/**
	 * Serialize the CounterpartyChannelTransactionParameters object into a byte array which can be read by CounterpartyChannelTransactionParameters_read
	 */
	public byte[] write() {
		byte[] ret = bindings.CounterpartyChannelTransactionParameters_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a CounterpartyChannelTransactionParameters from a byte array, created by CounterpartyChannelTransactionParameters_write
	 */
	public static Result_CounterpartyChannelTransactionParametersDecodeErrorZ read(byte[] ser) {
		long ret = bindings.CounterpartyChannelTransactionParameters_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyChannelTransactionParametersDecodeErrorZ ret_hu_conv = Result_CounterpartyChannelTransactionParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
