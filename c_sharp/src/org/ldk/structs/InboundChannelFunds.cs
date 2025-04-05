using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Used to indicate the kind of funding for this channel by the channel acceptor (us).
 * 
 * Allows the differentiation between a request for a dual-funded and non-dual-funded channel.
 */
public class InboundChannelFunds : CommonBase {
	protected InboundChannelFunds(object _dummy, long ptr) : base(ptr) { }
	~InboundChannelFunds() {
		if (ptr != 0) { bindings.InboundChannelFunds_free(ptr); }
	}

	internal static InboundChannelFunds constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKInboundChannelFunds_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new InboundChannelFunds_PushMsat(ptr);
			case 1: return new InboundChannelFunds_DualFunded(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A InboundChannelFunds of type PushMsat */
	public class InboundChannelFunds_PushMsat : InboundChannelFunds {
		public long push_msat;
		internal InboundChannelFunds_PushMsat(long ptr) : base(null, ptr) {
			this.push_msat = bindings.LDKInboundChannelFunds_PushMsat_get_push_msat(ptr);
		}
	}
	/** A InboundChannelFunds of type DualFunded */
	public class InboundChannelFunds_DualFunded : InboundChannelFunds {
		internal InboundChannelFunds_DualFunded(long ptr) : base(null, ptr) {
		}
	}
	internal long clone_ptr() {
		long ret = bindings.InboundChannelFunds_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the InboundChannelFunds
	 */
	public org.ldk.structs.InboundChannelFunds clone() {
		long ret = bindings.InboundChannelFunds_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundChannelFunds ret_hu_conv = org.ldk.structs.InboundChannelFunds.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PushMsat-variant InboundChannelFunds
	 */
	public static org.ldk.structs.InboundChannelFunds push_msat(long a) {
		long ret = bindings.InboundChannelFunds_push_msat(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundChannelFunds ret_hu_conv = org.ldk.structs.InboundChannelFunds.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DualFunded-variant InboundChannelFunds
	 */
	public static org.ldk.structs.InboundChannelFunds dual_funded() {
		long ret = bindings.InboundChannelFunds_dual_funded();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundChannelFunds ret_hu_conv = org.ldk.structs.InboundChannelFunds.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two InboundChannelFundss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.InboundChannelFunds b) {
		bool ret = bindings.InboundChannelFunds_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is InboundChannelFunds)) return false;
		return this.eq((InboundChannelFunds)o);
	}
}
} } }
