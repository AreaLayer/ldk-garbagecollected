using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Describes the necessary information to spend a spendable output.
 * 
 * When on-chain outputs are created by LDK (which our counterparty is not able to claim at any
 * point in the future) a [`SpendableOutputs`] event is generated which you must track and be able
 * to spend on-chain. The information needed to do this is provided in this enum, including the
 * outpoint describing which `txid` and output `index` is available, the full output which exists
 * at that `txid`/`index`, and any keys or other information required to sign.
 * 
 * [`SpendableOutputs`]: crate::events::Event::SpendableOutputs
 */
public class SpendableOutputDescriptor : CommonBase {
	protected SpendableOutputDescriptor(object _dummy, long ptr) : base(ptr) { }
	~SpendableOutputDescriptor() {
		if (ptr != 0) { bindings.SpendableOutputDescriptor_free(ptr); }
	}

	internal static SpendableOutputDescriptor constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKSpendableOutputDescriptor_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new SpendableOutputDescriptor_StaticOutput(ptr);
			case 1: return new SpendableOutputDescriptor_DelayedPaymentOutput(ptr);
			case 2: return new SpendableOutputDescriptor_StaticPaymentOutput(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A SpendableOutputDescriptor of type StaticOutput */
	public class SpendableOutputDescriptor_StaticOutput : SpendableOutputDescriptor {
		/**
		 * The outpoint which is spendable.
		 */
		public org.ldk.structs.OutPoint outpoint;
		/**
		 * The output which is referenced by the given outpoint.
		 */
		public org.ldk.structs.TxOut output;
		/**
		 * The `channel_keys_id` for the channel which this output came from.
		 * 
		 * For channels which were generated on LDK 0.0.119 or later, this is the value which was
		 * passed to the [`SignerProvider::get_destination_script`] call which provided this
		 * output script.
		 * 
		 * For channels which were generated prior to LDK 0.0.119, no such argument existed,
		 * however this field may still be filled in if such data is available.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public byte[] channel_keys_id;
		internal SpendableOutputDescriptor_StaticOutput(long ptr) : base(null, ptr) {
			long outpoint = bindings.LDKSpendableOutputDescriptor_StaticOutput_get_outpoint(ptr);
			org.ldk.structs.OutPoint outpoint_hu_conv = null; if (outpoint < 0 || outpoint > 4096) { outpoint_hu_conv = new org.ldk.structs.OutPoint(null, outpoint); }
			if (outpoint_hu_conv != null) { outpoint_hu_conv.ptrs_to.AddLast(this); };
			this.outpoint = outpoint_hu_conv;
			long output = bindings.LDKSpendableOutputDescriptor_StaticOutput_get_output(ptr);
			TxOut output_conv = new TxOut(null, output);
			this.output = output_conv;
			long channel_keys_id = bindings.LDKSpendableOutputDescriptor_StaticOutput_get_channel_keys_id(ptr);
			byte[] channel_keys_id_conv = InternalUtils.decodeUint8Array(channel_keys_id);
			this.channel_keys_id = channel_keys_id_conv;
		}
	}
	/** A SpendableOutputDescriptor of type DelayedPaymentOutput */
	public class SpendableOutputDescriptor_DelayedPaymentOutput : SpendableOutputDescriptor {
		public org.ldk.structs.DelayedPaymentOutputDescriptor delayed_payment_output;
		internal SpendableOutputDescriptor_DelayedPaymentOutput(long ptr) : base(null, ptr) {
			long delayed_payment_output = bindings.LDKSpendableOutputDescriptor_DelayedPaymentOutput_get_delayed_payment_output(ptr);
			org.ldk.structs.DelayedPaymentOutputDescriptor delayed_payment_output_hu_conv = null; if (delayed_payment_output < 0 || delayed_payment_output > 4096) { delayed_payment_output_hu_conv = new org.ldk.structs.DelayedPaymentOutputDescriptor(null, delayed_payment_output); }
			if (delayed_payment_output_hu_conv != null) { delayed_payment_output_hu_conv.ptrs_to.AddLast(this); };
			this.delayed_payment_output = delayed_payment_output_hu_conv;
		}
	}
	/** A SpendableOutputDescriptor of type StaticPaymentOutput */
	public class SpendableOutputDescriptor_StaticPaymentOutput : SpendableOutputDescriptor {
		public org.ldk.structs.StaticPaymentOutputDescriptor static_payment_output;
		internal SpendableOutputDescriptor_StaticPaymentOutput(long ptr) : base(null, ptr) {
			long static_payment_output = bindings.LDKSpendableOutputDescriptor_StaticPaymentOutput_get_static_payment_output(ptr);
			org.ldk.structs.StaticPaymentOutputDescriptor static_payment_output_hu_conv = null; if (static_payment_output < 0 || static_payment_output > 4096) { static_payment_output_hu_conv = new org.ldk.structs.StaticPaymentOutputDescriptor(null, static_payment_output); }
			if (static_payment_output_hu_conv != null) { static_payment_output_hu_conv.ptrs_to.AddLast(this); };
			this.static_payment_output = static_payment_output_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.SpendableOutputDescriptor_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the SpendableOutputDescriptor
	 */
	public org.ldk.structs.SpendableOutputDescriptor clone() {
		long ret = bindings.SpendableOutputDescriptor_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendableOutputDescriptor ret_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new StaticOutput-variant SpendableOutputDescriptor
	 */
	public static org.ldk.structs.SpendableOutputDescriptor static_output(org.ldk.structs.OutPoint outpoint, org.ldk.structs.TxOut output, byte[] channel_keys_id) {
		long ret = bindings.SpendableOutputDescriptor_static_output(outpoint.ptr, output.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(channel_keys_id, 32)));
		GC.KeepAlive(outpoint);
		GC.KeepAlive(output);
		GC.KeepAlive(channel_keys_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendableOutputDescriptor ret_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DelayedPaymentOutput-variant SpendableOutputDescriptor
	 */
	public static org.ldk.structs.SpendableOutputDescriptor delayed_payment_output(org.ldk.structs.DelayedPaymentOutputDescriptor a) {
		long ret = bindings.SpendableOutputDescriptor_delayed_payment_output(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendableOutputDescriptor ret_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new StaticPaymentOutput-variant SpendableOutputDescriptor
	 */
	public static org.ldk.structs.SpendableOutputDescriptor static_payment_output(org.ldk.structs.StaticPaymentOutputDescriptor a) {
		long ret = bindings.SpendableOutputDescriptor_static_payment_output(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendableOutputDescriptor ret_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the SpendableOutputDescriptor.
	 */
	public long hash() {
		long ret = bindings.SpendableOutputDescriptor_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two SpendableOutputDescriptors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.SpendableOutputDescriptor b) {
		bool ret = bindings.SpendableOutputDescriptor_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is SpendableOutputDescriptor)) return false;
		return this.eq((SpendableOutputDescriptor)o);
	}
	/**
	 * Serialize the SpendableOutputDescriptor object into a byte array which can be read by SpendableOutputDescriptor_read
	 */
	public byte[] write() {
		long ret = bindings.SpendableOutputDescriptor_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a SpendableOutputDescriptor from a byte array, created by SpendableOutputDescriptor_write
	 */
	public static org.ldk.structs.Result_SpendableOutputDescriptorDecodeErrorZ read(byte[] ser) {
		long ret = bindings.SpendableOutputDescriptor_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpendableOutputDescriptorDecodeErrorZ ret_hu_conv = Result_SpendableOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Returns the outpoint of the spendable output.
	 */
	public org.ldk.structs.OutPoint spendable_outpoint() {
		long ret = bindings.SpendableOutputDescriptor_spendable_outpoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
