using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Data to construct a [`BlindedHop`] for receiving a payment. This payload is custom to LDK and
 * may not be valid if received by another lightning implementation.
 */
public class ReceiveTlvs : CommonBase {
	internal ReceiveTlvs(object _dummy, long ptr) : base(ptr) { }
	~ReceiveTlvs() {
		if (ptr != 0) { bindings.ReceiveTlvs_free(ptr); }
	}

	/**
	 * Used to authenticate the sender of a payment to the receiver and tie MPP HTLCs together.
	 */
	public byte[] get_payment_secret() {
		long ret = bindings.ReceiveTlvs_get_payment_secret(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Used to authenticate the sender of a payment to the receiver and tie MPP HTLCs together.
	 */
	public void set_payment_secret(byte[] val) {
		bindings.ReceiveTlvs_set_payment_secret(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constraints for the receiver of this payment.
	 */
	public PaymentConstraints get_payment_constraints() {
		long ret = bindings.ReceiveTlvs_get_payment_constraints(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentConstraints ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentConstraints(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constraints for the receiver of this payment.
	 */
	public void set_payment_constraints(org.ldk.structs.PaymentConstraints val) {
		bindings.ReceiveTlvs_set_payment_constraints(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Context for the receiver of this payment.
	 */
	public PaymentContext get_payment_context() {
		long ret = bindings.ReceiveTlvs_get_payment_context(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentContext ret_hu_conv = org.ldk.structs.PaymentContext.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Context for the receiver of this payment.
	 */
	public void set_payment_context(org.ldk.structs.PaymentContext val) {
		bindings.ReceiveTlvs_set_payment_context(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ReceiveTlvs given each field
	 */
	public static ReceiveTlvs of(byte[] payment_secret_arg, org.ldk.structs.PaymentConstraints payment_constraints_arg, org.ldk.structs.PaymentContext payment_context_arg) {
		long ret = bindings.ReceiveTlvs_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_secret_arg, 32)), payment_constraints_arg.ptr, payment_context_arg.ptr);
		GC.KeepAlive(payment_secret_arg);
		GC.KeepAlive(payment_constraints_arg);
		GC.KeepAlive(payment_context_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ReceiveTlvs_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ReceiveTlvs
	 */
	public ReceiveTlvs clone() {
		long ret = bindings.ReceiveTlvs_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ReceiveTlvs object into a byte array which can be read by ReceiveTlvs_read
	 */
	public byte[] write() {
		long ret = bindings.ReceiveTlvs_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
