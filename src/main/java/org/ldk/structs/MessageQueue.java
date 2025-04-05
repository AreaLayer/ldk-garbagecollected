package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The default [`MessageQueue`] Implementation used by [`LiquidityManager`].
 * 
 * [`LiquidityManager`]: crate::LiquidityManager
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class MessageQueue extends CommonBase {
	MessageQueue(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.MessageQueue_free(ptr); }
	}

}
