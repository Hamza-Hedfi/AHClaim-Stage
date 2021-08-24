using FileHelpers;

namespace AHClaim.domain.Record
{
    /// <summary>
    /// Raw Segment as defined in file.
    /// It defines how the file should be read.
    /// Till FieldOrder is introduced the order of the properties is important.
    /// This class is never instantiated directly.
    /// It is used by FileHelper engine to process the data source 'file'.
    ///
    /// The order of the properties is as it is defined in the datasource 'file' spec.
    /// 
    /// DO NOT MODIFY THE ORDER OF THE PROPERTIES, UNLESS YOU KNOW WHAT YOU ARE DOING
    ///     OR [FieldOrder] IS PRESENT FOR ALL PROPERTIES
    /// </summary>
    [FixedLengthRecord(FixedMode.AllowVariableLength)]
    public class RawClaimRecord
    {
        #region Header Segment

        /// <summary>
        /// Field #: 1
        /// Field Name: Claim File Record Indicator ($C)
        /// Format: AN 
        /// Length: 2
        /// Values: $C
        /// </summary>
        [FieldFixedLength(2)]
        public string HeaderSegmentClaimFileRecordIndicator { get; set; }

        /// <summary>
        /// Field #: 2
        /// Field Name: Version Number
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string HeaderSegmentVersionNumber { get; set; }

        /// <summary>
        /// Field #: 3
        /// Field Name: Minor Version Number
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string HeaderSegmentMinorVersionNumber { get; set; }

        #endregion

        #region Claim Segment

