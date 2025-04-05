using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The main server-side object allowing to send and receive bLIP-50 / LSPS0 messages.
 */
public class LSPS0ServiceHandler : CommonBase {
	internal LSPS0ServiceHandler(object _dummy, long ptr) : base(ptr) { }
	~LSPS0ServiceHandler() {
		if (ptr != 0) { bindings.LSPS0ServiceHandler_free(ptr); }
	}

}
} } }
