package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * A callback which will be called to trigger network message processing.
 * 
 * Usually, this should call [`PeerManager::process_events`].
 * 
 * [`PeerManager::process_events`]: lightning::ln::peer_handler::PeerManager::process_events
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ProcessMessagesCallback extends CommonBase {
	final bindings.LDKProcessMessagesCallback bindings_instance;
	ProcessMessagesCallback(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private ProcessMessagesCallback(bindings.LDKProcessMessagesCallback arg) {
		super(bindings.LDKProcessMessagesCallback_new(arg));
		this.ptrs_to.add(arg);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.ProcessMessagesCallback_free(ptr); } super.finalize();
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
		if (ptr != 0) { bindings.ProcessMessagesCallback_free(ptr); }
		ptr = 0;
	}
	public static interface ProcessMessagesCallbackInterface {
		/**
		 * The method which is called.
		 */
		void call();
	}
	private static class LDKProcessMessagesCallbackHolder { ProcessMessagesCallback held; }
	public static ProcessMessagesCallback new_impl(ProcessMessagesCallbackInterface arg) {
		final LDKProcessMessagesCallbackHolder impl_holder = new LDKProcessMessagesCallbackHolder();
		impl_holder.held = new ProcessMessagesCallback(new bindings.LDKProcessMessagesCallback() {
			@Override public void call() {
				arg.call();
				Reference.reachabilityFence(arg);
			}
		});
		return impl_holder.held;
	}
	/**
	 * The method which is called.
	 */
	public void call() {
		bindings.ProcessMessagesCallback_call(this.ptr);
		Reference.reachabilityFence(this);
	}

}
