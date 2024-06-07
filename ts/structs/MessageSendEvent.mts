import { TxOut } from '../structs/TxOut.mjs';
import { TxIn } from '../structs/TxIn.mjs';
import { BigEndianScalar } from '../structs/BigEndianScalar.mjs';
import { WitnessProgram } from '../structs/WitnessProgram.mjs';
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
import { BlindedPath } from '../structs/BlindedPath.mjs';
import { Bolt12ParseError } from '../structs/Bolt12ParseError.mjs';
import { Result_RefundBolt12ParseErrorZ } from '../structs/Result_RefundBolt12ParseErrorZ.mjs';
import { Retry } from '../structs/Retry.mjs';
import { DecodeError } from '../structs/DecodeError.mjs';
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
import { BlindedPayInfo } from '../structs/BlindedPayInfo.mjs';
import { Result_BlindedPayInfoDecodeErrorZ } from '../structs/Result_BlindedPayInfoDecodeErrorZ.mjs';
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
import { Result_NoneNoneZ } from '../structs/Result_NoneNoneZ.mjs';
import { Result_PublicKeyNoneZ } from '../structs/Result_PublicKeyNoneZ.mjs';
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
import { WriteableEcdsaChannelSigner, WriteableEcdsaChannelSignerInterface } from '../structs/WriteableEcdsaChannelSigner.mjs';
import { Result_WriteableEcdsaChannelSignerDecodeErrorZ } from '../structs/Result_WriteableEcdsaChannelSignerDecodeErrorZ.mjs';
import { Result_CVec_u8ZNoneZ } from '../structs/Result_CVec_u8ZNoneZ.mjs';
import { Result_ShutdownScriptNoneZ } from '../structs/Result_ShutdownScriptNoneZ.mjs';
import { Option_u16Z } from '../structs/Option_u16Z.mjs';
import { Option_boolZ } from '../structs/Option_boolZ.mjs';
import { Result_WitnessNoneZ } from '../structs/Result_WitnessNoneZ.mjs';
import { InMemorySigner } from '../structs/InMemorySigner.mjs';
import { Result_InMemorySignerDecodeErrorZ } from '../structs/Result_InMemorySignerDecodeErrorZ.mjs';
import { ChannelDetails } from '../structs/ChannelDetails.mjs';
import { Route } from '../structs/Route.mjs';
import { LightningError } from '../structs/LightningError.mjs';
import { Result_RouteLightningErrorZ } from '../structs/Result_RouteLightningErrorZ.mjs';
import { TwoTuple_BlindedPayInfoBlindedPathZ } from '../structs/TwoTuple_BlindedPayInfoBlindedPathZ.mjs';
import { Result_CVec_C2Tuple_BlindedPayInfoBlindedPathZZNoneZ } from '../structs/Result_CVec_C2Tuple_BlindedPayInfoBlindedPathZZNoneZ.mjs';
import { OnionMessagePath } from '../structs/OnionMessagePath.mjs';
import { Result_OnionMessagePathNoneZ } from '../structs/Result_OnionMessagePathNoneZ.mjs';
import { Result_CVec_BlindedPathZNoneZ } from '../structs/Result_CVec_BlindedPathZNoneZ.mjs';
import { InFlightHtlcs } from '../structs/InFlightHtlcs.mjs';
import { Result_InFlightHtlcsDecodeErrorZ } from '../structs/Result_InFlightHtlcsDecodeErrorZ.mjs';
import { RouteHop } from '../structs/RouteHop.mjs';
import { Result_RouteHopDecodeErrorZ } from '../structs/Result_RouteHopDecodeErrorZ.mjs';
import { BlindedHop } from '../structs/BlindedHop.mjs';
import { BlindedTail } from '../structs/BlindedTail.mjs';
import { Result_BlindedTailDecodeErrorZ } from '../structs/Result_BlindedTailDecodeErrorZ.mjs';
import { Path } from '../structs/Path.mjs';
import { Result_RouteDecodeErrorZ } from '../structs/Result_RouteDecodeErrorZ.mjs';
import { RouteParameters } from '../structs/RouteParameters.mjs';
import { Result_RouteParametersDecodeErrorZ } from '../structs/Result_RouteParametersDecodeErrorZ.mjs';
import { PaymentParameters } from '../structs/PaymentParameters.mjs';
import { Result_PaymentParametersDecodeErrorZ } from '../structs/Result_PaymentParametersDecodeErrorZ.mjs';
import { RouteHint } from '../structs/RouteHint.mjs';
import { RouteHintHop } from '../structs/RouteHintHop.mjs';
import { Result_RouteHintDecodeErrorZ } from '../structs/Result_RouteHintDecodeErrorZ.mjs';
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
import { Result_OfferBolt12ParseErrorZ } from '../structs/Result_OfferBolt12ParseErrorZ.mjs';
import { Result_NodeIdDecodeErrorZ } from '../structs/Result_NodeIdDecodeErrorZ.mjs';
import { Result_PublicKeySecp256k1ErrorZ } from '../structs/Result_PublicKeySecp256k1ErrorZ.mjs';
import { ChannelUpdate } from '../structs/ChannelUpdate.mjs';
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
import { ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ } from '../structs/ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ.mjs';
import { Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ } from '../structs/Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ.mjs';
import { AcceptChannel } from '../structs/AcceptChannel.mjs';
import { AcceptChannelV2 } from '../structs/AcceptChannelV2.mjs';
import { OpenChannel } from '../structs/OpenChannel.mjs';
import { OpenChannelV2 } from '../structs/OpenChannelV2.mjs';
import { FundingCreated } from '../structs/FundingCreated.mjs';
import { FundingSigned } from '../structs/FundingSigned.mjs';
import { Stfu } from '../structs/Stfu.mjs';
import { Splice } from '../structs/Splice.mjs';
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
import { ChannelUpdateInfo } from '../structs/ChannelUpdateInfo.mjs';
import { Result_ChannelUpdateInfoDecodeErrorZ } from '../structs/Result_ChannelUpdateInfoDecodeErrorZ.mjs';
import { ChannelInfo } from '../structs/ChannelInfo.mjs';
import { Result_ChannelInfoDecodeErrorZ } from '../structs/Result_ChannelInfoDecodeErrorZ.mjs';
import { RoutingFees } from '../structs/RoutingFees.mjs';
import { Result_RoutingFeesDecodeErrorZ } from '../structs/Result_RoutingFeesDecodeErrorZ.mjs';
import { Hostname } from '../structs/Hostname.mjs';
import { SocketAddress } from '../structs/SocketAddress.mjs';
import { NodeAnnouncementInfo } from '../structs/NodeAnnouncementInfo.mjs';
import { Result_NodeAnnouncementInfoDecodeErrorZ } from '../structs/Result_NodeAnnouncementInfoDecodeErrorZ.mjs';
import { NodeAlias } from '../structs/NodeAlias.mjs';
import { Result_NodeAliasDecodeErrorZ } from '../structs/Result_NodeAliasDecodeErrorZ.mjs';
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
import { InvoiceRequest } from '../structs/InvoiceRequest.mjs';
import { InvoiceError } from '../structs/InvoiceError.mjs';
import { OffersMessage } from '../structs/OffersMessage.mjs';
import { Option_OffersMessageZ } from '../structs/Option_OffersMessageZ.mjs';
import { Destination } from '../structs/Destination.mjs';
import { ThreeTuple_OffersMessageDestinationBlindedPathZ } from '../structs/ThreeTuple_OffersMessageDestinationBlindedPathZ.mjs';
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
import { ChannelManager } from '../structs/ChannelManager.mjs';
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
import { TwoTuple_u32TxOutZ } from '../structs/TwoTuple_u32TxOutZ.mjs';
import { TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ } from '../structs/TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ.mjs';
import { Balance } from '../structs/Balance.mjs';
import { TwoTuple_ThirtyTwoBytesChannelMonitorZ } from '../structs/TwoTuple_ThirtyTwoBytesChannelMonitorZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.mjs';
import { Type, TypeInterface } from '../structs/Type.mjs';
import { TwoTuple_PublicKeyTypeZ } from '../structs/TwoTuple_PublicKeyTypeZ.mjs';
import { TwoTuple_PublicKeyCVec_SocketAddressZZ } from '../structs/TwoTuple_PublicKeyCVec_SocketAddressZZ.mjs';
import { OnionMessageContents, OnionMessageContentsInterface } from '../structs/OnionMessageContents.mjs';
import { Option_OnionMessageContentsZ } from '../structs/Option_OnionMessageContentsZ.mjs';
import { Result_COption_OnionMessageContentsZDecodeErrorZ } from '../structs/Result_COption_OnionMessageContentsZDecodeErrorZ.mjs';
import { ThreeTuple_OnionMessageContentsDestinationBlindedPathZ } from '../structs/ThreeTuple_OnionMessageContentsDestinationBlindedPathZ.mjs';
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
import { Option_SecretKeyZ } from '../structs/Option_SecretKeyZ.mjs';
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
import { Result_SpliceDecodeErrorZ } from '../structs/Result_SpliceDecodeErrorZ.mjs';
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
import { Bolt11Invoice } from '../structs/Bolt11Invoice.mjs';
import { SignOrCreationError } from '../structs/SignOrCreationError.mjs';
import { Result_Bolt11InvoiceSignOrCreationErrorZ } from '../structs/Result_Bolt11InvoiceSignOrCreationErrorZ.mjs';
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
import { Result_PaymentFailureReasonDecodeErrorZ } from '../structs/Result_PaymentFailureReasonDecodeErrorZ.mjs';
import { Option_U128Z } from '../structs/Option_U128Z.mjs';
import { Option_PaymentFailureReasonZ } from '../structs/Option_PaymentFailureReasonZ.mjs';
import { AnchorDescriptor } from '../structs/AnchorDescriptor.mjs';
import { BumpTransactionEvent } from '../structs/BumpTransactionEvent.mjs';
import { Event } from '../structs/Event.mjs';
import { Option_EventZ } from '../structs/Option_EventZ.mjs';
import { Result_COption_EventZDecodeErrorZ } from '../structs/Result_COption_EventZDecodeErrorZ.mjs';
import { Bolt11ParseError } from '../structs/Bolt11ParseError.mjs';
import { Result_SiPrefixBolt11ParseErrorZ } from '../structs/Result_SiPrefixBolt11ParseErrorZ.mjs';
import { ParseOrSemanticError } from '../structs/ParseOrSemanticError.mjs';
import { Result_Bolt11InvoiceParseOrSemanticErrorZ } from '../structs/Result_Bolt11InvoiceParseOrSemanticErrorZ.mjs';
import { SignedRawBolt11Invoice } from '../structs/SignedRawBolt11Invoice.mjs';
import { Result_SignedRawBolt11InvoiceBolt11ParseErrorZ } from '../structs/Result_SignedRawBolt11InvoiceBolt11ParseErrorZ.mjs';
import { RawBolt11Invoice } from '../structs/RawBolt11Invoice.mjs';
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
import { Result_HostnameDecodeErrorZ } from '../structs/Result_HostnameDecodeErrorZ.mjs';
import { TransactionU16LenLimited } from '../structs/TransactionU16LenLimited.mjs';
import { Result_TransactionU16LenLimitedNoneZ } from '../structs/Result_TransactionU16LenLimitedNoneZ.mjs';
import { Result_TransactionU16LenLimitedDecodeErrorZ } from '../structs/Result_TransactionU16LenLimitedDecodeErrorZ.mjs';
import { Result_UntrustedStringDecodeErrorZ } from '../structs/Result_UntrustedStringDecodeErrorZ.mjs';
import { Result_ChannelIdDecodeErrorZ } from '../structs/Result_ChannelIdDecodeErrorZ.mjs';
import { TwoTuple__u832u16Z } from '../structs/TwoTuple__u832u16Z.mjs';
import { PaymentRelay } from '../structs/PaymentRelay.mjs';
import { Result_PaymentRelayDecodeErrorZ } from '../structs/Result_PaymentRelayDecodeErrorZ.mjs';
import { PaymentConstraints } from '../structs/PaymentConstraints.mjs';
import { Result_PaymentConstraintsDecodeErrorZ } from '../structs/Result_PaymentConstraintsDecodeErrorZ.mjs';
import { Result_PaymentContextDecodeErrorZ } from '../structs/Result_PaymentContextDecodeErrorZ.mjs';
import { Result_UnknownPaymentContextDecodeErrorZ } from '../structs/Result_UnknownPaymentContextDecodeErrorZ.mjs';
import { Result_Bolt12OfferContextDecodeErrorZ } from '../structs/Result_Bolt12OfferContextDecodeErrorZ.mjs';
import { Result_Bolt12RefundContextDecodeErrorZ } from '../structs/Result_Bolt12RefundContextDecodeErrorZ.mjs';
import { Result_StrSecp256k1ErrorZ } from '../structs/Result_StrSecp256k1ErrorZ.mjs';
import { ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ } from '../structs/ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ.mjs';
import { Result_C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZNoneZ } from '../structs/Result_C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZNoneZ.mjs';
import { ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ } from '../structs/ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ.mjs';
import { SendError } from '../structs/SendError.mjs';
import { Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ } from '../structs/Result_C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZSendErrorZ.mjs';
import { NextMessageHop } from '../structs/NextMessageHop.mjs';
import { ParsedOnionMessageContents } from '../structs/ParsedOnionMessageContents.mjs';
import { PeeledOnion } from '../structs/PeeledOnion.mjs';
import { Result_PeeledOnionNoneZ } from '../structs/Result_PeeledOnionNoneZ.mjs';
import { SendSuccess } from '../structs/SendSuccess.mjs';
import { Result_SendSuccessSendErrorZ } from '../structs/Result_SendSuccessSendErrorZ.mjs';
import { Result_BlindedPathNoneZ } from '../structs/Result_BlindedPathNoneZ.mjs';
import { Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ } from '../structs/Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ.mjs';
import { ForwardNode } from '../structs/ForwardNode.mjs';
import { Result_BlindedPathDecodeErrorZ } from '../structs/Result_BlindedPathDecodeErrorZ.mjs';
import { Result_BlindedHopDecodeErrorZ } from '../structs/Result_BlindedHopDecodeErrorZ.mjs';
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
import { MonitorUpdateId } from '../structs/MonitorUpdateId.mjs';
import { TwoTuple_OutPointCVec_MonitorUpdateIdZZ } from '../structs/TwoTuple_OutPointCVec_MonitorUpdateIdZZ.mjs';
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
import { PrintableString } from '../structs/PrintableString.mjs';
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
import { OfferFeatures } from '../structs/OfferFeatures.mjs';
import { InvoiceRequestFeatures } from '../structs/InvoiceRequestFeatures.mjs';
import { OfferWithExplicitMetadataBuilder } from '../structs/OfferWithExplicitMetadataBuilder.mjs';
import { SignBolt12InvoiceFn, SignBolt12InvoiceFnInterface } from '../structs/SignBolt12InvoiceFn.mjs';
import { TaggedHash } from '../structs/TaggedHash.mjs';
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
import { Sha256 } from '../structs/Sha256.mjs';
import { ExpiryTime } from '../structs/ExpiryTime.mjs';
import { MinFinalCltvExpiryDelta } from '../structs/MinFinalCltvExpiryDelta.mjs';
import { Fallback } from '../structs/Fallback.mjs';

