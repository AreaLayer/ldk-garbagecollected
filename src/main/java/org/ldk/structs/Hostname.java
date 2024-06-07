package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Represents a hostname for serialization purposes.
 * Only the character set and length will be validated.
 * The character set consists of ASCII alphanumeric characters, hyphens, and periods.
 * Its length is guaranteed to be representable by a single byte.
 * This serialization is used by [`BOLT 7`] hostnames.
 * 
 * [`BOLT 7`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Hostname extends CommonBase {
	Hostname(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Hostname_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.Hostname_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Hostname
	 */
	public Hostname clone() {
		long ret = bindings.Hostname_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Hostname ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Hostname(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Hostname.
	 */
	public long hash() {
		long ret = bindings.Hostname_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Hostnames contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.Hostname b) {
		boolean ret = bindings.Hostname_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof Hostname)) return false;
		return this.eq((Hostname)o);
	}
	/**
	 * Returns the length of the hostname.
	 */
	public byte len() {
		byte ret = bindings.Hostname_len(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Get the string representation of a Hostname object
	 */
	public String to_str() {
		String ret = bindings.Hostname_to_str(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Serialize the Hostname object into a byte array which can be read by Hostname_read
	 */
	public byte[] write() {
		byte[] ret = bindings.Hostname_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a Hostname from a byte array, created by Hostname_write
	 */
	public static Result_HostnameDecodeErrorZ read(byte[] ser) {
		long ret = bindings.Hostname_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HostnameDecodeErrorZ ret_hu_conv = Result_HostnameDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
