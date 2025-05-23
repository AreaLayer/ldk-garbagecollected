using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A reference to a transaction output.
 * 
 * Differs from bitcoin::transaction::OutPoint as the index is a u16 instead of u32
 * due to LN's restrictions on index values. Should reduce (possibly) unsafe conversions this way.
 */
public class OutPoint : CommonBase {
	internal OutPoint(object _dummy, long ptr) : base(ptr) { }
	~OutPoint() {
		if (ptr != 0) { bindings.OutPoint_free(ptr); }
	}

	/**
	 * The referenced transaction's txid.
	 */
	public byte[] get_txid() {
		long ret = bindings.OutPoint_get_txid(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The referenced transaction's txid.
	 */
	public void set_txid(byte[] val) {
		bindings.OutPoint_set_txid(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The index of the referenced output in its transaction's vout.
	 */
	public short get_index() {
		short ret = bindings.OutPoint_get_index(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The index of the referenced output in its transaction's vout.
	 */
	public void set_index(short val) {
		bindings.OutPoint_set_index(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new OutPoint given each field
	 */
	public static org.ldk.structs.OutPoint of(byte[] txid_arg, short index_arg) {
		long ret = bindings.OutPoint_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(txid_arg, 32)), index_arg);
		GC.KeepAlive(txid_arg);
		GC.KeepAlive(index_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.OutPoint_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OutPoint
	 */
	public org.ldk.structs.OutPoint clone() {
		long ret = bindings.OutPoint_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two OutPoints contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.OutPoint b) {
		bool ret = bindings.OutPoint_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is OutPoint)) return false;
		return this.eq((OutPoint)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the OutPoint.
	 */
	public long hash() {
		long ret = bindings.OutPoint_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Get the string representation of a OutPoint object
	 */
	public string to_str() {
		long ret = bindings.OutPoint_to_str(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * Serialize the OutPoint object into a byte array which can be read by OutPoint_read
	 */
	public byte[] write() {
		long ret = bindings.OutPoint_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a OutPoint from a byte array, created by OutPoint_write
	 */
	public static org.ldk.structs.Result_OutPointDecodeErrorZ read(byte[] ser) {
		long ret = bindings.OutPoint_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutPointDecodeErrorZ ret_hu_conv = Result_OutPointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
