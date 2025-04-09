using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A request to buy a JIT channel.
 */
public class LSPS2BuyRequest : CommonBase {
	internal LSPS2BuyRequest(object _dummy, long ptr) : base(ptr) { }
	~LSPS2BuyRequest() {
		if (ptr != 0) { bindings.LSPS2BuyRequest_free(ptr); }
	}

	/**
	 * The fee parameters you would like to use.
	 */
	public org.ldk.structs.LSPS2OpeningFeeParams get_opening_fee_params() {
		long ret = bindings.LSPS2BuyRequest_get_opening_fee_params(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2OpeningFeeParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The fee parameters you would like to use.
	 */
	public void set_opening_fee_params(org.ldk.structs.LSPS2OpeningFeeParams val) {
		bindings.LSPS2BuyRequest_set_opening_fee_params(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The size of the initial payment you expect to receive.
	 */
	public org.ldk.structs.Option_u64Z get_payment_size_msat() {
		long ret = bindings.LSPS2BuyRequest_get_payment_size_msat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The size of the initial payment you expect to receive.
	 */
	public void set_payment_size_msat(org.ldk.structs.Option_u64Z val) {
		bindings.LSPS2BuyRequest_set_payment_size_msat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS2BuyRequest given each field
	 */
	public static org.ldk.structs.LSPS2BuyRequest of(org.ldk.structs.LSPS2OpeningFeeParams opening_fee_params_arg, org.ldk.structs.Option_u64Z payment_size_msat_arg) {
		long ret = bindings.LSPS2BuyRequest_new(opening_fee_params_arg.ptr, payment_size_msat_arg.ptr);
		GC.KeepAlive(opening_fee_params_arg);
		GC.KeepAlive(payment_size_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2BuyRequest_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2BuyRequest
	 */
	public org.ldk.structs.LSPS2BuyRequest clone() {
		long ret = bindings.LSPS2BuyRequest_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2BuyRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2BuyRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2BuyRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS2BuyRequest b) {
		bool ret = bindings.LSPS2BuyRequest_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2BuyRequest)) return false;
		return this.eq((LSPS2BuyRequest)o);
	}
}
} } }
