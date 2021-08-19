using FileHelpers;

namespace AHClaim
{
    [FixedLengthRecord(FixedMode.AllowVariableLength)]
    public class NameMeLater
    {
        #region Header Segment

        [FieldFixedLength(2)] public string ClaimFileRecordIndicator { get; set; }
        [FieldFixedLength(2)] public string VersionNumber { get; set; }
        [FieldFixedLength(2)] public string MinorVersionNumber { get; set; }

        #endregion

        #region Claim Segment

        [FieldFixedLength(1)] public string ClaimSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string ClaimSegmentIdentifier { get; set; }
        [FieldFixedLength(20)] public string ClaimAuthorizationNumber { get; set; }
        [FieldFixedLength(20)] public string OriginalClaimAuthorizationNumber { get; set; }
        [FieldFixedLength(20)] public string ReversalClaimAuthorizationNumber { get; set; }
        [FieldFixedLength(8)] public string DateProcessed { get; set; }
        [FieldFixedLength(8)] public string TimeProcessed { get; set; }
        [FieldFixedLength(1)] public string RejectionFlag { get; set; }
        [FieldFixedLength(1)] public string DuplicateFlag { get; set; }
        [FieldFixedLength(1)] public string ReversalFlag { get; set; }
        [FieldFixedLength(15)] public string PharmacyNcpdpidNumber { get; set; }
        [FieldFixedLength(35)] public string PharmacyName { get; set; }
        [FieldFixedLength(4)] public string PharmacyChainNumber { get; set; }
        [FieldFixedLength(35)] public string PharmacyChainName { get; set; }
        [FieldFixedLength(1)] public string PharmacyType { get; set; }
        [FieldFixedLength(3)] public string CarrierCode { get; set; }
        [FieldFixedLength(3)] public string SubmittedCarrierCode { get; set; }
        [FieldFixedLength(10)] public string TpaBrokerCode { get; set; }
        [FieldFixedLength(35)] public string TpaBrokerName { get; set; }
        [FieldFixedLength(10)] public string SponsorCode { get; set; }
        [FieldFixedLength(35)] public string SponsorName { get; set; }
        [FieldFixedLength(15)] public string GroupNumber { get; set; }
        [FieldFixedLength(35)] public string GroupName { get; set; }
        [FieldFixedLength(20)] public string CardholderIdNumber { get; set; }
        [FieldFixedLength(3)] public string PatientPersonCode { get; set; }
        [FieldFixedLength(15)] public string PatientLastName { get; set; }
        [FieldFixedLength(12)] public string PatientFirstName { get; set; }
        [FieldFixedLength(15)] public string PrescriberId { get; set; }
        [FieldFixedLength(35)] public string PrescriberName { get; set; }
        [FieldFixedLength(8)] public string DateFilled { get; set; }
        [FieldFixedLength(8)] public string DateWritten { get; set; }
        [FieldFixedLength(12)] public string RxNumber { get; set; }
        [FieldFixedLength(2)] public string FillNumber { get; set; }
        [FieldFixedLength(2)] public string NumberOfRefillsAuthorized { get; set; }
        [FieldFixedLength(19)] public string DrugNdcNumber { get; set; }
        [FieldFixedLength(35)] public string DrugName { get; set; }
        [FieldFixedLength(10)] public string DrugStrengthDescription { get; set; }
        [FieldFixedLength(10)] public string DrugDoseFormDescription { get; set; }
        [FieldFixedLength(1)] public string SubmittedCompoundCode { get; set; }
        [FieldFixedLength(11)] public string SubmittedRouteOfAdmin { get; set; }
        [FieldFixedLength(1)] public string DrugProcessedSigCode { get; set; }
        [FieldFixedLength(1)] public string DrugMonyCode { get; set; }
        [FieldFixedLength(12)] public string QuantityDispensed { get; set; }
        [FieldFixedLength(4)] public string DaysSupply { get; set; }
        [FieldFixedLength(1)] public string DawCode { get; set; }
        [FieldFixedLength(10)] public string PlanIngredientCost { get; set; }
        [FieldFixedLength(10)] public string PlanDispensingFee { get; set; }
        [FieldFixedLength(10)] public string PlanSalesTax { get; set; }
        [FieldFixedLength(10)] public string IncentiveFee { get; set; }
        [FieldFixedLength(10)] public string ClaimSegmentProcessorFee { get; set; }
        [FieldFixedLength(10)] public string PlanGrossAmount { get; set; }
        [FieldFixedLength(10)] public string OtherPayerAmount { get; set; }
        [FieldFixedLength(10)] public string TotalPatientPayAmount { get; set; }
        [FieldFixedLength(10)] public string PlanPharmacyAmount { get; set; }
        [FieldFixedLength(3)] public string PlanBasisOfCost { get; set; }
        [FieldFixedLength(3)] public string PlanBasisOfReimbursement { get; set; }
        [FieldFixedLength(10)] public string CalculatedAwp { get; set; }
        [FieldFixedLength(2)] public string SubmissionClarificationCode { get; set; }
        [FieldFixedLength(2)] public string OtherCoverageCode { get; set; }
        [FieldFixedLength(4)] public string MedicaidCode { get; set; }
        [FieldFixedLength(35)] public string MedicaidName { get; set; }
        [FieldFixedLength(15)] public string CouponNumber { get; set; }
        [FieldFixedLength(15)] public string PharmacyNationalProviderId { get; set; }
        [FieldFixedLength(2)] public string PharmacyIdQualifiersubmitted { get; set; }
        [FieldFixedLength(10)] public string CalculatedFedmac { get; set; }
        [FieldFixedLength(1)] public string CalculatedAwpSource { get; set; }
        [FieldFixedLength(10)] public string CalculatedWac { get; set; }
        [FieldFixedLength(3)] public string CouponActualUseNumber { get; set; }
        [FieldFixedLength(1)] public string ProcessedSingleSourceGenericIndicator { get; set; }
        [FieldFixedLength(20)] public string ManufacturerName { get; set; }
        [FieldFixedLength(12)] public string AdjudicatedUnitPrice { get; set; }
        [FieldFixedLength(10)] public string PreCopayRoundingAmount { get; set; }
        [FieldFixedLength(1)] public string NumberOfCouponUses { get; set; }
        [FieldFixedLength(3)] public string CombinedCouponUses { get; set; }
        [FieldFixedLength(20)] public string RejectReprocessOriginalAuthorizationNumber { get; set; }
        [FieldFixedLength(119)] public string ReservedForFutureUse { get; set; }

