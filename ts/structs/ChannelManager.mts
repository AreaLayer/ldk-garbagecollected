import { TxOut } from '../structs/TxOut.mjs';
import { TxIn } from '../structs/TxIn.mjs';
import { BigEndianScalar } from '../structs/BigEndianScalar.mjs';
import { WitnessProgram } from '../structs/WitnessProgram.mjs';
import { BalanceSource } from '../enums/BalanceSource.mjs';
import { BlindedFailure } from '../enums/BlindedFailure.mjs';
import { Bolt11SemanticError } from '../enums/Bolt11SemanticError.mjs';
import { Bolt12SemanticError } from '../enums/Bolt12SemanticError.mjs';
import { COption_NoneZ } from '../enums/COption_NoneZ.mjs';
import { ChannelMonitorUpdateStatus } from '../enums/ChannelMonitorUpdateStatus.mjs';
import { ChannelShutdownState } from '../enums/ChannelShutdownState.mjs';
import { ConfirmationTarget } from '../enums/ConfirmationTarget.mjs';
import { CreationError } from '../enums/CreationError.mjs';
import { Currency } from '../enums/Currency.mjs';
import { Direction } from '../enums/Direction.mjs';
import { HTLCClaim } from '../enums/HTLCClaim.mjs';
import { IOError } from '../enums/IOError.mjs';
import { InboundHTLCStateDetails } from '../enums/InboundHTLCStateDetails.mjs';
import { Level } from '../enums/Level.mjs';
import { Network } from '../enums/Network.mjs';
import { OutboundHTLCStateDetails } from '../enums/OutboundHTLCStateDetails.mjs';
import { PaymentFailureReason } from '../enums/PaymentFailureReason.mjs';
import { Recipient } from '../enums/Recipient.mjs';
import { RetryableSendFailure } from '../enums/RetryableSendFailure.mjs';
import { Secp256k1Error } from '../enums/Secp256k1Error.mjs';
import { ShortChannelIdError } from '../enums/ShortChannelIdError.mjs';
import { SiPrefix } from '../enums/SiPrefix.mjs';
import { SocketAddressParseError } from '../enums/SocketAddressParseError.mjs';
import { UtxoLookupError } from '../enums/UtxoLookupError.mjs';
import { Bech32Error } from '../structs/Bech32Error.mjs';
import { RefundMaybeWithDerivedMetadataBuilder } from '../structs/RefundMaybeWithDerivedMetadataBuilder.mjs';
import { Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ } from '../structs/Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ.mjs';
import { Refund } from '../structs/Refund.mjs';
import { Result_RefundBolt12SemanticErrorZ } from '../structs/Result_RefundBolt12SemanticErrorZ.mjs';
import { Option_u64Z } from '../structs/Option_u64Z.mjs';
import { BlindedMessagePath } from '../structs/BlindedMessagePath.mjs';
import { DecodeError } from '../structs/DecodeError.mjs';
import { Result_RefundDecodeErrorZ } from '../structs/Result_RefundDecodeErrorZ.mjs';
import { Bolt12ParseError } from '../structs/Bolt12ParseError.mjs';
import { Result_RefundBolt12ParseErrorZ } from '../structs/Result_RefundBolt12ParseErrorZ.mjs';
import { Retry } from '../structs/Retry.mjs';
import { Result_RetryDecodeErrorZ } from '../structs/Result_RetryDecodeErrorZ.mjs';
import { ShutdownScript } from '../structs/ShutdownScript.mjs';
import { APIError } from '../structs/APIError.mjs';
import { Result_NoneAPIErrorZ } from '../structs/Result_NoneAPIErrorZ.mjs';
import { Option_ThirtyTwoBytesZ } from '../structs/Option_ThirtyTwoBytesZ.mjs';
import { Option_CVec_u8ZZ } from '../structs/Option_CVec_u8ZZ.mjs';
import { RecipientOnionFields } from '../structs/RecipientOnionFields.mjs';
import { Result_RecipientOnionFieldsDecodeErrorZ } from '../structs/Result_RecipientOnionFieldsDecodeErrorZ.mjs';
import { TwoTuple_u64CVec_u8ZZ } from '../structs/TwoTuple_u64CVec_u8ZZ.mjs';
import { Result_RecipientOnionFieldsNoneZ } from '../structs/Result_RecipientOnionFieldsNoneZ.mjs';
import { UnsignedBolt12Invoice } from '../structs/UnsignedBolt12Invoice.mjs';
import { Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ } from '../structs/Result_UnsignedBolt12InvoiceBolt12SemanticErrorZ.mjs';
import { Bolt12Invoice } from '../structs/Bolt12Invoice.mjs';
import { Result_Bolt12InvoiceBolt12SemanticErrorZ } from '../structs/Result_Bolt12InvoiceBolt12SemanticErrorZ.mjs';
import { Result_SchnorrSignatureNoneZ } from '../structs/Result_SchnorrSignatureNoneZ.mjs';
import { Option_CVec_ThirtyTwoBytesZZ } from '../structs/Option_CVec_ThirtyTwoBytesZZ.mjs';
import { Amount } from '../structs/Amount.mjs';
import { Option_AmountZ } from '../structs/Option_AmountZ.mjs';
import { Quantity } from '../structs/Quantity.mjs';
import { Option_QuantityZ } from '../structs/Option_QuantityZ.mjs';
import { Result_ThirtyTwoBytesNoneZ } from '../structs/Result_ThirtyTwoBytesNoneZ.mjs';
import { Result_Bolt12InvoiceDecodeErrorZ } from '../structs/Result_Bolt12InvoiceDecodeErrorZ.mjs';
import { DelayedPaymentOutputDescriptor } from '../structs/DelayedPaymentOutputDescriptor.mjs';
import { Result_DelayedPaymentOutputDescriptorDecodeErrorZ } from '../structs/Result_DelayedPaymentOutputDescriptorDecodeErrorZ.mjs';
import { StaticPaymentOutputDescriptor } from '../structs/StaticPaymentOutputDescriptor.mjs';
import { Result_StaticPaymentOutputDescriptorDecodeErrorZ } from '../structs/Result_StaticPaymentOutputDescriptorDecodeErrorZ.mjs';
import { OutPoint } from '../structs/OutPoint.mjs';
import { SpendableOutputDescriptor } from '../structs/SpendableOutputDescriptor.mjs';
import { Result_SpendableOutputDescriptorDecodeErrorZ } from '../structs/Result_SpendableOutputDescriptorDecodeErrorZ.mjs';
import { Option_u32Z } from '../structs/Option_u32Z.mjs';
import { TwoTuple_CVec_u8Zu64Z } from '../structs/TwoTuple_CVec_u8Zu64Z.mjs';
import { Result_C2Tuple_CVec_u8Zu64ZNoneZ } from '../structs/Result_C2Tuple_CVec_u8Zu64ZNoneZ.mjs';
import { ChannelDerivationParameters } from '../structs/ChannelDerivationParameters.mjs';
import { Result_ChannelDerivationParametersDecodeErrorZ } from '../structs/Result_ChannelDerivationParametersDecodeErrorZ.mjs';
import { HTLCDescriptor } from '../structs/HTLCDescriptor.mjs';
import { Result_HTLCDescriptorDecodeErrorZ } from '../structs/Result_HTLCDescriptorDecodeErrorZ.mjs';
import { Result_PublicKeyNoneZ } from '../structs/Result_PublicKeyNoneZ.mjs';
import { Result__u832NoneZ } from '../structs/Result__u832NoneZ.mjs';
import { Result_NoneNoneZ } from '../structs/Result_NoneNoneZ.mjs';
import { Option_BigEndianScalarZ } from '../structs/Option_BigEndianScalarZ.mjs';
import { Result_RecoverableSignatureNoneZ } from '../structs/Result_RecoverableSignatureNoneZ.mjs';
import { Result_ECDSASignatureNoneZ } from '../structs/Result_ECDSASignatureNoneZ.mjs';
import { Result_TransactionNoneZ } from '../structs/Result_TransactionNoneZ.mjs';
import { TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ } from '../structs/TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ.mjs';
import { Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ } from '../structs/Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ.mjs';
import { CommitmentTransaction } from '../structs/CommitmentTransaction.mjs';
import { HolderCommitmentTransaction } from '../structs/HolderCommitmentTransaction.mjs';
import { HTLCOutputInCommitment } from '../structs/HTLCOutputInCommitment.mjs';
import { ClosingTransaction } from '../structs/ClosingTransaction.mjs';
import { UnsignedChannelAnnouncement } from '../structs/UnsignedChannelAnnouncement.mjs';
import { ChannelPublicKeys } from '../structs/ChannelPublicKeys.mjs';
import { ChannelTransactionParameters } from '../structs/ChannelTransactionParameters.mjs';
import { ChannelSigner, ChannelSignerInterface } from '../structs/ChannelSigner.mjs';
import { EcdsaChannelSigner, EcdsaChannelSignerInterface } from '../structs/EcdsaChannelSigner.mjs';
import { Result_EcdsaChannelSignerDecodeErrorZ } from '../structs/Result_EcdsaChannelSignerDecodeErrorZ.mjs';
import { Result_CVec_u8ZNoneZ } from '../structs/Result_CVec_u8ZNoneZ.mjs';
import { Result_ShutdownScriptNoneZ } from '../structs/Result_ShutdownScriptNoneZ.mjs';
import { Option_u16Z } from '../structs/Option_u16Z.mjs';
import { Option_boolZ } from '../structs/Option_boolZ.mjs';
import { Result_WitnessNoneZ } from '../structs/Result_WitnessNoneZ.mjs';
import { InMemorySigner } from '../structs/InMemorySigner.mjs';
import { Result_InMemorySignerDecodeErrorZ } from '../structs/Result_InMemorySignerDecodeErrorZ.mjs';
import { RouteParameters } from '../structs/RouteParameters.mjs';
import { ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ } from '../structs/ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ.mjs';
import { Result_C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZNoneZ } from '../structs/Result_C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZNoneZ.mjs';
import { ChannelDetails } from '../structs/ChannelDetails.mjs';
import { Route } from '../structs/Route.mjs';
import { LightningError } from '../structs/LightningError.mjs';
import { Result_RouteLightningErrorZ } from '../structs/Result_RouteLightningErrorZ.mjs';
import { BlindedPaymentPath } from '../structs/BlindedPaymentPath.mjs';
import { Result_CVec_BlindedPaymentPathZNoneZ } from '../structs/Result_CVec_BlindedPaymentPathZNoneZ.mjs';
import { OnionMessagePath } from '../structs/OnionMessagePath.mjs';
import { Result_OnionMessagePathNoneZ } from '../structs/Result_OnionMessagePathNoneZ.mjs';
import { Result_CVec_BlindedMessagePathZNoneZ } from '../structs/Result_CVec_BlindedMessagePathZNoneZ.mjs';
import { MessageForwardNode } from '../structs/MessageForwardNode.mjs';
import { InFlightHtlcs } from '../structs/InFlightHtlcs.mjs';
import { Result_InFlightHtlcsDecodeErrorZ } from '../structs/Result_InFlightHtlcsDecodeErrorZ.mjs';
import { RouteHop } from '../structs/RouteHop.mjs';
import { Result_RouteHopDecodeErrorZ } from '../structs/Result_RouteHopDecodeErrorZ.mjs';
import { BlindedHop } from '../structs/BlindedHop.mjs';
import { BlindedTail } from '../structs/BlindedTail.mjs';
import { Result_BlindedTailDecodeErrorZ } from '../structs/Result_BlindedTailDecodeErrorZ.mjs';
import { Path } from '../structs/Path.mjs';
import { Result_RouteDecodeErrorZ } from '../structs/Result_RouteDecodeErrorZ.mjs';
import { Result_RouteParametersDecodeErrorZ } from '../structs/Result_RouteParametersDecodeErrorZ.mjs';
import { PaymentParameters } from '../structs/PaymentParameters.mjs';
import { Result_PaymentParametersDecodeErrorZ } from '../structs/Result_PaymentParametersDecodeErrorZ.mjs';
import { RouteHint } from '../structs/RouteHint.mjs';
import { Result_RouteHintDecodeErrorZ } from '../structs/Result_RouteHintDecodeErrorZ.mjs';
import { RouteHintHop } from '../structs/RouteHintHop.mjs';
import { Result_RouteHintHopDecodeErrorZ } from '../structs/Result_RouteHintHopDecodeErrorZ.mjs';
import { FixedPenaltyScorer } from '../structs/FixedPenaltyScorer.mjs';
import { Result_FixedPenaltyScorerDecodeErrorZ } from '../structs/Result_FixedPenaltyScorerDecodeErrorZ.mjs';
import { NodeId } from '../structs/NodeId.mjs';
import { TwoTuple_u64u64Z } from '../structs/TwoTuple_u64u64Z.mjs';
import { Option_C2Tuple_u64u64ZZ } from '../structs/Option_C2Tuple_u64u64ZZ.mjs';
import { TwoTuple_Z } from '../structs/TwoTuple_Z.mjs';
import { TwoTuple__u1632_u1632Z } from '../structs/TwoTuple__u1632_u1632Z.mjs';
import { Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ } from '../structs/Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ.mjs';
import { Option_f64Z } from '../structs/Option_f64Z.mjs';
import { Record } from '../structs/Record.mjs';
import { Logger, LoggerInterface } from '../structs/Logger.mjs';
import { NetworkGraph } from '../structs/NetworkGraph.mjs';
import { ProbabilisticScorer } from '../structs/ProbabilisticScorer.mjs';
import { Result_ProbabilisticScorerDecodeErrorZ } from '../structs/Result_ProbabilisticScorerDecodeErrorZ.mjs';
import { BestBlock } from '../structs/BestBlock.mjs';
import { Result_BestBlockDecodeErrorZ } from '../structs/Result_BestBlockDecodeErrorZ.mjs';
import { TwoTuple_usizeTransactionZ } from '../structs/TwoTuple_usizeTransactionZ.mjs';
import { ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ } from '../structs/ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ.mjs';
import { Result_ChannelMonitorUpdateStatusNoneZ } from '../structs/Result_ChannelMonitorUpdateStatusNoneZ.mjs';
import { HTLCUpdate } from '../structs/HTLCUpdate.mjs';
import { UntrustedString } from '../structs/UntrustedString.mjs';
import { ClosureReason } from '../structs/ClosureReason.mjs';
import { ChannelId } from '../structs/ChannelId.mjs';
import { MonitorEvent } from '../structs/MonitorEvent.mjs';
import { FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ } from '../structs/FourTuple_OutPointChannelIdCVec_MonitorEventZPublicKeyZ.mjs';
import { InitFeatures } from '../structs/InitFeatures.mjs';
import { Result_InitFeaturesDecodeErrorZ } from '../structs/Result_InitFeaturesDecodeErrorZ.mjs';
import { ChannelFeatures } from '../structs/ChannelFeatures.mjs';
import { Result_ChannelFeaturesDecodeErrorZ } from '../structs/Result_ChannelFeaturesDecodeErrorZ.mjs';
import { NodeFeatures } from '../structs/NodeFeatures.mjs';
import { Result_NodeFeaturesDecodeErrorZ } from '../structs/Result_NodeFeaturesDecodeErrorZ.mjs';
import { Bolt11InvoiceFeatures } from '../structs/Bolt11InvoiceFeatures.mjs';
import { Result_Bolt11InvoiceFeaturesDecodeErrorZ } from '../structs/Result_Bolt11InvoiceFeaturesDecodeErrorZ.mjs';
import { Bolt12InvoiceFeatures } from '../structs/Bolt12InvoiceFeatures.mjs';
import { Result_Bolt12InvoiceFeaturesDecodeErrorZ } from '../structs/Result_Bolt12InvoiceFeaturesDecodeErrorZ.mjs';
import { BlindedHopFeatures } from '../structs/BlindedHopFeatures.mjs';
import { Result_BlindedHopFeaturesDecodeErrorZ } from '../structs/Result_BlindedHopFeaturesDecodeErrorZ.mjs';
import { ChannelTypeFeatures } from '../structs/ChannelTypeFeatures.mjs';
import { Result_ChannelTypeFeaturesDecodeErrorZ } from '../structs/Result_ChannelTypeFeaturesDecodeErrorZ.mjs';
import { OfferId } from '../structs/OfferId.mjs';
import { Result_OfferIdDecodeErrorZ } from '../structs/Result_OfferIdDecodeErrorZ.mjs';
import { Result_NoneBolt12SemanticErrorZ } from '../structs/Result_NoneBolt12SemanticErrorZ.mjs';
import { Offer } from '../structs/Offer.mjs';
import { Result_OfferBolt12SemanticErrorZ } from '../structs/Result_OfferBolt12SemanticErrorZ.mjs';
import { InvoiceRequestWithDerivedPayerIdBuilder } from '../structs/InvoiceRequestWithDerivedPayerIdBuilder.mjs';
import { Result_InvoiceRequestWithDerivedPayerIdBuilderBolt12SemanticErrorZ } from '../structs/Result_InvoiceRequestWithDerivedPayerIdBuilderBolt12SemanticErrorZ.mjs';
import { InvoiceRequestWithExplicitPayerIdBuilder } from '../structs/InvoiceRequestWithExplicitPayerIdBuilder.mjs';
import { Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ } from '../structs/Result_InvoiceRequestWithExplicitPayerIdBuilderBolt12SemanticErrorZ.mjs';
import { Result_OfferDecodeErrorZ } from '../structs/Result_OfferDecodeErrorZ.mjs';
import { Result_OfferBolt12ParseErrorZ } from '../structs/Result_OfferBolt12ParseErrorZ.mjs';
import { Result_NodeIdDecodeErrorZ } from '../structs/Result_NodeIdDecodeErrorZ.mjs';
import { Result_PublicKeySecp256k1ErrorZ } from '../structs/Result_PublicKeySecp256k1ErrorZ.mjs';
import { NetworkUpdate } from '../structs/NetworkUpdate.mjs';
import { Option_NetworkUpdateZ } from '../structs/Option_NetworkUpdateZ.mjs';
import { Result_COption_NetworkUpdateZDecodeErrorZ } from '../structs/Result_COption_NetworkUpdateZDecodeErrorZ.mjs';
import { Result_TxOutUtxoLookupErrorZ } from '../structs/Result_TxOutUtxoLookupErrorZ.mjs';
import { UtxoFuture } from '../structs/UtxoFuture.mjs';
import { UtxoResult } from '../structs/UtxoResult.mjs';
import { UtxoLookup, UtxoLookupInterface } from '../structs/UtxoLookup.mjs';
import { Option_UtxoLookupZ } from '../structs/Option_UtxoLookupZ.mjs';
import { Result_NoneLightningErrorZ } from '../structs/Result_NoneLightningErrorZ.mjs';
import { Result_boolLightningErrorZ } from '../structs/Result_boolLightningErrorZ.mjs';
import { ChannelAnnouncement } from '../structs/ChannelAnnouncement.mjs';
import { ChannelUpdate } from '../structs/ChannelUpdate.mjs';
import { ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ } from '../structs/ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ.mjs';
import { Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ } from '../structs/Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ.mjs';
import { AcceptChannel } from '../structs/AcceptChannel.mjs';
import { AcceptChannelV2 } from '../structs/AcceptChannelV2.mjs';
import { OpenChannel } from '../structs/OpenChannel.mjs';
import { OpenChannelV2 } from '../structs/OpenChannelV2.mjs';
import { FundingCreated } from '../structs/FundingCreated.mjs';
import { FundingSigned } from '../structs/FundingSigned.mjs';
import { Stfu } from '../structs/Stfu.mjs';
import { SpliceInit } from '../structs/SpliceInit.mjs';
import { SpliceAck } from '../structs/SpliceAck.mjs';
import { SpliceLocked } from '../structs/SpliceLocked.mjs';
import { TxAddInput } from '../structs/TxAddInput.mjs';
import { TxAddOutput } from '../structs/TxAddOutput.mjs';
import { TxRemoveInput } from '../structs/TxRemoveInput.mjs';
import { TxRemoveOutput } from '../structs/TxRemoveOutput.mjs';
import { TxComplete } from '../structs/TxComplete.mjs';
import { TxSignatures } from '../structs/TxSignatures.mjs';
import { TxInitRbf } from '../structs/TxInitRbf.mjs';
import { TxAckRbf } from '../structs/TxAckRbf.mjs';
import { TxAbort } from '../structs/TxAbort.mjs';
import { ChannelReady } from '../structs/ChannelReady.mjs';
import { AnnouncementSignatures } from '../structs/AnnouncementSignatures.mjs';
import { CommitmentUpdate } from '../structs/CommitmentUpdate.mjs';
import { RevokeAndACK } from '../structs/RevokeAndACK.mjs';
import { ClosingSigned } from '../structs/ClosingSigned.mjs';
import { Shutdown } from '../structs/Shutdown.mjs';
import { ChannelReestablish } from '../structs/ChannelReestablish.mjs';
import { NodeAnnouncement } from '../structs/NodeAnnouncement.mjs';
import { ErrorMessage } from '../structs/ErrorMessage.mjs';
import { WarningMessage } from '../structs/WarningMessage.mjs';
import { ErrorAction } from '../structs/ErrorAction.mjs';
import { QueryChannelRange } from '../structs/QueryChannelRange.mjs';
import { QueryShortChannelIds } from '../structs/QueryShortChannelIds.mjs';
import { ReplyChannelRange } from '../structs/ReplyChannelRange.mjs';
import { GossipTimestampFilter } from '../structs/GossipTimestampFilter.mjs';
import { MessageSendEvent } from '../structs/MessageSendEvent.mjs';
import { ChannelUpdateInfo } from '../structs/ChannelUpdateInfo.mjs';
import { Result_ChannelUpdateInfoDecodeErrorZ } from '../structs/Result_ChannelUpdateInfoDecodeErrorZ.mjs';
import { ChannelInfo } from '../structs/ChannelInfo.mjs';
import { Result_ChannelInfoDecodeErrorZ } from '../structs/Result_ChannelInfoDecodeErrorZ.mjs';
import { RoutingFees } from '../structs/RoutingFees.mjs';
import { Result_RoutingFeesDecodeErrorZ } from '../structs/Result_RoutingFeesDecodeErrorZ.mjs';
import { Hostname } from '../structs/Hostname.mjs';
import { SocketAddress } from '../structs/SocketAddress.mjs';
import { NodeAnnouncementDetails } from '../structs/NodeAnnouncementDetails.mjs';
import { NodeAnnouncementInfo } from '../structs/NodeAnnouncementInfo.mjs';
import { Result_NodeAnnouncementInfoDecodeErrorZ } from '../structs/Result_NodeAnnouncementInfoDecodeErrorZ.mjs';
import { NodeAlias } from '../structs/NodeAlias.mjs';
import { Result_NodeAliasDecodeErrorZ } from '../structs/Result_NodeAliasDecodeErrorZ.mjs';
import { Option_NodeAnnouncementInfoZ } from '../structs/Option_NodeAnnouncementInfoZ.mjs';
import { NodeInfo } from '../structs/NodeInfo.mjs';
import { Result_NodeInfoDecodeErrorZ } from '../structs/Result_NodeInfoDecodeErrorZ.mjs';
import { Result_NetworkGraphDecodeErrorZ } from '../structs/Result_NetworkGraphDecodeErrorZ.mjs';
import { Option_CVec_SocketAddressZZ } from '../structs/Option_CVec_SocketAddressZZ.mjs';
import { Result_u64ShortChannelIdErrorZ } from '../structs/Result_u64ShortChannelIdErrorZ.mjs';
import { PendingHTLCInfo } from '../structs/PendingHTLCInfo.mjs';
import { InboundHTLCErr } from '../structs/InboundHTLCErr.mjs';
import { Result_PendingHTLCInfoInboundHTLCErrZ } from '../structs/Result_PendingHTLCInfoInboundHTLCErrZ.mjs';
import { Utxo } from '../structs/Utxo.mjs';
import { Option_TxOutZ } from '../structs/Option_TxOutZ.mjs';
import { Input } from '../structs/Input.mjs';
import { CoinSelection } from '../structs/CoinSelection.mjs';
import { Result_CoinSelectionNoneZ } from '../structs/Result_CoinSelectionNoneZ.mjs';
import { Result_CVec_UtxoZNoneZ } from '../structs/Result_CVec_UtxoZNoneZ.mjs';
import { UnknownPaymentContext } from '../structs/UnknownPaymentContext.mjs';
import { Bolt12OfferContext } from '../structs/Bolt12OfferContext.mjs';
import { Bolt12RefundContext } from '../structs/Bolt12RefundContext.mjs';
import { PaymentContext } from '../structs/PaymentContext.mjs';
import { Option_PaymentContextZ } from '../structs/Option_PaymentContextZ.mjs';
import { TwoTuple_u64u16Z } from '../structs/TwoTuple_u64u16Z.mjs';
import { Option_C2Tuple_u64u16ZZ } from '../structs/Option_C2Tuple_u64u16ZZ.mjs';
import { Result_ChannelIdAPIErrorZ } from '../structs/Result_ChannelIdAPIErrorZ.mjs';
import { RecentPaymentDetails } from '../structs/RecentPaymentDetails.mjs';
import { PaymentSendFailure } from '../structs/PaymentSendFailure.mjs';
import { Result_NonePaymentSendFailureZ } from '../structs/Result_NonePaymentSendFailureZ.mjs';
import { Result_NoneRetryableSendFailureZ } from '../structs/Result_NoneRetryableSendFailureZ.mjs';
import { Result_ThirtyTwoBytesPaymentSendFailureZ } from '../structs/Result_ThirtyTwoBytesPaymentSendFailureZ.mjs';
import { Result_ThirtyTwoBytesRetryableSendFailureZ } from '../structs/Result_ThirtyTwoBytesRetryableSendFailureZ.mjs';
import { TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ } from '../structs/TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZPaymentSendFailureZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZPaymentSendFailureZ.mjs';
import { ProbeSendFailure } from '../structs/ProbeSendFailure.mjs';
import { Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ } from '../structs/Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ.mjs';
import { TwoTuple_ChannelIdPublicKeyZ } from '../structs/TwoTuple_ChannelIdPublicKeyZ.mjs';
import { OfferWithDerivedMetadataBuilder } from '../structs/OfferWithDerivedMetadataBuilder.mjs';
import { Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ } from '../structs/Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ.mjs';
import { Option_StrZ } from '../structs/Option_StrZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ.mjs';
import { Result_ThirtyTwoBytesAPIErrorZ } from '../structs/Result_ThirtyTwoBytesAPIErrorZ.mjs';
import { Nonce } from '../structs/Nonce.mjs';
import { OffersContext } from '../structs/OffersContext.mjs';
import { Option_OffersContextZ } from '../structs/Option_OffersContextZ.mjs';
import { InvoiceRequest } from '../structs/InvoiceRequest.mjs';
import { InvoiceError } from '../structs/InvoiceError.mjs';
import { OffersMessage } from '../structs/OffersMessage.mjs';
import { ResponseInstruction } from '../structs/ResponseInstruction.mjs';
import { TwoTuple_OffersMessageResponseInstructionZ } from '../structs/TwoTuple_OffersMessageResponseInstructionZ.mjs';
import { Option_C2Tuple_OffersMessageResponseInstructionZZ } from '../structs/Option_C2Tuple_OffersMessageResponseInstructionZZ.mjs';
import { Destination } from '../structs/Destination.mjs';
import { MessageContext } from '../structs/MessageContext.mjs';
import { MessageSendInstructions } from '../structs/MessageSendInstructions.mjs';
import { TwoTuple_OffersMessageMessageSendInstructionsZ } from '../structs/TwoTuple_OffersMessageMessageSendInstructionsZ.mjs';
import { ReleaseHeldHtlc } from '../structs/ReleaseHeldHtlc.mjs';
import { TwoTuple_ReleaseHeldHtlcResponseInstructionZ } from '../structs/TwoTuple_ReleaseHeldHtlcResponseInstructionZ.mjs';
import { Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ } from '../structs/Option_C2Tuple_ReleaseHeldHtlcResponseInstructionZZ.mjs';
import { HeldHtlcAvailable } from '../structs/HeldHtlcAvailable.mjs';
import { AsyncPaymentsMessage } from '../structs/AsyncPaymentsMessage.mjs';
import { TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ } from '../structs/TwoTuple_AsyncPaymentsMessageMessageSendInstructionsZ.mjs';
import { PhantomRouteHints } from '../structs/PhantomRouteHints.mjs';
import { Result_PhantomRouteHintsDecodeErrorZ } from '../structs/Result_PhantomRouteHintsDecodeErrorZ.mjs';
import { BlindedForward } from '../structs/BlindedForward.mjs';
import { Result_BlindedForwardDecodeErrorZ } from '../structs/Result_BlindedForwardDecodeErrorZ.mjs';
import { OnionPacket } from '../structs/OnionPacket.mjs';
import { FinalOnionHopData } from '../structs/FinalOnionHopData.mjs';
import { PendingHTLCRouting } from '../structs/PendingHTLCRouting.mjs';
import { Result_PendingHTLCRoutingDecodeErrorZ } from '../structs/Result_PendingHTLCRoutingDecodeErrorZ.mjs';
import { Result_PendingHTLCInfoDecodeErrorZ } from '../structs/Result_PendingHTLCInfoDecodeErrorZ.mjs';
import { Result_BlindedFailureDecodeErrorZ } from '../structs/Result_BlindedFailureDecodeErrorZ.mjs';
import { ChannelMonitor } from '../structs/ChannelMonitor.mjs';
import { ChannelMonitorUpdate } from '../structs/ChannelMonitorUpdate.mjs';
import { Watch, WatchInterface } from '../structs/Watch.mjs';
import { BroadcasterInterface, BroadcasterInterfaceInterface } from '../structs/BroadcasterInterface.mjs';
import { EntropySource, EntropySourceInterface } from '../structs/EntropySource.mjs';
import { RawBolt11Invoice } from '../structs/RawBolt11Invoice.mjs';
import { UnsignedInvoiceRequest } from '../structs/UnsignedInvoiceRequest.mjs';
import { UnsignedChannelUpdate } from '../structs/UnsignedChannelUpdate.mjs';
import { UnsignedNodeAnnouncement } from '../structs/UnsignedNodeAnnouncement.mjs';
import { UnsignedGossipMessage } from '../structs/UnsignedGossipMessage.mjs';
import { NodeSigner, NodeSignerInterface } from '../structs/NodeSigner.mjs';
import { SignerProvider, SignerProviderInterface } from '../structs/SignerProvider.mjs';
import { FeeEstimator, FeeEstimatorInterface } from '../structs/FeeEstimator.mjs';
import { ReceiveTlvs } from '../structs/ReceiveTlvs.mjs';
import { MessageRouter, MessageRouterInterface } from '../structs/MessageRouter.mjs';
import { Router, RouterInterface } from '../structs/Router.mjs';
import { TwoTuple_ThirtyTwoBytesChannelManagerZ } from '../structs/TwoTuple_ThirtyTwoBytesChannelManagerZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ.mjs';
import { MaxDustHTLCExposure } from '../structs/MaxDustHTLCExposure.mjs';
import { Result_MaxDustHTLCExposureDecodeErrorZ } from '../structs/Result_MaxDustHTLCExposureDecodeErrorZ.mjs';
import { ChannelConfig } from '../structs/ChannelConfig.mjs';
import { Result_ChannelConfigDecodeErrorZ } from '../structs/Result_ChannelConfigDecodeErrorZ.mjs';
import { Option_MaxDustHTLCExposureZ } from '../structs/Option_MaxDustHTLCExposureZ.mjs';
import { Option_APIErrorZ } from '../structs/Option_APIErrorZ.mjs';
import { Result_COption_APIErrorZDecodeErrorZ } from '../structs/Result_COption_APIErrorZDecodeErrorZ.mjs';
import { Result_ChannelMonitorUpdateDecodeErrorZ } from '../structs/Result_ChannelMonitorUpdateDecodeErrorZ.mjs';
import { Option_MonitorEventZ } from '../structs/Option_MonitorEventZ.mjs';
import { Result_COption_MonitorEventZDecodeErrorZ } from '../structs/Result_COption_MonitorEventZDecodeErrorZ.mjs';
import { Result_HTLCUpdateDecodeErrorZ } from '../structs/Result_HTLCUpdateDecodeErrorZ.mjs';
import { TwoTuple_OutPointCVec_u8ZZ } from '../structs/TwoTuple_OutPointCVec_u8ZZ.mjs';
import { TwoTuple_u32CVec_u8ZZ } from '../structs/TwoTuple_u32CVec_u8ZZ.mjs';
import { TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32CVec_u8ZZZZ } from '../structs/TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32CVec_u8ZZZZ.mjs';
import { ReplayEvent } from '../structs/ReplayEvent.mjs';
import { Result_NoneReplayEventZ } from '../structs/Result_NoneReplayEventZ.mjs';
import { TwoTuple_u32TxOutZ } from '../structs/TwoTuple_u32TxOutZ.mjs';
import { TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ } from '../structs/TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ.mjs';
import { Balance } from '../structs/Balance.mjs';
import { TwoTuple_ThirtyTwoBytesChannelMonitorZ } from '../structs/TwoTuple_ThirtyTwoBytesChannelMonitorZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.mjs';
import { Type, TypeInterface } from '../structs/Type.mjs';
import { TwoTuple_PublicKeyTypeZ } from '../structs/TwoTuple_PublicKeyTypeZ.mjs';
import { OnionMessageContents, OnionMessageContentsInterface } from '../structs/OnionMessageContents.mjs';
import { TwoTuple_OnionMessageContentsResponseInstructionZ } from '../structs/TwoTuple_OnionMessageContentsResponseInstructionZ.mjs';
import { Option_C2Tuple_OnionMessageContentsResponseInstructionZZ } from '../structs/Option_C2Tuple_OnionMessageContentsResponseInstructionZZ.mjs';
import { Option_OnionMessageContentsZ } from '../structs/Option_OnionMessageContentsZ.mjs';
import { Result_COption_OnionMessageContentsZDecodeErrorZ } from '../structs/Result_COption_OnionMessageContentsZDecodeErrorZ.mjs';
import { TwoTuple_OnionMessageContentsMessageSendInstructionsZ } from '../structs/TwoTuple_OnionMessageContentsMessageSendInstructionsZ.mjs';
import { Option_TypeZ } from '../structs/Option_TypeZ.mjs';
import { Result_COption_TypeZDecodeErrorZ } from '../structs/Result_COption_TypeZDecodeErrorZ.mjs';
import { Option_SocketAddressZ } from '../structs/Option_SocketAddressZ.mjs';
import { PeerDetails } from '../structs/PeerDetails.mjs';
import { PeerHandleError } from '../structs/PeerHandleError.mjs';
import { Result_CVec_u8ZPeerHandleErrorZ } from '../structs/Result_CVec_u8ZPeerHandleErrorZ.mjs';
import { Result_NonePeerHandleErrorZ } from '../structs/Result_NonePeerHandleErrorZ.mjs';
import { Result_boolPeerHandleErrorZ } from '../structs/Result_boolPeerHandleErrorZ.mjs';
import { GraphSyncError } from '../structs/GraphSyncError.mjs';
import { Result_u32GraphSyncErrorZ } from '../structs/Result_u32GraphSyncErrorZ.mjs';
import { Result_CVec_u8ZIOErrorZ } from '../structs/Result_CVec_u8ZIOErrorZ.mjs';
import { Result_NoneIOErrorZ } from '../structs/Result_NoneIOErrorZ.mjs';
import { Result_CVec_StrZIOErrorZ } from '../structs/Result_CVec_StrZIOErrorZ.mjs';
import { Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ } from '../structs/Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesChannelMonitorZIOErrorZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesChannelMonitorZIOErrorZ.mjs';
import { Result_UnsignedInvoiceRequestBolt12SemanticErrorZ } from '../structs/Result_UnsignedInvoiceRequestBolt12SemanticErrorZ.mjs';
import { Result_InvoiceRequestBolt12SemanticErrorZ } from '../structs/Result_InvoiceRequestBolt12SemanticErrorZ.mjs';
import { InvoiceWithExplicitSigningPubkeyBuilder } from '../structs/InvoiceWithExplicitSigningPubkeyBuilder.mjs';
import { Result_InvoiceWithExplicitSigningPubkeyBuilderBolt12SemanticErrorZ } from '../structs/Result_InvoiceWithExplicitSigningPubkeyBuilderBolt12SemanticErrorZ.mjs';
import { VerifiedInvoiceRequest } from '../structs/VerifiedInvoiceRequest.mjs';
import { Result_VerifiedInvoiceRequestNoneZ } from '../structs/Result_VerifiedInvoiceRequestNoneZ.mjs';
import { InvoiceWithDerivedSigningPubkeyBuilder } from '../structs/InvoiceWithDerivedSigningPubkeyBuilder.mjs';
import { Result_InvoiceWithDerivedSigningPubkeyBuilderBolt12SemanticErrorZ } from '../structs/Result_InvoiceWithDerivedSigningPubkeyBuilderBolt12SemanticErrorZ.mjs';
import { InvoiceRequestFields } from '../structs/InvoiceRequestFields.mjs';
import { Result_InvoiceRequestFieldsDecodeErrorZ } from '../structs/Result_InvoiceRequestFieldsDecodeErrorZ.mjs';
import { Option_ECDSASignatureZ } from '../structs/Option_ECDSASignatureZ.mjs';
import { Option_i64Z } from '../structs/Option_i64Z.mjs';
import { Result_SocketAddressDecodeErrorZ } from '../structs/Result_SocketAddressDecodeErrorZ.mjs';
import { Result_SocketAddressSocketAddressParseErrorZ } from '../structs/Result_SocketAddressSocketAddressParseErrorZ.mjs';
import { UpdateAddHTLC } from '../structs/UpdateAddHTLC.mjs';
import { UpdateFulfillHTLC } from '../structs/UpdateFulfillHTLC.mjs';
import { UpdateFailHTLC } from '../structs/UpdateFailHTLC.mjs';
import { UpdateFailMalformedHTLC } from '../structs/UpdateFailMalformedHTLC.mjs';
import { Result_AcceptChannelDecodeErrorZ } from '../structs/Result_AcceptChannelDecodeErrorZ.mjs';
import { Result_AcceptChannelV2DecodeErrorZ } from '../structs/Result_AcceptChannelV2DecodeErrorZ.mjs';
import { Result_StfuDecodeErrorZ } from '../structs/Result_StfuDecodeErrorZ.mjs';
import { Result_SpliceInitDecodeErrorZ } from '../structs/Result_SpliceInitDecodeErrorZ.mjs';
import { Result_SpliceAckDecodeErrorZ } from '../structs/Result_SpliceAckDecodeErrorZ.mjs';
import { Result_SpliceLockedDecodeErrorZ } from '../structs/Result_SpliceLockedDecodeErrorZ.mjs';
import { Result_TxAddInputDecodeErrorZ } from '../structs/Result_TxAddInputDecodeErrorZ.mjs';
import { Result_TxAddOutputDecodeErrorZ } from '../structs/Result_TxAddOutputDecodeErrorZ.mjs';
import { Result_TxRemoveInputDecodeErrorZ } from '../structs/Result_TxRemoveInputDecodeErrorZ.mjs';
import { Result_TxRemoveOutputDecodeErrorZ } from '../structs/Result_TxRemoveOutputDecodeErrorZ.mjs';
import { Result_TxCompleteDecodeErrorZ } from '../structs/Result_TxCompleteDecodeErrorZ.mjs';
import { Result_TxSignaturesDecodeErrorZ } from '../structs/Result_TxSignaturesDecodeErrorZ.mjs';
import { Result_TxInitRbfDecodeErrorZ } from '../structs/Result_TxInitRbfDecodeErrorZ.mjs';
import { Result_TxAckRbfDecodeErrorZ } from '../structs/Result_TxAckRbfDecodeErrorZ.mjs';
import { Result_TxAbortDecodeErrorZ } from '../structs/Result_TxAbortDecodeErrorZ.mjs';
import { Result_AnnouncementSignaturesDecodeErrorZ } from '../structs/Result_AnnouncementSignaturesDecodeErrorZ.mjs';
import { Result_ChannelReestablishDecodeErrorZ } from '../structs/Result_ChannelReestablishDecodeErrorZ.mjs';
import { Result_ClosingSignedDecodeErrorZ } from '../structs/Result_ClosingSignedDecodeErrorZ.mjs';
import { ClosingSignedFeeRange } from '../structs/ClosingSignedFeeRange.mjs';
import { Result_ClosingSignedFeeRangeDecodeErrorZ } from '../structs/Result_ClosingSignedFeeRangeDecodeErrorZ.mjs';
import { CommitmentSignedBatch } from '../structs/CommitmentSignedBatch.mjs';
import { Result_CommitmentSignedBatchDecodeErrorZ } from '../structs/Result_CommitmentSignedBatchDecodeErrorZ.mjs';
import { CommitmentSigned } from '../structs/CommitmentSigned.mjs';
import { Result_CommitmentSignedDecodeErrorZ } from '../structs/Result_CommitmentSignedDecodeErrorZ.mjs';
import { Result_FundingCreatedDecodeErrorZ } from '../structs/Result_FundingCreatedDecodeErrorZ.mjs';
import { Result_FundingSignedDecodeErrorZ } from '../structs/Result_FundingSignedDecodeErrorZ.mjs';
import { Result_ChannelReadyDecodeErrorZ } from '../structs/Result_ChannelReadyDecodeErrorZ.mjs';
import { Init } from '../structs/Init.mjs';
import { Result_InitDecodeErrorZ } from '../structs/Result_InitDecodeErrorZ.mjs';
import { Result_OpenChannelDecodeErrorZ } from '../structs/Result_OpenChannelDecodeErrorZ.mjs';
import { Result_OpenChannelV2DecodeErrorZ } from '../structs/Result_OpenChannelV2DecodeErrorZ.mjs';
import { Result_RevokeAndACKDecodeErrorZ } from '../structs/Result_RevokeAndACKDecodeErrorZ.mjs';
import { Result_ShutdownDecodeErrorZ } from '../structs/Result_ShutdownDecodeErrorZ.mjs';
import { Result_UpdateFailHTLCDecodeErrorZ } from '../structs/Result_UpdateFailHTLCDecodeErrorZ.mjs';
import { Result_UpdateFailMalformedHTLCDecodeErrorZ } from '../structs/Result_UpdateFailMalformedHTLCDecodeErrorZ.mjs';
import { UpdateFee } from '../structs/UpdateFee.mjs';
import { Result_UpdateFeeDecodeErrorZ } from '../structs/Result_UpdateFeeDecodeErrorZ.mjs';
import { Result_UpdateFulfillHTLCDecodeErrorZ } from '../structs/Result_UpdateFulfillHTLCDecodeErrorZ.mjs';
import { Result_OnionPacketDecodeErrorZ } from '../structs/Result_OnionPacketDecodeErrorZ.mjs';
import { Result_UpdateAddHTLCDecodeErrorZ } from '../structs/Result_UpdateAddHTLCDecodeErrorZ.mjs';
import { OnionMessage } from '../structs/OnionMessage.mjs';
import { Result_OnionMessageDecodeErrorZ } from '../structs/Result_OnionMessageDecodeErrorZ.mjs';
import { Result_FinalOnionHopDataDecodeErrorZ } from '../structs/Result_FinalOnionHopDataDecodeErrorZ.mjs';
import { Ping } from '../structs/Ping.mjs';
import { Result_PingDecodeErrorZ } from '../structs/Result_PingDecodeErrorZ.mjs';
import { Pong } from '../structs/Pong.mjs';
import { Result_PongDecodeErrorZ } from '../structs/Result_PongDecodeErrorZ.mjs';
import { Result_UnsignedChannelAnnouncementDecodeErrorZ } from '../structs/Result_UnsignedChannelAnnouncementDecodeErrorZ.mjs';
import { Result_ChannelAnnouncementDecodeErrorZ } from '../structs/Result_ChannelAnnouncementDecodeErrorZ.mjs';
import { Result_UnsignedChannelUpdateDecodeErrorZ } from '../structs/Result_UnsignedChannelUpdateDecodeErrorZ.mjs';
import { Result_ChannelUpdateDecodeErrorZ } from '../structs/Result_ChannelUpdateDecodeErrorZ.mjs';
import { Result_ErrorMessageDecodeErrorZ } from '../structs/Result_ErrorMessageDecodeErrorZ.mjs';
import { Result_WarningMessageDecodeErrorZ } from '../structs/Result_WarningMessageDecodeErrorZ.mjs';
import { Result_UnsignedNodeAnnouncementDecodeErrorZ } from '../structs/Result_UnsignedNodeAnnouncementDecodeErrorZ.mjs';
import { Result_NodeAnnouncementDecodeErrorZ } from '../structs/Result_NodeAnnouncementDecodeErrorZ.mjs';
import { Result_QueryShortChannelIdsDecodeErrorZ } from '../structs/Result_QueryShortChannelIdsDecodeErrorZ.mjs';
import { ReplyShortChannelIdsEnd } from '../structs/ReplyShortChannelIdsEnd.mjs';
import { Result_ReplyShortChannelIdsEndDecodeErrorZ } from '../structs/Result_ReplyShortChannelIdsEndDecodeErrorZ.mjs';
import { Result_QueryChannelRangeDecodeErrorZ } from '../structs/Result_QueryChannelRangeDecodeErrorZ.mjs';
import { Result_ReplyChannelRangeDecodeErrorZ } from '../structs/Result_ReplyChannelRangeDecodeErrorZ.mjs';
import { Result_GossipTimestampFilterDecodeErrorZ } from '../structs/Result_GossipTimestampFilterDecodeErrorZ.mjs';
import { Option_InboundHTLCStateDetailsZ } from '../structs/Option_InboundHTLCStateDetailsZ.mjs';
import { Result_COption_InboundHTLCStateDetailsZDecodeErrorZ } from '../structs/Result_COption_InboundHTLCStateDetailsZDecodeErrorZ.mjs';
import { InboundHTLCDetails } from '../structs/InboundHTLCDetails.mjs';
import { Result_InboundHTLCDetailsDecodeErrorZ } from '../structs/Result_InboundHTLCDetailsDecodeErrorZ.mjs';
import { Option_OutboundHTLCStateDetailsZ } from '../structs/Option_OutboundHTLCStateDetailsZ.mjs';
import { Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ } from '../structs/Result_COption_OutboundHTLCStateDetailsZDecodeErrorZ.mjs';
import { OutboundHTLCDetails } from '../structs/OutboundHTLCDetails.mjs';
import { Result_OutboundHTLCDetailsDecodeErrorZ } from '../structs/Result_OutboundHTLCDetailsDecodeErrorZ.mjs';
import { CounterpartyForwardingInfo } from '../structs/CounterpartyForwardingInfo.mjs';
import { Result_CounterpartyForwardingInfoDecodeErrorZ } from '../structs/Result_CounterpartyForwardingInfoDecodeErrorZ.mjs';
import { ChannelCounterparty } from '../structs/ChannelCounterparty.mjs';
import { Result_ChannelCounterpartyDecodeErrorZ } from '../structs/Result_ChannelCounterpartyDecodeErrorZ.mjs';
import { Option_ChannelShutdownStateZ } from '../structs/Option_ChannelShutdownStateZ.mjs';
import { Result_ChannelDetailsDecodeErrorZ } from '../structs/Result_ChannelDetailsDecodeErrorZ.mjs';
import { Result_ChannelShutdownStateDecodeErrorZ } from '../structs/Result_ChannelShutdownStateDecodeErrorZ.mjs';
import { Result_HeldHtlcAvailableDecodeErrorZ } from '../structs/Result_HeldHtlcAvailableDecodeErrorZ.mjs';
import { Result_ReleaseHeldHtlcDecodeErrorZ } from '../structs/Result_ReleaseHeldHtlcDecodeErrorZ.mjs';
import { Result_AsyncPaymentsMessageDecodeErrorZ } from '../structs/Result_AsyncPaymentsMessageDecodeErrorZ.mjs';
import { Result_OffersMessageDecodeErrorZ } from '../structs/Result_OffersMessageDecodeErrorZ.mjs';
import { Option_HTLCClaimZ } from '../structs/Option_HTLCClaimZ.mjs';
import { CounterpartyCommitmentSecrets } from '../structs/CounterpartyCommitmentSecrets.mjs';
import { Result_CounterpartyCommitmentSecretsDecodeErrorZ } from '../structs/Result_CounterpartyCommitmentSecretsDecodeErrorZ.mjs';
import { TxCreationKeys } from '../structs/TxCreationKeys.mjs';
import { Result_TxCreationKeysDecodeErrorZ } from '../structs/Result_TxCreationKeysDecodeErrorZ.mjs';
import { Result_ChannelPublicKeysDecodeErrorZ } from '../structs/Result_ChannelPublicKeysDecodeErrorZ.mjs';
import { Result_HTLCOutputInCommitmentDecodeErrorZ } from '../structs/Result_HTLCOutputInCommitmentDecodeErrorZ.mjs';
import { CounterpartyChannelTransactionParameters } from '../structs/CounterpartyChannelTransactionParameters.mjs';
import { Result_CounterpartyChannelTransactionParametersDecodeErrorZ } from '../structs/Result_CounterpartyChannelTransactionParametersDecodeErrorZ.mjs';
import { Result_ChannelTransactionParametersDecodeErrorZ } from '../structs/Result_ChannelTransactionParametersDecodeErrorZ.mjs';
import { Result_HolderCommitmentTransactionDecodeErrorZ } from '../structs/Result_HolderCommitmentTransactionDecodeErrorZ.mjs';
import { BuiltCommitmentTransaction } from '../structs/BuiltCommitmentTransaction.mjs';
import { Result_BuiltCommitmentTransactionDecodeErrorZ } from '../structs/Result_BuiltCommitmentTransactionDecodeErrorZ.mjs';
import { TrustedClosingTransaction } from '../structs/TrustedClosingTransaction.mjs';
import { Result_TrustedClosingTransactionNoneZ } from '../structs/Result_TrustedClosingTransactionNoneZ.mjs';
import { Result_CommitmentTransactionDecodeErrorZ } from '../structs/Result_CommitmentTransactionDecodeErrorZ.mjs';
import { TrustedCommitmentTransaction } from '../structs/TrustedCommitmentTransaction.mjs';
import { Result_TrustedCommitmentTransactionNoneZ } from '../structs/Result_TrustedCommitmentTransactionNoneZ.mjs';
import { Result_CVec_ECDSASignatureZNoneZ } from '../structs/Result_CVec_ECDSASignatureZNoneZ.mjs';
import { Option_usizeZ } from '../structs/Option_usizeZ.mjs';
import { Result_ShutdownScriptDecodeErrorZ } from '../structs/Result_ShutdownScriptDecodeErrorZ.mjs';
import { InvalidShutdownScript } from '../structs/InvalidShutdownScript.mjs';
import { Result_ShutdownScriptInvalidShutdownScriptZ } from '../structs/Result_ShutdownScriptInvalidShutdownScriptZ.mjs';
import { FundingInfo } from '../structs/FundingInfo.mjs';
import { Result_FundingInfoDecodeErrorZ } from '../structs/Result_FundingInfoDecodeErrorZ.mjs';
import { PaymentPurpose } from '../structs/PaymentPurpose.mjs';
import { Result_PaymentPurposeDecodeErrorZ } from '../structs/Result_PaymentPurposeDecodeErrorZ.mjs';
import { ClaimedHTLC } from '../structs/ClaimedHTLC.mjs';
import { Result_ClaimedHTLCDecodeErrorZ } from '../structs/Result_ClaimedHTLCDecodeErrorZ.mjs';
import { PathFailure } from '../structs/PathFailure.mjs';
import { Option_PathFailureZ } from '../structs/Option_PathFailureZ.mjs';
import { Result_COption_PathFailureZDecodeErrorZ } from '../structs/Result_COption_PathFailureZDecodeErrorZ.mjs';
import { Option_ClosureReasonZ } from '../structs/Option_ClosureReasonZ.mjs';
import { Result_COption_ClosureReasonZDecodeErrorZ } from '../structs/Result_COption_ClosureReasonZDecodeErrorZ.mjs';
import { HTLCDestination } from '../structs/HTLCDestination.mjs';
import { Option_HTLCDestinationZ } from '../structs/Option_HTLCDestinationZ.mjs';
import { Result_COption_HTLCDestinationZDecodeErrorZ } from '../structs/Result_COption_HTLCDestinationZDecodeErrorZ.mjs';
import { Option_PaymentFailureReasonZ } from '../structs/Option_PaymentFailureReasonZ.mjs';
import { Result_COption_PaymentFailureReasonZDecodeErrorZ } from '../structs/Result_COption_PaymentFailureReasonZDecodeErrorZ.mjs';
import { Option_U128Z } from '../structs/Option_U128Z.mjs';
import { Responder } from '../structs/Responder.mjs';
import { ChannelParameters } from '../structs/ChannelParameters.mjs';
import { AnchorDescriptor } from '../structs/AnchorDescriptor.mjs';
import { BumpTransactionEvent } from '../structs/BumpTransactionEvent.mjs';
import { Event } from '../structs/Event.mjs';
import { Option_EventZ } from '../structs/Option_EventZ.mjs';
import { Result_COption_EventZDecodeErrorZ } from '../structs/Result_COption_EventZDecodeErrorZ.mjs';
import { Result_NonceDecodeErrorZ } from '../structs/Result_NonceDecodeErrorZ.mjs';
import { Bolt11ParseError } from '../structs/Bolt11ParseError.mjs';
import { Result_SiPrefixBolt11ParseErrorZ } from '../structs/Result_SiPrefixBolt11ParseErrorZ.mjs';
import { Bolt11Invoice } from '../structs/Bolt11Invoice.mjs';
import { ParseOrSemanticError } from '../structs/ParseOrSemanticError.mjs';
import { Result_Bolt11InvoiceParseOrSemanticErrorZ } from '../structs/Result_Bolt11InvoiceParseOrSemanticErrorZ.mjs';
import { SignedRawBolt11Invoice } from '../structs/SignedRawBolt11Invoice.mjs';
import { Result_SignedRawBolt11InvoiceBolt11ParseErrorZ } from '../structs/Result_SignedRawBolt11InvoiceBolt11ParseErrorZ.mjs';
import { Bolt11InvoiceSignature } from '../structs/Bolt11InvoiceSignature.mjs';
import { ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ } from '../structs/ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ.mjs';
import { PayeePubKey } from '../structs/PayeePubKey.mjs';
import { Result_PayeePubKeySecp256k1ErrorZ } from '../structs/Result_PayeePubKeySecp256k1ErrorZ.mjs';
import { PrivateRoute } from '../structs/PrivateRoute.mjs';
import { PositiveTimestamp } from '../structs/PositiveTimestamp.mjs';
import { Result_PositiveTimestampCreationErrorZ } from '../structs/Result_PositiveTimestampCreationErrorZ.mjs';
import { Result_NoneBolt11SemanticErrorZ } from '../structs/Result_NoneBolt11SemanticErrorZ.mjs';
import { Result_Bolt11InvoiceBolt11SemanticErrorZ } from '../structs/Result_Bolt11InvoiceBolt11SemanticErrorZ.mjs';
import { Description } from '../structs/Description.mjs';
import { Result_DescriptionCreationErrorZ } from '../structs/Result_DescriptionCreationErrorZ.mjs';
import { Result_PrivateRouteCreationErrorZ } from '../structs/Result_PrivateRouteCreationErrorZ.mjs';
import { Result_OutPointDecodeErrorZ } from '../structs/Result_OutPointDecodeErrorZ.mjs';
import { BigSize } from '../structs/BigSize.mjs';
import { Result_BigSizeDecodeErrorZ } from '../structs/Result_BigSizeDecodeErrorZ.mjs';
import { Result_UntrustedStringDecodeErrorZ } from '../structs/Result_UntrustedStringDecodeErrorZ.mjs';
import { Result_HostnameDecodeErrorZ } from '../structs/Result_HostnameDecodeErrorZ.mjs';
import { TransactionU16LenLimited } from '../structs/TransactionU16LenLimited.mjs';
import { Result_TransactionU16LenLimitedNoneZ } from '../structs/Result_TransactionU16LenLimitedNoneZ.mjs';
import { Result_TransactionU16LenLimitedDecodeErrorZ } from '../structs/Result_TransactionU16LenLimitedDecodeErrorZ.mjs';
import { Result_ChannelIdDecodeErrorZ } from '../structs/Result_ChannelIdDecodeErrorZ.mjs';
import { TwoTuple__u832u16Z } from '../structs/TwoTuple__u832u16Z.mjs';
import { BlindedPayInfo } from '../structs/BlindedPayInfo.mjs';
import { Result_BlindedPayInfoDecodeErrorZ } from '../structs/Result_BlindedPayInfoDecodeErrorZ.mjs';
import { Result_BlindedPaymentPathNoneZ } from '../structs/Result_BlindedPaymentPathNoneZ.mjs';
import { PaymentForwardNode } from '../structs/PaymentForwardNode.mjs';
import { PaymentRelay } from '../structs/PaymentRelay.mjs';
import { Result_PaymentRelayDecodeErrorZ } from '../structs/Result_PaymentRelayDecodeErrorZ.mjs';
import { PaymentConstraints } from '../structs/PaymentConstraints.mjs';
import { Result_PaymentConstraintsDecodeErrorZ } from '../structs/Result_PaymentConstraintsDecodeErrorZ.mjs';
import { Result_PaymentContextDecodeErrorZ } from '../structs/Result_PaymentContextDecodeErrorZ.mjs';
import { Result_UnknownPaymentContextDecodeErrorZ } from '../structs/Result_UnknownPaymentContextDecodeErrorZ.mjs';
import { Result_Bolt12OfferContextDecodeErrorZ } from '../structs/Result_Bolt12OfferContextDecodeErrorZ.mjs';
import { Result_Bolt12RefundContextDecodeErrorZ } from '../structs/Result_Bolt12RefundContextDecodeErrorZ.mjs';
import { Result_ResponderDecodeErrorZ } from '../structs/Result_ResponderDecodeErrorZ.mjs';
import { Option_MessageContextZ } from '../structs/Option_MessageContextZ.mjs';
import { ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ } from '../structs/ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ.mjs';
import { SendError } from '../structs/SendError.mjs';
import { Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ } from '../structs/Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ.mjs';
import { NextMessageHop } from '../structs/NextMessageHop.mjs';
import { ParsedOnionMessageContents } from '../structs/ParsedOnionMessageContents.mjs';
import { PeeledOnion } from '../structs/PeeledOnion.mjs';
import { Result_PeeledOnionNoneZ } from '../structs/Result_PeeledOnionNoneZ.mjs';
import { SendSuccess } from '../structs/SendSuccess.mjs';
import { Result_SendSuccessSendErrorZ } from '../structs/Result_SendSuccessSendErrorZ.mjs';
import { Result_NoneSendErrorZ } from '../structs/Result_NoneSendErrorZ.mjs';
import { Result_BlindedHopDecodeErrorZ } from '../structs/Result_BlindedHopDecodeErrorZ.mjs';
import { SignOrCreationError } from '../structs/SignOrCreationError.mjs';
import { Result_Bolt11InvoiceSignOrCreationErrorZ } from '../structs/Result_Bolt11InvoiceSignOrCreationErrorZ.mjs';
import { Result_InvoiceErrorDecodeErrorZ } from '../structs/Result_InvoiceErrorDecodeErrorZ.mjs';
import { TrackedSpendableOutput } from '../structs/TrackedSpendableOutput.mjs';
import { Result_TrackedSpendableOutputDecodeErrorZ } from '../structs/Result_TrackedSpendableOutputDecodeErrorZ.mjs';
import { OutputSpendStatus } from '../structs/OutputSpendStatus.mjs';
import { Result_OutputSpendStatusDecodeErrorZ } from '../structs/Result_OutputSpendStatusDecodeErrorZ.mjs';
import { WatchedOutput } from '../structs/WatchedOutput.mjs';
import { Filter, FilterInterface } from '../structs/Filter.mjs';
import { Option_FilterZ } from '../structs/Option_FilterZ.mjs';
import { ChangeDestinationSource, ChangeDestinationSourceInterface } from '../structs/ChangeDestinationSource.mjs';
import { KVStore, KVStoreInterface } from '../structs/KVStore.mjs';
import { OutputSpender, OutputSpenderInterface } from '../structs/OutputSpender.mjs';
import { OutputSweeper } from '../structs/OutputSweeper.mjs';
import { Result_OutputSweeperDecodeErrorZ } from '../structs/Result_OutputSweeperDecodeErrorZ.mjs';
import { TwoTuple_BestBlockOutputSweeperZ } from '../structs/TwoTuple_BestBlockOutputSweeperZ.mjs';
import { Result_C2Tuple_BestBlockOutputSweeperZDecodeErrorZ } from '../structs/Result_C2Tuple_BestBlockOutputSweeperZDecodeErrorZ.mjs';
import { DelayedPaymentBasepoint } from '../structs/DelayedPaymentBasepoint.mjs';
import { Result_DelayedPaymentBasepointDecodeErrorZ } from '../structs/Result_DelayedPaymentBasepointDecodeErrorZ.mjs';
import { DelayedPaymentKey } from '../structs/DelayedPaymentKey.mjs';
import { Result_DelayedPaymentKeyDecodeErrorZ } from '../structs/Result_DelayedPaymentKeyDecodeErrorZ.mjs';
import { HtlcBasepoint } from '../structs/HtlcBasepoint.mjs';
import { Result_HtlcBasepointDecodeErrorZ } from '../structs/Result_HtlcBasepointDecodeErrorZ.mjs';
import { HtlcKey } from '../structs/HtlcKey.mjs';
import { Result_HtlcKeyDecodeErrorZ } from '../structs/Result_HtlcKeyDecodeErrorZ.mjs';
import { RevocationBasepoint } from '../structs/RevocationBasepoint.mjs';
import { Result_RevocationBasepointDecodeErrorZ } from '../structs/Result_RevocationBasepointDecodeErrorZ.mjs';
import { RevocationKey } from '../structs/RevocationKey.mjs';
import { Result_RevocationKeyDecodeErrorZ } from '../structs/Result_RevocationKeyDecodeErrorZ.mjs';
import { LockedChannelMonitor } from '../structs/LockedChannelMonitor.mjs';
import { Result_LockedChannelMonitorNoneZ } from '../structs/Result_LockedChannelMonitorNoneZ.mjs';
import { TwoTuple_OutPointChannelIdZ } from '../structs/TwoTuple_OutPointChannelIdZ.mjs';
import { TwoTuple_OutPointCVec_u64ZZ } from '../structs/TwoTuple_OutPointCVec_u64ZZ.mjs';
import { Result_BlindedMessagePathDecodeErrorZ } from '../structs/Result_BlindedMessagePathDecodeErrorZ.mjs';
import { Result_BlindedMessagePathNoneZ } from '../structs/Result_BlindedMessagePathNoneZ.mjs';
import { Result_MessageContextDecodeErrorZ } from '../structs/Result_MessageContextDecodeErrorZ.mjs';
import { Result_OffersContextDecodeErrorZ } from '../structs/Result_OffersContextDecodeErrorZ.mjs';
import { FirstHopCandidate } from '../structs/FirstHopCandidate.mjs';
import { PublicHopCandidate } from '../structs/PublicHopCandidate.mjs';
import { PrivateHopCandidate } from '../structs/PrivateHopCandidate.mjs';
import { BlindedPathCandidate } from '../structs/BlindedPathCandidate.mjs';
import { OneHopBlindedPathCandidate } from '../structs/OneHopBlindedPathCandidate.mjs';
import { CandidateRouteHop } from '../structs/CandidateRouteHop.mjs';
import { ChannelUsage } from '../structs/ChannelUsage.mjs';
import { ProbabilisticScoringFeeParameters } from '../structs/ProbabilisticScoringFeeParameters.mjs';
import { ScoreLookUp, ScoreLookUpInterface } from '../structs/ScoreLookUp.mjs';
import { ScoreUpdate, ScoreUpdateInterface } from '../structs/ScoreUpdate.mjs';
import { LockableScore, LockableScoreInterface } from '../structs/LockableScore.mjs';
import { WriteableScore, WriteableScoreInterface } from '../structs/WriteableScore.mjs';
import { Persister, PersisterInterface } from '../structs/Persister.mjs';
import { MonitorUpdatingPersister } from '../structs/MonitorUpdatingPersister.mjs';
import { Persist, PersistInterface } from '../structs/Persist.mjs';
import { Listen, ListenInterface } from '../structs/Listen.mjs';
import { Confirm, ConfirmInterface } from '../structs/Confirm.mjs';
import { SpendingDelay } from '../structs/SpendingDelay.mjs';
import { FutureCallback, FutureCallbackInterface } from '../structs/FutureCallback.mjs';
import { Future } from '../structs/Future.mjs';
import { ChannelHandshakeConfig } from '../structs/ChannelHandshakeConfig.mjs';
import { ChannelHandshakeLimits } from '../structs/ChannelHandshakeLimits.mjs';
import { ChannelConfigUpdate } from '../structs/ChannelConfigUpdate.mjs';
import { UserConfig } from '../structs/UserConfig.mjs';
import { ChainMonitor } from '../structs/ChainMonitor.mjs';
import { EventHandler, EventHandlerInterface } from '../structs/EventHandler.mjs';
import { EventsProvider, EventsProviderInterface } from '../structs/EventsProvider.mjs';
import { FailureCode } from '../structs/FailureCode.mjs';
import { ChainParameters } from '../structs/ChainParameters.mjs';
import { MessageSendEventsProvider, MessageSendEventsProviderInterface } from '../structs/MessageSendEventsProvider.mjs';
import { ChannelMessageHandler, ChannelMessageHandlerInterface } from '../structs/ChannelMessageHandler.mjs';
import { OffersMessageHandler, OffersMessageHandlerInterface } from '../structs/OffersMessageHandler.mjs';
import { AsyncPaymentsMessageHandler, AsyncPaymentsMessageHandlerInterface } from '../structs/AsyncPaymentsMessageHandler.mjs';
import { NodeIdLookUp, NodeIdLookUpInterface } from '../structs/NodeIdLookUp.mjs';
import { ChannelManagerReadArgs } from '../structs/ChannelManagerReadArgs.mjs';
import { ExpandedKey } from '../structs/ExpandedKey.mjs';
import { CommonOpenChannelFields } from '../structs/CommonOpenChannelFields.mjs';
import { CommonAcceptChannelFields } from '../structs/CommonAcceptChannelFields.mjs';
import { Packet } from '../structs/Packet.mjs';
import { RoutingMessageHandler, RoutingMessageHandlerInterface } from '../structs/RoutingMessageHandler.mjs';
import { OnionMessageHandler, OnionMessageHandlerInterface } from '../structs/OnionMessageHandler.mjs';
import { TrampolineOnionPacket } from '../structs/TrampolineOnionPacket.mjs';
import { CustomMessageReader, CustomMessageReaderInterface } from '../structs/CustomMessageReader.mjs';
import { CustomMessageHandler, CustomMessageHandlerInterface } from '../structs/CustomMessageHandler.mjs';
import { IgnoringMessageHandler } from '../structs/IgnoringMessageHandler.mjs';
import { CustomOnionMessageHandler, CustomOnionMessageHandlerInterface } from '../structs/CustomOnionMessageHandler.mjs';
import { ErroringMessageHandler } from '../structs/ErroringMessageHandler.mjs';
import { MessageHandler } from '../structs/MessageHandler.mjs';
import { SocketDescriptor, SocketDescriptorInterface } from '../structs/SocketDescriptor.mjs';
import { PeerManager } from '../structs/PeerManager.mjs';
import { DirectedChannelTransactionParameters } from '../structs/DirectedChannelTransactionParameters.mjs';
import { Sha256 } from '../structs/Sha256.mjs';
import { Bolt12PaymentError } from '../structs/Bolt12PaymentError.mjs';
import { OfferWithExplicitMetadataBuilder } from '../structs/OfferWithExplicitMetadataBuilder.mjs';
import { PrintableString } from '../structs/PrintableString.mjs';
import { OfferFeatures } from '../structs/OfferFeatures.mjs';
import { SignBolt12InvoiceFn, SignBolt12InvoiceFnInterface } from '../structs/SignBolt12InvoiceFn.mjs';
import { TaggedHash } from '../structs/TaggedHash.mjs';
import { InvoiceRequestFeatures } from '../structs/InvoiceRequestFeatures.mjs';
import { ErroneousField } from '../structs/ErroneousField.mjs';
import { SignInvoiceRequestFn, SignInvoiceRequestFnInterface } from '../structs/SignInvoiceRequestFn.mjs';
import { SignError } from '../structs/SignError.mjs';
import { P2PGossipSync } from '../structs/P2PGossipSync.mjs';
import { ReadOnlyNetworkGraph } from '../structs/ReadOnlyNetworkGraph.mjs';
import { DirectedChannelInfo } from '../structs/DirectedChannelInfo.mjs';
import { EffectiveCapacity } from '../structs/EffectiveCapacity.mjs';
import { DefaultRouter } from '../structs/DefaultRouter.mjs';
import { ScorerAccountingForInFlightHtlcs } from '../structs/ScorerAccountingForInFlightHtlcs.mjs';
import { Payee } from '../structs/Payee.mjs';
import { Score, ScoreInterface } from '../structs/Score.mjs';
import { MultiThreadedLockableScore } from '../structs/MultiThreadedLockableScore.mjs';
import { MultiThreadedScoreLockRead } from '../structs/MultiThreadedScoreLockRead.mjs';
import { MultiThreadedScoreLockWrite } from '../structs/MultiThreadedScoreLockWrite.mjs';
import { ProbabilisticScoringDecayParameters } from '../structs/ProbabilisticScoringDecayParameters.mjs';
import { KeysManager } from '../structs/KeysManager.mjs';
import { PhantomKeysManager } from '../structs/PhantomKeysManager.mjs';
import { RandomBytes } from '../structs/RandomBytes.mjs';
import { OnionMessenger } from '../structs/OnionMessenger.mjs';
import { DefaultMessageRouter } from '../structs/DefaultMessageRouter.mjs';
import { IntroductionNode } from '../structs/IntroductionNode.mjs';
import { EmptyNodeIdLookUp } from '../structs/EmptyNodeIdLookUp.mjs';
import { ForwardTlvs } from '../structs/ForwardTlvs.mjs';
import { CoinSelectionSource, CoinSelectionSourceInterface } from '../structs/CoinSelectionSource.mjs';
import { WalletSource, WalletSourceInterface } from '../structs/WalletSource.mjs';
import { Wallet } from '../structs/Wallet.mjs';
import { BumpTransactionEventHandler } from '../structs/BumpTransactionEventHandler.mjs';
import { RapidGossipSync } from '../structs/RapidGossipSync.mjs';
import { GossipSync } from '../structs/GossipSync.mjs';
import { RawDataPart } from '../structs/RawDataPart.mjs';
import { ExpiryTime } from '../structs/ExpiryTime.mjs';
import { MinFinalCltvExpiryDelta } from '../structs/MinFinalCltvExpiryDelta.mjs';
import { Fallback } from '../structs/Fallback.mjs';

