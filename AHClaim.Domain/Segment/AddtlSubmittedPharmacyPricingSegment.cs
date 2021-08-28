namespace AHClaim.domain.Segment
{
    public class AddtlSubmittedPharmacyPricingSegment
    {
        /// <summary>
        /// Field #: 3
        /// Field Name: Submitted U&C 
        /// Format: D
        /// Length: 10 
        /// Definition: Value submitted by pharmacy 
        /// </summary>
        public string SubmittedUc { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Submitted Ingredient Cost 
        /// Format: D
        /// Length: 10 
        /// Definition: Value submitted by pharmacy 
        /// </summary>
        public string SubmittedIngredientCost { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Submitted Dispensing Fee 
        /// Format: D
        /// Length: 10 
        /// Definition: Value submitted by pharmacy 
        /// </summary>
        public string SubmittedDispensingFee { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Submitted Sales Tax 
        /// Format: D
        /// Length: 10 
        /// Definition: Value submitted by pharmacy 
        /// </summary>
        public string SubmittedSalesTax { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Submitted Gross Amount 
        /// Format: D
        /// Length: 10 
        /// Definition: Value submitted by pharmacy 
        /// </summary>
        public string SubmittedGrossAmount { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Submitted Copay Amount 
        /// Format: D
        /// Length: 10 
        /// Definition: Value submitted by pharmacy 
        /// </summary>
        public string SubmittedCopayAmount { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Reserved for Future Use 
        /// Length: 24
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}