package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_OutputSweeperDecodeErrorZ extends CommonBase {
	private Result_OutputSweeperDecodeErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_OutputSweeperDecodeErrorZ_free(ptr); } super.finalize();
	}

	protected void force_free() {
		if (ptr != 0) { bindings.CResult_OutputSweeperDecodeErrorZ_free(ptr); ptr = 0; }
	}

	static Result_OutputSweeperDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_OutputSweeperDecodeErrorZ_is_ok(ptr)) {
			return new Result_OutputSweeperDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_OutputSweeperDecodeErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_OutputSweeperDecodeErrorZ_OK extends Result_OutputSweeperDecodeErrorZ {
		public final OutputSweeper res;
		private Result_OutputSweeperDecodeErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_OutputSweeperDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.OutputSweeper res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.OutputSweeper(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_OutputSweeperDecodeErrorZ_Err extends Result_OutputSweeperDecodeErrorZ {
		public final DecodeError err;
		private Result_OutputSweeperDecodeErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_OutputSweeperDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_OutputSweeperDecodeErrorZ in the success state.
	 */
	public static Result_OutputSweeperDecodeErrorZ ok(BestBlock o_best_block, BroadcasterInterface o_broadcaster, FeeEstimator o_fee_estimator, Option_FilterZ o_chain_data_source, OutputSpender o_output_spender, ChangeDestinationSource o_change_destination_source, KVStore o_kv_store, Logger o_logger) {
		long ret = bindings.CResult_OutputSweeperDecodeErrorZ_ok(bindings.OutputSweeper_new(o_best_block.ptr, o_broadcaster.ptr, o_fee_estimator.ptr, o_chain_data_source.ptr, o_output_spender.ptr, o_change_destination_source.ptr, o_kv_store.ptr, o_logger.ptr));
		Reference.reachabilityFence(o_best_block);
		Reference.reachabilityFence(o_broadcaster);
		Reference.reachabilityFence(o_fee_estimator);
		Reference.reachabilityFence(o_chain_data_source);
		Reference.reachabilityFence(o_output_spender);
		Reference.reachabilityFence(o_change_destination_source);
		Reference.reachabilityFence(o_kv_store);
		Reference.reachabilityFence(o_logger);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutputSweeperDecodeErrorZ ret_hu_conv = Result_OutputSweeperDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_best_block); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_broadcaster); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_fee_estimator); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_chain_data_source); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_output_spender); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_change_destination_source); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_kv_store); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o_logger); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OutputSweeperDecodeErrorZ in the error state.
	 */
	public static Result_OutputSweeperDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_OutputSweeperDecodeErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutputSweeperDecodeErrorZ ret_hu_conv = Result_OutputSweeperDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_OutputSweeperDecodeErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
