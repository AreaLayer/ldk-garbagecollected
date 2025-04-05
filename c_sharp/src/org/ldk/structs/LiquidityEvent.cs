using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An event which you should probably take some action in response to.
 */
public class LiquidityEvent : CommonBase {
	protected LiquidityEvent(object _dummy, long ptr) : base(ptr) { }
	~LiquidityEvent() {
		if (ptr != 0) { bindings.LiquidityEvent_free(ptr); }
	}

	internal static LiquidityEvent constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLiquidityEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LiquidityEvent_LSPS0Client(ptr);
			case 1: return new LiquidityEvent_LSPS1Client(ptr);
			case 2: return new LiquidityEvent_LSPS2Client(ptr);
			case 3: return new LiquidityEvent_LSPS2Service(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LiquidityEvent of type LSPS0Client */
	public class LiquidityEvent_LSPS0Client : LiquidityEvent {
		internal LiquidityEvent_LSPS0Client(long ptr) : base(null, ptr) {
		}
	}
	/** A LiquidityEvent of type LSPS1Client */
	public class LiquidityEvent_LSPS1Client : LiquidityEvent {
		internal LiquidityEvent_LSPS1Client(long ptr) : base(null, ptr) {
		}
	}
	/** A LiquidityEvent of type LSPS2Client */
	public class LiquidityEvent_LSPS2Client : LiquidityEvent {
		internal LiquidityEvent_LSPS2Client(long ptr) : base(null, ptr) {
		}
	}
	/** A LiquidityEvent of type LSPS2Service */
	public class LiquidityEvent_LSPS2Service : LiquidityEvent {
		internal LiquidityEvent_LSPS2Service(long ptr) : base(null, ptr) {
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LiquidityEvent_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LiquidityEvent
	 */
	public org.ldk.structs.LiquidityEvent clone() {
		long ret = bindings.LiquidityEvent_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS0Client-variant LiquidityEvent
	 */
	public static org.ldk.structs.LiquidityEvent lsps0_client(org.ldk.structs.LSPS0ClientEvent a) {
		long ret = bindings.LiquidityEvent_lsps0_client(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS1Client-variant LiquidityEvent
	 */
	public static org.ldk.structs.LiquidityEvent lsps1_client(org.ldk.structs.LSPS1ClientEvent a) {
		long ret = bindings.LiquidityEvent_lsps1_client(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS2Client-variant LiquidityEvent
	 */
	public static org.ldk.structs.LiquidityEvent lsps2_client(org.ldk.structs.LSPS2ClientEvent a) {
		long ret = bindings.LiquidityEvent_lsps2_client(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS2Service-variant LiquidityEvent
	 */
	public static org.ldk.structs.LiquidityEvent lsps2_service(org.ldk.structs.LSPS2ServiceEvent a) {
		long ret = bindings.LiquidityEvent_lsps2_service(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LiquidityEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LiquidityEvent b) {
		bool ret = bindings.LiquidityEvent_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LiquidityEvent)) return false;
		return this.eq((LiquidityEvent)o);
	}
}
} } }
