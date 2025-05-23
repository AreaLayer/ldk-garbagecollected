using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A script pubkey for shutting down a channel as defined by [BOLT #2].
 * 
 * [BOLT #2]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md
 */
public class ShutdownScript : CommonBase {
	internal ShutdownScript(object _dummy, long ptr) : base(ptr) { }
	~ShutdownScript() {
		if (ptr != 0) { bindings.ShutdownScript_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.ShutdownScript_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ShutdownScript
	 */
	public org.ldk.structs.ShutdownScript clone() {
		long ret = bindings.ShutdownScript_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ShutdownScript ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ShutdownScript(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ShutdownScripts contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ShutdownScript b) {
		bool ret = bindings.ShutdownScript_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ShutdownScript)) return false;
		return this.eq((ShutdownScript)o);
	}
	/**
	 * Serialize the ShutdownScript object into a byte array which can be read by ShutdownScript_read
	 */
	public byte[] write() {
		long ret = bindings.ShutdownScript_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ShutdownScript from a byte array, created by ShutdownScript_write
	 */
	public static org.ldk.structs.Result_ShutdownScriptDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ShutdownScript_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ShutdownScriptDecodeErrorZ ret_hu_conv = Result_ShutdownScriptDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Generates a P2WPKH script pubkey from the given [`WPubkeyHash`].
	 */
	public static org.ldk.structs.ShutdownScript new_p2wpkh(byte[] pubkey_hash) {
		long ret = bindings.ShutdownScript_new_p2wpkh(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(pubkey_hash, 20)));
		GC.KeepAlive(pubkey_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ShutdownScript ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ShutdownScript(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a P2WSH script pubkey from the given [`WScriptHash`].
	 */
	public static org.ldk.structs.ShutdownScript new_p2wsh(byte[] script_hash) {
		long ret = bindings.ShutdownScript_new_p2wsh(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(script_hash, 32)));
		GC.KeepAlive(script_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ShutdownScript ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ShutdownScript(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a witness script pubkey from the given segwit version and program.
	 * 
	 * Note for version-zero witness scripts you must use [`ShutdownScript::new_p2wpkh`] or
	 * [`ShutdownScript::new_p2wsh`] instead.
	 * 
	 * # Errors
	 * 
	 * This function may return an error if `program` is invalid for the segwit `version`.
	 */
	public static org.ldk.structs.Result_ShutdownScriptInvalidShutdownScriptZ new_witness_program(org.ldk.structs.WitnessProgram witness_program) {
		long ret = bindings.ShutdownScript_new_witness_program(witness_program.ptr);
		GC.KeepAlive(witness_program);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ShutdownScriptInvalidShutdownScriptZ ret_hu_conv = Result_ShutdownScriptInvalidShutdownScriptZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Converts the shutdown script into the underlying [`ScriptBuf`].
	 */
	public byte[] into_inner() {
		long ret = bindings.ShutdownScript_into_inner(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		;
		return ret_conv;
	}

	/**
	 * Returns the [`PublicKey`] used for a P2WPKH shutdown script if constructed directly from it.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public byte[] as_legacy_pubkey() {
		long ret = bindings.ShutdownScript_as_legacy_pubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Returns whether the shutdown script is compatible with the features as defined by BOLT #2.
	 * 
	 * Specifically, checks for compliance with feature `option_shutdown_anysegwit`.
	 */
	public bool is_compatible(org.ldk.structs.InitFeatures features) {
		bool ret = bindings.ShutdownScript_is_compatible(this.ptr, features.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(features);
		if (this != null) { this.ptrs_to.AddLast(features); };
		return ret;
	}

	/**
	 * Get the string representation of a ShutdownScript object
	 */
	public string to_str() {
		long ret = bindings.ShutdownScript_to_str(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

}
} } }
