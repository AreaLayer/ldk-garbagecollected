package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An implementation of [`EntropySource`] using ChaCha20.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class RandomBytes extends CommonBase {
	RandomBytes(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.RandomBytes_free(ptr); }
	}

	/**
	 * Creates a new instance using the given seed.
	 */
	public static RandomBytes of(byte[] seed) {
		long ret = bindings.RandomBytes_new(InternalUtils.check_arr_len(seed, 32));
		Reference.reachabilityFence(seed);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RandomBytes ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RandomBytes(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new EntropySource which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned EntropySource must be freed before this_arg is
	 */
	public EntropySource as_EntropySource() {
		long ret = bindings.RandomBytes_as_EntropySource(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		EntropySource ret_hu_conv = new EntropySource(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