import { CommonBase, UInt5, WitnessVersion, UnqualifiedError } from './CommonBase.mjs';
import * as bindings from '../bindings.mjs'


/**
 * A lightning node's channel state machine and payment management logic, which facilitates
 * sending, forwarding, and receiving payments through lightning channels.
 * 
 * [`ChannelManager`] is parameterized by a number of components to achieve this.
 * - [`chain::Watch`] (typically [`ChainMonitor`]) for on-chain monitoring and enforcement of each
 * channel
 * - [`BroadcasterInterface`] for broadcasting transactions related to opening, funding, and
 * closing channels
 * - [`EntropySource`] for providing random data needed for cryptographic operations
 * - [`NodeSigner`] for cryptographic operations scoped to the node
 * - [`SignerProvider`] for providing signers whose operations are scoped to individual channels
 * - [`FeeEstimator`] to determine transaction fee rates needed to have a transaction mined in a
 * timely manner
 * - [`Router`] for finding payment paths when initiating and retrying payments
 * - [`Logger`] for logging operational information of varying degrees
 * 
 * Additionally, it implements the following traits:
 * - [`ChannelMessageHandler`] to handle off-chain channel activity from peers
 * - [`MessageSendEventsProvider`] to similarly send such messages to peers
 * - [`OffersMessageHandler`] for BOLT 12 message handling and sending
 * - [`EventsProvider`] to generate user-actionable [`Event`]s
 * - [`chain::Listen`] and [`chain::Confirm`] for notification of on-chain activity
 * 
 * Thus, [`ChannelManager`] is typically used to parameterize a [`MessageHandler`] and an
 * [`OnionMessenger`]. The latter is required to support BOLT 12 functionality.
 * 
 * # `ChannelManager` vs `ChannelMonitor`
 * 
 * It's important to distinguish between the *off-chain* management and *on-chain* enforcement of
 * lightning channels. [`ChannelManager`] exchanges messages with peers to manage the off-chain
 * state of each channel. During this process, it generates a [`ChannelMonitor`] for each channel
 * and a [`ChannelMonitorUpdate`] for each relevant change, notifying its parameterized
 * [`chain::Watch`] of them.
 * 
 * An implementation of [`chain::Watch`], such as [`ChainMonitor`], is responsible for aggregating
 * these [`ChannelMonitor`]s and applying any [`ChannelMonitorUpdate`]s to them. It then monitors
 * for any pertinent on-chain activity, enforcing claims as needed.
 * 
 * This division of off-chain management and on-chain enforcement allows for interesting node
 * setups. For instance, on-chain enforcement could be moved to a separate host or have added
 * redundancy, possibly as a watchtower. See [`chain::Watch`] for the relevant interface.
 * 
 * # Initialization
 * 
 * Use [`ChannelManager::new`] with the most recent [`BlockHash`] when creating a fresh instance.
 * Otherwise, if restarting, construct [`ChannelManagerReadArgs`] with the necessary parameters and
 * references to any deserialized [`ChannelMonitor`]s that were previously persisted. Use this to
 * deserialize the [`ChannelManager`] and feed it any new chain data since it was last online, as
 * detailed in the [`ChannelManagerReadArgs`] documentation.
 * 
 * ```
 * use bitcoin::BlockHash;
 * use bitcoin::network::Network;
 * use lightning::chain::BestBlock;
 * # use lightning::chain::channelmonitor::ChannelMonitor;
 * use lightning::ln::channelmanager::{ChainParameters, ChannelManager, ChannelManagerReadArgs};
 * # use lightning::routing::gossip::NetworkGraph;
 * use lightning::util::config::UserConfig;
 * use lightning::util::ser::ReadableArgs;
 * 
 * # fn read_channel_monitors() -> Vec<ChannelMonitor<lightning::sign::InMemorySigner>> { vec![] }
 * # fn example<
 * #     'a,
 * #     L: lightning::util::logger::Logger,
 * #     ES: lightning::sign::EntropySource,
 * #     S: for <'b> lightning::routing::scoring::LockableScore<'b, ScoreLookUp = SL>,
 * #     SL: lightning::routing::scoring::ScoreLookUp<ScoreParams = SP>,
 * #     SP: Sized,
 * #     R: lightning::io::Read,
 * # >(
 * #     fee_estimator: &dyn lightning::chain::chaininterface::FeeEstimator,
 * #     chain_monitor: &dyn lightning::chain::Watch<lightning::sign::InMemorySigner>,
 * #     tx_broadcaster: &dyn lightning::chain::chaininterface::BroadcasterInterface,
 * #     router: &lightning::routing::router::DefaultRouter<&NetworkGraph<&'a L>, &'a L, &ES, &S, SP, SL>,
 * #     logger: &L,
 * #     entropy_source: &ES,
 * #     node_signer: &dyn lightning::sign::NodeSigner,
 * #     signer_provider: &lightning::sign::DynSignerProvider,
 * #     best_block: lightning::chain::BestBlock,
 * #     current_timestamp: u32,
 * #     mut reader: R,
 * # ) -> Result<(), lightning::ln::msgs::DecodeError> {
 * Fresh start with no channels
 * let params = ChainParameters {
 * network: Network::Bitcoin,
 * best_block,
 * };
 * let default_config = UserConfig::default();
 * let channel_manager = ChannelManager::new(
 * fee_estimator, chain_monitor, tx_broadcaster, router, logger, entropy_source, node_signer,
 * signer_provider, default_config, params, current_timestamp
 * );
 * 
 * Restart from deserialized data
 * let mut channel_monitors = read_channel_monitors();
 * let args = ChannelManagerReadArgs::new(
 * entropy_source, node_signer, signer_provider, fee_estimator, chain_monitor, tx_broadcaster,
 * router, logger, default_config, channel_monitors.iter_mut().collect()
 * );
 * let (block_hash, channel_manager) =
 * <(BlockHash, ChannelManager<_, _, _, _, _, _, _, _>)>::read(&mut reader, args)?;
 * 
 * Update the ChannelManager and ChannelMonitors with the latest chain data
 * ...
 * 
 * Move the monitors to the ChannelManager's chain::Watch parameter
 * for monitor in channel_monitors {
 * chain_monitor.watch_channel(monitor.get_funding_txo().0, monitor);
 * }
 * # Ok(())
 * # }
 * ```
 * 
 * # Operation
 * 
 * The following is required for [`ChannelManager`] to function properly:
 * - Handle messages from peers using its [`ChannelMessageHandler`] implementation (typically
 * called by [`PeerManager::read_event`] when processing network I/O)
 * - Send messages to peers obtained via its [`MessageSendEventsProvider`] implementation
 * (typically initiated when [`PeerManager::process_events`] is called)
 * - Feed on-chain activity using either its [`chain::Listen`] or [`chain::Confirm`] implementation
 * as documented by those traits
 * - Perform any periodic channel and payment checks by calling [`timer_tick_occurred`] roughly
 * every minute
 * - Persist to disk whenever [`get_and_clear_needs_persistence`] returns `true` using a
 * [`Persister`] such as a [`KVStore`] implementation
 * - Handle [`Event`]s obtained via its [`EventsProvider`] implementation
 * 
 * The [`Future`] returned by [`get_event_or_persistence_needed_future`] is useful in determining
 * when the last two requirements need to be checked.
 * 
 * The [`lightning-block-sync`] and [`lightning-transaction-sync`] crates provide utilities that
 * simplify feeding in on-chain activity using the [`chain::Listen`] and [`chain::Confirm`] traits,
 * respectively. The remaining requirements can be met using the [`lightning-background-processor`]
 * crate. For languages other than Rust, the availability of similar utilities may vary.
 * 
 * # Channels
 * 
 * [`ChannelManager`]'s primary function involves managing a channel state. Without channels,
 * payments can't be sent. Use [`list_channels`] or [`list_usable_channels`] for a snapshot of the
 * currently open channels.
 * 
 * ```
 * # use lightning::ln::channelmanager::AChannelManager;
 * #
 * # fn example<T: AChannelManager>(channel_manager: T) {
 * # let channel_manager = channel_manager.get_cm();
 * let channels = channel_manager.list_usable_channels();
 * for details in channels {
 * println!(\"{:?}\", details);
 * }
 * # }
 * ```
 * 
 * Each channel is identified using a [`ChannelId`], which will change throughout the channel's
 * life cycle. Additionally, channels are assigned a `user_channel_id`, which is given in
 * [`Event`]s associated with the channel and serves as a fixed identifier but is otherwise unused
 * by [`ChannelManager`].
 * 
 * ## Opening Channels
 * 
 * To an open a channel with a peer, call [`create_channel`]. This will initiate the process of
 * opening an outbound channel, which requires self-funding when handling
 * [`Event::FundingGenerationReady`].
 * 
 * ```
 * # use bitcoin::{ScriptBuf, Transaction};
 * # use bitcoin::secp256k1::PublicKey;
 * # use lightning::ln::channelmanager::AChannelManager;
 * # use lightning::events::{Event, EventsProvider};
 * #
 * # trait Wallet {
 * #     fn create_funding_transaction(
 * #         &self, _amount_sats: u64, _output_script: ScriptBuf
 * #     ) -> Transaction;
 * # }
 * #
 * # fn example<T: AChannelManager, W: Wallet>(channel_manager: T, wallet: W, peer_id: PublicKey) {
 * # let channel_manager = channel_manager.get_cm();
 * let value_sats = 1_000_000;
 * let push_msats = 10_000_000;
 * match channel_manager.create_channel(peer_id, value_sats, push_msats, 42, None, None) {
 * Ok(channel_id) => println!(\"Opening channel {}\", channel_id),
 * Err(e) => println!(\"Error opening channel: {:?}\", e),
 * }
 * 
 * On the event processing thread once the peer has responded
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::FundingGenerationReady {
 * temporary_channel_id, counterparty_node_id, channel_value_satoshis, output_script,
 * user_channel_id, ..
 * } => {
 * assert_eq!(user_channel_id, 42);
 * let funding_transaction = wallet.create_funding_transaction(
 * channel_value_satoshis, output_script
 * );
 * match channel_manager.funding_transaction_generated(
 * temporary_channel_id, counterparty_node_id, funding_transaction
 * ) {
 * Ok(()) => println!(\"Funding channel {}\", temporary_channel_id),
 * Err(e) => println!(\"Error funding channel {}: {:?}\", temporary_channel_id, e),
 * }
 * },
 * Event::ChannelPending { channel_id, user_channel_id, former_temporary_channel_id, .. } => {
 * assert_eq!(user_channel_id, 42);
 * println!(
 * \"Channel {} now {} pending (funding transaction has been broadcasted)\", channel_id,
 * former_temporary_channel_id.unwrap()
 * );
 * },
 * Event::ChannelReady { channel_id, user_channel_id, .. } => {
 * assert_eq!(user_channel_id, 42);
 * println!(\"Channel {} ready\", channel_id);
 * },
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # }
 * ```
 * 
 * ## Accepting Channels
 * 
 * Inbound channels are initiated by peers and are automatically accepted unless [`ChannelManager`]
 * has [`UserConfig::manually_accept_inbound_channels`] set. In that case, the channel may be
 * either accepted or rejected when handling [`Event::OpenChannelRequest`].
 * 
 * ```
 * # use bitcoin::secp256k1::PublicKey;
 * # use lightning::ln::channelmanager::AChannelManager;
 * # use lightning::events::{Event, EventsProvider};
 * #
 * # fn is_trusted(counterparty_node_id: PublicKey) -> bool {
 * #     // ...
 * #     unimplemented!()
 * # }
 * #
 * # fn example<T: AChannelManager>(channel_manager: T) {
 * # let channel_manager = channel_manager.get_cm();
 * # let error_message = \"Channel force-closed\";
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::OpenChannelRequest { temporary_channel_id, counterparty_node_id, ..  } => {
 * if !is_trusted(counterparty_node_id) {
 * match channel_manager.force_close_without_broadcasting_txn(
 * &temporary_channel_id, &counterparty_node_id, error_message.to_string()
 * ) {
 * Ok(()) => println!(\"Rejecting channel {}\", temporary_channel_id),
 * Err(e) => println!(\"Error rejecting channel {}: {:?}\", temporary_channel_id, e),
 * }
 * return Ok(());
 * }
 * 
 * let user_channel_id = 43;
 * match channel_manager.accept_inbound_channel(
 * &temporary_channel_id, &counterparty_node_id, user_channel_id
 * ) {
 * Ok(()) => println!(\"Accepting channel {}\", temporary_channel_id),
 * Err(e) => println!(\"Error accepting channel {}: {:?}\", temporary_channel_id, e),
 * }
 * },
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # }
 * ```
 * 
 * ## Closing Channels
 * 
 * There are two ways to close a channel: either cooperatively using [`close_channel`] or
 * unilaterally using [`force_close_broadcasting_latest_txn`]. The former is ideal as it makes for
 * lower fees and immediate access to funds. However, the latter may be necessary if the
 * counterparty isn't behaving properly or has gone offline. [`Event::ChannelClosed`] is generated
 * once the channel has been closed successfully.
 * 
 * ```
 * # use bitcoin::secp256k1::PublicKey;
 * # use lightning::ln::types::ChannelId;
 * # use lightning::ln::channelmanager::AChannelManager;
 * # use lightning::events::{Event, EventsProvider};
 * #
 * # fn example<T: AChannelManager>(
 * #     channel_manager: T, channel_id: ChannelId, counterparty_node_id: PublicKey
 * # ) {
 * # let channel_manager = channel_manager.get_cm();
 * match channel_manager.close_channel(&channel_id, &counterparty_node_id) {
 * Ok(()) => println!(\"Closing channel {}\", channel_id),
 * Err(e) => println!(\"Error closing channel {}: {:?}\", channel_id, e),
 * }
 * 
 * On the event processing thread
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::ChannelClosed { channel_id, user_channel_id, ..  } => {
 * assert_eq!(user_channel_id, 42);
 * println!(\"Channel {} closed\", channel_id);
 * },
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # }
 * ```
 * 
 * # Payments
 * 
 * [`ChannelManager`] is responsible for sending, forwarding, and receiving payments through its
 * channels. A payment is typically initiated from a [BOLT 11] invoice or a [BOLT 12] offer, though
 * spontaneous (i.e., keysend) payments are also possible. Incoming payments don't require
 * maintaining any additional state as [`ChannelManager`] can reconstruct the [`PaymentPreimage`]
 * from the [`PaymentSecret`]. Sending payments, however, require tracking in order to retry failed
 * HTLCs.
 * 
 * After a payment is initiated, it will appear in [`list_recent_payments`] until a short time
 * after either an [`Event::PaymentSent`] or [`Event::PaymentFailed`] is handled. Failed HTLCs
 * for a payment will be retried according to the payment's [`Retry`] strategy or until
 * [`abandon_payment`] is called.
 * 
 * ## BOLT 11 Invoices
 * 
 * The [`lightning-invoice`] crate is useful for creating BOLT 11 invoices. Specifically, use the
 * functions in its `utils` module for constructing invoices that are compatible with
 * [`ChannelManager`]. These functions serve as a convenience for building invoices with the
 * [`PaymentHash`] and [`PaymentSecret`] returned from [`create_inbound_payment`]. To provide your
 * own [`PaymentHash`], use [`create_inbound_payment_for_hash`] or the corresponding functions in
 * the [`lightning-invoice`] `utils` module.
 * 
 * [`ChannelManager`] generates an [`Event::PaymentClaimable`] once the full payment has been
 * received. Call [`claim_funds`] to release the [`PaymentPreimage`], which in turn will result in
 * an [`Event::PaymentClaimed`].
 * 
 * ```
 * # use lightning::events::{Event, EventsProvider, PaymentPurpose};
 * # use lightning::ln::channelmanager::AChannelManager;
 * #
 * # fn example<T: AChannelManager>(channel_manager: T) {
 * # let channel_manager = channel_manager.get_cm();
 * Or use utils::create_invoice_from_channelmanager
 * let known_payment_hash = match channel_manager.create_inbound_payment(
 * Some(10_000_000), 3600, None
 * ) {
 * Ok((payment_hash, _payment_secret)) => {
 * println!(\"Creating inbound payment {}\", payment_hash);
 * payment_hash
 * },
 * Err(()) => panic!(\"Error creating inbound payment\"),
 * };
 * 
 * On the event processing thread
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::PaymentClaimable { payment_hash, purpose, .. } => match purpose {
 * PaymentPurpose::Bolt11InvoicePayment { payment_preimage: Some(payment_preimage), .. } => {
 * assert_eq!(payment_hash, known_payment_hash);
 * println!(\"Claiming payment {}\", payment_hash);
 * channel_manager.claim_funds(payment_preimage);
 * },
 * PaymentPurpose::Bolt11InvoicePayment { payment_preimage: None, .. } => {
 * println!(\"Unknown payment hash: {}\", payment_hash);
 * },
 * PaymentPurpose::SpontaneousPayment(payment_preimage) => {
 * assert_ne!(payment_hash, known_payment_hash);
 * println!(\"Claiming spontaneous payment {}\", payment_hash);
 * channel_manager.claim_funds(payment_preimage);
 * },
 * ...
 * #           _ => {},
 * },
 * Event::PaymentClaimed { payment_hash, amount_msat, .. } => {
 * assert_eq!(payment_hash, known_payment_hash);
 * println!(\"Claimed {} msats\", amount_msat);
 * },
 * ...
 * #       _ => {},
 * }
 * Ok(())
 * });
 * # }
 * ```
 * 
 * For paying an invoice, [`lightning-invoice`] provides a `payment` module with convenience
 * functions for use with [`send_payment`].
 * 
 * ```
 * # use lightning::events::{Event, EventsProvider};
 * # use lightning::ln::types::PaymentHash;
 * # use lightning::ln::channelmanager::{AChannelManager, PaymentId, RecentPaymentDetails, RecipientOnionFields, Retry};
 * # use lightning::routing::router::RouteParameters;
 * #
 * # fn example<T: AChannelManager>(
 * #     channel_manager: T, payment_hash: PaymentHash, recipient_onion: RecipientOnionFields,
 * #     route_params: RouteParameters, retry: Retry
 * # ) {
 * # let channel_manager = channel_manager.get_cm();
 * let (payment_hash, recipient_onion, route_params) =
 * payment::payment_parameters_from_invoice(&invoice);
 * let payment_id = PaymentId([42; 32]);
 * match channel_manager.send_payment(
 * payment_hash, recipient_onion, payment_id, route_params, retry
 * ) {
 * Ok(()) => println!(\"Sending payment with hash {}\", payment_hash),
 * Err(e) => println!(\"Failed sending payment with hash {}: {:?}\", payment_hash, e),
 * }
 * 
 * let expected_payment_id = payment_id;
 * let expected_payment_hash = payment_hash;
 * assert!(
 * channel_manager.list_recent_payments().iter().find(|details| matches!(
 * details,
 * RecentPaymentDetails::Pending {
 * payment_id: expected_payment_id,
 * payment_hash: expected_payment_hash,
 * ..
 * }
 * )).is_some()
 * );
 * 
 * On the event processing thread
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::PaymentSent { payment_hash, .. } => println!(\"Paid {}\", payment_hash),
 * Event::PaymentFailed { payment_hash: Some(payment_hash), .. } =>
 * println!(\"Failed paying {}\", payment_hash),
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # }
 * ```
 * 
 * ## BOLT 12 Offers
 * 
 * The [`offers`] module is useful for creating BOLT 12 offers. An [`Offer`] is a precursor to a
 * [`Bolt12Invoice`], which must first be requested by the payer. The interchange of these messages
 * as defined in the specification is handled by [`ChannelManager`] and its implementation of
 * [`OffersMessageHandler`]. However, this only works with an [`Offer`] created using a builder
 * returned by [`create_offer_builder`]. With this approach, BOLT 12 offers and invoices are
 * stateless just as BOLT 11 invoices are.
 * 
 * ```
 * # use lightning::events::{Event, EventsProvider, PaymentPurpose};
 * # use lightning::ln::channelmanager::AChannelManager;
 * # use lightning::offers::parse::Bolt12SemanticError;
 * #
 * # fn example<T: AChannelManager>(channel_manager: T) -> Result<(), Bolt12SemanticError> {
 * # let channel_manager = channel_manager.get_cm();
 * # let absolute_expiry = None;
 * let offer = channel_manager
 * .create_offer_builder(absolute_expiry)?
 * # ;
 * # // Needed for compiling for c_bindings
 * # let builder: lightning::offers::offer::OfferBuilder<_, _> = offer.into();
 * # let offer = builder
 * .description(\"coffee\".to_string())
 * .amount_msats(10_000_000)
 * .build()?;
 * let bech32_offer = offer.to_string();
 * 
 * On the event processing thread
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::PaymentClaimable { payment_hash, purpose, .. } => match purpose {
 * PaymentPurpose::Bolt12OfferPayment { payment_preimage: Some(payment_preimage), .. } => {
 * println!(\"Claiming payment {}\", payment_hash);
 * channel_manager.claim_funds(payment_preimage);
 * },
 * PaymentPurpose::Bolt12OfferPayment { payment_preimage: None, .. } => {
 * println!(\"Unknown payment hash: {}\", payment_hash);
 * }
 * #           _ => {},
 * },
 * Event::PaymentClaimed { payment_hash, amount_msat, .. } => {
 * println!(\"Claimed {} msats\", amount_msat);
 * },
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # Ok(())
 * # }
 * ```
 * 
 * Use [`pay_for_offer`] to initiated payment, which sends an [`InvoiceRequest`] for an [`Offer`]
 * and pays the [`Bolt12Invoice`] response.
 * 
 * ```
 * # use lightning::events::{Event, EventsProvider};
 * # use lightning::ln::channelmanager::{AChannelManager, PaymentId, RecentPaymentDetails, Retry};
 * # use lightning::offers::offer::Offer;
 * #
 * # fn example<T: AChannelManager>(
 * #     channel_manager: T, offer: &Offer, quantity: Option<u64>, amount_msats: Option<u64>,
 * #     payer_note: Option<String>, retry: Retry, max_total_routing_fee_msat: Option<u64>
 * # ) {
 * # let channel_manager = channel_manager.get_cm();
 * let payment_id = PaymentId([42; 32]);
 * match channel_manager.pay_for_offer(
 * offer, quantity, amount_msats, payer_note, payment_id, retry, max_total_routing_fee_msat
 * ) {
 * Ok(()) => println!(\"Requesting invoice for offer\"),
 * Err(e) => println!(\"Unable to request invoice for offer: {:?}\", e),
 * }
 * 
 * First the payment will be waiting on an invoice
 * let expected_payment_id = payment_id;
 * assert!(
 * channel_manager.list_recent_payments().iter().find(|details| matches!(
 * details,
 * RecentPaymentDetails::AwaitingInvoice { payment_id: expected_payment_id }
 * )).is_some()
 * );
 * 
 * Once the invoice is received, a payment will be sent
 * assert!(
 * channel_manager.list_recent_payments().iter().find(|details| matches!(
 * details,
 * RecentPaymentDetails::Pending { payment_id: expected_payment_id, ..  }
 * )).is_some()
 * );
 * 
 * On the event processing thread
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::PaymentSent { payment_id: Some(payment_id), .. } => println!(\"Paid {}\", payment_id),
 * Event::PaymentFailed { payment_id, .. } => println!(\"Failed paying {}\", payment_id),
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # }
 * ```
 * 
 * ## BOLT 12 Refunds
 * 
 * A [`Refund`] is a request for an invoice to be paid. Like *paying* for an [`Offer`], *creating*
 * a [`Refund`] involves maintaining state since it represents a future outbound payment.
 * Therefore, use [`create_refund_builder`] when creating one, otherwise [`ChannelManager`] will
 * refuse to pay any corresponding [`Bolt12Invoice`] that it receives.
 * 
 * ```
 * # use core::time::Duration;
 * # use lightning::events::{Event, EventsProvider};
 * # use lightning::ln::channelmanager::{AChannelManager, PaymentId, RecentPaymentDetails, Retry};
 * # use lightning::offers::parse::Bolt12SemanticError;
 * #
 * # fn example<T: AChannelManager>(
 * #     channel_manager: T, amount_msats: u64, absolute_expiry: Duration, retry: Retry,
 * #     max_total_routing_fee_msat: Option<u64>
 * # ) -> Result<(), Bolt12SemanticError> {
 * # let channel_manager = channel_manager.get_cm();
 * let payment_id = PaymentId([42; 32]);
 * let refund = channel_manager
 * .create_refund_builder(
 * amount_msats, absolute_expiry, payment_id, retry, max_total_routing_fee_msat
 * )?
 * # ;
 * # // Needed for compiling for c_bindings
 * # let builder: lightning::offers::refund::RefundBuilder<_> = refund.into();
 * # let refund = builder
 * .description(\"coffee\".to_string())
 * .payer_note(\"refund for order 1234\".to_string())
 * .build()?;
 * let bech32_refund = refund.to_string();
 * 
 * First the payment will be waiting on an invoice
 * let expected_payment_id = payment_id;
 * assert!(
 * channel_manager.list_recent_payments().iter().find(|details| matches!(
 * details,
 * RecentPaymentDetails::AwaitingInvoice { payment_id: expected_payment_id }
 * )).is_some()
 * );
 * 
 * Once the invoice is received, a payment will be sent
 * assert!(
 * channel_manager.list_recent_payments().iter().find(|details| matches!(
 * details,
 * RecentPaymentDetails::Pending { payment_id: expected_payment_id, ..  }
 * )).is_some()
 * );
 * 
 * On the event processing thread
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::PaymentSent { payment_id: Some(payment_id), .. } => println!(\"Paid {}\", payment_id),
 * Event::PaymentFailed { payment_id, .. } => println!(\"Failed paying {}\", payment_id),
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # Ok(())
 * # }
 * ```
 * 
 * Use [`request_refund_payment`] to send a [`Bolt12Invoice`] for receiving the refund. Similar to
 * creating* an [`Offer`], this is stateless as it represents an inbound payment.
 * 
 * ```
 * # use lightning::events::{Event, EventsProvider, PaymentPurpose};
 * # use lightning::ln::channelmanager::AChannelManager;
 * # use lightning::offers::refund::Refund;
 * #
 * # fn example<T: AChannelManager>(channel_manager: T, refund: &Refund) {
 * # let channel_manager = channel_manager.get_cm();
 * let known_payment_hash = match channel_manager.request_refund_payment(refund) {
 * Ok(invoice) => {
 * let payment_hash = invoice.payment_hash();
 * println!(\"Requesting refund payment {}\", payment_hash);
 * payment_hash
 * },
 * Err(e) => panic!(\"Unable to request payment for refund: {:?}\", e),
 * };
 * 
 * On the event processing thread
 * channel_manager.process_pending_events(&|event| {
 * match event {
 * Event::PaymentClaimable { payment_hash, purpose, .. } => match purpose {
 * PaymentPurpose::Bolt12RefundPayment { payment_preimage: Some(payment_preimage), .. } => {
 * assert_eq!(payment_hash, known_payment_hash);
 * println!(\"Claiming payment {}\", payment_hash);
 * channel_manager.claim_funds(payment_preimage);
 * },
 * PaymentPurpose::Bolt12RefundPayment { payment_preimage: None, .. } => {
 * println!(\"Unknown payment hash: {}\", payment_hash);
 * },
 * ...
 * #           _ => {},
 * },
 * Event::PaymentClaimed { payment_hash, amount_msat, .. } => {
 * assert_eq!(payment_hash, known_payment_hash);
 * println!(\"Claimed {} msats\", amount_msat);
 * },
 * ...
 * #     _ => {},
 * }
 * Ok(())
 * });
 * # }
 * ```
 * 
 * # Persistence
 * 
 * Implements [`Writeable`] to write out all channel state to disk. Implies [`peer_disconnected`] for
 * all peers during write/read (though does not modify this instance, only the instance being
 * serialized). This will result in any channels which have not yet exchanged [`funding_created`] (i.e.,
 * called [`funding_transaction_generated`] for outbound channels) being closed.
 * 
 * Note that you can be a bit lazier about writing out `ChannelManager` than you can be with
 * [`ChannelMonitor`]. With [`ChannelMonitor`] you MUST durably write each
 * [`ChannelMonitorUpdate`] before returning from
 * [`chain::Watch::watch_channel`]/[`update_channel`] or before completing async writes. With
 * `ChannelManager`s, writing updates happens out-of-band (and will prevent any other
 * `ChannelManager` operations from occurring during the serialization process). If the
 * deserialized version is out-of-date compared to the [`ChannelMonitor`] passed by reference to
 * [`read`], those channels will be force-closed based on the `ChannelMonitor` state and no funds
 * will be lost (modulo on-chain transaction fees).
 * 
 * Note that the deserializer is only implemented for `(`[`BlockHash`]`, `[`ChannelManager`]`)`, which
 * tells you the last block hash which was connected. You should get the best block tip before using the manager.
 * See [`chain::Listen`] and [`chain::Confirm`] for more details.
 * 
 * # `ChannelUpdate` Messages
 * 
 * Note that `ChannelManager` is responsible for tracking liveness of its channels and generating
 * [`ChannelUpdate`] messages informing peers that the channel is temporarily disabled. To avoid
 * spam due to quick disconnection/reconnection, updates are not sent until the channel has been
 * offline for a full minute. In order to track this, you must call
 * [`timer_tick_occurred`] roughly once per minute, though it doesn't have to be perfect.
 * 
 * # DoS Mitigation
 * 
 * To avoid trivial DoS issues, `ChannelManager` limits the number of inbound connections and
 * inbound channels without confirmed funding transactions. This may result in nodes which we do
 * not have a channel with being unable to connect to us or open new channels with us if we have
 * many peers with unfunded channels.
 * 
 * Because it is an indication of trust, inbound channels which we've accepted as 0conf are
 * exempted from the count of unfunded channels. Similarly, outbound channels and connections are
 * never limited. Please ensure you limit the count of such channels yourself.
 * 
 * # Type Aliases
 * 
 * Rather than using a plain `ChannelManager`, it is preferable to use either a [`SimpleArcChannelManager`]
 * a [`SimpleRefChannelManager`], for conciseness. See their documentation for more details, but
 * essentially you should default to using a [`SimpleRefChannelManager`], and use a
 * [`SimpleArcChannelManager`] when you require a `ChannelManager` with a static lifetime, such as when
 * you're using lightning-net-tokio.
 * 
 * [`ChainMonitor`]: crate::chain::chainmonitor::ChainMonitor
 * [`MessageHandler`]: crate::ln::peer_handler::MessageHandler
 * [`OnionMessenger`]: crate::onion_message::messenger::OnionMessenger
 * [`PeerManager::read_event`]: crate::ln::peer_handler::PeerManager::read_event
 * [`PeerManager::process_events`]: crate::ln::peer_handler::PeerManager::process_events
 * [`timer_tick_occurred`]: Self::timer_tick_occurred
 * [`get_and_clear_needs_persistence`]: Self::get_and_clear_needs_persistence
 * [`Persister`]: crate::util::persist::Persister
 * [`KVStore`]: crate::util::persist::KVStore
 * [`get_event_or_persistence_needed_future`]: Self::get_event_or_persistence_needed_future
 * [`lightning-block-sync`]: https://docs.rs/lightning_block_sync/latest/lightning_block_sync
 * [`lightning-transaction-sync`]: https://docs.rs/lightning_transaction_sync/latest/lightning_transaction_sync
 * [`lightning-background-processor`]: https://docs.rs/lightning_background_processor/lightning_background_processor
 * [`list_channels`]: Self::list_channels
 * [`list_usable_channels`]: Self::list_usable_channels
 * [`create_channel`]: Self::create_channel
 * [`close_channel`]: Self::force_close_broadcasting_latest_txn
 * [`force_close_broadcasting_latest_txn`]: Self::force_close_broadcasting_latest_txn
 * [BOLT 11]: https://github.com/lightning/bolts/blob/master/11-payment-encoding.md
 * [BOLT 12]: https://github.com/rustyrussell/lightning-rfc/blob/guilt/offers/12-offer-encoding.md
 * [`list_recent_payments`]: Self::list_recent_payments
 * [`abandon_payment`]: Self::abandon_payment
 * [`lightning-invoice`]: https://docs.rs/lightning_invoice/latest/lightning_invoice
 * [`create_inbound_payment`]: Self::create_inbound_payment
 * [`create_inbound_payment_for_hash`]: Self::create_inbound_payment_for_hash
 * [`claim_funds`]: Self::claim_funds
 * [`send_payment`]: Self::send_payment
 * [`offers`]: crate::offers
 * [`create_offer_builder`]: Self::create_offer_builder
 * [`pay_for_offer`]: Self::pay_for_offer
 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
 * [`create_refund_builder`]: Self::create_refund_builder
 * [`request_refund_payment`]: Self::request_refund_payment
 * [`peer_disconnected`]: msgs::ChannelMessageHandler::peer_disconnected
 * [`funding_created`]: msgs::FundingCreated
 * [`funding_transaction_generated`]: Self::funding_transaction_generated
 * [`BlockHash`]: bitcoin::hash_types::BlockHash
 * [`update_channel`]: chain::Watch::update_channel
 * [`ChannelUpdate`]: msgs::ChannelUpdate
 * [`read`]: ReadableArgs::read
 */
