
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of OutputSpender */
public interface OutputSpenderInterface {
	/**Creates a [`Transaction`] which spends the given descriptors to the given outputs, plus an
	 * output to the given change destination (if sufficient change value remains). The
	 * transaction will have a feerate, at least, of the given value.
	 * 
	 * The `locktime` argument is used to set the transaction's locktime. If `None`, the
	 * transaction will have a locktime of 0. It it recommended to set this to the current block
	 * height to avoid fee sniping, unless you have some specific reason to use a different
	 * locktime.
	 * 
	 * Returns `Err(())` if the output value is greater than the input value minus required fee,
	 * if a descriptor was duplicated, or if an output descriptor `script_pubkey`
	 * does not match the one we can spend.
	 */
	Result_TransactionNoneZ spend_spendable_outputs(SpendableOutputDescriptor[] descriptors, TxOut[] outputs, byte[] change_destination_script, int feerate_sat_per_1000_weight, Option_u32Z locktime);
}

/**
 * A trait that describes a wallet capable of creating a spending [`Transaction`] from a set of
 * [`SpendableOutputDescriptor`]s.
 */
public class OutputSpender : CommonBase {
	internal bindings.LDKOutputSpender bindings_instance;
	internal long instance_idx;

	internal OutputSpender(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~OutputSpender() {
		if (ptr != 0) { bindings.OutputSpender_free(ptr); }
	}

	private class LDKOutputSpenderHolder { internal OutputSpender held; }
	private class LDKOutputSpenderImpl : bindings.LDKOutputSpender {
		internal LDKOutputSpenderImpl(OutputSpenderInterface arg, LDKOutputSpenderHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private OutputSpenderInterface arg;
		private LDKOutputSpenderHolder impl_holder;
		public long spend_spendable_outputs(long _descriptors, long _outputs, long _change_destination_script, int _feerate_sat_per_1000_weight, long _locktime) {
			int _descriptors_conv_27_len = InternalUtils.getArrayLength(_descriptors);
			SpendableOutputDescriptor[] _descriptors_conv_27_arr = new SpendableOutputDescriptor[_descriptors_conv_27_len];
			for (int b = 0; b < _descriptors_conv_27_len; b++) {
				long _descriptors_conv_27 = InternalUtils.getU64ArrayElem(_descriptors, b);
				org.ldk.structs.SpendableOutputDescriptor _descriptors_conv_27_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(_descriptors_conv_27);
				if (_descriptors_conv_27_hu_conv != null) { _descriptors_conv_27_hu_conv.ptrs_to.AddLast(this); };
				_descriptors_conv_27_arr[b] = _descriptors_conv_27_hu_conv;
			}
			bindings.free_buffer(_descriptors);
			int _outputs_conv_7_len = InternalUtils.getArrayLength(_outputs);
			TxOut[] _outputs_conv_7_arr = new TxOut[_outputs_conv_7_len];
			for (int h = 0; h < _outputs_conv_7_len; h++) {
				long _outputs_conv_7 = InternalUtils.getU64ArrayElem(_outputs, h);
				TxOut _outputs_conv_7_conv = new TxOut(null, _outputs_conv_7);
				_outputs_conv_7_arr[h] = _outputs_conv_7_conv;
			}
			bindings.free_buffer(_outputs);
			byte[] _change_destination_script_conv = InternalUtils.decodeUint8Array(_change_destination_script);
			org.ldk.structs.Option_u32Z _locktime_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(_locktime);
			if (_locktime_hu_conv != null) { _locktime_hu_conv.ptrs_to.AddLast(this); };
			Result_TransactionNoneZ ret = arg.spend_spendable_outputs(_descriptors_conv_27_arr, _outputs_conv_7_arr, _change_destination_script_conv, _feerate_sat_per_1000_weight, _locktime_hu_conv);
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
	}

	/** Creates a new instance of OutputSpender from a given implementation */
	public static OutputSpender new_impl(OutputSpenderInterface arg) {
		LDKOutputSpenderHolder impl_holder = new LDKOutputSpenderHolder();
		LDKOutputSpenderImpl impl = new LDKOutputSpenderImpl(arg, impl_holder);
		long[] ptr_idx = bindings.LDKOutputSpender_new(impl);

		impl_holder.held = new OutputSpender(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Creates a [`Transaction`] which spends the given descriptors to the given outputs, plus an
	 * output to the given change destination (if sufficient change value remains). The
	 * transaction will have a feerate, at least, of the given value.
	 * 
	 * The `locktime` argument is used to set the transaction's locktime. If `None`, the
	 * transaction will have a locktime of 0. It it recommended to set this to the current block
	 * height to avoid fee sniping, unless you have some specific reason to use a different
	 * locktime.
	 * 
	 * Returns `Err(())` if the output value is greater than the input value minus required fee,
	 * if a descriptor was duplicated, or if an output descriptor `script_pubkey`
	 * does not match the one we can spend.
	 */
	public Result_TransactionNoneZ spend_spendable_outputs(SpendableOutputDescriptor[] descriptors, TxOut[] outputs, byte[] change_destination_script, int feerate_sat_per_1000_weight, org.ldk.structs.Option_u32Z locktime) {
		long ret = bindings.OutputSpender_spend_spendable_outputs(this.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(descriptors, descriptors_conv_27 => descriptors_conv_27.ptr)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(outputs, outputs_conv_7 => outputs_conv_7.ptr)), InternalUtils.encodeUint8Array(change_destination_script), feerate_sat_per_1000_weight, locktime.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(descriptors);
		GC.KeepAlive(outputs);
		GC.KeepAlive(change_destination_script);
		GC.KeepAlive(feerate_sat_per_1000_weight);
		GC.KeepAlive(locktime);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TransactionNoneZ ret_hu_conv = Result_TransactionNoneZ.constr_from_ptr(ret);
		foreach (SpendableOutputDescriptor descriptors_conv_27 in descriptors) { if (this != null) { this.ptrs_to.AddLast(descriptors_conv_27); }; };
		if (this != null) { this.ptrs_to.AddLast(locktime); };
		return ret_hu_conv;
	}

}
} } }
