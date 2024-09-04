package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Features used within the channel_type field in an OpenChannel message.
 * 
 * A channel is always of some known \"type\", describing the transaction formats used and the exact
 * semantics of our interaction with our peer.
 * 
 * Note that because a channel is a specific type which is proposed by the opener and accepted by
 * the counterparty, only required features are allowed here.
 * 
 * This is serialized differently from other feature types - it is not prefixed by a length, and
 * thus must only appear inside a TLV where its length is known in advance.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ChannelTypeFeatures extends CommonBase {
	ChannelTypeFeatures(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ChannelTypeFeatures_free(ptr); }
	}

	/**
	 * Serialize the ChannelTypeFeatures object into a byte array which can be read by ChannelTypeFeatures_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelTypeFeatures_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a ChannelTypeFeatures from a byte array, created by ChannelTypeFeatures_write
	 */
	public static Result_ChannelTypeFeaturesDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelTypeFeatures_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelTypeFeaturesDecodeErrorZ ret_hu_conv = Result_ChannelTypeFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if two ChannelTypeFeaturess contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.ChannelTypeFeatures b) {
		boolean ret = bindings.ChannelTypeFeatures_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof ChannelTypeFeatures)) return false;
		return this.eq((ChannelTypeFeatures)o);
	}
	long clone_ptr() {
		long ret = bindings.ChannelTypeFeatures_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelTypeFeatures
	 */
	public ChannelTypeFeatures clone() {
		long ret = bindings.ChannelTypeFeatures_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelTypeFeatures.
	 */
	public long hash() {
		long ret = bindings.ChannelTypeFeatures_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Constructs a ChannelTypeFeatures with only static_remotekey set
	 */
	public static ChannelTypeFeatures only_static_remote_key() {
		long ret = bindings.ChannelTypeFeatures_only_static_remote_key();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a ChannelTypeFeatures with anchors support
	 */
	public static ChannelTypeFeatures anchors_zero_htlc_fee_and_dependencies() {
		long ret = bindings.ChannelTypeFeatures_anchors_zero_htlc_fee_and_dependencies();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Create a blank Features with no features set
	 */
	public static ChannelTypeFeatures empty() {
		long ret = bindings.ChannelTypeFeatures_empty();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Returns the feature set as a list of bytes, in little-endian. This is in reverse byte order
	 * from most on-the-wire encodings.
	 */
	public byte[] le_flags() {
		byte[] ret = bindings.ChannelTypeFeatures_le_flags(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Returns true if this `Features` has any optional flags set
	 */
	public boolean supports_any_optional_bits() {
		boolean ret = bindings.ChannelTypeFeatures_supports_any_optional_bits(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Returns true if this `Features` object contains required features unknown by `other`.
	 */
	public boolean requires_unknown_bits_from(org.ldk.structs.ChannelTypeFeatures other) {
		boolean ret = bindings.ChannelTypeFeatures_requires_unknown_bits_from(this.ptr, other.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(other);
		if (this != null) { this.ptrs_to.add(other); };
		return ret;
	}

	/**
	 * Returns the set of required features unknown by `other`, as their bit position.
	 */
	public long[] required_unknown_bits_from(org.ldk.structs.ChannelTypeFeatures other) {
		long[] ret = bindings.ChannelTypeFeatures_required_unknown_bits_from(this.ptr, other.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(other);
		if (this != null) { this.ptrs_to.add(other); };
		return ret;
	}

	/**
	 * Returns true if this `Features` object contains unknown feature flags which are set as
	 * \"required\".
	 */
	public boolean requires_unknown_bits() {
		boolean ret = bindings.ChannelTypeFeatures_requires_unknown_bits(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Returns true if this `Features` supports any bits which we do not know of
	 */
	public boolean supports_unknown_bits() {
		boolean ret = bindings.ChannelTypeFeatures_supports_unknown_bits(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Sets a required feature bit. Errors if `bit` is outside the feature range as defined
	 * by [BOLT 9].
	 * 
	 * Note: Required bits are even. If an odd bit is given, then the corresponding even bit will
	 * be set instead (i.e., `bit - 1`).
	 * 
	 * [BOLT 9]: https://github.com/lightning/bolts/blob/master/09-features.md
	 */
	public Result_NoneNoneZ set_required_feature_bit(long bit) {
		long ret = bindings.ChannelTypeFeatures_set_required_feature_bit(this.ptr, bit);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(bit);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Sets an optional feature bit. Errors if `bit` is outside the feature range as defined
	 * by [BOLT 9].
	 * 
	 * Note: Optional bits are odd. If an even bit is given, then the corresponding odd bit will be
	 * set instead (i.e., `bit + 1`).
	 * 
	 * [BOLT 9]: https://github.com/lightning/bolts/blob/master/09-features.md
	 */
	public Result_NoneNoneZ set_optional_feature_bit(long bit) {
		long ret = bindings.ChannelTypeFeatures_set_optional_feature_bit(this.ptr, bit);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(bit);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Sets a required custom feature bit. Errors if `bit` is outside the custom range as defined
	 * by [bLIP 2] or if it is a known `T` feature.
	 * 
	 * Note: Required bits are even. If an odd bit is given, then the corresponding even bit will
	 * be set instead (i.e., `bit - 1`).
	 * 
	 * [bLIP 2]: https://github.com/lightning/blips/blob/master/blip-0002.md#feature-bits
	 */
	public Result_NoneNoneZ set_required_custom_bit(long bit) {
		long ret = bindings.ChannelTypeFeatures_set_required_custom_bit(this.ptr, bit);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(bit);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Sets an optional custom feature bit. Errors if `bit` is outside the custom range as defined
	 * by [bLIP 2] or if it is a known `T` feature.
	 * 
	 * Note: Optional bits are odd. If an even bit is given, then the corresponding odd bit will be
	 * set instead (i.e., `bit + 1`).
	 * 
	 * [bLIP 2]: https://github.com/lightning/blips/blob/master/blip-0002.md#feature-bits
	 */
	public Result_NoneNoneZ set_optional_custom_bit(long bit) {
		long ret = bindings.ChannelTypeFeatures_set_optional_custom_bit(this.ptr, bit);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(bit);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Unsets the `scid_privacy` feature
	 */
	public void clear_scid_privacy() {
		bindings.ChannelTypeFeatures_clear_scid_privacy(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Unsets the `anchors_zero_fee_htlc_tx` feature
	 */
	public void clear_anchors_zero_fee_htlc_tx() {
		bindings.ChannelTypeFeatures_clear_anchors_zero_fee_htlc_tx(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_static_remote_key_optional() {
		bindings.ChannelTypeFeatures_set_static_remote_key_optional(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_static_remote_key_required() {
		bindings.ChannelTypeFeatures_set_static_remote_key_required(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public boolean supports_static_remote_key() {
		boolean ret = bindings.ChannelTypeFeatures_supports_static_remote_key(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public boolean requires_static_remote_key() {
		boolean ret = bindings.ChannelTypeFeatures_requires_static_remote_key(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_anchors_nonzero_fee_htlc_tx_optional() {
		bindings.ChannelTypeFeatures_set_anchors_nonzero_fee_htlc_tx_optional(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_anchors_nonzero_fee_htlc_tx_required() {
		bindings.ChannelTypeFeatures_set_anchors_nonzero_fee_htlc_tx_required(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public boolean supports_anchors_nonzero_fee_htlc_tx() {
		boolean ret = bindings.ChannelTypeFeatures_supports_anchors_nonzero_fee_htlc_tx(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public boolean requires_anchors_nonzero_fee_htlc_tx() {
		boolean ret = bindings.ChannelTypeFeatures_requires_anchors_nonzero_fee_htlc_tx(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_anchors_zero_fee_htlc_tx_optional() {
		bindings.ChannelTypeFeatures_set_anchors_zero_fee_htlc_tx_optional(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_anchors_zero_fee_htlc_tx_required() {
		bindings.ChannelTypeFeatures_set_anchors_zero_fee_htlc_tx_required(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public boolean supports_anchors_zero_fee_htlc_tx() {
		boolean ret = bindings.ChannelTypeFeatures_supports_anchors_zero_fee_htlc_tx(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public boolean requires_anchors_zero_fee_htlc_tx() {
		boolean ret = bindings.ChannelTypeFeatures_requires_anchors_zero_fee_htlc_tx(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_taproot_optional() {
		bindings.ChannelTypeFeatures_set_taproot_optional(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_taproot_required() {
		bindings.ChannelTypeFeatures_set_taproot_required(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public boolean supports_taproot() {
		boolean ret = bindings.ChannelTypeFeatures_supports_taproot(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public boolean requires_taproot() {
		boolean ret = bindings.ChannelTypeFeatures_requires_taproot(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_scid_privacy_optional() {
		bindings.ChannelTypeFeatures_set_scid_privacy_optional(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_scid_privacy_required() {
		bindings.ChannelTypeFeatures_set_scid_privacy_required(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public boolean supports_scid_privacy() {
		boolean ret = bindings.ChannelTypeFeatures_supports_scid_privacy(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public boolean requires_scid_privacy() {
		boolean ret = bindings.ChannelTypeFeatures_requires_scid_privacy(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_zero_conf_optional() {
		bindings.ChannelTypeFeatures_set_zero_conf_optional(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_zero_conf_required() {
		bindings.ChannelTypeFeatures_set_zero_conf_required(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public boolean supports_zero_conf() {
		boolean ret = bindings.ChannelTypeFeatures_supports_zero_conf(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public boolean requires_zero_conf() {
		boolean ret = bindings.ChannelTypeFeatures_requires_zero_conf(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
