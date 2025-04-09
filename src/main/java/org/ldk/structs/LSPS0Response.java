package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An bLIP-50 / LSPS0 protocol request.
 * 
 * Please refer to the [bLIP-50 / LSPS0
 * specification](https://github.com/lightning/blips/blob/master/blip-0050.md#lsps-specification-support-query)
 * for more information.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS0Response extends CommonBase {
	private LSPS0Response(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS0Response_free(ptr); }
	}
	static LSPS0Response constr_from_ptr(long ptr) {
		bindings.LDKLSPS0Response raw_val = bindings.LDKLSPS0Response_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS0Response.ListProtocols.class) {
			return new ListProtocols(ptr, (bindings.LDKLSPS0Response.ListProtocols)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPS0Response.ListProtocolsError.class) {
			return new ListProtocolsError(ptr, (bindings.LDKLSPS0Response.ListProtocolsError)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A response to a `list_protocols` request.
	 */
	public final static class ListProtocols extends LSPS0Response {
		public final org.ldk.structs.LSPS0ListProtocolsResponse list_protocols;
		private ListProtocols(long ptr, bindings.LDKLSPS0Response.ListProtocols obj) {
			super(null, ptr);
			long list_protocols = obj.list_protocols;
			org.ldk.structs.LSPS0ListProtocolsResponse list_protocols_hu_conv = null; if (list_protocols < 0 || list_protocols > 4096) { list_protocols_hu_conv = new org.ldk.structs.LSPS0ListProtocolsResponse(null, list_protocols); }
			if (list_protocols_hu_conv != null) { list_protocols_hu_conv.ptrs_to.add(this); };
			this.list_protocols = list_protocols_hu_conv;
		}
	}
	/**
	 * An error response to a `list_protocols` request.
	 */
	public final static class ListProtocolsError extends LSPS0Response {
		public final org.ldk.structs.LSPSResponseError list_protocols_error;
		private ListProtocolsError(long ptr, bindings.LDKLSPS0Response.ListProtocolsError obj) {
			super(null, ptr);
			long list_protocols_error = obj.list_protocols_error;
			org.ldk.structs.LSPSResponseError list_protocols_error_hu_conv = null; if (list_protocols_error < 0 || list_protocols_error > 4096) { list_protocols_error_hu_conv = new org.ldk.structs.LSPSResponseError(null, list_protocols_error); }
			if (list_protocols_error_hu_conv != null) { list_protocols_error_hu_conv.ptrs_to.add(this); };
			this.list_protocols_error = list_protocols_error_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS0Response_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0Response
	 */
	public LSPS0Response clone() {
		long ret = bindings.LSPS0Response_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Response ret_hu_conv = org.ldk.structs.LSPS0Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocols-variant LSPS0Response
	 */
	public static LSPS0Response list_protocols(org.ldk.structs.LSPS0ListProtocolsResponse a) {
		long ret = bindings.LSPS0Response_list_protocols(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Response ret_hu_conv = org.ldk.structs.LSPS0Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocolsError-variant LSPS0Response
	 */
	public static LSPS0Response list_protocols_error(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPS0Response_list_protocols_error(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Response ret_hu_conv = org.ldk.structs.LSPS0Response.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0Responses contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS0Response b) {
		boolean ret = bindings.LSPS0Response_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS0Response)) return false;
		return this.eq((LSPS0Response)o);
	}
}
