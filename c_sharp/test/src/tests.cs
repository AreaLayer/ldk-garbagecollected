using System;
using System.Collections.Generic;
using System.Diagnostics;
using org.ldk.enums;
using org.ldk.util;
using org.ldk.structs;

namespace tests {
	static class Tests {
		static void Assert(bool a, int assertion) {
			if (!a) {
				Console.WriteLine("Assertion " + assertion + " failed at");
				Console.WriteLine(new StackTrace().ToString());
				Environment.Exit(45);
			}
		}

		static void SimpleConstructionTest() {
			Ping ping = Ping.of(42, 43);
			Assert(ping.get_ponglen() == 42, 0);
		}

		class TestBroadcaster : BroadcasterInterfaceInterface {
			public int broadcasted_len = 0;
			public void broadcast_transactions(byte[][] txn) {
				Assert(txn.Length == 1, 1);
				broadcasted_len = txn[0].Length;
			}
		}

		static void SimpleTraitTest() {
			TestBroadcaster impl = new TestBroadcaster();
			BroadcasterInterface broadcaster = BroadcasterInterface.new_impl(impl);
			byte[][] txn = new byte[1][];
			txn[0] = new byte[42];
			broadcaster.broadcast_transactions(txn);
			Assert(impl.broadcasted_len == 42, 3);
		}

		class TestEstimator : FeeEstimatorInterface {
			public int get_est_sat_per_1000_weight(ConfirmationTarget confirmation_target) {
				if (confirmation_target == ConfirmationTarget.LDKConfirmationTarget_MinAllowedNonAnchorChannelRemoteFee) {
					return 253;
				} else {
					return 300;
				}
			}
		}

		class TestLogger : LoggerInterface {
			public void log(Record record) {
				Console.WriteLine(record.get_module_path() + ":" + record.get_line() + " " + record.get_args());
			}
		}

		class TestPersister : PersistInterface {
			public ChannelMonitorUpdateStatus persist_new_channel(OutPoint channel_id, ChannelMonitor data) {
				return ChannelMonitorUpdateStatus.LDKChannelMonitorUpdateStatus_Completed;
			}
			public ChannelMonitorUpdateStatus update_persisted_channel(OutPoint channel_id, ChannelMonitorUpdate update, ChannelMonitor data) {
				return ChannelMonitorUpdateStatus.LDKChannelMonitorUpdateStatus_Completed;
			}
			public void archive_persisted_channel(OutPoint channel_id) { }
		}

		class TestEventHandler : EventHandlerInterface {
			public List<Event> events = new List<Event>();
			public Result_NoneReplayEventZ handle_event(Event ev) {
				events.Add(ev);
				return Result_NoneReplayEventZ.ok();
			}
		}
		static Event get_event(ChannelManager manager) {
			TestEventHandler impl = new TestEventHandler();
			org.ldk.structs.EventHandler handler = org.ldk.structs.EventHandler.new_impl(impl);
			manager.as_EventsProvider().process_pending_events(handler);
			Assert(impl.events.Count == 1, 100);
			return impl.events[0];
		}

		class TestRouter : RouterInterface, MessageRouterInterface {
			DefaultRouter inner;
			EntropySource entropy;
			public TestRouter(DefaultRouter inner, EntropySource entropy) {
				this.inner = inner;
				this.entropy = entropy;
			}
			public Result_RouteLightningErrorZ find_route(byte[] payer, RouteParameters param, ChannelDetails[] chans, InFlightHtlcs htlcs) {
				return inner.as_Router().find_route(payer, param, chans, htlcs);
			}
			public Result_RouteLightningErrorZ find_route_with_id(byte[] payer, RouteParameters param, ChannelDetails[] chans, InFlightHtlcs htlcs, byte[] payment_hash, byte[] payment_id) {
				return inner.as_Router().find_route_with_id(payer, param, chans, htlcs, payment_hash, payment_id);
			}
			public Result_CVec_BlindedPaymentPathZNoneZ create_blinded_payment_paths(byte[] recipient, ChannelDetails[] first_hops, ReceiveTlvs tlvs, long amount_msats) {
				Result_BlindedPaymentPathNoneZ info_path = BlindedPaymentPath.one_hop(recipient, tlvs, 40, entropy);
				BlindedPaymentPath hop = ((Result_BlindedPaymentPathNoneZ.Result_BlindedPaymentPathNoneZ_OK)info_path).res;
				BlindedPaymentPath[] hops = new BlindedPaymentPath[1];
				hops[0] = hop;
				return Result_CVec_BlindedPaymentPathZNoneZ.ok(hops);
			}

