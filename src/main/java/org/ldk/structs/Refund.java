package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A `Refund` is a request to send an [`Bolt12Invoice`] without a preceding [`Offer`].
 * 
 * Typically, after an invoice is paid, the recipient may publish a refund allowing the sender to
 * recoup their funds. A refund may be used more generally as an \"offer for money\", such as with a
 * bitcoin ATM.
 * 
 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
 * [`Offer`]: crate::offers::offer::Offer
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Refund extends CommonBase {
	Refund(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Refund_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.Refund_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Refund
	 */
	public Refund clone() {
		long ret = bindings.Refund_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Refund ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Refund(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * A complete description of the purpose of the refund. Intended to be displayed to the user
	 * but with the caveat that it has not been verified in any way.
	 */
	public PrintableString description() {
		long ret = bindings.Refund_description(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Duration since the Unix epoch when an invoice should no longer be sent.
	 * 
	 * If `None`, the refund does not expire.
	 */
	public Option_u64Z absolute_expiry() {
		long ret = bindings.Refund_absolute_expiry(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Whether the refund has expired.
	 */
	public boolean is_expired() {
		boolean ret = bindings.Refund_is_expired(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Whether the refund has expired given the duration since the Unix epoch.
	 */
	public boolean is_expired_no_std(long duration_since_epoch) {
		boolean ret = bindings.Refund_is_expired_no_std(this.ptr, duration_since_epoch);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(duration_since_epoch);
		return ret;
	}

	/**
	 * The issuer of the refund, possibly beginning with `user@domain` or `domain`. Intended to be
	 * displayed to the user but with the caveat that it has not been verified in any way.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public PrintableString issuer() {
		long ret = bindings.Refund_issuer(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Paths to the sender originating from publicly reachable nodes. Blinded paths provide sender
	 * privacy by obfuscating its node id.
	 */
	public BlindedMessagePath[] paths() {
		long[] ret = bindings.Refund_paths(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_20_len = ret.length;
		BlindedMessagePath[] ret_conv_20_arr = new BlindedMessagePath[ret_conv_20_len];
		for (int u = 0; u < ret_conv_20_len; u++) {
			long ret_conv_20 = ret[u];
			org.ldk.structs.BlindedMessagePath ret_conv_20_hu_conv = null; if (ret_conv_20 < 0 || ret_conv_20 > 4096) { ret_conv_20_hu_conv = new org.ldk.structs.BlindedMessagePath(null, ret_conv_20); }
			if (ret_conv_20_hu_conv != null) { ret_conv_20_hu_conv.ptrs_to.add(this); };
			ret_conv_20_arr[u] = ret_conv_20_hu_conv;
		}
		return ret_conv_20_arr;
	}

	/**
	 * An unpredictable series of bytes, typically containing information about the derivation of
	 * [`payer_id`].
	 * 
	 * [`payer_id`]: Self::payer_id
	 */
	public byte[] payer_metadata() {
		byte[] ret = bindings.Refund_payer_metadata(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * A chain that the refund is valid for.
	 */
	public byte[] chain() {
		byte[] ret = bindings.Refund_chain(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The amount to refund in msats (i.e., the minimum lightning-payable unit for [`chain`]).
	 * 
	 * [`chain`]: Self::chain
	 */
	public long amount_msats() {
		long ret = bindings.Refund_amount_msats(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Features pertaining to requesting an invoice.
	 */
	public InvoiceRequestFeatures features() {
		long ret = bindings.Refund_features(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InvoiceRequestFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InvoiceRequestFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The quantity of an item that refund is for.
	 */
	public Option_u64Z quantity() {
		long ret = bindings.Refund_quantity(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * A public node id to send to in the case where there are no [`paths`]. Otherwise, a possibly
	 * transient pubkey.
	 * 
	 * [`paths`]: Self::paths
	 */
	public byte[] payer_id() {
		byte[] ret = bindings.Refund_payer_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Payer provided note to include in the invoice.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public PrintableString payer_note() {
		long ret = bindings.Refund_payer_note(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Refund.
	 */
	public long hash() {
		long ret = bindings.Refund_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Read a Refund from a byte array, created by Refund_write
	 */
	public static Result_RefundDecodeErrorZ read(byte[] ser) {
		long ret = bindings.Refund_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundDecodeErrorZ ret_hu_conv = Result_RefundDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Serialize the Refund object into a byte array which can be read by Refund_read
	 */
	public byte[] write() {
		byte[] ret = bindings.Refund_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a Refund object from a string
	 */
	public static Result_RefundBolt12ParseErrorZ from_str(java.lang.String s) {
		long ret = bindings.Refund_from_str(s);
		Reference.reachabilityFence(s);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundBolt12ParseErrorZ ret_hu_conv = Result_RefundBolt12ParseErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Get the string representation of a Refund object
	 */
	public String to_str() {
		String ret = bindings.Refund_to_str(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
