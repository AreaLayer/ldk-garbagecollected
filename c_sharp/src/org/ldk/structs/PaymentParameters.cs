using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Information used to route a payment.
 */
public class PaymentParameters : CommonBase {
	internal PaymentParameters(object _dummy, long ptr) : base(ptr) { }
	~PaymentParameters() {
		if (ptr != 0) { bindings.PaymentParameters_free(ptr); }
	}

	/**
	 * Information about the payee, such as their features and route hints for their channels.
	 */
	public Payee get_payee() {
		long ret = bindings.PaymentParameters_get_payee(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Payee ret_hu_conv = org.ldk.structs.Payee.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Information about the payee, such as their features and route hints for their channels.
	 */
	public void set_payee(org.ldk.structs.Payee val) {
		bindings.PaymentParameters_set_payee(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Expiration of a payment to the payee, in seconds relative to the UNIX epoch.
	 */
	public Option_u64Z get_expiry_time() {
		long ret = bindings.PaymentParameters_get_expiry_time(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Expiration of a payment to the payee, in seconds relative to the UNIX epoch.
	 */
	public void set_expiry_time(org.ldk.structs.Option_u64Z val) {
		bindings.PaymentParameters_set_expiry_time(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum total CLTV delta we accept for the route.
	 * Defaults to [`DEFAULT_MAX_TOTAL_CLTV_EXPIRY_DELTA`].
	 */
	public int get_max_total_cltv_expiry_delta() {
		int ret = bindings.PaymentParameters_get_max_total_cltv_expiry_delta(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum total CLTV delta we accept for the route.
	 * Defaults to [`DEFAULT_MAX_TOTAL_CLTV_EXPIRY_DELTA`].
	 */
	public void set_max_total_cltv_expiry_delta(int val) {
		bindings.PaymentParameters_set_max_total_cltv_expiry_delta(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of paths that may be used by (MPP) payments.
	 * Defaults to [`DEFAULT_MAX_PATH_COUNT`].
	 */
	public byte get_max_path_count() {
		byte ret = bindings.PaymentParameters_get_max_path_count(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of paths that may be used by (MPP) payments.
	 * Defaults to [`DEFAULT_MAX_PATH_COUNT`].
	 */
	public void set_max_path_count(byte val) {
		bindings.PaymentParameters_set_max_path_count(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of [`Path::hops`] in any returned path.
	 * Defaults to [`MAX_PATH_LENGTH_ESTIMATE`].
	 */
	public byte get_max_path_length() {
		byte ret = bindings.PaymentParameters_get_max_path_length(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of [`Path::hops`] in any returned path.
	 * Defaults to [`MAX_PATH_LENGTH_ESTIMATE`].
	 */
	public void set_max_path_length(byte val) {
		bindings.PaymentParameters_set_max_path_length(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Selects the maximum share of a channel's total capacity which will be sent over a channel,
	 * as a power of 1/2. A higher value prefers to send the payment using more MPP parts whereas
	 * a lower value prefers to send larger MPP parts, potentially saturating channels and
	 * increasing failure probability for those paths.
	 * 
	 * Note that this restriction will be relaxed during pathfinding after paths which meet this
	 * restriction have been found. While paths which meet this criteria will be searched for, it
	 * is ultimately up to the scorer to select them over other paths.
	 * 
	 * A value of 0 will allow payments up to and including a channel's total announced usable
	 * capacity, a value of one will only use up to half its capacity, two 1/4, etc.
	 * 
	 * Default value: 2
	 */
	public byte get_max_channel_saturation_power_of_half() {
		byte ret = bindings.PaymentParameters_get_max_channel_saturation_power_of_half(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Selects the maximum share of a channel's total capacity which will be sent over a channel,
	 * as a power of 1/2. A higher value prefers to send the payment using more MPP parts whereas
	 * a lower value prefers to send larger MPP parts, potentially saturating channels and
	 * increasing failure probability for those paths.
	 * 
	 * Note that this restriction will be relaxed during pathfinding after paths which meet this
	 * restriction have been found. While paths which meet this criteria will be searched for, it
	 * is ultimately up to the scorer to select them over other paths.
	 * 
	 * A value of 0 will allow payments up to and including a channel's total announced usable
	 * capacity, a value of one will only use up to half its capacity, two 1/4, etc.
	 * 
	 * Default value: 2
	 */
	public void set_max_channel_saturation_power_of_half(byte val) {
		bindings.PaymentParameters_set_max_channel_saturation_power_of_half(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A list of SCIDs which this payment was previously attempted over and which caused the
	 * payment to fail. Future attempts for the same payment shouldn't be relayed through any of
	 * these SCIDs.
	 * 
	 * Returns a copy of the field.
	 */
	public long[] get_previously_failed_channels() {
		long ret = bindings.PaymentParameters_get_previously_failed_channels(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		long[] ret_conv = InternalUtils.decodeUint64Array(ret);
		return ret_conv;
	}

	/**
	 * A list of SCIDs which this payment was previously attempted over and which caused the
	 * payment to fail. Future attempts for the same payment shouldn't be relayed through any of
	 * these SCIDs.
	 */
	public void set_previously_failed_channels(long[] val) {
		bindings.PaymentParameters_set_previously_failed_channels(this.ptr, InternalUtils.encodeUint64Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A list of indices corresponding to blinded paths in [`Payee::Blinded::route_hints`] which this
	 * payment was previously attempted over and which caused the payment to fail. Future attempts
	 * for the same payment shouldn't be relayed through any of these blinded paths.
	 * 
	 * Returns a copy of the field.
	 */
	public long[] get_previously_failed_blinded_path_idxs() {
		long ret = bindings.PaymentParameters_get_previously_failed_blinded_path_idxs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		long[] ret_conv = InternalUtils.decodeUint64Array(ret);
		return ret_conv;
	}

	/**
	 * A list of indices corresponding to blinded paths in [`Payee::Blinded::route_hints`] which this
	 * payment was previously attempted over and which caused the payment to fail. Future attempts
	 * for the same payment shouldn't be relayed through any of these blinded paths.
	 */
	public void set_previously_failed_blinded_path_idxs(long[] val) {
		bindings.PaymentParameters_set_previously_failed_blinded_path_idxs(this.ptr, InternalUtils.encodeUint64Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PaymentParameters given each field
	 */
	public static PaymentParameters of(org.ldk.structs.Payee payee_arg, org.ldk.structs.Option_u64Z expiry_time_arg, int max_total_cltv_expiry_delta_arg, byte max_path_count_arg, byte max_path_length_arg, byte max_channel_saturation_power_of_half_arg, long[] previously_failed_channels_arg, long[] previously_failed_blinded_path_idxs_arg) {
		long ret = bindings.PaymentParameters_new(payee_arg.ptr, expiry_time_arg.ptr, max_total_cltv_expiry_delta_arg, max_path_count_arg, max_path_length_arg, max_channel_saturation_power_of_half_arg, InternalUtils.encodeUint64Array(previously_failed_channels_arg), InternalUtils.encodeUint64Array(previously_failed_blinded_path_idxs_arg));
		GC.KeepAlive(payee_arg);
		GC.KeepAlive(expiry_time_arg);
		GC.KeepAlive(max_total_cltv_expiry_delta_arg);
		GC.KeepAlive(max_path_count_arg);
		GC.KeepAlive(max_path_length_arg);
		GC.KeepAlive(max_channel_saturation_power_of_half_arg);
		GC.KeepAlive(previously_failed_channels_arg);
		GC.KeepAlive(previously_failed_blinded_path_idxs_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.PaymentParameters_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentParameters
	 */
	public PaymentParameters clone() {
		long ret = bindings.PaymentParameters_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the PaymentParameters.
	 */
	public long hash() {
		long ret = bindings.PaymentParameters_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two PaymentParameterss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.PaymentParameters b) {
		bool ret = bindings.PaymentParameters_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is PaymentParameters)) return false;
		return this.eq((PaymentParameters)o);
	}
	/**
	 * Serialize the PaymentParameters object into a byte array which can be read by PaymentParameters_read
	 */
	public byte[] write() {
		long ret = bindings.PaymentParameters_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a PaymentParameters from a byte array, created by PaymentParameters_write
	 */
	public static Result_PaymentParametersDecodeErrorZ read(byte[] ser, int arg) {
		long ret = bindings.PaymentParameters_read(InternalUtils.encodeUint8Array(ser), arg);
		GC.KeepAlive(ser);
		GC.KeepAlive(arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentParametersDecodeErrorZ ret_hu_conv = Result_PaymentParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a payee with the node id of the given `pubkey`.
	 * 
	 * The `final_cltv_expiry_delta` should match the expected final CLTV delta the recipient has
	 * provided.
	 */
	public static PaymentParameters from_node_id(byte[] payee_pubkey, int final_cltv_expiry_delta) {
		long ret = bindings.PaymentParameters_from_node_id(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payee_pubkey, 33)), final_cltv_expiry_delta);
		GC.KeepAlive(payee_pubkey);
		GC.KeepAlive(final_cltv_expiry_delta);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Creates a payee with the node id of the given `pubkey` to use for keysend payments.
	 * 
	 * The `final_cltv_expiry_delta` should match the expected final CLTV delta the recipient has
	 * provided.
	 * 
	 * Note that MPP keysend is not widely supported yet. The `allow_mpp` lets you choose
	 * whether your router will be allowed to find a multi-part route for this payment. If you
	 * set `allow_mpp` to true, you should ensure a payment secret is set on send, likely via
	 * [`RecipientOnionFields::secret_only`].
	 * 
	 * [`RecipientOnionFields::secret_only`]: crate::ln::channelmanager::RecipientOnionFields::secret_only
	 */
	public static PaymentParameters for_keysend(byte[] payee_pubkey, int final_cltv_expiry_delta, bool allow_mpp) {
		long ret = bindings.PaymentParameters_for_keysend(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payee_pubkey, 33)), final_cltv_expiry_delta, allow_mpp);
		GC.KeepAlive(payee_pubkey);
		GC.KeepAlive(final_cltv_expiry_delta);
		GC.KeepAlive(allow_mpp);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Creates parameters for paying to a blinded payee from the provided invoice. Sets
	 * [`Payee::Blinded::route_hints`], [`Payee::Blinded::features`], and
	 * [`PaymentParameters::expiry_time`].
	 */
	public static PaymentParameters from_bolt12_invoice(org.ldk.structs.Bolt12Invoice invoice) {
		long ret = bindings.PaymentParameters_from_bolt12_invoice(invoice.ptr);
		GC.KeepAlive(invoice);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(invoice); };
		return ret_hu_conv;
	}

	/**
	 * Creates parameters for paying to a blinded payee from the provided blinded route hints.
	 */
	public static PaymentParameters blinded(BlindedPaymentPath[] blinded_route_hints) {
		long ret = bindings.PaymentParameters_blinded(InternalUtils.encodeUint64Array(InternalUtils.mapArray(blinded_route_hints, blinded_route_hints_conv_20 => blinded_route_hints_conv_20.ptr)));
		GC.KeepAlive(blinded_route_hints);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