import { CommonBase, UInt5, WitnessVersion, UnqualifiedError } from './CommonBase.mjs';
import * as bindings from '../bindings.mjs'

/**
 * An event generated by ChannelManager which indicates a message should be sent to a peer (or
 * broadcast to most peers).
 * These events are handled by PeerManager::process_events if you are using a PeerManager.
 */
export class MessageSendEvent extends CommonBase {
	protected constructor(_dummy: null, ptr: bigint) { super(ptr, bindings.MessageSendEvent_free); }
	/* @internal */
	public static constr_from_ptr(ptr: bigint): MessageSendEvent {
		const raw_ty: number = bindings.LDKMessageSendEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new MessageSendEvent_SendAcceptChannel(ptr);
			case 1: return new MessageSendEvent_SendAcceptChannelV2(ptr);
			case 2: return new MessageSendEvent_SendOpenChannel(ptr);
			case 3: return new MessageSendEvent_SendOpenChannelV2(ptr);
			case 4: return new MessageSendEvent_SendFundingCreated(ptr);
			case 5: return new MessageSendEvent_SendFundingSigned(ptr);
			case 6: return new MessageSendEvent_SendStfu(ptr);
			case 7: return new MessageSendEvent_SendSplice(ptr);
			case 8: return new MessageSendEvent_SendSpliceAck(ptr);
			case 9: return new MessageSendEvent_SendSpliceLocked(ptr);
			case 10: return new MessageSendEvent_SendTxAddInput(ptr);
			case 11: return new MessageSendEvent_SendTxAddOutput(ptr);
			case 12: return new MessageSendEvent_SendTxRemoveInput(ptr);
			case 13: return new MessageSendEvent_SendTxRemoveOutput(ptr);
			case 14: return new MessageSendEvent_SendTxComplete(ptr);
			case 15: return new MessageSendEvent_SendTxSignatures(ptr);
			case 16: return new MessageSendEvent_SendTxInitRbf(ptr);
			case 17: return new MessageSendEvent_SendTxAckRbf(ptr);
			case 18: return new MessageSendEvent_SendTxAbort(ptr);
			case 19: return new MessageSendEvent_SendChannelReady(ptr);
			case 20: return new MessageSendEvent_SendAnnouncementSignatures(ptr);
			case 21: return new MessageSendEvent_UpdateHTLCs(ptr);
			case 22: return new MessageSendEvent_SendRevokeAndACK(ptr);
			case 23: return new MessageSendEvent_SendClosingSigned(ptr);
			case 24: return new MessageSendEvent_SendShutdown(ptr);
			case 25: return new MessageSendEvent_SendChannelReestablish(ptr);
			case 26: return new MessageSendEvent_SendChannelAnnouncement(ptr);
			case 27: return new MessageSendEvent_BroadcastChannelAnnouncement(ptr);
			case 28: return new MessageSendEvent_BroadcastChannelUpdate(ptr);
			case 29: return new MessageSendEvent_BroadcastNodeAnnouncement(ptr);
			case 30: return new MessageSendEvent_SendChannelUpdate(ptr);
			case 31: return new MessageSendEvent_HandleError(ptr);
			case 32: return new MessageSendEvent_SendChannelRangeQuery(ptr);
			case 33: return new MessageSendEvent_SendShortIdsQuery(ptr);
			case 34: return new MessageSendEvent_SendReplyChannelRange(ptr);
			case 35: return new MessageSendEvent_SendGossipTimestampFilter(ptr);
			default:
				throw new Error('oops, this should be unreachable'); // Unreachable without extending the (internal) bindings interface
		}
	}

	public clone_ptr(): bigint {
		const ret: bigint = bindings.MessageSendEvent_clone_ptr(this.ptr);
		return ret;
	}

	/**
	 * Creates a copy of the MessageSendEvent
	 */
	public clone(): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_clone(this.ptr);
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, this);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendAcceptChannel-variant MessageSendEvent
	 */
	public static constructor_send_accept_channel(node_id: Uint8Array, msg: AcceptChannel): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_accept_channel(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendAcceptChannelV2-variant MessageSendEvent
	 */
	public static constructor_send_accept_channel_v2(node_id: Uint8Array, msg: AcceptChannelV2): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_accept_channel_v2(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendOpenChannel-variant MessageSendEvent
	 */
	public static constructor_send_open_channel(node_id: Uint8Array, msg: OpenChannel): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_open_channel(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendOpenChannelV2-variant MessageSendEvent
	 */
	public static constructor_send_open_channel_v2(node_id: Uint8Array, msg: OpenChannelV2): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_open_channel_v2(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendFundingCreated-variant MessageSendEvent
	 */
	public static constructor_send_funding_created(node_id: Uint8Array, msg: FundingCreated): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_funding_created(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendFundingSigned-variant MessageSendEvent
	 */
	public static constructor_send_funding_signed(node_id: Uint8Array, msg: FundingSigned): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_funding_signed(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendStfu-variant MessageSendEvent
	 */
	public static constructor_send_stfu(node_id: Uint8Array, msg: Stfu): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_stfu(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendSplice-variant MessageSendEvent
	 */
	public static constructor_send_splice(node_id: Uint8Array, msg: Splice): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_splice(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendSpliceAck-variant MessageSendEvent
	 */
	public static constructor_send_splice_ack(node_id: Uint8Array, msg: SpliceAck): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_splice_ack(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendSpliceLocked-variant MessageSendEvent
	 */
	public static constructor_send_splice_locked(node_id: Uint8Array, msg: SpliceLocked): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_splice_locked(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxAddInput-variant MessageSendEvent
	 */
	public static constructor_send_tx_add_input(node_id: Uint8Array, msg: TxAddInput): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_add_input(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxAddOutput-variant MessageSendEvent
	 */
	public static constructor_send_tx_add_output(node_id: Uint8Array, msg: TxAddOutput): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_add_output(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxRemoveInput-variant MessageSendEvent
	 */
	public static constructor_send_tx_remove_input(node_id: Uint8Array, msg: TxRemoveInput): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_remove_input(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxRemoveOutput-variant MessageSendEvent
	 */
	public static constructor_send_tx_remove_output(node_id: Uint8Array, msg: TxRemoveOutput): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_remove_output(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxComplete-variant MessageSendEvent
	 */
	public static constructor_send_tx_complete(node_id: Uint8Array, msg: TxComplete): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_complete(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxSignatures-variant MessageSendEvent
	 */
	public static constructor_send_tx_signatures(node_id: Uint8Array, msg: TxSignatures): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_signatures(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxInitRbf-variant MessageSendEvent
	 */
	public static constructor_send_tx_init_rbf(node_id: Uint8Array, msg: TxInitRbf): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_init_rbf(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxAckRbf-variant MessageSendEvent
	 */
	public static constructor_send_tx_ack_rbf(node_id: Uint8Array, msg: TxAckRbf): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_ack_rbf(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendTxAbort-variant MessageSendEvent
	 */
	public static constructor_send_tx_abort(node_id: Uint8Array, msg: TxAbort): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_tx_abort(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendChannelReady-variant MessageSendEvent
	 */
	public static constructor_send_channel_ready(node_id: Uint8Array, msg: ChannelReady): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_channel_ready(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendAnnouncementSignatures-variant MessageSendEvent
	 */
	public static constructor_send_announcement_signatures(node_id: Uint8Array, msg: AnnouncementSignatures): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_announcement_signatures(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new UpdateHTLCs-variant MessageSendEvent
	 */
	public static constructor_update_htlcs(node_id: Uint8Array, updates: CommitmentUpdate): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_update_htlcs(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(updates));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, updates);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendRevokeAndACK-variant MessageSendEvent
	 */
	public static constructor_send_revoke_and_ack(node_id: Uint8Array, msg: RevokeAndACK): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_revoke_and_ack(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendClosingSigned-variant MessageSendEvent
	 */
	public static constructor_send_closing_signed(node_id: Uint8Array, msg: ClosingSigned): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_closing_signed(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendShutdown-variant MessageSendEvent
	 */
	public static constructor_send_shutdown(node_id: Uint8Array, msg: Shutdown): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_shutdown(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendChannelReestablish-variant MessageSendEvent
	 */
	public static constructor_send_channel_reestablish(node_id: Uint8Array, msg: ChannelReestablish): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_channel_reestablish(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendChannelAnnouncement-variant MessageSendEvent
	 */
	public static constructor_send_channel_announcement(node_id: Uint8Array, msg: ChannelAnnouncement, update_msg: ChannelUpdate): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_channel_announcement(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg), CommonBase.get_ptr_of(update_msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		CommonBase.add_ref_from(ret_hu_conv, update_msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BroadcastChannelAnnouncement-variant MessageSendEvent
	 */
	public static constructor_broadcast_channel_announcement(msg: ChannelAnnouncement, update_msg: ChannelUpdate): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_broadcast_channel_announcement(CommonBase.get_ptr_of(msg), CommonBase.get_ptr_of(update_msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		CommonBase.add_ref_from(ret_hu_conv, update_msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BroadcastChannelUpdate-variant MessageSendEvent
	 */
	public static constructor_broadcast_channel_update(msg: ChannelUpdate): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_broadcast_channel_update(CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BroadcastNodeAnnouncement-variant MessageSendEvent
	 */
	public static constructor_broadcast_node_announcement(msg: NodeAnnouncement): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_broadcast_node_announcement(CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendChannelUpdate-variant MessageSendEvent
	 */
	public static constructor_send_channel_update(node_id: Uint8Array, msg: ChannelUpdate): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_channel_update(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new HandleError-variant MessageSendEvent
	 */
	public static constructor_handle_error(node_id: Uint8Array, action: ErrorAction): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_handle_error(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(action));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, action);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendChannelRangeQuery-variant MessageSendEvent
	 */
	public static constructor_send_channel_range_query(node_id: Uint8Array, msg: QueryChannelRange): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_channel_range_query(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendShortIdsQuery-variant MessageSendEvent
	 */
	public static constructor_send_short_ids_query(node_id: Uint8Array, msg: QueryShortChannelIds): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_short_ids_query(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendReplyChannelRange-variant MessageSendEvent
	 */
	public static constructor_send_reply_channel_range(node_id: Uint8Array, msg: ReplyChannelRange): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_reply_channel_range(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SendGossipTimestampFilter-variant MessageSendEvent
	 */
	public static constructor_send_gossip_timestamp_filter(node_id: Uint8Array, msg: GossipTimestampFilter): MessageSendEvent {
		const ret: bigint = bindings.MessageSendEvent_send_gossip_timestamp_filter(bindings.encodeUint8Array(bindings.check_arr_len(node_id, 33)), CommonBase.get_ptr_of(msg));
		const ret_hu_conv: MessageSendEvent = MessageSendEvent.constr_from_ptr(ret);
		CommonBase.add_ref_from(ret_hu_conv, ret_hu_conv);
		CommonBase.add_ref_from(ret_hu_conv, msg);
		return ret_hu_conv;
	}

}
/** A MessageSendEvent of type SendAcceptChannel */
export class MessageSendEvent_SendAcceptChannel extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: AcceptChannel;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendAcceptChannel_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendAcceptChannel_get_msg(ptr);
		const msg_hu_conv: AcceptChannel = new AcceptChannel(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendAcceptChannelV2 */
export class MessageSendEvent_SendAcceptChannelV2 extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: AcceptChannelV2;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendAcceptChannelV2_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendAcceptChannelV2_get_msg(ptr);
		const msg_hu_conv: AcceptChannelV2 = new AcceptChannelV2(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendOpenChannel */
export class MessageSendEvent_SendOpenChannel extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: OpenChannel;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendOpenChannel_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendOpenChannel_get_msg(ptr);
		const msg_hu_conv: OpenChannel = new OpenChannel(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendOpenChannelV2 */
export class MessageSendEvent_SendOpenChannelV2 extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: OpenChannelV2;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendOpenChannelV2_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendOpenChannelV2_get_msg(ptr);
		const msg_hu_conv: OpenChannelV2 = new OpenChannelV2(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendFundingCreated */
export class MessageSendEvent_SendFundingCreated extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: FundingCreated;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendFundingCreated_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendFundingCreated_get_msg(ptr);
		const msg_hu_conv: FundingCreated = new FundingCreated(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendFundingSigned */
export class MessageSendEvent_SendFundingSigned extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: FundingSigned;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendFundingSigned_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendFundingSigned_get_msg(ptr);
		const msg_hu_conv: FundingSigned = new FundingSigned(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendStfu */
export class MessageSendEvent_SendStfu extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: Stfu;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendStfu_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendStfu_get_msg(ptr);
		const msg_hu_conv: Stfu = new Stfu(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendSplice */
export class MessageSendEvent_SendSplice extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: Splice;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendSplice_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendSplice_get_msg(ptr);
		const msg_hu_conv: Splice = new Splice(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendSpliceAck */
export class MessageSendEvent_SendSpliceAck extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: SpliceAck;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendSpliceAck_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendSpliceAck_get_msg(ptr);
		const msg_hu_conv: SpliceAck = new SpliceAck(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendSpliceLocked */
export class MessageSendEvent_SendSpliceLocked extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: SpliceLocked;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendSpliceLocked_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendSpliceLocked_get_msg(ptr);
		const msg_hu_conv: SpliceLocked = new SpliceLocked(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxAddInput */
export class MessageSendEvent_SendTxAddInput extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxAddInput;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxAddInput_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxAddInput_get_msg(ptr);
		const msg_hu_conv: TxAddInput = new TxAddInput(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxAddOutput */
export class MessageSendEvent_SendTxAddOutput extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxAddOutput;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxAddOutput_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxAddOutput_get_msg(ptr);
		const msg_hu_conv: TxAddOutput = new TxAddOutput(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxRemoveInput */
export class MessageSendEvent_SendTxRemoveInput extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxRemoveInput;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxRemoveInput_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxRemoveInput_get_msg(ptr);
		const msg_hu_conv: TxRemoveInput = new TxRemoveInput(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxRemoveOutput */
export class MessageSendEvent_SendTxRemoveOutput extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxRemoveOutput;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxRemoveOutput_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxRemoveOutput_get_msg(ptr);
		const msg_hu_conv: TxRemoveOutput = new TxRemoveOutput(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxComplete */
export class MessageSendEvent_SendTxComplete extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxComplete;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxComplete_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxComplete_get_msg(ptr);
		const msg_hu_conv: TxComplete = new TxComplete(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxSignatures */
export class MessageSendEvent_SendTxSignatures extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxSignatures;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxSignatures_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxSignatures_get_msg(ptr);
		const msg_hu_conv: TxSignatures = new TxSignatures(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxInitRbf */
export class MessageSendEvent_SendTxInitRbf extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxInitRbf;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxInitRbf_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxInitRbf_get_msg(ptr);
		const msg_hu_conv: TxInitRbf = new TxInitRbf(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxAckRbf */
export class MessageSendEvent_SendTxAckRbf extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxAckRbf;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxAckRbf_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxAckRbf_get_msg(ptr);
		const msg_hu_conv: TxAckRbf = new TxAckRbf(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendTxAbort */
export class MessageSendEvent_SendTxAbort extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: TxAbort;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendTxAbort_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendTxAbort_get_msg(ptr);
		const msg_hu_conv: TxAbort = new TxAbort(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendChannelReady */
export class MessageSendEvent_SendChannelReady extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive these message(s)
	 */
	public node_id: Uint8Array;
	/**
	 * The channel_ready message which should be sent.
	 */
	public msg: ChannelReady;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendChannelReady_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendChannelReady_get_msg(ptr);
		const msg_hu_conv: ChannelReady = new ChannelReady(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendAnnouncementSignatures */
export class MessageSendEvent_SendAnnouncementSignatures extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive these message(s)
	 */
	public node_id: Uint8Array;
	/**
	 * The announcement_signatures message which should be sent.
	 */
	public msg: AnnouncementSignatures;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendAnnouncementSignatures_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendAnnouncementSignatures_get_msg(ptr);
		const msg_hu_conv: AnnouncementSignatures = new AnnouncementSignatures(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type UpdateHTLCs */
export class MessageSendEvent_UpdateHTLCs extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive these message(s)
	 */
	public node_id: Uint8Array;
	/**
	 * The update messages which should be sent. ALL messages in the struct should be sent!
	 */
	public updates: CommitmentUpdate;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_UpdateHTLCs_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const updates: bigint = bindings.LDKMessageSendEvent_UpdateHTLCs_get_updates(ptr);
		const updates_hu_conv: CommitmentUpdate = new CommitmentUpdate(null, updates);
			CommonBase.add_ref_from(updates_hu_conv, this);
		this.updates = updates_hu_conv;
	}
}
/** A MessageSendEvent of type SendRevokeAndACK */
export class MessageSendEvent_SendRevokeAndACK extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: RevokeAndACK;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendRevokeAndACK_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendRevokeAndACK_get_msg(ptr);
		const msg_hu_conv: RevokeAndACK = new RevokeAndACK(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendClosingSigned */
export class MessageSendEvent_SendClosingSigned extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: ClosingSigned;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendClosingSigned_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendClosingSigned_get_msg(ptr);
		const msg_hu_conv: ClosingSigned = new ClosingSigned(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendShutdown */
export class MessageSendEvent_SendShutdown extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: Shutdown;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendShutdown_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendShutdown_get_msg(ptr);
		const msg_hu_conv: Shutdown = new Shutdown(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendChannelReestablish */
export class MessageSendEvent_SendChannelReestablish extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The message which should be sent.
	 */
	public msg: ChannelReestablish;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendChannelReestablish_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendChannelReestablish_get_msg(ptr);
		const msg_hu_conv: ChannelReestablish = new ChannelReestablish(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendChannelAnnouncement */
export class MessageSendEvent_SendChannelAnnouncement extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The channel_announcement which should be sent.
	 */
	public msg: ChannelAnnouncement;
	/**
	 * The followup channel_update which should be sent.
	 */
	public update_msg: ChannelUpdate;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendChannelAnnouncement_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendChannelAnnouncement_get_msg(ptr);
		const msg_hu_conv: ChannelAnnouncement = new ChannelAnnouncement(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
		const update_msg: bigint = bindings.LDKMessageSendEvent_SendChannelAnnouncement_get_update_msg(ptr);
		const update_msg_hu_conv: ChannelUpdate = new ChannelUpdate(null, update_msg);
			CommonBase.add_ref_from(update_msg_hu_conv, this);
		this.update_msg = update_msg_hu_conv;
	}
}
/** A MessageSendEvent of type BroadcastChannelAnnouncement */
export class MessageSendEvent_BroadcastChannelAnnouncement extends MessageSendEvent {
	/**
	 * The channel_announcement which should be sent.
	 */
	public msg: ChannelAnnouncement;
	/**
	 * The followup channel_update which should be sent.
	 * 
	 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public update_msg: ChannelUpdate;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const msg: bigint = bindings.LDKMessageSendEvent_BroadcastChannelAnnouncement_get_msg(ptr);
		const msg_hu_conv: ChannelAnnouncement = new ChannelAnnouncement(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
		const update_msg: bigint = bindings.LDKMessageSendEvent_BroadcastChannelAnnouncement_get_update_msg(ptr);
		const update_msg_hu_conv: ChannelUpdate = new ChannelUpdate(null, update_msg);
			CommonBase.add_ref_from(update_msg_hu_conv, this);
		this.update_msg = update_msg_hu_conv;
	}
}
/** A MessageSendEvent of type BroadcastChannelUpdate */
export class MessageSendEvent_BroadcastChannelUpdate extends MessageSendEvent {
	/**
	 * The channel_update which should be sent.
	 */
	public msg: ChannelUpdate;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const msg: bigint = bindings.LDKMessageSendEvent_BroadcastChannelUpdate_get_msg(ptr);
		const msg_hu_conv: ChannelUpdate = new ChannelUpdate(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type BroadcastNodeAnnouncement */
export class MessageSendEvent_BroadcastNodeAnnouncement extends MessageSendEvent {
	/**
	 * The node_announcement which should be sent.
	 */
	public msg: NodeAnnouncement;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const msg: bigint = bindings.LDKMessageSendEvent_BroadcastNodeAnnouncement_get_msg(ptr);
		const msg_hu_conv: NodeAnnouncement = new NodeAnnouncement(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendChannelUpdate */
export class MessageSendEvent_SendChannelUpdate extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The channel_update which should be sent.
	 */
	public msg: ChannelUpdate;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendChannelUpdate_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendChannelUpdate_get_msg(ptr);
		const msg_hu_conv: ChannelUpdate = new ChannelUpdate(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type HandleError */
export class MessageSendEvent_HandleError extends MessageSendEvent {
	/**
	 * The node_id of the node which should receive this message
	 */
	public node_id: Uint8Array;
	/**
	 * The action which should be taken.
	 */
	public action: ErrorAction;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_HandleError_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const action: bigint = bindings.LDKMessageSendEvent_HandleError_get_action(ptr);
		const action_hu_conv: ErrorAction = ErrorAction.constr_from_ptr(action);
			CommonBase.add_ref_from(action_hu_conv, this);
		this.action = action_hu_conv;
	}
}
/** A MessageSendEvent of type SendChannelRangeQuery */
export class MessageSendEvent_SendChannelRangeQuery extends MessageSendEvent {
	/**
	 * The node_id of this message recipient
	 */
	public node_id: Uint8Array;
	/**
	 * The query_channel_range which should be sent.
	 */
	public msg: QueryChannelRange;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendChannelRangeQuery_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendChannelRangeQuery_get_msg(ptr);
		const msg_hu_conv: QueryChannelRange = new QueryChannelRange(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendShortIdsQuery */
export class MessageSendEvent_SendShortIdsQuery extends MessageSendEvent {
	/**
	 * The node_id of this message recipient
	 */
	public node_id: Uint8Array;
	/**
	 * The query_short_channel_ids which should be sent.
	 */
	public msg: QueryShortChannelIds;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendShortIdsQuery_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendShortIdsQuery_get_msg(ptr);
		const msg_hu_conv: QueryShortChannelIds = new QueryShortChannelIds(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendReplyChannelRange */
export class MessageSendEvent_SendReplyChannelRange extends MessageSendEvent {
	/**
	 * The node_id of this message recipient
	 */
	public node_id: Uint8Array;
	/**
	 * The reply_channel_range which should be sent.
	 */
	public msg: ReplyChannelRange;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendReplyChannelRange_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendReplyChannelRange_get_msg(ptr);
		const msg_hu_conv: ReplyChannelRange = new ReplyChannelRange(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
/** A MessageSendEvent of type SendGossipTimestampFilter */
export class MessageSendEvent_SendGossipTimestampFilter extends MessageSendEvent {
	/**
	 * The node_id of this message recipient
	 */
	public node_id: Uint8Array;
	/**
	 * The gossip_timestamp_filter which should be sent.
	 */
	public msg: GossipTimestampFilter;
	/* @internal */
	public constructor(ptr: bigint) {
		super(null, ptr);
		const node_id: number = bindings.LDKMessageSendEvent_SendGossipTimestampFilter_get_node_id(ptr);
		const node_id_conv: Uint8Array = bindings.decodeUint8Array(node_id);
		this.node_id = node_id_conv;
		const msg: bigint = bindings.LDKMessageSendEvent_SendGossipTimestampFilter_get_msg(ptr);
		const msg_hu_conv: GossipTimestampFilter = new GossipTimestampFilter(null, msg);
			CommonBase.add_ref_from(msg_hu_conv, this);
		this.msg = msg_hu_conv;
	}
}
