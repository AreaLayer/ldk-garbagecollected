package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Details regarding the state of an ordered channel.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class LSPS1ChannelInfo extends CommonBase {
	LSPS1ChannelInfo(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.LSPS1ChannelInfo_free(ptr); }
	}

	/**
	 * The datetime when the funding transaction has been published.
	 */
	public LSPSDateTime get_funded_at() {
		long ret = bindings.LSPS1ChannelInfo_get_funded_at(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The datetime when the funding transaction has been published.
	 */
	public void set_funded_at(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS1ChannelInfo_set_funded_at(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The outpoint of the funding transaction.
	 */
	public OutPoint get_funding_outpoint() {
		long ret = bindings.LSPS1ChannelInfo_get_funding_outpoint(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The outpoint of the funding transaction.
	 */
	public void set_funding_outpoint(org.ldk.structs.OutPoint val) {
		bindings.LSPS1ChannelInfo_set_funding_outpoint(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The earliest datetime when the channel may be closed by the LSP.
	 */
	public LSPSDateTime get_expires_at() {
		long ret = bindings.LSPS1ChannelInfo_get_expires_at(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The earliest datetime when the channel may be closed by the LSP.
	 */
	public void set_expires_at(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS1ChannelInfo_set_expires_at(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new LSPS1ChannelInfo given each field
	 */
	public static LSPS1ChannelInfo of(org.ldk.structs.LSPSDateTime funded_at_arg, org.ldk.structs.OutPoint funding_outpoint_arg, org.ldk.structs.LSPSDateTime expires_at_arg) {
		long ret = bindings.LSPS1ChannelInfo_new(funded_at_arg.ptr, funding_outpoint_arg.ptr, expires_at_arg.ptr);
		Reference.reachabilityFence(funded_at_arg);
		Reference.reachabilityFence(funding_outpoint_arg);
		Reference.reachabilityFence(expires_at_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ChannelInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.LSPS1ChannelInfo_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1ChannelInfo
	 */
	public LSPS1ChannelInfo clone() {
		long ret = bindings.LSPS1ChannelInfo_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ChannelInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1ChannelInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.LSPS1ChannelInfo b) {
		boolean ret = bindings.LSPS1ChannelInfo_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof LSPS1ChannelInfo)) return false;
		return this.eq((LSPS1ChannelInfo)o);
	}
}
