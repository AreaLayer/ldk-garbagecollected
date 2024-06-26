
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of NodeIdLookUp */
public interface NodeIdLookUpInterface {
	/**Returns the node id of the forwarding node's channel counterparty with `short_channel_id`.
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

/**
 * An interface for looking up the node id of a channel counterparty for the purpose of forwarding
 * an [`OnionMessage`].
 * 
 * [`OnionMessage`]: crate::ln::msgs::OnionMessage
 */
public class NodeIdLookUp : CommonBase {
	internal bindings.LDKNodeIdLookUp bindings_instance;
	internal long instance_idx;

	internal NodeIdLookUp(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~NodeIdLookUp() {
		if (ptr != 0) { bindings.NodeIdLookUp_free(ptr); }
	}

	private class LDKNodeIdLookUpHolder { internal NodeIdLookUp held; }
	private class LDKNodeIdLookUpImpl : bindings.LDKNodeIdLookUp {
		internal LDKNodeIdLookUpImpl(NodeIdLookUpInterface arg, LDKNodeIdLookUpHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private NodeIdLookUpInterface arg;
		private LDKNodeIdLookUpHolder impl_holder;
		public long next_node_id(long _short_channel_id) {
			byte[] ret = arg.next_node_id(_short_channel_id);
				GC.KeepAlive(arg);
			long result = InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(ret, 33));
			return result;
		}
	}

	/** Creates a new instance of NodeIdLookUp from a given implementation */
	public static NodeIdLookUp new_impl(NodeIdLookUpInterface arg) {
		LDKNodeIdLookUpHolder impl_holder = new LDKNodeIdLookUpHolder();
		LDKNodeIdLookUpImpl impl = new LDKNodeIdLookUpImpl(arg, impl_holder);
		long[] ptr_idx = bindings.LDKNodeIdLookUp_new(impl);

		impl_holder.held = new NodeIdLookUp(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
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
	public byte[] next_node_id(long short_channel_id) {
		long ret = bindings.NodeIdLookUp_next_node_id(this.ptr, short_channel_id);
		GC.KeepAlive(this);
		GC.KeepAlive(short_channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
