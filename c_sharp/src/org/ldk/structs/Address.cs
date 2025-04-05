using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Address : CommonBase {
	/** The address in string form */
	public readonly string address;

	internal Address(object _dummy, long ptr) : base(ptr) {
		this.address = InternalUtils.decodeString(bindings.Address_to_string(ptr));
	}
	public static Address from_string(string address) {
		long str_ptr = InternalUtils.encodeString(address);
		long ptr = bindings.Address_new(str_ptr);
		bindings.free_buffer(str_ptr);
		Option_AddressZ res = Option_AddressZ.constr_from_ptr(ptr);
		if (res is Option_AddressZ.Option_AddressZ_Some) {
			long addr_ptr = ((Option_AddressZ.Option_AddressZ_Some)res).some.ptr;
			long cloned = bindings.Address_clone(addr_ptr);
			Address rest = new Address(null, cloned);
			return rest;
		} else {
			throw new ArgumentException("Invalid address", "address");
		}
	}

	~Address() {
		if (ptr != 0) { bindings.Address_free(ptr); }
	}
}} } }
