package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A struct representing a name for a channel monitor.
 * 
 * `MonitorName` is primarily used within the [`MonitorUpdatingPersister`]
 * in functions that store or retrieve channel monitor snapshots.
 * It provides a consistent way to generate a unique key for channel
 * monitors based on their funding outpoints.
 * 
 * While users of the Lightning Dev Kit library generally won't need
 * to interact with [`MonitorName`] directly, it can be useful for:
 * - Custom persistence implementations
 * - Debugging or logging channel monitor operations
 * - Extending the functionality of the `MonitorUpdatingPersister`
 * # Examples
 * 
 * ```
 * use std::str::FromStr;
 * 
 * use bitcoin::Txid;
 * 
 * use lightning::util::persist::MonitorName;
 * use lightning::chain::transaction::OutPoint;
 * 
 * let outpoint = OutPoint {
 * \t txid: Txid::from_str(\"deadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeef\").unwrap(),
 * \t index: 1,
 * };
 * let monitor_name = MonitorName::from(outpoint);
 * assert_eq!(monitor_name.as_str(), \"deadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeef_1\");
 * 
 * Using MonitorName to generate a storage key
 * let storage_key = format!(\"channel_monitors/{}\", monitor_name.as_str());
 * ```
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class MonitorName extends CommonBase {
	MonitorName(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.MonitorName_free(ptr); }
	}

	/**
	 * Constructs a [`MonitorName`], after verifying that an [`OutPoint`] can
	 * be formed from the given `name`.
	 * This method is useful if you have a String and you want to verify that
	 * it's a valid storage key for a channel monitor.
	 */
	public static Result_MonitorNameIOErrorZ of(java.lang.String name) {
		long ret = bindings.MonitorName_new(name);
		Reference.reachabilityFence(name);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MonitorNameIOErrorZ ret_hu_conv = Result_MonitorNameIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Convert this monitor name to a str.
	 * This method is particularly useful when you need to use the monitor name
	 * as a key in a key-value store or when logging.
	 */
	public String as_str() {
		String ret = bindings.MonitorName_as_str(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

}
