using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Struct used to return values from [`RevokeAndACK`] messages, containing a bunch of commitment
 * transaction updates if they were pending.
 */
public class CommitmentUpdate : CommonBase {
	internal CommitmentUpdate(object _dummy, long ptr) : base(ptr) { }
	~CommitmentUpdate() {
		if (ptr != 0) { bindings.CommitmentUpdate_free(ptr); }
	}

	/**
	 * `update_add_htlc` messages which should be sent
	 */
	public UpdateAddHTLC[] get_update_add_htlcs() {
		long ret = bindings.CommitmentUpdate_get_update_add_htlcs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_15_len = InternalUtils.getArrayLength(ret);
		UpdateAddHTLC[] ret_conv_15_arr = new UpdateAddHTLC[ret_conv_15_len];
		for (int p = 0; p < ret_conv_15_len; p++) {
			long ret_conv_15 = InternalUtils.getU64ArrayElem(ret, p);
			org.ldk.structs.UpdateAddHTLC ret_conv_15_hu_conv = null; if (ret_conv_15 < 0 || ret_conv_15 > 4096) { ret_conv_15_hu_conv = new org.ldk.structs.UpdateAddHTLC(null, ret_conv_15); }
			if (ret_conv_15_hu_conv != null) { ret_conv_15_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_15_arr[p] = ret_conv_15_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_15_arr;
	}

	/**
	 * `update_add_htlc` messages which should be sent
	 */
	public void set_update_add_htlcs(UpdateAddHTLC[] val) {
		bindings.CommitmentUpdate_set_update_add_htlcs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_15 => val_conv_15.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * `update_fulfill_htlc` messages which should be sent
	 */
	public UpdateFulfillHTLC[] get_update_fulfill_htlcs() {
		long ret = bindings.CommitmentUpdate_get_update_fulfill_htlcs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_19_len = InternalUtils.getArrayLength(ret);
		UpdateFulfillHTLC[] ret_conv_19_arr = new UpdateFulfillHTLC[ret_conv_19_len];
		for (int t = 0; t < ret_conv_19_len; t++) {
			long ret_conv_19 = InternalUtils.getU64ArrayElem(ret, t);
			org.ldk.structs.UpdateFulfillHTLC ret_conv_19_hu_conv = null; if (ret_conv_19 < 0 || ret_conv_19 > 4096) { ret_conv_19_hu_conv = new org.ldk.structs.UpdateFulfillHTLC(null, ret_conv_19); }
			if (ret_conv_19_hu_conv != null) { ret_conv_19_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_19_arr[t] = ret_conv_19_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_19_arr;
	}

	/**
	 * `update_fulfill_htlc` messages which should be sent
	 */
	public void set_update_fulfill_htlcs(UpdateFulfillHTLC[] val) {
		bindings.CommitmentUpdate_set_update_fulfill_htlcs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_19 => val_conv_19.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * `update_fail_htlc` messages which should be sent
	 */
	public UpdateFailHTLC[] get_update_fail_htlcs() {
		long ret = bindings.CommitmentUpdate_get_update_fail_htlcs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_16_len = InternalUtils.getArrayLength(ret);
		UpdateFailHTLC[] ret_conv_16_arr = new UpdateFailHTLC[ret_conv_16_len];
		for (int q = 0; q < ret_conv_16_len; q++) {
			long ret_conv_16 = InternalUtils.getU64ArrayElem(ret, q);
			org.ldk.structs.UpdateFailHTLC ret_conv_16_hu_conv = null; if (ret_conv_16 < 0 || ret_conv_16 > 4096) { ret_conv_16_hu_conv = new org.ldk.structs.UpdateFailHTLC(null, ret_conv_16); }
			if (ret_conv_16_hu_conv != null) { ret_conv_16_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_16_arr[q] = ret_conv_16_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_16_arr;
	}

	/**
	 * `update_fail_htlc` messages which should be sent
	 */
	public void set_update_fail_htlcs(UpdateFailHTLC[] val) {
		bindings.CommitmentUpdate_set_update_fail_htlcs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_16 => val_conv_16.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * `update_fail_malformed_htlc` messages which should be sent
	 */
	public UpdateFailMalformedHTLC[] get_update_fail_malformed_htlcs() {
		long ret = bindings.CommitmentUpdate_get_update_fail_malformed_htlcs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_25_len = InternalUtils.getArrayLength(ret);
		UpdateFailMalformedHTLC[] ret_conv_25_arr = new UpdateFailMalformedHTLC[ret_conv_25_len];
		for (int z = 0; z < ret_conv_25_len; z++) {
			long ret_conv_25 = InternalUtils.getU64ArrayElem(ret, z);
			org.ldk.structs.UpdateFailMalformedHTLC ret_conv_25_hu_conv = null; if (ret_conv_25 < 0 || ret_conv_25 > 4096) { ret_conv_25_hu_conv = new org.ldk.structs.UpdateFailMalformedHTLC(null, ret_conv_25); }
			if (ret_conv_25_hu_conv != null) { ret_conv_25_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_25_arr[z] = ret_conv_25_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_25_arr;
	}

	/**
	 * `update_fail_malformed_htlc` messages which should be sent
	 */
	public void set_update_fail_malformed_htlcs(UpdateFailMalformedHTLC[] val) {
		bindings.CommitmentUpdate_set_update_fail_malformed_htlcs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_25 => val_conv_25.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * An `update_fee` message which should be sent
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.UpdateFee get_update_fee() {
		long ret = bindings.CommitmentUpdate_get_update_fee(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFee ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFee(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An `update_fee` message which should be sent
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_update_fee(org.ldk.structs.UpdateFee val) {
		bindings.CommitmentUpdate_set_update_fee(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A `commitment_signed` message which should be sent
	 */
	public org.ldk.structs.CommitmentSigned get_commitment_signed() {
		long ret = bindings.CommitmentUpdate_get_commitment_signed(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentSigned ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentSigned(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * A `commitment_signed` message which should be sent
	 */
	public void set_commitment_signed(org.ldk.structs.CommitmentSigned val) {
		bindings.CommitmentUpdate_set_commitment_signed(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new CommitmentUpdate given each field
	 * 
	 * Note that update_fee_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static org.ldk.structs.CommitmentUpdate of(UpdateAddHTLC[] update_add_htlcs_arg, UpdateFulfillHTLC[] update_fulfill_htlcs_arg, UpdateFailHTLC[] update_fail_htlcs_arg, UpdateFailMalformedHTLC[] update_fail_malformed_htlcs_arg, org.ldk.structs.UpdateFee update_fee_arg, org.ldk.structs.CommitmentSigned commitment_signed_arg) {
		long ret = bindings.CommitmentUpdate_new(InternalUtils.encodeUint64Array(InternalUtils.mapArray(update_add_htlcs_arg, update_add_htlcs_arg_conv_15 => update_add_htlcs_arg_conv_15.ptr)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(update_fulfill_htlcs_arg, update_fulfill_htlcs_arg_conv_19 => update_fulfill_htlcs_arg_conv_19.ptr)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(update_fail_htlcs_arg, update_fail_htlcs_arg_conv_16 => update_fail_htlcs_arg_conv_16.ptr)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(update_fail_malformed_htlcs_arg, update_fail_malformed_htlcs_arg_conv_25 => update_fail_malformed_htlcs_arg_conv_25.ptr)), update_fee_arg == null ? 0 : update_fee_arg.ptr, commitment_signed_arg.ptr);
		GC.KeepAlive(update_add_htlcs_arg);
		GC.KeepAlive(update_fulfill_htlcs_arg);
		GC.KeepAlive(update_fail_htlcs_arg);
		GC.KeepAlive(update_fail_malformed_htlcs_arg);
		GC.KeepAlive(update_fee_arg);
		GC.KeepAlive(commitment_signed_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.CommitmentUpdate_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the CommitmentUpdate
	 */
	public org.ldk.structs.CommitmentUpdate clone() {
		long ret = bindings.CommitmentUpdate_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CommitmentUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CommitmentUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the CommitmentUpdate.
	 */
	public long hash() {
		long ret = bindings.CommitmentUpdate_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two CommitmentUpdates contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.CommitmentUpdate b) {
		bool ret = bindings.CommitmentUpdate_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is CommitmentUpdate)) return false;
		return this.eq((CommitmentUpdate)o);
	}
}
} } }
