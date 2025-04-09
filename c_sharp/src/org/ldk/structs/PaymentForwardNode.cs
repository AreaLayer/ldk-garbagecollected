using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An intermediate node, its outbound channel, and relay parameters.
 */
public class PaymentForwardNode : CommonBase {
	internal PaymentForwardNode(object _dummy, long ptr) : base(ptr) { }
	~PaymentForwardNode() {
		if (ptr != 0) { bindings.PaymentForwardNode_free(ptr); }
	}

	/**
	 * The TLVs for this node's [`BlindedHop`], where the fee parameters contained within are also
	 * used for [`BlindedPayInfo`] construction.
	 */
	public org.ldk.structs.ForwardTlvs get_tlvs() {
		long ret = bindings.PaymentForwardNode_get_tlvs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ForwardTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ForwardTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The TLVs for this node's [`BlindedHop`], where the fee parameters contained within are also
	 * used for [`BlindedPayInfo`] construction.
	 */
	public void set_tlvs(org.ldk.structs.ForwardTlvs val) {
		bindings.PaymentForwardNode_set_tlvs(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * This node's pubkey.
	 */
	public byte[] get_node_id() {
		long ret = bindings.PaymentForwardNode_get_node_id(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * This node's pubkey.
	 */
	public void set_node_id(byte[] val) {
		bindings.PaymentForwardNode_set_node_id(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum value, in msat, that may be accepted by this node.
	 */
	public long get_htlc_maximum_msat() {
		long ret = bindings.PaymentForwardNode_get_htlc_maximum_msat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum value, in msat, that may be accepted by this node.
	 */
	public void set_htlc_maximum_msat(long val) {
		bindings.PaymentForwardNode_set_htlc_maximum_msat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PaymentForwardNode given each field
	 */
	public static org.ldk.structs.PaymentForwardNode of(org.ldk.structs.ForwardTlvs tlvs_arg, byte[] node_id_arg, long htlc_maximum_msat_arg) {
		long ret = bindings.PaymentForwardNode_new(tlvs_arg.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(node_id_arg, 33)), htlc_maximum_msat_arg);
		GC.KeepAlive(tlvs_arg);
		GC.KeepAlive(node_id_arg);
		GC.KeepAlive(htlc_maximum_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentForwardNode ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentForwardNode(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.PaymentForwardNode_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentForwardNode
	 */
	public org.ldk.structs.PaymentForwardNode clone() {
		long ret = bindings.PaymentForwardNode_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentForwardNode ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentForwardNode(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
