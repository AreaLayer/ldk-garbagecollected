using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The result of a successful coin selection attempt for a transaction requiring additional UTXOs
 * to cover its fees.
 */
public class CoinSelection : CommonBase {
	internal CoinSelection(object _dummy, long ptr) : base(ptr) { }
	~CoinSelection() {
		if (ptr != 0) { bindings.CoinSelection_free(ptr); }
	}

	/**
	 * The set of UTXOs (with at least 1 confirmation) to spend and use within a transaction
	 * requiring additional fees.
	 */
	public Utxo[] get_confirmed_utxos() {
		long ret = bindings.CoinSelection_get_confirmed_utxos(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_6_len = InternalUtils.getArrayLength(ret);
		Utxo[] ret_conv_6_arr = new Utxo[ret_conv_6_len];
		for (int g = 0; g < ret_conv_6_len; g++) {
			long ret_conv_6 = InternalUtils.getU64ArrayElem(ret, g);
			org.ldk.structs.Utxo ret_conv_6_hu_conv = null; if (ret_conv_6 < 0 || ret_conv_6 > 4096) { ret_conv_6_hu_conv = new org.ldk.structs.Utxo(null, ret_conv_6); }
			if (ret_conv_6_hu_conv != null) { ret_conv_6_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_6_arr[g] = ret_conv_6_hu_conv;
		}
		bindings.free_buffer(ret);
		return ret_conv_6_arr;
	}

	/**
	 * The set of UTXOs (with at least 1 confirmation) to spend and use within a transaction
	 * requiring additional fees.
	 */
	public void set_confirmed_utxos(Utxo[] val) {
		bindings.CoinSelection_set_confirmed_utxos(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(val, val_conv_6 => val_conv_6.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * An additional output tracking whether any change remained after coin selection. This output
	 * should always have a value above dust for its given `script_pubkey`. It should not be
	 * spent until the transaction it belongs to confirms to ensure mempool descendant limits are
	 * not met. This implies no other party should be able to spend it except us.
	 */
	public org.ldk.structs.Option_TxOutZ get_change_output() {
		long ret = bindings.CoinSelection_get_change_output(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_TxOutZ ret_hu_conv = org.ldk.structs.Option_TxOutZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An additional output tracking whether any change remained after coin selection. This output
	 * should always have a value above dust for its given `script_pubkey`. It should not be
	 * spent until the transaction it belongs to confirms to ensure mempool descendant limits are
	 * not met. This implies no other party should be able to spend it except us.
	 */
	public void set_change_output(org.ldk.structs.Option_TxOutZ val) {
		bindings.CoinSelection_set_change_output(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new CoinSelection given each field
	 */
	public static org.ldk.structs.CoinSelection of(Utxo[] confirmed_utxos_arg, org.ldk.structs.Option_TxOutZ change_output_arg) {
		long ret = bindings.CoinSelection_new(InternalUtils.encodeUint64Array(InternalUtils.mapArray(confirmed_utxos_arg, confirmed_utxos_arg_conv_6 => confirmed_utxos_arg_conv_6.ptr)), change_output_arg.ptr);
		GC.KeepAlive(confirmed_utxos_arg);
		GC.KeepAlive(change_output_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CoinSelection ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CoinSelection(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.CoinSelection_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the CoinSelection
	 */
	public org.ldk.structs.CoinSelection clone() {
		long ret = bindings.CoinSelection_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CoinSelection ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CoinSelection(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
