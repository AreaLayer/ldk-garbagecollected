
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of AsyncPaymentsMessageHandler */
public interface AsyncPaymentsMessageHandlerInterface {
	/**Handle a [`HeldHtlcAvailable`] message. A [`ReleaseHeldHtlc`] should be returned to release
	 * the held funds.
	 * 
	 * Note that responder (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ handle_held_htlc_available(org.ldk.structs.HeldHtlcAvailable message, org.ldk.structs.Responder responder);
	/**Handle a [`ReleaseHeldHtlc`] message. If authentication of the message succeeds, an HTLC
	 * should be released to the corresponding payee.
	 */
	void handle_release_held_htlc(org.ldk.structs.ReleaseHeldHtlc message, org.ldk.structs.AsyncPaymentsContext context);
	/**Release any [`AsyncPaymentsMessage`]s that need to be sent.
	 * 
	 * Typically, this is used for messages initiating an async payment flow rather than in response
	 * to another message.
	 */
	TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] release_pending_messages();
}

/**
 * A handler for an [`OnionMessage`] containing an async payments message as its payload.
 * 
 * [`OnionMessage`]: crate::ln::msgs::OnionMessage
 */
public class AsyncPaymentsMessageHandler : CommonBase {
	internal bindings.LDKAsyncPaymentsMessageHandler bindings_instance;
	internal long instance_idx;

	internal AsyncPaymentsMessageHandler(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~AsyncPaymentsMessageHandler() {
		if (ptr != 0) { bindings.AsyncPaymentsMessageHandler_free(ptr); }
	}

	private class LDKAsyncPaymentsMessageHandlerHolder { internal AsyncPaymentsMessageHandler held; }
	private class LDKAsyncPaymentsMessageHandlerImpl : bindings.LDKAsyncPaymentsMessageHandler {
		internal LDKAsyncPaymentsMessageHandlerImpl(AsyncPaymentsMessageHandlerInterface arg, LDKAsyncPaymentsMessageHandlerHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private AsyncPaymentsMessageHandlerInterface arg;
		private LDKAsyncPaymentsMessageHandlerHolder impl_holder;
		public long handle_held_htlc_available(long _message, long _responder) {
			org.ldk.structs.HeldHtlcAvailable _message_hu_conv = null; if (_message < 0 || _message > 4096) { _message_hu_conv = new org.ldk.structs.HeldHtlcAvailable(null, _message); }
			if (_message_hu_conv != null) { _message_hu_conv.ptrs_to.AddLast(this); };
			org.ldk.structs.Responder _responder_hu_conv = null; if (_responder < 0 || _responder > 4096) { _responder_hu_conv = new org.ldk.structs.Responder(null, _responder); }
			if (_responder_hu_conv != null) { _responder_hu_conv.ptrs_to.AddLast(this); };
			Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ ret = arg.handle_held_htlc_available(_message_hu_conv, _responder_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
		public void handle_release_held_htlc(long _message, long _context) {
			org.ldk.structs.ReleaseHeldHtlc _message_hu_conv = null; if (_message < 0 || _message > 4096) { _message_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, _message); }
			if (_message_hu_conv != null) { _message_hu_conv.ptrs_to.AddLast(this); };
			org.ldk.structs.AsyncPaymentsContext _context_hu_conv = org.ldk.structs.AsyncPaymentsContext.constr_from_ptr(_context);
			if (_context_hu_conv != null) { _context_hu_conv.ptrs_to.AddLast(this); };
			arg.handle_release_held_htlc(_message_hu_conv, _context_hu_conv);
				GC.KeepAlive(arg);
		}
		public long release_pending_messages() {
			TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] ret = arg.release_pending_messages();
				GC.KeepAlive(arg);
			long result = InternalUtils.encodeUint64Array(InternalUtils.mapArray(ret, ret_conv_55 => ret_conv_55.clone_ptr()));
			return result;
		}
	}

	/** Creates a new instance of AsyncPaymentsMessageHandler from a given implementation */
	public static AsyncPaymentsMessageHandler new_impl(AsyncPaymentsMessageHandlerInterface arg) {
		LDKAsyncPaymentsMessageHandlerHolder impl_holder = new LDKAsyncPaymentsMessageHandlerHolder();
		LDKAsyncPaymentsMessageHandlerImpl impl = new LDKAsyncPaymentsMessageHandlerImpl(arg, impl_holder);
		long[] ptr_idx = bindings.LDKAsyncPaymentsMessageHandler_new(impl);

		impl_holder.held = new AsyncPaymentsMessageHandler(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Handle a [`HeldHtlcAvailable`] message. A [`ReleaseHeldHtlc`] should be returned to release
	 * the held funds.
	 * 
	 * Note that responder (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ handle_held_htlc_available(org.ldk.structs.HeldHtlcAvailable message, org.ldk.structs.Responder responder) {
		long ret = bindings.AsyncPaymentsMessageHandler_handle_held_htlc_available(this.ptr, message.ptr, responder == null ? 0 : responder.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(message);
		GC.KeepAlive(responder);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Handle a [`ReleaseHeldHtlc`] message. If authentication of the message succeeds, an HTLC
	 * should be released to the corresponding payee.
	 */
	public void handle_release_held_htlc(org.ldk.structs.ReleaseHeldHtlc message, org.ldk.structs.AsyncPaymentsContext context) {
		bindings.AsyncPaymentsMessageHandler_handle_release_held_htlc(this.ptr, message.ptr, context.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(message);
		GC.KeepAlive(context);
	}

	/**
	 * Release any [`AsyncPaymentsMessage`]s that need to be sent.
	 * 
	 * Typically, this is used for messages initiating an async payment flow rather than in response
	 * to another message.
	 */
	public TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] release_pending_messages() {
		long ret = bindings.AsyncPaymentsMessageHandler_release_pending_messages(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_55_len = InternalUtils.getArrayLength(ret);
		TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[] ret_conv_55_arr = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ[ret_conv_55_len];
		for (int d = 0; d < ret_conv_55_len; d++) {
			long ret_conv_55 = InternalUtils.getU64ArrayElem(ret, d);
			TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ ret_conv_55_hu_conv = new TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ(null, ret_conv_55);
			if (ret_conv_55_hu_conv != null) { ret_conv_55_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_55_arr[d] = ret_conv_55_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_55_arr;
	}

}
} } }