        #endregion

        #region Claim Indicator Segment

        [FieldFixedLength(1)] public string ClaimIndicatorSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string ClaimIndicatorSegmentIdentifier { get; set; }
        [FieldFixedLength(1)] public string PaperClaimFlag { get; set; }
        [FieldFixedLength(1)] public string DirectReimbursementFlag { get; set; }
        [FieldFixedLength(1)] public string TestClaimFlag { get; set; }
        [FieldFixedLength(1)] public string BatchProcessedFlag { get; set; }
        [FieldFixedLength(1)] public string OtherProcessorFlag { get; set; }
        [FieldFixedLength(1)] public string FormularyDrugFlag { get; set; }
        [FieldFixedLength(1)] public string NetworkPharmacyFlag { get; set; }
        [FieldFixedLength(1)] public string NetworkPhysicianFlag { get; set; }
        [FieldFixedLength(1)] public string ShoeboxClaimFlag { get; set; }
        [FieldFixedLength(1)] public string ProductQtyClaimFlag { get; set; }
        [FieldFixedLength(1)] public string StarterDoseFlag { get; set; }
        [FieldFixedLength(1)] public string PriorAuthFlag { get; set; }
        [FieldFixedLength(1)] public string DurFlag { get; set; }
        [FieldFixedLength(1)] public string DurOverrideFlag { get; set; }
        [FieldFixedLength(1)] public string IgCopayFlag { get; set; }
        [FieldFixedLength(1)] public string MultiIngredCompoundFlag { get; set; }
        [FieldFixedLength(1)] public string PartialFillDispensingStatus { get; set; }
        [FieldFixedLength(1)] public string MedicaidFlag { get; set; }
        [FieldFixedLength(1)] public string ForceUcFlag { get; set; }
        [FieldFixedLength(1)] public string NdcRemapped { get; set; }
        [FieldFixedLength(1)] public string ForcePharmacyDue { get; set; }
        [FieldFixedLength(1)] public string AdditionalLowerOfStateRateUsed { get; set; }
        [FieldFixedLength(1)] public string PosMedicaidFlag { get; set; }
        [FieldFixedLength(1)] public string AlternateProcessingBypass { get; set; }
        [FieldFixedLength(1)] public string TaxExemptIndicator { get; set; }
        [FieldFixedLength(1)] public string AlternateDrugRecord { get; set; }
        [FieldFixedLength(1)] public string ClaimRoundingUsed { get; set; }
        [FieldFixedLength(1)] public string MedicalClaimIndicator { get; set; }
        [FieldFixedLength(1)] public string CompensableClaimIndicator { get; set; }
        [FieldFixedLength(1)] public string DataFeedTransaction { get; set; }
        [FieldFixedLength(27)] public string ClaimIndicatorSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Addtl. Patient Info Segment

