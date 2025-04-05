using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An bLIP-50 / LSPS0 protocol request.
 * 
 * Please refer to the [bLIP-50 / LSPS0
 * specification](https://github.com/lightning/blips/blob/master/blip-0050.md#lsps-specification-support-query)
 * for more information.
 */
public class LSPS0Response : CommonBase {
	protected LSPS0Response(object _dummy, long ptr) : base(ptr) { }
	~LSPS0Response() {
		if (ptr != 0) { bindings.LSPS0Response_free(ptr); }
	}

	internal static LSPS0Response constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS0Response_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS0Response_ListProtocols(ptr);
			case 1: return new LSPS0Response_ListProtocolsError(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS0Response of type ListProtocols */
	public class LSPS0Response_ListProtocols : LSPS0Response {
		public org.ldk.structs.LSPS0ListProtocolsResponse list_protocols;
		internal LSPS0Response_ListProtocols(long ptr) : base(null, ptr) {
			long list_protocols = bindings.LDKLSPS0Response_ListProtocols_get_list_protocols(ptr);
			org.ldk.structs.LSPS0ListProtocolsResponse list_protocols_hu_conv = null; if (list_protocols < 0 || list_protocols > 4096) { list_protocols_hu_conv = new org.ldk.structs.LSPS0ListProtocolsResponse(null, list_protocols); }
			if (list_protocols_hu_conv != null) { list_protocols_hu_conv.ptrs_to.AddLast(this); };
			this.list_protocols = list_protocols_hu_conv;
		}
	}
	/** A LSPS0Response of type ListProtocolsError */
	public class LSPS0Response_ListProtocolsError : LSPS0Response {
		public org.ldk.structs.LSPSResponseError list_protocols_error;
		internal LSPS0Response_ListProtocolsError(long ptr) : base(null, ptr) {
			long list_protocols_error = bindings.LDKLSPS0Response_ListProtocolsError_get_list_protocols_error(ptr);
			org.ldk.structs.LSPSResponseError list_protocols_error_hu_conv = null; if (list_protocols_error < 0 || list_protocols_error > 4096) { list_protocols_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, list_protocols_error); }
			if (list_protocols_error_hu_conv != null) { list_protocols_error_hu_conv.ptrs_to.AddLast(this); };
			this.list_protocols_error = list_protocols_error_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS0Response_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0Response
	 */
	public org.ldk.structs.LSPS0Response clone() {
		long ret = bindings.LSPS0Response_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Response ret_hu_conv = org.ldk.structs.LSPS0Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocols-variant LSPS0Response
	 */
	public static org.ldk.structs.LSPS0Response list_protocols(org.ldk.structs.LSPS0ListProtocolsResponse a) {
		long ret = bindings.LSPS0Response_list_protocols(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Response ret_hu_conv = org.ldk.structs.LSPS0Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocolsError-variant LSPS0Response
	 */
	public static org.ldk.structs.LSPS0Response list_protocols_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS0Response_list_protocols_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Response ret_hu_conv = org.ldk.structs.LSPS0Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0Responses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS0Response b) {
		bool ret = bindings.LSPS0Response_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS0Response)) return false;
		return this.eq((LSPS0Response)o);
	}
}
} } }
