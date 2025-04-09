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
public class LSPS0Request extends CommonBase {
	private LSPS0Request(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS0Request_free(ptr); }
	}
	static LSPS0Request constr_from_ptr(long ptr) {
		bindings.LDKLSPS0Request raw_val = bindings.LDKLSPS0Request_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS0Request.ListProtocols.class) {
			return new ListProtocols(ptr, (bindings.LDKLSPS0Request.ListProtocols)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A request calling `list_protocols`.
	 */
	public final static class ListProtocols extends LSPS0Request {
		public final org.ldk.structs.LSPS0ListProtocolsRequest list_protocols;
		private ListProtocols(long ptr, bindings.LDKLSPS0Request.ListProtocols obj) {
			super(null, ptr);
			long list_protocols = obj.list_protocols;
			org.ldk.structs.LSPS0ListProtocolsRequest list_protocols_hu_conv = null; if (list_protocols < 0 || list_protocols > 4096) { list_protocols_hu_conv = new org.ldk.structs.LSPS0ListProtocolsRequest(null, list_protocols); }
			if (list_protocols_hu_conv != null) { list_protocols_hu_conv.ptrs_to.add(this); };
			this.list_protocols = list_protocols_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS0Request_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0Request
	 */
	public LSPS0Request clone() {
		long ret = bindings.LSPS0Request_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Request ret_hu_conv = org.ldk.structs.LSPS0Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocols-variant LSPS0Request
	 */
	public static LSPS0Request list_protocols(org.ldk.structs.LSPS0ListProtocolsRequest a) {
		long ret = bindings.LSPS0Request_list_protocols(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0Request ret_hu_conv = org.ldk.structs.LSPS0Request.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0Requests contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS0Request b) {
		boolean ret = bindings.LSPS0Request_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS0Request)) return false;
		return this.eq((LSPS0Request)o);
	}
	/**
	 * Returns the method name associated with the given request variant.
	 */
	public String method() {
		String ret = bindings.LSPS0Request_method(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
