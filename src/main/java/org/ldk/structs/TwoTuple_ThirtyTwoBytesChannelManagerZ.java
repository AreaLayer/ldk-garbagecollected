package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A Tuple
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class TwoTuple_ThirtyTwoBytesChannelManagerZ extends CommonBase {
	TwoTuple_ThirtyTwoBytesChannelManagerZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C2Tuple_ThirtyTwoBytesChannelManagerZ_free(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		byte[] ret = bindings.C2Tuple_ThirtyTwoBytesChannelManagerZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * 
	 */
	public ChannelManager get_b() {
		long ret = bindings.C2Tuple_ThirtyTwoBytesChannelManagerZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelManager ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelManager(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_ThirtyTwoBytesChannelManagerZ from the contained elements.
	 */
	public static TwoTuple_ThirtyTwoBytesChannelManagerZ of(byte[] a, FeeEstimator b_fee_est, Watch b_chain_monitor, BroadcasterInterface b_tx_broadcaster, Router b_router, MessageRouter b_message_router, Logger b_logger, EntropySource b_entropy_source, NodeSigner b_node_signer, SignerProvider b_signer_provider, UserConfig b_config, ChainParameters b_params, int b_current_timestamp) {
		long ret = bindings.C2Tuple_ThirtyTwoBytesChannelManagerZ_new(InternalUtils.check_arr_len(a, 32), bindings.ChannelManager_new(b_fee_est.ptr, b_chain_monitor.ptr, b_tx_broadcaster.ptr, b_router.ptr, b_message_router.ptr, b_logger.ptr, b_entropy_source.ptr, b_node_signer.ptr, b_signer_provider.ptr, b_config.ptr, b_params.ptr, b_current_timestamp));
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b_fee_est);
		Reference.reachabilityFence(b_chain_monitor);
		Reference.reachabilityFence(b_tx_broadcaster);
		Reference.reachabilityFence(b_router);
		Reference.reachabilityFence(b_message_router);
		Reference.reachabilityFence(b_logger);
		Reference.reachabilityFence(b_entropy_source);
		Reference.reachabilityFence(b_node_signer);
		Reference.reachabilityFence(b_signer_provider);
		Reference.reachabilityFence(b_config);
		Reference.reachabilityFence(b_params);
		Reference.reachabilityFence(b_current_timestamp);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ThirtyTwoBytesChannelManagerZ ret_hu_conv = new TwoTuple_ThirtyTwoBytesChannelManagerZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_fee_est); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_chain_monitor); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_tx_broadcaster); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_router); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_message_router); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_logger); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_entropy_source); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_node_signer); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(b_signer_provider); };
		;
		;
		return ret_hu_conv;
	}

}
