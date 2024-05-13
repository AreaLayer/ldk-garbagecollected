using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An unknown payment context.
 */
public class UnknownPaymentContext : CommonBase {
	internal UnknownPaymentContext(object _dummy, long ptr) : base(ptr) { }
	~UnknownPaymentContext() {
		if (ptr != 0) { bindings.UnknownPaymentContext_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.UnknownPaymentContext_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UnknownPaymentContext
	 */
	public UnknownPaymentContext clone() {
		long ret = bindings.UnknownPaymentContext_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnknownPaymentContext ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnknownPaymentContext(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two UnknownPaymentContexts contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UnknownPaymentContext b) {
		bool ret = bindings.UnknownPaymentContext_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UnknownPaymentContext)) return false;
		return this.eq((UnknownPaymentContext)o);
	}
	/**
	 * Serialize the UnknownPaymentContext object into a byte array which can be read by UnknownPaymentContext_read
	 */
	public byte[] write() {
		long ret = bindings.UnknownPaymentContext_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a UnknownPaymentContext from a byte array, created by UnknownPaymentContext_write
	 */
	public static Result_UnknownPaymentContextDecodeErrorZ read(byte[] ser) {
		long ret = bindings.UnknownPaymentContext_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnknownPaymentContextDecodeErrorZ ret_hu_conv = Result_UnknownPaymentContextDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
