package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A user-defined name for a node, which may be used when displaying the node in a graph.
 * 
 * Since node aliases are provided by third parties, they are a potential avenue for injection
 * attacks. Care must be taken when processing.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class NodeAlias extends CommonBase {
	NodeAlias(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.NodeAlias_free(ptr); }
	}

	public byte[] get_a() {
		byte[] ret = bindings.NodeAlias_get_a(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	public void set_a(byte[] val) {
		bindings.NodeAlias_set_a(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new NodeAlias given each field
	 */
	public static NodeAlias of(byte[] a_arg) {
		long ret = bindings.NodeAlias_new(InternalUtils.check_arr_len(a_arg, 32));
		Reference.reachabilityFence(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAlias ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAlias(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.NodeAlias_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the NodeAlias
	 */
	public NodeAlias clone() {
		long ret = bindings.NodeAlias_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAlias ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAlias(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the NodeAlias.
	 */
	public long hash() {
		long ret = bindings.NodeAlias_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two NodeAliass contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.NodeAlias b) {
		boolean ret = bindings.NodeAlias_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof NodeAlias)) return false;
		return this.eq((NodeAlias)o);
	}
	/**
	 * Get the string representation of a NodeAlias object
	 */
	public String to_str() {
		String ret = bindings.NodeAlias_to_str(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Serialize the NodeAlias object into a byte array which can be read by NodeAlias_read
	 */
	public byte[] write() {
		byte[] ret = bindings.NodeAlias_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a NodeAlias from a byte array, created by NodeAlias_write
	 */
	public static Result_NodeAliasDecodeErrorZ read(byte[] ser) {
		long ret = bindings.NodeAlias_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeAliasDecodeErrorZ ret_hu_conv = Result_NodeAliasDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
