package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * A trait that describes a wallet capable of creating a spending [`Transaction`] from a set of
 * [`SpendableOutputDescriptor`]s.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class OutputSpender extends CommonBase {
	final bindings.LDKOutputSpender bindings_instance;
	OutputSpender(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private OutputSpender(bindings.LDKOutputSpender arg) {
		super(bindings.LDKOutputSpender_new(arg));
		this.ptrs_to.add(arg);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.OutputSpender_free(ptr); } super.finalize();
	}
	/**
	 * Destroys the object, freeing associated resources. After this call, any access
	 * to this object may result in a SEGFAULT or worse.
	 *
	 * You should generally NEVER call this method. You should let the garbage collector
	 * do this for you when it finalizes objects. However, it may be useful for types
	 * which represent locks and should be closed immediately to avoid holding locks
	 * until the GC runs.
	 */
	public void destroy() {
		if (ptr != 0) { bindings.OutputSpender_free(ptr); }
		ptr = 0;
	}
	public static interface OutputSpenderInterface {
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
		Result_TransactionNoneZ spend_spendable_outputs(SpendableOutputDescriptor[] descriptors, TxOut[] outputs, byte[] change_destination_script, int feerate_sat_per_1000_weight, Option_u32Z locktime);
	}
	private static class LDKOutputSpenderHolder { OutputSpender held; }
	public static OutputSpender new_impl(OutputSpenderInterface arg) {
		final LDKOutputSpenderHolder impl_holder = new LDKOutputSpenderHolder();
		impl_holder.held = new OutputSpender(new bindings.LDKOutputSpender() {
			@Override public long spend_spendable_outputs(long[] descriptors, long[] outputs, byte[] change_destination_script, int feerate_sat_per_1000_weight, long locktime) {
				int descriptors_conv_27_len = descriptors.length;
				SpendableOutputDescriptor[] descriptors_conv_27_arr = new SpendableOutputDescriptor[descriptors_conv_27_len];
				for (int b = 0; b < descriptors_conv_27_len; b++) {
					long descriptors_conv_27 = descriptors[b];
					org.ldk.structs.SpendableOutputDescriptor descriptors_conv_27_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(descriptors_conv_27);
					if (descriptors_conv_27_hu_conv != null) { descriptors_conv_27_hu_conv.ptrs_to.add(this); };
					descriptors_conv_27_arr[b] = descriptors_conv_27_hu_conv;
				}
				int outputs_conv_7_len = outputs.length;
				TxOut[] outputs_conv_7_arr = new TxOut[outputs_conv_7_len];
				for (int h = 0; h < outputs_conv_7_len; h++) {
					long outputs_conv_7 = outputs[h];
					TxOut outputs_conv_7_conv = new TxOut(null, outputs_conv_7);
					outputs_conv_7_arr[h] = outputs_conv_7_conv;
				}
				org.ldk.structs.Option_u32Z locktime_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(locktime);
				if (locktime_hu_conv != null) { locktime_hu_conv.ptrs_to.add(this); };
				Result_TransactionNoneZ ret = arg.spend_spendable_outputs(descriptors_conv_27_arr, outputs_conv_7_arr, change_destination_script, feerate_sat_per_1000_weight, locktime_hu_conv);
				Reference.reachabilityFence(arg);
				long result = ret.clone_ptr();
				return result;
			}
		});
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
		long ret = bindings.OutputSpender_spend_spendable_outputs(this.ptr, descriptors != null ? Arrays.stream(descriptors).mapToLong(descriptors_conv_27 -> descriptors_conv_27.ptr).toArray() : null, outputs != null ? Arrays.stream(outputs).mapToLong(outputs_conv_7 -> outputs_conv_7.ptr).toArray() : null, change_destination_script, feerate_sat_per_1000_weight, locktime.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(descriptors);
		Reference.reachabilityFence(outputs);
		Reference.reachabilityFence(change_destination_script);
		Reference.reachabilityFence(feerate_sat_per_1000_weight);
		Reference.reachabilityFence(locktime);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TransactionNoneZ ret_hu_conv = Result_TransactionNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
