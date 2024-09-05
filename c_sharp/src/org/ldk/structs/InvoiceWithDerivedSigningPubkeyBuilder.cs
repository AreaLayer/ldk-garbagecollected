using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


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
public class InvoiceWithDerivedSigningPubkeyBuilder : CommonBase {
	internal InvoiceWithDerivedSigningPubkeyBuilder(object _dummy, long ptr) : base(ptr) { }
	~InvoiceWithDerivedSigningPubkeyBuilder() {
		if (ptr != 0) { bindings.InvoiceWithDerivedSigningPubkeyBuilder_free(ptr); }
	}

	/**
	 * Builds a signed [`Bolt12Invoice`] after checking for valid semantics.
	 */
	public Result_Bolt12InvoiceBolt12SemanticErrorZ build_and_sign() {
		long ret = bindings.InvoiceWithDerivedSigningPubkeyBuilder_build_and_sign(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt12InvoiceBolt12SemanticErrorZ ret_hu_conv = Result_Bolt12InvoiceBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(this); };
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
		bindings.InvoiceWithDerivedSigningPubkeyBuilder_relative_expiry(this.ptr, relative_expiry_secs);
		GC.KeepAlive(this);
		GC.KeepAlive(relative_expiry_secs);
		if (this != null) { this.ptrs_to.AddLast(this); };
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
		bindings.InvoiceWithDerivedSigningPubkeyBuilder_fallback_v0_p2wsh(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(script_hash, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(script_hash);
		if (this != null) { this.ptrs_to.AddLast(this); };
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
		bindings.InvoiceWithDerivedSigningPubkeyBuilder_fallback_v0_p2wpkh(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(pubkey_hash, 20)));
		GC.KeepAlive(this);
		GC.KeepAlive(pubkey_hash);
		if (this != null) { this.ptrs_to.AddLast(this); };
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
		bindings.InvoiceWithDerivedSigningPubkeyBuilder_fallback_v1_p2tr_tweaked(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(utput_key, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(utput_key);
		if (this != null) { this.ptrs_to.AddLast(this); };
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
		bindings.InvoiceWithDerivedSigningPubkeyBuilder_allow_mpp(this.ptr);
		GC.KeepAlive(this);
		if (this != null) { this.ptrs_to.AddLast(this); };
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
} } }
