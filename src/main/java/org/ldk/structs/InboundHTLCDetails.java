package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Exposes details around pending inbound HTLCs.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class InboundHTLCDetails extends CommonBase {
	InboundHTLCDetails(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.InboundHTLCDetails_free(ptr); }
	}

	/**
	 * The HTLC ID.
	 * The IDs are incremented by 1 starting from 0 for each offered HTLC.
	 * They are unique per channel and inbound/outbound direction, unless an HTLC was only announced
	 * and not part of any commitment transaction.
	 */
	public long get_htlc_id() {
		long ret = bindings.InboundHTLCDetails_get_htlc_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The HTLC ID.
	 * The IDs are incremented by 1 starting from 0 for each offered HTLC.
	 * They are unique per channel and inbound/outbound direction, unless an HTLC was only announced
	 * and not part of any commitment transaction.
	 */
	public void set_htlc_id(long val) {
		bindings.InboundHTLCDetails_set_htlc_id(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The amount in msat.
	 */
	public long get_amount_msat() {
		long ret = bindings.InboundHTLCDetails_get_amount_msat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The amount in msat.
	 */
	public void set_amount_msat(long val) {
		bindings.InboundHTLCDetails_set_amount_msat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The block height at which this HTLC expires.
	 */
	public int get_cltv_expiry() {
		int ret = bindings.InboundHTLCDetails_get_cltv_expiry(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The block height at which this HTLC expires.
	 */
	public void set_cltv_expiry(int val) {
		bindings.InboundHTLCDetails_set_cltv_expiry(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The payment hash.
	 */
	public byte[] get_payment_hash() {
		byte[] ret = bindings.InboundHTLCDetails_get_payment_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The payment hash.
	 */
	public void set_payment_hash(byte[] val) {
		bindings.InboundHTLCDetails_set_payment_hash(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The state of the HTLC in the state machine.
	 * 
	 * Determines on which commitment transactions the HTLC is included and what message the HTLC is
	 * waiting for to advance to the next state.
	 * 
	 * See [`InboundHTLCStateDetails`] for information on the specific states.
	 * 
	 * LDK will always fill this field in, but when downgrading to prior versions of LDK, new
	 * states may result in `None` here.
	 */
	public Option_InboundHTLCStateDetailsZ get_state() {
		long ret = bindings.InboundHTLCDetails_get_state(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_InboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_InboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The state of the HTLC in the state machine.
	 * 
	 * Determines on which commitment transactions the HTLC is included and what message the HTLC is
	 * waiting for to advance to the next state.
	 * 
	 * See [`InboundHTLCStateDetails`] for information on the specific states.
	 * 
	 * LDK will always fill this field in, but when downgrading to prior versions of LDK, new
	 * states may result in `None` here.
	 */
	public void set_state(org.ldk.structs.Option_InboundHTLCStateDetailsZ val) {
		bindings.InboundHTLCDetails_set_state(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
		if (this != null) { this.ptrs_to.add(val); };
	}

	/**
	 * Whether the HTLC has an output below the local dust limit. If so, the output will be trimmed
	 * from the local commitment transaction and added to the commitment transaction fee.
	 * For non-anchor channels, this takes into account the cost of the second-stage HTLC
	 * transactions as well.
	 * 
	 * When the local commitment transaction is broadcasted as part of a unilateral closure,
	 * the value of this HTLC will therefore not be claimable but instead burned as a transaction
	 * fee.
	 * 
	 * Note that dust limits are specific to each party. An HTLC can be dust for the local
	 * commitment transaction but not for the counterparty's commitment transaction and vice versa.
	 */
	public boolean get_is_dust() {
		boolean ret = bindings.InboundHTLCDetails_get_is_dust(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Whether the HTLC has an output below the local dust limit. If so, the output will be trimmed
	 * from the local commitment transaction and added to the commitment transaction fee.
	 * For non-anchor channels, this takes into account the cost of the second-stage HTLC
	 * transactions as well.
	 * 
	 * When the local commitment transaction is broadcasted as part of a unilateral closure,
	 * the value of this HTLC will therefore not be claimable but instead burned as a transaction
	 * fee.
	 * 
	 * Note that dust limits are specific to each party. An HTLC can be dust for the local
	 * commitment transaction but not for the counterparty's commitment transaction and vice versa.
	 */
	public void set_is_dust(boolean val) {
		bindings.InboundHTLCDetails_set_is_dust(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new InboundHTLCDetails given each field
	 */
	public static InboundHTLCDetails of(long htlc_id_arg, long amount_msat_arg, int cltv_expiry_arg, byte[] payment_hash_arg, org.ldk.structs.Option_InboundHTLCStateDetailsZ state_arg, boolean is_dust_arg) {
		long ret = bindings.InboundHTLCDetails_new(htlc_id_arg, amount_msat_arg, cltv_expiry_arg, InternalUtils.check_arr_len(payment_hash_arg, 32), state_arg.ptr, is_dust_arg);
		Reference.reachabilityFence(htlc_id_arg);
		Reference.reachabilityFence(amount_msat_arg);
		Reference.reachabilityFence(cltv_expiry_arg);
		Reference.reachabilityFence(payment_hash_arg);
		Reference.reachabilityFence(state_arg);
		Reference.reachabilityFence(is_dust_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundHTLCDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InboundHTLCDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(state_arg); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.InboundHTLCDetails_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the InboundHTLCDetails
	 */
	public InboundHTLCDetails clone() {
		long ret = bindings.InboundHTLCDetails_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundHTLCDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InboundHTLCDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the InboundHTLCDetails object into a byte array which can be read by InboundHTLCDetails_read
	 */
	public byte[] write() {
		byte[] ret = bindings.InboundHTLCDetails_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a InboundHTLCDetails from a byte array, created by InboundHTLCDetails_write
	 */
	public static Result_InboundHTLCDetailsDecodeErrorZ read(byte[] ser) {
		long ret = bindings.InboundHTLCDetails_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InboundHTLCDetailsDecodeErrorZ ret_hu_conv = Result_InboundHTLCDetailsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
