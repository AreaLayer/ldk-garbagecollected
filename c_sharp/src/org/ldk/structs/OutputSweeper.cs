using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A utility that keeps track of [`SpendableOutputDescriptor`]s, persists them in a given
 * [`KVStore`] and regularly retries sweeping them based on a callback given to the constructor
 * methods.
 * 
 * Users should call [`Self::track_spendable_outputs`] for any [`SpendableOutputDescriptor`]s received via [`Event::SpendableOutputs`].
 * 
 * This needs to be notified of chain state changes either via its [`Listen`] or [`Confirm`]
 * implementation and hence has to be connected with the utilized chain data sources.
 * 
 * If chain data is provided via the [`Confirm`] interface or via filtered blocks, users are
 * required to give their chain data sources (i.e., [`Filter`] implementation) to the respective
 * constructor.
 * 
 * [`Event::SpendableOutputs`]: crate::events::Event::SpendableOutputs
 */
public class OutputSweeper : CommonBase {
	internal OutputSweeper(object _dummy, long ptr) : base(ptr) { }
	~OutputSweeper() {
		if (ptr != 0) { bindings.OutputSweeper_free(ptr); }
	}

	/**
	 * Constructs a new [`OutputSweeper`].
	 * 
	 * If chain data is provided via the [`Confirm`] interface or via filtered blocks, users also
	 * need to register their [`Filter`] implementation via the given `chain_data_source`.
	 */
	public static org.ldk.structs.OutputSweeper of(org.ldk.structs.BestBlock best_block, org.ldk.structs.BroadcasterInterface broadcaster, org.ldk.structs.FeeEstimator fee_estimator, org.ldk.structs.Option_FilterZ chain_data_source, org.ldk.structs.OutputSpender output_spender, org.ldk.structs.ChangeDestinationSource change_destination_source, org.ldk.structs.KVStore kv_store, org.ldk.structs.Logger logger) {
		long ret = bindings.OutputSweeper_new(best_block.ptr, broadcaster.ptr, fee_estimator.ptr, chain_data_source.ptr, output_spender.ptr, change_destination_source.ptr, kv_store.ptr, logger.ptr);
		GC.KeepAlive(best_block);
		GC.KeepAlive(broadcaster);
		GC.KeepAlive(fee_estimator);
		GC.KeepAlive(chain_data_source);
		GC.KeepAlive(output_spender);
		GC.KeepAlive(change_destination_source);
		GC.KeepAlive(kv_store);
		GC.KeepAlive(logger);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutputSweeper ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutputSweeper(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(broadcaster); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(fee_estimator); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(chain_data_source); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(output_spender); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(change_destination_source); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(kv_store); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(logger); };
		return ret_hu_conv;
	}

	/**
	 * Tells the sweeper to track the given outputs descriptors.
	 * 
	 * Usually, this should be called based on the values emitted by the
	 * [`Event::SpendableOutputs`].
	 * 
	 * The given `exclude_static_outputs` flag controls whether the sweeper will filter out
	 * [`SpendableOutputDescriptor::StaticOutput`]s, which may be handled directly by the on-chain
	 * wallet implementation.
	 * 
	 * If `delay_until_height` is set, we will delay the spending until the respective block
	 * height is reached. This can be used to batch spends, e.g., to reduce on-chain fees.
	 * 
	 * Returns `Err` on persistence failure, in which case the call may be safely retried.
	 * 
	 * [`Event::SpendableOutputs`]: crate::events::Event::SpendableOutputs
	 * 
	 * Note that channel_id (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public org.ldk.structs.Result_NoneNoneZ track_spendable_outputs(SpendableOutputDescriptor[] output_descriptors, org.ldk.structs.ChannelId channel_id, bool exclude_static_outputs, org.ldk.structs.Option_u32Z delay_until_height) {
		long ret = bindings.OutputSweeper_track_spendable_outputs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(output_descriptors, output_descriptors_conv_27 => output_descriptors_conv_27.ptr)), channel_id == null ? 0 : channel_id.ptr, exclude_static_outputs, delay_until_height.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(output_descriptors);
		GC.KeepAlive(channel_id);
		GC.KeepAlive(exclude_static_outputs);
		GC.KeepAlive(delay_until_height);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Returns a list of the currently tracked spendable outputs.
	 */
	public TrackedSpendableOutput[] tracked_spendable_outputs() {
		long ret = bindings.OutputSweeper_tracked_spendable_outputs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_24_len = InternalUtils.getArrayLength(ret);
		TrackedSpendableOutput[] ret_conv_24_arr = new TrackedSpendableOutput[ret_conv_24_len];
		for (int y = 0; y < ret_conv_24_len; y++) {
			long ret_conv_24 = InternalUtils.getU64ArrayElem(ret, y);
			org.ldk.structs.TrackedSpendableOutput ret_conv_24_hu_conv = null; if (ret_conv_24 < 0 || ret_conv_24 > 4096) { ret_conv_24_hu_conv = new org.ldk.structs.TrackedSpendableOutput(null, ret_conv_24); }
			if (ret_conv_24_hu_conv != null) { ret_conv_24_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_24_arr[y] = ret_conv_24_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_24_arr;
	}

	/**
	 * Gets the latest best block which was connected either via the [`Listen`] or
	 * [`Confirm`] interfaces.
	 */
	public org.ldk.structs.BestBlock current_best_block() {
		long ret = bindings.OutputSweeper_current_best_block(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BestBlock ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BestBlock(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new Listen which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned Listen must be freed before this_arg is
	 */
	public org.ldk.structs.Listen as_Listen() {
		long ret = bindings.OutputSweeper_as_Listen(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Listen ret_hu_conv = new Listen(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new Confirm which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned Confirm must be freed before this_arg is
	 */
	public org.ldk.structs.Confirm as_Confirm() {
		long ret = bindings.OutputSweeper_as_Confirm(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Confirm ret_hu_conv = new Confirm(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Read a OutputSweeper from a byte array, created by OutputSweeper_write
	 */
	public static org.ldk.structs.Result_OutputSweeperDecodeErrorZ read(byte[] ser, org.ldk.structs.BroadcasterInterface arg_a, org.ldk.structs.FeeEstimator arg_b, org.ldk.structs.Option_FilterZ arg_c, org.ldk.structs.OutputSpender arg_d, org.ldk.structs.ChangeDestinationSource arg_e, org.ldk.structs.KVStore arg_f, org.ldk.structs.Logger arg_g) {
		long ret = bindings.OutputSweeper_read(InternalUtils.encodeUint8Array(ser), arg_a.ptr, arg_b.ptr, arg_c.ptr, arg_d.ptr, arg_e.ptr, arg_f.ptr, arg_g.ptr);
		GC.KeepAlive(ser);
		GC.KeepAlive(arg_a);
		GC.KeepAlive(arg_b);
		GC.KeepAlive(arg_c);
		GC.KeepAlive(arg_d);
		GC.KeepAlive(arg_e);
		GC.KeepAlive(arg_f);
		GC.KeepAlive(arg_g);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutputSweeperDecodeErrorZ ret_hu_conv = Result_OutputSweeperDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_a); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_b); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_c); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_d); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_e); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_f); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg_g); };
		return ret_hu_conv;
	}

}
} } }
