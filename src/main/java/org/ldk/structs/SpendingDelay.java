package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A `enum` signalling to the [`OutputSweeper`] that it should delay spending an output until a
 * future block height is reached.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class SpendingDelay extends CommonBase {
	private SpendingDelay(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.SpendingDelay_free(ptr); }
	}
	static SpendingDelay constr_from_ptr(long ptr) {
		bindings.LDKSpendingDelay raw_val = bindings.LDKSpendingDelay_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKSpendingDelay.Relative.class) {
			return new Relative(ptr, (bindings.LDKSpendingDelay.Relative)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKSpendingDelay.Absolute.class) {
			return new Absolute(ptr, (bindings.LDKSpendingDelay.Absolute)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A relative delay indicating we shouldn't spend the output before `cur_height + num_blocks`
	 * is reached.
	 */
	public final static class Relative extends SpendingDelay {
		/**
		 * The number of blocks until we'll generate and broadcast the spending transaction.
		*/
		public final int num_blocks;
		private Relative(long ptr, bindings.LDKSpendingDelay.Relative obj) {
			super(null, ptr);
			this.num_blocks = obj.num_blocks;
		}
	}
	/**
	 * An absolute delay indicating we shouldn't spend the output before `height` is reached.
	 */
	public final static class Absolute extends SpendingDelay {
		/**
		 * The height at which we'll generate and broadcast the spending transaction.
		*/
		public final int height;
		private Absolute(long ptr, bindings.LDKSpendingDelay.Absolute obj) {
			super(null, ptr);
			this.height = obj.height;
		}
	}
	long clone_ptr() {
		long ret = bindings.SpendingDelay_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the SpendingDelay
	 */
	public SpendingDelay clone() {
		long ret = bindings.SpendingDelay_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendingDelay ret_hu_conv = org.ldk.structs.SpendingDelay.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Relative-variant SpendingDelay
	 */
	public static SpendingDelay relative(int num_blocks) {
		long ret = bindings.SpendingDelay_relative(num_blocks);
		Reference.reachabilityFence(num_blocks);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendingDelay ret_hu_conv = org.ldk.structs.SpendingDelay.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Absolute-variant SpendingDelay
	 */
	public static SpendingDelay absolute(int height) {
		long ret = bindings.SpendingDelay_absolute(height);
		Reference.reachabilityFence(height);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpendingDelay ret_hu_conv = org.ldk.structs.SpendingDelay.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
