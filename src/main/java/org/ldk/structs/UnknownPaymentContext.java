package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An unknown payment context.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class UnknownPaymentContext extends CommonBase {
	UnknownPaymentContext(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.UnknownPaymentContext_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.UnknownPaymentContext_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the UnknownPaymentContext
	 */
	public UnknownPaymentContext clone() {
		long ret = bindings.UnknownPaymentContext_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnknownPaymentContext ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnknownPaymentContext(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two UnknownPaymentContexts contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.UnknownPaymentContext b) {
		boolean ret = bindings.UnknownPaymentContext_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof UnknownPaymentContext)) return false;
		return this.eq((UnknownPaymentContext)o);
	}
	/**
	 * Serialize the UnknownPaymentContext object into a byte array which can be read by UnknownPaymentContext_read
	 */
	public byte[] write() {
		byte[] ret = bindings.UnknownPaymentContext_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a UnknownPaymentContext from a byte array, created by UnknownPaymentContext_write
	 */
	public static Result_UnknownPaymentContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.UnknownPaymentContext_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnknownPaymentContextDecodeErrorZ ret_hu_conv = Result_UnknownPaymentContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
