using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ : CommonBase {
	internal ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ(object _dummy, long ptr) : base(ptr) { }
	~ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ() {
		if (ptr != 0) { bindings.C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ_free(ptr); }
	}

	/**
	 * 
	 */
	public org.ldk.structs.RawBolt11Invoice get_a() {
		long ret = bindings.C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ_get_a(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RawBolt11Invoice ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RawBolt11Invoice(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public byte[] get_b() {
		long ret = bindings.C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ_get_b(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public org.ldk.structs.Bolt11InvoiceSignature get_c() {
		long ret = bindings.C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ_get_c(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt11InvoiceSignature ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt11InvoiceSignature(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ clone() {
		long ret = bindings.C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ ret_hu_conv = new ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ from the contained elements.
	 */
	public static org.ldk.structs.ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ of(org.ldk.structs.RawBolt11Invoice a, byte[] b, org.ldk.structs.Bolt11InvoiceSignature c) {
		long ret = bindings.C3Tuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ_new(a.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(b, 32)), c.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		GC.KeepAlive(c);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ ret_hu_conv = new ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
