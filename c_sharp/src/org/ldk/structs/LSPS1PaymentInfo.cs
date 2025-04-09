using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Details regarding how to pay for an order.
 */
public class LSPS1PaymentInfo : CommonBase {
	internal LSPS1PaymentInfo(object _dummy, long ptr) : base(ptr) { }
	~LSPS1PaymentInfo() {
		if (ptr != 0) { bindings.LSPS1PaymentInfo_free(ptr); }
	}

	/**
	 * A Lightning payment using BOLT 11.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.LSPS1Bolt11PaymentInfo get_bolt11() {
		long ret = bindings.LSPS1PaymentInfo_get_bolt11(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1Bolt11PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1Bolt11PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * A Lightning payment using BOLT 11.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_bolt11(org.ldk.structs.LSPS1Bolt11PaymentInfo val) {
		bindings.LSPS1PaymentInfo_set_bolt11(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * An onchain payment.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.LSPS1OnchainPaymentInfo get_onchain() {
		long ret = bindings.LSPS1PaymentInfo_get_onchain(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OnchainPaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OnchainPaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An onchain payment.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_onchain(org.ldk.structs.LSPS1OnchainPaymentInfo val) {
		bindings.LSPS1PaymentInfo_set_onchain(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1PaymentInfo given each field
	 * 
	 * Note that bolt11_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that onchain_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static org.ldk.structs.LSPS1PaymentInfo of(org.ldk.structs.LSPS1Bolt11PaymentInfo bolt11_arg, org.ldk.structs.LSPS1OnchainPaymentInfo onchain_arg) {
		long ret = bindings.LSPS1PaymentInfo_new(bolt11_arg == null ? 0 : bolt11_arg.ptr, onchain_arg == null ? 0 : onchain_arg.ptr);
		GC.KeepAlive(bolt11_arg);
		GC.KeepAlive(onchain_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1PaymentInfo_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1PaymentInfo
	 */
	public org.ldk.structs.LSPS1PaymentInfo clone() {
		long ret = bindings.LSPS1PaymentInfo_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1PaymentInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1PaymentInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1PaymentInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1PaymentInfo b) {
		bool ret = bindings.LSPS1PaymentInfo_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1PaymentInfo)) return false;
		return this.eq((LSPS1PaymentInfo)o);
	}
}
} } }
