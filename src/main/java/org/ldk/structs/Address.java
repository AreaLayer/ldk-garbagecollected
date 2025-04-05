package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Address extends CommonBase {
	/** The address in string form */
	public final String address;

	Address(java.lang.Object _dummy, long ptr) {
		super(ptr);
		this.address = bindings.Address_to_string(ptr);
	}
	public static Address from_string(String address) throws IllegalArgumentException {
		long ptr = bindings.Address_new(address);
		Option_AddressZ res = Option_AddressZ.constr_from_ptr(ptr);
		if (res instanceof Option_AddressZ.Some) {
			long addr_ptr = ((Option_AddressZ.Some) res).some.ptr;
			return new Address(null, bindings.Address_clone(addr_ptr));
		} else {
			throw new IllegalArgumentException("Invalid address");
		}
	}

	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Address_free(ptr); }
	}
}