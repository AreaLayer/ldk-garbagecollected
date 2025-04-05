package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A (de-)serializable LSPS message allowing to be sent over the wire.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPSMessage extends CommonBase {
	private LSPSMessage(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPSMessage_free(ptr); }
	}
	static LSPSMessage constr_from_ptr(long ptr) {
		bindings.LDKLSPSMessage raw_val = bindings.LDKLSPSMessage_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKLSPSMessage.Invalid.class) {
			return new Invalid(ptr, (bindings.LDKLSPSMessage.Invalid)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPSMessage.LSPS0.class) {
			return new LSPS0(ptr, (bindings.LDKLSPSMessage.LSPS0)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPSMessage.LSPS1.class) {
			return new LSPS1(ptr, (bindings.LDKLSPSMessage.LSPS1)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKLSPSMessage.LSPS2.class) {
			return new LSPS2(ptr, (bindings.LDKLSPSMessage.LSPS2)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * An invalid variant.
	 */
	public final static class Invalid extends LSPSMessage {
		public final org.ldk.structs.LSPSResponseError invalid;
		private Invalid(long ptr, bindings.LDKLSPSMessage.Invalid obj) {
			super(null, ptr);
			long invalid = obj.invalid;
			org.ldk.structs.LSPSResponseError invalid_hu_conv = null; if (invalid < 0 || invalid > 4096) { invalid_hu_conv = new org.ldk.structs.LSPSResponseError(null, invalid); }
			if (invalid_hu_conv != null) { invalid_hu_conv.ptrs_to.add(this); };
			this.invalid = invalid_hu_conv;
		}
	}
	/**
	 * An LSPS0 message.
	 */
	public final static class LSPS0 extends LSPSMessage {
		private LSPS0(long ptr, bindings.LDKLSPSMessage.LSPS0 obj) {
			super(null, ptr);
		}
	}
	/**
	 * An LSPS1 message.
	 */
	public final static class LSPS1 extends LSPSMessage {
		private LSPS1(long ptr, bindings.LDKLSPSMessage.LSPS1 obj) {
			super(null, ptr);
		}
	}
	/**
	 * An LSPS2 message.
	 */
	public final static class LSPS2 extends LSPSMessage {
		private LSPS2(long ptr, bindings.LDKLSPSMessage.LSPS2 obj) {
			super(null, ptr);
		}
	}
	long clone_ptr() {
		long ret = bindings.LSPSMessage_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSMessage
	 */
	public LSPSMessage clone() {
		long ret = bindings.LSPSMessage_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Invalid-variant LSPSMessage
	 */
	public static LSPSMessage invalid(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPSMessage_invalid(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS0-variant LSPSMessage
	 */
	public static LSPSMessage lsps0(org.ldk.structs.LSPS0Message a) {
		long ret = bindings.LSPSMessage_lsps0(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS1-variant LSPSMessage
	 */
	public static LSPSMessage lsps1(org.ldk.structs.LSPS1Message a) {
		long ret = bindings.LSPSMessage_lsps1(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS2-variant LSPSMessage
	 */
	public static LSPSMessage lsps2(org.ldk.structs.LSPS2Message a) {
		long ret = bindings.LSPSMessage_lsps2(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.LSPSMessage b) {
		boolean ret = bindings.LSPSMessage_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPSMessage)) return false;
		return this.eq((LSPSMessage)o);
	}
}
