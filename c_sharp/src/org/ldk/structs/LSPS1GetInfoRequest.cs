using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A request made to an LSP to retrieve the supported options.
 * 
 * Please refer to the [bLIP-51 / LSPS1
 * specification](https://github.com/lightning/blips/blob/master/blip-0051.md#1-lsps1get_info) for
 * more information.
 */
public class LSPS1GetInfoRequest : CommonBase {
	internal LSPS1GetInfoRequest(object _dummy, long ptr) : base(ptr) { }
	~LSPS1GetInfoRequest() {
		if (ptr != 0) { bindings.LSPS1GetInfoRequest_free(ptr); }
	}

	/**
	 * Constructs a new LSPS1GetInfoRequest given each field
	 */
	public static org.ldk.structs.LSPS1GetInfoRequest of() {
		long ret = bindings.LSPS1GetInfoRequest_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1GetInfoRequest_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1GetInfoRequest
	 */
	public org.ldk.structs.LSPS1GetInfoRequest clone() {
		long ret = bindings.LSPS1GetInfoRequest_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1GetInfoRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1GetInfoRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1GetInfoRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1GetInfoRequest b) {
		bool ret = bindings.LSPS1GetInfoRequest_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1GetInfoRequest)) return false;
		return this.eq((LSPS1GetInfoRequest)o);
	}
}
} } }
