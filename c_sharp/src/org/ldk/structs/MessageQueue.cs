using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The default [`MessageQueue`] Implementation used by [`LiquidityManager`].
 * 
 * [`LiquidityManager`]: crate::LiquidityManager
 */
public class MessageQueue : CommonBase {
	internal MessageQueue(object _dummy, long ptr) : base(ptr) { }
	~MessageQueue() {
		if (ptr != 0) { bindings.MessageQueue_free(ptr); }
	}

}
} } }
