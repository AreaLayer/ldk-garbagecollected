package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * An enum which can either contain a crate::c_types::Address or not
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Option_AddressZ extends CommonBase {
	private Option_AddressZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.COption_AddressZ_free(ptr); }
	}
	static Option_AddressZ constr_from_ptr(long ptr) {
		bindings.LDKCOption_AddressZ raw_val = bindings.LDKCOption_AddressZ_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKCOption_AddressZ.Some.class) {
			return new Some(ptr, (bindings.LDKCOption_AddressZ.Some)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKCOption_AddressZ.None.class) {
			return new None(ptr, (bindings.LDKCOption_AddressZ.None)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * When we're in this state, this COption_AddressZ contains a crate::c_types::Address
	 */
	public final static class Some extends Option_AddressZ {
		public final org.ldk.structs.Address some;
		private Some(long ptr, bindings.LDKCOption_AddressZ.Some obj) {
			super(null, ptr);
			long some = obj.some;
			Address some_conv = new Address(null, some);
			this.some = some_conv;
		}
	}
	/**
	 * When we're in this state, this COption_AddressZ contains nothing
	 */
	public final static class None extends Option_AddressZ {
		private None(long ptr, bindings.LDKCOption_AddressZ.None obj) {
			super(null, ptr);
		}
	}
	/**
	 * Constructs a new COption_AddressZ containing a crate::c_types::Address
	 */
	public static Option_AddressZ some(org.ldk.structs.Address o) {
		long ret = bindings.COption_AddressZ_some(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AddressZ ret_hu_conv = org.ldk.structs.Option_AddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_AddressZ containing nothing
	 */
	public static Option_AddressZ none() {
		long ret = bindings.COption_AddressZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_AddressZ ret_hu_conv = org.ldk.structs.Option_AddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