        /// <summary>
        /// Field #: 1
        /// Field Name: Segment Separator Character
        /// Format: AN
        /// Length: 1
        /// Values: >
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2
        /// Field Name: Segment Identifier
        /// Format: AN 
        /// Length: 2
        /// Values: CS
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimSegmentSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3
        /// Field Name: Claim Authorization #
        /// Format: AN 
        /// Length: 20
        /// Definition: The unique Authorization number assigned to every transaction
        /// </summary>
        [FieldFixedLength(20)]
        public string ClaimSegmentClaimAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Original Claim Authorization #
        /// Format: AN 
        /// Length: 20
        /// Definition: In the case of a reversal, the value will be the Claim Auth. Number of the corresponding paid claim.Otherwise, it is equal to field #3.
        /// </summary>
        [FieldFixedLength(20)]
        public string ClaimSegmentOriginalClaimAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Reversal Claim Authorization #
        /// Format: AN 
        /// Length: 20
        /// Definition: In the case of a paid claim that has been reversed, the value will be the Claim Auth. Number of the reversal. Otherwise, blank 
        /// </summary>
        [FieldFixedLength(20)]
        public string ClaimSegmentReversalClaimAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Date Processed
        /// Format: N
        /// Length: 8
        /// Definition: The date that the claim was processed by Change Healthcare
        /// </summary>
        [FieldFixedLength(8)]
        public string ClaimSegmentDateProcessed { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Time Processed
        /// Format: AN
        /// Length: 8
        /// Definition: The time that the claim was processed by Change Healthcare / hh:mm:ss
        /// </summary>
        [FieldFixedLength(8)]
        public string ClaimSegmentTimeProcessed { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Rejection Flag
        /// Format: N
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = Claim is a Rejection
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentRejectionFlag { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Duplicate Flag
        /// Format: N
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = Claim is a Paid Duplicate
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentDuplicateFlag { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: Reversal Flag
        /// Format: N
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = Claim is a Reversal
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentReversalFlag { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Pharmacy NCPDP ID Number 
        /// Format: N
        /// Length: 15
        /// Definition: Unique pharmacy identifier assigned by NCPDP
        /// </summary>
        [FieldFixedLength(15)]
        public string ClaimSegmentPharmacyNcpdpIdNumber { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: Pharmacy Name
        /// Format: AN
        /// Length: 35
        /// Definition: As provided by NCPDP 
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentPharmacyName { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: Pharmacy Chain #
        /// Format: N
        /// Length: 4
        /// Definition: As provided by NCPDP
        /// </summary>
        [FieldFixedLength(4)]
        public string ClaimSegmentPharmacyChainNumber { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Pharmacy Chain Name
        /// Format: AN
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentPharmacyChainName { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: Pharmacy Type (Retail 1, Retail 2, Mail Order) 
        /// Format: AN
        /// Length: 1
        /// Values: 1, 2, M
        /// Definition: "1"=Retail 1, "2"=Retail 2, "M"=MailOrder
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentPharmacyType { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name: Carrier Code
        /// Format: AN
        /// Length: 3
        /// Definition: Carrier code as processed
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimSegmentCarrierCode { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name: Submitted Carrier Code
        /// Format: AN
        /// Length: 3
        /// Definition: Carrier code submitted via PCN, or assigned from group routing
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimSegmentSubmittedCarrierCode { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name: TPA/Broker Code
        /// Format: AN
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentTpaBrokerCode { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name: TPA/Broker Name 
        /// Format: AN
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentTpaBrokerName { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name: Sponsor Code
        /// Format: AN
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentSponsorCode { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name: Sponsor Name
        /// Format: AN
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentSponsorName { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name: Group #
        /// Format: AN
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string ClaimSegmentGroupNumber { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name: Group Name
        /// Format: AN
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentGroupName { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name: Cardholder ID #
        /// Format: AN
        /// Length: 20
        /// Definition: Base member identification number
        /// </summary>
        [FieldFixedLength(20)]
        public string ClaimSegmentCardholderIdNumber { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name: Patient Person Code
        /// Format: N
        /// Length: 3
        /// Definition: Individual person code
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimSegmentPatientPersonCode { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name: Patient Last Name
        /// Format: 1N
        /// Length: 15
        /// Definition: If Cardholder ID on file, then as per file, otherwise as submitted 
        /// </summary>
        [FieldFixedLength(15)]
        public string ClaimSegmentPatientLastName { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name: Patient First Name
        /// Format: 1N
        /// Length: 12
        /// Definition: If Cardholder ID on file, then as per file, otherwise as submitted
        /// </summary>
        [FieldFixedLength(12)]
        public string ClaimSegmentPatientFirstName { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name: Prescriber ID
        /// Format: AN
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string ClaimSegmentPrescriberId { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name: Prescriber Name
        /// Format: AN
        /// Length: 35
        /// Definition: If Prescriber ID on file, then as per file, otherwise as submitted 
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentPrescriberName { get; set; }

        /// <summary>
        /// Field #: 30
        /// Field Name: Date Filled 
        /// Format: N
        /// Length: 8
        /// </summary>
        [FieldFixedLength(8)]
        public string ClaimSegmentDateFilled { get; set; }

        /// <summary>
        /// Field #: 31 
        /// Field Name: Date Written 
        /// Format: N 
        /// Length: 8
        /// </summary>
        [FieldFixedLength(8)]
        public string ClaimSegmentDateWritten { get; set; }

        /// <summary>
        /// Field #: 32 
        /// Field Name: RX Number 
        /// Format: AN 
        /// Length: 12 
        /// </summary>
        [FieldFixedLength(12)]
        public string ClaimSegmentRxNumber { get; set; }

        /// <summary>
        /// Field #: 33
        /// Field Name: Fill Number
        /// Format: N
        /// Length: 2
        /// Definition: Value as submitted by the pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimSegmentFillNumber { get; set; }

        /// <summary>
        /// Field #: 34 
        /// Field Name: Number of Refills Authorized 
        /// Format: N 
        /// Length: 2
        /// Definition: Value as submitted by the pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimSegmentNumberOfRefillsAuthorized { get; set; }

        /// <summary>
        /// Field #: 35
        /// Field Name: Drug NDC # 
        /// Format: N 
        /// Length: 19
        /// </summary>
        [FieldFixedLength(19)]
        public string ClaimSegmentDrugNdcNumber { get; set; }

        /// <summary>
        /// Field #: 36 
        /// Field Name: Drug Name 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentDrugName { get; set; }

        /// <summary>
        /// Field #: 37
        /// Field Name: Drug Strength Description 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentDrugStrengthDescription { get; set; }

        /// <summary>
        /// Field #: 38
        /// Field Name: Drug Dose Form Description 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentDrugDoseFormDescription { get; set; }

        /// <summary>
        /// Field #: 39
        /// Field Name: Submitted Compound Code 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1,2 
        /// Definition: NCPDP value submitted by the pharmacy
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentSubmittedCompoundCode { get; set; }

        /// <summary>
        /// Field #: 40 
        /// Field Name: Submitted Route of Admin 
        /// Format: AN 
        /// Length: 11
        /// Definition: See ECL for values
        /// </summary>
        [FieldFixedLength(11)]
        public string ClaimSegmentSubmittedRouteOfAdmin { get; set; }

        /// <summary>
        /// Field #: 41 
        /// Field Name: Drug Processed SIG Code 
        /// Format: AN 
        /// Length: 1
        /// Value: S,I,G 
        /// Definition: "S"=SingleSource, "I"=Innovator, "G"=Generic P
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentDrugProcessedSigCode { get; set; }

        /// <summary>
        /// Field #: 42 
        /// Field Name: Drug MONY Code 
        /// Format: AN 
        /// Length: 1
        /// Value: M,O,N,Y,X 
        /// Definition: "M"=CoLicensed Brand, "O"=Originator,"N"=SingleSource Brand, "Y"=Generic, "X"=NonDrug item
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentDrugMonyCode { get; set; }

        /// <summary>
        /// Field #: 43 
        /// Field Name: Quantity Dispensed 
        /// Format: N 
        /// Length: 12
        /// </summary>
        [FieldFixedLength(12)]
        public string ClaimSegmentQuantityDispensed { get; set; }

        /// <summary>
        /// Field #: 44 
        /// Field Name: Days Supply 
        /// Format: N 
        /// Length: 4
        /// </summary>
        [FieldFixedLength(4)]
        public string ClaimSegmentDaysSupply { get; set; }

        /// <summary>
        /// Field #: 45 
        /// Field Name: DAW Code 
        /// Format: AN 
        /// Length: 1
        /// Value: 0-9 
        /// Definition: NCPDP value submitted by the pharmacy. Non NCPDP values submitted = "0" P
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentDawCode { get; set; }

        /// <summary>
        /// Field #: 46 
        /// Field Name: Plan Ingredient Cost 
        /// Format: D 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentPlanIngredientCost { get; set; }

        /// <summary>
        /// Field #: 47 
        /// Field Name: Plan Dispensing Fee 
        /// Format: D 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentPlanDispensingFee { get; set; }

        /// <summary>
        /// Field #: 48 
        /// Field Name: Plan Sales Tax 
        /// Format: D 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentPlanSalesTax { get; set; }

        /// <summary>
        /// Field #: 49 
        /// Field Name: Incentive Fee (Handling Fee) 
        /// Format: D 
        /// Length: 10
        /// Definition: The value returned to the pharmacy in the Incentive Fee field. 001.00 = $1.00
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentIncentiveFee { get; set; }

        /// <summary>
        /// Field #: 50
        /// Field Name: Processor Fee (User Fee) 
        /// Format: D 
        /// Length: 10 
        /// Definition: The Plan User Fee assessed at time of transaction
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentProcessorFee { get; set; }

        /// <summary>
        /// Field #: 51
        /// Field Name: Plan Gross Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Equals sum of fields 46, 47, 48, 49 and 50
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentPlanGrossAmount { get; set; }

        /// <summary>
        /// Field #: 52
        /// Field Name: Other Payer Amount 
        /// Format: D 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentOtherPayerAmount { get; set; }

        /// <summary>
        /// Field #: 53
        /// Field Name: Total Patient Pay Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Detailed breakout available in PP Segment
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentTotalPatientPayAmount { get; set; }

        /// <summary>
        /// Field #: 54
        /// Field Name: Plan Pharmacy Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Equals Total Patient Pay Amount (CS 53) + Other Payer Amount (recognized) (CS 52)
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentPlanPharmacyAmount { get; set; }

        /// <summary>
        /// Field #: 55
        /// Field Name: Plan Basis of Cost
        /// Format: AN 
        /// Length: 3 
        /// Value: AWP, FED, MAC, WAC 
        /// Definition: Calculation basis used prior to U&C compare
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimSegmentPlanBasisOfCost { get; set; }

        /// <summary>
        /// Field #: 56
        /// Field Name: Plan Basis of Reimbursement 
        /// Format: AN 
        /// Length: 3 
        /// Definition: Actual lower of basis used as per NCPDP defined Basis of Reimbursement codes
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimSegmentPlanBasisOfReimbursement { get; set; }

        /// <summary>
        /// Field #: 57
        /// Field Name: Calculated AWP 
        /// Format: D 
        /// Length: 10
        /// Definition:  The quantity multiplied by the per unit AWP value at time of claims file build.
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentCalculatedAwp { get; set; }

        /// <summary>
        /// Field #: 58
        /// Field Name: Submission Clarification Code 
        /// Format: N 
        /// Length: 2 
        /// Definition: Value as submitted by the pharmacy – Will present 1st submission code submitted.
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimSegmentSubmissionClarificationCode { get; set; }

        /// <summary>
        /// Field #: 59
        /// Field Name: Other Coverage Code 
        /// Format: N 
        /// Length: 2 
        /// Definition: 0-8 Value as submitted by the pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimSegmentOtherCoverageCode { get; set; }

        /// <summary>
        /// Field #: 60
        /// Field Name: Medicaid Code 
        /// Format: A 
        /// Length: 4 
        /// Definition: As keyed for Medicaid/Third Party payment
        /// </summary>
        [FieldFixedLength(4)]
        public string ClaimSegmentMedicaidCode { get; set; }

        /// <summary>
        /// Field #: 61
        /// Field Name: Medicaid Name 
        /// Format: A 
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string ClaimSegmentMedicaidName { get; set; }

        /// <summary>
        /// Field #: 62
        /// Field Name: Coupon Number 
        /// Format: A 
        /// Length: 15
        /// Definition:  Coupon Number submitted by the pharmacy
        /// </summary>
        [FieldFixedLength(15)]
        public string ClaimSegmentCouponNumber { get; set; }

        /// <summary>
        /// Field #: 63
        /// Field Name: Pharmacy National Provider ID (NPI) 
        /// Format: AN 
        /// Length: 15
        /// Definition:  NPI assigned to Pharmacy
        /// </summary>
        [FieldFixedLength(15)]
        public string ClaimSegmentPharmacyNationalProviderId { get; set; }

        /// <summary>
        /// Field #: 64
        /// Field Name: Pharmacy ID Qualifier submitted 
        /// Format: AN 
        /// Length: 2 
        /// Definition: Pharmacy ID Qualifier submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimSegmentPharmacyIdQualifierSubmitted { get; set; }

        /// <summary>
        /// Field #: 65
        /// Field Name: Calculated FED MAC 
        /// Format: D 
        /// Length: 10
        /// Definition:  The quantity multiplied by the per unit FED value at time of file
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentCalculatedFedmac { get; set; }

        /// <summary>
        /// Field #: 66
        /// Field Name: Calculated AWP Source 
        /// Format: N 
        /// Length: 1 
        /// Definition: AWP value provided by: 1= FDB, 2= MediSpan
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentCalculatedAwpSource { get; set; }

        /// <summary>
        /// Field #: 67
        /// Field Name: Calculated WAC 
        /// Format: D 
        /// Length: 10
        /// Definition:  The quantity multiplied by the per unit WAC value at time of claims file build.
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentCalculatedWac { get; set; }

        /// <summary>
        /// Field #: 68
        /// Field Name: Coupon Actual Use Number 
        /// Format: N 
        /// Length: 3
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimSegmentCouponActualUseNumber { get; set; }

        /// <summary>
        /// Field #: 69
        /// Field Name: Processed Single Source Generic Indicator 
        /// Format: AN 
        /// Length: 1 
        /// Value: 0,1,2, blank
        /// Definition: 0=Not SSG; 1=SSG; 2=SSG in GCNSEQ; blank=undetermined
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentProcessedSingleSourceGenericIndicator { get; set; }

        /// <summary>
        /// Field #: 70
        /// Field Name: Manufacturer Name 
        /// Format: AN 
        /// Length: 20
        /// </summary>
        [FieldFixedLength(20)]
        public string ClaimSegmentManufacturerName { get; set; }

        /// <summary>
        /// Field #: 71 
        /// Field Name: Adjudicated Unit Price 
        /// Format: D 
        /// Length: 12 
        /// Definition: Per unit price used in final adjudicated calculation
        /// </summary>
        [FieldFixedLength(12)]
        public string ClaimSegmentAdjudicatedUnitPrice { get; set; }

        /// <summary>
        /// Field #: 72 
        /// Field Name: Pre-Copay Rounding Amount 
        /// Format: D 
        /// Length: 10 
        /// Definition: Claim Calculation prior to invoke of claim rounding edit.
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimSegmentPreCopayRoundingAmount { get; set; }

        /// <summary>
        /// Field #: 73 
        /// Field Name: Number of Coupon Uses 
        /// Format: N 
        /// Length: 1 
        /// Definition: Number of counted coupon uses applied to the transaction.
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimSegmentNumberOfCouponUses { get; set; }

        /// <summary>
        /// Field #: 74 
        /// Field Name: Combined Coupon Uses 
        /// Format: N 
        /// Length: 3 
        /// Definition: Combined coupon uses across all linked coupons.
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimSegmentCombinedCouponUses { get; set; }

        /// <summary>
        /// Field #: 75 
        /// Field Name: Reject Reprocess Original Authorization # 
        /// Format: AN 
        /// Length: 20 
        /// Definition: The Authorization # of the originally processed claim in a Rejection Re-Route/Reprocess scenario.
        /// </summary>
        [FieldFixedLength(20)]
        public string ClaimSegmentRejectReprocessOriginalAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 76 
        /// Field Name: Reserved for Future Use 
        /// Length: 119
        /// </summary>
        [FieldFixedLength(119)]
        public string ClaimSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Claim Indicator Segment

        /// <summary>
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1 
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2 
        /// Field Name: Segment Identifier ( CI ) 
        /// Format: AN 
        /// Length: 2 
        /// Value: CI
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimIndicatorSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3 
        /// Field Name: Paper Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1"= processed as Paper Claim
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentPaperClaimFlag { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: Direct Reimbursement Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as a Direct Member Reimbursement
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentDirectReimbursementFlag { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: Test Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as a Test claim
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentTestClaimFlag { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: Batch Processed Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed via batch mode
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentBatchProcessedFlag { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: Other Processor Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = inserted from external processing system
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentOtherProcessorFlag { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: Formulary Drug Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Formulary" per plan setup
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentFormularyDrugFlag { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: Network Pharmacy Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Network Pharmacy" per plan setup
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentNetworkPharmacyFlag { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name:  Network Physician Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as"Network Physician" per plan setup
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentNetworkPhysicianFlag { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name:  Shoebox Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Shoebox" claim per plan setup
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentShoeboxClaimFlag { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name:  Product/QTY Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Cognitive Services", "2" = processed as "Gross Price"
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentProductQtyClaimFlag { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name:  Starter Dose Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as Starter Dose limited first dose per plan setup
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentStarterDoseFlag { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name:  Prior Auth Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = a Prior Authorization (Manual or Automatic) was used in processing the claim
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentPriorAuthFlag { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name:  DUR Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim incurred a DUR rejection or warning
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentDurFlag { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name:  DUR Override Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim incurred an override of at least one DUR occurrence
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentDurOverrideFlag { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name:  I/G Copay Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim incurred an I/G difference copayment
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentIgCopayFlag { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name:  Multi Ingred Compound Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim is a compound utilizing the Compound Segment
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentMultiIngredCompoundFlag { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name:  Partial Fill Dispensing Status 
        /// Format: A 
        /// Length: 1 
        /// Value: P,C 
        /// Definition: "P" = initial partial fill, "C" = completion of partial fill
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentPartialFillDispensingStatus { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name:  Medicaid Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed as Medicaid Claim
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentMedicaidFlag { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name:  Force U&C Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1,2,3 
        /// Definition: “1” = plan edit forced price to U&C, “2”=user forced U&C, "3"=Force U&C/PA
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentForceUcFlag { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name:  NDC Remapped 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed with a Remapped NDC
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentNdcRemapped { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name:  Force $0 Pharmacy Due 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed with pharmacy due forced to $0
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentForcePharmacyDue { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name: Additional Lower of / State Rate Used 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = State Rate used for reimbursement as part of lower of. 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentAdditionalLowerOfStateRateUsed { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name: POS Medicaid Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed as a POS Medicaid claim. 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentPosMedicaidFlag { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name: Alternate Processing Bypass 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1,2,3,4 
        /// Definition: "1"= Bypass via Prior Auth, "2"= Carrier Bypass Invoked, "3"= '404' returned on a B1, claim processed as a standard non debit claim; "4" = Timed out Transaction (zz). 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentAlternateProcessingBypass { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name: Tax Exempt Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as Tax Exempt 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentTaxExemptIndicator { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name: Alternate Drug Record 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed based on Alternate Drug File 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentAlternateDrugRecord { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name: Claim Rounding Used 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = Claim Rounding was used in final price response 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentClaimRoundingUsed { get; set; }

        /// <summary>
        /// Field #: 30
        /// Field Name: Medical Claim Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = Originating Claim was from a Medical Distributor 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentMedicalClaimIndicator { get; set; }

        /// <summary>
        /// Field #: 31
        /// Field Name: Compensable Claim Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = Claim is determined to be compensable 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentCompensableClaimIndicator { get; set; }

        /// <summary>
        /// Field #: 32
        /// Field Name: Data Feed Transaction 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = An attempt to send transaction data via data feed was made. 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimIndicatorSegmentDataFeedTransaction { get; set; }

        /// <summary>
        /// Field #: 33
        /// Field Name: Reserved for Future Use 
        /// Format: N 
        /// Length: 27
        /// </summary>
        [FieldFixedLength(27)]
        public string ClaimIndicatorSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Addtl. Patient Info Segment

        /// <summary>
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2 
        /// Field Name: Segment Identifier ( PT ) 
        /// Format: AN 
        /// Length: 2
        /// Value: PT
        /// </summary>
        [FieldFixedLength(2)]
        public string AddtlPatientInfoSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3 
        /// Field Name: Cardholder Last Name 
        /// Format: AN 
        /// Length: 15
        /// Definition: Value associated with Primary/Cardholder record
        /// </summary>
        [FieldFixedLength(15)]
        public string AddtlPatientInfoSegmentCardholderLastName { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: Cardholder First Name 
        /// Format: AN 
        /// Length: 12
        /// Definition: Value associated with Primary/Cardholder record
        /// </summary>
        [FieldFixedLength(12)]
        public string AddtlPatientInfoSegmentCardholderFirstName { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: Patient Middle Initial 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentPatientMiddleInitial { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: Patient Name Suffix 
        /// Format: AN 
        /// Length: 3
        /// </summary>
        [FieldFixedLength(3)]
        public string AddtlPatientInfoSegmentPatientNameSuffix { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: Address Line 1 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string AddtlPatientInfoSegmentAddressLine1 { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: Address Line 2 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string AddtlPatientInfoSegmentAddressLine2 { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: City 
        /// Format: AN 
        /// Length: 18
        /// </summary>
        [FieldFixedLength(18)]
        public string AddtlPatientInfoSegmentCity { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name:  State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string AddtlPatientInfoSegmentState { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name:  Zip Code + 4 
        /// Format: N 
        /// Length: 9
        /// </summary>
        [FieldFixedLength(9)]
        public string AddtlPatientInfoSegmentZipCode { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name:  Phone Number 
        /// Format: N 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string AddtlPatientInfoSegmentPhoneNumber { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name:  Effective Date 
        /// Format: N 
        /// Length: 8
        /// </summary>
        [FieldFixedLength(8)]
        public string AddtlPatientInfoSegmentEffectiveDate { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name:  Termination Date 
        /// Format: N 
        /// Length: 8
        /// </summary>
        [FieldFixedLength(8)]
        public string AddtlPatientInfoSegmentTerminationDate { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name:  Date Of Birth 
        /// Format: N 
        /// Length: 8
        /// </summary>
        [FieldFixedLength(8)]
        public string AddtlPatientInfoSegmentDateOfBirth { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name:  Gender Code
        /// Format:  N 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentGenderCode { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name:  Relationship Code 
        /// Format: N 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentRelationshipCode { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name:  Coverage Code 
        /// Format: N 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentCoverageCode { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name:  Reserved for Future Use 
        /// Format: N 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentReservedForFutureUse1 { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name:  Student Flag 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1 
        /// Definition: "1" = true
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentStudentFlag { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name:  Reserved for Future Use 
        /// Format: N 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentReservedForFutureUse2 { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name:  Location Code 
        /// Format: AN 
        /// Length: 20
        /// Definition: Value associated with Member/Patient ID
        /// </summary>
        [FieldFixedLength(20)]
        public string AddtlPatientInfoSegmentLocationCode { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name:  Location Name 
        /// Format: AN 
        /// Length: 35
        /// Dfinition: Value associated with Location Code
        /// </summary>
        [FieldFixedLength(35)]
        public string AddtlPatientInfoSegmentLocationName { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name:  Secondary Coverage 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1
        /// Definition: "1" = true
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentSecondaryCoverage { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name:  Pharmacy Lock-in 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1 
        /// Definition: "1" = true, lock-in exists
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentPharmacyLockIn { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name:  Physician Lock-in 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1 
        /// Definition: "1" = true, lock-in exists
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentPhysicianLockIn { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name:  Test Member Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1
        /// Definition: "1" = true B
        /// </summary>
        [FieldFixedLength(1)]
        public string AddtlPatientInfoSegmentTestMemberFlag { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name:  Eligibility Created By User ID 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string AddtlPatientInfoSegmentEligibilityCreatedByUserId { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name:  Eligibility Created Date 
        /// Format: N 
        /// Length: 8
        /// Definition: Date initial eligibility record was created
        /// </summary>
        [FieldFixedLength(8)]
        public string AddtlPatientInfoSegmentEligibilityCreatedDate { get; set; }

        /// <summary>
        /// Field #: 30
        /// Field Name:  Eligibility Modified By User ID 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string AddtlPatientInfoSegmentEligibilityModifiedByUserId { get; set; }

        /// <summary>
        /// Field #: 31
        /// Field Name:  Eligibility Modified Date 
        /// Format: N 
        /// Length: 8
        /// Definition: Date of most recent eligibility modification 
        /// </summary>
        [FieldFixedLength(8)]
        public string AddtlPatientInfoSegmentEligibilityModifiedDate { get; set; }

        /// <summary>
        /// Field #: 32
        /// Field Name:  Reserved for Future Use 
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string AddtlPatientInfoSegmentReservedForFutureUse3 { get; set; }

        #endregion

        #region Claim Reject Segment

        /// <summary>
        /// Firld #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimRejectSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Firld #: 2 
        /// Field Name: Segment Identifier ( RJ ) 
        /// Format: AN 
        /// Length: 2
        /// Value: RJ
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimRejectSegmentIdentifier { get; set; }

        /// <summary>
        /// Firld #: 3 
        /// Field Name: Reject Code 1 
        /// Format: AN 
        /// Length: 3
        /// Value: NCPDP Rejection Code
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentRejectCode1 { get; set; }

        /// <summary>
        /// Firld #: 4 
        /// Field Name: Reject Code 2 
        /// Format: AN 
        /// Length: 3
        /// Definition: NCPDP Rejection Code 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentRejectCode2 { get; set; }

        /// <summary>
        /// Firld #: 5 
        /// Field Name: Reject Code 3 
        /// Format: AN 
        /// Length: 3
        /// Definition:  NCPDP Rejection Code 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentRejectCode3 { get; set; }

        /// <summary>
        /// Firld #: 6 
        /// Field Name: Reject Code 4 
        /// Format: AN 
        /// Length: 3
        /// Definition:  NCPDP Rejection Code 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentRejectCode4 { get; set; }

        /// <summary>
        /// Firld #: 7 
        /// Field Name: Reject Code 5 
        /// Format: AN 
        /// Length: 3
        /// Definition:  NCPDP Rejection Code 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentRejectCode5 { get; set; }

        /// <summary>
        /// Firld #: 8 
        /// Field Name: ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 1 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentEccRejectCode1 { get; set; }

        /// <summary>
        /// Firld #: 9 
        /// Field Name: ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 2 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentEccRejectCode2 { get; set; }

        /// <summary>
        /// Firld #: 10
        /// Field Name:  ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 3 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentEccRejectCode3 { get; set; }

        /// <summary>
        /// Firld #: 11
        /// Field Name:  ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 4 
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentEccRejectCode4 { get; set; }

        /// <summary>
        /// Firld #: 12
        /// Field Name:  ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition: Error clarification code for Rej Code 5
        /// </summary>
        [FieldFixedLength(3)]
        public string ClaimRejectSegmentEccRejectCode5 { get; set; }

        #endregion

        #region Prior Authorization Segment

        /// <summary>
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1 
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string PriorAuthorizationSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2 
        /// Field Name: Segment Identifier ( PA ) 
        /// Format: AN
        /// Length: 2
        /// Value: PA
        /// </summary>
        [FieldFixedLength(2)]
        public string PriorAuthorizationSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3 
        /// Field Name: PA Type Submitted 
        /// Format: N 
        /// Length: 2
        /// Definition: NCPDP PA Type ("01")
        /// </summary>
        [FieldFixedLength(2)]
        public string PriorAuthorizationSegmentPaTypeSubmitted { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: PA # Submitted 
        /// Format: N 
        /// Length: 11
        /// Definition: PA Number submitted by pharmacy
        /// </summary>
        [FieldFixedLength(11)]
        public string PriorAuthorizationSegmentPaNumberSubmitted { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: Actual PA # Used 
        /// Format: N 
        /// Length: 11
        /// Definition: PA Number utilized in processing
        /// </summary>
        [FieldFixedLength(11)]
        public string PriorAuthorizationSegmentActualPaNumberUsed { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: PA Type - Manual/Auto 
        /// Format: A 
        /// Length: 1
        /// Value: A,M 
        /// Definition: "A" = Automatic, "M" = Manual
        /// </summary>
        [FieldFixedLength(1)]
        public string PriorAuthorizationSegmentPaTypeManualAuto { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: PA Effective Date 
        /// Format: N 
        /// Length:8
        /// Definition: Effective date associated with PA record used
        /// </summary>
        [FieldFixedLength(8)]
        public string PriorAuthorizationSegmentPaEffectiveDate { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: PA Termination Date 
        /// Format: N 
        /// Length: 8
        /// Definition: Termination date associated with PA record used 
        /// </summary>
        [FieldFixedLength(8)]
        public string PriorAuthorizationSegmentPaTerminationDate { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: PA Description 
        /// Format: AN
        /// Length: 35 
        /// Definition: Description associated with PA record used 
        /// </summary>
        [FieldFixedLength(35)]
        public string PriorAuthorizationSegmentPaDescription { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name:  Reserved for Future Use 
        /// Length: 30
        /// </summary>
        [FieldFixedLength(30)]
        public string PriorAuthorizationSegmentReservedForFutureUse { get; set; }

        #endregion

        #region DUR Segment

        /// <summary>
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN
        /// Length: 1
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2 
        /// Field Name: Segment Identifier ( DU ) 
        /// Format: AN
        /// Length: 2
        /// Value: DU
        /// </summary>
        [FieldFixedLength(2)]
        public string DurSegmentSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3 
        /// Field Name: DUR 1 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>

        [FieldFixedLength(2)]
        public string DurSegmentDur1ConflictCode { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: DUR 1 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur1SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: DUR 1 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur1HitDisposition { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: DUR 1 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        [FieldFixedLength(20)]
        public string DurSegmentDur1ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: DUR 2 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        [FieldFixedLength(2)]
        public string DurSegmentDur2ConflictCode { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: DUR 2 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>

        [FieldFixedLength(1)]
        public string DurSegmentDur2SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: DUR 2 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur2HitDisposition { get; set; }

        /// <summary>
        /// Field #: 10 
        /// Field Name: DUR 2 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        [FieldFixedLength(20)]
        public string DurSegmentDur2ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 11 
        /// Field Name: DUR 3 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        [FieldFixedLength(2)]
        public string DurSegmentDur3ConflictCode { get; set; }

        /// <summary>
        /// Field #: 12 
        /// Field Name: DUR 3 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur3SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 13 
        /// Field Name: DUR 3 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R 
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur3HitDisposition { get; set; }

        /// <summary>
        /// Field #: 14 
        /// Field Name: DUR 3 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        [FieldFixedLength(20)]
        public string DurSegmentDur3ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 15 
        /// Field Name: DUR 4 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        [FieldFixedLength(2)]
        public string DurSegmentDur4ConflictCode { get; set; }

        /// <summary>
        /// Field #: 16 
        /// Field Name: DUR 4 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur4SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 17 
        /// Field Name: DUR 4 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R 
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur4HitDisposition { get; set; }

        /// <summary>
        /// Field #: 18 
        /// Field Name: DUR 4 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        [FieldFixedLength(20)]
        public string DurSegmentDur4ConflictingAuthorizationNumber { get; set; }

        /// <summary>
        /// Field #: 19 
        /// Field Name: DUR 5 Conflict Code 
        /// Format: AN
        /// Length: 2
        /// Definition: NCPCP Conflict code incurred
        /// </summary>
        [FieldFixedLength(2)]
        public string DurSegmentDur5ConflictCode { get; set; }

        /// <summary>
        /// Field #: 20 
        /// Field Name: DUR 5 Severity Index 
        /// Format: AN
        /// Length: 1
        /// Definition: NCPDP Severity code, if applicable
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur5SeverityIndex { get; set; }

        /// <summary>
        /// Field #: 21 
        /// Field Name: DUR 5 Hit Disposition 
        /// Format: AN
        /// Length: 1
        /// Value: A,R 
        /// Definition: "A" = Advisory, "R" = Reject, blank = no notification to pharmacy per plan
        /// </summary>
        [FieldFixedLength(1)]
        public string DurSegmentDur5HitDisposition { get; set; }

        /// <summary>
        /// Field #: 22 
        /// Field Name: DUR 5 Conflicting Authorization Number 
        /// Format: AN
        /// Length: 20
        /// Definition: Auth Number of conflicting Rx, if applicable
        /// </summary>
        [FieldFixedLength(20)]
        public string DurSegmentDur5ConflictingAuthorizationNumber { get; set; }

        #endregion

        #region Submitted DUR Override Segment

        /// <summary>
        /// Field #: 1 
        /// Field Name: Segment Separator Character
        /// Format: AN
        /// Length: 1
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string SubmittedDurOverrideSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2 
        /// Field Name: Segment Identifier ( DO ) 
        /// Format: AN 
        /// Length: 2 
        /// Value: DO
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3
        /// Field Name: Reason for Service (Conflict) 1 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Reason for Service submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentReasonForServiceConflict1 { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Professional Service Code (Intervention) 1 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Profess Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention1 { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Result of Service Code (Outcome) 1 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Result of Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome1 { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Reason for Service (Conflict) 2 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Reason for Service submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentReasonForServiceConflict2 { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Professional Service Code (Intervention) 2 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Profess Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention2 { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Result of Service Code (Outcome) 2 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Result of Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome2 { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Reason for Service (Conflict) 3 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Reason for Service submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentReasonForServiceConflict3 { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: Professional Service Code (Intervention) 3 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Profess Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention3 { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Result of Service Code (Outcome) 3 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Result of Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome3 { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: Reason for Service (Conflict) 4 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Reason for Service submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentReasonForServiceConflict4 { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: Professional Service Code (Intervention) 4 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Profess Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention4 { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Result of Service Code (Outcome) 4 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Result of Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome4 { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: Reason for Service (Conflict) 5 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Reason for Service submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentReasonForServiceConflict5 { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name: Professional Service Code (Intervention) 5 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Profess Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentProfessionalServiceCodeIntervention5 { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name: Result of Service Code (Outcome) 5 
        /// Format: AN
        /// Length: 2 
        /// Definition: NCPDP Result of Service Code submitted by pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string SubmittedDurOverrideSegmentResultOfServiceCodeOutcome5 { get; set; }

        #endregion

        #region Drug Classification Segment

        /// <summary> 
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1 
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentSeparatorCharacter { get; set; }

        /// <summary> 
        /// Field #: 2 
        /// Field Name: Segment Identifier ( DC ) 
        /// Format: AN 
        /// Length: 2 
        /// Value: DC
        /// </summary>
        [FieldFixedLength(2)]
        public string DrugClassificationSegmentIdentifier { get; set; }

        /// <summary> 
        /// Field #: 3 
        /// Field Name: Category Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentCategoryCode { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: Class Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentClassCode { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: GC1 Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentGc1Code { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: GC2 Code 
        /// Format: AN 
        /// Length: 2 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(2)]
        public string DrugClassificationSegmentGc2Code { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: GC3 Code 
        /// Format: AN 
        /// Length: 3 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(3)]
        public string DrugClassificationSegmentGc3Code { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: GC4 Code 
        /// Format: AN 
        /// Length: 4 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(4)]
        public string DrugClassificationSegmentGc4Code { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: Specific Therapeutic Class 
        /// Format: AN 
        /// Length: 3 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(3)]
        public string DrugClassificationSegmentSpecificTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: GCN Code 
        /// Format: N 
        /// Length: 5 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(5)]
        public string DrugClassificationSegmentGcnCode { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: GCN Sequence Number 
        /// Format: N 
        /// Length: 6 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(6)]
        public string DrugClassificationSegmentGcnSequenceNumber { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: Standard Therapeutic Class 
        /// Format: N 
        /// Length: 2 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(2)]
        public string DrugClassificationSegmentStandardTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: Generic Therapeutic Class 
        /// Format: N 
        /// Length: 2 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(2)]
        public string DrugClassificationSegmentGenericTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: AHFS Therapeutic Class 
        /// Format: N 
        /// Length: 6 
        /// Definition: Code from Drug file
        /// </summary>
        [FieldFixedLength(6)]
        public string DrugClassificationSegmentAhfsTherapeuticClass { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: Orange Book Code 
        /// Format: AN 
        /// Length: 3 
        /// Definition: Code from Drug file
        /// </summary>
        [FieldFixedLength(3)]
        public string DrugClassificationSegmentOrangeBookCode { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: Route of Administration Code 
        /// Format: AN 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentRouteOfAdministrationCode { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: Drug Form Code (Unit of Measure) 
        /// Format: N 
        /// Length: 1 
        /// Definition: FDB Code from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentDrugFormCodeUnitOfMeasure { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: DEA Code 
        /// Format: N 
        /// Length: 1 
        /// Definition: Code from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentDeaCode { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: Maintenance Drug Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentMaintenanceDrugIndicator { get; set; }

        /// <summary> 
        /// Field #: 20 
        /// Field Name: Unit of Use Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentUnitOfUseIndicator { get; set; }

        /// <summary> 
        /// Field #: 21 
        /// Field Name: Repackage Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentRepackageIndicator { get; set; }

        /// <summary> 
        /// Field #: 22 
        /// Field Name: Unit Dose Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentUnitDoseIndicator { get; set; }

        /// <summary> 
        /// Field #: 23 
        /// Field Name: DESI Drug Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = true, from Drug file
        /// </summary>
        [FieldFixedLength(1)]
        public string DrugClassificationSegmentDesiDrugIndicator { get; set; }

        /// <summary> 
        /// Field #: 24 
        /// Field Name: Drug Obsolete Date 
        /// Format: N 
        /// Length: 8 
        /// Definition: Date that NDC became obsolete
        /// </summary>
        [FieldFixedLength(8)]
        public string DrugClassificationSegmentDrugObsoleteDate { get; set; }

        /// <summary> 
        /// Field #: 25 
        /// Field Name: Medispan GPI 
        /// Format: AN 
        /// Length: 14 
        /// Value: Medispan Code from Drug file
        /// </summary>
        [FieldFixedLength(14)]
        public string DrugClassificationSegmentMedispanGpi { get; set; }

        /// <summary> 
        /// Field #: 26 
        /// Field Name: Reserved for Future Use 
        /// Length: 11
        /// </summary>
        [FieldFixedLength(11)]
        public string DrugClassificationSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Pharmacy Segment

        /// <summary>
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string PharmacySegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2 
        /// Field Name: Segment Identifier ( PH ) 
        /// Format: AN 
        /// Length: 2
        /// Value: PH
        /// </summary>
        [FieldFixedLength(2)]
        public string PharmacySegmentIdentifier { get; set; }

        /// <summary> 
        /// Field #: 3 
        /// Field Name: Physical Address Line 1 
        /// Format: AN
        /// Lenght: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string PharmacySegmentPhysicalAddressLine1 { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: Physical Address Line 2 
        /// Format: AN
        /// Lenght: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string PharmacySegmentPhysicalAddressLine2 { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: Physical City 
        /// Format: AN
        /// Lenght: 18
        /// </summary>
        [FieldFixedLength(18)]
        public string PharmacySegmentPhysicalCity { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: Physical State 
        /// Format: AN
        /// Lenght: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string PharmacySegmentPhysicalState { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: Physical Zip Code + 4 
        /// Format: N
        /// Lenght: 9
        /// </summary>
        [FieldFixedLength(9)]
        public string PharmacySegmentPhysicalZipCode { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: Phone Number 
        /// Format: N
        /// Lenght: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string PharmacySegmentPhoneNumber { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: Reserved for Future Use 
        /// Format: AN
        /// Lenght: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string PharmacySegmentReservedForFutureUse1 { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: Fax Number 
        /// Format: N
        /// Lenght: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string PharmacySegmentFaxNumber { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: Federal License Number 
        /// Format: AN
        /// Lenght: 12
        /// </summary>
        [FieldFixedLength(12)]
        public string PharmacySegmentFederalLicenseNumber { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: Federal Tax ID Number 
        /// Format: AN
        /// Lenght: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string PharmacySegmentFederalTaxIdNumber { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: State License Number 
        /// Format: AN
        /// Lenght: 20
        /// </summary>
        [FieldFixedLength(20)]
        public string PharmacySegmentStateLicenseNumber { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: State Tax ID Number 
        /// Format: AN
        /// Lenght: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string PharmacySegmentStateTaxIdNumber { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: State Medicaid Number 
        /// Format: AN
        /// Lenght: 20
        /// </summary>
        [FieldFixedLength(20)]
        public string PharmacySegmentStateMedicaidNumber { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: Pharmacy Store Number 
        /// Format: AN
        /// Lenght: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string PharmacySegmentPharmacyStoreNumber { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: Test Pharmacy Flag 
        /// Format: N
        /// Lenght: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string PharmacySegmentTestPharmacyFlag { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: Pharmacist ID Qualifier 
        /// Format: AN
        /// Lenght: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string PharmacySegmentPharmacistIdQualifier { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: Pharmacist ID 
        /// Format: AN
        /// Lenght: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string PharmacySegmentPharmacistId { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name: Primary Pharmacy Dispenser Type 
        /// Format: N 
        /// Length: 2
        /// Definition: Numeric Value indicating the Primary Dispenser Type for the Pharmacy
        /// </summary>
        [FieldFixedLength(2)]
        public string PharmacySegmentPrimaryPharmacyDispenserType { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name: Reserved for Future Use 
        /// Length: 6
        /// </summary>
        [FieldFixedLength(6)]
        public string PharmacySegmentReservedForFutureUse2 { get; set; }

        #endregion

        #region Prescriber Segment

        /// <summary>
        /// Field #: 1
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1 
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string PrescriberSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2
        /// Field Name: Segment Identifier ( PR ) 
        /// Format: AN 
        /// Length: 2 
        /// Value: PR
        /// </summary>
        [FieldFixedLength(2)]
        public string PrescriberSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3
        /// Field Name: Business Activity Code 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string PrescriberSegmentBusinessActivityCode { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Drug Schedules 
        /// Format: AN 
        /// Length: 12
        /// </summary>
        [FieldFixedLength(12)]
        public string PrescriberSegmentDrugSchedules { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Address Line 1 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        [FieldFixedLength(40)]
        public string PrescriberSegmentAddressLine1 { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Address Line 2 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        [FieldFixedLength(40)]
        public string PrescriberSegmentAddressLine2 { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Address Line 3 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        [FieldFixedLength(40)]
        public string PrescriberSegmentAddressLine3 { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Address Line 4 
        /// Format: AN 
        /// Length: 33
        /// </summary>
        [FieldFixedLength(33)]
        public string PrescriberSegmentAddressLine4 { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: City 
        /// Format: AN 
        /// Length: 24
        /// </summary>
        [FieldFixedLength(24)]
        public string PrescriberSegmentCity { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string PrescriberSegmentState { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Zip Code 
        /// Format: N 
        /// Length: 5
        /// </summary>
        [FieldFixedLength(5)]
        public string PrescriberSegmentZipCode { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: DEA 
        /// Format: AN 
        /// Length: 9
        /// </summary>
        [FieldFixedLength(9)]
        public string PrescriberSegmentDea { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: NPI 
        /// Format: N 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string PrescriberSegmentNpi { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Prescriber ID Qualifier 
        /// Format: N 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string PrescriberSegmentPrescriberIdQualifier { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: Reserved for Future Use 
        /// Length: 4
        /// </summary>
        [FieldFixedLength(4)]
        public string PrescriberSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Enhanced Prescriber Segment

        /// <summary> 
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format : AN 
        /// Length: 1 
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string EnhancedPrescriberSegmentSeparatorCharacter { get; set; }

        /// <summary> 
        /// Field #: 2 
        /// Field Name: Segment Identifier ( EP ) 
        /// Format : AN 
        /// Length: 2 
        /// Value: EP
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentIdentifier { get; set; }

        /// <summary> 
        /// Field #: 3 
        /// Field Name: Prescriber Name 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        [FieldFixedLength(35)]
        public string EnhancedPrescriberSegmentPrescriberName { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: DEA 
        /// Format: AN 
        /// Length: 9
        /// </summary>
        [FieldFixedLength(9)]
        public string EnhancedPrescriberSegmentDea { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: NPI 
        /// Format: N 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string EnhancedPrescriberSegmentNpi { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: Business Activity Code 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string EnhancedPrescriberSegmentBusinessActivityCode { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: Business Activity Sub Code 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        [FieldFixedLength(1)]
        public string EnhancedPrescriberSegmentBusinessActivitySubCode { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: Drug Schedules 
        /// Format: AN 
        /// Length: 12
        /// </summary>
        [FieldFixedLength(12)]
        public string EnhancedPrescriberSegmentDrugSchedules { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: Address Line 1 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        [FieldFixedLength(40)]
        public string EnhancedPrescriberSegmentAddressLine1 { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: Address Line 2 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        [FieldFixedLength(40)]
        public string EnhancedPrescriberSegmentAddressLine2 { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: City 
        /// Format: AN 
        /// Length: 24
        /// </summary>
        [FieldFixedLength(24)]
        public string EnhancedPrescriberSegmentCity { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentState { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: Zip Code + 4 
        /// Format: N 
        /// Length: 9
        /// </summary>
        [FieldFixedLength(9)]
        public string EnhancedPrescriberSegmentZipCode { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: Phone 
        /// Format: N 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string EnhancedPrescriberSegmentPhone { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: Fax # 
        /// Format: N 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string EnhancedPrescriberSegmentFaxNumber { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: Credentials 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        [FieldFixedLength(10)]
        public string EnhancedPrescriberSegmentCredentials { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: Practitioner Type 
        /// Format: AN 
        /// Length: 25
        /// </summary>
        [FieldFixedLength(25)]
        public string EnhancedPrescriberSegmentPractitionerType { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: Specialty 1 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        [FieldFixedLength(40)]
        public string EnhancedPrescriberSegmentSpecialty1 { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: Specialty 2 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        [FieldFixedLength(40)]
        public string EnhancedPrescriberSegmentSpecialty2 { get; set; }

        /// <summary> 
        /// Field #: 20 
        /// Field Name: State License #1 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string EnhancedPrescriberSegmentStateLicenseNumber1 { get; set; }

        /// <summary> 
        /// Field #: 21 
        /// Field Name: State License #1 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentStateLicenseNumber1State { get; set; }

        /// <summary> 
        /// Field #: 22 
        /// Field Name: State License #2 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string EnhancedPrescriberSegmentStateLicenseNumber2 { get; set; }

        /// <summary> 
        /// Field #: 23 
        /// Field Name: State License #2 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentStateLicenseNumber2State { get; set; }

        /// <summary> 
        /// Field #: 24 
        /// Field Name: State License #3 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string EnhancedPrescriberSegmentStateLicenseNumber3 { get; set; }

        /// <summary> 
        /// Field #: 25 
        /// Field Name: State License #3 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentStateLicenseNumber3State { get; set; }

        /// <summary> 
        /// Field #: 26 
        /// Field Name: Medicaid ID #1 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string EnhancedPrescriberSegmentMedicaidIdNumber1 { get; set; }

        /// <summary> 
        /// Field #: 27 
        /// Field Name: Medicaid ID #1 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentMedicaidIdNumber1State { get; set; }

        /// <summary> 
        /// Field #: 28 
        /// Field Name: Medicaid ID #2 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string EnhancedPrescriberSegmentMedicaidIdNumber2 { get; set; }

        /// <summary> 
        /// Field #: 29 
        /// Field Name: Medicaid ID #2 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentMedicaidIdNumber2State { get; set; }

        /// <summary> 
        /// Field #: 30 
        /// Field Name: Medicaid ID #3 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        [FieldFixedLength(15)]
        public string EnhancedPrescriberSegmentMedicaidIdNumber3 { get; set; }

        /// <summary> 
        /// Field #: 31 
        /// Field Name: Medicaid ID #3 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentMedicaidIdNumber3State { get; set; }

        /// <summary> 
        /// Field #: 32 
        /// Field Name: Tax ID 
        /// Format: AN 
        /// Length: 9
        /// </summary>
        [FieldFixedLength(9)]
        public string EnhancedPrescriberSegmentTaxId { get; set; }

        /// <summary> 
        /// Field #: 33 
        /// Field Name: Expiration Date 
        /// Format: N 
        /// Length: 8
        /// </summary>
        [FieldFixedLength(8)]
        public string EnhancedPrescriberSegmentExpirationDate { get; set; }

        /// <summary> 
        /// Field #: 34 
        /// Field Name: Prescriber ID Qualifier 
        /// Format: N 
        /// Length: 2
        /// </summary>
        [FieldFixedLength(2)]
        public string EnhancedPrescriberSegmentPrescriberIdQualifier { get; set; }

        /// <summary>
        /// Field #: 35 
        /// Field Name: Reserved for Future Use 
        /// Lenght: 99
        /// </summary>
        [FieldFixedLength(99)]
        public string EnhancedPrescriberSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Workers' Compensation Segment

        /// <summary> 
        /// Field #: 1 
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1 
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string WorkersCompensationSegmentSeparatorCharacter { get; set; }

        /// <summary> 
        /// Field #: 2 
        /// Field Name: Segment Identifier ( WC ) 
        /// Format: AN 
        /// Length: 2 
        /// Value: WC
        /// </summary>
        [FieldFixedLength(2)]
        public string WorkersCompensationSegmentIdentifier { get; set; }

        /// <summary> 
        /// Field #: 3 
        /// Field Name: WC Date of Injury 
        /// Format: N 
        /// Length: 8 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(8)]
        public string WorkersCompensationSegmentWcDateOfInjury { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: WC Claim Number 
        /// Format: AN 
        /// Length: 14 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(14)]
        public string WorkersCompensationSegmentWcClaimNumber { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: WC Record Claim Number - Info Only 
        /// Format: AN 
        /// Length: 14 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(14)]
        public string WorkersCompensationSegmentWcRecordClaimNumberInfoOnly { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: WC Record Adjustor Code 
        /// Format: AN 
        /// Length: 10 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(10)]
        public string WorkersCompensationSegmentWcRecordAdjustorCode { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: WC Employer Name 
        /// Format: AN 
        /// Length: 35 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(35)]
        public string WorkersCompensationSegmentWcEmployerName { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: WC Employer Address 1 
        /// Format: AN 
        /// Length: 35 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(35)]
        public string WorkersCompensationSegmentWcEmployerAddress1 { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: WC Employer Address 2 
        /// Format: AN 
        /// Length: 35 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(35)]
        public string WorkersCompensationSegmentWcEmployerAddress2 { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: WC Employer City 
        /// Format: AN 
        /// Length: 18 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(18)]
        public string WorkersCompensationSegmentWcEmployerCity { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: WC Employer State AN 2 173 174 Value associated w/ Work Comp record used in processing the claim or as submitted B
        /// </summary>
        [FieldFixedLength(2)]
        public string WorkersCompensationSegmentWcEmployerState { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: WC Employer Zip Code 
        /// Format: N 
        /// Length: 9 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(9)]
        public string WorkersCompensationSegmentWcEmployerZipCode { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: WC Employer Phone Number 
        /// Format: N 
        /// Length: 10 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        [FieldFixedLength(10)]
        public string WorkersCompensationSegmentWcEmployerPhoneNumber { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: WC Record Therapy Category Code 1 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(6)]
        public string WorkersCompensationSegmentWcRecordTherapyCategoryCode1 { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: WC Record Therapy Category Code 2 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(6)]
        public string WorkersCompensationSegmentWcRecordTherapyCategoryCode2 { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: WC Record Therapy Category Code 3 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(6)]
        public string WorkersCompensationSegmentWcRecordTherapyCategoryCode3 { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: WC Record Therapy Category Code 4 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(6)]
        public string WorkersCompensationSegmentWcRecordTherapyCategoryCode4 { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: WC Record Therapy Category Code 5 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(6)]
        public string WorkersCompensationSegmentWcRecordTherapyCategoryCode5 { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: WC Record Termination Date 
        /// Format: N 
        /// Length: 8 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        [FieldFixedLength(8)]
        public string WorkersCompensationSegmentWcRecordTerminationDate { get; set; }

        /// <summary> 
        /// Field #: 20 
        /// Field Name: Reserved for Future Use 
        /// Length: 290
        /// </summary>
        [FieldFixedLength(290)]
        public string WorkersCompensationSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Claim Balances Segment

        /// <summary>
        /// Field #: 1
        /// Field Name: Segment Separator Character 
        /// Format: AN 
        /// Length: 1 
        /// Value: >
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimBalancesSegmentSeparatorCharacter { get; set; }

        /// <summary>
        /// Field #: 2
        /// Field Name: Segment Identifier ( CB ) 
        /// Format: AN 
        /// Length: 2 
        /// Value: CB
        /// </summary>
        [FieldFixedLength(2)]
        public string ClaimBalancesSegmentIdentifier { get; set; }

        /// <summary>
        /// Field #: 3
        /// Field Name: Individual Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Individual Member Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualMemberAmount { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Individual Sponsor Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualSponsorAmount { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Individual Starting Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualStartingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Individual Ending Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualEndingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Individual Remaining Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualRemainingDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Individual Starting Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualStartingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: Individual Ending Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualEndingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Individual Starting Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualStartingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: Individual Ending Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentIndividualEndingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: Individual Starting Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimBalancesSegmentIndividualStartingTierLevel { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Individual Ending Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimBalancesSegmentIndividualEndingTierLevel { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: Family Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name: Family Member Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyMemberAmount { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name: Family Sponsor Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilySponsorAmount { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name: Family Starting Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyStartingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name: Family Ending Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyEndingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name: Family Remaining Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyRemainingDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name: Family Starting Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyStartingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name: Family Ending Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyEndingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name: Family Starting Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyStartingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name: Family Ending Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentFamilyEndingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name: Family Starting Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimBalancesSegmentFamilyStartingTierLevel { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name: Family Ending Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimBalancesSegmentFamilyEndingTierLevel { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name: Card Value 
        /// Format: D 
        /// Length: 10 
        /// Definition: Dollar Amount Sent to Debit Card Vendor 
        /// </summary>
        [FieldFixedLength(10)]
        public string ClaimBalancesSegmentCardValue { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name: Rebate Adjustment 
        /// Format: D 
        /// Length: 7 
        /// </summary>
        [FieldFixedLength(7)]
        public string ClaimBalancesSegmentRebateAdjustment { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name: Reserved for Future Use 
        /// Length: 73
        /// </summary>
        [FieldFixedLength(73)]
        public string ClaimBalancesSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Paper Claim Info Segment

        [FieldFixedLength(1)] public string PaperClaimInfoSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string PaperClaimInfoSegmentIdentifier { get; set; }
        [FieldFixedLength(10)] public string PaperClaimInfoSegmentUserId { get; set; }
        [FieldFixedLength(4)] public string PaperClaimInfoSegmentTerminalId { get; set; }
        [FieldFixedLength(8)] public string PaperClaimInfoSegmentReceivedDateNumber1 { get; set; }
        [FieldFixedLength(8)] public string PaperClaimInfoSegmentReceivedDateNumber2 { get; set; }
        [FieldFixedLength(20)] public string PaperClaimInfoSegmentReferenceCode { get; set; }
        [FieldFixedLength(29)] public string PaperClaimInfoSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Plan Codes Used Segment

        [FieldFixedLength(1)] public string PlanCodesUsedSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string PlanCodesUsedSegmentIdentifier { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentLineOfBusinessCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentPlanNetworkCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentMarginNetworkCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentCommonFormularyCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentPlanFormulaCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentPharmacyFormulaCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentCommonMacCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentCopayCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentLevel2MessagingCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentMemberPlanCode { get; set; }
        [FieldFixedLength(10)] public string PlanCodesUsedSegmentPlanCommonMacCode { get; set; }
        [FieldFixedLength(70)] public string PlanCodesUsedSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Transaction Messaging

        [FieldFixedLength(1)] public string TransactionMessagingSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string TransactionMessagingSegmentIdentifier { get; set; }
        [FieldFixedLength(200)] public string TransactionMessagingSegmentTransactionMessage { get; set; }

        #endregion

        #region Submitted Member Segment

        [FieldFixedLength(1)] public string SubmittedMemberSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string SubmittedMemberSegmentIdentifier { get; set; }
        [FieldFixedLength(15)] public string SubmittedMemberSegmentSubmittedCardholderLastName { get; set; }
        [FieldFixedLength(15)] public string SubmittedMemberSegmentSubmittedPatientFirstName { get; set; }
        [FieldFixedLength(8)] public string SubmittedMemberSegmentSubmittedPatientDateofBirth { get; set; }
        [FieldFixedLength(1)] public string SubmittedMemberSegmentSubmittedGender { get; set; }
        [FieldFixedLength(80)] public string SubmittedMemberSegmentSubmittedPatientEmailAddress { get; set; }
        [FieldFixedLength(43)] public string SubmittedMemberSegmentReservedForFutureUse { get; set; }

        #endregion

        #region Enhanced Submitted Member Segment

        [FieldFixedLength(1)] public string EnhancedSubmittedMemberSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string EnhancedSubmittedMemberSegmentIdentifier { get; set; }
        [FieldFixedLength(15)] public string EnhancedSubmittedMemberSegmentSubmittedCardholderLastName { get; set; }
        [FieldFixedLength(15)] public string EnhancedSubmittedMemberSegmentSubmittedPatientFirstName { get; set; }
        [FieldFixedLength(8)] public string EnhancedSubmittedMemberSegmentSubmittedPatientDateOfBirth { get; set; }
        [FieldFixedLength(1)] public string EnhancedSubmittedMemberSegmentSubmittedGender { get; set; }
        [FieldFixedLength(80)] public string EnhancedSubmittedMemberSegmentSubmittedPatientEmailAddress { get; set; }
        [FieldFixedLength(30)] public string EnhancedSubmittedMemberSegmentSubmittedPatientStreetAddress { get; set; }
        [FieldFixedLength(20)] public string EnhancedSubmittedMemberSegmentSubmittedPatientCityAddress { get; set; }
        [FieldFixedLength(2)] public string EnhancedSubmittedMemberSegmentPatientStateProvinceAddress { get; set; }
        [FieldFixedLength(15)] public string EnhancedSubmittedMemberSegmentSubmittedPatientZipPostalCode { get; set; }
        [FieldFixedLength(100)] public string EnhancedSubmittedMemberSegmentFutureUse { get; set; }

        #endregion

        #region Addtl. Submitted Values Segment

        [FieldFixedLength(1)] public string AddtlSubmittedValuesSegmentSeparatorCharacter { get; set; }
        [FieldFixedLength(2)] public string AddtlSubmittedValuesSegmentIdentifier { get; set; }
        [FieldFixedLength(19)] public string AddtlSubmittedValuesSegmentSubmittedNdcNumber { get; set; }
        [FieldFixedLength(20)] public string AddtlSubmittedValuesSegmentSubmittedCardholderId { get; set; }
        [FieldFixedLength(1)] public string AddtlSubmittedValuesSegmentPrescriptionOriginCode { get; set; }
        [FieldFixedLength(2)] public string AddtlSubmittedValuesSegmentPrimaryOtherPayerIdQualifier { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedValuesSegmentPrimaryOtherPayerId { get; set; }
        [FieldFixedLength(2)] public string AddtlSubmittedValuesSegmentSubmittedNcpdpVersion { get; set; }
        [FieldFixedLength(15)] public string AddtlSubmittedValuesSegmentSubmittedGroupNumber { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedValuesSegmentSubmittedBin { get; set; }
        [FieldFixedLength(2)] public string AddtlSubmittedValuesSegmentSubmittedTransactionType { get; set; }
        [FieldFixedLength(10)] public string AddtlSubmittedValuesSegmentSoftwareVendorId { get; set; }
        [FieldFixedLength(106)] public string AddtlSubmittedValuesSegmentReservedForFutureUse { get; set; }

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