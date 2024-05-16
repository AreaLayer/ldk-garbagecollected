using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Builds an [`InvoiceRequest`] from an [`Offer`] for the \"offer to be paid\" flow.
 * 
 * See [module-level documentation] for usage.
 * 
 * [module-level documentation]: self
 */
public class InvoiceRequestWithDerivedPayerIdBuilder : CommonBase {
	internal InvoiceRequestWithDerivedPayerIdBuilder(object _dummy, long ptr) : base(ptr) { }
	~InvoiceRequestWithDerivedPayerIdBuilder() {
		if (ptr != 0) { bindings.InvoiceRequestWithDerivedPayerIdBuilder_free(ptr); }
	}

	/**
	 * Builds a signed [`InvoiceRequest`] after checking for valid semantics.
	 */
	public Result_InvoiceRequestBolt12SemanticErrorZ build_and_sign() {
		long ret = bindings.InvoiceRequestWithDerivedPayerIdBuilder_build_and_sign(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_InvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets the [`InvoiceRequest::chain`] of the given [`Network`] for paying an invoice. If not
	 * called, [`Network::Bitcoin`] is assumed. Errors if the chain for `network` is not supported
	 * by the offer.
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public Result_NoneBolt12SemanticErrorZ chain(Network network) {
		long ret = bindings.InvoiceRequestWithDerivedPayerIdBuilder_chain(this.ptr, network);
		GC.KeepAlive(this);
		GC.KeepAlive(network);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets the [`InvoiceRequest::amount_msats`] for paying an invoice. Errors if `amount_msats` is
	 * not at least the expected invoice amount (i.e., [`Offer::amount`] times [`quantity`]).
	 * 
	 * Successive calls to this method will override the previous setting.
	 * 
	 * [`quantity`]: Self::quantity
	 */
	public Result_NoneBolt12SemanticErrorZ amount_msats(long amount_msats) {
		long ret = bindings.InvoiceRequestWithDerivedPayerIdBuilder_amount_msats(this.ptr, amount_msats);
		GC.KeepAlive(this);
		GC.KeepAlive(amount_msats);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets [`InvoiceRequest::quantity`] of items. If not set, `1` is assumed. Errors if `quantity`
	 * does not conform to [`Offer::is_valid_quantity`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public Result_NoneBolt12SemanticErrorZ quantity(long quantity) {
		long ret = bindings.InvoiceRequestWithDerivedPayerIdBuilder_quantity(this.ptr, quantity);
		GC.KeepAlive(this);
		GC.KeepAlive(quantity);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets the [`InvoiceRequest::payer_note`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void payer_note(string payer_note) {
		bindings.InvoiceRequestWithDerivedPayerIdBuilder_payer_note(this.ptr, InternalUtils.encodeString(payer_note));
		GC.KeepAlive(this);
		GC.KeepAlive(payer_note);
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
