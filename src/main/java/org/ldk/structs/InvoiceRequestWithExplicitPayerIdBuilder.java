package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Builds an [`InvoiceRequest`] from an [`Offer`] for the \"offer to be paid\" flow.
 * 
 * See [module-level documentation] for usage.
 * 
 * [module-level documentation]: self
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class InvoiceRequestWithExplicitPayerIdBuilder extends CommonBase {
	InvoiceRequestWithExplicitPayerIdBuilder(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.InvoiceRequestWithExplicitPayerIdBuilder_free(ptr); }
	}

	/**
	 * Builds an unsigned [`InvoiceRequest`] after checking for valid semantics. It can be signed
	 * by [`UnsignedInvoiceRequest::sign`].
	 */
	public Result_UnsignedInvoiceRequestBolt12SemanticErrorZ build() {
		long ret = bindings.InvoiceRequestWithExplicitPayerIdBuilder_build(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedInvoiceRequestBolt12SemanticErrorZ ret_hu_conv = Result_UnsignedInvoiceRequestBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets the [`InvoiceRequest::chain`] of the given [`Network`] for paying an invoice. If not
	 * called, [`Network::Bitcoin`] is assumed. Errors if the chain for `network` is not supported
	 * by the offer.
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public Result_NoneBolt12SemanticErrorZ chain(org.ldk.enums.Network network) {
		long ret = bindings.InvoiceRequestWithExplicitPayerIdBuilder_chain(this.ptr, network);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(network);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets the [`InvoiceRequest::amount_msats`] for paying an invoice. Errors if `amount_msats` is
	 * not at least the expected invoice amount (i.e., [`Offer::amount`] times [`quantity`]).
	 * 
	 * Successive calls to this method will override the previous setting.
	 * 
	 * [`quantity`]: Self::quantity
	 */
	public Result_NoneBolt12SemanticErrorZ amount_msats(long amount_msats) {
		long ret = bindings.InvoiceRequestWithExplicitPayerIdBuilder_amount_msats(this.ptr, amount_msats);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(amount_msats);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets [`InvoiceRequest::quantity`] of items. If not set, `1` is assumed. Errors if `quantity`
	 * does not conform to [`Offer::is_valid_quantity`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public Result_NoneBolt12SemanticErrorZ quantity(long quantity) {
		long ret = bindings.InvoiceRequestWithExplicitPayerIdBuilder_quantity(this.ptr, quantity);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(quantity);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
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
	 * Sets the [`InvoiceRequest::payer_note`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void payer_note(java.lang.String payer_note) {
		bindings.InvoiceRequestWithExplicitPayerIdBuilder_payer_note(this.ptr, payer_note);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(payer_note);
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
