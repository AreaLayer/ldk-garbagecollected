package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * A handler for an [`OnionMessage`] containing an async payments message as its payload.
 * 
 * [`OnionMessage`]: crate::ln::msgs::OnionMessage
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class AsyncPaymentsMessageHandler extends CommonBase {
	final bindings.LDKAsyncPaymentsMessageHandler bindings_instance;
	AsyncPaymentsMessageHandler(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private AsyncPaymentsMessageHandler(bindings.LDKAsyncPaymentsMessageHandler arg) {
		super(bindings.LDKAsyncPaymentsMessageHandler_new(arg));
		this.ptrs_to.add(arg);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.AsyncPaymentsMessageHandler_free(ptr); } super.finalize();
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
		if (ptr != 0) { bindings.AsyncPaymentsMessageHandler_free(ptr); }
		ptr = 0;
	}
	public static interface AsyncPaymentsMessageHandlerInterface {
		/**
		 * Handle a [`HeldHtlcAvailable`] message. A [`ReleaseHeldHtlc`] should be returned to release
		 * the held funds.
		 * 
		 * Note that responder (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ handle_held_htlc_available(HeldHtlcAvailable message, Responder responder);
		/**
		 * Handle a [`ReleaseHeldHtlc`] message. If authentication of the message succeeds, an HTLC
		 * should be released to the corresponding payee.
		 */
		void handle_release_held_htlc(ReleaseHeldHtlc message, AsyncPaymentsContext context);
		/**
		 * Release any [`AsyncPaymentsMessage`]s that need to be sent.
		 * 
		 * Typically, this is used for messages initiating an async payment flow rather than in response
		 * to another message.
		 */
		TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] release_pending_messages();
	}
	private static class LDKAsyncPaymentsMessageHandlerHolder { AsyncPaymentsMessageHandler held; }
	public static AsyncPaymentsMessageHandler new_impl(AsyncPaymentsMessageHandlerInterface arg) {
		final LDKAsyncPaymentsMessageHandlerHolder impl_holder = new LDKAsyncPaymentsMessageHandlerHolder();
		impl_holder.held = new AsyncPaymentsMessageHandler(new bindings.LDKAsyncPaymentsMessageHandler() {
			@Override public long handle_held_htlc_available(long message, long responder) {
				org.ldk.structs.HeldHtlcAvailable message_hu_conv = null; if (message < 0 || message > 4096) { message_hu_conv = new org.ldk.structs.HeldHtlcAvailable(null, message); }
				if (message_hu_conv != null) { message_hu_conv.ptrs_to.add(this); };
				org.ldk.structs.Responder responder_hu_conv = null; if (responder < 0 || responder > 4096) { responder_hu_conv = new org.ldk.structs.Responder(null, responder); }
				if (responder_hu_conv != null) { responder_hu_conv.ptrs_to.add(this); };
				Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ ret = arg.handle_held_htlc_available(message_hu_conv, responder_hu_conv);
				Reference.reachabilityFence(arg);
				long result = ret.clone_ptr();
				return result;
			}
			@Override public void handle_release_held_htlc(long message, long context) {
				org.ldk.structs.ReleaseHeldHtlc message_hu_conv = null; if (message < 0 || message > 4096) { message_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, message); }
				if (message_hu_conv != null) { message_hu_conv.ptrs_to.add(this); };
				org.ldk.structs.AsyncPaymentsContext context_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(context);
				if (context_hu_conv != null) { context_hu_conv.ptrs_to.add(this); };
				arg.handle_release_held_htlc(message_hu_conv, context_hu_conv);
				Reference.reachabilityFence(arg);
			}
			@Override public long[] release_pending_messages() {
				TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] ret = arg.release_pending_messages();
				Reference.reachabilityFence(arg);
				long[] result = ret != null ? Arrays.stream(ret).mapToLong(ret_conv_55 -> ret_conv_55.clone_ptr()).toArray() : null;
				return result;
			}
		});
		return impl_holder.held;
	}
	/**
	 * Handle a [`HeldHtlcAvailable`] message. A [`ReleaseHeldHtlc`] should be returned to release
	 * the held funds.
	 * 
	 * Note that responder (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ handle_held_htlc_available(org.ldk.structs.HeldHtlcAvailable message, @Nullable org.ldk.structs.Responder responder) {
		long ret = bindings.AsyncPaymentsMessageHandler_handle_held_htlc_available(this.ptr, message.ptr, responder == null ? 0 : responder.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(message);
		Reference.reachabilityFence(responder);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Handle a [`ReleaseHeldHtlc`] message. If authentication of the message succeeds, an HTLC
	 * should be released to the corresponding payee.
	 */
	public void handle_release_held_htlc(org.ldk.structs.ReleaseHeldHtlc message, org.ldk.structs.AsyncPaymentsContext context) {
		bindings.AsyncPaymentsMessageHandler_handle_release_held_htlc(this.ptr, message.ptr, context.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(message);
		Reference.reachabilityFence(context);
	}

	/**
	 * Release any [`AsyncPaymentsMessage`]s that need to be sent.
	 * 
	 * Typically, this is used for messages initiating an async payment flow rather than in response
	 * to another message.
	 */
	public TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] release_pending_messages() {
		long[] ret = bindings.AsyncPaymentsMessageHandler_release_pending_messages(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_55_len = ret.length;
		TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] ret_conv_55_arr = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[ret_conv_55_len];
		for (int d = 0; d < ret_conv_55_len; d++) {
			long ret_conv_55 = ret[d];
			TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ ret_conv_55_hu_conv = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(null, ret_conv_55);
			if (ret_conv_55_hu_conv != null) { ret_conv_55_hu_conv.ptrs_to.add(this); };
			ret_conv_55_arr[d] = ret_conv_55_hu_conv;
		}
		return ret_conv_55_arr;
	}

}
