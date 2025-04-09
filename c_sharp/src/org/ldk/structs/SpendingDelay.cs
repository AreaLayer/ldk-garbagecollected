using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * A `enum` signalling to the [`OutputSweeper`] that it should delay spending an output until a
 * future block height is reached.
 */
public class SpendingDelay : CommonBase {
	protected SpendingDelay(object _dummy, long ptr) : base(ptr) { }
	~SpendingDelay() {
		if (ptr != 0) { bindings.SpendingDelay_free(ptr); }
	}

	internal static SpendingDelay constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKSpendingDelay_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new SpendingDelay_Relative(ptr);
			case 1: return new SpendingDelay_Absolute(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A SpendingDelay of type Relative */
	public class SpendingDelay_Relative : SpendingDelay {
		/**
		 * The number of blocks until we'll generate and broadcast the spending transaction.
		 */
		public int num_blocks;
		internal SpendingDelay_Relative(long ptr) : base(null, ptr) {
			this.num_blocks = bindings.LDKSpendingDelay_Relative_get_num_blocks(ptr);
		}
	}
	/** A SpendingDelay of type Absolute */
	public class SpendingDelay_Absolute : SpendingDelay {
		/**
		 * The height at which we'll generate and broadcast the spending transaction.
		 */
		public int height;
		internal SpendingDelay_Absolute(long ptr) : base(null, ptr) {
			this.height = bindings.LDKSpendingDelay_Absolute_get_height(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = bindings.SpendingDelay_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the SpendingDelay
	 */
	public org.ldk.structs.SpendingDelay clone() {
		long ret = bindings.SpendingDelay_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendingDelay ret_hu_conv = org.ldk.structs.SpendingDelay.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Relative-variant SpendingDelay
	 */
	public static org.ldk.structs.SpendingDelay relative(int num_blocks) {
		long ret = bindings.SpendingDelay_relative(num_blocks);
		GC.KeepAlive(num_blocks);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendingDelay ret_hu_conv = org.ldk.structs.SpendingDelay.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Absolute-variant SpendingDelay
	 */
	public static org.ldk.structs.SpendingDelay absolute(int height) {
		long ret = bindings.SpendingDelay_absolute(height);
		GC.KeepAlive(height);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendingDelay ret_hu_conv = org.ldk.structs.SpendingDelay.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