			public Result_OnionMessagePathNoneZ find_path(byte[] sender, byte[][] peers, Destination dest) {
				return inner.as_MessageRouter().find_path(sender, peers, dest);
			}
			public Result_CVec_BlindedMessagePathZNoneZ create_blinded_paths(byte[] recipient, MessageContext ctx, byte[][] peers) {
				Result_BlindedMessagePathNoneZ path = BlindedMessagePath.one_hop(recipient, ctx, entropy);
				Assert(path.is_ok(), 2);
				BlindedMessagePath[] paths = new BlindedMessagePath[1];
				paths[0] = ((Result_BlindedMessagePathNoneZ.Result_BlindedMessagePathNoneZ_OK)path).res;
				return Result_CVec_BlindedMessagePathZNoneZ.ok(paths);
			}
			public Result_CVec_BlindedMessagePathZNoneZ create_compact_blinded_paths(byte[] recipient, MessageContext ctx, MessageForwardNode[] peers) {
				return this.create_blinded_paths(recipient, ctx, new byte[0][]);
			}
		}

		class Node {
			public TestBroadcaster broadcaster = new TestBroadcaster();
			public FeeEstimator estimator = FeeEstimator.new_impl(new TestEstimator());
			public Logger logger = Logger.new_impl(new TestLogger());
			public Persist persister = Persist.new_impl(new TestPersister());
			public ChainParameters chain_params = ChainParameters.of(Network.LDKNetwork_Bitcoin, BestBlock.from_network(Network.LDKNetwork_Bitcoin));

			public BroadcasterInterface ldk_broadcaster;
			public ChainMonitor chain_monitor;
			public NetworkGraph graph;
			public MultiThreadedLockableScore scorer;
			public Router router;
			public KeysManager keys;
			public ChannelManager manager;
			public OnionMessenger messenger;

			public Node(byte seed) {
				byte[] seed_bytes = new byte[32];
				for (int i = 0; i < 32; i++) seed_bytes[i] = seed;
				keys = KeysManager.of(seed_bytes, 42, 43);

				ldk_broadcaster = BroadcasterInterface.new_impl(broadcaster);
				chain_monitor = ChainMonitor.of(Option_FilterZ.none(), ldk_broadcaster, logger, estimator, persister);
				graph = NetworkGraph.of(Network.LDKNetwork_Bitcoin, logger);
				scorer = MultiThreadedLockableScore.of(ProbabilisticScorer.of(ProbabilisticScoringDecayParameters.with_default(), graph, logger).as_Score());

				DefaultRouter router_impl = DefaultRouter.of(graph, logger, keys.as_EntropySource(), scorer.as_LockableScore(), ProbabilisticScoringFeeParameters.with_default());
				TestRouter router_wrapper = new TestRouter(router_impl, keys.as_EntropySource());
				router = Router.new_impl(router_wrapper, router_wrapper);

				UserConfig config = UserConfig.with_default();
				config.set_manually_accept_inbound_channels(true);

				manager = ChannelManager.of(estimator, chain_monitor.as_Watch(), ldk_broadcaster, router, logger, keys.as_EntropySource(), keys.as_NodeSigner(), keys.as_SignerProvider(), config, chain_params, 42);

				messenger = OnionMessenger.of(keys.as_EntropySource(), keys.as_NodeSigner(), logger, manager.as_NodeIdLookUp(), MessageRouter.new_impl(router_wrapper), manager.as_OffersMessageHandler(), IgnoringMessageHandler.of().as_AsyncPaymentsMessageHandler(), IgnoringMessageHandler.of().as_CustomOnionMessageHandler());
			}
		}

