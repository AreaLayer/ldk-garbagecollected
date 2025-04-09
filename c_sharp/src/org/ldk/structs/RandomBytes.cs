using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An implementation of [`EntropySource`] using ChaCha20.
 */
public class RandomBytes : CommonBase {
	internal RandomBytes(object _dummy, long ptr) : base(ptr) { }
	~RandomBytes() {
		if (ptr != 0) { bindings.RandomBytes_free(ptr); }
	}

	/**
	 * Creates a new instance using the given seed.
	 */
	public static org.ldk.structs.RandomBytes of(byte[] seed) {
		long ret = bindings.RandomBytes_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(seed, 32)));
		GC.KeepAlive(seed);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RandomBytes ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RandomBytes(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new EntropySource which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned EntropySource must be freed before this_arg is
	 */
	public org.ldk.structs.EntropySource as_EntropySource() {
		long ret = bindings.RandomBytes_as_EntropySource(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		EntropySource ret_hu_conv = new EntropySource(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
