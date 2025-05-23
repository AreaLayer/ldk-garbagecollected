package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Builds a [`Bolt12Invoice`] from either:
 * - an [`InvoiceRequest`] for the \"offer to be paid\" flow or
 * - a [`Refund`] for the \"offer for money\" flow.
 * 
 * See [module-level documentation] for usage.
 * 
 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
 * [`Refund`]: crate::offers::refund::Refund
 * [module-level documentation]: self
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class InvoiceWithExplicitSigningPubkeyBuilder extends CommonBase {
	InvoiceWithExplicitSigningPubkeyBuilder(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.InvoiceWithExplicitSigningPubkeyBuilder_free(ptr); }
	}

	/**
	 * Builds an unsigned [`Bolt12Invoice`] after checking for valid semantics.
	 */
	public Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ build() {
		long ret = bindings.InvoiceWithExplicitSigningPubkeyBuilder_build(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(this); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid this being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after this call, this is reset to null and is now a dummy object.
		this.ptr = 0;;
		return ret_hu_conv;
	}

	/**
	 * Sets the [`Bolt12Invoice::relative_expiry`]
	 * as seconds since [`Bolt12Invoice::created_at`].
	 * Any expiry that has already passed is valid and can be checked for using
	 * [`Bolt12Invoice::is_expired`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void relative_expiry(int relative_expiry_secs) {
		bindings.InvoiceWithExplicitSigningPubkeyBuilder_relative_expiry(this.ptr, relative_expiry_secs);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(relative_expiry_secs);
		if (this != null) { this.ptrs_to.add(this); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid this being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after this call, this is reset to null and is now a dummy object.
		this.ptr = 0;;
	}

	/**
	 * Adds a P2WSH address to [`Bolt12Invoice::fallbacks`].
	 * 
	 * Successive calls to this method will add another address. Caller is responsible for not
	 * adding duplicate addresses and only calling if capable of receiving to P2WSH addresses.
	 */
	public void fallback_v0_p2wsh(byte[] script_hash) {
		bindings.InvoiceWithExplicitSigningPubkeyBuilder_fallback_v0_p2wsh(this.ptr, InternalUtils.check_arr_len(script_hash, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(script_hash);
		if (this != null) { this.ptrs_to.add(this); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid this being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after this call, this is reset to null and is now a dummy object.
		this.ptr = 0;;
	}

	/**
	 * Adds a P2WPKH address to [`Bolt12Invoice::fallbacks`].
	 * 
	 * Successive calls to this method will add another address. Caller is responsible for not
	 * adding duplicate addresses and only calling if capable of receiving to P2WPKH addresses.
	 */
	public void fallback_v0_p2wpkh(byte[] pubkey_hash) {
		bindings.InvoiceWithExplicitSigningPubkeyBuilder_fallback_v0_p2wpkh(this.ptr, InternalUtils.check_arr_len(pubkey_hash, 20));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(pubkey_hash);
		if (this != null) { this.ptrs_to.add(this); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid this being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after this call, this is reset to null and is now a dummy object.
		this.ptr = 0;;
	}

	/**
	 * Adds a P2TR address to [`Bolt12Invoice::fallbacks`].
	 * 
	 * Successive calls to this method will add another address. Caller is responsible for not
	 * adding duplicate addresses and only calling if capable of receiving to P2TR addresses.
	 */
	public void fallback_v1_p2tr_tweaked(byte[] utput_key) {
		bindings.InvoiceWithExplicitSigningPubkeyBuilder_fallback_v1_p2tr_tweaked(this.ptr, InternalUtils.check_arr_len(utput_key, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(utput_key);
		if (this != null) { this.ptrs_to.add(this); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid this being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after this call, this is reset to null and is now a dummy object.
		this.ptr = 0;;
	}

	/**
	 * Sets [`Bolt12Invoice::invoice_features`]
	 * to indicate MPP may be used. Otherwise, MPP is disallowed.
	 */
	public void allow_mpp() {
		bindings.InvoiceWithExplicitSigningPubkeyBuilder_allow_mpp(this.ptr);
		Reference.reachabilityFence(this);
		if (this != null) { this.ptrs_to.add(this); };
		// Due to rust's strict-ownership memory model, in some cases we need to "move"
		// an object to pass exclusive ownership to the function being called.
		// In most cases, we avoid this being visible in GC'd languages by cloning the object
		// at the FFI layer, creating a new object which Rust can claim ownership of
		// However, in some cases (eg here), there is no way to clone an object, and thus
		// we actually have to pass full ownership to Rust.
		// Thus, after this call, this is reset to null and is now a dummy object.
		this.ptr = 0;;
	}

}
