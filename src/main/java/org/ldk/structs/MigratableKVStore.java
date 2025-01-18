package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * Provides additional interface methods that are required for [`KVStore`]-to-[`KVStore`]
 * data migration.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class MigratableKVStore extends CommonBase {
	final bindings.LDKMigratableKVStore bindings_instance;
	MigratableKVStore(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private MigratableKVStore(bindings.LDKMigratableKVStore arg, bindings.LDKKVStore KVStore) {
		super(bindings.LDKMigratableKVStore_new(arg, KVStore));
		this.ptrs_to.add(arg);
		this.ptrs_to.add(KVStore);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.MigratableKVStore_free(ptr); } super.finalize();
	}
	/**
	 * Destroys the object, freeing associated resources. After this call, any access
	 * to this object may result in a SEGFAULT or worse.
	 *
	 * You should generally NEVER call this method. You should let the garbage collector
	 * do this for you when it finalizes objects. However, it may be useful for types
	 * which represent locks and should be closed immediately to avoid holding locks
	 * until the GC runs.
	 */
	public void destroy() {
		if (ptr != 0) { bindings.MigratableKVStore_free(ptr); }
		ptr = 0;
	}
	public static interface MigratableKVStoreInterface {
		/**
		 * Returns *all* known keys as a list of `primary_namespace`, `secondary_namespace`, `key` tuples.
		 * 
		 * This is useful for migrating data from [`KVStore`] implementation to [`KVStore`]
		 * implementation.
		 * 
		 * Must exhaustively return all entries known to the store to ensure no data is missed, but
		 * may return the items in arbitrary order.
		 */
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ list_all_keys();
	}
	private static class LDKMigratableKVStoreHolder { MigratableKVStore held; }
	public static MigratableKVStore new_impl(MigratableKVStoreInterface arg, KVStore.KVStoreInterface KVStore_impl) {
		final LDKMigratableKVStoreHolder impl_holder = new LDKMigratableKVStoreHolder();
		impl_holder.held = new MigratableKVStore(new bindings.LDKMigratableKVStore() {
			@Override public long list_all_keys() {
				Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret = arg.list_all_keys();
				Reference.reachabilityFence(arg);
				long result = ret.clone_ptr();
				return result;
			}
		}, KVStore.new_impl(KVStore_impl).bindings_instance);
		return impl_holder.held;
	}

	/**
	 * Gets the underlying KVStore.
	 */
	public KVStore get_k_v_store() {
		KVStore res = new KVStore(null, bindings.LDKMigratableKVStore_get_KVStore(this.ptr));
		res.ptrs_to.add(this);
		return res;
	}

	/**
	 * Returns *all* known keys as a list of `primary_namespace`, `secondary_namespace`, `key` tuples.
	 * 
	 * This is useful for migrating data from [`KVStore`] implementation to [`KVStore`]
	 * implementation.
	 * 
	 * Must exhaustively return all entries known to the store to ensure no data is missed, but
	 * may return the items in arbitrary order.
	 */
	public Result_CVec_C3Tuple_StrStrStrZZIOErrorZ list_all_keys() {
		long ret = bindings.MigratableKVStore_list_all_keys(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
