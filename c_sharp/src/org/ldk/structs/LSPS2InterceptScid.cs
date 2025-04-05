using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A newtype that holds a `short_channel_id` in human readable format of BBBxTTTx000.
 */
public class LSPS2InterceptScid : CommonBase {
	internal LSPS2InterceptScid(object _dummy, long ptr) : base(ptr) { }
	~LSPS2InterceptScid() {
		if (ptr != 0) { bindings.LSPS2InterceptScid_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2InterceptScid_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2InterceptScid
	 */
	public org.ldk.structs.LSPS2InterceptScid clone() {
		long ret = bindings.LSPS2InterceptScid_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2InterceptScid ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2InterceptScid(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2InterceptScids contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS2InterceptScid b) {
		bool ret = bindings.LSPS2InterceptScid_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2InterceptScid)) return false;
		return this.eq((LSPS2InterceptScid)o);
	}
	/**
	 * Try to convert a [`LSPS2InterceptScid`] into a u64 used by LDK.
	 */
	public org.ldk.structs.Result_u64NoneZ to_scid() {
		long ret = bindings.LSPS2InterceptScid_to_scid(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u64NoneZ ret_hu_conv = Result_u64NoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
