using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A response to a `list_protocols` request.
 * 
 * Please refer to the [bLIP-50 / LSPS0
 * specification](https://github.com/lightning/blips/blob/master/blip-0050.md#lsps-specification-support-query)
 * for more information.
 */
public class LSPS0ListProtocolsResponse : CommonBase {
	internal LSPS0ListProtocolsResponse(object _dummy, long ptr) : base(ptr) { }
	~LSPS0ListProtocolsResponse() {
		if (ptr != 0) { bindings.LSPS0ListProtocolsResponse_free(ptr); }
	}

	/**
	 * A list of supported protocols.
	 * 
	 * Returns a copy of the field.
	 */
	public short[] get_protocols() {
		long ret = bindings.LSPS0ListProtocolsResponse_get_protocols(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		short[] ret_conv = InternalUtils.decodeUint16Array(ret);
		return ret_conv;
	}

	/**
	 * A list of supported protocols.
	 */
	public void set_protocols(short[] val) {
		bindings.LSPS0ListProtocolsResponse_set_protocols(this.ptr, InternalUtils.encodeUint16Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS0ListProtocolsResponse given each field
	 */
	public static org.ldk.structs.LSPS0ListProtocolsResponse of(short[] protocols_arg) {
		long ret = bindings.LSPS0ListProtocolsResponse_new(InternalUtils.encodeUint16Array(protocols_arg));
		GC.KeepAlive(protocols_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ListProtocolsResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS0ListProtocolsResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS0ListProtocolsResponse_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0ListProtocolsResponse
	 */
	public org.ldk.structs.LSPS0ListProtocolsResponse clone() {
		long ret = bindings.LSPS0ListProtocolsResponse_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ListProtocolsResponse ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS0ListProtocolsResponse(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0ListProtocolsResponses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS0ListProtocolsResponse b) {
		bool ret = bindings.LSPS0ListProtocolsResponse_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS0ListProtocolsResponse)) return false;
		return this.eq((LSPS0ListProtocolsResponse)o);
	}
}
} } }
