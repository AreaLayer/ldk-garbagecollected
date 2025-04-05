using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An event which an bLIP-50 / LSPS0 client may want to take some action in response to.
 */
public class LSPS0ClientEvent : CommonBase {
	protected LSPS0ClientEvent(object _dummy, long ptr) : base(ptr) { }
	~LSPS0ClientEvent() {
		if (ptr != 0) { bindings.LSPS0ClientEvent_free(ptr); }
	}

	internal static LSPS0ClientEvent constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPS0ClientEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPS0ClientEvent_ListProtocolsResponse(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPS0ClientEvent of type ListProtocolsResponse */
	public class LSPS0ClientEvent_ListProtocolsResponse : LSPS0ClientEvent {
		/**
		 * The node id of the LSP.
		 */
		public byte[] counterparty_node_id;
		/**
		 * A list of supported protocols.
		 */
		public short[] protocols;
		internal LSPS0ClientEvent_ListProtocolsResponse(long ptr) : base(null, ptr) {
			long counterparty_node_id = bindings.LDKLSPS0ClientEvent_ListProtocolsResponse_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long protocols = bindings.LDKLSPS0ClientEvent_ListProtocolsResponse_get_protocols(ptr);
			short[] protocols_conv = InternalUtils.decodeUint16Array(protocols);
			this.protocols = protocols_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPS0ClientEvent_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS0ClientEvent
	 */
	public org.ldk.structs.LSPS0ClientEvent clone() {
		long ret = bindings.LSPS0ClientEvent_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ClientEvent ret_hu_conv = org.ldk.structs.LSPS0ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ListProtocolsResponse-variant LSPS0ClientEvent
	 */
	public static org.ldk.structs.LSPS0ClientEvent list_protocols_response(byte[] counterparty_node_id, short[] protocols) {
		long ret = bindings.LSPS0ClientEvent_list_protocols_response(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), InternalUtils.encodeUint16Array(protocols));
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(protocols);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS0ClientEvent ret_hu_conv = org.ldk.structs.LSPS0ClientEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS0ClientEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPS0ClientEvent b) {
		bool ret = bindings.LSPS0ClientEvent_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS0ClientEvent)) return false;
		return this.eq((LSPS0ClientEvent)o);
	}
}
} } }