		static void NodeTest() {
			Node node_a = new Node(1);
			Node node_b = new Node(2);

			InitFeatures init_features = node_a.manager.as_ChannelMessageHandler().provided_init_features(node_b.manager.get_our_node_id());
			init_features.set_onion_messages_optional();
			Init init_msg = Init.of(init_features, Option_CVec_ThirtyTwoBytesZZ.none(), Option_SocketAddressZ.none());
			node_a.manager.as_ChannelMessageHandler().peer_connected(node_b.manager.get_our_node_id(), init_msg, false);
			node_b.manager.as_ChannelMessageHandler().peer_connected(node_a.manager.get_our_node_id(), init_msg, false);
			node_a.messenger.as_OnionMessageHandler().peer_connected(node_b.manager.get_our_node_id(), init_msg, false);
			node_b.messenger.as_OnionMessageHandler().peer_connected(node_a.manager.get_our_node_id(), init_msg, false);

			Result_ChannelIdAPIErrorZ res = node_a.manager.create_channel(node_b.manager.get_our_node_id(), 100000, 42, new UInt128(43), null, null);
			Assert(res.is_ok(), 4);

			MessageSendEvent[] msgs = node_a.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(msgs.Length == 1, 5);
			Assert(msgs[0] is MessageSendEvent.MessageSendEvent_SendOpenChannel, 6);
			node_b.manager.as_ChannelMessageHandler().handle_open_channel(node_a.manager.get_our_node_id(), ((MessageSendEvent.MessageSendEvent_SendOpenChannel) msgs[0]).msg);

			Event inbound_chan = get_event(node_b.manager);
			Assert(inbound_chan is Event.Event_OpenChannelRequest, 7);
			Event.Event_OpenChannelRequest chan_request = (Event.Event_OpenChannelRequest)inbound_chan;
			Result_NoneAPIErrorZ accept_res = node_b.manager.accept_inbound_channel_from_trusted_peer_0conf(chan_request.temporary_channel_id, chan_request.counterparty_node_id, new UInt128(42));
			Assert(accept_res.is_ok(), 8);

			MessageSendEvent[] response_msgs = node_b.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(response_msgs.Length == 1, 9);
			Assert(response_msgs[0] is MessageSendEvent.MessageSendEvent_SendAcceptChannel, 10);
			node_a.manager.as_ChannelMessageHandler().handle_accept_channel(node_b.manager.get_our_node_id(), ((MessageSendEvent.MessageSendEvent_SendAcceptChannel) response_msgs[0]).msg);

			Event funding_ready = get_event(node_a.manager);
			Assert(funding_ready is Event.Event_FundingGenerationReady, 11);

			// We could use funding_transaction_generated here, but test batching
			TwoTuple_ChannelIdPublicKeyZ[] channel = new TwoTuple_ChannelIdPublicKeyZ[1];
			channel[0] = TwoTuple_ChannelIdPublicKeyZ.of(((Event.Event_FundingGenerationReady) funding_ready).temporary_channel_id, ((Event.Event_FundingGenerationReady) funding_ready).counterparty_node_id);

			// Hand-crafted transaction which has a dummy witness and can pay to our script
			byte[] transaction = new byte[99];
			transaction[0] = 2;
			transaction[1] = 0;
			transaction[2] = 0;
			transaction[3] = 0;
			transaction[4] = 0;
			transaction[5] = 1;
			transaction[6] = 1;
			transaction[7] = 66;
			transaction[8] = 66;
			transaction[9] = 66;
			transaction[10] = 66;
			transaction[11] = 66;
			transaction[12] = 66;
			transaction[13] = 66;
			transaction[14] = 66;
			transaction[15] = 66;
			transaction[16] = 66;
			transaction[17] = 66;
			transaction[18] = 66;
			transaction[19] = 66;
			transaction[20] = 66;
			transaction[21] = 66;
			transaction[22] = 66;
			transaction[23] = 66;
			transaction[24] = 66;
			transaction[25] = 66;
			transaction[26] = 66;
			transaction[27] = 66;
			transaction[28] = 66;
			transaction[29] = 66;
			transaction[30] = 66;
			transaction[31] = 66;
			transaction[32] = 66;
			transaction[33] = 66;
			transaction[34] = 66;
			transaction[35] = 66;
			transaction[36] = 66;
			transaction[37] = 66;
			transaction[38] = 66;
			transaction[39] = 18;
			transaction[40] = 0;
			transaction[41] = 0;
			transaction[42] = 0;
			transaction[43] = 0;
			transaction[44] = 253;
			transaction[45] = 255;
			transaction[46] = 255;
			transaction[47] = 255;
			transaction[48] = 1;
			transaction[49] = 160;
			transaction[50] = 134;
			transaction[51] = 1;
			transaction[52] = 0;
			transaction[53] = 0;
			transaction[54] = 0;
			transaction[55] = 0;
			transaction[56] = 0;
			transaction[57] = 34;

			Assert(((Event.Event_FundingGenerationReady) funding_ready).output_script.Length == 34, 12);
			for (int i = 0; i < 34; i++) {
				transaction[58 + i] = ((Event.Event_FundingGenerationReady) funding_ready).output_script[i];
			}

			transaction[92] = 1;
			transaction[93] = 1;
			transaction[94] = 1;
			transaction[95] = 0;
			transaction[96] = 0;
			transaction[97] = 0;
			transaction[98] = 0;

			node_a.manager.batch_funding_transaction_generated(channel, transaction);

			MessageSendEvent[] funding_msg = node_a.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(funding_msg.Length == 1, 13);
			Assert(funding_msg[0] is MessageSendEvent.MessageSendEvent_SendFundingCreated, 14);
			node_b.manager.as_ChannelMessageHandler().handle_funding_created(node_a.manager.get_our_node_id(), ((MessageSendEvent.MessageSendEvent_SendFundingCreated) funding_msg[0]).msg);

			Event bs_chan_pending = get_event(node_b.manager);
			Assert(bs_chan_pending is Event.Event_ChannelPending, 15);

			MessageSendEvent[] signed_ready_msgs = node_b.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(signed_ready_msgs.Length == 2, 16);
			Assert(signed_ready_msgs[0] is MessageSendEvent.MessageSendEvent_SendFundingSigned, 17);
			node_a.manager.as_ChannelMessageHandler().handle_funding_signed(node_b.manager.get_our_node_id(), ((MessageSendEvent.MessageSendEvent_SendFundingSigned) signed_ready_msgs[0]).msg);
			Assert(node_a.broadcaster.broadcasted_len == 99, 18);

			Event as_chan_pending = get_event(node_a.manager);
			Assert(as_chan_pending is Event.Event_ChannelPending, 19);

			MessageSendEvent[] as_ready = node_a.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(as_ready.Length == 1, 20);
			Assert(as_ready[0] is MessageSendEvent.MessageSendEvent_SendChannelReady, 21);

			Assert(signed_ready_msgs[1] is MessageSendEvent.MessageSendEvent_SendChannelReady, 22);
			node_a.manager.as_ChannelMessageHandler().handle_channel_ready(node_b.manager.get_our_node_id(), ((MessageSendEvent.MessageSendEvent_SendChannelReady) signed_ready_msgs[1]).msg);

			MessageSendEvent[] as_chan_update = node_a.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(as_chan_update.Length == 1, 23);
			Assert(as_chan_update[0] is MessageSendEvent.MessageSendEvent_SendChannelUpdate, 24);

			node_b.manager.as_ChannelMessageHandler().handle_channel_ready(node_a.manager.get_our_node_id(), ((MessageSendEvent.MessageSendEvent_SendChannelReady) as_ready[0]).msg);

			Event as_chan_ready = get_event(node_a.manager);
			Assert(as_chan_ready is Event.Event_ChannelReady, 25);

			Event bs_chan_ready = get_event(node_b.manager);
			Assert(bs_chan_ready is Event.Event_ChannelReady, 26);

			MessageSendEvent[] bs_chan_update = node_b.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(bs_chan_update.Length == 1, 27);
			Assert(bs_chan_update[0] is MessageSendEvent.MessageSendEvent_SendChannelUpdate, 28);

			// Now that we have a channel, pay using a BOLT12 offer!

			Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ builder_res = node_b.manager.create_offer_builder(Option_u64Z.none());
			Assert(builder_res.is_ok(), 29);
			Result_OfferBolt12SemanticErrorZ offer_res = ((Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ.Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ_OK)builder_res).res.build();
			Assert(offer_res.is_ok(), 30);
			Offer offer = ((Result_OfferBolt12SemanticErrorZ.Result_OfferBolt12SemanticErrorZ_OK)offer_res).res;

			Result_NoneBolt12SemanticErrorZ pay_res = node_a.manager.pay_for_offer(offer, Option_u64Z.none(), Option_u64Z.some(42000), Option_StrZ.none(), new byte[32], Retry.attempts(0), Option_u64Z.none());
			Assert(pay_res.is_ok(), 31);

			OnionMessage as_invreq = node_a.messenger.as_OnionMessageHandler().next_onion_message_for_peer(node_b.manager.get_our_node_id());
			node_b.messenger.as_OnionMessageHandler().handle_onion_message(node_a.manager.get_our_node_id(), as_invreq);

			OnionMessage bs_inv = node_b.messenger.as_OnionMessageHandler().next_onion_message_for_peer(node_a.manager.get_our_node_id());
			node_a.messenger.as_OnionMessageHandler().handle_onion_message(node_b.manager.get_our_node_id(), bs_inv);

			// At this point node_a will generate a commitment update for node_b, which we check exists but don't bother to handle:
			MessageSendEvent[] as_commit = node_a.manager.as_MessageSendEventsProvider().get_and_clear_pending_msg_events();
			Assert(as_commit.Length == 1, 32);
			Assert(as_commit[0] is MessageSendEvent.MessageSendEvent_UpdateHTLCs, 33);
		}

