package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An event which you should probably take some action in response to.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LiquidityEvent extends CommonBase {
	private LiquidityEvent(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LiquidityEvent_free(ptr); }
	}
	static LiquidityEvent constr_from_ptr(long ptr) {
		bindings.LDKLiquidityEvent raw_val = bindings.LDKLiquidityEvent_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLiquidityEvent.LSPS0Client.class) {
			return new LSPS0Client(ptr, (bindings.LDKLiquidityEvent.LSPS0Client)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLiquidityEvent.LSPS1Client.class) {
			return new LSPS1Client(ptr, (bindings.LDKLiquidityEvent.LSPS1Client)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLiquidityEvent.LSPS2Client.class) {
			return new LSPS2Client(ptr, (bindings.LDKLiquidityEvent.LSPS2Client)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLiquidityEvent.LSPS2Service.class) {
			return new LSPS2Service(ptr, (bindings.LDKLiquidityEvent.LSPS2Service)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * An LSPS0 client event.
	 */
	public final static class LSPS0Client extends LiquidityEvent {
		private LSPS0Client(long ptr, bindings.LDKLiquidityEvent.LSPS0Client obj) {
			super(null, ptr);
		}
	}
	/**
	 * An LSPS1 (Channel Request) client event.
	 */
	public final static class LSPS1Client extends LiquidityEvent {
		private LSPS1Client(long ptr, bindings.LDKLiquidityEvent.LSPS1Client obj) {
			super(null, ptr);
		}
	}
	/**
	 * An LSPS2 (JIT Channel) client event.
	 */
	public final static class LSPS2Client extends LiquidityEvent {
		private LSPS2Client(long ptr, bindings.LDKLiquidityEvent.LSPS2Client obj) {
			super(null, ptr);
		}
	}
	/**
	 * An LSPS2 (JIT Channel) server event.
	 */
	public final static class LSPS2Service extends LiquidityEvent {
		private LSPS2Service(long ptr, bindings.LDKLiquidityEvent.LSPS2Service obj) {
			super(null, ptr);
		}
	}
	long clone_ptr() {
		long ret = bindings.LiquidityEvent_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LiquidityEvent
	 */
	public LiquidityEvent clone() {
		long ret = bindings.LiquidityEvent_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS0Client-variant LiquidityEvent
	 */
	public static LiquidityEvent lsps0_client(org.ldk.structs.LSPS0ClientEvent a) {
		long ret = bindings.LiquidityEvent_lsps0_client(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS1Client-variant LiquidityEvent
	 */
	public static LiquidityEvent lsps1_client(org.ldk.structs.LSPS1ClientEvent a) {
		long ret = bindings.LiquidityEvent_lsps1_client(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS2Client-variant LiquidityEvent
	 */
	public static LiquidityEvent lsps2_client(org.ldk.structs.LSPS2ClientEvent a) {
		long ret = bindings.LiquidityEvent_lsps2_client(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS2Service-variant LiquidityEvent
	 */
	public static LiquidityEvent lsps2_service(org.ldk.structs.LSPS2ServiceEvent a) {
		long ret = bindings.LiquidityEvent_lsps2_service(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LiquidityEvent ret_hu_conv = org.ldk.structs.LiquidityEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LiquidityEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LiquidityEvent b) {
		boolean ret = bindings.LiquidityEvent_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LiquidityEvent)) return false;
		return this.eq((LiquidityEvent)o);
	}
}
