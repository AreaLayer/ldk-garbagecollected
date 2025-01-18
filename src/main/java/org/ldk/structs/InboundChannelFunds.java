package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Used to indicate the kind of funding for this channel by the channel acceptor (us).
 * 
 * Allows the differentiation between a request for a dual-funded and non-dual-funded channel.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class InboundChannelFunds extends CommonBase {
	private InboundChannelFunds(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.InboundChannelFunds_free(ptr); }
	}
	static InboundChannelFunds constr_from_ptr(long ptr) {
		bindings.LDKInboundChannelFunds raw_val = bindings.LDKInboundChannelFunds_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKInboundChannelFunds.PushMsat.class) {
			return new PushMsat(ptr, (bindings.LDKInboundChannelFunds.PushMsat)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKInboundChannelFunds.DualFunded.class) {
			return new DualFunded(ptr, (bindings.LDKInboundChannelFunds.DualFunded)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * For a non-dual-funded channel, the `push_msat` value from the channel initiator to us.
	 */
	public final static class PushMsat extends InboundChannelFunds {
		public final long push_msat;
		private PushMsat(long ptr, bindings.LDKInboundChannelFunds.PushMsat obj) {
			super(null, ptr);
			this.push_msat = obj.push_msat;
		}
	}
	/**
	 * Indicates the open request is for a dual funded channel.
	 * 
	 * Note that these channels do not support starting with initial funds pushed from the counterparty,
	 * who is the channel opener in this case.
	 */
	public final static class DualFunded extends InboundChannelFunds {
		private DualFunded(long ptr, bindings.LDKInboundChannelFunds.DualFunded obj) {
			super(null, ptr);
		}
	}
	long clone_ptr() {
		long ret = bindings.InboundChannelFunds_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the InboundChannelFunds
	 */
	public InboundChannelFunds clone() {
		long ret = bindings.InboundChannelFunds_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundChannelFunds ret_hu_conv = org.ldk.structs.InboundChannelFunds.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PushMsat-variant InboundChannelFunds
	 */
	public static InboundChannelFunds push_msat(long a) {
		long ret = bindings.InboundChannelFunds_push_msat(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundChannelFunds ret_hu_conv = org.ldk.structs.InboundChannelFunds.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DualFunded-variant InboundChannelFunds
	 */
	public static InboundChannelFunds dual_funded() {
		long ret = bindings.InboundChannelFunds_dual_funded();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InboundChannelFunds ret_hu_conv = org.ldk.structs.InboundChannelFunds.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two InboundChannelFundss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.InboundChannelFunds b) {
		boolean ret = bindings.InboundChannelFunds_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof InboundChannelFunds)) return false;
		return this.eq((InboundChannelFunds)o);
	}
}
