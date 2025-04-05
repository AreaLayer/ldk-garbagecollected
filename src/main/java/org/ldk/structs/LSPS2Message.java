package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum that captures all valid JSON-RPC messages in the bLIP-52 / LSPS2 protocol.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS2Message extends CommonBase {
	private LSPS2Message(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS2Message_free(ptr); }
	}
	static LSPS2Message constr_from_ptr(long ptr) {
		bindings.LDKLSPS2Message raw_val = bindings.LDKLSPS2Message_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS2Message.Request.class) {
			return new Request(ptr, (bindings.LDKLSPS2Message.Request)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS2Message.Response.class) {
			return new Response(ptr, (bindings.LDKLSPS2Message.Response)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * An LSPS2 JSON-RPC request.
	 */
	public final static class Request extends LSPS2Message {
		public final org.ldk.structs.LSPSRequestId _0;
		public final org.ldk.structs.LSPS2Request _1;
		private Request(long ptr, bindings.LDKLSPS2Message.Request obj) {
			super(null, ptr);
			long _0 = obj._0;
			org.ldk.structs.LSPSRequestId _0_hu_conv = null; if (_0 < 0 || _0 > 4096) { _0_hu_conv = new org.ldk.structs.LSPSRequestId(null, _0); }
			if (_0_hu_conv != null) { _0_hu_conv.ptrs_to.add(this); };
			this._0 = _0_hu_conv;
			long _1 = obj._1;
			org.ldk.structs.LSPS2Request _1_hu_conv = org.ldk.structs.LSPS2Request.constr_from_ptr(_1);
			if (_1_hu_conv != null) { _1_hu_conv.ptrs_to.add(this); };
			this._1 = _1_hu_conv;
		}
	}
	/**
	 * An LSPS2 JSON-RPC response.
	 */
	public final static class Response extends LSPS2Message {
		public final org.ldk.structs.LSPSRequestId _0;
		public final org.ldk.structs.LSPS2Response _1;
		private Response(long ptr, bindings.LDKLSPS2Message.Response obj) {
			super(null, ptr);
			long _0 = obj._0;
			org.ldk.structs.LSPSRequestId _0_hu_conv = null; if (_0 < 0 || _0 > 4096) { _0_hu_conv = new org.ldk.structs.LSPSRequestId(null, _0); }
			if (_0_hu_conv != null) { _0_hu_conv.ptrs_to.add(this); };
			this._0 = _0_hu_conv;
			long _1 = obj._1;
			org.ldk.structs.LSPS2Response _1_hu_conv = org.ldk.structs.LSPS2Response.constr_from_ptr(_1);
			if (_1_hu_conv != null) { _1_hu_conv.ptrs_to.add(this); };
			this._1 = _1_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS2Message_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS2Message
	 */
	public LSPS2Message clone() {
		long ret = bindings.LSPS2Message_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Message ret_hu_conv = org.ldk.structs.LSPS2Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Request-variant LSPS2Message
	 */
	public static LSPS2Message request(org.ldk.structs.LSPSRequestId a, org.ldk.structs.LSPS2Request b) {
		long ret = bindings.LSPS2Message_request(a.ptr, b.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Message ret_hu_conv = org.ldk.structs.LSPS2Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Response-variant LSPS2Message
	 */
	public static LSPS2Message response(org.ldk.structs.LSPSRequestId a, org.ldk.structs.LSPS2Response b) {
		long ret = bindings.LSPS2Message_response(a.ptr, b.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS2Message ret_hu_conv = org.ldk.structs.LSPS2Message.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS2Messages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS2Message b) {
		boolean ret = bindings.LSPS2Message_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS2Message)) return false;
		return this.eq((LSPS2Message)o);
	}
}
