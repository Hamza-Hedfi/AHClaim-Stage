using System.Collections.Generic;
using System.Linq;
using AHClaim.Record;

namespace AHClaim.Segment
{
    public static class SegmentFactory
    {
        /// <summary>
        /// Factory method for Claim Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;ClaimSegment&gt;</returns>
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

        /// <summary>
        /// Factory method for Claim Indicator Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;ClaimIndicatorSegment&gt;</returns>
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

        /// <summary>
        /// Factory method for Addtl. Patient Info Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;AddtlPatientInfoSegment&gt;</returns>
        public static IEnumerable<AddtlPatientInfoSegment> GetAddtlPatientInfoSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new AddtlPatientInfoSegment()
            {
                CardholderLastName = r.AddtlPatientInfoSegmentCardholderLastName,
                CardholderFirstName = r.AddtlPatientInfoSegmentCardholderFirstName,
                PatientMiddleInitial = r.AddtlPatientInfoSegmentPatientMiddleInitial,
                PatientNameSuffix = r.AddtlPatientInfoSegmentPatientNameSuffix,
                AddressLine1 = r.AddtlPatientInfoSegmentAddressLine1,
                AddressLine2 = r.AddtlPatientInfoSegmentAddressLine2,
                City = r.AddtlPatientInfoSegmentCity,
                State = r.AddtlPatientInfoSegmentState,
                ZipCode = r.AddtlPatientInfoSegmentZipCode,
                PhoneNumber = r.AddtlPatientInfoSegmentPhoneNumber,
                EffectiveDate = r.AddtlPatientInfoSegmentEffectiveDate,
                TerminationDate = r.AddtlPatientInfoSegmentTerminationDate,
                DateOfBirth = r.AddtlPatientInfoSegmentDateOfBirth,
                GenderCode = r.AddtlPatientInfoSegmentGenderCode,
                RelationshipCode = r.AddtlPatientInfoSegmentRelationshipCode,
                CoverageCode = r.AddtlPatientInfoSegmentCoverageCode,
                ReservedForFutureUse1 = r.AddtlPatientInfoSegmentReservedForFutureUse1,
                StudentFlag = r.AddtlPatientInfoSegmentStudentFlag,
                ReservedForFutureUse2 = r.AddtlPatientInfoSegmentReservedForFutureUse2,
                LocationCode = r.AddtlPatientInfoSegmentLocationCode,
                LocationName = r.AddtlPatientInfoSegmentLocationName,
                SecondaryCoverage = r.AddtlPatientInfoSegmentSecondaryCoverage,
                PharmacyLockIn = r.AddtlPatientInfoSegmentPharmacyLockIn,
                PhysicianLockIn = r.AddtlPatientInfoSegmentPhysicianLockIn,
                TestMemberFlag = r.AddtlPatientInfoSegmentTestMemberFlag,
                EligibilityCreatedByUserId = r.AddtlPatientInfoSegmentEligibilityCreatedByUserId,
                EligibilityCreatedDate = r.AddtlPatientInfoSegmentEligibilityCreatedDate,
                EligibilityModifiedByUserId = r.AddtlPatientInfoSegmentEligibilityModifiedByUserId,
                EligibilityModifiedDate = r.AddtlPatientInfoSegmentEligibilityModifiedDate,
                ReservedForFutureUse3 = r.AddtlPatientInfoSegmentReservedForFutureUse3
            });
        }

        /// <summary>
        /// Factory method for Claim Reject Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;ClaimRejectSegment&gt;</returns>
        public static IEnumerable<ClaimRejectSegment> GetClaimRejectSegments(this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new ClaimRejectSegment()
            {
                RejectCode1 = r.ClaimRejectSegmentRejectCode1,
                RejectCode2 = r.ClaimRejectSegmentRejectCode2,
                RejectCode3 = r.ClaimRejectSegmentRejectCode3,
                RejectCode4 = r.ClaimRejectSegmentRejectCode4,
                RejectCode5 = r.ClaimRejectSegmentRejectCode5,
                EccRejectCode1 = r.ClaimRejectSegmentEccRejectCode1,
                EccRejectCode2 = r.ClaimRejectSegmentEccRejectCode2,
                EccRejectCode3 = r.ClaimRejectSegmentEccRejectCode3,
                EccRejectCode4 = r.ClaimRejectSegmentEccRejectCode4,
                EccRejectCode5 = r.ClaimRejectSegmentEccRejectCode5
            });
        }

        /// <summary>
        /// Factory method for Prior Authorization Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;PriorAuthorizationSegment&gt;</returns>
        public static IEnumerable<PriorAuthorizationSegment> GetPriorAuthorizationSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new PriorAuthorizationSegment()
            {
                PaTypeSubmitted = r.PriorAuthorizationSegmentPaTypeSubmitted,
                PaNumberSubmitted = r.PriorAuthorizationSegmentPaNumberSubmitted,
                ActualPaNumberUsed = r.PriorAuthorizationSegmentActualPaNumberUsed,
                PaTypeManualAuto = r.PriorAuthorizationSegmentPaTypeManualAuto,
                PaEffectiveDate = r.PriorAuthorizationSegmentPaEffectiveDate,
                PaTerminationDate = r.PriorAuthorizationSegmentPaTerminationDate,
                PaDescription = r.PriorAuthorizationSegmentPaDescription,
                ReservedForFutureUse = r.PriorAuthorizationSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for DUR Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;DurSegment&gt;</returns>
        public static IEnumerable<DurSegment> GetDurSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new DurSegment()
            {
                Dur1ConflictCode = r.DurSegmentDur1ConflictCode,
                Dur1SeverityIndex = r.DurSegmentDur1SeverityIndex,
                Dur1HitDisposition = r.DurSegmentDur1HitDisposition,
                Dur1ConflictingAuthorizationNumber = r.DurSegmentDur1ConflictingAuthorizationNumber,
                Dur2ConflictCode = r.DurSegmentDur2ConflictCode,
                Dur2SeverityIndex = r.DurSegmentDur2SeverityIndex,
                Dur2HitDisposition = r.DurSegmentDur2HitDisposition,
                Dur2ConflictingAuthorizationNumber = r.DurSegmentDur2ConflictingAuthorizationNumber,
                Dur3ConflictCode = r.DurSegmentDur3ConflictCode,
                Dur3SeverityIndex = r.DurSegmentDur3SeverityIndex,
                Dur3HitDisposition = r.DurSegmentDur3HitDisposition,
                Dur3ConflictingAuthorizationNumber = r.DurSegmentDur3ConflictingAuthorizationNumber,
                Dur4ConflictCode = r.DurSegmentDur4ConflictCode,
                Dur4SeverityIndex = r.DurSegmentDur4SeverityIndex,
                Dur4HitDisposition = r.DurSegmentDur4HitDisposition,
                Dur4ConflictingAuthorizationNumber = r.DurSegmentDur4ConflictingAuthorizationNumber,
                Dur5ConflictCode = r.DurSegmentDur5ConflictCode,
                Dur5SeverityIndex = r.DurSegmentDur5SeverityIndex,
                Dur5HitDisposition = r.DurSegmentDur5HitDisposition,
                Dur5ConflictingAuthorizationNumber = r.DurSegmentDur5ConflictingAuthorizationNumber
            });
        }

        /// <summary>
        /// Factory method for Submitted DUR Override Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;DurSegment&gt;</returns>
        public static IEnumerable<SubmittedDurOverrideSegment> GetSubmittedDurOverrideSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new SubmittedDurOverrideSegment()
            {
                ReasonForServiceConflict1 = r.SubmittedDurOverrideSegmentReasonForServiceConflict1,
                ProfessionalServiceCodeIntervention1 =
                    r.SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention1,
                ResultOfServiceCodeOutcome1 = r.SubmittedDurOverrideSegmentResultOfServiceCodeOutcome1,
                ReasonForServiceConflict2 = r.SubmittedDurOverrideSegmentReasonForServiceConflict2,
                ProfessionalServiceCodeIntervention2 =
                    r.SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention2,
                ResultOfServiceCodeOutcome2 = r.SubmittedDurOverrideSegmentResultOfServiceCodeOutcome2,
                ReasonForServiceConflict3 = r.SubmittedDurOverrideSegmentReasonForServiceConflict3,
                ProfessionalServiceCodeIntervention3 =
                    r.SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention3,
                ResultOfServiceCodeOutcome3 = r.SubmittedDurOverrideSegmentResultOfServiceCodeOutcome3,
                ReasonForServiceConflict4 = r.SubmittedDurOverrideSegmentReasonForServiceConflict4,
                ProfessionalServiceCodeIntervention4 =
                    r.SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention4,
                ResultOfServiceCodeOutcome4 = r.SubmittedDurOverrideSegmentResultOfServiceCodeOutcome4,
                ReasonForServiceConflict5 = r.SubmittedDurOverrideSegmentReasonForServiceConflict5,
                ProfessionalServiceCodeIntervention5 =
                    r.SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention5,
                ResultOfServiceCodeOutcome5 = r.SubmittedDurOverrideSegmentResultOfServiceCodeOutcome5
            });
        }
    }
}