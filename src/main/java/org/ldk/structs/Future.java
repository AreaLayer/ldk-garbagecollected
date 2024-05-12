package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A simple future which can complete once, and calls some callback(s) when it does so.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Future extends CommonBase {
	Future(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Future_free(ptr); }
	}

	/**
	 * Registers a callback to be called upon completion of this future. If the future has already
	 * completed, the callback will be called immediately.
	 */
	public void register_callback_fn(org.ldk.structs.FutureCallback callback) {
		bindings.Future_register_callback_fn(this.ptr, callback.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(callback);
		if (this != null) { this.ptrs_to.add(callback); };
	}

	/**
	 * Waits until this [`Future`] completes.
	 */
	public void wait_indefinite() {
		bindings.Future_wait(this.ptr);
		Reference.reachabilityFence(this);
	}

	/**
	 * Waits until this [`Future`] completes or the given amount of time has elapsed.
	 * 
	 * Returns true if the [`Future`] completed, false if the time elapsed.
	 */
	public boolean wait_timeout(long max_wait) {
		boolean ret = bindings.Future_wait_timeout(this.ptr, max_wait);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(max_wait);
		return ret;
	}

}
