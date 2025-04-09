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
public class LSPS0Request : CommonBase {
	protected LSPS0Request(object _dummy, long ptr) : base(ptr) { }
	~LSPS0Request() {
		if (ptr != 0) { bindings.LSPS0Request_free(ptr); }
	}

	internal static LSPS0Request constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS0Request_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS0Request_ListProtocols(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS0Request of type ListProtocols */
	public class LSPS0Request_ListProtocols : LSPS0Request {
		public org.ldk.structs.LSPS0ListProtocolsRequest list_protocols;
		internal LSPS0Request_ListProtocols(long ptr) : base(null, ptr) {
			long list_protocols = bindings.LDKLSPS0Request_ListProtocols_get_list_protocols(ptr);
			org.ldk.structs.LSPS0ListProtocolsRequest list_protocols_hu_conv = null; if (list_protocols < 0 || list_protocols > 4096) { list_protocols_hu_conv = new org.ldk.structs.LSPS0ListProtocolsRequest(null, list_protocols); }
			if (list_protocols_hu_conv != null) { list_protocols_hu_conv.ptrs_to.AddLast(this); };
			this.list_protocols = list_protocols_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS0Request_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0Request
	 */
	public org.ldk.structs.LSPS0Request clone() {
		long ret = bindings.LSPS0Request_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Request ret_hu_conv = org.ldk.structs.LSPS0Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocols-variant LSPS0Request
	 */
	public static org.ldk.structs.LSPS0Request list_protocols(org.ldk.structs.LSPS0ListProtocolsRequest a) {
		long ret = bindings.LSPS0Request_list_protocols(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Request ret_hu_conv = org.ldk.structs.LSPS0Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0Requests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS0Request b) {
		bool ret = bindings.LSPS0Request_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS0Request)) return false;
		return this.eq((LSPS0Request)o);
	}
	/**
	 * Returns the method name associated with the given request variant.
	 */
	public string method() {
		long ret = bindings.LSPS0Request_method(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

}
} } }
