namespace AHClaim.domain.Segment
{
    /// <summary>
    /// Claim Segment
    /// </summary>
    public class ClaimSegment
    {
        /// <summary>
        /// Field #: 3
        /// Field Name: Claim Authorization #
        /// Format: AN 
        /// Length: 20
        /// Definition: The unique Authorization number assigned to every transaction
        /// </summary>
        public string ClaimAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Original Claim Authorization #
        /// Format: AN 
        /// Length: 20
        /// Definition: In the case of a reversal, the value will be the Claim Auth. Number of the corresponding paid claim.Otherwise, it is equal to field #3.
        /// </summary>
        public string OriginalClaimAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Reversal Claim Authorization #
        /// Format: AN 
        /// Length: 20
        /// Definition: In the case of a paid claim that has been reversed, the value will be the Claim Auth. Number of the reversal. Otherwise, blank 
        /// </summary>
        public string ReversalClaimAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Date Processed
        /// Format: N
        /// Length: 8
        /// Definition: The date that the claim was processed by Change Healthcare
        /// </summary>
        public string DateProcessed { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Time Processed
        /// Format: AN
        /// Length: 8
        /// Definition: The time that the claim was processed by Change Healthcare / hh:mm:ss
        /// </summary>
        public string TimeProcessed { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Rejection Flag
        /// Format: N
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = Claim is a Rejection
        /// </summary>
        public string RejectionFlag { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Duplicate Flag
        /// Format: N
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = Claim is a Paid Duplicate
        /// </summary>
        public string DuplicateFlag { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: Reversal Flag
        /// Format: N
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = Claim is a Reversal
        /// </summary>
        public string ReversalFlag { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Pharmacy NCPDP ID Number 
        /// Format: N
        /// Length: 15
        /// Definition: Unique pharmacy identifier assigned by NCPDP
        /// </summary>
        public string PharmacyNcpdpIdNumber { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: Pharmacy Name
        /// Format: AN
        /// Length: 35
        /// Definition: As provided by NCPDP 
        /// </summary>
        public string PharmacyName { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: Pharmacy Chain #
        /// Format: N
        /// Length: 4
        /// Definition: As provided by NCPDP
        /// </summary>
        public string PharmacyChainNumber { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Pharmacy Chain Name
        /// Format: AN
        /// Length: 35
        /// </summary>
        public string PharmacyChainName { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: Pharmacy Type (Retail 1, Retail 2, Mail Order) 
        /// Format: AN
        /// Length: 1
        /// Values: 1, 2, M
        /// Definition: "1"=Retail 1, "2"=Retail 2, "M"=MailOrder
        /// </summary>
        public string PharmacyType { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name: Carrier Code
        /// Format: AN
        /// Length: 3
        /// Definition: Carrier code as processed
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name: Submitted Carrier Code
        /// Format: AN
        /// Length: 3
        /// Definition: Carrier code submitted via PCN, or assigned from group routing
        /// </summary>
        public string SubmittedCarrierCode { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name: TPA/Broker Code
        /// Format: AN
        /// Length: 10
        /// </summary>
        public string TpaBrokerCode { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name: TPA/Broker Name 
        /// Format: AN
        /// Length: 35
        /// </summary>
        public string TpaBrokerName { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name: Sponsor Code
        /// Format: AN
        /// Length: 10
        /// </summary>
        public string SponsorCode { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name: Sponsor Name
        /// Format: AN
        /// Length: 35
        /// </summary>
        public string SponsorName { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name: Group #
        /// Format: AN
        /// Length: 15
        /// </summary>
        public string GroupNumber { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name: Group Name
        /// Format: AN
        /// Length: 35
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name: Cardholder ID #
        /// Format: AN
        /// Length: 20
        /// Definition: Base member identification number
        /// </summary>
        public string CardholderIdNumber { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name: Patient Person Code
        /// Format: N
        /// Length: 3
        /// Definition: Individual person code
        /// </summary>
        public string PatientPersonCode { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name: Patient Last Name
        /// Format: 1N
        /// Length: 15
        /// Definition: If Cardholder ID on file, then as per file, otherwise as submitted 
        /// </summary>
        public string PatientLastName { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name: Patient First Name
        /// Format: 1N
        /// Length: 12
        /// Definition: If Cardholder ID on file, then as per file, otherwise as submitted
        /// </summary>
        public string PatientFirstName { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name: Prescriber ID
        /// Format: AN
        /// Length: 15
        /// </summary>
        public string PrescriberId { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name: Prescriber Name
        /// Format: AN
        /// Length: 35
        /// Definition: If Prescriber ID on file, then as per file, otherwise as submitted 
        /// </summary>
        public string PrescriberName { get; set; }

        /// <summary>
        /// Field #: 30
        /// Field Name: Date Filled 
        /// Format: N
        /// Length: 8
        /// </summary>
        public string DateFilled { get; set; }

        /// <summary>
        /// Field #: 31 
        /// Field Name: Date Written 
        /// Format: N 
        /// Length: 8
        /// </summary>
        public string DateWritten { get; set; }

        /// <summary>
        /// Field #: 32 
        /// Field Name: RX Number 
        /// Format: AN 
        /// Length: 12 
        /// </summary>
        public string RxNumber { get; set; }

        /// <summary>
        /// Field #: 33
        /// Field Name: Fill Number
        /// Format: N
        /// Length: 2
        /// Definition: Value as submitted by the pharmacy
        /// </summary>
        public string FillNumber { get; set; }

        /// <summary>
        /// Field #: 34 
        /// Field Name: Number of Refills Authorized 
        /// Format: N 
        /// Length: 2
        /// Definition: Value as submitted by the pharmacy
        /// </summary>
        public string NumberOfRefillsAuthorized { get; set; }

        /// <summary>
        /// Field #: 35
        /// Field Name: Drug NDC # 
        /// Format: N 
        /// Length: 19
        /// </summary>
        public string DrugNdcNumber { get; set; }

        /// <summary>
        /// Field #: 36 
        /// Field Name: Drug Name 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        public string DrugName { get; set; }

        /// <summary>
        /// Field #: 37
        /// Field Name: Drug Strength Description 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string DrugStrengthDescription { get; set; }

        /// <summary>
        /// Field #: 38
        /// Field Name: Drug Dose Form Description 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string DrugDoseFormDescription { get; set; }

        /// <summary>
        /// Field #: 39
        /// Field Name: Submitted Compound Code 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1,2 
        /// Definition: NCPDP value submitted by the pharmacy
        /// </summary>
        public string SubmittedCompoundCode { get; set; }

        /// <summary>
        /// Field #: 40 
        /// Field Name: Submitted Route of Admin 
        /// Format: AN 
        /// Length: 11
        /// Definition: See ECL for values
        /// </summary>
        public string SubmittedRouteOfAdmin { get; set; }

        /// <summary>
        /// Field #: 41 
        /// Field Name: Drug Processed SIG Code 
        /// Format: AN 
        /// Length: 1
        /// Value: S,I,G 
        /// Definition: "S"=SingleSource, "I"=Innovator, "G"=Generic P
        /// </summary>
        public string DrugProcessedSigCode { get; set; }

        /// <summary>
        /// Field #: 42 
        /// Field Name: Drug MONY Code 
        /// Format: AN 
        /// Length: 1
        /// Value: M,O,N,Y,X 
        /// Definition: "M"=CoLicensed Brand, "O"=Originator,"N"=SingleSource Brand, "Y"=Generic, "X"=NonDrug item
        /// </summary>
        public string DrugMonyCode { get; set; }

        /// <summary>
        /// Field #: 43 
        /// Field Name: Quantity Dispensed 
        /// Format: N 
        /// Length: 12
        /// </summary>
        public string QuantityDispensed { get; set; }

        /// <summary>
        /// Field #: 44 
        /// Field Name: Days Supply 
        /// Format: N 
        /// Length: 4
        /// </summary>
        public string DaysSupply { get; set; }

        /// <summary>
        /// Field #: 45 
        /// Field Name: DAW Code 
        /// Format: AN 
        /// Length: 1
        /// Value: 0-9 
        /// Definition: NCPDP value submitted by the pharmacy. Non NCPDP values submitted = "0" P
        /// </summary>
        public string DawCode { get; set; }

        /// <summary>
        /// Field #: 46 
        /// Field Name: Plan Ingredient Cost 
        /// Format: D 
        /// Length: 10
        /// </summary>
        public string PlanIngredientCost { get; set; }

        /// <summary>
        /// Field #: 47 
        /// Field Name: Plan Dispensing Fee 
        /// Format: D 
        /// Length: 10
        /// </summary>
        public string PlanDispensingFee { get; set; }

        /// <summary>
        /// Field #: 48 
        /// Field Name: Plan Sales Tax 
        /// Format: D 
        /// Length: 10
        /// </summary>
        public string PlanSalesTax { get; set; }

        /// <summary>
        /// Field #: 49 
        /// Field Name: Incentive Fee (Handling Fee) 
        /// Format: D 
        /// Length: 10
        /// Definition: The value returned to the pharmacy in the Incentive Fee field. 001.00 = $1.00
        /// </summary>
        public string IncentiveFee { get; set; }

        /// <summary>
        /// Field #: 50
        /// Field Name: Processor Fee (User Fee) 
        /// Format: D 
        /// Length: 10 
        /// Definition: The Plan User Fee assessed at time of transaction
        /// </summary>
        public string ProcessorFee { get; set; }

        /// <summary>
        /// Field #: 51
        /// Field Name: Plan Gross Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Equals sum of fields 46, 47, 48, 49 and 50
        /// </summary>
        public string PlanGrossAmount { get; set; }

        /// <summary>
        /// Field #: 52
        /// Field Name: Other Payer Amount 
        /// Format: D 
        /// Length: 10
        /// </summary>
        public string OtherPayerAmount { get; set; }

        /// <summary>
        /// Field #: 53
        /// Field Name: Total Patient Pay Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Detailed breakout available in PP Segment
        /// </summary>
        public string TotalPatientPayAmount { get; set; }

        /// <summary>
        /// Field #: 54
        /// Field Name: Plan Pharmacy Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Equals Total Patient Pay Amount (CS 53) + Other Payer Amount (recognized) (CS 52)
        /// </summary>
        public string PlanPharmacyAmount { get; set; }

        /// <summary>
        /// Field #: 55
        /// Field Name: Plan Basis of Cost
        /// Format: AN 
        /// Length: 3 
        /// Value: AWP, FED, MAC, WAC 
        /// Definition: Calculation basis used prior to U&C compare
        /// </summary>
        public string PlanBasisOfCost { get; set; }

        /// <summary>
        /// Field #: 56
        /// Field Name: Plan Basis of Reimbursement 
        /// Format: AN 
        /// Length: 3 
        /// Definition: Actual lower of basis used as per NCPDP defined Basis of Reimbursement codes
        /// </summary>
        public string PlanBasisOfReimbursement { get; set; }

        /// <summary>
        /// Field #: 57
        /// Field Name: Calculated AWP 
        /// Format: D 
        /// Length: 10
        /// Definition:  The quantity multiplied by the per unit AWP value at time of claims file build.
        /// </summary>
        public string CalculatedAwp { get; set; }

        /// <summary>
        /// Field #: 58
        /// Field Name: Submission Clarification Code 
        /// Format: N 
        /// Length: 2 
        /// Definition: Value as submitted by the pharmacy – Will present 1st submission code submitted.
        /// </summary>
        public string SubmissionClarificationCode { get; set; }

        /// <summary>
        /// Field #: 59
        /// Field Name: Other Coverage Code 
        /// Format: N 
        /// Length: 2 
        /// Definition: 0-8 Value as submitted by the pharmacy
        /// </summary>
        public string OtherCoverageCode { get; set; }

        /// <summary>
        /// Field #: 60
        /// Field Name: Medicaid Code 
        /// Format: A 
        /// Length: 4 
        /// Definition: As keyed for Medicaid/Third Party payment
        /// </summary>
        public string MedicaidCode { get; set; }

        /// <summary>
        /// Field #: 61
        /// Field Name: Medicaid Name 
        /// Format: A 
        /// Length: 35
        /// </summary>
        public string MedicaidName { get; set; }

        /// <summary>
        /// Field #: 62
        /// Field Name: Coupon Number 
        /// Format: A 
        /// Length: 15
        /// Definition:  Coupon Number submitted by the pharmacy
        /// </summary>
        public string CouponNumber { get; set; }

        /// <summary>
        /// Field #: 63
        /// Field Name: Pharmacy National Provider ID (NPI) 
        /// Format: AN 
        /// Length: 15
        /// Definition:  NPI assigned to Pharmacy
        /// </summary>
        public string PharmacyNationalProviderId { get; set; }

        /// <summary>
        /// Field #: 64
        /// Field Name: Pharmacy ID Qualifier submitted 
        /// Format: AN 
        /// Length: 2 
        /// Definition: Pharmacy ID Qualifier submitted by pharmacy
        /// </summary>
        public string PharmacyIdQualifierSubmitted { get; set; }

        /// <summary>
        /// Field #: 65
        /// Field Name: Calculated FED MAC 
        /// Format: D 
        /// Length: 10
        /// Definition:  The quantity multiplied by the per unit FED value at time of file
        /// </summary>
        public string CalculatedFedmac { get; set; }

        /// <summary>
        /// Field #: 66
        /// Field Name: Calculated AWP Source 
        /// Format: N 
        /// Length: 1 
        /// Definition: AWP value provided by: 1= FDB, 2= MediSpan
        /// </summary>
        public string CalculatedAwpSource { get; set; }

        /// <summary>
        /// Field #: 67
        /// Field Name: Calculated WAC 
        /// Format: D 
        /// Length: 10
        /// Definition:  The quantity multiplied by the per unit WAC value at time of claims file build.
        /// </summary>
        public string CalculatedWac { get; set; }

        /// <summary>
        /// Field #: 68
        /// Field Name: Coupon Actual Use Number 
        /// Format: N 
        /// Length: 3
        /// </summary>
        public string CouponActualUseNumber { get; set; }

        /// <summary>
        /// Field #: 69
        /// Field Name: Processed Single Source Generic Indicator 
        /// Format: AN 
        /// Length: 1 
        /// Value: 0,1,2, blank
        /// Definition: 0=Not SSG; 1=SSG; 2=SSG in GCNSEQ; blank=undetermined
        /// </summary>
        public string ProcessedSingleSourceGenericIndicator { get; set; }

        /// <summary>
        /// Field #: 70
        /// Field Name: Manufacturer Name 
        /// Format: AN 
        /// Length: 20
        /// </summary>
        public string ManufacturerName { get; set; }

        /// <summary>
        /// Field #: 71 
        /// Field Name: Adjudicated Unit Price 
        /// Format: D 
        /// Length: 12 
        /// Definition: Per unit price used in final adjudicated calculation
        /// </summary>
        public string AdjudicatedUnitPrice { get; set; }

        /// <summary>
        /// Field #: 72 
        /// Field Name: Pre-Copay Rounding Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Claim Calculation prior to invoke of claim rounding edit.
        /// </summary>
        public string PreCopayRoundingAmount { get; set; }

        /// <summary>
        /// Field #: 73 
        /// Field Name: Number of Coupon Uses 
        /// Format: N 
        /// Length: 1 
        /// Definition: Number of counted coupon uses applied to the transaction.
        /// </summary>
        public string NumberOfCouponUses { get; set; }

        /// <summary>
        /// Field #: 74 
        /// Field Name: Combined Coupon Uses 
        /// Format: N 
        /// Length: 3 
        /// Definition: Combined coupon uses across all linked coupons.
        /// </summary>
        public string CombinedCouponUses { get; set; }

        /// <summary>
        /// Field #: 75 
        /// Field Name: Reject Reprocess Original Authorization # 
        /// Format: AN 
        /// Length: 20 
        /// Definition: The Authorization # of the originally processed claim in a Rejection Re-Route/Reprocess scenario.
        /// </summary>
        public string RejectReprocessOriginalAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 76 
        /// Field Name: Reserved for Future Use 
        /// Length: 119
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}