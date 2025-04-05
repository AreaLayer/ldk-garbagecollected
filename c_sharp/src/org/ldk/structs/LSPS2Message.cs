using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum that captures all valid JSON-RPC messages in the bLIP-52 / LSPS2 protocol.
 */
public class LSPS2Message : CommonBase {
	protected LSPS2Message(object _dummy, long ptr) : base(ptr) { }
	~LSPS2Message() {
		if (ptr != 0) { bindings.LSPS2Message_free(ptr); }
	}

	internal static LSPS2Message constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS2Message_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS2Message_Request(ptr);
			case 1: return new LSPS2Message_Response(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS2Message of type Request */
	public class LSPS2Message_Request : LSPS2Message {
		public org.ldk.structs.LSPSRequestId _0;
		public org.ldk.structs.LSPS2Request _1;
		internal LSPS2Message_Request(long ptr) : base(null, ptr) {
			long _0 = bindings.LDKLSPS2Message_Request_get__0(ptr);
			org.ldk.structs.LSPSRequestId _0_hu_conv = null; if (_0 < 0 || _0 > 4096) { _0_hu_conv = new org.ldk.structs.LSPSRequestId(null, _0); }
			if (_0_hu_conv != null) { _0_hu_conv.ptrs_to.AddLast(this); };
			this._0 = _0_hu_conv;
			long _1 = bindings.LDKLSPS2Message_Request_get__1(ptr);
			org.ldk.structs.LSPS2Request _1_hu_conv = org.ldk.structs.LSPS2Request.constr_from_ptr(_1);
			if (_1_hu_conv != null) { _1_hu_conv.ptrs_to.AddLast(this); };
			this._1 = _1_hu_conv;
		}
	}
	/** A LSPS2Message of type Response */
	public class LSPS2Message_Response : LSPS2Message {
		public org.ldk.structs.LSPSRequestId _0;
		public org.ldk.structs.LSPS2Response _1;
		internal LSPS2Message_Response(long ptr) : base(null, ptr) {
			long _0 = bindings.LDKLSPS2Message_Response_get__0(ptr);
			org.ldk.structs.LSPSRequestId _0_hu_conv = null; if (_0 < 0 || _0 > 4096) { _0_hu_conv = new org.ldk.structs.LSPSRequestId(null, _0); }
			if (_0_hu_conv != null) { _0_hu_conv.ptrs_to.AddLast(this); };
			this._0 = _0_hu_conv;
			long _1 = bindings.LDKLSPS2Message_Response_get__1(ptr);
			org.ldk.structs.LSPS2Response _1_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(_1);
			if (_1_hu_conv != null) { _1_hu_conv.ptrs_to.AddLast(this); };
			this._1 = _1_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS2Message_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2Message
	 */
	public org.ldk.structs.LSPS2Message clone() {
		long ret = bindings.LSPS2Message_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Message ret_hu_conv = org.ldk.structs.LSPS2Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Request-variant LSPS2Message
	 */
	public static org.ldk.structs.LSPS2Message request(org.ldk.structs.LSPSRequestId a, org.ldk.structs.LSPS2Request b) {
		long ret = bindings.LSPS2Message_request(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Message ret_hu_conv = org.ldk.structs.LSPS2Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Response-variant LSPS2Message
	 */
	public static org.ldk.structs.LSPS2Message response(org.ldk.structs.LSPSRequestId a, org.ldk.structs.LSPS2Response b) {
		long ret = bindings.LSPS2Message_response(a.ptr, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Message ret_hu_conv = org.ldk.structs.LSPS2Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2Messages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS2Message b) {
		bool ret = bindings.LSPS2Message_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS2Message)) return false;
		return this.eq((LSPS2Message)o);
	}
}
} } }
