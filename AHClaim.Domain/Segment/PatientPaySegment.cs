namespace AHClaim.domain.Segment
{
    public class PatientPaySegment
    {
        /// <summary>
        /// Field #: 3
        /// Field Name: Amt. Attributed to Processor Fee 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string AmtAttributedToProcessorFee { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Amount of Coinsurance 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string AmountOfCoinsurance { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Reserved for future defined Field 
        /// Format: A
        /// Length: 2
        /// </summary>
        public string ReservedForFutureDefinedField { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Reserved for future Pricing Field 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string ReservedForFuturePricingField1 { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Reserved for future Pricing Field 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string ReservedForFuturePricingField2 { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Amt. Attributed to Product Selection/Brand Drug 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string AmtAttributedToProductSelectionBrandDrug { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Amt. Attributed to Product Selection/NonPreferred Formulary Selection 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string AmtAttributedToProductSelectionNonPreferredFormularySelection { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: Amt. Attributed to Product Selection/Brand NonPreferred Formulary Selection 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string AmtAttributedToProductSelectionBrandNonPreferredFormularySelection { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Reserved for future Pricing Field 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string ReservedForFuturePricingField3 { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: Reserved for future Pricing Field
        /// Format: D
        /// Length: 10
        /// </summary>
        public string ReservedForFuturePricingField4 { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: Amount Attributed to Sales Tax 
        /// Format: D
        /// Length: 10
        /// </summary>
        public string AmountAttributedToSalesTax { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Reserved for Future Use 
        /// Length: 40
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}