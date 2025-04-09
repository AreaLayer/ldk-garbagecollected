package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A newtype that holds a `short_channel_id` in human readable format of BBBxTTTx000.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2InterceptScid extends CommonBase {
	LSPS2InterceptScid(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2InterceptScid_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.LSPS2InterceptScid_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2InterceptScid
	 */
	public LSPS2InterceptScid clone() {
		long ret = bindings.LSPS2InterceptScid_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2InterceptScid ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2InterceptScid(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2InterceptScids contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS2InterceptScid b) {
		boolean ret = bindings.LSPS2InterceptScid_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2InterceptScid)) return false;
		return this.eq((LSPS2InterceptScid)o);
	}
	/**
	 * Try to convert a [`LSPS2InterceptScid`] into a u64 used by LDK.
	 */
	public Result_u64NoneZ to_scid() {
		long ret = bindings.LSPS2InterceptScid_to_scid(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