export class ChannelManager extends CommonBase {
	/* @internal */
	public constructor(_dummy: null, ptr: bigint) {
		super(ptr, bindings.ChannelManager_free);
	}

	/**
	 * Constructs a new `ChannelManager` to hold several channels and route between them.
	 * 
	 * The current time or latest block header time can be provided as the `current_timestamp`.
	 * 
	 * This is the main \"logic hub\" for all channel-related actions, and implements
	 * [`ChannelMessageHandler`].
	 * 
	 * Non-proportional fees are fixed according to our risk using the provided fee estimator.
	 * 
	 * Users need to notify the new `ChannelManager` when a new block is connected or
	 * disconnected using its [`block_connected`] and [`block_disconnected`] methods, starting
	 * from after [`params.best_block.block_hash`]. See [`chain::Listen`] and [`chain::Confirm`] for
	 * more details.
	 * 
	 * [`block_connected`]: chain::Listen::block_connected
	 * [`block_disconnected`]: chain::Listen::block_disconnected
	 * [`params.best_block.block_hash`]: chain::BestBlock::block_hash
	 */
	public static constructor_new(fee_est: FeeEstimator, chain_monitor: Watch, tx_broadcaster: BroadcasterInterface, router: Router, logger: Logger, entropy_source: EntropySource, node_signer: NodeSigner, signer_provider: SignerProvider, config: UserConfig, params: ChainParameters, current_timestamp: number): ChannelManager {
		const ret: bigint = bindings.ChannelManager_new(CommonBase.get_ptr_of(fee_est), CommonBase.get_ptr_of(chain_monitor), CommonBase.get_ptr_of(tx_broadcaster), CommonBase.get_ptr_of(router), CommonBase.get_ptr_of(logger), CommonBase.get_ptr_of(entropy_source), CommonBase.get_ptr_of(node_signer), CommonBase.get_ptr_of(signer_provider), CommonBase.get_ptr_of(config), CommonBase.get_ptr_of(params), current_timestamp);
		const ret_hu_conv: ChannelManager = new ChannelManager(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, fee_est);
		CommonBase.add_ref_from(ret_hu_conv, chain_monitor);
		CommonBase.add_ref_from(ret_hu_conv, tx_broadcaster);
		CommonBase.add_ref_from(ret_hu_conv, router);
		CommonBase.add_ref_from(ret_hu_conv, logger);
		CommonBase.add_ref_from(ret_hu_conv, entropy_source);
		CommonBase.add_ref_from(ret_hu_conv, node_signer);
		CommonBase.add_ref_from(ret_hu_conv, signer_provider);
		return ret_hu_conv;
	}

