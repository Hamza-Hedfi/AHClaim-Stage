using System.Collections.Generic;
using System.Linq;
using AHClaim.domain.Record;

namespace AHClaim.domain.Segment.Extension
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

        /// <summary>
        /// Factory method for Drug Classification Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;DrugClassificationSegment&gt;</returns>
        public static IEnumerable<DrugClassificationSegment> GetDrugClassificationSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new DrugClassificationSegment()
            {
                CategoryCode = r.DrugClassificationSegmentCategoryCode,
                ClassCode = r.DrugClassificationSegmentClassCode,
                Gc1Code = r.DrugClassificationSegmentGc1Code,
                Gc2Code = r.DrugClassificationSegmentGc2Code,
                Gc3Code = r.DrugClassificationSegmentGc3Code,
                Gc4Code = r.DrugClassificationSegmentGc4Code,
                SpecificTherapeuticClass = r.DrugClassificationSegmentSpecificTherapeuticClass,
                GcnCode = r.DrugClassificationSegmentGcnCode,
                GcnSequenceNumber = r.DrugClassificationSegmentGcnSequenceNumber,
                StandardTherapeuticClass = r.DrugClassificationSegmentStandardTherapeuticClass,
                GenericTherapeuticClass = r.DrugClassificationSegmentGenericTherapeuticClass,
                AhfsTherapeuticClass = r.DrugClassificationSegmentAhfsTherapeuticClass,
                OrangeBookCode = r.DrugClassificationSegmentOrangeBookCode,
                RouteOfAdministrationCode = r.DrugClassificationSegmentRouteOfAdministrationCode,
                DrugFormCodeUnitOfMeasure = r.DrugClassificationSegmentDrugFormCodeUnitOfMeasure,
                DeaCode = r.DrugClassificationSegmentDeaCode,
                MaintenanceDrugIndicator = r.DrugClassificationSegmentMaintenanceDrugIndicator,
                UnitOfUseIndicator = r.DrugClassificationSegmentUnitOfUseIndicator,
                RepackageIndicator = r.DrugClassificationSegmentRepackageIndicator,
                UnitDoseIndicator = r.DrugClassificationSegmentUnitDoseIndicator,
                DesiDrugIndicator = r.DrugClassificationSegmentDesiDrugIndicator,
                DrugObsoleteDate = r.DrugClassificationSegmentDrugObsoleteDate,
                MedispanGpi = r.DrugClassificationSegmentMedispanGpi,
                ReservedForFutureUse = r.DrugClassificationSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Pharmacy Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;PharmacySegment&gt;</returns>
        public static IEnumerable<PharmacySegment> GetPharmacySegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new PharmacySegment()
            {
                PhysicalAddressLine1 = r.PharmacySegmentPhysicalAddressLine1,
                PhysicalAddressLine2 = r.PharmacySegmentPhysicalAddressLine2,
                PhysicalCity = r.PharmacySegmentPhysicalCity,
                PhysicalState = r.PharmacySegmentPhysicalState,
                PhysicalZipCode = r.PharmacySegmentPhysicalZipCode,
                PhoneNumber = r.PharmacySegmentPhoneNumber,
                ReservedForFutureUse1 = r.PharmacySegmentReservedForFutureUse1,
                FaxNumber = r.PharmacySegmentFaxNumber,
                FederalLicenseNumber = r.PharmacySegmentFederalLicenseNumber,
                FederalTaxIdNumber = r.PharmacySegmentFederalTaxIdNumber,
                StateLicenseNumber = r.PharmacySegmentStateLicenseNumber,
                StateTaxIdNumber = r.PharmacySegmentStateTaxIdNumber,
                StateMedicaidNumber = r.PharmacySegmentStateMedicaidNumber,
                PharmacyStoreNumber = r.PharmacySegmentPharmacyStoreNumber,
                TestPharmacyFlag = r.PharmacySegmentTestPharmacyFlag,
                PharmacistIdQualifier = r.PharmacySegmentPharmacistIdQualifier,
                PharmacistId = r.PharmacySegmentPharmacistId,
                PrimaryPharmacyDispenserType = r.PharmacySegmentPrimaryPharmacyDispenserType,
                ReservedForFutureUse2 = r.PharmacySegmentReservedForFutureUse2
            });
        }

        /// <summary>
        /// Factory method for Prescriber Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;PrescriberSegment&gt;</returns>
        public static IEnumerable<PrescriberSegment> GetPrescriberSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new PrescriberSegment()
            {
                BusinessActivityCode = r.PrescriberSegmentBusinessActivityCode,
                DrugSchedules = r.PrescriberSegmentDrugSchedules,
                AddressLine1 = r.PrescriberSegmentAddressLine1,
                AddressLine2 = r.PrescriberSegmentAddressLine2,
                AddressLine3 = r.PrescriberSegmentAddressLine3,
                AddressLine4 = r.PrescriberSegmentAddressLine4,
                City = r.PrescriberSegmentCity,
                State = r.PrescriberSegmentState,
                ZipCode = r.PrescriberSegmentZipCode,
                Dea = r.PrescriberSegmentDea,
                Npi = r.PrescriberSegmentNpi,
                PrescriberIdQualifier = r.PrescriberSegmentPrescriberIdQualifier,
                ReservedForFutureUse = r.PrescriberSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Enhanced Prescriber Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;EnhancedPrescriberSegment&gt;</returns>
        public static IEnumerable<EnhancedPrescriberSegment> GetEnhancedPrescriberSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new EnhancedPrescriberSegment()
            {
                PrescriberName = r.EnhancedPrescriberSegmentPrescriberName,
                Dea = r.EnhancedPrescriberSegmentDea,
                Npi = r.EnhancedPrescriberSegmentNpi,
                BusinessActivityCode = r.EnhancedPrescriberSegmentBusinessActivityCode,
                BusinessActivitySubCode = r.EnhancedPrescriberSegmentBusinessActivitySubCode,
                DrugSchedules = r.EnhancedPrescriberSegmentDrugSchedules,
                AddressLine1 = r.EnhancedPrescriberSegmentAddressLine1,
                AddressLine2 = r.EnhancedPrescriberSegmentAddressLine2,
                City = r.EnhancedPrescriberSegmentCity,
                State = r.EnhancedPrescriberSegmentState,
                ZipCode = r.EnhancedPrescriberSegmentZipCode,
                Phone = r.EnhancedPrescriberSegmentPhone,
                FaxNumber = r.EnhancedPrescriberSegmentFaxNumber,
                Credentials = r.EnhancedPrescriberSegmentCredentials,
                PractitionerType = r.EnhancedPrescriberSegmentPractitionerType,
                Specialty1 = r.EnhancedPrescriberSegmentSpecialty1,
                Specialty2 = r.EnhancedPrescriberSegmentSpecialty2,
                StateLicenseNumber1 = r.EnhancedPrescriberSegmentStateLicenseNumber1,
                StateLicenseNumber1State = r.EnhancedPrescriberSegmentStateLicenseNumber1State,
                StateLicenseNumber2 = r.EnhancedPrescriberSegmentStateLicenseNumber2,
                StateLicenseNumber2State = r.EnhancedPrescriberSegmentStateLicenseNumber2State,
                StateLicenseNumber3 = r.EnhancedPrescriberSegmentStateLicenseNumber3,
                StateLicenseNumber3State = r.EnhancedPrescriberSegmentStateLicenseNumber3State,
                MedicaidIdNumber1 = r.EnhancedPrescriberSegmentMedicaidIdNumber1,
                MedicaidIdNumber1State = r.EnhancedPrescriberSegmentMedicaidIdNumber1State,
                MedicaidIdNumber2 = r.EnhancedPrescriberSegmentMedicaidIdNumber2,
                MedicaidIdNumber2State = r.EnhancedPrescriberSegmentMedicaidIdNumber2State,
                MedicaidIdNumber3 = r.EnhancedPrescriberSegmentMedicaidIdNumber3,
                MedicaidIdNumber3State = r.EnhancedPrescriberSegmentMedicaidIdNumber3State,
                TaxId = r.EnhancedPrescriberSegmentTaxId,
                ExpirationDate = r.EnhancedPrescriberSegmentExpirationDate,
                PrescriberIdQualifier = r.EnhancedPrescriberSegmentPrescriberIdQualifier,
                ReservedForFutureUse = r.EnhancedPrescriberSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Workers' Compensation Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;WorkersCompensationSegment&gt;</returns>
        public static IEnumerable<WorkersCompensationSegment> GetWorkersCompensationSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new WorkersCompensationSegment()
            {
                WcDateOfInjury = r.WorkersCompensationSegmentWcDateOfInjury,
                WcClaimNumber = r.WorkersCompensationSegmentWcClaimNumber,
                WcRecordClaimNumberInfoOnly = r.WorkersCompensationSegmentWcRecordClaimNumberInfoOnly,
                WcRecordAdjustorCode = r.WorkersCompensationSegmentWcRecordAdjustorCode,
                WcEmployerName = r.WorkersCompensationSegmentWcEmployerName,
                WcEmployerAddress1 = r.WorkersCompensationSegmentWcEmployerAddress1,
                WcEmployerAddress2 = r.WorkersCompensationSegmentWcEmployerAddress2,
                WcEmployerCity = r.WorkersCompensationSegmentWcEmployerCity,
                WcEmployerState = r.WorkersCompensationSegmentWcEmployerState,
                WcEmployerZipCode = r.WorkersCompensationSegmentWcEmployerZipCode,
                WcEmployerPhoneNumber = r.WorkersCompensationSegmentWcEmployerPhoneNumber,
                WcRecordTherapyCategoryCode1 = r.WorkersCompensationSegmentWcRecordTherapyCategoryCode1,
                WcRecordTherapyCategoryCode2 = r.WorkersCompensationSegmentWcRecordTherapyCategoryCode2,
                WcRecordTherapyCategoryCode3 = r.WorkersCompensationSegmentWcRecordTherapyCategoryCode3,
                WcRecordTherapyCategoryCode4 = r.WorkersCompensationSegmentWcRecordTherapyCategoryCode4,
                WcRecordTherapyCategoryCode5 = r.WorkersCompensationSegmentWcRecordTherapyCategoryCode5,
                WcRecordTerminationDate = r.WorkersCompensationSegmentWcRecordTerminationDate,
                ReservedForFutureUse = r.WorkersCompensationSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Claim Balances Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;ClaimBalancesSegment&gt;</returns>
        public static IEnumerable<ClaimBalancesSegment> GetClaimBalancesSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new ClaimBalancesSegment()
            {
                IndividualDeductibleAmount = r.ClaimBalancesSegmentIndividualDeductibleAmount,
                IndividualMemberAmount = r.ClaimBalancesSegmentIndividualMemberAmount,
                IndividualSponsorAmount = r.ClaimBalancesSegmentIndividualSponsorAmount,
                IndividualStartingDeductibleAccumulation =
                    r.ClaimBalancesSegmentIndividualStartingDeductibleAccumulation,
                IndividualEndingDeductibleAccumulation = r.ClaimBalancesSegmentIndividualEndingDeductibleAccumulation,
                IndividualRemainingDeductibleAmount = r.ClaimBalancesSegmentIndividualRemainingDeductibleAmount,
                IndividualStartingMemberAccumulation = r.ClaimBalancesSegmentIndividualStartingMemberAccumulation,
                IndividualEndingMemberAccumulation = r.ClaimBalancesSegmentIndividualEndingMemberAccumulation,
                IndividualStartingSponsorAccumulation = r.ClaimBalancesSegmentIndividualStartingSponsorAccumulation,
                IndividualEndingSponsorAccumulation = r.ClaimBalancesSegmentIndividualEndingSponsorAccumulation,
                IndividualStartingTierLevel = r.ClaimBalancesSegmentIndividualStartingTierLevel,
                IndividualEndingTierLevel = r.ClaimBalancesSegmentIndividualEndingTierLevel,
                FamilyDeductibleAmount = r.ClaimBalancesSegmentFamilyDeductibleAmount,
                FamilyMemberAmount = r.ClaimBalancesSegmentFamilyMemberAmount,
                FamilySponsorAmount = r.ClaimBalancesSegmentFamilySponsorAmount,
                FamilyStartingDeductibleAccumulation = r.ClaimBalancesSegmentFamilyStartingDeductibleAccumulation,
                FamilyEndingDeductibleAccumulation = r.ClaimBalancesSegmentFamilyEndingDeductibleAccumulation,
                FamilyRemainingDeductibleAmount = r.ClaimBalancesSegmentFamilyRemainingDeductibleAmount,
                FamilyStartingMemberAccumulation = r.ClaimBalancesSegmentFamilyStartingMemberAccumulation,
                FamilyEndingMemberAccumulation = r.ClaimBalancesSegmentFamilyEndingMemberAccumulation,
                FamilyStartingSponsorAccumulation = r.ClaimBalancesSegmentFamilyStartingSponsorAccumulation,
                FamilyEndingSponsorAccumulation = r.ClaimBalancesSegmentFamilyEndingSponsorAccumulation,
                FamilyStartingTierLevel = r.ClaimBalancesSegmentFamilyStartingTierLevel,
                FamilyEndingTierLevel = r.ClaimBalancesSegmentFamilyEndingTierLevel,
                CardValue = r.ClaimBalancesSegmentCardValue,
                RebateAdjustment = r.ClaimBalancesSegmentRebateAdjustment,
                ReservedForFutureUse = r.ClaimBalancesSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Paper Claim Info Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;PaperClaimInfoSegment&gt;</returns>
        public static IEnumerable<PaperClaimInfoSegment> GetPaperClaimInfoSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new PaperClaimInfoSegment()
            {
                UserId = r.PaperClaimInfoSegmentUserId,
                TerminalId = r.PaperClaimInfoSegmentTerminalId,
                ReceivedDateNumber1 = r.PaperClaimInfoSegmentReceivedDateNumber1,
                ReceivedDateNumber2 = r.PaperClaimInfoSegmentReceivedDateNumber2,
                ReferenceCode = r.PaperClaimInfoSegmentReferenceCode,
                ReservedForFutureUse = r.PaperClaimInfoSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Plan Codes Used Segment
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;PlanCodesUsedSegment&gt;</returns>
        public static IEnumerable<PlanCodesUsedSegment> GetPlanCodesUsedSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new PlanCodesUsedSegment()
            {
                LineOfBusinessCode = r.PlanCodesUsedSegmentLineOfBusinessCode,
                PlanNetworkCode = r.PlanCodesUsedSegmentPlanNetworkCode,
                MarginNetworkCode = r.PlanCodesUsedSegmentMarginNetworkCode,
                CommonFormularyCode = r.PlanCodesUsedSegmentCommonFormularyCode,
                PlanFormulaCode = r.PlanCodesUsedSegmentPlanFormulaCode,
                PharmacyFormulaCode = r.PlanCodesUsedSegmentPharmacyFormulaCode,
                CommonMacCode = r.PlanCodesUsedSegmentCommonMacCode,
                CopayCode = r.PlanCodesUsedSegmentCopayCode,
                Level2MessagingCode = r.PlanCodesUsedSegmentLevel2MessagingCode,
                MemberPlanCode = r.PlanCodesUsedSegmentMemberPlanCode,
                PlanCommonMacCode = r.PlanCodesUsedSegmentPlanCommonMacCode,
                ReservedForFutureUse = r.PlanCodesUsedSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Transaction Messaging Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;TransactionMessagingSegment&gt;</returns>
        public static IEnumerable<TransactionMessagingSegment> GetTransactionMessagingSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new TransactionMessagingSegment()
            {
                TransactionMessage = r.TransactionMessagingSegmentTransactionMessage
            });
        }

        /// <summary>
        /// Factory method for Submitted Member Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;SubmittedMemberSegment&gt;</returns>
        public static IEnumerable<SubmittedMemberSegment> GetSubmittedMemberSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new SubmittedMemberSegment()
            {
                SubmittedCardholderLastName = r.SubmittedMemberSegmentSubmittedCardholderLastName,
                SubmittedPatientFirstName = r.SubmittedMemberSegmentSubmittedPatientFirstName,
                SubmittedPatientDateofBirth = r.SubmittedMemberSegmentSubmittedPatientDateofBirth,
                SubmittedGender = r.SubmittedMemberSegmentSubmittedGender,
                SubmittedPatientEmailAddress = r.SubmittedMemberSegmentSubmittedPatientEmailAddress,
                ReservedForFutureUse = r.SubmittedMemberSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Enhanced Submitted Member Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;EnhancedSubmittedMemberSegment&gt;</returns>
        public static IEnumerable<EnhancedSubmittedMemberSegment> GetEnhancedSubmittedMemberSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new EnhancedSubmittedMemberSegment()
            {
                SubmittedCardholderLastName = r.EnhancedSubmittedMemberSegmentSubmittedCardholderLastName,
                SubmittedPatientFirstName = r.EnhancedSubmittedMemberSegmentSubmittedPatientFirstName,
                SubmittedPatientDateOfBirth = r.EnhancedSubmittedMemberSegmentSubmittedPatientDateOfBirth,
                SubmittedGender = r.EnhancedSubmittedMemberSegmentSubmittedGender,
                SubmittedPatientEmailAddress = r.EnhancedSubmittedMemberSegmentSubmittedPatientEmailAddress,
                SubmittedPatientStreetAddress = r.EnhancedSubmittedMemberSegmentSubmittedPatientStreetAddress,
                SubmittedPatientCityAddress = r.EnhancedSubmittedMemberSegmentSubmittedPatientCityAddress,
                PatientStateProvinceAddress = r.EnhancedSubmittedMemberSegmentPatientStateProvinceAddress,
                SubmittedPatientZipPostalCode = r.EnhancedSubmittedMemberSegmentSubmittedPatientZipPostalCode,
                FutureUse = r.EnhancedSubmittedMemberSegmentFutureUse
            });
        }

        /// <summary>
        /// Factory method for Addtl Submitted Values Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;AddtlSubmittedValuesSegment&gt;</returns>
        public static IEnumerable<AddtlSubmittedValuesSegment> GetAddtlSubmittedValuesSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new AddtlSubmittedValuesSegment()
            {
                SubmittedNdcNumber = r.AddtlSubmittedValuesSegmentSubmittedNdcNumber,
                SubmittedCardholderId = r.AddtlSubmittedValuesSegmentSubmittedCardholderId,
                PrescriptionOriginCode = r.AddtlSubmittedValuesSegmentPrescriptionOriginCode,
                PrimaryOtherPayerIdQualifier = r.AddtlSubmittedValuesSegmentPrimaryOtherPayerIdQualifier,
                PrimaryOtherPayerId = r.AddtlSubmittedValuesSegmentPrimaryOtherPayerId,
                SubmittedNcpdpVersion = r.AddtlSubmittedValuesSegmentSubmittedNcpdpVersion,
                SubmittedGroupNumber = r.AddtlSubmittedValuesSegmentSubmittedGroupNumber,
                SubmittedBin = r.AddtlSubmittedValuesSegmentSubmittedBin,
                SubmittedTransactionType = r.AddtlSubmittedValuesSegmentSubmittedTransactionType,
                SoftwareVendorId = r.AddtlSubmittedValuesSegmentSoftwareVendorId,
                ReservedForFutureUse = r.AddtlSubmittedValuesSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Patient Pay Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;PatientPaySegment&gt;</returns>
        public static IEnumerable<PatientPaySegment> GetPatientPaySegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new PatientPaySegment()
            {
                AmtAttributedToProcessorFee = r.PatientPaySegmentAmtAttributedToProcessorFee,
                AmountOfCoinsurance = r.PatientPaySegmentAmountOfCoinsurance,
                ReservedForFutureDefinedField = r.PatientPaySegmentReservedForFutureDefinedField,
                ReservedForFuturePricingField1 = r.PatientPaySegmentReservedForFuturePricingField1,
                ReservedForFuturePricingField2 = r.PatientPaySegmentReservedForFuturePricingField2,
                AmtAttributedToProductSelectionBrandDrug = r.PatientPaySegmentAmtAttributedToProductSelectionBrandDrug,
                AmtAttributedToProductSelectionNonPreferredFormularySelection =
                    r.PatientPaySegmentAmtAttributedToProductSelectionNonPreferredFormularySelection,
                AmtAttributedToProductSelectionBrandNonPreferredFormularySelection = r
                    .PatientPaySegmentAmtAttributedToProductSelectionBrandNonPreferredFormularySelection,
                ReservedForFuturePricingField3 = r.PatientPaySegmentReservedForFuturePricingField3,
                ReservedForFuturePricingField4 = r.PatientPaySegmentReservedForFuturePricingField4,
                AmountAttributedToSalesTax = r.PatientPaySegmentAmountAttributedToSalesTax,
                ReservedForFutureUse = r.PatientPaySegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Submitted COB Information Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;SubmittedCobClaimInformationSegment&gt;</returns>
        public static IEnumerable<SubmittedCobInformationSegment> GetSubmittedCobClaimInformationSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new SubmittedCobInformationSegment()
            {
                CoordinationOfBenefitsOtherPaymentsCount =
                    r.SubmittedCobClaimInformationSegmentCoordinationOfBenefitsOtherPaymentsCount,
                OtherPayerCoverageTypePrimarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerCoverageTypePrimarySubmission,
                OtherPayerIdQualifierPrimarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerIdQualifierPrimarySubmission,
                OtherPayerIdBinPrimarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerIdBinPrimarySubmission,
                OtherPayerDatePrimarySubmission = r.SubmittedCobClaimInformationSegmentOtherPayerDatePrimarySubmission,
                RejectCountPrimarySubmission = r.SubmittedCobClaimInformationSegmentRejectCountPrimarySubmission,
                RejectCodePrimarySubmission1 = r.SubmittedCobClaimInformationSegmentRejectCodePrimarySubmission1,
                RejectCodePrimarySubmission2 = r.SubmittedCobClaimInformationSegmentRejectCodePrimarySubmission2,
                RejectCodePrimarySubmission3 = r.SubmittedCobClaimInformationSegmentRejectCodePrimarySubmission3,
                OtherPayerPatientResponsibilityAmountQualifierPrimarySubmission = r
                    .SubmittedCobClaimInformationSegmentOtherPayerPatientResponsibilityAmountQualifierPrimarySubmission,
                OtherPayerPatientResponsibilityAmountSumPrimarySubmission = r
                    .SubmittedCobClaimInformationSegmentOtherPayerPatientResponsibilityAmountSumPrimarySubmission,
                OtherPayerAmountPaidSumPrimarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerAmountPaidSumPrimarySubmission,
                OtherPayerCoverageTypeSecondarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerCoverageTypeSecondarySubmission,
                OtherPayerIdQualifierSecondarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerIdQualifierSecondarySubmission,
                OtherPayerIdBinSecondarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerIdBinSecondarySubmission,
                OtherPayerDateSecondarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerDateSecondarySubmission,
                RejectCountSecondarySubmission = r.SubmittedCobClaimInformationSegmentRejectCountSecondarySubmission,
                RejectCodeSecondarySubmission1 = r.SubmittedCobClaimInformationSegmentRejectCodeSecondarySubmission1,
                RejectCodeSecondarySubmission2 = r.SubmittedCobClaimInformationSegmentRejectCodeSecondarySubmission2,
                RejectCodeSecondarySubmission3 = r.SubmittedCobClaimInformationSegmentRejectCodeSecondarySubmission3,
                OtherPayerPatientResponsibilityAmountQualifierSecondarySubmission = r
                    .SubmittedCobClaimInformationSegmentOtherPayerPatientResponsibilityAmountQualifierSecondarySubmission,
                OtherPayerPatientResponsibilityAmountSumSecondarySubmission = r
                    .SubmittedCobClaimInformationSegmentOtherPayerPatientResponsibilityAmountSumSecondarySubmission,
                OtherPayerAmountPaidSumSecondarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerAmountPaidSumSecondarySubmission,
                Submission = r.SubmittedCobClaimInformationSegmentSubmission,
                OtherPayerIdQualifierTertiarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerIdQualifierTertiarySubmission,
                OtherPayerIdBinTertiarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerIdBinTertiarySubmission,
                OtherPayerDateTertiarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerDateTertiarySubmission,
                RejectCountTertiarySubmission = r.SubmittedCobClaimInformationSegmentRejectCountTertiarySubmission,
                RejectCodeTertiarySubmission1 = r.SubmittedCobClaimInformationSegmentRejectCodeTertiarySubmission1,
                RejectCodeTertiarySubmission2 = r.SubmittedCobClaimInformationSegmentRejectCodeTertiarySubmission2,
                RejectCodeTertiarySubmission3 = r.SubmittedCobClaimInformationSegmentRejectCodeTertiarySubmission3,
                OtherPayerPatientResponsibilityAmountQualifierTertiarySubmission = r
                    .SubmittedCobClaimInformationSegmentOtherPayerPatientResponsibilityAmountQualifierTertiarySubmission,
                OtherPayerPatientResponsibilityAmountSumTertiarySubmission = r
                    .SubmittedCobClaimInformationSegmentOtherPayerPatientResponsibilityAmountSumTertiarySubmission,
                OtherPayerAmountPaidSumTertiarySubmission =
                    r.SubmittedCobClaimInformationSegmentOtherPayerAmountPaidSumTertiarySubmission,
                OtherPayerBinNamePrimary = r.SubmittedCobClaimInformationSegmentOtherPayerBinNamePrimary,
                OtherPayerBinNameSecondary = r.SubmittedCobClaimInformationSegmentOtherPayerBinNameSecondary,
                OtherPayerBinNameTertiary = r.SubmittedCobClaimInformationSegmentOtherPayerBinNameTertiary,
                BenefitStageInformationPresentedPrimary =
                    r.SubmittedCobClaimInformationSegmentBenefitStageInformationPresentedPrimary,
                BenefitStageInformationPresentedSecondary =
                    r.SubmittedCobClaimInformationSegmentBenefitStageInformationPresentedSecondary,
                BenefitStageInformationPresentedTertiary =
                    r.SubmittedCobClaimInformationSegmentBenefitStageInformationPresentedTertiary,
                FutureUse = r.SubmittedCobClaimInformationSegmentFutureUse
            });
        }

        /// <summary>
        /// Factory method for Pharmacy Pricing Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;PharmacyPricingSegment&gt;</returns>
        public static IEnumerable<PharmacyPricingSegment> GetPharmacyPricingSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new PharmacyPricingSegment()
            {
                PharmacyIngredientCost = r.PharmacyPricingSegmentPharmacyIngredientCost,
                PharmacyDispensingFee = r.PharmacyPricingSegmentPharmacyDispensingFee,
                PharmacySalesTax = r.PharmacyPricingSegmentPharmacySalesTax,
                PharmacyGrossAmount = r.PharmacyPricingSegmentPharmacyGrossAmount,
                PharmacyCopayAmount = r.PharmacyPricingSegmentPharmacyCopayAmount,
                PharmacyDueAmount = r.PharmacyPricingSegmentPharmacyDueAmount,
                PharmacyBasisOfCost = r.PharmacyPricingSegmentPharmacyBasisOfCost,
                PharmacyBasisOfReimbursement = r.PharmacyPricingSegmentPharmacyBasisOfReimbursement,
                PharmacyCalculatedAmount = r.PharmacyPricingSegmentPharmacyCalculatedAmount,
                ProcessorFee = r.PharmacyPricingSegmentProcessorFee,
                ReservedForFutureUse = r.PharmacyPricingSegmentReservedForFutureUse
            });
        }

        /// <summary>
        /// Factory method for Addtl. Submitted Pharmacy Pricing Segments
        /// </summary>
        /// <param name="container">Raw Claim Records</param>
        /// <returns>IEnumerable&lt;AddtlSubmittedPharmacyPricingSegment&gt;</returns>
        public static IEnumerable<AddtlSubmittedPharmacyPricingSegment> GetAddtlSubmittedPharmacyPricingSegments(
            this IEnumerable<RawClaimRecord> container)
        {
            return container.Select(r => new AddtlSubmittedPharmacyPricingSegment()
            {
                SubmittedUc = r.AddtlSubmittedPharmacyPricingSegmentSubmittedUc,
                SubmittedIngredientCost = r.AddtlSubmittedPharmacyPricingSegmentSubmittedIngredientCost,
                SubmittedDispensingFee = r.AddtlSubmittedPharmacyPricingSegmentSubmittedDispensingFee,
                SubmittedSalesTax = r.AddtlSubmittedPharmacyPricingSegmentSubmittedSalesTax,
                SubmittedGrossAmount = r.AddtlSubmittedPharmacyPricingSegmentSubmittedGrossAmount,
                SubmittedCopayAmount = r.AddtlSubmittedPharmacyPricingSegmentSubmittedCopayAmount,
                ReservedForFutureUse = r.AddtlSubmittedPharmacyPricingSegmentReservedForFutureUse
            });
        }
    }
}