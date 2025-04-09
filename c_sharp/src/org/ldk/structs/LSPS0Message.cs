using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An bLIP-50 / LSPS0 protocol message.
 * 
 * Please refer to the [bLIP-50 / LSPS0
 * specification](https://github.com/lightning/blips/blob/master/blip-0050.md#lsps-specification-support-query)
 * for more information.
 */
public class LSPS0Message : CommonBase {
	protected LSPS0Message(object _dummy, long ptr) : base(ptr) { }
	~LSPS0Message() {
		if (ptr != 0) { bindings.LSPS0Message_free(ptr); }
	}

	internal static LSPS0Message constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS0Message_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS0Message_Request(ptr);
			case 1: return new LSPS0Message_Response(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS0Message of type Request */
	public class LSPS0Message_Request : LSPS0Message {
		public org.ldk.structs.LSPSRequestId _0;
		public org.ldk.structs.LSPS0Request _1;
		internal LSPS0Message_Request(long ptr) : base(null, ptr) {
			long _0 = bindings.LDKLSPS0Message_Request_get__0(ptr);
			org.ldk.structs.LSPSRequestId _0_hu_conv = null; if (_0 < 0 || _0 > 4096) { _0_hu_conv = new org.ldk.structs.LSPSRequestId(null, _0); }
			if (_0_hu_conv != null) { _0_hu_conv.ptrs_to.AddLast(this); };
			this._0 = _0_hu_conv;
			long _1 = bindings.LDKLSPS0Message_Request_get__1(ptr);
			org.ldk.structs.LSPS0Request _1_hu_conv = org.ldk.structs.LSPS0Request.constr_from_ptr(_1);
			if (_1_hu_conv != null) { _1_hu_conv.ptrs_to.AddLast(this); };
			this._1 = _1_hu_conv;
		}
	}
	/** A LSPS0Message of type Response */
	public class LSPS0Message_Response : LSPS0Message {
		public org.ldk.structs.LSPSRequestId _0;
		public org.ldk.structs.LSPS0Response _1;
		internal LSPS0Message_Response(long ptr) : base(null, ptr) {
			long _0 = bindings.LDKLSPS0Message_Response_get__0(ptr);
			org.ldk.structs.LSPSRequestId _0_hu_conv = null; if (_0 < 0 || _0 > 4096) { _0_hu_conv = new org.ldk.structs.LSPSRequestId(null, _0); }
			if (_0_hu_conv != null) { _0_hu_conv.ptrs_to.AddLast(this); };
			this._0 = _0_hu_conv;
			long _1 = bindings.LDKLSPS0Message_Response_get__1(ptr);
			org.ldk.structs.LSPS0Response _1_hu_conv = org.ldk.structs.LSPS0Response.constr_from_ptr(_1);
			if (_1_hu_conv != null) { _1_hu_conv.ptrs_to.AddLast(this); };
			this._1 = _1_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS0Message_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0Message
	 */
	public org.ldk.structs.LSPS0Message clone() {
		long ret = bindings.LSPS0Message_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Message ret_hu_conv = org.ldk.structs.LSPS0Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Request-variant LSPS0Message
	 */
	public static org.ldk.structs.LSPS0Message request(org.ldk.structs.LSPSRequestId a, org.ldk.structs.LSPS0Request b) {
		long ret = bindings.LSPS0Message_request(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Message ret_hu_conv = org.ldk.structs.LSPS0Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Response-variant LSPS0Message
	 */
	public static org.ldk.structs.LSPS0Message response(org.ldk.structs.LSPSRequestId a, org.ldk.structs.LSPS0Response b) {
		long ret = bindings.LSPS0Message_response(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Message ret_hu_conv = org.ldk.structs.LSPS0Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0Messages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS0Message b) {
		bool ret = bindings.LSPS0Message_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS0Message)) return false;
		return this.eq((LSPS0Message)o);
	}
}
} } }