	/**
	 * Gets the current configuration applied to all new channels.
	 */
	public get_current_default_configuration(): UserConfig {
		const ret: bigint = bindings.ChannelManager_get_current_default_configuration(this.ptr);
		const ret_hu_conv: UserConfig = new UserConfig(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Creates a new outbound channel to the given remote node and with the given value.
	 * 
	 * `user_channel_id` will be provided back as in
	 * [`Event::FundingGenerationReady::user_channel_id`] to allow tracking of which events
	 * correspond with which `create_channel` call. Note that the `user_channel_id` defaults to a
	 * randomized value for inbound channels. `user_channel_id` has no meaning inside of LDK, it
	 * is simply copied to events and otherwise ignored.
	 * 
	 * Raises [`APIError::APIMisuseError`] when `channel_value_satoshis` > 2**24 or `push_msat` is
	 * greater than `channel_value_satoshis * 1k` or `channel_value_satoshis < 1000`.
	 * 
	 * Raises [`APIError::ChannelUnavailable`] if the channel cannot be opened due to failing to
	 * generate a shutdown scriptpubkey or destination script set by
	 * [`SignerProvider::get_shutdown_scriptpubkey`] or [`SignerProvider::get_destination_script`].
	 * 
	 * Note that we do not check if you are currently connected to the given peer. If no
	 * connection is available, the outbound `open_channel` message may fail to send, resulting in
	 * the channel eventually being silently forgotten (dropped on reload).
	 * 
	 * If `temporary_channel_id` is specified, it will be used as the temporary channel ID of the
	 * channel. Otherwise, a random one will be generated for you.
	 * 
	 * Returns the new Channel's temporary `channel_id`. This ID will appear as
	 * [`Event::FundingGenerationReady::temporary_channel_id`] and in
	 * [`ChannelDetails::channel_id`] until after
	 * [`ChannelManager::funding_transaction_generated`] is called, swapping the Channel's ID for
	 * one derived from the funding transaction's TXID. If the counterparty rejects the channel
	 * immediately, this temporary ID will appear in [`Event::ChannelClosed::channel_id`].
	 * 
	 * [`Event::FundingGenerationReady::user_channel_id`]: events::Event::FundingGenerationReady::user_channel_id
	 * [`Event::FundingGenerationReady::temporary_channel_id`]: events::Event::FundingGenerationReady::temporary_channel_id
	 * [`Event::ChannelClosed::channel_id`]: events::Event::ChannelClosed::channel_id
	 * 
	 * Note that temporary_channel_id (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that override_config (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public create_channel(their_network_key: Uint8Array, channel_value_satoshis: bigint, push_msat: bigint, user_channel_id: bigint, temporary_channel_id: ChannelId|null, override_config: UserConfig|null): Result_ChannelIdAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_create_channel(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(their_network_key, 33)), channel_value_satoshis, push_msat, bindings.encodeUint128(user_channel_id), temporary_channel_id == null ? 0n : CommonBase.get_ptr_of(temporary_channel_id), override_config == null ? 0n : CommonBase.get_ptr_of(override_config));
		const ret_hu_conv: Result_ChannelIdAPIErrorZ = Result_ChannelIdAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Gets the list of open channels, in random order. See [`ChannelDetails`] field documentation for
	 * more information.
	 */
	public list_channels(): ChannelDetails[] {
		const ret: number = bindings.ChannelManager_list_channels(this.ptr);
		const ret_conv_16_len: number = bindings.getArrayLength(ret);
		const ret_conv_16_arr: ChannelDetails[] = new Array(ret_conv_16_len).fill(null);
		for (var q = 0; q < ret_conv_16_len; q++) {
			const ret_conv_16: bigint = bindings.getU64ArrayElem(ret, q);
			const ret_conv_16_hu_conv: ChannelDetails = new ChannelDetails(null, ret_conv_16);
			CommonBase.add_ref_from(ret_conv_16_hu_conv, this);
			ret_conv_16_arr[q] = ret_conv_16_hu_conv;
		}
		bindings.freeWasmMemory(ret)
		return ret_conv_16_arr;
	}

	/**
	 * Gets the list of usable channels, in random order. Useful as an argument to
	 * [`Router::find_route`] to ensure non-announced channels are used.
	 * 
	 * These are guaranteed to have their [`ChannelDetails::is_usable`] value set to true, see the
	 * documentation for [`ChannelDetails::is_usable`] for more info on exactly what the criteria
	 * are.
	 */
	public list_usable_channels(): ChannelDetails[] {
		const ret: number = bindings.ChannelManager_list_usable_channels(this.ptr);
		const ret_conv_16_len: number = bindings.getArrayLength(ret);
		const ret_conv_16_arr: ChannelDetails[] = new Array(ret_conv_16_len).fill(null);
		for (var q = 0; q < ret_conv_16_len; q++) {
			const ret_conv_16: bigint = bindings.getU64ArrayElem(ret, q);
			const ret_conv_16_hu_conv: ChannelDetails = new ChannelDetails(null, ret_conv_16);
			CommonBase.add_ref_from(ret_conv_16_hu_conv, this);
			ret_conv_16_arr[q] = ret_conv_16_hu_conv;
		}
		bindings.freeWasmMemory(ret)
		return ret_conv_16_arr;
	}

	/**
	 * Gets the list of channels we have with a given counterparty, in random order.
	 */
	public list_channels_with_counterparty(counterparty_node_id: Uint8Array): ChannelDetails[] {
		const ret: number = bindings.ChannelManager_list_channels_with_counterparty(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)));
		const ret_conv_16_len: number = bindings.getArrayLength(ret);
		const ret_conv_16_arr: ChannelDetails[] = new Array(ret_conv_16_len).fill(null);
		for (var q = 0; q < ret_conv_16_len; q++) {
			const ret_conv_16: bigint = bindings.getU64ArrayElem(ret, q);
			const ret_conv_16_hu_conv: ChannelDetails = new ChannelDetails(null, ret_conv_16);
			CommonBase.add_ref_from(ret_conv_16_hu_conv, this);
			ret_conv_16_arr[q] = ret_conv_16_hu_conv;
		}
		bindings.freeWasmMemory(ret)
		return ret_conv_16_arr;
	}

	/**
	 * Returns in an undefined order recent payments that -- if not fulfilled -- have yet to find a
	 * successful path, or have unresolved HTLCs.
	 * 
	 * This can be useful for payments that may have been prepared, but ultimately not sent, as a
	 * result of a crash. If such a payment exists, is not listed here, and an
	 * [`Event::PaymentSent`] has not been received, you may consider resending the payment.
	 * 
	 * [`Event::PaymentSent`]: events::Event::PaymentSent
	 */
	public list_recent_payments(): RecentPaymentDetails[] {
		const ret: number = bindings.ChannelManager_list_recent_payments(this.ptr);
		const ret_conv_22_len: number = bindings.getArrayLength(ret);
		const ret_conv_22_arr: RecentPaymentDetails[] = new Array(ret_conv_22_len).fill(null);
		for (var w = 0; w < ret_conv_22_len; w++) {
			const ret_conv_22: bigint = bindings.getU64ArrayElem(ret, w);
			const ret_conv_22_hu_conv: RecentPaymentDetails = RecentPaymentDetails.constr_from_ptr(ret_conv_22);
			CommonBase.add_ref_from(ret_conv_22_hu_conv, this);
			ret_conv_22_arr[w] = ret_conv_22_hu_conv;
		}
		bindings.freeWasmMemory(ret)
		return ret_conv_22_arr;
	}

	/**
	 * Begins the process of closing a channel. After this call (plus some timeout), no new HTLCs
	 * will be accepted on the given channel, and after additional timeout/the closing of all
	 * pending HTLCs, the channel will be closed on chain.
	 * 
	 * If we are the channel initiator, we will pay between our [`ChannelCloseMinimum`] and
	 * [`ChannelConfig::force_close_avoidance_max_fee_satoshis`] plus our [`NonAnchorChannelFee`]
	 * fee estimate.
	 * If our counterparty is the channel initiator, we will require a channel closing
	 * transaction feerate of at least our [`ChannelCloseMinimum`] feerate or the feerate which
	 * would appear on a force-closure transaction, whichever is lower. We will allow our
	 * counterparty to pay as much fee as they'd like, however.
	 * 
	 * May generate a [`SendShutdown`] message event on success, which should be relayed.
	 * 
	 * Raises [`APIError::ChannelUnavailable`] if the channel cannot be closed due to failing to
	 * generate a shutdown scriptpubkey or destination script set by
	 * [`SignerProvider::get_shutdown_scriptpubkey`]. A force-closure may be needed to close the
	 * channel.
	 * 
	 * [`ChannelConfig::force_close_avoidance_max_fee_satoshis`]: crate::util::config::ChannelConfig::force_close_avoidance_max_fee_satoshis
	 * [`ChannelCloseMinimum`]: crate::chain::chaininterface::ConfirmationTarget::ChannelCloseMinimum
	 * [`NonAnchorChannelFee`]: crate::chain::chaininterface::ConfirmationTarget::NonAnchorChannelFee
	 * [`SendShutdown`]: crate::events::MessageSendEvent::SendShutdown
	 */
	public close_channel(channel_id: ChannelId, counterparty_node_id: Uint8Array): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_close_channel(this.ptr, CommonBase.get_ptr_of(channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, channel_id);
		return ret_hu_conv;
	}

	/**
	 * Begins the process of closing a channel. After this call (plus some timeout), no new HTLCs
	 * will be accepted on the given channel, and after additional timeout/the closing of all
	 * pending HTLCs, the channel will be closed on chain.
	 * 
	 * `target_feerate_sat_per_1000_weight` has different meanings depending on if we initiated
	 * the channel being closed or not:
	 * If we are the channel initiator, we will pay at least this feerate on the closing
	 * transaction. The upper-bound is set by
	 * [`ChannelConfig::force_close_avoidance_max_fee_satoshis`] plus our [`NonAnchorChannelFee`]
	 * fee estimate (or `target_feerate_sat_per_1000_weight`, if it is greater).
	 * If our counterparty is the channel initiator, we will refuse to accept a channel closure
	 * transaction feerate below `target_feerate_sat_per_1000_weight` (or the feerate which
	 * will appear on a force-closure transaction, whichever is lower).
	 * 
	 * The `shutdown_script` provided  will be used as the `scriptPubKey` for the closing transaction.
	 * Will fail if a shutdown script has already been set for this channel by
	 * ['ChannelHandshakeConfig::commit_upfront_shutdown_pubkey`]. The given shutdown script must
	 * also be compatible with our and the counterparty's features.
	 * 
	 * May generate a [`SendShutdown`] message event on success, which should be relayed.
	 * 
	 * Raises [`APIError::ChannelUnavailable`] if the channel cannot be closed due to failing to
	 * generate a shutdown scriptpubkey or destination script set by
	 * [`SignerProvider::get_shutdown_scriptpubkey`]. A force-closure may be needed to close the
	 * channel.
	 * 
	 * [`ChannelConfig::force_close_avoidance_max_fee_satoshis`]: crate::util::config::ChannelConfig::force_close_avoidance_max_fee_satoshis
	 * [`NonAnchorChannelFee`]: crate::chain::chaininterface::ConfirmationTarget::NonAnchorChannelFee
	 * [`SendShutdown`]: crate::events::MessageSendEvent::SendShutdown
	 * 
	 * Note that shutdown_script (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public close_channel_with_feerate_and_script(channel_id: ChannelId, counterparty_node_id: Uint8Array, target_feerate_sats_per_1000_weight: Option_u32Z, shutdown_script: ShutdownScript|null): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_close_channel_with_feerate_and_script(this.ptr, CommonBase.get_ptr_of(channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), CommonBase.get_ptr_of(target_feerate_sats_per_1000_weight), shutdown_script == null ? 0n : CommonBase.get_ptr_of(shutdown_script));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, channel_id);
		return ret_hu_conv;
	}

	/**
	 * Force closes a channel, immediately broadcasting the latest local transaction(s),
	 * rejecting new HTLCs.
	 * 
	 * The provided `error_message` is sent to connected peers for closing
	 * channels and should be a human-readable description of what went wrong.
	 * 
	 * Fails if `channel_id` is unknown to the manager, or if the `counterparty_node_id`
	 * isn't the counterparty of the corresponding channel.
	 */
	public force_close_broadcasting_latest_txn(channel_id: ChannelId, counterparty_node_id: Uint8Array, error_message: string): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_force_close_broadcasting_latest_txn(this.ptr, CommonBase.get_ptr_of(channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), bindings.encodeString(error_message));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, channel_id);
		return ret_hu_conv;
	}

	/**
	 * Force closes a channel, rejecting new HTLCs on the given channel but skips broadcasting
	 * the latest local transaction(s).
	 * 
	 * The provided `error_message` is sent to connected peers for closing channels and should
	 * be a human-readable description of what went wrong.
	 * 
	 * Fails if `channel_id` is unknown to the manager, or if the
	 * `counterparty_node_id` isn't the counterparty of the corresponding channel.
	 * You can always broadcast the latest local transaction(s) via
	 * [`ChannelMonitor::broadcast_latest_holder_commitment_txn`].
	 */
	public force_close_without_broadcasting_txn(channel_id: ChannelId, counterparty_node_id: Uint8Array, error_message: string): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_force_close_without_broadcasting_txn(this.ptr, CommonBase.get_ptr_of(channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), bindings.encodeString(error_message));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, channel_id);
		return ret_hu_conv;
	}

	/**
	 * Force close all channels, immediately broadcasting the latest local commitment transaction
	 * for each to the chain and rejecting new HTLCs on each.
	 * 
	 * The provided `error_message` is sent to connected peers for closing channels and should
	 * be a human-readable description of what went wrong.
	 */
	public force_close_all_channels_broadcasting_latest_txn(error_message: string): void {
		bindings.ChannelManager_force_close_all_channels_broadcasting_latest_txn(this.ptr, bindings.encodeString(error_message));
	}

	/**
	 * Force close all channels rejecting new HTLCs on each but without broadcasting the latest
	 * local transaction(s).
	 * 
	 * The provided `error_message` is sent to connected peers for closing channels and
	 * should be a human-readable description of what went wrong.
	 */
	public force_close_all_channels_without_broadcasting_txn(error_message: string): void {
		bindings.ChannelManager_force_close_all_channels_without_broadcasting_txn(this.ptr, bindings.encodeString(error_message));
	}

	/**
	 * Sends a payment along a given route.
	 * 
	 * This method is *DEPRECATED*, use [`Self::send_payment`] instead. If you wish to fix the
	 * route for a payment, do so by matching the [`PaymentId`] passed to
	 * [`Router::find_route_with_id`].
	 * 
	 * Value parameters are provided via the last hop in route, see documentation for [`RouteHop`]
	 * fields for more info.
	 * 
	 * May generate [`UpdateHTLCs`] message(s) event on success, which should be relayed (e.g. via
	 * [`PeerManager::process_events`]).
	 * 
	 * # Avoiding Duplicate Payments
	 * 
	 * If a pending payment is currently in-flight with the same [`PaymentId`] provided, this
	 * method will error with an [`APIError::InvalidRoute`]. Note, however, that once a payment
	 * is no longer pending (either via [`ChannelManager::abandon_payment`], or handling of an
	 * [`Event::PaymentSent`] or [`Event::PaymentFailed`]) LDK will not stop you from sending a
	 * second payment with the same [`PaymentId`].
	 * 
	 * Thus, in order to ensure duplicate payments are not sent, you should implement your own
	 * tracking of payments, including state to indicate once a payment has completed. Because you
	 * should also ensure that [`PaymentHash`]es are not re-used, for simplicity, you should
	 * consider using the [`PaymentHash`] as the key for tracking payments. In that case, the
	 * [`PaymentId`] should be a copy of the [`PaymentHash`] bytes.
	 * 
	 * Additionally, in the scenario where we begin the process of sending a payment, but crash
	 * before `send_payment` returns (or prior to [`ChannelMonitorUpdate`] persistence if you're
	 * using [`ChannelMonitorUpdateStatus::InProgress`]), the payment may be lost on restart. See
	 * [`ChannelManager::list_recent_payments`] for more information.
	 * 
	 * # Possible Error States on [`PaymentSendFailure`]
	 * 
	 * Each path may have a different return value, and [`PaymentSendFailure`] may return a `Vec` with
	 * each entry matching the corresponding-index entry in the route paths, see
	 * [`PaymentSendFailure`] for more info.
	 * 
	 * In general, a path may raise:
	 * [`APIError::InvalidRoute`] when an invalid route or forwarding parameter (cltv_delta, fee,
	 * node public key) is specified.
	 * [`APIError::ChannelUnavailable`] if the next-hop channel is not available as it has been
	 * closed, doesn't exist, or the peer is currently disconnected.
	 * [`APIError::MonitorUpdateInProgress`] if a new monitor update failure prevented sending the
	 * relevant updates.
	 * 
	 * Note that depending on the type of the [`PaymentSendFailure`] the HTLC may have been
	 * irrevocably committed to on our end. In such a case, do NOT retry the payment with a
	 * different route unless you intend to pay twice!
	 * 
	 * [`RouteHop`]: crate::routing::router::RouteHop
	 * [`Event::PaymentSent`]: events::Event::PaymentSent
	 * [`Event::PaymentFailed`]: events::Event::PaymentFailed
	 * [`UpdateHTLCs`]: events::MessageSendEvent::UpdateHTLCs
	 * [`PeerManager::process_events`]: crate::ln::peer_handler::PeerManager::process_events
	 * [`ChannelMonitorUpdateStatus::InProgress`]: crate::chain::ChannelMonitorUpdateStatus::InProgress
	 */
	public send_payment_with_route(route: Route, payment_hash: Uint8Array, recipient_onion: RecipientOnionFields, payment_id: Uint8Array): Result_NonePaymentSendFailureZ {
		const ret: bigint = bindings.ChannelManager_send_payment_with_route(this.ptr, CommonBase.get_ptr_of(route), bindings.encodeUint8Array(bindings.check_arr_len(payment_hash, 32)), CommonBase.get_ptr_of(recipient_onion), bindings.encodeUint8Array(bindings.check_arr_len(payment_id, 32)));
		const ret_hu_conv: Result_NonePaymentSendFailureZ = Result_NonePaymentSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Similar to [`ChannelManager::send_payment_with_route`], but will automatically find a route based on
	 * `route_params` and retry failed payment paths based on `retry_strategy`.
	 */
	public send_payment(payment_hash: Uint8Array, recipient_onion: RecipientOnionFields, payment_id: Uint8Array, route_params: RouteParameters, retry_strategy: Retry): Result_NoneRetryableSendFailureZ {
		const ret: bigint = bindings.ChannelManager_send_payment(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_hash, 32)), CommonBase.get_ptr_of(recipient_onion), bindings.encodeUint8Array(bindings.check_arr_len(payment_id, 32)), CommonBase.get_ptr_of(route_params), CommonBase.get_ptr_of(retry_strategy));
		const ret_hu_conv: Result_NoneRetryableSendFailureZ = Result_NoneRetryableSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Signals that no further attempts for the given payment should occur. Useful if you have a
	 * pending outbound payment with retries remaining, but wish to stop retrying the payment before
	 * retries are exhausted.
	 * 
	 * # Event Generation
	 * 
	 * If no [`Event::PaymentFailed`] event had been generated before, one will be generated as soon
	 * as there are no remaining pending HTLCs for this payment.
	 * 
	 * Note that calling this method does *not* prevent a payment from succeeding. You must still
	 * wait until you receive either a [`Event::PaymentFailed`] or [`Event::PaymentSent`] event to
	 * determine the ultimate status of a payment.
	 * 
	 * # Requested Invoices
	 * 
	 * In the case of paying a [`Bolt12Invoice`] via [`ChannelManager::pay_for_offer`], abandoning
	 * the payment prior to receiving the invoice will result in an [`Event::PaymentFailed`] and
	 * prevent any attempts at paying it once received.
	 * 
	 * # Restart Behavior
	 * 
	 * If an [`Event::PaymentFailed`] is generated and we restart without first persisting the
	 * [`ChannelManager`], another [`Event::PaymentFailed`] may be generated.
	 * 
	 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
	 */
	public abandon_payment(payment_id: Uint8Array): void {
		bindings.ChannelManager_abandon_payment(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_id, 32)));
	}

	/**
	 * Send a spontaneous payment, which is a payment that does not require the recipient to have
	 * generated an invoice. Optionally, you may specify the preimage. If you do choose to specify
	 * the preimage, it must be a cryptographically secure random value that no intermediate node
	 * would be able to guess -- otherwise, an intermediate node may claim the payment and it will
	 * never reach the recipient.
	 * 
	 * See [`send_payment`] documentation for more details on the return value of this function
	 * and idempotency guarantees provided by the [`PaymentId`] key.
	 * 
	 * Similar to regular payments, you MUST NOT reuse a `payment_preimage` value. See
	 * [`send_payment`] for more information about the risks of duplicate preimage usage.
	 * 
	 * [`send_payment`]: Self::send_payment
	 */
	public send_spontaneous_payment(route: Route, payment_preimage: Option_ThirtyTwoBytesZ, recipient_onion: RecipientOnionFields, payment_id: Uint8Array): Result_ThirtyTwoBytesPaymentSendFailureZ {
		const ret: bigint = bindings.ChannelManager_send_spontaneous_payment(this.ptr, CommonBase.get_ptr_of(route), CommonBase.get_ptr_of(payment_preimage), CommonBase.get_ptr_of(recipient_onion), bindings.encodeUint8Array(bindings.check_arr_len(payment_id, 32)));
		const ret_hu_conv: Result_ThirtyTwoBytesPaymentSendFailureZ = Result_ThirtyTwoBytesPaymentSendFailureZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, route);
		return ret_hu_conv;
	}

	/**
	 * Similar to [`ChannelManager::send_spontaneous_payment`], but will automatically find a route
	 * based on `route_params` and retry failed payment paths based on `retry_strategy`.
	 * 
	 * See [`PaymentParameters::for_keysend`] for help in constructing `route_params` for spontaneous
	 * payments.
	 * 
	 * [`PaymentParameters::for_keysend`]: crate::routing::router::PaymentParameters::for_keysend
	 */
	public send_spontaneous_payment_with_retry(payment_preimage: Option_ThirtyTwoBytesZ, recipient_onion: RecipientOnionFields, payment_id: Uint8Array, route_params: RouteParameters, retry_strategy: Retry): Result_ThirtyTwoBytesRetryableSendFailureZ {
		const ret: bigint = bindings.ChannelManager_send_spontaneous_payment_with_retry(this.ptr, CommonBase.get_ptr_of(payment_preimage), CommonBase.get_ptr_of(recipient_onion), bindings.encodeUint8Array(bindings.check_arr_len(payment_id, 32)), CommonBase.get_ptr_of(route_params), CommonBase.get_ptr_of(retry_strategy));
		const ret_hu_conv: Result_ThirtyTwoBytesRetryableSendFailureZ = Result_ThirtyTwoBytesRetryableSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Send a payment that is probing the given route for liquidity. We calculate the
	 * [`PaymentHash`] of probes based on a static secret and a random [`PaymentId`], which allows
	 * us to easily discern them from real payments.
	 */
	public send_probe(path: Path): Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZPaymentSendFailureZ {
		const ret: bigint = bindings.ChannelManager_send_probe(this.ptr, CommonBase.get_ptr_of(path));
		const ret_hu_conv: Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZPaymentSendFailureZ = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZPaymentSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Sends payment probes over all paths of a route that would be used to pay the given
	 * amount to the given `node_id`.
	 * 
	 * See [`ChannelManager::send_preflight_probes`] for more information.
	 */
	public send_spontaneous_preflight_probes(node_id: Uint8Array, amount_msat: bigint, final_cltv_expiry_delta: number, liquidity_limit_multiplier: Option_u64Z): Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ {
		const ret: bigint = bindings.ChannelManager_send_spontaneous_preflight_probes(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), amount_msat, final_cltv_expiry_delta, CommonBase.get_ptr_of(liquidity_limit_multiplier));
		const ret_hu_conv: Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ = Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Sends payment probes over all paths of a route that would be used to pay a route found
	 * according to the given [`RouteParameters`].
	 * 
	 * This may be used to send \"pre-flight\" probes, i.e., to train our scorer before conducting
	 * the actual payment. Note this is only useful if there likely is sufficient time for the
	 * probe to settle before sending out the actual payment, e.g., when waiting for user
	 * confirmation in a wallet UI.
	 * 
	 * Otherwise, there is a chance the probe could take up some liquidity needed to complete the
	 * actual payment. Users should therefore be cautious and might avoid sending probes if
	 * liquidity is scarce and/or they don't expect the probe to return before they send the
	 * payment. To mitigate this issue, channels with available liquidity less than the required
	 * amount times the given `liquidity_limit_multiplier` won't be used to send pre-flight
	 * probes. If `None` is given as `liquidity_limit_multiplier`, it defaults to `3`.
	 */
	public send_preflight_probes(route_params: RouteParameters, liquidity_limit_multiplier: Option_u64Z): Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ {
		const ret: bigint = bindings.ChannelManager_send_preflight_probes(this.ptr, CommonBase.get_ptr_of(route_params), CommonBase.get_ptr_of(liquidity_limit_multiplier));
		const ret_hu_conv: Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ = Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Call this upon creation of a funding transaction for the given channel.
	 * 
	 * Returns an [`APIError::APIMisuseError`] if the funding_transaction spent non-SegWit outputs
	 * or if no output was found which matches the parameters in [`Event::FundingGenerationReady`].
	 * 
	 * Returns [`APIError::APIMisuseError`] if the funding transaction is not final for propagation
	 * across the p2p network.
	 * 
	 * Returns [`APIError::ChannelUnavailable`] if a funding transaction has already been provided
	 * for the channel or if the channel has been closed as indicated by [`Event::ChannelClosed`].
	 * 
	 * May panic if the output found in the funding transaction is duplicative with some other
	 * channel (note that this should be trivially prevented by using unique funding transaction
	 * keys per-channel).
	 * 
	 * Do NOT broadcast the funding transaction yourself. When we have safely received our
	 * counterparty's signature the funding transaction will automatically be broadcast via the
	 * [`BroadcasterInterface`] provided when this `ChannelManager` was constructed.
	 * 
	 * Note that this includes RBF or similar transaction replacement strategies - lightning does
	 * not currently support replacing a funding transaction on an existing channel. Instead,
	 * create a new channel with a conflicting funding transaction.
	 * 
	 * Note to keep the miner incentives aligned in moving the blockchain forward, we recommend
	 * the wallet software generating the funding transaction to apply anti-fee sniping as
	 * implemented by Bitcoin Core wallet. See <https://bitcoinops.org/en/topics/fee-sniping/>
	 * for more details.
	 * 
	 * [`Event::FundingGenerationReady`]: crate::events::Event::FundingGenerationReady
	 * [`Event::ChannelClosed`]: crate::events::Event::ChannelClosed
	 */
	public funding_transaction_generated(temporary_channel_id: ChannelId, counterparty_node_id: Uint8Array, funding_transaction: Uint8Array): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_funding_transaction_generated(this.ptr, CommonBase.get_ptr_of(temporary_channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), bindings.encodeUint8Array(funding_transaction));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Unsafe**: This method does not validate the spent output. It is the caller's
	 * responsibility to ensure the spent outputs are SegWit, as well as making sure the funding
	 * transaction has a final absolute locktime, i.e., its locktime is lower than the next block height.
	 * 
	 * For a safer method, please refer to [`ChannelManager::funding_transaction_generated`].
	 * 
	 * Call this in response to a [`Event::FundingGenerationReady`] event.
	 * 
	 * Note that if this method is called successfully, the funding transaction won't be
	 * broadcasted and you are expected to broadcast it manually when receiving the
	 * [`Event::FundingTxBroadcastSafe`] event.
	 * 
	 * Returns [`APIError::ChannelUnavailable`] if a funding transaction has already been provided
	 * for the channel or if the channel has been closed as indicated by [`Event::ChannelClosed`].
	 * 
	 * May panic if the funding output is duplicative with some other channel (note that this
	 * should be trivially prevented by using unique funding transaction keys per-channel).
	 * 
	 * Note to keep the miner incentives aligned in moving the blockchain forward, we recommend
	 * the wallet software generating the funding transaction to apply anti-fee sniping as
	 * implemented by Bitcoin Core wallet. See <https://bitcoinops.org/en/topics/fee-sniping/> for
	 * more details.
	 * 
	 * [`Event::FundingGenerationReady`]: crate::events::Event::FundingGenerationReady
	 * [`Event::FundingTxBroadcastSafe`]: crate::events::Event::FundingTxBroadcastSafe
	 * [`Event::ChannelClosed`]: crate::events::Event::ChannelClosed
	 * [`ChannelManager::funding_transaction_generated`]: crate::ln::channelmanager::ChannelManager::funding_transaction_generated
	 */
	public unsafe_manual_funding_transaction_generated(temporary_channel_id: ChannelId, counterparty_node_id: Uint8Array, funding: OutPoint): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_unsafe_manual_funding_transaction_generated(this.ptr, CommonBase.get_ptr_of(temporary_channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), CommonBase.get_ptr_of(funding));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Call this upon creation of a batch funding transaction for the given channels.
	 * 
	 * Return values are identical to [`Self::funding_transaction_generated`], respective to
	 * each individual channel and transaction output.
	 * 
	 * Do NOT broadcast the funding transaction yourself. This batch funding transaction
	 * will only be broadcast when we have safely received and persisted the counterparty's
	 * signature for each channel.
	 * 
	 * If there is an error, all channels in the batch are to be considered closed.
	 */
	public batch_funding_transaction_generated(temporary_channels: TwoTuple_ChannelIdPublicKeyZ[], funding_transaction: Uint8Array): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_batch_funding_transaction_generated(this.ptr, bindings.encodeUint64Array(temporary_channels.map(temporary_channels_conv_30 => CommonBase.get_ptr_of(temporary_channels_conv_30))), bindings.encodeUint8Array(funding_transaction));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Atomically applies partial updates to the [`ChannelConfig`] of the given channels.
	 * 
	 * Once the updates are applied, each eligible channel (advertised with a known short channel
	 * ID and a change in [`forwarding_fee_proportional_millionths`], [`forwarding_fee_base_msat`],
	 * or [`cltv_expiry_delta`]) has a [`BroadcastChannelUpdate`] event message generated
	 * containing the new [`ChannelUpdate`] message which should be broadcast to the network.
	 * 
	 * Returns [`ChannelUnavailable`] when a channel is not found or an incorrect
	 * `counterparty_node_id` is provided.
	 * 
	 * Returns [`APIMisuseError`] when a [`cltv_expiry_delta`] update is to be applied with a value
	 * below [`MIN_CLTV_EXPIRY_DELTA`].
	 * 
	 * If an error is returned, none of the updates should be considered applied.
	 * 
	 * [`forwarding_fee_proportional_millionths`]: ChannelConfig::forwarding_fee_proportional_millionths
	 * [`forwarding_fee_base_msat`]: ChannelConfig::forwarding_fee_base_msat
	 * [`cltv_expiry_delta`]: ChannelConfig::cltv_expiry_delta
	 * [`BroadcastChannelUpdate`]: events::MessageSendEvent::BroadcastChannelUpdate
	 * [`ChannelUpdate`]: msgs::ChannelUpdate
	 * [`ChannelUnavailable`]: APIError::ChannelUnavailable
	 * [`APIMisuseError`]: APIError::APIMisuseError
	 */
	public update_partial_channel_config(counterparty_node_id: Uint8Array, channel_ids: ChannelId[], config_update: ChannelConfigUpdate): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_update_partial_channel_config(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), bindings.encodeUint64Array(channel_ids.map(channel_ids_conv_11 => CommonBase.get_ptr_of(channel_ids_conv_11))), CommonBase.get_ptr_of(config_update));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, config_update);
		return ret_hu_conv;
	}

	/**
	 * Atomically updates the [`ChannelConfig`] for the given channels.
	 * 
	 * Once the updates are applied, each eligible channel (advertised with a known short channel
	 * ID and a change in [`forwarding_fee_proportional_millionths`], [`forwarding_fee_base_msat`],
	 * or [`cltv_expiry_delta`]) has a [`BroadcastChannelUpdate`] event message generated
	 * containing the new [`ChannelUpdate`] message which should be broadcast to the network.
	 * 
	 * Returns [`ChannelUnavailable`] when a channel is not found or an incorrect
	 * `counterparty_node_id` is provided.
	 * 
	 * Returns [`APIMisuseError`] when a [`cltv_expiry_delta`] update is to be applied with a value
	 * below [`MIN_CLTV_EXPIRY_DELTA`].
	 * 
	 * If an error is returned, none of the updates should be considered applied.
	 * 
	 * [`forwarding_fee_proportional_millionths`]: ChannelConfig::forwarding_fee_proportional_millionths
	 * [`forwarding_fee_base_msat`]: ChannelConfig::forwarding_fee_base_msat
	 * [`cltv_expiry_delta`]: ChannelConfig::cltv_expiry_delta
	 * [`BroadcastChannelUpdate`]: events::MessageSendEvent::BroadcastChannelUpdate
	 * [`ChannelUpdate`]: msgs::ChannelUpdate
	 * [`ChannelUnavailable`]: APIError::ChannelUnavailable
	 * [`APIMisuseError`]: APIError::APIMisuseError
	 */
	public update_channel_config(counterparty_node_id: Uint8Array, channel_ids: ChannelId[], config: ChannelConfig): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_update_channel_config(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), bindings.encodeUint64Array(channel_ids.map(channel_ids_conv_11 => CommonBase.get_ptr_of(channel_ids_conv_11))), CommonBase.get_ptr_of(config));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, config);
		return ret_hu_conv;
	}

	/**
	 * Attempts to forward an intercepted HTLC over the provided channel id and with the provided
	 * amount to forward. Should only be called in response to an [`HTLCIntercepted`] event.
	 * 
	 * Intercepted HTLCs can be useful for Lightning Service Providers (LSPs) to open a just-in-time
	 * channel to a receiving node if the node lacks sufficient inbound liquidity.
	 * 
	 * To make use of intercepted HTLCs, set [`UserConfig::accept_intercept_htlcs`] and use
	 * [`ChannelManager::get_intercept_scid`] to generate short channel id(s) to put in the
	 * receiver's invoice route hints. These route hints will signal to LDK to generate an
	 * [`HTLCIntercepted`] event when it receives the forwarded HTLC, and this method or
	 * [`ChannelManager::fail_intercepted_htlc`] MUST be called in response to the event.
	 * 
	 * Note that LDK does not enforce fee requirements in `amt_to_forward_msat`, and will not stop
	 * you from forwarding more than you received. See
	 * [`HTLCIntercepted::expected_outbound_amount_msat`] for more on forwarding a different amount
	 * than expected.
	 * 
	 * Errors if the event was not handled in time, in which case the HTLC was automatically failed
	 * backwards.
	 * 
	 * [`UserConfig::accept_intercept_htlcs`]: crate::util::config::UserConfig::accept_intercept_htlcs
	 * [`HTLCIntercepted`]: events::Event::HTLCIntercepted
	 * [`HTLCIntercepted::expected_outbound_amount_msat`]: events::Event::HTLCIntercepted::expected_outbound_amount_msat
	 */
	public forward_intercepted_htlc(intercept_id: Uint8Array, next_hop_channel_id: ChannelId, next_node_id: Uint8Array, amt_to_forward_msat: bigint): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_forward_intercepted_htlc(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(intercept_id, 32)), CommonBase.get_ptr_of(next_hop_channel_id), bindings.encodeUint8Array(bindings.check_arr_len(next_node_id, 33)), amt_to_forward_msat);
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, next_hop_channel_id);
		return ret_hu_conv;
	}

	/**
	 * Fails the intercepted HTLC indicated by intercept_id. Should only be called in response to
	 * an [`HTLCIntercepted`] event. See [`ChannelManager::forward_intercepted_htlc`].
	 * 
	 * Errors if the event was not handled in time, in which case the HTLC was automatically failed
	 * backwards.
	 * 
	 * [`HTLCIntercepted`]: events::Event::HTLCIntercepted
	 */
	public fail_intercepted_htlc(intercept_id: Uint8Array): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_fail_intercepted_htlc(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(intercept_id, 32)));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Processes HTLCs which are pending waiting on random forward delay.
	 * 
	 * Should only really ever be called in response to a PendingHTLCsForwardable event.
	 * Will likely generate further events.
	 */
	public process_pending_htlc_forwards(): void {
		bindings.ChannelManager_process_pending_htlc_forwards(this.ptr);
	}

	/**
	 * Performs actions which should happen on startup and roughly once per minute thereafter.
	 * 
	 * This currently includes:
	 * Increasing or decreasing the on-chain feerate estimates for our outbound channels,
	 * Broadcasting [`ChannelUpdate`] messages if we've been disconnected from our peer for more
	 * than a minute, informing the network that they should no longer attempt to route over
	 * the channel.
	 * Expiring a channel's previous [`ChannelConfig`] if necessary to only allow forwarding HTLCs
	 * with the current [`ChannelConfig`].
	 * Removing peers which have disconnected but and no longer have any channels.
	 * Force-closing and removing channels which have not completed establishment in a timely manner.
	 * Forgetting about stale outbound payments, either those that have already been fulfilled
	 * or those awaiting an invoice that hasn't been delivered in the necessary amount of time.
	 * The latter is determined using the system clock in `std` and the highest seen block time
	 * minus two hours in `no-std`.
	 * 
	 * Note that this may cause reentrancy through [`chain::Watch::update_channel`] calls or feerate
	 * estimate fetches.
	 * 
	 * [`ChannelUpdate`]: msgs::ChannelUpdate
	 * [`ChannelConfig`]: crate::util::config::ChannelConfig
	 */
	public timer_tick_occurred(): void {
		bindings.ChannelManager_timer_tick_occurred(this.ptr);
	}

	/**
	 * Indicates that the preimage for payment_hash is unknown or the received amount is incorrect
	 * after a PaymentClaimable event, failing the HTLC back to its origin and freeing resources
	 * along the path (including in our own channel on which we received it).
	 * 
	 * Note that in some cases around unclean shutdown, it is possible the payment may have
	 * already been claimed by you via [`ChannelManager::claim_funds`] prior to you seeing (a
	 * second copy of) the [`events::Event::PaymentClaimable`] event. Alternatively, the payment
	 * may have already been failed automatically by LDK if it was nearing its expiration time.
	 * 
	 * While LDK will never claim a payment automatically on your behalf (i.e. without you calling
	 * [`ChannelManager::claim_funds`]), you should still monitor for
	 * [`events::Event::PaymentClaimed`] events even for payments you intend to fail, especially on
	 * startup during which time claims that were in-progress at shutdown may be replayed.
	 */
	public fail_htlc_backwards(payment_hash: Uint8Array): void {
		bindings.ChannelManager_fail_htlc_backwards(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_hash, 32)));
	}

	/**
	 * This is a variant of [`ChannelManager::fail_htlc_backwards`] that allows you to specify the
	 * reason for the failure.
	 * 
	 * See [`FailureCode`] for valid failure codes.
	 */
	public fail_htlc_backwards_with_reason(payment_hash: Uint8Array, failure_code: FailureCode): void {
		bindings.ChannelManager_fail_htlc_backwards_with_reason(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_hash, 32)), CommonBase.get_ptr_of(failure_code));
	}

	/**
	 * Provides a payment preimage in response to [`Event::PaymentClaimable`], generating any
	 * [`MessageSendEvent`]s needed to claim the payment.
	 * 
	 * This method is guaranteed to ensure the payment has been claimed but only if the current
	 * height is strictly below [`Event::PaymentClaimable::claim_deadline`]. To avoid race
	 * conditions, you should wait for an [`Event::PaymentClaimed`] before considering the payment
	 * successful. It will generally be available in the next [`process_pending_events`] call.
	 * 
	 * Note that if you did not set an `amount_msat` when calling [`create_inbound_payment`] or
	 * [`create_inbound_payment_for_hash`] you must check that the amount in the `PaymentClaimable`
	 * event matches your expectation. If you fail to do so and call this method, you may provide
	 * the sender \"proof-of-payment\" when they did not fulfill the full expected payment.
	 * 
	 * This function will fail the payment if it has custom TLVs with even type numbers, as we
	 * will assume they are unknown. If you intend to accept even custom TLVs, you should use
	 * [`claim_funds_with_known_custom_tlvs`].
	 * 
	 * [`Event::PaymentClaimable`]: crate::events::Event::PaymentClaimable
	 * [`Event::PaymentClaimable::claim_deadline`]: crate::events::Event::PaymentClaimable::claim_deadline
	 * [`Event::PaymentClaimed`]: crate::events::Event::PaymentClaimed
	 * [`process_pending_events`]: EventsProvider::process_pending_events
	 * [`create_inbound_payment`]: Self::create_inbound_payment
	 * [`create_inbound_payment_for_hash`]: Self::create_inbound_payment_for_hash
	 * [`claim_funds_with_known_custom_tlvs`]: Self::claim_funds_with_known_custom_tlvs
	 */
	public claim_funds(payment_preimage: Uint8Array): void {
		bindings.ChannelManager_claim_funds(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_preimage, 32)));
	}

	/**
	 * This is a variant of [`claim_funds`] that allows accepting a payment with custom TLVs with
	 * even type numbers.
	 * 
	 * # Note
	 * 
	 * You MUST check you've understood all even TLVs before using this to
	 * claim, otherwise you may unintentionally agree to some protocol you do not understand.
	 * 
	 * [`claim_funds`]: Self::claim_funds
	 */
	public claim_funds_with_known_custom_tlvs(payment_preimage: Uint8Array): void {
		bindings.ChannelManager_claim_funds_with_known_custom_tlvs(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_preimage, 32)));
	}

	/**
	 * Gets the node_id held by this ChannelManager
	 */
	public get_our_node_id(): Uint8Array {
		const ret: number = bindings.ChannelManager_get_our_node_id(this.ptr);
		const ret_conv: Uint8Array = bindings.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Accepts a request to open a channel after a [`Event::OpenChannelRequest`].
	 * 
	 * The `temporary_channel_id` parameter indicates which inbound channel should be accepted,
	 * and the `counterparty_node_id` parameter is the id of the peer which has requested to open
	 * the channel.
	 * 
	 * The `user_channel_id` parameter will be provided back in
	 * [`Event::ChannelClosed::user_channel_id`] to allow tracking of which events correspond
	 * with which `accept_inbound_channel`/`accept_inbound_channel_from_trusted_peer_0conf` call.
	 * 
	 * Note that this method will return an error and reject the channel, if it requires support
	 * for zero confirmations. Instead, `accept_inbound_channel_from_trusted_peer_0conf` must be
	 * used to accept such channels.
	 * 
	 * [`Event::OpenChannelRequest`]: events::Event::OpenChannelRequest
	 * [`Event::ChannelClosed::user_channel_id`]: events::Event::ChannelClosed::user_channel_id
	 */
	public accept_inbound_channel(temporary_channel_id: ChannelId, counterparty_node_id: Uint8Array, user_channel_id: bigint): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_accept_inbound_channel(this.ptr, CommonBase.get_ptr_of(temporary_channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), bindings.encodeUint128(user_channel_id));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, temporary_channel_id);
		return ret_hu_conv;
	}

	/**
	 * Accepts a request to open a channel after a [`events::Event::OpenChannelRequest`], treating
	 * it as confirmed immediately.
	 * 
	 * The `user_channel_id` parameter will be provided back in
	 * [`Event::ChannelClosed::user_channel_id`] to allow tracking of which events correspond
	 * with which `accept_inbound_channel`/`accept_inbound_channel_from_trusted_peer_0conf` call.
	 * 
	 * Unlike [`ChannelManager::accept_inbound_channel`], this method accepts the incoming channel
	 * and (if the counterparty agrees), enables forwarding of payments immediately.
	 * 
	 * This fully trusts that the counterparty has honestly and correctly constructed the funding
	 * transaction and blindly assumes that it will eventually confirm.
	 * 
	 * If it does not confirm before we decide to close the channel, or if the funding transaction
	 * does not pay to the correct script the correct amount, *you will lose funds*.
	 * 
	 * [`Event::OpenChannelRequest`]: events::Event::OpenChannelRequest
	 * [`Event::ChannelClosed::user_channel_id`]: events::Event::ChannelClosed::user_channel_id
	 */
	public accept_inbound_channel_from_trusted_peer_0conf(temporary_channel_id: ChannelId, counterparty_node_id: Uint8Array, user_channel_id: bigint): Result_NoneAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_accept_inbound_channel_from_trusted_peer_0conf(this.ptr, CommonBase.get_ptr_of(temporary_channel_id), bindings.encodeUint8Array(bindings.check_arr_len(counterparty_node_id, 33)), bindings.encodeUint128(user_channel_id));
		const ret_hu_conv: Result_NoneAPIErrorZ = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, temporary_channel_id);
		return ret_hu_conv;
	}

	/**
	 * Creates an [`OfferBuilder`] such that the [`Offer`] it builds is recognized by the
	 * [`ChannelManager`] when handling [`InvoiceRequest`] messages for the offer. The offer's
	 * expiration will be `absolute_expiry` if `Some`, otherwise it will not expire.
	 * 
	 * # Privacy
	 * 
	 * Uses [`MessageRouter`] to construct a [`BlindedMessagePath`] for the offer based on the given
	 * `absolute_expiry` according to [`MAX_SHORT_LIVED_RELATIVE_EXPIRY`]. See those docs for
	 * privacy implications as well as those of the parameterized [`Router`], which implements
	 * [`MessageRouter`].
	 * 
	 * Also, uses a derived signing pubkey in the offer for recipient privacy.
	 * 
	 * # Limitations
	 * 
	 * Requires a direct connection to the introduction node in the responding [`InvoiceRequest`]'s
	 * reply path.
	 * 
	 * # Errors
	 * 
	 * Errors if the parameterized [`Router`] is unable to create a blinded path for the offer.
	 * 
	 * [`Offer`]: crate::offers::offer::Offer
	 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
	 */
	public create_offer_builder(absolute_expiry: Option_u64Z): Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ {
		const ret: bigint = bindings.ChannelManager_create_offer_builder(this.ptr, CommonBase.get_ptr_of(absolute_expiry));
		const ret_hu_conv: Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ = Result_OfferWithDerivedMetadataBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a [`RefundBuilder`] such that the [`Refund`] it builds is recognized by the
	 * [`ChannelManager`] when handling [`Bolt12Invoice`] messages for the refund.
	 * 
	 * # Payment
	 * 
	 * The provided `payment_id` is used to ensure that only one invoice is paid for the refund.
	 * See [Avoiding Duplicate Payments] for other requirements once the payment has been sent.
	 * 
	 * The builder will have the provided expiration set. Any changes to the expiration on the
	 * returned builder will not be honored by [`ChannelManager`]. For `no-std`, the highest seen
	 * block time minus two hours is used for the current time when determining if the refund has
	 * expired.
	 * 
	 * To revoke the refund, use [`ChannelManager::abandon_payment`] prior to receiving the
	 * invoice. If abandoned, or an invoice isn't received before expiration, the payment will fail
	 * with an [`Event::PaymentFailed`].
	 * 
	 * If `max_total_routing_fee_msat` is not specified, The default from
	 * [`RouteParameters::from_payment_params_and_value`] is applied.
	 * 
	 * # Privacy
	 * 
	 * Uses [`MessageRouter`] to construct a [`BlindedMessagePath`] for the refund based on the given
	 * `absolute_expiry` according to [`MAX_SHORT_LIVED_RELATIVE_EXPIRY`]. See those docs for
	 * privacy implications as well as those of the parameterized [`Router`], which implements
	 * [`MessageRouter`].
	 * 
	 * Also, uses a derived payer id in the refund for payer privacy.
	 * 
	 * # Limitations
	 * 
	 * Requires a direct connection to an introduction node in the responding
	 * [`Bolt12Invoice::payment_paths`].
	 * 
	 * # Errors
	 * 
	 * Errors if:
	 * - a duplicate `payment_id` is provided given the caveats in the aforementioned link,
	 * - `amount_msats` is invalid, or
	 * - the parameterized [`Router`] is unable to create a blinded path for the refund.
	 * 
	 * [`Refund`]: crate::offers::refund::Refund
	 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
	 * [`Bolt12Invoice::payment_paths`]: crate::offers::invoice::Bolt12Invoice::payment_paths
	 * [Avoiding Duplicate Payments]: #avoiding-duplicate-payments
	 */
	public create_refund_builder(amount_msats: bigint, absolute_expiry: bigint, payment_id: Uint8Array, retry_strategy: Retry, max_total_routing_fee_msat: Option_u64Z): Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ {
		const ret: bigint = bindings.ChannelManager_create_refund_builder(this.ptr, amount_msats, absolute_expiry, bindings.encodeUint8Array(bindings.check_arr_len(payment_id, 32)), CommonBase.get_ptr_of(retry_strategy), CommonBase.get_ptr_of(max_total_routing_fee_msat));
		const ret_hu_conv: Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ = Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Pays for an [`Offer`] using the given parameters by creating an [`InvoiceRequest`] and
	 * enqueuing it to be sent via an onion message. [`ChannelManager`] will pay the actual
	 * [`Bolt12Invoice`] once it is received.
	 * 
	 * Uses [`InvoiceRequestBuilder`] such that the [`InvoiceRequest`] it builds is recognized by
	 * the [`ChannelManager`] when handling a [`Bolt12Invoice`] message in response to the request.
	 * The optional parameters are used in the builder, if `Some`:
	 * - `quantity` for [`InvoiceRequest::quantity`] which must be set if
	 * [`Offer::expects_quantity`] is `true`.
	 * - `amount_msats` if overpaying what is required for the given `quantity` is desired, and
	 * - `payer_note` for [`InvoiceRequest::payer_note`].
	 * 
	 * If `max_total_routing_fee_msat` is not specified, The default from
	 * [`RouteParameters::from_payment_params_and_value`] is applied.
	 * 
	 * # Payment
	 * 
	 * The provided `payment_id` is used to ensure that only one invoice is paid for the request
	 * when received. See [Avoiding Duplicate Payments] for other requirements once the payment has
	 * been sent.
	 * 
	 * To revoke the request, use [`ChannelManager::abandon_payment`] prior to receiving the
	 * invoice. If abandoned, or an invoice isn't received in a reasonable amount of time, the
	 * payment will fail with an [`Event::PaymentFailed`].
	 * 
	 * # Privacy
	 * 
	 * For payer privacy, uses a derived payer id and uses [`MessageRouter::create_blinded_paths`]
	 * to construct a [`BlindedMessagePath`] for the reply path. For further privacy implications, see the
	 * docs of the parameterized [`Router`], which implements [`MessageRouter`].
	 * 
	 * # Limitations
	 * 
	 * Requires a direct connection to an introduction node in [`Offer::paths`] or to
	 * [`Offer::signing_pubkey`], if empty. A similar restriction applies to the responding
	 * [`Bolt12Invoice::payment_paths`].
	 * 
	 * # Errors
	 * 
	 * Errors if:
	 * - a duplicate `payment_id` is provided given the caveats in the aforementioned link,
	 * - the provided parameters are invalid for the offer,
	 * - the offer is for an unsupported chain, or
	 * - the parameterized [`Router`] is unable to create a blinded reply path for the invoice
	 * request.
	 * 
	 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
	 * [`InvoiceRequest::quantity`]: crate::offers::invoice_request::InvoiceRequest::quantity
	 * [`InvoiceRequest::payer_note`]: crate::offers::invoice_request::InvoiceRequest::payer_note
	 * [`InvoiceRequestBuilder`]: crate::offers::invoice_request::InvoiceRequestBuilder
	 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
	 * [`Bolt12Invoice::payment_paths`]: crate::offers::invoice::Bolt12Invoice::payment_paths
	 * [Avoiding Duplicate Payments]: #avoiding-duplicate-payments
	 */
	public pay_for_offer(offer: Offer, quantity: Option_u64Z, amount_msats: Option_u64Z, payer_note: Option_StrZ, payment_id: Uint8Array, retry_strategy: Retry, max_total_routing_fee_msat: Option_u64Z): Result_NoneBolt12SemanticErrorZ {
		const ret: bigint = bindings.ChannelManager_pay_for_offer(this.ptr, CommonBase.get_ptr_of(offer), CommonBase.get_ptr_of(quantity), CommonBase.get_ptr_of(amount_msats), CommonBase.get_ptr_of(payer_note), bindings.encodeUint8Array(bindings.check_arr_len(payment_id, 32)), CommonBase.get_ptr_of(retry_strategy), CommonBase.get_ptr_of(max_total_routing_fee_msat));
		const ret_hu_conv: Result_NoneBolt12SemanticErrorZ = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, offer);
		return ret_hu_conv;
	}

	/**
	 * Creates a [`Bolt12Invoice`] for a [`Refund`] and enqueues it to be sent via an onion
	 * message.
	 * 
	 * The resulting invoice uses a [`PaymentHash`] recognized by the [`ChannelManager`] and a
	 * [`BlindedPaymentPath`] containing the [`PaymentSecret`] needed to reconstruct the
	 * corresponding [`PaymentPreimage`]. It is returned purely for informational purposes.
	 * 
	 * # Limitations
	 * 
	 * Requires a direct connection to an introduction node in [`Refund::paths`] or to
	 * [`Refund::payer_id`], if empty. This request is best effort; an invoice will be sent to each
	 * node meeting the aforementioned criteria, but there's no guarantee that they will be
	 * received and no retries will be made.
	 * 
	 * # Errors
	 * 
	 * Errors if:
	 * - the refund is for an unsupported chain, or
	 * - the parameterized [`Router`] is unable to create a blinded payment path or reply path for
	 * the invoice.
	 * 
	 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
	 */
	public request_refund_payment(refund: Refund): Result_Bolt12InvoiceBolt12SemanticErrorZ {
		const ret: bigint = bindings.ChannelManager_request_refund_payment(this.ptr, CommonBase.get_ptr_of(refund));
		const ret_hu_conv: Result_Bolt12InvoiceBolt12SemanticErrorZ = Result_Bolt12InvoiceBolt12SemanticErrorZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, refund);
		return ret_hu_conv;
	}

	/**
	 * Gets a payment secret and payment hash for use in an invoice given to a third party wishing
	 * to pay us.
	 * 
	 * This differs from [`create_inbound_payment_for_hash`] only in that it generates the
	 * [`PaymentHash`] and [`PaymentPreimage`] for you.
	 * 
	 * The [`PaymentPreimage`] will ultimately be returned to you in the [`PaymentClaimable`] event, which
	 * will have the [`PaymentClaimable::purpose`] return `Some` for [`PaymentPurpose::preimage`]. That
	 * should then be passed directly to [`claim_funds`].
	 * 
	 * See [`create_inbound_payment_for_hash`] for detailed documentation on behavior and requirements.
	 * 
	 * Note that a malicious eavesdropper can intuit whether an inbound payment was created by
	 * `create_inbound_payment` or `create_inbound_payment_for_hash` based on runtime.
	 * 
	 * # Note
	 * 
	 * If you register an inbound payment with this method, then serialize the `ChannelManager`, then
	 * deserialize it with a node running 0.0.103 and earlier, the payment will fail to be received.
	 * 
	 * Errors if `min_value_msat` is greater than total bitcoin supply.
	 * 
	 * If `min_final_cltv_expiry_delta` is set to some value, then the payment will not be receivable
	 * on versions of LDK prior to 0.0.114.
	 * 
	 * [`claim_funds`]: Self::claim_funds
	 * [`PaymentClaimable`]: events::Event::PaymentClaimable
	 * [`PaymentClaimable::purpose`]: events::Event::PaymentClaimable::purpose
	 * [`PaymentPurpose::preimage`]: events::PaymentPurpose::preimage
	 * [`create_inbound_payment_for_hash`]: Self::create_inbound_payment_for_hash
	 */
	public create_inbound_payment(min_value_msat: Option_u64Z, invoice_expiry_delta_secs: number, min_final_cltv_expiry_delta: Option_u16Z): Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ {
		const ret: bigint = bindings.ChannelManager_create_inbound_payment(this.ptr, CommonBase.get_ptr_of(min_value_msat), invoice_expiry_delta_secs, CommonBase.get_ptr_of(min_final_cltv_expiry_delta));
		const ret_hu_conv: Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Gets a [`PaymentSecret`] for a given [`PaymentHash`], for which the payment preimage is
	 * stored external to LDK.
	 * 
	 * A [`PaymentClaimable`] event will only be generated if the [`PaymentSecret`] matches a
	 * payment secret fetched via this method or [`create_inbound_payment`], and which is at least
	 * the `min_value_msat` provided here, if one is provided.
	 * 
	 * The [`PaymentHash`] (and corresponding [`PaymentPreimage`]) should be globally unique, though
	 * note that LDK will not stop you from registering duplicate payment hashes for inbound
	 * payments.
	 * 
	 * `min_value_msat` should be set if the invoice being generated contains a value. Any payment
	 * received for the returned [`PaymentHash`] will be required to be at least `min_value_msat`
	 * before a [`PaymentClaimable`] event will be generated, ensuring that we do not provide the
	 * sender \"proof-of-payment\" unless they have paid the required amount.
	 * 
	 * `invoice_expiry_delta_secs` describes the number of seconds that the invoice is valid for
	 * in excess of the current time. This should roughly match the expiry time set in the invoice.
	 * After this many seconds, we will remove the inbound payment, resulting in any attempts to
	 * pay the invoice failing. The BOLT spec suggests 3,600 secs as a default validity time for
	 * invoices when no timeout is set.
	 * 
	 * Note that we use block header time to time-out pending inbound payments (with some margin
	 * to compensate for the inaccuracy of block header timestamps). Thus, in practice we will
	 * accept a payment and generate a [`PaymentClaimable`] event for some time after the expiry.
	 * If you need exact expiry semantics, you should enforce them upon receipt of
	 * [`PaymentClaimable`].
	 * 
	 * Note that invoices generated for inbound payments should have their `min_final_cltv_expiry_delta`
	 * set to at least [`MIN_FINAL_CLTV_EXPIRY_DELTA`].
	 * 
	 * Note that a malicious eavesdropper can intuit whether an inbound payment was created by
	 * `create_inbound_payment` or `create_inbound_payment_for_hash` based on runtime.
	 * 
	 * # Note
	 * 
	 * If you register an inbound payment with this method, then serialize the `ChannelManager`, then
	 * deserialize it with a node running 0.0.103 and earlier, the payment will fail to be received.
	 * 
	 * Errors if `min_value_msat` is greater than total bitcoin supply.
	 * 
	 * If `min_final_cltv_expiry_delta` is set to some value, then the payment will not be receivable
	 * on versions of LDK prior to 0.0.114.
	 * 
	 * [`create_inbound_payment`]: Self::create_inbound_payment
	 * [`PaymentClaimable`]: events::Event::PaymentClaimable
	 */
	public create_inbound_payment_for_hash(payment_hash: Uint8Array, min_value_msat: Option_u64Z, invoice_expiry_delta_secs: number, min_final_cltv_expiry: Option_u16Z): Result_ThirtyTwoBytesNoneZ {
		const ret: bigint = bindings.ChannelManager_create_inbound_payment_for_hash(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_hash, 32)), CommonBase.get_ptr_of(min_value_msat), invoice_expiry_delta_secs, CommonBase.get_ptr_of(min_final_cltv_expiry));
		const ret_hu_conv: Result_ThirtyTwoBytesNoneZ = Result_ThirtyTwoBytesNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Gets an LDK-generated payment preimage from a payment hash and payment secret that were
	 * previously returned from [`create_inbound_payment`].
	 * 
	 * [`create_inbound_payment`]: Self::create_inbound_payment
	 */
	public get_payment_preimage(payment_hash: Uint8Array, payment_secret: Uint8Array): Result_ThirtyTwoBytesAPIErrorZ {
		const ret: bigint = bindings.ChannelManager_get_payment_preimage(this.ptr, bindings.encodeUint8Array(bindings.check_arr_len(payment_hash, 32)), bindings.encodeUint8Array(bindings.check_arr_len(payment_secret, 32)));
		const ret_hu_conv: Result_ThirtyTwoBytesAPIErrorZ = Result_ThirtyTwoBytesAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Gets a fake short channel id for use in receiving [phantom node payments]. These fake scids
	 * are used when constructing the phantom invoice's route hints.
	 * 
	 * [phantom node payments]: crate::sign::PhantomKeysManager
	 */
	public get_phantom_scid(): bigint {
		const ret: bigint = bindings.ChannelManager_get_phantom_scid(this.ptr);
		return ret;
	}

	/**
	 * Gets route hints for use in receiving [phantom node payments].
	 * 
	 * [phantom node payments]: crate::sign::PhantomKeysManager
	 */
	public get_phantom_route_hints(): PhantomRouteHints {
		const ret: bigint = bindings.ChannelManager_get_phantom_route_hints(this.ptr);
		const ret_hu_conv: PhantomRouteHints = new PhantomRouteHints(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Gets a fake short channel id for use in receiving intercepted payments. These fake scids are
	 * used when constructing the route hints for HTLCs intended to be intercepted. See
	 * [`ChannelManager::forward_intercepted_htlc`].
	 * 
	 * Note that this method is not guaranteed to return unique values, you may need to call it a few
	 * times to get a unique scid.
	 */
	public get_intercept_scid(): bigint {
		const ret: bigint = bindings.ChannelManager_get_intercept_scid(this.ptr);
		return ret;
	}

	/**
	 * Gets inflight HTLC information by processing pending outbound payments that are in
	 * our channels. May be used during pathfinding to account for in-use channel liquidity.
	 */
	public compute_inflight_htlcs(): InFlightHtlcs {
		const ret: bigint = bindings.ChannelManager_compute_inflight_htlcs(this.ptr);
		const ret_hu_conv: InFlightHtlcs = new InFlightHtlcs(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new MessageSendEventsProvider which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned MessageSendEventsProvider must be freed before this_arg is
	 */
	public as_MessageSendEventsProvider(): MessageSendEventsProvider {
		const ret: bigint = bindings.ChannelManager_as_MessageSendEventsProvider(this.ptr);
		const ret_hu_conv: MessageSendEventsProvider = new MessageSendEventsProvider(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new EventsProvider which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned EventsProvider must be freed before this_arg is
	 */
	public as_EventsProvider(): EventsProvider {
		const ret: bigint = bindings.ChannelManager_as_EventsProvider(this.ptr);
		const ret_hu_conv: EventsProvider = new EventsProvider(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new Listen which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned Listen must be freed before this_arg is
	 */
	public as_Listen(): Listen {
		const ret: bigint = bindings.ChannelManager_as_Listen(this.ptr);
		const ret_hu_conv: Listen = new Listen(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new Confirm which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned Confirm must be freed before this_arg is
	 */
	public as_Confirm(): Confirm {
		const ret: bigint = bindings.ChannelManager_as_Confirm(this.ptr);
		const ret_hu_conv: Confirm = new Confirm(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Gets a [`Future`] that completes when this [`ChannelManager`] may need to be persisted or
	 * may have events that need processing.
	 * 
	 * In order to check if this [`ChannelManager`] needs persisting, call
	 * [`Self::get_and_clear_needs_persistence`].
	 * 
	 * Note that callbacks registered on the [`Future`] MUST NOT call back into this
	 * [`ChannelManager`] and should instead register actions to be taken later.
	 */
	public get_event_or_persistence_needed_future(): Future {
		const ret: bigint = bindings.ChannelManager_get_event_or_persistence_needed_future(this.ptr);
		const ret_hu_conv: Future = new Future(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Returns true if this [`ChannelManager`] needs to be persisted.
	 * 
	 * See [`Self::get_event_or_persistence_needed_future`] for retrieving a [`Future`] that
	 * indicates this should be checked.
	 */
	public get_and_clear_needs_persistence(): boolean {
		const ret: boolean = bindings.ChannelManager_get_and_clear_needs_persistence(this.ptr);
		return ret;
	}

	/**
	 * Gets the latest best block which was connected either via the [`chain::Listen`] or
	 * [`chain::Confirm`] interfaces.
	 */
	public current_best_block(): BestBlock {
		const ret: bigint = bindings.ChannelManager_current_best_block(this.ptr);
		const ret_hu_conv: BestBlock = new BestBlock(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Fetches the set of [`NodeFeatures`] flags that are provided by or required by
	 * [`ChannelManager`].
	 */
	public node_features(): NodeFeatures {
		const ret: bigint = bindings.ChannelManager_node_features(this.ptr);
		const ret_hu_conv: NodeFeatures = new NodeFeatures(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Fetches the set of [`ChannelFeatures`] flags that are provided by or required by
	 * [`ChannelManager`].
	 */
	public channel_features(): ChannelFeatures {
		const ret: bigint = bindings.ChannelManager_channel_features(this.ptr);
		const ret_hu_conv: ChannelFeatures = new ChannelFeatures(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Fetches the set of [`ChannelTypeFeatures`] flags that are provided by or required by
	 * [`ChannelManager`].
	 */
	public channel_type_features(): ChannelTypeFeatures {
		const ret: bigint = bindings.ChannelManager_channel_type_features(this.ptr);
		const ret_hu_conv: ChannelTypeFeatures = new ChannelTypeFeatures(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Fetches the set of [`InitFeatures`] flags that are provided by or required by
	 * [`ChannelManager`].
	 */
	public init_features(): InitFeatures {
		const ret: bigint = bindings.ChannelManager_init_features(this.ptr);
		const ret_hu_conv: InitFeatures = new InitFeatures(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new ChannelMessageHandler which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned ChannelMessageHandler must be freed before this_arg is
	 */
	public as_ChannelMessageHandler(): ChannelMessageHandler {
		const ret: bigint = bindings.ChannelManager_as_ChannelMessageHandler(this.ptr);
		const ret_hu_conv: ChannelMessageHandler = new ChannelMessageHandler(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new OffersMessageHandler which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned OffersMessageHandler must be freed before this_arg is
	 */
	public as_OffersMessageHandler(): OffersMessageHandler {
		const ret: bigint = bindings.ChannelManager_as_OffersMessageHandler(this.ptr);
		const ret_hu_conv: OffersMessageHandler = new OffersMessageHandler(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new AsyncPaymentsMessageHandler which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned AsyncPaymentsMessageHandler must be freed before this_arg is
	 */
	public as_AsyncPaymentsMessageHandler(): AsyncPaymentsMessageHandler {
		const ret: bigint = bindings.ChannelManager_as_AsyncPaymentsMessageHandler(this.ptr);
		const ret_hu_conv: AsyncPaymentsMessageHandler = new AsyncPaymentsMessageHandler(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Constructs a new NodeIdLookUp which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned NodeIdLookUp must be freed before this_arg is
	 */
	public as_NodeIdLookUp(): NodeIdLookUp {
		const ret: bigint = bindings.ChannelManager_as_NodeIdLookUp(this.ptr);
		const ret_hu_conv: NodeIdLookUp = new NodeIdLookUp(null, ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Serialize the ChannelManager object into a byte array which can be read by ChannelManager_read
	 */
	public write(): Uint8Array {
		const ret: number = bindings.ChannelManager_write(this.ptr);
		const ret_conv: Uint8Array = bindings.decodeUint8Array(ret);
		return ret_conv;
	}

}