		static void Bolt12ParseTest() {
			// Parse a random BOLT12 offer from the BOLT12 test cases
			const string offerStr = "lno1pgx9getnwss8vetrw3hhyuckyypwa3eyt44h6txtxquqh7lz5djge4afgfjn7k4rgrkuag0jsd5xvxg";
			const string expectedPubkey = "02eec7245d6b7d2ccb30380bfbe2a3648cd7a942653f5aa340edcea1f283686619";
			const string expectedDescription = "Test vectors";

			Result_OfferBolt12ParseErrorZ offer_res = Offer.from_str(offerStr);
			Assert(offer_res.is_ok(), 100);
			Offer offer = ((Result_OfferBolt12ParseErrorZ.Result_OfferBolt12ParseErrorZ_OK)offer_res).res;
			Assert(BitConverter.ToString(offer.signing_pubkey()).Replace("-", "").ToLower() == expectedPubkey, 101);
			Assert(offer.description().get_a() == expectedDescription, 102);
			Assert(offer.issuer() == null, 103);
			Assert(!offer.is_expired(), 104);
			Assert(!offer.expects_quantity(), 105);
			Assert(offer.supported_quantity() is Quantity.Quantity_One, 106);
			Assert(offer.amount() is Option_AmountZ.Option_AmountZ_None, 107);
			Assert(offer.supported_quantity() is Quantity.Quantity_One, 108);
			Assert(offer.to_str() == offerStr, 109);
		}

		static void Main(string[] args) {
			SimpleConstructionTest();
			SimpleTraitTest();
			NodeTest();
			Bolt12ParseTest();

			Console.WriteLine("\n\nTESTS PASSED\n\n");
			System.GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}
