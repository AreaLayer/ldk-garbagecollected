using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An error type that may be returned to LDK in order to safely abort event handling if it can't
 * currently succeed (e.g., due to a persistence failure).
 * 
 * Depending on the type, LDK may ensure the event is persisted and will eventually be replayed.
 * Please refer to the documentation of each [`Event`] variant for more details.
 */
public class ReplayEvent : CommonBase {
	internal ReplayEvent(object _dummy, long ptr) : base(ptr) { }
	~ReplayEvent() {
		if (ptr != 0) { bindings.ReplayEvent_free(ptr); }
	}

	/**
	 * Constructs a new ReplayEvent given each field
	 */
	public static ReplayEvent of() {
		long ret = bindings.ReplayEvent_new();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReplayEvent ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReplayEvent(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ReplayEvent_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ReplayEvent
	 */
	public ReplayEvent clone() {
		long ret = bindings.ReplayEvent_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReplayEvent ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReplayEvent(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
