namespace AHClaim.Segment
{
    public class PriorAuthorizationSegment
    {
        /// <summary>
        /// Field #: 3 
        /// Field Name: PA Type Submitted 
        /// Format: N 
        /// Length: 2
        /// Definition: NCPDP PA Type ("01")
        /// </summary>
        public string PaTypeSubmitted { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: PA # Submitted 
        /// Format: N 
        /// Length: 11
        /// Definition: PA Number submitted by pharmacy
        /// </summary>
        public string PaNumberSubmitted { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: Actual PA # Used 
        /// Format: N 
        /// Length: 11
        /// Definition: PA Number utilized in processing
        /// </summary>
        public string ActualPaNumberUsed { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: PA Type - Manual/Auto 
        /// Format: A 
        /// Length: 1
        /// Value: A,M 
        /// Definition: "A" = Automatic, "M" = Manual
        /// </summary>
        public string PaTypeManualAuto { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: PA Effective Date 
        /// Format: N 
        /// Length:8
        /// Definition: Effective date associated with PA record used
        /// </summary>
        public string PaEffectiveDate { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: PA Termination Date 
        /// Format: N 
        /// Length: 8
        /// Definition: Termination date associated with PA record used 
        /// </summary>
        public string PaTerminationDate { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: PA Description 
        /// Format: AN
        /// Length: 35 
        /// Definition: Description associated with PA record used 
        /// </summary>
        public string PaDescription { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name:  Reserved for Future Use 
        /// Length: 30
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}