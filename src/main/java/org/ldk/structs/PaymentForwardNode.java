package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An intermediate node, its outbound channel, and relay parameters.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class PaymentForwardNode extends CommonBase {
	PaymentForwardNode(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.PaymentForwardNode_free(ptr); }
	}

	/**
	 * The TLVs for this node's [`BlindedHop`], where the fee parameters contained within are also
	 * used for [`BlindedPayInfo`] construction.
	 */
	public ForwardTlvs get_tlvs() {
		long ret = bindings.PaymentForwardNode_get_tlvs(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ForwardTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ForwardTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The TLVs for this node's [`BlindedHop`], where the fee parameters contained within are also
	 * used for [`BlindedPayInfo`] construction.
	 */
	public void set_tlvs(org.ldk.structs.ForwardTlvs val) {
		bindings.PaymentForwardNode_set_tlvs(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * This node's pubkey.
	 */
	public byte[] get_node_id() {
		byte[] ret = bindings.PaymentForwardNode_get_node_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * This node's pubkey.
	 */
	public void set_node_id(byte[] val) {
		bindings.PaymentForwardNode_set_node_id(this.ptr, InternalUtils.check_arr_len(val, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The maximum value, in msat, that may be accepted by this node.
	 */
	public long get_htlc_maximum_msat() {
		long ret = bindings.PaymentForwardNode_get_htlc_maximum_msat(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The maximum value, in msat, that may be accepted by this node.
	 */
	public void set_htlc_maximum_msat(long val) {
		bindings.PaymentForwardNode_set_htlc_maximum_msat(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new PaymentForwardNode given each field
	 */
	public static PaymentForwardNode of(org.ldk.structs.ForwardTlvs tlvs_arg, byte[] node_id_arg, long htlc_maximum_msat_arg) {
		long ret = bindings.PaymentForwardNode_new(tlvs_arg.ptr, InternalUtils.check_arr_len(node_id_arg, 33), htlc_maximum_msat_arg);
		Reference.reachabilityFence(tlvs_arg);
		Reference.reachabilityFence(node_id_arg);
		Reference.reachabilityFence(htlc_maximum_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentForwardNode ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentForwardNode(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.PaymentForwardNode_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentForwardNode
	 */
	public PaymentForwardNode clone() {
		long ret = bindings.PaymentForwardNode_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentForwardNode ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentForwardNode(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
