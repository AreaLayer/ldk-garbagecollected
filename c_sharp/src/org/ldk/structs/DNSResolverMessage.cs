using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum containing the possible onion messages which are used uses to request and receive
 * DNSSEC proofs.
 */
public class DNSResolverMessage : CommonBase {
	protected DNSResolverMessage(object _dummy, long ptr) : base(ptr) { }
	~DNSResolverMessage() {
		if (ptr != 0) { bindings.DNSResolverMessage_free(ptr); }
	}

	internal static DNSResolverMessage constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKDNSResolverMessage_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new DNSResolverMessage_DNSSECQuery(ptr);
			case 1: return new DNSResolverMessage_DNSSECProof(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A DNSResolverMessage of type DNSSECQuery */
	public class DNSResolverMessage_DNSSECQuery : DNSResolverMessage {
		public DNSSECQuery dnssec_query;
		internal DNSResolverMessage_DNSSECQuery(long ptr) : base(null, ptr) {
			long dnssec_query = bindings.LDKDNSResolverMessage_DNSSECQuery_get_dnssec_query(ptr);
			org.ldk.structs.DNSSECQuery dnssec_query_hu_conv = null; if (dnssec_query < 0 || dnssec_query > 4096) { dnssec_query_hu_conv = new org.ldk.structs.DNSSECQuery(null, dnssec_query); }
			if (dnssec_query_hu_conv != null) { dnssec_query_hu_conv.ptrs_to.AddLast(this); };
			this.dnssec_query = dnssec_query_hu_conv;
		}
	}
	/** A DNSResolverMessage of type DNSSECProof */
	public class DNSResolverMessage_DNSSECProof : DNSResolverMessage {
		public DNSSECProof dnssec_proof;
		internal DNSResolverMessage_DNSSECProof(long ptr) : base(null, ptr) {
			long dnssec_proof = bindings.LDKDNSResolverMessage_DNSSECProof_get_dnssec_proof(ptr);
			org.ldk.structs.DNSSECProof dnssec_proof_hu_conv = null; if (dnssec_proof < 0 || dnssec_proof > 4096) { dnssec_proof_hu_conv = new org.ldk.structs.DNSSECProof(null, dnssec_proof); }
			if (dnssec_proof_hu_conv != null) { dnssec_proof_hu_conv.ptrs_to.AddLast(this); };
			this.dnssec_proof = dnssec_proof_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.DNSResolverMessage_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the DNSResolverMessage
	 */
	public DNSResolverMessage clone() {
		long ret = bindings.DNSResolverMessage_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverMessage ret_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DNSSECQuery-variant DNSResolverMessage
	 */
	public static DNSResolverMessage dnssecquery(org.ldk.structs.DNSSECQuery a) {
		long ret = bindings.DNSResolverMessage_dnssecquery(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverMessage ret_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DNSSECProof-variant DNSResolverMessage
	 */
	public static DNSResolverMessage dnssecproof(org.ldk.structs.DNSSECProof a) {
		long ret = bindings.DNSResolverMessage_dnssecproof(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverMessage ret_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the DNSResolverMessage.
	 */
	public long hash() {
		long ret = bindings.DNSResolverMessage_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two DNSResolverMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.DNSResolverMessage b) {
		bool ret = bindings.DNSResolverMessage_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is DNSResolverMessage)) return false;
		return this.eq((DNSResolverMessage)o);
	}
	/**
	 * Serialize the DNSResolverMessage object into a byte array which can be read by DNSResolverMessage_read
	 */
	public byte[] write() {
		long ret = bindings.DNSResolverMessage_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a DNSResolverMessage from a byte array, created by DNSResolverMessage_write
	 */
	public static Result_DNSResolverMessageDecodeErrorZ read(byte[] ser, long arg) {
		long ret = bindings.DNSResolverMessage_read(InternalUtils.encodeUint8Array(ser), arg);
		GC.KeepAlive(ser);
		GC.KeepAlive(arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DNSResolverMessageDecodeErrorZ ret_hu_conv = Result_DNSResolverMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new OnionMessageContents which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned OnionMessageContents must be freed before this_arg is
	 */
	public OnionMessageContents as_OnionMessageContents() {
		long ret = bindings.DNSResolverMessage_as_OnionMessageContents(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
