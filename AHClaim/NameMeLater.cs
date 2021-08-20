using FileHelpers;

namespace AHClaim
{
    [FixedLengthRecord(FixedMode.AllowVariableLength)]
    public class NameMeLater
    {
        #region Header Segment

        [FieldFixedLength(2)] public string HeaderSegmentClaimFileRecordIndicator { get; set; }
        [FieldFixedLength(2)] public string HeaderSegmentVersionNumber { get; set; }
        [FieldFixedLength(2)] public string HeaderSegmentMinorVersionNumber { get; set; }

        #endregion

        #region Claim Segment

        [FieldFixedLength(1)] public string ClaimSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string ClaimSegmentIdentifier { get; set; }
        [FieldFixedLength(20)] public string ClaimSegmentClaimAuthorizationNumber { get; set; }
        [FieldFixedLength(20)] public string ClaimSegmentOriginalClaimAuthorizationNumber { get; set; }
        [FieldFixedLength(20)] public string ClaimSegmentReversalClaimAuthorizationNumber { get; set; }
        [FieldFixedLength(8)] public string ClaimSegmentDateProcessed { get; set; }
        [FieldFixedLength(8)] public string ClaimSegmentTimeProcessed { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentRejectionFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentDuplicateFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentReversalFlag { get; set; }
        [FieldFixedLength(15)] public string ClaimSegmentPharmacyNcpdpidNumber { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentPharmacyName { get; set; }
        [FieldFixedLength(4)] public string ClaimSegmentPharmacyChainNumber { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentPharmacyChainName { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentPharmacyType { get; set; }
        [FieldFixedLength(3)] public string ClaimSegmentCarrierCode { get; set; }
        [FieldFixedLength(3)] public string ClaimSegmentSubmittedCarrierCode { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentTpaBrokerCode { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentTpaBrokerName { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentSponsorCode { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentSponsorName { get; set; }
        [FieldFixedLength(15)] public string ClaimSegmentGroupNumber { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentGroupName { get; set; }
        [FieldFixedLength(20)] public string ClaimSegmentCardholderIdNumber { get; set; }
        [FieldFixedLength(3)] public string ClaimSegmentPatientPersonCode { get; set; }
        [FieldFixedLength(15)] public string ClaimSegmentPatientLastName { get; set; }
        [FieldFixedLength(12)] public string ClaimSegmentPatientFirstName { get; set; }
        [FieldFixedLength(15)] public string ClaimSegmentPrescriberId { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentPrescriberName { get; set; }
        [FieldFixedLength(8)] public string ClaimSegmentDateFilled { get; set; }
        [FieldFixedLength(8)] public string ClaimSegmentDateWritten { get; set; }
        [FieldFixedLength(12)] public string ClaimSegmentRxNumber { get; set; }
        [FieldFixedLength(2)] public string ClaimSegmentFillNumber { get; set; }
        [FieldFixedLength(2)] public string ClaimSegmentNumberOfRefillsAuthorized { get; set; }
        [FieldFixedLength(19)] public string ClaimSegmentDrugNdcNumber { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentDrugName { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentDrugStrengthDescription { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentDrugDoseFormDescription { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentSubmittedCompoundCode { get; set; }
        [FieldFixedLength(11)] public string ClaimSegmentSubmittedRouteOfAdmin { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentDrugProcessedSigCode { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentDrugMonyCode { get; set; }
        [FieldFixedLength(12)] public string ClaimSegmentQuantityDispensed { get; set; }
        [FieldFixedLength(4)] public string ClaimSegmentDaysSupply { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentDawCode { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentPlanIngredientCost { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentPlanDispensingFee { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentPlanSalesTax { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentIncentiveFee { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentClaimSegmentProcessorFee { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentPlanGrossAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentOtherPayerAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentTotalPatientPayAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentPlanPharmacyAmount { get; set; }
        [FieldFixedLength(3)] public string ClaimSegmentPlanBasisOfCost { get; set; }
        [FieldFixedLength(3)] public string ClaimSegmentPlanBasisOfReimbursement { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentCalculatedAwp { get; set; }
        [FieldFixedLength(2)] public string ClaimSegmentSubmissionClarificationCode { get; set; }
        [FieldFixedLength(2)] public string ClaimSegmentOtherCoverageCode { get; set; }
        [FieldFixedLength(4)] public string ClaimSegmentMedicaidCode { get; set; }
        [FieldFixedLength(35)] public string ClaimSegmentMedicaidName { get; set; }
        [FieldFixedLength(15)] public string ClaimSegmentCouponNumber { get; set; }
        [FieldFixedLength(15)] public string ClaimSegmentPharmacyNationalProviderId { get; set; }
        [FieldFixedLength(2)] public string ClaimSegmentPharmacyIdQualifiersubmitted { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentCalculatedFedmac { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentCalculatedAwpSource { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentCalculatedWac { get; set; }
        [FieldFixedLength(3)] public string ClaimSegmentCouponActualUseNumber { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentProcessedSingleSourceGenericIndicator { get; set; }
        [FieldFixedLength(20)] public string ClaimSegmentManufacturerName { get; set; }
        [FieldFixedLength(12)] public string ClaimSegmentAdjudicatedUnitPrice { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentPreCopayRoundingAmount { get; set; }
        [FieldFixedLength(1)] public string ClaimSegmentNumberOfCouponUses { get; set; }
        [FieldFixedLength(3)] public string ClaimSegmentCombinedCouponUses { get; set; }
        [FieldFixedLength(20)] public string ClaimSegmentRejectReprocessOriginalAuthorizationNumber { get; set; }
        [FieldFixedLength(119)] public string ClaimSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Claim Indicator Segment

        [FieldFixedLength(1)] public string ClaimIndicatorSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string ClaimIndicatorSegmentIdentifier { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentPaperClaimFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentDirectReimbursementFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentTestClaimFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentBatchProcessedFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentOtherProcessorFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentFormularyDrugFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentNetworkPharmacyFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentNetworkPhysicianFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentShoeboxClaimFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentProductQtyClaimFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentStarterDoseFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentPriorAuthFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentDurFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentDurOverrideFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentIgCopayFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentMultiIngredCompoundFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentPartialFillDispensingStatus { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentMedicaidFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentForceUcFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentNdcRemapped { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentForcePharmacyDue { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentAdditionalLowerOfStateRateUsed { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentPosMedicaidFlag { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentAlternateProcessingBypass { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentTaxExemptIndicator { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentAlternateDrugRecord { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentClaimRoundingUsed { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentMedicalClaimIndicator { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentCompensableClaimIndicator { get; set; }
        [FieldFixedLength(1)] public string ClaimIndicatorSegmentDataFeedTransaction { get; set; }
        [FieldFixedLength(27)] public string ClaimIndicatorSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Addtl. Patient Info Segment

        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string AddtlPatientInfoSegmentIdentifier { get; set; }
        [FieldFixedLength(15)] public string AddtlPatientInfoSegmentCardholderLastName { get; set; }
        [FieldFixedLength(12)] public string AddtlPatientInfoSegmentCardholderFirstName { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentPatientMiddleInitial { get; set; }
        [FieldFixedLength(3)] public string AddtlPatientInfoSegmentPatientNameSuffix { get; set; }
        [FieldFixedLength(35)] public string AddtlPatientInfoSegmentAddressLine1 { get; set; }
        [FieldFixedLength(35)] public string AddtlPatientInfoSegmentAddressLine2 { get; set; }
        [FieldFixedLength(18)] public string AddtlPatientInfoSegmentCity { get; set; }
        [FieldFixedLength(2)] public string AddtlPatientInfoSegmentState { get; set; }
        [FieldFixedLength(9)] public string AddtlPatientInfoSegmentZipCode { get; set; }
        [FieldFixedLength(10)] public string AddtlPatientInfoSegmentPhoneNumber { get; set; }
        [FieldFixedLength(8)] public string AddtlPatientInfoSegmentEffectiveDate { get; set; }
        [FieldFixedLength(8)] public string AddtlPatientInfoSegmentTerminationDate { get; set; }
        [FieldFixedLength(8)] public string AddtlPatientInfoSegmentDateOfBirth { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentGenderCode { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentRelationshipCode { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentCoverageCode { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentReservedForFutureUse1 { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentStudentFlag { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentReservedForFutureUse2 { get; set; }
        [FieldFixedLength(20)] public string AddtlPatientInfoSegmentLocationCode { get; set; }
        [FieldFixedLength(35)] public string AddtlPatientInfoSegmentLocationName { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentSecondaryCoverage { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentPharmacyLockIn { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentPhysicianLockIn { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentTestMemberFlag { get; set; }
        [FieldFixedLength(10)] public string AddtlPatientInfoSegmentEligibilityCreatedByUserId { get; set; }
        [FieldFixedLength(8)] public string AddtlPatientInfoSegmentEligibilityCreatedDate { get; set; }
        [FieldFixedLength(10)] public string AddtlPatientInfoSegmentEligibilityModifiedByUserId { get; set; }
        [FieldFixedLength(8)] public string AddtlPatientInfoSegmentEligibilityModifiedDate { get; set; }
        [FieldFixedLength(15)] public string AddtlPatientInfoReservedForFutureUse3 { get; set; }

        #endregion

        #region Claim Reject Segment

        [FieldFixedLength(1)] public string ClaimRejectSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string ClaimRejectSegmentIdentifier { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentRejectCode1 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentRejectCode2 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentRejectCode3 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentRejectCode4 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentRejectCode5 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentEccRejectCode1 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentEccRejectCode2 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentEccRejectCode3 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentEccRejectCode4 { get; set; }
        [FieldFixedLength(3)] public string ClaimRejectSegmentEccRejectCode5 { get; set; }

        #endregion

        #region Prior Authorization Segment

        [FieldFixedLength(1)] public string PriorAuthorizationSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string PriorAuthorizationSegmentIdentifier { get; set; }
        [FieldFixedLength(2)] public string PriorAuthorizationSegmentPaTypeSubmitted { get; set; }
        [FieldFixedLength(11)] public string PriorAuthorizationSegmentPaNumberSubmitted { get; set; }
        [FieldFixedLength(11)] public string PriorAuthorizationSegmentActualPaNumberUsed { get; set; }
        [FieldFixedLength(1)] public string PriorAuthorizationSegmentPaTypeManualAuto { get; set; }
        [FieldFixedLength(8)] public string PriorAuthorizationSegmentPaEffectiveDate { get; set; }
        [FieldFixedLength(8)] public string PriorAuthorizationSegmentPaTerminationDate { get; set; }
        [FieldFixedLength(35)] public string PriorAuthorizationSegmentPaDescription { get; set; }

        [FieldFixedLength(30)]
        public string PriorAuthorizationSegmentPriorAuthorizationSegmentReservedForFutureUse { get; set; }

        #endregion

        #region DUR Segment

        [FieldFixedLength(1)] public string DurSegmentSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string DurSegmentSegmentIdentifier { get; set; }
        [FieldFixedLength(2)] public string DurSegmentDur1ConflictCode { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur1SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur1HitDisposition { get; set; }
        [FieldFixedLength(20)] public string DurSegmentDur1ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string DurSegmentDur2ConflictCode { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur2SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur2HitDisposition { get; set; }
        [FieldFixedLength(20)] public string DurSegmentDur2ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string DurSegmentDur3ConflictCode { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur3SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur3HitDisposition { get; set; }
        [FieldFixedLength(20)] public string DurSegmentDur3ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string DurSegmentDur4ConflictCode { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur4SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur4HitDisposition { get; set; }
        [FieldFixedLength(20)] public string DurSegmentDur4ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string DurSegmentDur5ConflictCode { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur5SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string DurSegmentDur5HitDisposition { get; set; }
        [FieldFixedLength(20)] public string DurSegmentDur5ConflictingAuthorizationNumber { get; set; }

        #endregion

        #region Submitted DUR Override Segment

        public string SubmittedDurOverrideSegmentSeparatorCharacter { get; set; }
        public string SubmittedDurOverrideSegmentIdentifier { get; set; }
        public string SubmittedDurOverrideSegmentReasonForServiceConflict1 { get; set; }
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention1 { get; set; }
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome1 { get; set; }
        public string SubmittedDurOverrideSegmentReasonForServiceConflict2 { get; set; }
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention2 { get; set; }
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome2 { get; set; }
        public string SubmittedDurOverrideSegmentReasonForServiceConflict3 { get; set; }
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention3 { get; set; }
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome3 { get; set; }
        public string SubmittedDurOverrideSegmentReasonForServiceConflict4 { get; set; }
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention4 { get; set; }
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome4 { get; set; }
        public string SubmittedDurOverrideSegmentReasonForServiceConflict5 { get; set; }
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention5 { get; set; }
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome5 { get; set; }

        #endregion

        #region Drug Classification Segment

        [FieldFixedLength(1)] public string DrugClassificationSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string DrugClassificationSegmentIdentifier { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentCategoryCode { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentClassCode { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentGc1Code { get; set; }
        [FieldFixedLength(2)] public string DrugClassificationSegmentGc2Code { get; set; }
        [FieldFixedLength(3)] public string DrugClassificationSegmentGc3Code { get; set; }
        [FieldFixedLength(4)] public string DrugClassificationSegmentGc4Code { get; set; }
        [FieldFixedLength(3)] public string DrugClassificationSegmentSpecificTherapeuticClass { get; set; }
        [FieldFixedLength(5)] public string DrugClassificationSegmentGcnCode { get; set; }
        [FieldFixedLength(6)] public string DrugClassificationSegmentGcnSequenceNumber { get; set; }
        [FieldFixedLength(2)] public string DrugClassificationSegmentStandardTherapeuticClass { get; set; }
        [FieldFixedLength(2)] public string DrugClassificationSegmentGenericTherapeuticClass { get; set; }
        [FieldFixedLength(6)] public string DrugClassificationSegmentAhfsTherapeuticClass { get; set; }
        [FieldFixedLength(3)] public string DrugClassificationSegmentOrangeBookCode { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentRouteOfAdministrationCode { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentDrugFormCodeUnitOfMeasure { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentDeaCode { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentMaintenanceDrugIndicator { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentUnitOfUseIndicator { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentRepackageIndicator { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentUnitDoseIndicator { get; set; }
        [FieldFixedLength(1)] public string DrugClassificationSegmentDesiDrugIndicator { get; set; }
        [FieldFixedLength(8)] public string DrugClassificationSegmentDrugObsoleteDate { get; set; }
        [FieldFixedLength(14)] public string DrugClassificationSegmentMedispanGpi { get; set; }
        [FieldFixedLength(11)] public string DrugClassificationReservedForFutureUse { get; set; }

        #endregion

        #region Pharmacy Segment

        [FieldFixedLength(1)] public string PharmacySegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string PharmacySegmentIdentifier { get; set; }
        [FieldFixedLength(35)] public string PharmacySegmentPhysicalAddressLine1 { get; set; }
        [FieldFixedLength(35)] public string PharmacySegmentPhysicalAddressLine2 { get; set; }
        [FieldFixedLength(18)] public string PharmacySegmentPhysicalCity { get; set; }
        [FieldFixedLength(2)] public string PharmacySegmentPhysicalState { get; set; }
        [FieldFixedLength(9)] public string PharmacySegmentPhysicalZipCode { get; set; }
        [FieldFixedLength(10)] public string PharmacySegmentPhoneNumber { get; set; }
        [FieldFixedLength(10)] public string PharmacySegmentReservedForFutureUse1 { get; set; }
        [FieldFixedLength(10)] public string PharmacySegmentFaxNumber { get; set; }
        [FieldFixedLength(12)] public string PharmacySegmentFederalLicenseNumber { get; set; }
        [FieldFixedLength(15)] public string PharmacySegmentFederalTaxIdNumber { get; set; }
        [FieldFixedLength(20)] public string PharmacySegmentStateLicenseNumber { get; set; }
        [FieldFixedLength(15)] public string PharmacySegmentStateTaxIdNumber { get; set; }
        [FieldFixedLength(20)] public string PharmacySegmentStateMedicaidNumber { get; set; }
        [FieldFixedLength(10)] public string PharmacySegmentPharmacyStoreNumber { get; set; }
        [FieldFixedLength(1)] public string PharmacySegmentTestPharmacyFlag { get; set; }
        [FieldFixedLength(2)] public string PharmacySegmentPharmacistIdQualifier { get; set; }
        [FieldFixedLength(15)] public string PharmacySegmentPharmacistId { get; set; }
        [FieldFixedLength(2)] public string PharmacySegmentPrimaryPharmacyDispenserType { get; set; }
        [FieldFixedLength(6)] public string PharmacySegmentReservedForFutureUse2 { get; set; }

        #endregion

        #region Prescriber Segment

        [FieldFixedLength(1)] public string PrescriberSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string PrescriberSegmentIdentifier { get; set; }
        [FieldFixedLength(1)] public string PrescriberSegmentBusinessActivityCode { get; set; }
        [FieldFixedLength(12)] public string PrescriberSegmentDrugSchedules { get; set; }
        [FieldFixedLength(40)] public string PrescriberSegmentAddressLine1 { get; set; }
        [FieldFixedLength(40)] public string PrescriberSegmentAddressLine2 { get; set; }
        [FieldFixedLength(40)] public string PrescriberSegmentAddressLine3 { get; set; }
        [FieldFixedLength(33)] public string PrescriberSegmentAddressLine4 { get; set; }
        [FieldFixedLength(24)] public string PrescriberSegmentCity { get; set; }
        [FieldFixedLength(2)] public string PrescriberSegmentState { get; set; }
        [FieldFixedLength(5)] public string PrescriberSegmentZipCode { get; set; }
        [FieldFixedLength(9)] public string PrescriberSegmentDea { get; set; }
        [FieldFixedLength(10)] public string PrescriberSegmentNpi { get; set; }
        [FieldFixedLength(2)] public string PrescriberSegmentPrescriberIdQualifier { get; set; }
        [FieldFixedLength(4)] public string PrescriberSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Enhanced Prescriber Segment

        [FieldFixedLength(1)] public string EnhancedPrescriberSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentIdentifier { get; set; }
        [FieldFixedLength(35)] public string EnhancedPrescriberSegmentPrescriberName { get; set; }
        [FieldFixedLength(9)] public string EnhancedPrescriberSegmentDea { get; set; }
        [FieldFixedLength(10)] public string EnhancedPrescriberSegmentNpi { get; set; }
        [FieldFixedLength(1)] public string EnhancedPrescriberSegmentBusinessActivityCode { get; set; }
        [FieldFixedLength(1)] public string EnhancedPrescriberSegmentBusinessActivitySubCode { get; set; }
        [FieldFixedLength(12)] public string EnhancedPrescriberSegmentDrugSchedules { get; set; }
        [FieldFixedLength(40)] public string EnhancedPrescriberSegmentAddressLine1 { get; set; }
        [FieldFixedLength(40)] public string EnhancedPrescriberSegmentAddressLine2 { get; set; }
        [FieldFixedLength(24)] public string EnhancedPrescriberSegmentCity { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentState { get; set; }
        [FieldFixedLength(9)] public string EnhancedPrescriberSegmentZipCode { get; set; }
        [FieldFixedLength(10)] public string EnhancedPrescriberSegmentPhone { get; set; }
        [FieldFixedLength(10)] public string EnhancedPrescriberSegmentFaxNumber { get; set; }
        [FieldFixedLength(10)] public string EnhancedPrescriberSegmentCredentials { get; set; }
        [FieldFixedLength(25)] public string EnhancedPrescriberSegmentPractitionerType { get; set; }
        [FieldFixedLength(40)] public string EnhancedPrescriberSegmentSpecialty1 { get; set; }
        [FieldFixedLength(40)] public string EnhancedPrescriberSegmentSpecialty2 { get; set; }
        [FieldFixedLength(15)] public string EnhancedPrescriberSegmentStateLicenseNumber1 { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentStateLicenseNumber1State { get; set; }
        [FieldFixedLength(15)] public string EnhancedPrescriberSegmentStateLicenseNumber2 { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentStateLicenseNumber2State { get; set; }
        [FieldFixedLength(15)] public string EnhancedPrescriberSegmentStateLicenseNumber3 { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentStateLicenseNumber3State { get; set; }
        [FieldFixedLength(15)] public string EnhancedPrescriberSegmentMedicaidIdNumber1 { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentMedicaidIdNumber1State { get; set; }
        [FieldFixedLength(15)] public string EnhancedPrescriberSegmentMedicaidIdNumber2 { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentMedicaidIdNumber2State { get; set; }
        [FieldFixedLength(15)] public string EnhancedPrescriberSegmentMedicaidIdNumber3 { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentMedicaidIdNumber3State { get; set; }
        [FieldFixedLength(9)] public string EnhancedPrescriberSegmentTaxId { get; set; }
        [FieldFixedLength(8)] public string EnhancedPrescriberSegmentExpirationDate { get; set; }
        [FieldFixedLength(2)] public string EnhancedPrescriberSegmentPrescriberIdQualifier { get; set; }
        [FieldFixedLength(99)] public string EnhancedPrescriberSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Workers' Compensation Segment

        [FieldFixedLength(1)] public string WorkersCompensationSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string WorkersCompensationSegmentIdentifier { get; set; }
        [FieldFixedLength(8)] public string WorkersCompensationSegmentWcDateOfInjury { get; set; }
        [FieldFixedLength(14)] public string WorkersCompensationSegmentWcClaimNumber { get; set; }
        [FieldFixedLength(14)] public string WorkersCompensationSegmentWcRecordClaimNumberInfoOnly { get; set; }
        [FieldFixedLength(10)] public string WorkersCompensationSegmentWcRecordAdjustorCode { get; set; }
        [FieldFixedLength(35)] public string WorkersCompensationSegmentWcEmployerName { get; set; }
        [FieldFixedLength(35)] public string WorkersCompensationSegmentWcEmployerAddress1 { get; set; }
        [FieldFixedLength(35)] public string WorkersCompensationSegmentWcEmployerAddress2 { get; set; }
        [FieldFixedLength(18)] public string WorkersCompensationSegmentWcEmployerCity { get; set; }
        [FieldFixedLength(2)] public string WorkersCompensationSegmentWcEmployerState { get; set; }
        [FieldFixedLength(9)] public string WorkersCompensationSegmentWcEmployerZipCode { get; set; }
        [FieldFixedLength(10)] public string WorkersCompensationSegmentWcEmployerPhoneNumber { get; set; }
        [FieldFixedLength(6)] public string WorkersCompensationSegmentWcRecordTherapyCategoryCode1 { get; set; }
        [FieldFixedLength(6)] public string WorkersCompensationSegmentWcRecordTherapyCategoryCode2 { get; set; }
        [FieldFixedLength(6)] public string WorkersCompensationSegmentWcRecordTherapyCategoryCode3 { get; set; }
        [FieldFixedLength(6)] public string WorkersCompensationSegmentWcRecordTherapyCategoryCode4 { get; set; }
        [FieldFixedLength(6)] public string WorkersCompensationSegmentWcRecordTherapyCategoryCode5 { get; set; }
        [FieldFixedLength(8)] public string WorkersCompensationSegmentWcRecordTerminationDate { get; set; }
        [FieldFixedLength(290)] public string WorkersCompensationSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Claim Balances Segment

        [FieldFixedLength(1)] public string ClaimBalancesSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string ClaimBalancesSegmentIdentifier { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualDeductibleAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualMemberAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualSponsorAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualStartingDeductibleAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualEndingDeductibleAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualRemainingDeductibleAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualStartingMemberAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualEndingMemberAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualStartingSponsorAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentIndividualEndingSponsorAccumulation { get; set; }
        [FieldFixedLength(1)] public string ClaimBalancesSegmentIndividualStartingTierLevel { get; set; }
        [FieldFixedLength(1)] public string ClaimBalancesSegmentIndividualEndingTierLevel { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyDeductibleAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyMemberAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilySponsorAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyStartingDeductibleAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyEndingDeductibleAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyRemainingDeductibleAmount { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyStartingMemberAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyEndingMemberAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyStartingSponsorAccumulation { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentFamilyEndingSponsorAccumulation { get; set; }
        [FieldFixedLength(1)] public string ClaimBalancesSegmentFamilyStartingTierLevel { get; set; }
        [FieldFixedLength(1)] public string ClaimBalancesSegmentFamilyEndingTierLevel { get; set; }
        [FieldFixedLength(10)] public string ClaimBalancesSegmentCardValue { get; set; }
        [FieldFixedLength(7)] public string ClaimBalancesSegmentRebateAdjustment { get; set; }
        [FieldFixedLength(73)] public string ClaimBalancesSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Paper Claim Info Segment

        // TODO 

        #endregion

        #region Plan Codes Used Segment

        // TODO 

        #endregion

        #region Transaction Messaging

        // TODO 

        #endregion

        #region Submitted Member Segment

        // TODO 

        #endregion

        #region Enhanced Submitted Member Segment

        // TODO 

        #endregion

        #region Addtl. Submitted Values Segment

        // TODO 

        #endregion

        #region Patient Pay Segment

        [FieldFixedLength(1)] public string PatientPaySegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string PatientPaySegmentIdentifier { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentAmtAttributedToProcessorFee { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentAmountOfCoinsurance { get; set; }
        [FieldFixedLength(2)] public string PatientPaySegmentReservedForFutureDefinedField { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField1 { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField2 { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentAmtAttributedToProductSelectionBrandDrug { get; set; }

        [FieldFixedLength(10)]
        public string PatientPaySegmentAmtAttributedToProductSelectionNonPreferredFormularySelection { get; set; }

        [FieldFixedLength(10)]
        public string PatientPaySegmentAmtAttributedToProductSelectionBrandNonPreferredFormularySelection { get; set; }

        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField3 { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField4 { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentAmountAttributedToSalesTax { get; set; }
        [FieldFixedLength(40)] public string PatientPaySegmentReservedForFutureUse { get; set; }

        #endregion

        /* Revision : this segment contains conflicting attributes
        #region Submitted OCB Information

        public string SubmittedCOBClaimInformationSegmentSeparatorCharacter { get; set; }
        public string SubmittedCOBClaimInformationSegmentIdentifier { get; set; }
        public string CoordinationofBenefitsOtherPaymentsCount { get; set; }
        public string OtherPayerCoverageTypePrimarySubmission { get; set; }
        public string OtherPayerIDQualifierPrimarySubmission { get; set; }
        public string OtherPayerIDBINPrimarySubmission { get; set; }
        public string OtherPayerDate { get; set; }
        public string RejectCountPrimarySubmission { get; set; }
        public string RejectCodePrimarySubmission { get; set; }
        public string RejectCodePrimarySubmission { get; set; }
        public string RejectCodePrimarySubmission { get; set; }
        public string OtherPayerPatientResponsibilityAmountQualifier { get; set; }
        public string OtherPayerPatientResponsibilityAmountSUM { get; set; }
        public string OtherPayerAmountPaidSUM { get; set; }
        public string OtherPayerCoverageTypeSecondarySubmission { get; set; }
        public string OtherPayerIDQualifierSecondarySubmission { get; set; }
        public string OtherPayerIDBINSecondarySubmission { get; set; }
        public string OtherPayerDate { get; set; }
        public string RejectCountSecondarySubmission { get; set; }
        public string RejectCodeSecondarySubmission { get; set; }
        public string RejectCodeSecondarySubmission { get; set; }
        public string RejectCodeSecondarySubmission { get; set; }
        public string OtherPayerPatientResponsibilityAmountQualifier { get; set; }
        public string OtherPayerPatientResponsibilityAmountSUM { get; set; }
        public string OtherPayerAmountPaidSUM { get; set; }
        public string Submission { get; set; }
        public string OtherPayerIDQualifierTertiarySubmission { get; set; }
        public string OtherPayerIDBINTertiarySubmission { get; set; }
        public string OtherPayerDate { get; set; }
        public string RejectCountTertiarySubmission { get; set; }
        public string RejectCodeTertiarySubmission { get; set; }
        public string RejectCodeTertiarySubmission { get; set; }
        public string RejectCodeTertiarySubmission { get; set; }
        public string OtherPayerPatientResponsibilityAmountQualifier { get; set; }
        public string OtherPayerPatientResponsibilityAmountSUM { get; set; }
        public string OtherPayerAmountPaidSUM { get; set; }
        public string OtherPayerBINNamePrimary { get; set; }
        public string OtherPayerBINNameSecondary { get; set; }
        public string OtherPayerBINNameTertiary { get; set; }
        public string BenefitStageInformationPresentedPrimary { get; set; }
        public string BenefitStageInformationPresentedSecondary { get; set; }
        public string BenefitStageInformationPresentedTertiary { get; set; }
        public string SubmittedCOBClaimInformationFutureUse { get; set; }

        #endregion
        */

        #region Pharmacy Pricing Segment

        [FieldFixedLength(1)] public string PharmacyPricingSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string PharmacyPricingSegmentIdentifier { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentPharmacyIngredientCost { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentPharmacyDispensingFee { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentPharmacySalesTax { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentPharmacyGrossAmount { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentPharmacyCopayAmount { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentPharmacyDueAmount { get; set; }
        [FieldFixedLength(3)] public string PharmacyPricingSegmentPharmacyBasisOfCost { get; set; }
        [FieldFixedLength(3)] public string PharmacyPricingSegmentPharmacyBasisOfReimbursement { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentPharmacyCalculatedAmount { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentProcessorFee { get; set; }
        [FieldFixedLength(3)] public string PharmacyPricingReservedForFutureUse { get; set; }

        #endregion

        #region Addtl. Submitted Pharmacy Pricing

        [FieldFixedLength(1)] public string AddtlSubmittedPharmacyPricingSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string AddtlSubmittedPharmacyPricingSegmentIdentifier { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedPharmacyPricingSegmentSubmittedUc { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedPharmacyPricingSegmentSubmittedIngredientCost { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedPharmacyPricingSegmentSubmittedDispensingFee { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedPharmacyPricingSegmentSubmittedSalesTax { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedPharmacyPricingSegmentSubmittedGrossAmount { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedPharmacyPricingSegmentSubmittedCopayAmount { get; set; }
        [FieldFixedLength(24)] public string AddtlSubmittedPharmacyPricingSegmentReservedForFutureUse { get; set; }

        #endregion
    }
}