        [FieldFixedLength(1)] public string AddtlPatientInfoSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string AddtlPatientInfoSegmentIdentifier { get; set; }
        [FieldFixedLength(15)] public string CardholderLastName { get; set; }
        [FieldFixedLength(12)] public string CardholderFirstName { get; set; }
        [FieldFixedLength(1)] public string PatientMiddleInitial { get; set; }
        [FieldFixedLength(3)] public string PatientNameSuffix { get; set; }
        [FieldFixedLength(35)] public string AddressLine1 { get; set; }
        [FieldFixedLength(35)] public string AddressLine2 { get; set; }
        [FieldFixedLength(18)] public string City { get; set; }
        [FieldFixedLength(2)] public string State { get; set; }
        [FieldFixedLength(9)] public string ZipCode { get; set; }
        [FieldFixedLength(10)] public string PhoneNumber { get; set; }
        [FieldFixedLength(8)] public string EffectiveDate { get; set; }
        [FieldFixedLength(8)] public string TerminationDate { get; set; }
        [FieldFixedLength(8)] public string DateOfBirth { get; set; }
        [FieldFixedLength(1)] public string GenderCode { get; set; }
        [FieldFixedLength(1)] public string RelationshipCode { get; set; }
        [FieldFixedLength(1)] public string CoverageCode { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoReservedForFutureUse1 { get; set; }
        [FieldFixedLength(1)] public string StudentFlag { get; set; }
        [FieldFixedLength(1)] public string AddtlPatientInfoReservedForFutureUse2 { get; set; }
        [FieldFixedLength(20)] public string LocationCode { get; set; }
        [FieldFixedLength(35)] public string LocationName { get; set; }
        [FieldFixedLength(1)] public string SecondaryCoverage { get; set; }
        [FieldFixedLength(1)] public string PharmacyLockIn { get; set; }
        [FieldFixedLength(1)] public string PhysicianLockIn { get; set; }
        [FieldFixedLength(1)] public string TestMemberFlag { get; set; }
        [FieldFixedLength(10)] public string EligibilityCreatedByUserId { get; set; }
        [FieldFixedLength(8)] public string EligibilityCreatedDate { get; set; }
        [FieldFixedLength(10)] public string EligibilityModifiedByUserId { get; set; }
        [FieldFixedLength(8)] public string EligibilityModifiedDate { get; set; }
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
        [FieldFixedLength(2)] public string PaTypeSubmitted { get; set; }
        [FieldFixedLength(11)] public string PaNumberSubmitted { get; set; }
        [FieldFixedLength(11)] public string ActualPaNumberUsed { get; set; }
        [FieldFixedLength(1)] public string PaTypeManualAuto { get; set; }
        [FieldFixedLength(8)] public string PaEffectiveDate { get; set; }
        [FieldFixedLength(8)] public string PaTerminationDate { get; set; }
        [FieldFixedLength(35)] public string PaDescription { get; set; }
        [FieldFixedLength(30)] public string PriorAuthorizationSegmentReservedForFutureUse { get; set; }

        #endregion

        #region DUR Segment

        [FieldFixedLength(1)] public string DurSegmentSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string DurSegmentSegmentIdentifier { get; set; }
        [FieldFixedLength(2)] public string Dur1ConflictCode { get; set; }
        [FieldFixedLength(1)] public string Dur1SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string Dur1HitDisposition { get; set; }
        [FieldFixedLength(20)] public string Dur1ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string Dur2ConflictCode { get; set; }
        [FieldFixedLength(1)] public string Dur2SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string Dur2HitDisposition { get; set; }
        [FieldFixedLength(20)] public string Dur2ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string Dur3ConflictCode { get; set; }
        [FieldFixedLength(1)] public string Dur3SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string Dur3HitDisposition { get; set; }
        [FieldFixedLength(20)] public string Dur3ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string Dur4ConflictCode { get; set; }
        [FieldFixedLength(1)] public string Dur4SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string Dur4HitDisposition { get; set; }
        [FieldFixedLength(20)] public string Dur4ConflictingAuthorizationNumber { get; set; }
        [FieldFixedLength(2)] public string Dur5ConflictCode { get; set; }
        [FieldFixedLength(1)] public string Dur5SeverityIndex { get; set; }
        [FieldFixedLength(1)] public string Dur5HitDisposition { get; set; }
        [FieldFixedLength(20)] public string Dur5ConflictingAuthorizationNumber { get; set; }

        #endregion

        #region Submitted DUR Override Segment

        // TODO 

        #endregion

        #region Drug Classification Segment

        // TODO 

        #endregion

        #region Pharmacy Segment

        // TODO 

        #endregion

        #region Prescriber Segment

        // TODO 

        #endregion

        #region Enhanced Prescriber Segment

        // TODO 

        #endregion

        #region Workers' Compensation Segment

        // TODO 

        #endregion

        #region Claim Balances Segment

        // TODO 

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
        [FieldFixedLength(10)] public string AmtAttributedToProcessorFee { get; set; }
        [FieldFixedLength(10)] public string AmountOfCoinsurance { get; set; }
        [FieldFixedLength(2)] public string ReservedForFutureDefinedField { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField1 { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField2 { get; set; }
        [FieldFixedLength(10)] public string AmtAttributedToProductSelectionBrandDrug { get; set; }
        [FieldFixedLength(10)] public string AmtAttributedToProductSelectionNonPreferredFormularySelection { get; set; }

        [FieldFixedLength(10)]
        public string AmtAttributedToProductSelectionBrandNonPreferredFormularySelection { get; set; }

        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField3 { get; set; }
        [FieldFixedLength(10)] public string PatientPaySegmentReservedForFuturePricingField4 { get; set; }
        [FieldFixedLength(10)] public string AmountAttributedToSalesTax { get; set; }
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
        [FieldFixedLength(10)] public string PharmacyIngredientCost { get; set; }
        [FieldFixedLength(10)] public string PharmacyDispensingFee { get; set; }
        [FieldFixedLength(10)] public string PharmacySalesTax { get; set; }
        [FieldFixedLength(10)] public string PharmacyGrossAmount { get; set; }
        [FieldFixedLength(10)] public string PharmacyCopayAmount { get; set; }
        [FieldFixedLength(10)] public string PharmacyDueAmount { get; set; }
        [FieldFixedLength(3)] public string PharmacyBasisOfCost { get; set; }
        [FieldFixedLength(3)] public string PharmacyBasisOfReimbursement { get; set; }
        [FieldFixedLength(10)] public string PharmacyCalculatedAmount { get; set; }
        [FieldFixedLength(10)] public string PharmacyPricingSegmentProcessorFee { get; set; }
        [FieldFixedLength(3)] public string PharmacyPricingReservedForFutureUse { get; set; }

        #endregion

        #region Addtl. Submitted Pharmacy Pricing

        [FieldFixedLength(1)] public string AddtlSubmittedPharmacyPricingSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string AddtlSubmittedPharmacyPricingSegmentIdentifier { get; set; }
        [FieldFixedLength(10)] public string SubmittedUc { get; set; }
        [FieldFixedLength(10)] public string SubmittedIngredientCost { get; set; }
        [FieldFixedLength(10)] public string SubmittedDispensingFee { get; set; }
        [FieldFixedLength(10)] public string SubmittedSalesTax { get; set; }
        [FieldFixedLength(10)] public string SubmittedGrossAmount { get; set; }
        [FieldFixedLength(10)] public string SubmittedCopayAmount { get; set; }
        [FieldFixedLength(24)] public string AddtlSubmittedPharmacyPricingSegmentReservedForFutureUse { get; set; }

        #endregion
    }
}