
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of MigratableKVStore */
public interface MigratableKVStoreInterface {
	/**Returns *all* known keys as a list of `primary_namespace`, `secondary_namespace`, `key` tuples.
	 * 
	 * This is useful for migrating data from [`KVStore`] implementation to [`KVStore`]
	 * implementation.
	 * 
	 * Must exhaustively return all entries known to the store to ensure no data is missed, but
	 * may return the items in arbitrary order.
	 */
	Result_CVec_C3Tuple_StrStrStrZZIOErrorZ list_all_keys();
}

/**
 * Provides additional interface methods that are required for [`KVStore`]-to-[`KVStore`]
 * data migration.
 */
public class MigratableKVStore : CommonBase {
	internal bindings.LDKMigratableKVStore bindings_instance;
	internal long instance_idx;

	internal MigratableKVStore(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~MigratableKVStore() {
		if (ptr != 0) { bindings.MigratableKVStore_free(ptr); }
	}

	private class LDKMigratableKVStoreHolder { internal MigratableKVStore held; }
	private class LDKMigratableKVStoreImpl : bindings.LDKMigratableKVStore {
		internal LDKMigratableKVStoreImpl(MigratableKVStoreInterface arg, LDKMigratableKVStoreHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private MigratableKVStoreInterface arg;
		private LDKMigratableKVStoreHolder impl_holder;
		public long list_all_keys() {
			Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret = arg.list_all_keys();
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
	}

	/** Creates a new instance of MigratableKVStore from a given implementation */
	public static MigratableKVStore new_impl(MigratableKVStoreInterface arg, KVStoreInterface kVStore_impl) {
		LDKMigratableKVStoreHolder impl_holder = new LDKMigratableKVStoreHolder();
		LDKMigratableKVStoreImpl impl = new LDKMigratableKVStoreImpl(arg, impl_holder);
		KVStore kVStore = KVStore.new_impl(kVStore_impl);
		long[] ptr_idx = bindings.LDKMigratableKVStore_new(impl, kVStore.instance_idx);

		impl_holder.held = new MigratableKVStore(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		impl_holder.held.ptrs_to.AddLast(kVStore);
		return impl_holder.held;
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
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C3Tuple_StrStrStrZZIOErrorZ ret_hu_conv = Result_CVec_C3Tuple_StrStrStrZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
