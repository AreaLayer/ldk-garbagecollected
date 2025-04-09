package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A message handler capable of sending and handling bLIP-50 / LSPS0 messages.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS0ClientHandler extends CommonBase {
	LSPS0ClientHandler(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
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
		bindings.LSPS0ClientHandler_list_protocols(this.ptr, InternalUtils.check_arr_len(counterparty_node_id, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(counterparty_node_id);
	}

}
