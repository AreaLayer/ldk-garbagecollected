using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Fees and parameters for a JIT Channel including the promise.
 * 
 * The promise is an HMAC calculated using a secret known to the LSP and the rest of the fields as input.
 * It exists so the LSP can verify the authenticity of a client provided LSPS2OpeningFeeParams by recalculating
 * the promise using the secret. Once verified they can be confident it was not modified by the client.
 */
public class LSPS2OpeningFeeParams : CommonBase {
	internal LSPS2OpeningFeeParams(object _dummy, long ptr) : base(ptr) { }
	~LSPS2OpeningFeeParams() {
		if (ptr != 0) { bindings.LSPS2OpeningFeeParams_free(ptr); }
	}

	/**
	 * The minimum fee required for the channel open.
	 */
	public long get_min_fee_msat() {
		long ret = bindings.LSPS2OpeningFeeParams_get_min_fee_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum fee required for the channel open.
	 */
	public void set_min_fee_msat(long val) {
		bindings.LSPS2OpeningFeeParams_set_min_fee_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A fee proportional to the size of the initial payment.
	 */
	public int get_proportional() {
		int ret = bindings.LSPS2OpeningFeeParams_get_proportional(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A fee proportional to the size of the initial payment.
	 */
	public void set_proportional(int val) {
		bindings.LSPS2OpeningFeeParams_set_proportional(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * An [`ISO8601`](https://www.iso.org/iso-8601-date-and-time-format.html) formatted date for which these params are valid.
	 */
	public org.ldk.structs.LSPSDateTime get_valid_until() {
		long ret = bindings.LSPS2OpeningFeeParams_get_valid_until(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An [`ISO8601`](https://www.iso.org/iso-8601-date-and-time-format.html) formatted date for which these params are valid.
	 */
	public void set_valid_until(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS2OpeningFeeParams_set_valid_until(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of blocks after confirmation that the LSP promises it will keep the channel alive without closing.
	 */
	public int get_min_lifetime() {
		int ret = bindings.LSPS2OpeningFeeParams_get_min_lifetime(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The number of blocks after confirmation that the LSP promises it will keep the channel alive without closing.
	 */
	public void set_min_lifetime(int val) {
		bindings.LSPS2OpeningFeeParams_set_min_lifetime(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of blocks that the client is allowed to set its `to_self_delay` parameter.
	 */
	public int get_max_client_to_self_delay() {
		int ret = bindings.LSPS2OpeningFeeParams_get_max_client_to_self_delay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of blocks that the client is allowed to set its `to_self_delay` parameter.
	 */
	public void set_max_client_to_self_delay(int val) {
		bindings.LSPS2OpeningFeeParams_set_max_client_to_self_delay(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum payment size that the LSP will accept when opening a channel.
	 */
	public long get_min_payment_size_msat() {
		long ret = bindings.LSPS2OpeningFeeParams_get_min_payment_size_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum payment size that the LSP will accept when opening a channel.
	 */
	public void set_min_payment_size_msat(long val) {
		bindings.LSPS2OpeningFeeParams_set_min_payment_size_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum payment size that the LSP will accept when opening a channel.
	 */
	public long get_max_payment_size_msat() {
		long ret = bindings.LSPS2OpeningFeeParams_get_max_payment_size_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum payment size that the LSP will accept when opening a channel.
	 */
	public void set_max_payment_size_msat(long val) {
		bindings.LSPS2OpeningFeeParams_set_max_payment_size_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The HMAC used to verify the authenticity of these parameters.
	 */
	public string get_promise() {
		long ret = bindings.LSPS2OpeningFeeParams_get_promise(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * The HMAC used to verify the authenticity of these parameters.
	 */
	public void set_promise(string val) {
		bindings.LSPS2OpeningFeeParams_set_promise(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS2OpeningFeeParams given each field
	 */
	public static org.ldk.structs.LSPS2OpeningFeeParams of(long min_fee_msat_arg, int proportional_arg, org.ldk.structs.LSPSDateTime valid_until_arg, int min_lifetime_arg, int max_client_to_self_delay_arg, long min_payment_size_msat_arg, long max_payment_size_msat_arg, string promise_arg) {
		long ret = bindings.LSPS2OpeningFeeParams_new(min_fee_msat_arg, proportional_arg, valid_until_arg.ptr, min_lifetime_arg, max_client_to_self_delay_arg, min_payment_size_msat_arg, max_payment_size_msat_arg, InternalUtils.encodeString(promise_arg));
		GC.KeepAlive(min_fee_msat_arg);
		GC.KeepAlive(proportional_arg);
		GC.KeepAlive(valid_until_arg);
		GC.KeepAlive(min_lifetime_arg);
		GC.KeepAlive(max_client_to_self_delay_arg);
		GC.KeepAlive(min_payment_size_msat_arg);
		GC.KeepAlive(max_payment_size_msat_arg);
		GC.KeepAlive(promise_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2OpeningFeeParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2OpeningFeeParams_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2OpeningFeeParams
	 */
	public org.ldk.structs.LSPS2OpeningFeeParams clone() {
		long ret = bindings.LSPS2OpeningFeeParams_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2OpeningFeeParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2OpeningFeeParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2OpeningFeeParamss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS2OpeningFeeParams b) {
		bool ret = bindings.LSPS2OpeningFeeParams_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2OpeningFeeParams)) return false;
		return this.eq((LSPS2OpeningFeeParams)o);
	}
}
} } }
