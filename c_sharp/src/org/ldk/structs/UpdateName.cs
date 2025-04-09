using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A struct representing a name for a channel monitor update.
 * 
 * [`UpdateName`] is primarily used within the [`MonitorUpdatingPersister`] in
 * functions that store or retrieve partial updates to channel monitors. It
 * provides a consistent way to generate and parse unique identifiers for
 * monitor updates based on their sequence number.
 * 
 * The name is derived from the update's sequence ID, which is a monotonically
 * increasing u64 value. This format allows for easy ordering of updates and
 * efficient storage and retrieval in key-value stores.
 * 
 * # Usage
 * 
 * While users of the Lightning Dev Kit library generally won't need to
 * interact with `UpdateName` directly, it still can be useful for custom
 * persistence implementations. The u64 value is the update_id that can be
 * compared with [ChannelMonitor::get_latest_update_id] to check if this update
 * has been applied to the channel monitor or not, which is useful for pruning
 * stale channel monitor updates off persistence.
 * 
 * # Examples
 * 
 * ```
 * use lightning::util::persist::UpdateName;
 * 
 * let update_id: u64 = 42;
 * let update_name = UpdateName::from(update_id);
 * assert_eq!(update_name.as_str(), \"42\");
 * 
 * Using UpdateName to generate a storage key
 * let monitor_name = \"some_monitor_name\";
 * let storage_key = format!(\"channel_monitor_updates/{}/{}\", monitor_name, update_name.as_str());
 * ```
 */
public class UpdateName : CommonBase {
	internal UpdateName(object _dummy, long ptr) : base(ptr) { }
	~UpdateName() {
		if (ptr != 0) { bindings.UpdateName_free(ptr); }
	}

	public long get_a() {
		long ret = bindings.UpdateName_get_a(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public void set_a(long val) {
		bindings.UpdateName_set_a(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs an [`UpdateName`], after verifying that an update sequence ID
	 * can be derived from the given `name`.
	 */
	public static org.ldk.structs.Result_UpdateNameIOErrorZ of(string name) {
		long ret = bindings.UpdateName_new(InternalUtils.encodeString(name));
		GC.KeepAlive(name);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateNameIOErrorZ ret_hu_conv = Result_UpdateNameIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Convert this update name to a string slice.
	 * 
	 * This method is particularly useful when you need to use the update name
	 * as part of a key in a key-value store or when logging.
	 * 
	 * # Examples
	 * 
	 * ```
	 * use lightning::util::persist::UpdateName;
	 * 
	 * let update_name = UpdateName::from(42);
	 * assert_eq!(update_name.as_str(), \"42\");
	 * ```
	 */
	public string as_str() {
		long ret = bindings.UpdateName_as_str(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

}
} } }
