package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Indicates that we failed to send a payment probe. Further errors may be surfaced later via
 * [`Event::ProbeFailed`].
 * 
 * [`Event::ProbeFailed`]: crate::events::Event::ProbeFailed
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ProbeSendFailure extends CommonBase {
	private ProbeSendFailure(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.ProbeSendFailure_free(ptr); }
	}
	static ProbeSendFailure constr_from_ptr(long ptr) {
		bindings.LDKProbeSendFailure raw_val = bindings.LDKProbeSendFailure_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKProbeSendFailure.RouteNotFound.class) {
			return new RouteNotFound(ptr, (bindings.LDKProbeSendFailure.RouteNotFound)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKProbeSendFailure.ParameterError.class) {
			return new ParameterError(ptr, (bindings.LDKProbeSendFailure.ParameterError)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKProbeSendFailure.DuplicateProbe.class) {
			return new DuplicateProbe(ptr, (bindings.LDKProbeSendFailure.DuplicateProbe)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * We were unable to find a route to the destination.
	 */
	public final static class RouteNotFound extends ProbeSendFailure {
		private RouteNotFound(long ptr, bindings.LDKProbeSendFailure.RouteNotFound obj) {
			super(null, ptr);
		}
	}
	/**
	 * A parameter which was passed to [`ChannelManager::send_probe`] was invalid, preventing us from
	 * attempting to send the probe at all.
	 * 
	 * You can freely resend the probe (with the parameter error fixed).
	 * 
	 * Because the probe failed outright, no payment tracking is done and no
	 * [`Event::ProbeFailed`] events will be generated.
	 * 
	 * [`ChannelManager::send_probe`]: crate::ln::channelmanager::ChannelManager::send_probe
	 * [`Event::ProbeFailed`]: crate::events::Event::ProbeFailed
	 */
	public final static class ParameterError extends ProbeSendFailure {
		public final org.ldk.structs.APIError parameter_error;
		private ParameterError(long ptr, bindings.LDKProbeSendFailure.ParameterError obj) {
			super(null, ptr);
			long parameter_error = obj.parameter_error;
			org.ldk.structs.APIError parameter_error_hu_conv = org.ldk.structs.APIError.constr_from_ptr(parameter_error);
			if (parameter_error_hu_conv != null) { parameter_error_hu_conv.ptrs_to.add(this); };
			this.parameter_error = parameter_error_hu_conv;
		}
	}
	/**
	 * Indicates that a payment for the provided [`PaymentId`] is already in-flight and has not
	 * yet completed (i.e. generated an [`Event::ProbeSuccessful`] or [`Event::ProbeFailed`]).
	 * 
	 * [`PaymentId`]: crate::ln::channelmanager::PaymentId
	 * [`Event::ProbeSuccessful`]: crate::events::Event::ProbeSuccessful
	 * [`Event::ProbeFailed`]: crate::events::Event::ProbeFailed
	 */
	public final static class DuplicateProbe extends ProbeSendFailure {
		private DuplicateProbe(long ptr, bindings.LDKProbeSendFailure.DuplicateProbe obj) {
			super(null, ptr);
		}
	}
	long clone_ptr() {
		long ret = bindings.ProbeSendFailure_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the ProbeSendFailure
	 */
	public ProbeSendFailure clone() {
		long ret = bindings.ProbeSendFailure_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new RouteNotFound-variant ProbeSendFailure
	 */
	public static ProbeSendFailure route_not_found() {
		long ret = bindings.ProbeSendFailure_route_not_found();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ParameterError-variant ProbeSendFailure
	 */
	public static ProbeSendFailure parameter_error(org.ldk.structs.APIError a) {
		long ret = bindings.ProbeSendFailure_parameter_error(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DuplicateProbe-variant ProbeSendFailure
	 */
	public static ProbeSendFailure duplicate_probe() {
		long ret = bindings.ProbeSendFailure_duplicate_probe();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ProbeSendFailures contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.ProbeSendFailure b) {
		boolean ret = bindings.ProbeSendFailure_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof ProbeSendFailure)) return false;
		return this.eq((ProbeSendFailure)o);
	}
}
