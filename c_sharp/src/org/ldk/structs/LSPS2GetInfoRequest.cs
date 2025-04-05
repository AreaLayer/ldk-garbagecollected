using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A request made to an LSP to learn their current channel fees and parameters.
 */
public class LSPS2GetInfoRequest : CommonBase {
	internal LSPS2GetInfoRequest(object _dummy, long ptr) : base(ptr) { }
	~LSPS2GetInfoRequest() {
		if (ptr != 0) { bindings.LSPS2GetInfoRequest_free(ptr); }
	}

	/**
	 * An optional token to provide to the LSP.
	 */
	public org.ldk.structs.Option_StrZ get_token() {
		long ret = bindings.LSPS2GetInfoRequest_get_token(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An optional token to provide to the LSP.
	 */
	public void set_token(org.ldk.structs.Option_StrZ val) {
		bindings.LSPS2GetInfoRequest_set_token(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS2GetInfoRequest given each field
	 */
	public static org.ldk.structs.LSPS2GetInfoRequest of(org.ldk.structs.Option_StrZ token_arg) {
		long ret = bindings.LSPS2GetInfoRequest_new(token_arg.ptr);
		GC.KeepAlive(token_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS2GetInfoRequest_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2GetInfoRequest
	 */
	public org.ldk.structs.LSPS2GetInfoRequest clone() {
		long ret = bindings.LSPS2GetInfoRequest_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS2GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2GetInfoRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS2GetInfoRequest b) {
		bool ret = bindings.LSPS2GetInfoRequest_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2GetInfoRequest)) return false;
		return this.eq((LSPS2GetInfoRequest)o);
	}
}
} } }
