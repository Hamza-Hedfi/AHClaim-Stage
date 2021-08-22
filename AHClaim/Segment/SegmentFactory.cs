﻿using System.Collections.Generic;
using System.Linq;
using AHClaim.Record;

namespace AHClaim.Segment
{
    public static class SegmentFactory
    {
        public static IEnumerable<ClaimSegment> GetClaimSegments(this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new ClaimSegment()
            {
                ClaimAuthorizationNumber = r.ClaimSegmentClaimAuthorizationNumber,
                OriginalClaimAuthorizationNumber = r.ClaimSegmentOriginalClaimAuthorizationNumber,
                ReversalClaimAuthorizationNumber = r.ClaimSegmentReversalClaimAuthorizationNumber,
                DateProcessed = r.ClaimSegmentDateProcessed,
                TimeProcessed = r.ClaimSegmentTimeProcessed,
                RejectionFlag = r.ClaimSegmentRejectionFlag,
                DuplicateFlag = r.ClaimSegmentDuplicateFlag,
                ReversalFlag = r.ClaimSegmentReversalFlag,
                PharmacyNcpdpIdNumber = r.ClaimSegmentPharmacyNcpdpIdNumber,
                PharmacyName = r.ClaimSegmentPharmacyName,
                PharmacyChainNumber = r.ClaimSegmentPharmacyChainNumber,
                PharmacyChainName = r.ClaimSegmentPharmacyChainName,
                PharmacyType = r.ClaimSegmentPharmacyType,
                CarrierCode = r.ClaimSegmentCarrierCode,
                SubmittedCarrierCode = r.ClaimSegmentSubmittedCarrierCode,
                TpaBrokerCode = r.ClaimSegmentTpaBrokerCode,
                TpaBrokerName = r.ClaimSegmentTpaBrokerName,
                SponsorCode = r.ClaimSegmentSponsorCode,
                SponsorName = r.ClaimSegmentSponsorName,
                GroupNumber = r.ClaimSegmentGroupNumber,
                GroupName = r.ClaimSegmentGroupName,
                CardholderIdNumber = r.ClaimSegmentCardholderIdNumber,
                PatientPersonCode = r.ClaimSegmentPatientPersonCode,
                PatientLastName = r.ClaimSegmentPatientLastName,
                PatientFirstName = r.ClaimSegmentPatientFirstName,
                PrescriberId = r.ClaimSegmentPrescriberId,
                PrescriberName = r.ClaimSegmentPrescriberName,
                DateFilled = r.ClaimSegmentDateFilled,
                DateWritten = r.ClaimSegmentDateWritten,
                RxNumber = r.ClaimSegmentRxNumber,
                FillNumber = r.ClaimSegmentFillNumber,
                NumberOfRefillsAuthorized = r.ClaimSegmentNumberOfRefillsAuthorized,
                DrugNdcNumber = r.ClaimSegmentDrugNdcNumber,
                DrugName = r.ClaimSegmentDrugName,
                DrugStrengthDescription = r.ClaimSegmentDrugStrengthDescription,
                DrugDoseFormDescription = r.ClaimSegmentDrugDoseFormDescription,
                SubmittedCompoundCode = r.ClaimSegmentSubmittedCompoundCode,
                SubmittedRouteOfAdmin = r.ClaimSegmentSubmittedRouteOfAdmin,
                DrugProcessedSigCode = r.ClaimSegmentDrugProcessedSigCode,
                DrugMonyCode = r.ClaimSegmentDrugMonyCode,
                QuantityDispensed = r.ClaimSegmentQuantityDispensed,
                DaysSupply = r.ClaimSegmentDaysSupply,
                DawCode = r.ClaimSegmentDawCode,
                PlanIngredientCost = r.ClaimSegmentPlanIngredientCost,
                PlanDispensingFee = r.ClaimSegmentPlanDispensingFee,
                PlanSalesTax = r.ClaimSegmentPlanSalesTax,
                IncentiveFee = r.ClaimSegmentIncentiveFee,
                ProcessorFee = r.ClaimSegmentProcessorFee,
                PlanGrossAmount = r.ClaimSegmentPlanGrossAmount,
                OtherPayerAmount = r.ClaimSegmentOtherPayerAmount,
                TotalPatientPayAmount = r.ClaimSegmentTotalPatientPayAmount,
                PlanPharmacyAmount = r.ClaimSegmentPlanPharmacyAmount,
                PlanBasisOfCost = r.ClaimSegmentPlanBasisOfCost,
                PlanBasisOfReimbursement = r.ClaimSegmentPlanBasisOfReimbursement,
                CalculatedAwp = r.ClaimSegmentCalculatedAwp,
                SubmissionClarificationCode = r.ClaimSegmentSubmissionClarificationCode,
                OtherCoverageCode = r.ClaimSegmentOtherCoverageCode,
                MedicaidCode = r.ClaimSegmentMedicaidCode,
                MedicaidName = r.ClaimSegmentMedicaidName,
                CouponNumber = r.ClaimSegmentCouponNumber,
                PharmacyNationalProviderId = r.ClaimSegmentPharmacyNationalProviderId,
                PharmacyIdQualifierSubmitted = r.ClaimSegmentPharmacyIdQualifierSubmitted,
                CalculatedFedmac = r.ClaimSegmentCalculatedFedmac,
                CalculatedAwpSource = r.ClaimSegmentCalculatedAwpSource,
                CalculatedWac = r.ClaimSegmentCalculatedWac,
                CouponActualUseNumber = r.ClaimSegmentCouponActualUseNumber,
                ProcessedSingleSourceGenericIndicator = r.ClaimSegmentProcessedSingleSourceGenericIndicator,
                ManufacturerName = r.ClaimSegmentManufacturerName,
                AdjudicatedUnitPrice = r.ClaimSegmentAdjudicatedUnitPrice,
                PreCopayRoundingAmount = r.ClaimSegmentPreCopayRoundingAmount,
                NumberOfCouponUses = r.ClaimSegmentNumberOfCouponUses,
                CombinedCouponUses = r.ClaimSegmentCombinedCouponUses,
                RejectReprocessOriginalAuthorizationNumber = r.ClaimSegmentRejectReprocessOriginalAuthorizationNumber,
                ReservedForFutureUse = r.ClaimSegmentReservedForFutureUse
            });
        }

