using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`NodeIdLookUp`] that always returns `None`.
 */
public class EmptyNodeIdLookUp : CommonBase {
	internal EmptyNodeIdLookUp(object _dummy, long ptr) : base(ptr) { }
	~EmptyNodeIdLookUp() {
		if (ptr != 0) { bindings.EmptyNodeIdLookUp_free(ptr); }
	}

	/**
	 * Constructs a new EmptyNodeIdLookUp given each field
	 */
	public static EmptyNodeIdLookUp of() {
		long ret = bindings.EmptyNodeIdLookUp_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.EmptyNodeIdLookUp ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.EmptyNodeIdLookUp(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new NodeIdLookUp which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned NodeIdLookUp must be freed before this_arg is
	 */
	public NodeIdLookUp as_NodeIdLookUp() {
		long ret = bindings.EmptyNodeIdLookUp_as_NodeIdLookUp(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		NodeIdLookUp ret_hu_conv = new NodeIdLookUp(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
