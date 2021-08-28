namespace AHClaim.domain.Segment
{
    public class PharmacyPricingSegment
    {
        /// <summary> 
        /// Field #: 3
        /// Field Name: Pharmacy Ingredient Cost 
        /// Format: D
        /// Length: 10 
        /// </summary>
        public string PharmacyIngredientCost { get; set; }

        /// <summary> 
        /// Field #: 4
        /// Field Name: Pharmacy Dispensing Fee 
        /// Format: D
        /// Length: 10 
        /// </summary>
        public string PharmacyDispensingFee { get; set; }

        /// <summary> 
        /// Field #: 5
        /// Field Name: Pharmacy Sales Tax 
        /// Format: D
        /// Length: 10 
        /// </summary>
        public string PharmacySalesTax { get; set; }

        /// <summary> 
        /// Field #: 6
        /// Field Name: Pharmacy Gross Amount 
        /// Format: D
        /// Length: 10 
        /// Definition: Equals sum of fields 3, 4, 5 and Claim Segment field 49. 
        /// </summary>
        public string PharmacyGrossAmount { get; set; }

        /// <summary> 
        /// Field #: 7
        /// Field Name: Pharmacy Copay Amount 
        /// Format: D
        /// Length: 10 
        /// </summary>
        public string PharmacyCopayAmount { get; set; }

        /// <summary> 
        /// Field #: 8
        /// Field Name: Pharmacy Due Amount 
        /// Format: D
        /// Length: 10 
        /// Definition: Equals field 6 less field 7 
        /// </summary>
        public string PharmacyDueAmount { get; set; }

        /// <summary> 
        /// Field #: 9
        /// Field Name: Pharmacy Basis of Cost 
        /// Format: AN
        /// Length: 3 
        /// Value: AWP, FED, MAC, WAC 
        /// Definition: Calculation basis used prior to U&C compare 
        /// </summary>
        public string PharmacyBasisOfCost { get; set; }

        /// <summary> 
        /// Field #: 10
        /// Field Name: Pharmacy Basis of Reimbursement 
        /// Format: N
        /// Length: 3 
        /// Definition: Actual lower of basis used as per NCPDP defined Basis of Reimbursement codes 
        /// </summary>
        public string PharmacyBasisOfReimbursement { get; set; }

        /// <summary> 
        /// Field #: 11
        /// Field Name: Pharmacy Calculated Amount 
        /// Format: D
        /// Length: 10 
        /// </summary>
        public string PharmacyCalculatedAmount { get; set; }

        /// <summary> 
        /// Field #: 12
        /// Field Name: Processor Fee (User Fee) 
        /// Format: D
        /// Length: 10 
        /// Definition: The Plan User Fee assessed at time of transaction 
        /// </summary>
        public string ProcessorFee { get; set; }

        /// <summary> 
        /// Field #: 13
        /// Field Name: Reserved for Future Use 
        /// Length: 3
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}