
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of ChangeDestinationSource */
public interface ChangeDestinationSourceInterface {
	/**Returns a script pubkey which can be used as a change destination for
	 * [`OutputSpender::spend_spendable_outputs`].
	 * 
	 * This method should return a different value each time it is called, to avoid linking
	 * on-chain funds controlled to the same user.
	 */
	Result_CVec_u8ZNoneZ get_change_destination_script();
}

/**
 * A helper trait that describes an on-chain wallet capable of returning a (change) destination
 * script.
 */
public class ChangeDestinationSource : CommonBase {
	internal bindings.LDKChangeDestinationSource bindings_instance;
	internal long instance_idx;

	internal ChangeDestinationSource(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~ChangeDestinationSource() {
		if (ptr != 0) { bindings.ChangeDestinationSource_free(ptr); }
	}

	private class LDKChangeDestinationSourceHolder { internal ChangeDestinationSource held; }
	private class LDKChangeDestinationSourceImpl : bindings.LDKChangeDestinationSource {
		internal LDKChangeDestinationSourceImpl(ChangeDestinationSourceInterface arg, LDKChangeDestinationSourceHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private ChangeDestinationSourceInterface arg;
		private LDKChangeDestinationSourceHolder impl_holder;
		public long get_change_destination_script() {
			Result_CVec_u8ZNoneZ ret = arg.get_change_destination_script();
				GC.KeepAlive(arg);
			long result = ret.clone_ptr();
			return result;
		}
	}

	/** Creates a new instance of ChangeDestinationSource from a given implementation */
	public static ChangeDestinationSource new_impl(ChangeDestinationSourceInterface arg) {
		LDKChangeDestinationSourceHolder impl_holder = new LDKChangeDestinationSourceHolder();
		LDKChangeDestinationSourceImpl impl = new LDKChangeDestinationSourceImpl(arg, impl_holder);
		long[] ptr_idx = bindings.LDKChangeDestinationSource_new(impl);

		impl_holder.held = new ChangeDestinationSource(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Returns a script pubkey which can be used as a change destination for
	 * [`OutputSpender::spend_spendable_outputs`].
	 * 
	 * This method should return a different value each time it is called, to avoid linking
	 * on-chain funds controlled to the same user.
	 */
	public Result_CVec_u8ZNoneZ get_change_destination_script() {
		long ret = bindings.ChangeDestinationSource_get_change_destination_script(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_u8ZNoneZ ret_hu_conv = Result_CVec_u8ZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
