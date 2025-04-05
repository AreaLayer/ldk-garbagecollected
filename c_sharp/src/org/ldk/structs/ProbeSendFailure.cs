using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Indicates that we failed to send a payment probe. Further errors may be surfaced later via
 * [`Event::ProbeFailed`].
 * 
 * [`Event::ProbeFailed`]: crate::events::Event::ProbeFailed
 */
public class ProbeSendFailure : CommonBase {
	protected ProbeSendFailure(object _dummy, long ptr) : base(ptr) { }
	~ProbeSendFailure() {
		if (ptr != 0) { bindings.ProbeSendFailure_free(ptr); }
	}

	internal static ProbeSendFailure constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKProbeSendFailure_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new ProbeSendFailure_RouteNotFound(ptr);
			case 1: return new ProbeSendFailure_ParameterError(ptr);
			case 2: return new ProbeSendFailure_DuplicateProbe(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A ProbeSendFailure of type RouteNotFound */
	public class ProbeSendFailure_RouteNotFound : ProbeSendFailure {
		internal ProbeSendFailure_RouteNotFound(long ptr) : base(null, ptr) {
		}
	}
	/** A ProbeSendFailure of type ParameterError */
	public class ProbeSendFailure_ParameterError : ProbeSendFailure {
		public org.ldk.structs.APIError parameter_error;
		internal ProbeSendFailure_ParameterError(long ptr) : base(null, ptr) {
			long parameter_error = bindings.LDKProbeSendFailure_ParameterError_get_parameter_error(ptr);
			org.ldk.structs.APIError parameter_error_hu_conv = org.ldk.structs.APIError.constr_from_ptr(parameter_error);
			if (parameter_error_hu_conv != null) { parameter_error_hu_conv.ptrs_to.AddLast(this); };
			this.parameter_error = parameter_error_hu_conv;
		}
	}
	/** A ProbeSendFailure of type DuplicateProbe */
	public class ProbeSendFailure_DuplicateProbe : ProbeSendFailure {
		internal ProbeSendFailure_DuplicateProbe(long ptr) : base(null, ptr) {
		}
	}
	internal long clone_ptr() {
		long ret = bindings.ProbeSendFailure_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ProbeSendFailure
	 */
	public org.ldk.structs.ProbeSendFailure clone() {
		long ret = bindings.ProbeSendFailure_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new RouteNotFound-variant ProbeSendFailure
	 */
	public static org.ldk.structs.ProbeSendFailure route_not_found() {
		long ret = bindings.ProbeSendFailure_route_not_found();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ParameterError-variant ProbeSendFailure
	 */
	public static org.ldk.structs.ProbeSendFailure parameter_error(org.ldk.structs.APIError a) {
		long ret = bindings.ProbeSendFailure_parameter_error(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DuplicateProbe-variant ProbeSendFailure
	 */
	public static org.ldk.structs.ProbeSendFailure duplicate_probe() {
		long ret = bindings.ProbeSendFailure_duplicate_probe();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbeSendFailure ret_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ProbeSendFailures contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.ProbeSendFailure b) {
		bool ret = bindings.ProbeSendFailure_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ProbeSendFailure)) return false;
		return this.eq((ProbeSendFailure)o);
	}
}
} } }
