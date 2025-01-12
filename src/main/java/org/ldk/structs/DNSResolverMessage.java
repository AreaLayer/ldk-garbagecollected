package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum containing the possible onion messages which are used uses to request and receive
 * DNSSEC proofs.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class DNSResolverMessage extends CommonBase {
	private DNSResolverMessage(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.DNSResolverMessage_free(ptr); }
	}
	static DNSResolverMessage constr_from_ptr(long ptr) {
		bindings.LDKDNSResolverMessage raw_val = bindings.LDKDNSResolverMessage_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKDNSResolverMessage.DNSSECQuery.class) {
			return new DNSSECQuery(ptr, (bindings.LDKDNSResolverMessage.DNSSECQuery)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKDNSResolverMessage.DNSSECProof.class) {
			return new DNSSECProof(ptr, (bindings.LDKDNSResolverMessage.DNSSECProof)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * A query requesting a DNSSEC proof
	 */
	public final static class DNSSECQuery extends DNSResolverMessage {
		public final org.ldk.structs.DNSSECQuery dnssec_query;
		private DNSSECQuery(long ptr, bindings.LDKDNSResolverMessage.DNSSECQuery obj) {
			super(null, ptr);
			long dnssec_query = obj.dnssec_query;
			org.ldk.structs.DNSSECQuery dnssec_query_hu_conv = null; if (dnssec_query < 0 || dnssec_query > 4096) { dnssec_query_hu_conv = new org.ldk.structs.DNSSECQuery(null, dnssec_query); }
			if (dnssec_query_hu_conv != null) { dnssec_query_hu_conv.ptrs_to.add(this); };
			this.dnssec_query = dnssec_query_hu_conv;
		}
	}
	/**
	 * A response containing a DNSSEC proof
	 */
	public final static class DNSSECProof extends DNSResolverMessage {
		public final org.ldk.structs.DNSSECProof dnssec_proof;
		private DNSSECProof(long ptr, bindings.LDKDNSResolverMessage.DNSSECProof obj) {
			super(null, ptr);
			long dnssec_proof = obj.dnssec_proof;
			org.ldk.structs.DNSSECProof dnssec_proof_hu_conv = null; if (dnssec_proof < 0 || dnssec_proof > 4096) { dnssec_proof_hu_conv = new org.ldk.structs.DNSSECProof(null, dnssec_proof); }
			if (dnssec_proof_hu_conv != null) { dnssec_proof_hu_conv.ptrs_to.add(this); };
			this.dnssec_proof = dnssec_proof_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.DNSResolverMessage_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the DNSResolverMessage
	 */
	public DNSResolverMessage clone() {
		long ret = bindings.DNSResolverMessage_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverMessage ret_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DNSSECQuery-variant DNSResolverMessage
	 */
	public static DNSResolverMessage dnssecquery(org.ldk.structs.DNSSECQuery a) {
		long ret = bindings.DNSResolverMessage_dnssecquery(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverMessage ret_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DNSSECProof-variant DNSResolverMessage
	 */
	public static DNSResolverMessage dnssecproof(org.ldk.structs.DNSSECProof a) {
		long ret = bindings.DNSResolverMessage_dnssecproof(a.ptr);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DNSResolverMessage ret_hu_conv = org.ldk.structs.DNSResolverMessage.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the DNSResolverMessage.
	 */
	public long hash() {
		long ret = bindings.DNSResolverMessage_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two DNSResolverMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.DNSResolverMessage b) {
		boolean ret = bindings.DNSResolverMessage_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof DNSResolverMessage)) return false;
		return this.eq((DNSResolverMessage)o);
	}
	/**
	 * Serialize the DNSResolverMessage object into a byte array which can be read by DNSResolverMessage_read
	 */
	public byte[] write() {
		byte[] ret = bindings.DNSResolverMessage_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a DNSResolverMessage from a byte array, created by DNSResolverMessage_write
	 */
	public static Result_DNSResolverMessageDecodeErrorZ read(byte[] ser, long arg) {
		long ret = bindings.DNSResolverMessage_read(ser, arg);
		Reference.reachabilityFence(ser);
		Reference.reachabilityFence(arg);
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
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
