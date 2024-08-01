package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * `FundingInfo` holds information about a channel's funding transaction.
 * 
 * When LDK is set to manual propagation of the funding transaction
 * (via [`ChannelManager::unsafe_manual_funding_transaction_generated`),
 * LDK does not have the full transaction data. Instead, the `OutPoint`
 * for the funding is provided here.
 * 
 * [`ChannelManager::unsafe_manual_funding_transaction_generated`]: crate::ln::channelmanager::ChannelManager::unsafe_manual_funding_transaction_generated
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class FundingInfo extends CommonBase {
	private FundingInfo(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.FundingInfo_free(ptr); }
	}
	static FundingInfo constr_from_ptr(long ptr) {
		bindings.LDKFundingInfo raw_val = bindings.LDKFundingInfo_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKFundingInfo.Tx.class) {
			return new Tx(ptr, (bindings.LDKFundingInfo.Tx)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKFundingInfo.OutPoint.class) {
			return new OutPoint(ptr, (bindings.LDKFundingInfo.OutPoint)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * The full funding `Transaction`.
	 */
	public final static class Tx extends FundingInfo {
		/**
		 * The funding transaction
		*/
		public final byte[] transaction;
		private Tx(long ptr, bindings.LDKFundingInfo.Tx obj) {
			super(null, ptr);
			this.transaction = obj.transaction;
		}
	}
	/**
	 * The `OutPoint` of the funding.
	 */
	public final static class OutPoint extends FundingInfo {
		/**
		 * The outpoint of the funding
		*/
		public final org.ldk.structs.OutPoint outpoint;
		private OutPoint(long ptr, bindings.LDKFundingInfo.OutPoint obj) {
			super(null, ptr);
			long outpoint = obj.outpoint;
			org.ldk.structs.OutPoint outpoint_hu_conv = null; if (outpoint < 0 || outpoint > 4096) { outpoint_hu_conv = new org.ldk.structs.OutPoint(null, outpoint); }
			if (outpoint_hu_conv != null) { outpoint_hu_conv.ptrs_to.add(this); };
			this.outpoint = outpoint_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.FundingInfo_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the FundingInfo
	 */
	public FundingInfo clone() {
		long ret = bindings.FundingInfo_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingInfo ret_hu_conv = org.ldk.structs.FundingInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Tx-variant FundingInfo
	 */
	public static FundingInfo tx(byte[] transaction) {
		long ret = bindings.FundingInfo_tx(transaction);
		Reference.reachabilityFence(transaction);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingInfo ret_hu_conv = org.ldk.structs.FundingInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OutPoint-variant FundingInfo
	 */
	public static FundingInfo out_point(org.ldk.structs.OutPoint outpoint) {
		long ret = bindings.FundingInfo_out_point(outpoint.ptr);
		Reference.reachabilityFence(outpoint);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingInfo ret_hu_conv = org.ldk.structs.FundingInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two FundingInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.FundingInfo b) {
		boolean ret = bindings.FundingInfo_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof FundingInfo)) return false;
		return this.eq((FundingInfo)o);
	}
	/**
	 * Serialize the FundingInfo object into a byte array which can be read by FundingInfo_read
	 */
	public byte[] write() {
		byte[] ret = bindings.FundingInfo_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a FundingInfo from a byte array, created by FundingInfo_write
	 */
	public static Result_FundingInfoDecodeErrorZ read(byte[] ser) {
		long ret = bindings.FundingInfo_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingInfoDecodeErrorZ ret_hu_conv = Result_FundingInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
