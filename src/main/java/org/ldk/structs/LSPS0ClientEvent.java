package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An event which an bLIP-50 / LSPS0 client may want to take some action in response to.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS0ClientEvent extends CommonBase {
	private LSPS0ClientEvent(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS0ClientEvent_free(ptr); }
	}
	static LSPS0ClientEvent constr_from_ptr(long ptr) {
		bindings.LDKLSPS0ClientEvent raw_val = bindings.LDKLSPS0ClientEvent_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPS0ClientEvent.ListProtocolsResponse.class) {
			return new ListProtocolsResponse(ptr, (bindings.LDKLSPS0ClientEvent.ListProtocolsResponse)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Information from the LSP about the protocols they support.
	 */
	public final static class ListProtocolsResponse extends LSPS0ClientEvent {
		/**
		 * The node id of the LSP.
		*/
		public final byte[] counterparty_node_id;
		/**
		 * A list of supported protocols.
		*/
		public final short[] protocols;
		private ListProtocolsResponse(long ptr, bindings.LDKLSPS0ClientEvent.ListProtocolsResponse obj) {
			super(null, ptr);
			this.counterparty_node_id = obj.counterparty_node_id;
			this.protocols = obj.protocols;
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPS0ClientEvent_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0ClientEvent
	 */
	public LSPS0ClientEvent clone() {
		long ret = bindings.LSPS0ClientEvent_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ClientEvent ret_hu_conv = org.ldk.structs.LSPS0ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocolsResponse-variant LSPS0ClientEvent
	 */
	public static LSPS0ClientEvent list_protocols_response(byte[] counterparty_node_id, short[] protocols) {
		long ret = bindings.LSPS0ClientEvent_list_protocols_response(InternalUtils.check_arr_len(counterparty_node_id, 33), protocols);
		Reference.reachabilityFence(counterparty_node_id);
		Reference.reachabilityFence(protocols);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ClientEvent ret_hu_conv = org.ldk.structs.LSPS0ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0ClientEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPS0ClientEvent b) {
		boolean ret = bindings.LSPS0ClientEvent_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS0ClientEvent)) return false;
		return this.eq((LSPS0ClientEvent)o);
	}
}
