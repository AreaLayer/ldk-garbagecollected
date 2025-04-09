using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Details regarding the state of an ordered channel.
 */
public class LSPS1ChannelInfo : CommonBase {
	internal LSPS1ChannelInfo(object _dummy, long ptr) : base(ptr) { }
	~LSPS1ChannelInfo() {
		if (ptr != 0) { bindings.LSPS1ChannelInfo_free(ptr); }
	}

	/**
	 * The datetime when the funding transaction has been published.
	 */
	public org.ldk.structs.LSPSDateTime get_funded_at() {
		long ret = bindings.LSPS1ChannelInfo_get_funded_at(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The datetime when the funding transaction has been published.
	 */
	public void set_funded_at(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS1ChannelInfo_set_funded_at(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The outpoint of the funding transaction.
	 */
	public org.ldk.structs.OutPoint get_funding_outpoint() {
		long ret = bindings.LSPS1ChannelInfo_get_funding_outpoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The outpoint of the funding transaction.
	 */
	public void set_funding_outpoint(org.ldk.structs.OutPoint val) {
		bindings.LSPS1ChannelInfo_set_funding_outpoint(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The earliest datetime when the channel may be closed by the LSP.
	 */
	public org.ldk.structs.LSPSDateTime get_expires_at() {
		long ret = bindings.LSPS1ChannelInfo_get_expires_at(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPSDateTime ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPSDateTime(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The earliest datetime when the channel may be closed by the LSP.
	 */
	public void set_expires_at(org.ldk.structs.LSPSDateTime val) {
		bindings.LSPS1ChannelInfo_set_expires_at(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new LSPS1ChannelInfo given each field
	 */
	public static org.ldk.structs.LSPS1ChannelInfo of(org.ldk.structs.LSPSDateTime funded_at_arg, org.ldk.structs.OutPoint funding_outpoint_arg, org.ldk.structs.LSPSDateTime expires_at_arg) {
		long ret = bindings.LSPS1ChannelInfo_new(funded_at_arg.ptr, funding_outpoint_arg.ptr, expires_at_arg.ptr);
		GC.KeepAlive(funded_at_arg);
		GC.KeepAlive(funding_outpoint_arg);
		GC.KeepAlive(expires_at_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ChannelInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.LSPS1ChannelInfo_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LSPS1ChannelInfo
	 */
	public org.ldk.structs.LSPS1ChannelInfo clone() {
		long ret = bindings.LSPS1ChannelInfo_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LSPS1ChannelInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LSPS1ChannelInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two LSPS1ChannelInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.LSPS1ChannelInfo b) {
		bool ret = bindings.LSPS1ChannelInfo_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is LSPS1ChannelInfo)) return false;
		return this.eq((LSPS1ChannelInfo)o);
	}
}
} } }
