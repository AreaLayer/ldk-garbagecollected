using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ : CommonBase {
	Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ() {
		if (ptr != 0) { bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_free(ptr); }
	}

	internal static Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_is_ok(ptr)) {
			return new Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_OK : Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ {
		public readonly TwoTuple_ThirtyTwoBytesChannelMonitorZ res;
		internal Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_get_ok(ptr);
			TwoTuple_ThirtyTwoBytesChannelMonitorZ res_hu_conv = new TwoTuple_ThirtyTwoBytesChannelMonitorZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_Err : Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ in the success state.
	 */
	public static org.ldk.structs.Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ ok(org.ldk.structs.TwoTuple_ThirtyTwoBytesChannelMonitorZ o) {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_ok(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ in the error state.
	 */
	public static org.ldk.structs.Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public org.ldk.structs.Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ clone() {
		long ret = bindings.CResult_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
