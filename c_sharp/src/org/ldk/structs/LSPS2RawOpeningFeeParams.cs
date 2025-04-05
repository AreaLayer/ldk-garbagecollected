using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Fees and parameters for a JIT Channel without the promise.
 * 
 * The promise will be calculated automatically for the LSP and this type converted
 * into an [`LSPS2OpeningFeeParams`] for transit over the wire.
 */
public class LSPS2RawOpeningFeeParams : CommonBase {
	internal LSPS2RawOpeningFeeParams(object _dummy, long ptr) : base(ptr) { }
	~LSPS2RawOpeningFeeParams() {
		if (ptr != 0) { bindings.LSPS2RawOpeningFeeParams_free(ptr); }
	}

	/**
	 * The minimum fee required for the channel open.
	 */
	public long get_min_fee_msat() {
		long ret = bindings.LSPS2RawOpeningFeeParams_get_min_fee_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum fee required for the channel open.
	 */
	public void set_min_fee_msat(long val) {
		bindings.LSPS2RawOpeningFeeParams_set_min_fee_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A fee proportional to the size of the initial payment.
	 */
	public int get_proportional() {
		int ret = bindings.LSPS2RawOpeningFeeParams_get_proportional(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A fee proportional to the size of the initial payment.
	 */
	public void set_proportional(int val) {
		bindings.LSPS2RawOpeningFeeParams_set_proportional(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * An [`ISO8601`](https://www.iso.org/iso-8601-date-and-time-format.html) formatted date for which these params are valid.
	 */
	public org.ldk.structs.LSPSDateTime get_valid_until() {
		long ret = bindings.LSPS2RawOpeningFeeParams_get_valid_until(this.ptr);
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
		bindings.LSPS2RawOpeningFeeParams_set_valid_until(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of blocks after confirmation that the LSP promises it will keep the channel alive without closing.
	 */
	public int get_min_lifetime() {
		int ret = bindings.LSPS2RawOpeningFeeParams_get_min_lifetime(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The number of blocks after confirmation that the LSP promises it will keep the channel alive without closing.
	 */
	public void set_min_lifetime(int val) {
		bindings.LSPS2RawOpeningFeeParams_set_min_lifetime(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of blocks that the client is allowed to set its `to_self_delay` parameter.
	 */
	public int get_max_client_to_self_delay() {
		int ret = bindings.LSPS2RawOpeningFeeParams_get_max_client_to_self_delay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of blocks that the client is allowed to set its `to_self_delay` parameter.
	 */
	public void set_max_client_to_self_delay(int val) {
		bindings.LSPS2RawOpeningFeeParams_set_max_client_to_self_delay(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum payment size that the LSP will accept when opening a channel.
	 */
	public long get_min_payment_size_msat() {
		long ret = bindings.LSPS2RawOpeningFeeParams_get_min_payment_size_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum payment size that the LSP will accept when opening a channel.
	 */
	public void set_min_payment_size_msat(long val) {
		bindings.LSPS2RawOpeningFeeParams_set_min_payment_size_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum payment size that the LSP will accept when opening a channel.
	 */
	public long get_max_payment_size_msat() {
		long ret = bindings.LSPS2RawOpeningFeeParams_get_max_payment_size_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum payment size that the LSP will accept when opening a channel.
	 */
	public void set_max_payment_size_msat(long val) {
		bindings.LSPS2RawOpeningFeeParams_set_max_payment_size_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS2RawOpeningFeeParams given each field
	 */
	public static org.ldk.structs.LSPS2RawOpeningFeeParams of(long min_fee_msat_arg, int proportional_arg, org.ldk.structs.LSPSDateTime valid_until_arg, int min_lifetime_arg, int max_client_to_self_delay_arg, long min_payment_size_msat_arg, long max_payment_size_msat_arg) {
		long ret = bindings.LSPS2RawOpeningFeeParams_new(min_fee_msat_arg, proportional_arg, valid_until_arg.ptr, min_lifetime_arg, max_client_to_self_delay_arg, min_payment_size_msat_arg, max_payment_size_msat_arg);
		GC.KeepAlive(min_fee_msat_arg);
		GC.KeepAlive(proportional_arg);
		GC.KeepAlive(valid_until_arg);
		GC.KeepAlive(min_lifetime_arg);
		GC.KeepAlive(max_client_to_self_delay_arg);
		GC.KeepAlive(min_payment_size_msat_arg);
		GC.KeepAlive(max_payment_size_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2RawOpeningFeeParams ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2RawOpeningFeeParams(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
