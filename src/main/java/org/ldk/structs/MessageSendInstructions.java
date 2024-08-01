package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Instructions for how and where to send a message.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class MessageSendInstructions extends CommonBase {
	private MessageSendInstructions(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.MessageSendInstructions_free(ptr); }
	}
	static MessageSendInstructions constr_from_ptr(long ptr) {
		bindings.LDKMessageSendInstructions raw_val = bindings.LDKMessageSendInstructions_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKMessageSendInstructions.WithSpecifiedReplyPath.class) {
			return new WithSpecifiedReplyPath(ptr, (bindings.LDKMessageSendInstructions.WithSpecifiedReplyPath)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKMessageSendInstructions.WithReplyPath.class) {
			return new WithReplyPath(ptr, (bindings.LDKMessageSendInstructions.WithReplyPath)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKMessageSendInstructions.WithoutReplyPath.class) {
			return new WithoutReplyPath(ptr, (bindings.LDKMessageSendInstructions.WithoutReplyPath)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKMessageSendInstructions.ForReply.class) {
			return new ForReply(ptr, (bindings.LDKMessageSendInstructions.ForReply)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Indicates that a message should be sent including the provided reply path for the recipient
	 * to respond.
	 */
	public final static class WithSpecifiedReplyPath extends MessageSendInstructions {
		/**
		 * The destination where we need to send our message.
		*/
		public final org.ldk.structs.Destination destination;
		/**
		 * The reply path which should be included in the message.
		*/
		public final org.ldk.structs.BlindedMessagePath reply_path;
		private WithSpecifiedReplyPath(long ptr, bindings.LDKMessageSendInstructions.WithSpecifiedReplyPath obj) {
			super(null, ptr);
			long destination = obj.destination;
			org.ldk.structs.Destination destination_hu_conv = org.ldk.structs.Destination.constr_from_ptr(destination);
			if (destination_hu_conv != null) { destination_hu_conv.ptrs_to.add(this); };
			this.destination = destination_hu_conv;
			long reply_path = obj.reply_path;
			org.ldk.structs.BlindedMessagePath reply_path_hu_conv = null; if (reply_path < 0 || reply_path > 4096) { reply_path_hu_conv = new org.ldk.structs.BlindedMessagePath(null, reply_path); }
			if (reply_path_hu_conv != null) { reply_path_hu_conv.ptrs_to.add(this); };
			this.reply_path = reply_path_hu_conv;
		}
	}
	/**
	 * Indicates that a message should be sent including a reply path for the recipient to
	 * respond.
	 */
	public final static class WithReplyPath extends MessageSendInstructions {
		/**
		 * The destination where we need to send our message.
		*/
		public final org.ldk.structs.Destination destination;
		/**
		 * The context to include in the reply path we'll give the recipient so they can respond
		 * to us.
		*/
		public final org.ldk.structs.MessageContext context;
		private WithReplyPath(long ptr, bindings.LDKMessageSendInstructions.WithReplyPath obj) {
			super(null, ptr);
			long destination = obj.destination;
			org.ldk.structs.Destination destination_hu_conv = org.ldk.structs.Destination.constr_from_ptr(destination);
			if (destination_hu_conv != null) { destination_hu_conv.ptrs_to.add(this); };
			this.destination = destination_hu_conv;
			long context = obj.context;
			org.ldk.structs.MessageContext context_hu_conv = org.ldk.structs.MessageContext.constr_from_ptr(context);
			if (context_hu_conv != null) { context_hu_conv.ptrs_to.add(this); };
			this.context = context_hu_conv;
		}
	}
	/**
	 * Indicates that a message should be sent without including a reply path, preventing the
	 * recipient from responding.
	 */
	public final static class WithoutReplyPath extends MessageSendInstructions {
		/**
		 * The destination where we need to send our message.
		*/
		public final org.ldk.structs.Destination destination;
		private WithoutReplyPath(long ptr, bindings.LDKMessageSendInstructions.WithoutReplyPath obj) {
			super(null, ptr);
			long destination = obj.destination;
			org.ldk.structs.Destination destination_hu_conv = org.ldk.structs.Destination.constr_from_ptr(destination);
			if (destination_hu_conv != null) { destination_hu_conv.ptrs_to.add(this); };
			this.destination = destination_hu_conv;
		}
	}
	/**
	 * Indicates that a message is being sent as a reply to a received message.
	 */
	public final static class ForReply extends MessageSendInstructions {
		/**
		 * The instructions provided by the [`Responder`].
		*/
		public final org.ldk.structs.ResponseInstruction instructions;
		private ForReply(long ptr, bindings.LDKMessageSendInstructions.ForReply obj) {
			super(null, ptr);
			long instructions = obj.instructions;
			org.ldk.structs.ResponseInstruction instructions_hu_conv = null; if (instructions < 0 || instructions > 4096) { instructions_hu_conv = new org.ldk.structs.ResponseInstruction(null, instructions); }
			if (instructions_hu_conv != null) { instructions_hu_conv.ptrs_to.add(this); };
			this.instructions = instructions_hu_conv;
		}
	}
	long clone_ptr() {
		long ret = bindings.MessageSendInstructions_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the MessageSendInstructions
	 */
	public MessageSendInstructions clone() {
		long ret = bindings.MessageSendInstructions_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new WithSpecifiedReplyPath-variant MessageSendInstructions
	 */
	public static MessageSendInstructions with_specified_reply_path(org.ldk.structs.Destination destination, org.ldk.structs.BlindedMessagePath reply_path) {
		long ret = bindings.MessageSendInstructions_with_specified_reply_path(destination.ptr, reply_path.ptr);
		Reference.reachabilityFence(destination);
		Reference.reachabilityFence(reply_path);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new WithReplyPath-variant MessageSendInstructions
	 */
	public static MessageSendInstructions with_reply_path(org.ldk.structs.Destination destination, org.ldk.structs.MessageContext context) {
		long ret = bindings.MessageSendInstructions_with_reply_path(destination.ptr, context.ptr);
		Reference.reachabilityFence(destination);
		Reference.reachabilityFence(context);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new WithoutReplyPath-variant MessageSendInstructions
	 */
	public static MessageSendInstructions without_reply_path(org.ldk.structs.Destination destination) {
		long ret = bindings.MessageSendInstructions_without_reply_path(destination.ptr);
		Reference.reachabilityFence(destination);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ForReply-variant MessageSendInstructions
	 */
	public static MessageSendInstructions for_reply(org.ldk.structs.ResponseInstruction instructions) {
		long ret = bindings.MessageSendInstructions_for_reply(instructions.ptr);
		Reference.reachabilityFence(instructions);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.MessageSendInstructions ret_hu_conv = org.ldk.structs.MessageSendInstructions.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

}
