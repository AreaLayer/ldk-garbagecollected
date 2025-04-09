
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of ProcessMessagesCallback */
public interface ProcessMessagesCallbackInterface {
	/**The method which is called.
	 */
	void call();
}

/**
 * A callback which will be called to trigger network message processing.
 * 
 * Usually, this should call [`PeerManager::process_events`].
 * 
 * [`PeerManager::process_events`]: lightning::ln::peer_handler::PeerManager::process_events
 */
public class ProcessMessagesCallback : CommonBase {
	internal bindings.LDKProcessMessagesCallback bindings_instance;
	internal long instance_idx;

	internal ProcessMessagesCallback(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~ProcessMessagesCallback() {
		if (ptr != 0) { bindings.ProcessMessagesCallback_free(ptr); }
	}

	private class LDKProcessMessagesCallbackHolder { internal ProcessMessagesCallback held; }
	private class LDKProcessMessagesCallbackImpl : bindings.LDKProcessMessagesCallback {
		internal LDKProcessMessagesCallbackImpl(ProcessMessagesCallbackInterface arg, LDKProcessMessagesCallbackHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private ProcessMessagesCallbackInterface arg;
		private LDKProcessMessagesCallbackHolder impl_holder;
		public void call() {
			arg.call();
				GC.KeepAlive(arg);
		}
	}

	/** Creates a new instance of ProcessMessagesCallback from a given implementation */
	public static ProcessMessagesCallback new_impl(ProcessMessagesCallbackInterface arg) {
		LDKProcessMessagesCallbackHolder impl_holder = new LDKProcessMessagesCallbackHolder();
		LDKProcessMessagesCallbackImpl impl = new LDKProcessMessagesCallbackImpl(arg, impl_holder);
		long[] ptr_idx = bindings.LDKProcessMessagesCallback_new(impl);

		impl_holder.held = new ProcessMessagesCallback(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * The method which is called.
	 */
	public void call() {
		bindings.ProcessMessagesCallback_call(this.ptr);
		GC.KeepAlive(this);
	}

}
} } }
