using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Features used within a `channel_announcement` message.
 */
public class ChannelFeatures : CommonBase {
	internal ChannelFeatures(object _dummy, long ptr) : base(ptr) { }
	~ChannelFeatures() {
		if (ptr != 0) { bindings.ChannelFeatures_free(ptr); }
	}

	/**
	 * Serialize the ChannelFeatures object into a byte array which can be read by ChannelFeatures_read
	 */
	public byte[] write() {
		long ret = bindings.ChannelFeatures_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelFeatures from a byte array, created by ChannelFeatures_write
	 */
	public static Result_ChannelFeaturesDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelFeatures_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelFeaturesDecodeErrorZ ret_hu_conv = Result_ChannelFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if two ChannelFeaturess contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelFeatures b) {
		bool ret = bindings.ChannelFeatures_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelFeatures)) return false;
		return this.eq((ChannelFeatures)o);
	}
	internal long clone_ptr() {
		long ret = bindings.ChannelFeatures_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelFeatures
	 */
	public ChannelFeatures clone() {
		long ret = bindings.ChannelFeatures_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelFeatures.
	 */
	public long hash() {
		long ret = bindings.ChannelFeatures_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Create a blank Features with no features set
	 */
	public static ChannelFeatures empty() {
		long ret = bindings.ChannelFeatures_empty();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Returns the feature set as a list of bytes, in little-endian. This is in reverse byte order
	 * from most on-the-wire encodings.
	 */
	public byte[] le_flags() {
		long ret = bindings.ChannelFeatures_le_flags(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Returns true if this `Features` has any optional flags set
	 */
	public bool supports_any_optional_bits() {
		bool ret = bindings.ChannelFeatures_supports_any_optional_bits(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Returns true if this `Features` object contains required features unknown by `other`.
	 */
	public bool requires_unknown_bits_from(org.ldk.structs.ChannelFeatures other) {
		bool ret = bindings.ChannelFeatures_requires_unknown_bits_from(this.ptr, other.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(other);
		if (this != null) { this.ptrs_to.AddLast(other); };
		return ret;
	}

	/**
	 * Returns the set of required features unknown by `other`, as their bit position.
	 */
	public long[] required_unknown_bits_from(org.ldk.structs.ChannelFeatures other) {
		long ret = bindings.ChannelFeatures_required_unknown_bits_from(this.ptr, other.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(other);
		if (ret >= 0 && ret <= 4096) { return null; }
		long[] ret_conv = InternalUtils.decodeUint64Array(ret);
		if (this != null) { this.ptrs_to.AddLast(other); };
		return ret_conv;
	}

	/**
	 * Returns true if this `Features` object contains unknown feature flags which are set as
	 * \"required\".
	 */
	public bool requires_unknown_bits() {
		bool ret = bindings.ChannelFeatures_requires_unknown_bits(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Returns true if this `Features` supports any bits which we do not know of
	 */
	public bool supports_unknown_bits() {
		bool ret = bindings.ChannelFeatures_supports_unknown_bits(this.ptr);
		GC.KeepAlive(this);
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
		long ret = bindings.ChannelFeatures_set_required_feature_bit(this.ptr, bit);
		GC.KeepAlive(this);
		GC.KeepAlive(bit);
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
		long ret = bindings.ChannelFeatures_set_optional_feature_bit(this.ptr, bit);
		GC.KeepAlive(this);
		GC.KeepAlive(bit);
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
		long ret = bindings.ChannelFeatures_set_required_custom_bit(this.ptr, bit);
		GC.KeepAlive(this);
		GC.KeepAlive(bit);
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
		long ret = bindings.ChannelFeatures_set_optional_custom_bit(this.ptr, bit);
		GC.KeepAlive(this);
		GC.KeepAlive(bit);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
