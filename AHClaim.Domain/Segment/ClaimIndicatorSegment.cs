namespace AHClaim.domain.Segment
{
    public class ClaimIndicatorSegment
    {
        /// <summary>
        /// Field #: 3 
        /// Field Name: Paper Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1"= processed as Paper Claim
        /// </summary>
        public string PaperClaimFlag { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: Direct Reimbursement Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as a Direct Member Reimbursement
        /// </summary>
        public string DirectReimbursementFlag { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: Test Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as a Test claim
        /// </summary>
        public string TestClaimFlag { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: Batch Processed Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed via batch mode
        /// </summary>
        public string BatchProcessedFlag { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: Other Processor Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = inserted from external processing system
        /// </summary>
        public string OtherProcessorFlag { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: Formulary Drug Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Formulary" per plan setup
        /// </summary>
        public string FormularyDrugFlag { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: Network Pharmacy Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Network Pharmacy" per plan setup
        /// </summary>
        public string NetworkPharmacyFlag { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name:  Network Physician Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as"Network Physician" per plan setup
        /// </summary>
        public string NetworkPhysicianFlag { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name:  Shoebox Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Shoebox" claim per plan setup
        /// </summary>
        public string ShoeboxClaimFlag { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name:  Product/QTY Claim Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as "Cognitive Services", "2" = processed as "Gross Price"
        /// </summary>
        public string ProductQtyClaimFlag { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name:  Starter Dose Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as Starter Dose limited first dose per plan setup
        /// </summary>
        public string StarterDoseFlag { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name:  Prior Auth Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = a Prior Authorization (Manual or Automatic) was used in processing the claim
        /// </summary>
        public string PriorAuthFlag { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name:  DUR Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim incurred a DUR rejection or warning
        /// </summary>
        public string DurFlag { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name:  DUR Override Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim incurred an override of at least one DUR occurrence
        /// </summary>
        public string DurOverrideFlag { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name:  I/G Copay Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim incurred an I/G difference copayment
        /// </summary>
        public string IgCopayFlag { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name:  Multi Ingred Compound Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = claim is a compound utilizing the Compound Segment
        /// </summary>
        public string MultiIngredCompoundFlag { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name:  Partial Fill Dispensing Status 
        /// Format: A 
        /// Length: 1 
        /// Value: P,C 
        /// Definition: "P" = initial partial fill, "C" = completion of partial fill
        /// </summary>
        public string PartialFillDispensingStatus { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name:  Medicaid Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed as Medicaid Claim
        /// </summary>
        public string MedicaidFlag { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name:  Force U&C Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1,2,3 
        /// Definition: “1” = plan edit forced price to U&C, “2”=user forced U&C, "3"=Force U&C/PA
        /// </summary>
        public string ForceUcFlag { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name:  NDC Remapped 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed with a Remapped NDC
        /// </summary>
        public string NdcRemapped { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name:  Force $0 Pharmacy Due 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed with pharmacy due forced to $0
        /// </summary>
        public string ForcePharmacyDue { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name: Additional Lower of / State Rate Used 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = State Rate used for reimbursement as part of lower of. 
        /// </summary>
        public string AdditionalLowerOfStateRateUsed { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name: POS Medicaid Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: “1” = processed as a POS Medicaid claim. 
        /// </summary>
        public string PosMedicaidFlag { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name: Alternate Processing Bypass 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1,2,3,4 
        /// Definition: "1"= Bypass via Prior Auth, "2"= Carrier Bypass Invoked, "3"= '404' returned on a B1, claim processed as a standard non debit claim; "4" = Timed out Transaction (zz). 
        /// </summary>
        public string AlternateProcessingBypass { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name: Tax Exempt Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed as Tax Exempt 
        /// </summary>
        public string TaxExemptIndicator { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name: Alternate Drug Record 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = processed based on Alternate Drug File 
        /// </summary>
        public string AlternateDrugRecord { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name: Claim Rounding Used 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = Claim Rounding was used in final price response 
        /// </summary>
        public string ClaimRoundingUsed { get; set; }

        /// <summary>
        /// Field #: 30
        /// Field Name: Medical Claim Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = Originating Claim was from a Medical Distributor 
        /// </summary>
        public string MedicalClaimIndicator { get; set; }

        /// <summary>
        /// Field #: 31
        /// Field Name: Compensable Claim Indicator 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = Claim is determined to be compensable 
        /// </summary>
        public string CompensableClaimIndicator { get; set; }

        /// <summary>
        /// Field #: 32
        /// Field Name: Data Feed Transaction 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1 
        /// Definition: "1" = An attempt to send transaction data via data feed was made. 
        /// </summary>
        public string DataFeedTransaction { get; set; }

        /// <summary>
        /// Field #: 33
        /// Field Name: Reserved for Future Use 
        /// Format: N 
        /// Length: 27
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}