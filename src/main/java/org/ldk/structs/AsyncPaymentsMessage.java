package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Possible async payment messages sent and received via an [`OnionMessage`].
 * 
 * [`OnionMessage`]: crate::ln::msgs::OnionMessage
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class AsyncPaymentsMessage extends CommonBase {
	private AsyncPaymentsMessage(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.AsyncPaymentsMessage_free(ptr); }
	}
	static AsyncPaymentsMessage constr_from_ptr(long ptr) {
		bindings.LDKAsyncPaymentsMessage raw_val = bindings.LDKAsyncPaymentsMessage_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKAsyncPaymentsMessage.HeldHtlcAvailable.class) {
			return new HeldHtlcAvailable(ptr, (bindings.LDKAsyncPaymentsMessage.HeldHtlcAvailable)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKAsyncPaymentsMessage.ReleaseHeldHtlc.class) {
			return new ReleaseHeldHtlc(ptr, (bindings.LDKAsyncPaymentsMessage.ReleaseHeldHtlc)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * An HTLC is being held upstream for the often-offline recipient, to be released via
	 * [`ReleaseHeldHtlc`].
	 */
	public final static class HeldHtlcAvailable extends AsyncPaymentsMessage {
		public final org.ldk.structs.HeldHtlcAvailable held_htlc_available;
		private HeldHtlcAvailable(long ptr, bindings.LDKAsyncPaymentsMessage.HeldHtlcAvailable obj) {
			super(null, ptr);
			long held_htlc_available = obj.held_htlc_available;
			org.ldk.structs.HeldHtlcAvailable held_htlc_available_hu_conv = null; if (held_htlc_available < 0 || held_htlc_available > 4096) { held_htlc_available_hu_conv = new org.ldk.structs.HeldHtlcAvailable(null, held_htlc_available); }
			if (held_htlc_available_hu_conv != null) { held_htlc_available_hu_conv.ptrs_to.add(this); };
			this.held_htlc_available = held_htlc_available_hu_conv;
		}
	}
	/**
	 * Releases the HTLC corresponding to an inbound [`HeldHtlcAvailable`] message.
	 */
	public final static class ReleaseHeldHtlc extends AsyncPaymentsMessage {
		public final org.ldk.structs.ReleaseHeldHtlc release_held_htlc;
		private ReleaseHeldHtlc(long ptr, bindings.LDKAsyncPaymentsMessage.ReleaseHeldHtlc obj) {
			super(null, ptr);
			long release_held_htlc = obj.release_held_htlc;
			org.ldk.structs.ReleaseHeldHtlc release_held_htlc_hu_conv = null; if (release_held_htlc < 0 || release_held_htlc > 4096) { release_held_htlc_hu_conv = new org.ldk.structs.ReleaseHeldHtlc(null, release_held_htlc); }
			if (release_held_htlc_hu_conv != null) { release_held_htlc_hu_conv.ptrs_to.add(this); };
			this.release_held_htlc = release_held_htlc_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.AsyncPaymentsMessage_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the AsyncPaymentsMessage
	 */
	public AsyncPaymentsMessage clone() {
		long ret = bindings.AsyncPaymentsMessage_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsMessage ret_hu_conv = org.ldk.structs.AsyncPaymentsMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new HeldHtlcAvailable-variant AsyncPaymentsMessage
	 */
	public static AsyncPaymentsMessage held_htlc_available(org.ldk.structs.HeldHtlcAvailable a) {
		long ret = bindings.AsyncPaymentsMessage_held_htlc_available(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsMessage ret_hu_conv = org.ldk.structs.AsyncPaymentsMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ReleaseHeldHtlc-variant AsyncPaymentsMessage
	 */
	public static AsyncPaymentsMessage release_held_htlc(org.ldk.structs.ReleaseHeldHtlc a) {
		long ret = bindings.AsyncPaymentsMessage_release_held_htlc(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AsyncPaymentsMessage ret_hu_conv = org.ldk.structs.AsyncPaymentsMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new OnionMessageContents which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned OnionMessageContents must be freed before this_arg is
	 */
	public OnionMessageContents as_OnionMessageContents() {
		long ret = bindings.AsyncPaymentsMessage_as_OnionMessageContents(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the AsyncPaymentsMessage object into a byte array which can be read by AsyncPaymentsMessage_read
	 */
	public byte[] write() {
		byte[] ret = bindings.AsyncPaymentsMessage_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a AsyncPaymentsMessage from a byte array, created by AsyncPaymentsMessage_write
	 */
	public static Result_AsyncPaymentsMessageDecodeErrorZ read(byte[] ser, long arg) {
		long ret = bindings.AsyncPaymentsMessage_read(ser, arg);
		Reference.reachabilityFence(ser);
		Reference.reachabilityFence(arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AsyncPaymentsMessageDecodeErrorZ ret_hu_conv = Result_AsyncPaymentsMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
