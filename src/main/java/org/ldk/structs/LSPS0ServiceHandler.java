package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The main server-side object allowing to send and receive bLIP-50 / LSPS0 messages.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS0ServiceHandler extends CommonBase {
	LSPS0ServiceHandler(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS0ServiceHandler_free(ptr); }
	}

}
