using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Details regarding a detected on-chain payment.
 */
public class LSPS1OnchainPayment : CommonBase {
	internal LSPS1OnchainPayment(object _dummy, long ptr) : base(ptr) { }
	~LSPS1OnchainPayment() {
		if (ptr != 0) { bindings.LSPS1OnchainPayment_free(ptr); }
	}

	/**
	 * The outpoint of the payment.
	 */
	public string get_outpoint() {
		long ret = bindings.LSPS1OnchainPayment_get_outpoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * The outpoint of the payment.
	 */
	public void set_outpoint(string val) {
		bindings.LSPS1OnchainPayment_set_outpoint(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The amount of satoshi paid.
	 */
	public long get_sat() {
		long ret = bindings.LSPS1OnchainPayment_get_sat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The amount of satoshi paid.
	 */
	public void set_sat(long val) {
		bindings.LSPS1OnchainPayment_set_sat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Indicates if the LSP regards the transaction as sufficiently confirmed.
	 */
	public bool get_confirmed() {
		bool ret = bindings.LSPS1OnchainPayment_get_confirmed(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Indicates if the LSP regards the transaction as sufficiently confirmed.
	 */
	public void set_confirmed(bool val) {
		bindings.LSPS1OnchainPayment_set_confirmed(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1OnchainPayment given each field
	 */
	public static org.ldk.structs.LSPS1OnchainPayment of(string outpoint_arg, long sat_arg, bool confirmed_arg) {
		long ret = bindings.LSPS1OnchainPayment_new(InternalUtils.encodeString(outpoint_arg), sat_arg, confirmed_arg);
		GC.KeepAlive(outpoint_arg);
		GC.KeepAlive(sat_arg);
		GC.KeepAlive(confirmed_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OnchainPayment ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OnchainPayment(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1OnchainPayment_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1OnchainPayment
	 */
	public org.ldk.structs.LSPS1OnchainPayment clone() {
		long ret = bindings.LSPS1OnchainPayment_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1OnchainPayment ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1OnchainPayment(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1OnchainPayments contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1OnchainPayment b) {
		bool ret = bindings.LSPS1OnchainPayment_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1OnchainPayment)) return false;
		return this.eq((LSPS1OnchainPayment)o);
	}
}
} } }
