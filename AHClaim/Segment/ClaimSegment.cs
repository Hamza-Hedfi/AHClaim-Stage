namespace AHClaim.Segment
{
    /// <summary>
    /// Claim Segment
    /// </summary>
    public class ClaimSegment
    {
        public string SeparatorCharacter { get; set; }
        public string SegmentIdentifier { get; set; }
        public string ClaimAuthorizationNumber { get; set; }
        public string OriginalClaimAuthorizationNumber { get; set; }
        public string ReversalClaimAuthorizationNumber { get; set; }
        public string DateProcessed { get; set; }
        public string TimeProcessed { get; set; }
        public string RejectionFlag { get; set; }
        public string DuplicateFlag { get; set; }
        public string ReversalFlag { get; set; }
        public string PharmacyNcpdpIdNumber { get; set; }
        public string PharmacyName { get; set; }
        public string PharmacyChainNumber { get; set; }
        public string PharmacyChainName { get; set; }
        public string PharmacyType { get; set; }
        public string CarrierCode { get; set; }
        public string SubmittedCarrierCode { get; set; }
        public string TpaBrokerCode { get; set; }
        public string TpaBrokerName { get; set; }
        public string SponsorCode { get; set; }
        public string SponsorName { get; set; }
        public string GroupNumber { get; set; }
        public string GroupName { get; set; }
        public string CardholderIdNumber { get; set; }
        public string PatientPersonCode { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PrescriberId { get; set; }
        public string PrescriberName { get; set; }
        public string DateFilled { get; set; }
        public string DateWritten { get; set; }
        public string RxNumber { get; set; }
        public string FillNumber { get; set; }
        public string NumberOfRefillsAuthorized { get; set; }
        public string DrugNdcNumber { get; set; }
        public string DrugName { get; set; }
        public string DrugStrengthDescription { get; set; }
        public string DrugDoseFormDescription { get; set; }
        public string SubmittedCompoundCode { get; set; }
        public string SubmittedRouteOfAdmin { get; set; }
        public string DrugProcessedSigCode { get; set; }
        public string DrugMonyCode { get; set; }
        public string QuantityDispensed { get; set; }
        public string DaysSupply { get; set; }
        public string DawCode { get; set; }
        public string PlanIngredientCost { get; set; }
        public string PlanDispensingFee { get; set; }
        public string PlanSalesTax { get; set; }
        public string IncentiveFee { get; set; }
        public string ProcessorFee { get; set; }
        public string PlanGrossAmount { get; set; }
        public string OtherPayerAmount { get; set; }
        public string TotalPatientPayAmount { get; set; }
        public string PlanPharmacyAmount { get; set; }
        public string PlanBasisOfCost { get; set; }
        public string PlanBasisOfReimbursement { get; set; }
        public string CalculatedAwp { get; set; }
        public string SubmissionClarificationCode { get; set; }
        public string OtherCoverageCode { get; set; }
        public string MedicaidCode { get; set; }
        public string MedicaidName { get; set; }
        public string CouponNumber { get; set; }
        public string PharmacyNationalProviderId { get; set; }
        public string PharmacyIdQualifierSubmitted { get; set; }
        public string CalculatedFedmac { get; set; }
        public string CalculatedAwpSource { get; set; }
        public string CalculatedWac { get; set; }
        public string CouponActualUseNumber { get; set; }
        public string ProcessedSingleSourceGenericIndicator { get; set; }
        public string ManufacturerName { get; set; }
        public string AdjudicatedUnitPrice { get; set; }
        public string PreCopayRoundingAmount { get; set; }
        public string NumberOfCouponUses { get; set; }
        public string CombinedCouponUses { get; set; }
        public string RejectReprocessOriginalAuthorizationNumber { get; set; }
        public string ReservedForFutureUse { get; set; }
    }
}