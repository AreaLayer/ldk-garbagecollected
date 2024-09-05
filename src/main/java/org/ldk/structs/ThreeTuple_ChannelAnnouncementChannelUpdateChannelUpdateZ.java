package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A Tuple
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ extends CommonBase {
	ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ_free(ptr); }
	}

	/**
	 * 
	 */
	public ChannelAnnouncement get_a() {
		long ret = bindings.C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ_get_a(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public ChannelUpdate get_b() {
		long ret = bindings.C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ_get_b(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public ChannelUpdate get_c() {
		long ret = bindings.C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ_get_c(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ clone() {
		long ret = bindings.C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ ret_hu_conv = new ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ from the contained elements.
	 */
	public static ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ of(org.ldk.structs.ChannelAnnouncement a, org.ldk.structs.ChannelUpdate b, org.ldk.structs.ChannelUpdate c) {
		long ret = bindings.C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZ_new(a.ptr, b.ptr, c.ptr);
		Reference.reachabilityFence(a);
		Reference.reachabilityFence(b);
		Reference.reachabilityFence(c);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ ret_hu_conv = new ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
