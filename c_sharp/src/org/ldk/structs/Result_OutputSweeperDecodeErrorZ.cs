using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_OutputSweeperDecodeErrorZ : CommonBase {
	Result_OutputSweeperDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_OutputSweeperDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_OutputSweeperDecodeErrorZ_free(ptr); }
	}

	internal static Result_OutputSweeperDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_OutputSweeperDecodeErrorZ_is_ok(ptr)) {
			return new Result_OutputSweeperDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_OutputSweeperDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_OutputSweeperDecodeErrorZ_OK : Result_OutputSweeperDecodeErrorZ {
		public readonly OutputSweeper res;
		internal Result_OutputSweeperDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_OutputSweeperDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.OutputSweeper res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.OutputSweeper(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_OutputSweeperDecodeErrorZ_Err : Result_OutputSweeperDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_OutputSweeperDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_OutputSweeperDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_OutputSweeperDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_OutputSweeperDecodeErrorZ ok(BestBlock o_best_block, BroadcasterInterface o_broadcaster, FeeEstimator o_fee_estimator, Option_FilterZ o_chain_data_source, OutputSpender o_output_spender, ChangeDestinationSource o_change_destination_source, KVStore o_kv_store, Logger o_logger) {
		long ret = bindings.CResult_OutputSweeperDecodeErrorZ_ok(bindings.OutputSweeper_new(o_best_block.ptr, o_broadcaster.ptr, o_fee_estimator.ptr, o_chain_data_source.ptr, o_output_spender.ptr, o_change_destination_source.ptr, o_kv_store.ptr, o_logger.ptr));
		GC.KeepAlive(o_best_block);
		GC.KeepAlive(o_broadcaster);
		GC.KeepAlive(o_fee_estimator);
		GC.KeepAlive(o_chain_data_source);
		GC.KeepAlive(o_output_spender);
		GC.KeepAlive(o_change_destination_source);
		GC.KeepAlive(o_kv_store);
		GC.KeepAlive(o_logger);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutputSweeperDecodeErrorZ ret_hu_conv = Result_OutputSweeperDecodeErrorZ.constr_from_ptr(ret);
		;
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_broadcaster); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_fee_estimator); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_chain_data_source); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_output_spender); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_change_destination_source); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_kv_store); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_logger); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OutputSweeperDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_OutputSweeperDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_OutputSweeperDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutputSweeperDecodeErrorZ ret_hu_conv = Result_OutputSweeperDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_OutputSweeperDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
