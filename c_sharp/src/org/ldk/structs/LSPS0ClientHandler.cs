using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A message handler capable of sending and handling bLIP-50 / LSPS0 messages.
 */
public class LSPS0ClientHandler : CommonBase {
	internal LSPS0ClientHandler(object _dummy, long ptr) : base(ptr) { }
	~LSPS0ClientHandler() {
		if (ptr != 0) { bindings.LSPS0ClientHandler_free(ptr); }
	}

	/**
	 * Calls bLIP-50 / LSPS0's `list_protocols`.
	 * 
	 * Please refer to the [bLIP-50 / LSPS0
	 * specifcation](https://github.com/lightning/blips/blob/master/blip-0050.md#lsps-specification-support-query)
	 * for more information.
	 */
	public void list_protocols(byte[] counterparty_node_id) {
		bindings.LSPS0ClientHandler_list_protocols(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(counterparty_node_id);
	}

}
} } }