        public static IEnumerable<ClaimIndicatorSegment> GetClaimIndicatorSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new ClaimIndicatorSegment()
            {
                PaperClaimFlag = r.ClaimIndicatorSegmentPaperClaimFlag,
                DirectReimbursementFlag = r.ClaimIndicatorSegmentDirectReimbursementFlag,
                TestClaimFlag = r.ClaimIndicatorSegmentTestClaimFlag,
                BatchProcessedFlag = r.ClaimIndicatorSegmentBatchProcessedFlag,
                OtherProcessorFlag = r.ClaimIndicatorSegmentOtherProcessorFlag,
                FormularyDrugFlag = r.ClaimIndicatorSegmentFormularyDrugFlag,
                NetworkPharmacyFlag = r.ClaimIndicatorSegmentNetworkPharmacyFlag,
                NetworkPhysicianFlag = r.ClaimIndicatorSegmentNetworkPhysicianFlag,
                ShoeboxClaimFlag = r.ClaimIndicatorSegmentShoeboxClaimFlag,
                ProductQtyClaimFlag = r.ClaimIndicatorSegmentProductQtyClaimFlag,
                StarterDoseFlag = r.ClaimIndicatorSegmentStarterDoseFlag,
                PriorAuthFlag = r.ClaimIndicatorSegmentPriorAuthFlag,
                DurFlag = r.ClaimIndicatorSegmentDurFlag,
                DurOverrideFlag = r.ClaimIndicatorSegmentDurOverrideFlag,
                IgCopayFlag = r.ClaimIndicatorSegmentIgCopayFlag,
                MultiIngredCompoundFlag = r.ClaimIndicatorSegmentMultiIngredCompoundFlag,
                PartialFillDispensingStatus = r.ClaimIndicatorSegmentPartialFillDispensingStatus,
                MedicaidFlag = r.ClaimIndicatorSegmentMedicaidFlag,
                ForceUcFlag = r.ClaimIndicatorSegmentForceUcFlag,
                NdcRemapped = r.ClaimIndicatorSegmentNdcRemapped,
                ForcePharmacyDue = r.ClaimIndicatorSegmentForcePharmacyDue,
                AdditionalLowerOfStateRateUsed = r.ClaimIndicatorSegmentAdditionalLowerOfStateRateUsed,
                PosMedicaidFlag = r.ClaimIndicatorSegmentPosMedicaidFlag,
                AlternateProcessingBypass = r.ClaimIndicatorSegmentAlternateProcessingBypass,
                TaxExemptIndicator = r.ClaimIndicatorSegmentTaxExemptIndicator,
                AlternateDrugRecord = r.ClaimIndicatorSegmentAlternateDrugRecord,
                ClaimRoundingUsed = r.ClaimIndicatorSegmentClaimRoundingUsed,
                MedicalClaimIndicator = r.ClaimIndicatorSegmentMedicalClaimIndicator,
                CompensableClaimIndicator = r.ClaimIndicatorSegmentCompensableClaimIndicator,
                DataFeedTransaction = r.ClaimIndicatorSegmentDataFeedTransaction,
                ReservedForFutureUse = r.ClaimIndicatorSegmentReservedForFutureUse
            });
        }
    }
}