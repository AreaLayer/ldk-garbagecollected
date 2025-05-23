package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * BOLT 4 onion packet including hop data for the next peer.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class OnionPacket extends CommonBase {
	OnionPacket(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.OnionPacket_free(ptr); }
	}

	/**
	 * BOLT 4 version number.
	 */
	public byte get_version() {
		byte ret = bindings.OnionPacket_get_version(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * BOLT 4 version number.
	 */
	public void set_version(byte val) {
		bindings.OnionPacket_set_version(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * In order to ensure we always return an error on onion decode in compliance with [BOLT
	 * #4](https://github.com/lightning/bolts/blob/master/04-onion-routing.md), we have to
	 * deserialize `OnionPacket`s contained in [`UpdateAddHTLC`] messages even if the ephemeral
	 * public key (here) is bogus, so we hold a [`Result`] instead of a [`PublicKey`] as we'd
	 * like.
	 * 
	 * Returns a copy of the field.
	 */
	public Result_PublicKeySecp256k1ErrorZ get_public_key() {
		long ret = bindings.OnionPacket_get_public_key(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeySecp256k1ErrorZ ret_hu_conv = Result_PublicKeySecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * In order to ensure we always return an error on onion decode in compliance with [BOLT
	 * #4](https://github.com/lightning/bolts/blob/master/04-onion-routing.md), we have to
	 * deserialize `OnionPacket`s contained in [`UpdateAddHTLC`] messages even if the ephemeral
	 * public key (here) is bogus, so we hold a [`Result`] instead of a [`PublicKey`] as we'd
	 * like.
	 */
	public void set_public_key(org.ldk.structs.Result_PublicKeySecp256k1ErrorZ val) {
		bindings.OnionPacket_set_public_key(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * HMAC to verify the integrity of hop_data.
	 */
	public byte[] get_hmac() {
		byte[] ret = bindings.OnionPacket_get_hmac(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * HMAC to verify the integrity of hop_data.
	 */
	public void set_hmac(byte[] val) {
		bindings.OnionPacket_set_hmac(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	long clone_ptr() {
		long ret = bindings.OnionPacket_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the OnionPacket
	 */
	public OnionPacket clone() {
		long ret = bindings.OnionPacket_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OnionPacket ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OnionPacket(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the OnionPacket.
	 */
	public long hash() {
		long ret = bindings.OnionPacket_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two OnionPackets contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.OnionPacket b) {
		boolean ret = bindings.OnionPacket_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof OnionPacket)) return false;
		return this.eq((OnionPacket)o);
	}
	/**
	 * Serialize the OnionPacket object into a byte array which can be read by OnionPacket_read
	 */
	public byte[] write() {
		byte[] ret = bindings.OnionPacket_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a OnionPacket from a byte array, created by OnionPacket_write
	 */
	public static Result_OnionPacketDecodeErrorZ read(byte[] ser) {
		long ret = bindings.OnionPacket_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OnionPacketDecodeErrorZ ret_hu_conv = Result_OnionPacketDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
