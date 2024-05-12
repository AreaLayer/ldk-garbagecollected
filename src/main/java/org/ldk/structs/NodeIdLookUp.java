package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * An interface for looking up the node id of a channel counterparty for the purpose of forwarding
 * an [`OnionMessage`].
 * 
 * [`OnionMessage`]: crate::ln::msgs::OnionMessage
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class NodeIdLookUp extends CommonBase {
	final bindings.LDKNodeIdLookUp bindings_instance;
	NodeIdLookUp(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private NodeIdLookUp(bindings.LDKNodeIdLookUp arg) {
		super(bindings.LDKNodeIdLookUp_new(arg));
		this.ptrs_to.add(arg);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.NodeIdLookUp_free(ptr); } super.finalize();
	}
	/**
	 * Destroys the object, freeing associated resources. After this call, any access
	 * to this object may result in a SEGFAULT or worse.
	 *
	 * You should generally NEVER call this method. You should let the garbage collector
	 * do this for you when it finalizes objects. However, it may be useful for types
	 * which represent locks and should be closed immediately to avoid holding locks
	 * until the GC runs.
	 */
	public void destroy() {
		if (ptr != 0) { bindings.NodeIdLookUp_free(ptr); }
		ptr = 0;
	}
	public static interface NodeIdLookUpInterface {
		/**
		 * Returns the node id of the forwarding node's channel counterparty with `short_channel_id`.
		 * 
		 * Here, the forwarding node is referring to the node of the [`OnionMessenger`] parameterized
		 * by the [`NodeIdLookUp`] and the counterparty to one of that node's peers.
		 * 
		 * [`OnionMessenger`]: crate::onion_message::messenger::OnionMessenger
		 * 
		 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		byte[] next_node_id(long short_channel_id);
	}
	private static class LDKNodeIdLookUpHolder { NodeIdLookUp held; }
	public static NodeIdLookUp new_impl(NodeIdLookUpInterface arg) {
		final LDKNodeIdLookUpHolder impl_holder = new LDKNodeIdLookUpHolder();
		impl_holder.held = new NodeIdLookUp(new bindings.LDKNodeIdLookUp() {
			@Override public byte[] next_node_id(long short_channel_id) {
				byte[] ret = arg.next_node_id(short_channel_id);
				Reference.reachabilityFence(arg);
				byte[] result = InternalUtils.check_arr_len(ret, 33);
				return result;
			}
		});
		return impl_holder.held;
	}
	/**
	 * Returns the node id of the forwarding node's channel counterparty with `short_channel_id`.
	 * 
	 * Here, the forwarding node is referring to the node of the [`OnionMessenger`] parameterized
	 * by the [`NodeIdLookUp`] and the counterparty to one of that node's peers.
	 * 
	 * [`OnionMessenger`]: crate::onion_message::messenger::OnionMessenger
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public byte[] next_node_id(long short_channel_id) {
		byte[] ret = bindings.NodeIdLookUp_next_node_id(this.ptr, short_channel_id);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(short_channel_id);
		return ret;
	}

}
