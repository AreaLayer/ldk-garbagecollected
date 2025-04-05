using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A `list_protocols` request.
 * 
 * Please refer to the [bLIP-50 / LSPS0
 * specification](https://github.com/lightning/blips/blob/master/blip-0050.md#lsps-specification-support-query)
 * for more information.
 */
public class LSPS0ListProtocolsRequest : CommonBase {
	internal LSPS0ListProtocolsRequest(object _dummy, long ptr) : base(ptr) { }
	~LSPS0ListProtocolsRequest() {
		if (ptr != 0) { bindings.LSPS0ListProtocolsRequest_free(ptr); }
	}

	/**
	 * Constructs a new LSPS0ListProtocolsRequest given each field
	 */
	public static org.ldk.structs.LSPS0ListProtocolsRequest of() {
		long ret = bindings.LSPS0ListProtocolsRequest_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ListProtocolsRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS0ListProtocolsRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS0ListProtocolsRequest_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0ListProtocolsRequest
	 */
	public org.ldk.structs.LSPS0ListProtocolsRequest clone() {
		long ret = bindings.LSPS0ListProtocolsRequest_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ListProtocolsRequest ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS0ListProtocolsRequest(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0ListProtocolsRequests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS0ListProtocolsRequest b) {
		bool ret = bindings.LSPS0ListProtocolsRequest_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS0ListProtocolsRequest)) return false;
		return this.eq((LSPS0ListProtocolsRequest)o);
	}
}
} } }
