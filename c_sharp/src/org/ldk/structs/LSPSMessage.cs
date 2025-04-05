using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * A (de-)serializable LSPS message allowing to be sent over the wire.
 */
public class LSPSMessage : CommonBase {
	protected LSPSMessage(object _dummy, long ptr) : base(ptr) { }
	~LSPSMessage() {
		if (ptr != 0) { bindings.LSPSMessage_free(ptr); }
	}

	internal static LSPSMessage constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKLSPSMessage_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new LSPSMessage_Invalid(ptr);
			case 1: return new LSPSMessage_LSPS0(ptr);
			case 2: return new LSPSMessage_LSPS1(ptr);
			case 3: return new LSPSMessage_LSPS2(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A LSPSMessage of type Invalid */
	public class LSPSMessage_Invalid : LSPSMessage {
		public org.ldk.structs.LSPSResponseError invalid;
		internal LSPSMessage_Invalid(long ptr) : base(null, ptr) {
			long invalid = bindings.LDKLSPSMessage_Invalid_get_invalid(ptr);
			org.ldk.structs.LSPSResponseError invalid_hu_conv = null; if (invalid < 0 || invalid > 4096) { invalid_hu_conv = new org.ldk.structs.LSPSResponseError(null, invalid); }
			if (invalid_hu_conv != null) { invalid_hu_conv.ptrs_to.AddLast(this); };
			this.invalid = invalid_hu_conv;
		}
	}
	/** A LSPSMessage of type LSPS0 */
	public class LSPSMessage_LSPS0 : LSPSMessage {
		internal LSPSMessage_LSPS0(long ptr) : base(null, ptr) {
		}
	}
	/** A LSPSMessage of type LSPS1 */
	public class LSPSMessage_LSPS1 : LSPSMessage {
		internal LSPSMessage_LSPS1(long ptr) : base(null, ptr) {
		}
	}
	/** A LSPSMessage of type LSPS2 */
	public class LSPSMessage_LSPS2 : LSPSMessage {
		internal LSPSMessage_LSPS2(long ptr) : base(null, ptr) {
		}
	}
	internal long clone_ptr() {
		long ret = bindings.LSPSMessage_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPSMessage
	 */
	public org.ldk.structs.LSPSMessage clone() {
		long ret = bindings.LSPSMessage_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Invalid-variant LSPSMessage
	 */
	public static org.ldk.structs.LSPSMessage invalid(org.ldk.structs.LSPSResponseError a) {
		long ret = bindings.LSPSMessage_invalid(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS0-variant LSPSMessage
	 */
	public static org.ldk.structs.LSPSMessage lsps0(org.ldk.structs.LSPS0Message a) {
		long ret = bindings.LSPSMessage_lsps0(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS1-variant LSPSMessage
	 */
	public static org.ldk.structs.LSPSMessage lsps1(org.ldk.structs.LSPS1Message a) {
		long ret = bindings.LSPSMessage_lsps1(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LSPS2-variant LSPSMessage
	 */
	public static org.ldk.structs.LSPSMessage lsps2(org.ldk.structs.LSPS2Message a) {
		long ret = bindings.LSPSMessage_lsps2(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSMessage ret_hu_conv = org.ldk.structs.LSPSMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPSMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.LSPSMessage b) {
		bool ret = bindings.LSPSMessage_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPSMessage)) return false;
		return this.eq((LSPSMessage)o);
	}
}
} } }
