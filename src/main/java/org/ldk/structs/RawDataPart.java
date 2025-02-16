package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Data of the [`RawBolt11Invoice`] that is encoded in the data part
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class RawDataPart extends CommonBase {
	RawDataPart(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.RawDataPart_free(ptr); }
	}

	/**
	 * generation time of the invoice
	 */
	public PositiveTimestamp get_timestamp() {
		long ret = bindings.RawDataPart_get_timestamp(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PositiveTimestamp ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PositiveTimestamp(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * generation time of the invoice
	 */
	public void set_timestamp(org.ldk.structs.PositiveTimestamp val) {
		bindings.RawDataPart_set_timestamp(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Checks if two RawDataParts contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.RawDataPart b) {
		boolean ret = bindings.RawDataPart_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof RawDataPart)) return false;
		return this.eq((RawDataPart)o);
	}
	long clone_ptr() {
		long ret = bindings.RawDataPart_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the RawDataPart
	 */
	public RawDataPart clone() {
		long ret = bindings.RawDataPart_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RawDataPart ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RawDataPart(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the RawDataPart.
	 */
	public long hash() {
		long ret = bindings.RawDataPart_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
}
