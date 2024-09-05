package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Indicates an error on the client's part (usually some variant of attempting to use too-low or
 * too-high values)
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class APIError extends CommonBase {
	private APIError(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.APIError_free(ptr); }
	}
	static APIError constr_from_ptr(long ptr) {
		bindings.LDKAPIError raw_val = bindings.LDKAPIError_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKAPIError.APIMisuseError.class) {
			return new APIMisuseError(ptr, (bindings.LDKAPIError.APIMisuseError)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKAPIError.FeeRateTooHigh.class) {
			return new FeeRateTooHigh(ptr, (bindings.LDKAPIError.FeeRateTooHigh)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKAPIError.InvalidRoute.class) {
			return new InvalidRoute(ptr, (bindings.LDKAPIError.InvalidRoute)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKAPIError.ChannelUnavailable.class) {
			return new ChannelUnavailable(ptr, (bindings.LDKAPIError.ChannelUnavailable)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKAPIError.MonitorUpdateInProgress.class) {
			return new MonitorUpdateInProgress(ptr, (bindings.LDKAPIError.MonitorUpdateInProgress)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKAPIError.IncompatibleShutdownScript.class) {
			return new IncompatibleShutdownScript(ptr, (bindings.LDKAPIError.IncompatibleShutdownScript)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Indicates the API was wholly misused (see err for more). Cases where these can be returned
	 * are documented, but generally indicates some precondition of a function was violated.
	 */
	public final static class APIMisuseError extends APIError {
		/**
		 * A human-readable error message
		*/
		public final java.lang.String err;
		private APIMisuseError(long ptr, bindings.LDKAPIError.APIMisuseError obj) {
			super(null, ptr);
			this.err = obj.err;
		}
	}
	/**
	 * Due to a high feerate, we were unable to complete the request.
	 * For example, this may be returned if the feerate implies we cannot open a channel at the
	 * requested value, but opening a larger channel would succeed.
	 */
	public final static class FeeRateTooHigh extends APIError {
		/**
		 * A human-readable error message
		*/
		public final java.lang.String err;
		/**
		 * The feerate which was too high.
		*/
		public final int feerate;
		private FeeRateTooHigh(long ptr, bindings.LDKAPIError.FeeRateTooHigh obj) {
			super(null, ptr);
			this.err = obj.err;
			this.feerate = obj.feerate;
		}
	}
	/**
	 * A malformed Route was provided (eg overflowed value, node id mismatch, overly-looped route,
	 * too-many-hops, etc).
	 */
	public final static class InvalidRoute extends APIError {
		/**
		 * A human-readable error message
		*/
		public final java.lang.String err;
		private InvalidRoute(long ptr, bindings.LDKAPIError.InvalidRoute obj) {
			super(null, ptr);
			this.err = obj.err;
		}
	}
	/**
	 * We were unable to complete the request as the Channel required to do so is unable to
	 * complete the request (or was not found). This can take many forms, including disconnected
	 * peer, channel at capacity, channel shutting down, etc.
	 */
	public final static class ChannelUnavailable extends APIError {
		/**
		 * A human-readable error message
		*/
		public final java.lang.String err;
		private ChannelUnavailable(long ptr, bindings.LDKAPIError.ChannelUnavailable obj) {
			super(null, ptr);
			this.err = obj.err;
		}
	}
	/**
	 * An attempt to call [`chain::Watch::watch_channel`]/[`chain::Watch::update_channel`]
	 * returned a [`ChannelMonitorUpdateStatus::InProgress`] indicating the persistence of a
	 * monitor update is awaiting async resolution. Once it resolves the attempted action should
	 * complete automatically.
	 * 
	 * [`chain::Watch::watch_channel`]: crate::chain::Watch::watch_channel
	 * [`chain::Watch::update_channel`]: crate::chain::Watch::update_channel
	 * [`ChannelMonitorUpdateStatus::InProgress`]: crate::chain::ChannelMonitorUpdateStatus::InProgress
	 */
	public final static class MonitorUpdateInProgress extends APIError {
		private MonitorUpdateInProgress(long ptr, bindings.LDKAPIError.MonitorUpdateInProgress obj) {
			super(null, ptr);
		}
	}
	/**
	 * [`SignerProvider::get_shutdown_scriptpubkey`] returned a shutdown scriptpubkey incompatible
	 * with the channel counterparty as negotiated in [`InitFeatures`].
	 * 
	 * Using a SegWit v0 script should resolve this issue. If you cannot, you won't be able to open
	 * a channel or cooperatively close one with this peer (and will have to force-close instead).
	 * 
	 * [`SignerProvider::get_shutdown_scriptpubkey`]: crate::sign::SignerProvider::get_shutdown_scriptpubkey
	 * [`InitFeatures`]: crate::ln::features::InitFeatures
	 */
	public final static class IncompatibleShutdownScript extends APIError {
		/**
		 * The incompatible shutdown script.
		*/
		public final org.ldk.structs.ShutdownScript script;
		private IncompatibleShutdownScript(long ptr, bindings.LDKAPIError.IncompatibleShutdownScript obj) {
			super(null, ptr);
			long script = obj.script;
			org.ldk.structs.ShutdownScript script_hu_conv = null; if (script < 0 || script > 4096) { script_hu_conv = new org.ldk.structs.ShutdownScript(null, script); }
			if (script_hu_conv != null) { script_hu_conv.ptrs_to.add(this); };
			this.script = script_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.APIError_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the APIError
	 */
	public APIError clone() {
		long ret = bindings.APIError_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new APIMisuseError-variant APIError
	 */
	public static APIError apimisuse_error(java.lang.String err) {
		long ret = bindings.APIError_apimisuse_error(err);
		Reference.reachabilityFence(err);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new FeeRateTooHigh-variant APIError
	 */
	public static APIError fee_rate_too_high(java.lang.String err, int feerate) {
		long ret = bindings.APIError_fee_rate_too_high(err, feerate);
		Reference.reachabilityFence(err);
		Reference.reachabilityFence(feerate);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvalidRoute-variant APIError
	 */
	public static APIError invalid_route(java.lang.String err) {
		long ret = bindings.APIError_invalid_route(err);
		Reference.reachabilityFence(err);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ChannelUnavailable-variant APIError
	 */
	public static APIError channel_unavailable(java.lang.String err) {
		long ret = bindings.APIError_channel_unavailable(err);
		Reference.reachabilityFence(err);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new MonitorUpdateInProgress-variant APIError
	 */
	public static APIError monitor_update_in_progress() {
		long ret = bindings.APIError_monitor_update_in_progress();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new IncompatibleShutdownScript-variant APIError
	 */
	public static APIError incompatible_shutdown_script(org.ldk.structs.ShutdownScript script) {
		long ret = bindings.APIError_incompatible_shutdown_script(script.ptr);
		Reference.reachabilityFence(script);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two APIErrors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.APIError b) {
		boolean ret = bindings.APIError_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof APIError)) return false;
		return this.eq((APIError)o);
	}
	/**
	 * Serialize the APIError object into a byte array which can be read by APIError_read
	 */
	public byte[] write() {
		byte[] ret = bindings.APIError_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
