package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * A trait implemented for objects handling events from [`EventsProvider`].
 * 
 * An async variation also exists for implementations of [`EventsProvider`] that support async
 * event handling. The async event handler should satisfy the generic bounds: `F:
 * core::future::Future<Output = Result<(), ReplayEvent>>, H: Fn(Event) -> F`.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class EventHandler extends CommonBase {
	final bindings.LDKEventHandler bindings_instance;
	EventHandler(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private EventHandler(bindings.LDKEventHandler arg) {
		super(bindings.LDKEventHandler_new(arg));
		this.ptrs_to.add(arg);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.EventHandler_free(ptr); } super.finalize();
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
		if (ptr != 0) { bindings.EventHandler_free(ptr); }
		ptr = 0;
	}
	public static interface EventHandlerInterface {
		/**
		 * Handles the given [`Event`].
		 * 
		 * See [`EventsProvider`] for details that must be considered when implementing this method.
		 */
		Result_NoneReplayEventZ handle_event(Event event);
	}
	private static class LDKEventHandlerHolder { EventHandler held; }
	public static EventHandler new_impl(EventHandlerInterface arg) {
		final LDKEventHandlerHolder impl_holder = new LDKEventHandlerHolder();
		impl_holder.held = new EventHandler(new bindings.LDKEventHandler() {
			@Override public long handle_event(long event) {
				org.ldk.structs.Event event_hu_conv = org.ldk.structs.Event.constr_from_ptr(event);
				if (event_hu_conv != null) { event_hu_conv.ptrs_to.add(this); };
				Result_NoneReplayEventZ ret = arg.handle_event(event_hu_conv);
				Reference.reachabilityFence(arg);
				long result = ret.clone_ptr();
				return result;
			}
		});
		return impl_holder.held;
	}
	/**
	 * Handles the given [`Event`].
	 * 
	 * See [`EventsProvider`] for details that must be considered when implementing this method.
	 */
	public Result_NoneReplayEventZ handle_event(org.ldk.structs.Event event) {
		long ret = bindings.EventHandler_handle_event(this.ptr, event.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(event);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneReplayEventZ ret_hu_conv = Result_NoneReplayEventZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
