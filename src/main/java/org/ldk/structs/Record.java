package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A Record, unit of logging output with Metadata to enable filtering
 * Module_path, file, line to inform on log's source
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Record extends CommonBase {
	Record(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Record_free(ptr); }
	}

	/**
	 * The verbosity level of the message.
	 */
	public Level get_level() {
		Level ret = bindings.Record_get_level(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The verbosity level of the message.
	 */
	public void set_level(org.ldk.enums.Level val) {
		bindings.Record_set_level(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The node id of the peer pertaining to the logged record.
	 * 
	 * Note that in some cases a [`Self::channel_id`] may be filled in but this may still be
	 * `None`, depending on if the peer information is readily available in LDK when the log is
	 * generated.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public byte[] get_peer_id() {
		byte[] ret = bindings.Record_get_peer_id(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The node id of the peer pertaining to the logged record.
	 * 
	 * Note that in some cases a [`Self::channel_id`] may be filled in but this may still be
	 * `None`, depending on if the peer information is readily available in LDK when the log is
	 * generated.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_peer_id(@Nullable byte[] val) {
		bindings.Record_set_peer_id(this.ptr, InternalUtils.check_arr_len(val, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The channel id of the channel pertaining to the logged record. May be a temporary id before
	 * the channel has been funded.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	@Nullable
	public ChannelId get_channel_id() {
		long ret = bindings.Record_get_channel_id(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelId ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelId(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The channel id of the channel pertaining to the logged record. May be a temporary id before
	 * the channel has been funded.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_channel_id(@Nullable org.ldk.structs.ChannelId val) {
		bindings.Record_set_channel_id(this.ptr, val == null ? 0 : val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The message body.
	 */
	public String get_args() {
		String ret = bindings.Record_get_args(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The message body.
	 */
	public void set_args(java.lang.String val) {
		bindings.Record_set_args(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The module path of the message.
	 */
	public String get_module_path() {
		String ret = bindings.Record_get_module_path(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The module path of the message.
	 */
	public void set_module_path(java.lang.String val) {
		bindings.Record_set_module_path(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The source file containing the message.
	 */
	public String get_file() {
		String ret = bindings.Record_get_file(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The source file containing the message.
	 */
	public void set_file(java.lang.String val) {
		bindings.Record_set_file(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The line containing the message.
	 */
	public int get_line() {
		int ret = bindings.Record_get_line(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The line containing the message.
	 */
	public void set_line(int val) {
		bindings.Record_set_line(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The payment hash.
	 * 
	 * Note that this is only filled in for logs pertaining to a specific payment, and will be
	 * `None` for logs which are not directly related to a payment.
	 */
	public Option_ThirtyTwoBytesZ get_payment_hash() {
		long ret = bindings.Record_get_payment_hash(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ThirtyTwoBytesZ ret_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The payment hash.
	 * 
	 * Note that this is only filled in for logs pertaining to a specific payment, and will be
	 * `None` for logs which are not directly related to a payment.
	 */
	public void set_payment_hash(org.ldk.structs.Option_ThirtyTwoBytesZ val) {
		bindings.Record_set_payment_hash(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new Record given each field
	 * 
	 * Note that peer_id_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that channel_id_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static Record of(org.ldk.enums.Level level_arg, @Nullable byte[] peer_id_arg, @Nullable org.ldk.structs.ChannelId channel_id_arg, java.lang.String args_arg, java.lang.String module_path_arg, java.lang.String file_arg, int line_arg, org.ldk.structs.Option_ThirtyTwoBytesZ payment_hash_arg) {
		long ret = bindings.Record_new(level_arg, InternalUtils.check_arr_len(peer_id_arg, 33), channel_id_arg == null ? 0 : channel_id_arg.ptr, args_arg, module_path_arg, file_arg, line_arg, payment_hash_arg.ptr);
		Reference.reachabilityFence(level_arg);
		Reference.reachabilityFence(peer_id_arg);
		Reference.reachabilityFence(channel_id_arg);
		Reference.reachabilityFence(args_arg);
		Reference.reachabilityFence(module_path_arg);
		Reference.reachabilityFence(file_arg);
		Reference.reachabilityFence(line_arg);
		Reference.reachabilityFence(payment_hash_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Record ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Record(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.Record_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Record
	 */
	public Record clone() {
		long ret = bindings.Record_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Record ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Record(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
