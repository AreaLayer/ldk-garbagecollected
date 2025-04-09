using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

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
public class FundingInfo : CommonBase {
	protected FundingInfo(object _dummy, long ptr) : base(ptr) { }
	~FundingInfo() {
		if (ptr != 0) { bindings.FundingInfo_free(ptr); }
	}

	internal static FundingInfo constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKFundingInfo_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new FundingInfo_Tx(ptr);
			case 1: return new FundingInfo_OutPoint(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A FundingInfo of type Tx */
	public class FundingInfo_Tx : FundingInfo {
		/**
		 * The funding transaction
		 */
		public byte[] transaction;
		internal FundingInfo_Tx(long ptr) : base(null, ptr) {
			long transaction = bindings.LDKFundingInfo_Tx_get_transaction(ptr);
			byte[] transaction_conv = InternalUtils.decodeUint8Array(transaction);
			this.transaction = transaction_conv;
		}
	}
	/** A FundingInfo of type OutPoint */
	public class FundingInfo_OutPoint : FundingInfo {
		/**
		 * The outpoint of the funding
		 */
		public org.ldk.structs.OutPoint outpoint;
		internal FundingInfo_OutPoint(long ptr) : base(null, ptr) {
			long outpoint = bindings.LDKFundingInfo_OutPoint_get_outpoint(ptr);
			org.ldk.structs.OutPoint outpoint_hu_conv = null; if (outpoint < 0 || outpoint > 4096) { outpoint_hu_conv = new org.ldk.structs.OutPoint(null, outpoint); }
			if (outpoint_hu_conv != null) { outpoint_hu_conv.ptrs_to.AddLast(this); };
			this.outpoint = outpoint_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.FundingInfo_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the FundingInfo
	 */
	public org.ldk.structs.FundingInfo clone() {
		long ret = bindings.FundingInfo_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingInfo ret_hu_conv = org.ldk.structs.FundingInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Tx-variant FundingInfo
	 */
	public static org.ldk.structs.FundingInfo tx(byte[] transaction) {
		long ret = bindings.FundingInfo_tx(InternalUtils.encodeUint8Array(transaction));
		GC.KeepAlive(transaction);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingInfo ret_hu_conv = org.ldk.structs.FundingInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OutPoint-variant FundingInfo
	 */
	public static org.ldk.structs.FundingInfo out_point(org.ldk.structs.OutPoint outpoint) {
		long ret = bindings.FundingInfo_out_point(outpoint.ptr);
		GC.KeepAlive(outpoint);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingInfo ret_hu_conv = org.ldk.structs.FundingInfo.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two FundingInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.FundingInfo b) {
		bool ret = bindings.FundingInfo_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is FundingInfo)) return false;
		return this.eq((FundingInfo)o);
	}
	/**
	 * Serialize the FundingInfo object into a byte array which can be read by FundingInfo_read
	 */
	public byte[] write() {
		long ret = bindings.FundingInfo_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a FundingInfo from a byte array, created by FundingInfo_write
	 */
	public static org.ldk.structs.Result_FundingInfoDecodeErrorZ read(byte[] ser) {
		long ret = bindings.FundingInfo_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingInfoDecodeErrorZ ret_hu_conv = Result_FundingInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
