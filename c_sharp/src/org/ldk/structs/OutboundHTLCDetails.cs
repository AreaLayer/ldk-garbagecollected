using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Exposes details around pending outbound HTLCs.
 */
public class OutboundHTLCDetails : CommonBase {
	internal OutboundHTLCDetails(object _dummy, long ptr) : base(ptr) { }
	~OutboundHTLCDetails() {
		if (ptr != 0) { bindings.OutboundHTLCDetails_free(ptr); }
	}

	/**
	 * The HTLC ID.
	 * The IDs are incremented by 1 starting from 0 for each offered HTLC.
	 * They are unique per channel and inbound/outbound direction, unless an HTLC was only announced
	 * and not part of any commitment transaction.
	 * 
	 * Not present when we are awaiting a remote revocation and the HTLC is not added yet.
	 */
	public Option_u64Z get_htlc_id() {
		long ret = bindings.OutboundHTLCDetails_get_htlc_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The HTLC ID.
	 * The IDs are incremented by 1 starting from 0 for each offered HTLC.
	 * They are unique per channel and inbound/outbound direction, unless an HTLC was only announced
	 * and not part of any commitment transaction.
	 * 
	 * Not present when we are awaiting a remote revocation and the HTLC is not added yet.
	 */
	public void set_htlc_id(org.ldk.structs.Option_u64Z val) {
		bindings.OutboundHTLCDetails_set_htlc_id(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The amount in msat.
	 */
	public long get_amount_msat() {
		long ret = bindings.OutboundHTLCDetails_get_amount_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The amount in msat.
	 */
	public void set_amount_msat(long val) {
		bindings.OutboundHTLCDetails_set_amount_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The block height at which this HTLC expires.
	 */
	public int get_cltv_expiry() {
		int ret = bindings.OutboundHTLCDetails_get_cltv_expiry(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The block height at which this HTLC expires.
	 */
	public void set_cltv_expiry(int val) {
		bindings.OutboundHTLCDetails_set_cltv_expiry(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The payment hash.
	 */
	public byte[] get_payment_hash() {
		long ret = bindings.OutboundHTLCDetails_get_payment_hash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The payment hash.
	 */
	public void set_payment_hash(byte[] val) {
		bindings.OutboundHTLCDetails_set_payment_hash(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The state of the HTLC in the state machine.
	 * 
	 * Determines on which commitment transactions the HTLC is included and what message the HTLC is
	 * waiting for to advance to the next state.
	 * 
	 * See [`OutboundHTLCStateDetails`] for information on the specific states.
	 * 
	 * LDK will always fill this field in, but when downgrading to prior versions of LDK, new
	 * states may result in `None` here.
	 */
	public Option_OutboundHTLCStateDetailsZ get_state() {
		long ret = bindings.OutboundHTLCDetails_get_state(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OutboundHTLCStateDetailsZ ret_hu_conv = org.ldk.structs.Option_OutboundHTLCStateDetailsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The state of the HTLC in the state machine.
	 * 
	 * Determines on which commitment transactions the HTLC is included and what message the HTLC is
	 * waiting for to advance to the next state.
	 * 
	 * See [`OutboundHTLCStateDetails`] for information on the specific states.
	 * 
	 * LDK will always fill this field in, but when downgrading to prior versions of LDK, new
	 * states may result in `None` here.
	 */
	public void set_state(org.ldk.structs.Option_OutboundHTLCStateDetailsZ val) {
		bindings.OutboundHTLCDetails_set_state(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The extra fee being skimmed off the top of this HTLC.
	 */
	public Option_u64Z get_skimmed_fee_msat() {
		long ret = bindings.OutboundHTLCDetails_get_skimmed_fee_msat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The extra fee being skimmed off the top of this HTLC.
	 */
	public void set_skimmed_fee_msat(org.ldk.structs.Option_u64Z val) {
		bindings.OutboundHTLCDetails_set_skimmed_fee_msat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
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
	public bool get_is_dust() {
		bool ret = bindings.OutboundHTLCDetails_get_is_dust(this.ptr);
		GC.KeepAlive(this);
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
	public void set_is_dust(bool val) {
		bindings.OutboundHTLCDetails_set_is_dust(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new OutboundHTLCDetails given each field
	 */
	public static OutboundHTLCDetails of(org.ldk.structs.Option_u64Z htlc_id_arg, long amount_msat_arg, int cltv_expiry_arg, byte[] payment_hash_arg, org.ldk.structs.Option_OutboundHTLCStateDetailsZ state_arg, org.ldk.structs.Option_u64Z skimmed_fee_msat_arg, bool is_dust_arg) {
		long ret = bindings.OutboundHTLCDetails_new(htlc_id_arg.ptr, amount_msat_arg, cltv_expiry_arg, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash_arg, 32)), state_arg.ptr, skimmed_fee_msat_arg.ptr, is_dust_arg);
		GC.KeepAlive(htlc_id_arg);
		GC.KeepAlive(amount_msat_arg);
		GC.KeepAlive(cltv_expiry_arg);
		GC.KeepAlive(payment_hash_arg);
		GC.KeepAlive(state_arg);
		GC.KeepAlive(skimmed_fee_msat_arg);
		GC.KeepAlive(is_dust_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutboundHTLCDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutboundHTLCDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.OutboundHTLCDetails_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OutboundHTLCDetails
	 */
	public OutboundHTLCDetails clone() {
		long ret = bindings.OutboundHTLCDetails_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutboundHTLCDetails ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutboundHTLCDetails(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the OutboundHTLCDetails object into a byte array which can be read by OutboundHTLCDetails_read
	 */
	public byte[] write() {
		long ret = bindings.OutboundHTLCDetails_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a OutboundHTLCDetails from a byte array, created by OutboundHTLCDetails_write
	 */
	public static Result_OutboundHTLCDetailsDecodeErrorZ read(byte[] ser) {
		long ret = bindings.OutboundHTLCDetails_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutboundHTLCDetailsDecodeErrorZ ret_hu_conv = Result_OutboundHTLCDetailsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
