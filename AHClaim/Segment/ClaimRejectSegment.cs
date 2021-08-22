namespace AHClaim.Segment
{
    public class ClaimRejectSegment
    {
        /// <summary>
        /// Firld #: 3 
        /// Field Name: Reject Code 1 
        /// Format: AN 
        /// Length: 3
        /// Value: NCPDP Rejection Code
        /// </summary>
        public string ClaimRejectSegmentRejectCode1 { get; set; }

        /// <summary>
        /// Firld #: 4 
        /// Field Name: Reject Code 2 
        /// Format: AN 
        /// Length: 3
        /// Definition: NCPDP Rejection Code 
        /// </summary>
        public string ClaimRejectSegmentRejectCode2 { get; set; }

        /// <summary>
        /// Firld #: 5 
        /// Field Name: Reject Code 3 
        /// Format: AN 
        /// Length: 3
        /// Definition:  NCPDP Rejection Code 
        /// </summary>
        public string ClaimRejectSegmentRejectCode3 { get; set; }

        /// <summary>
        /// Firld #: 6 
        /// Field Name: Reject Code 4 
        /// Format: AN 
        /// Length: 3
        /// Definition:  NCPDP Rejection Code 
        /// </summary>
        public string ClaimRejectSegmentRejectCode4 { get; set; }

        /// <summary>
        /// Firld #: 7 
        /// Field Name: Reject Code 5 
        /// Format: AN 
        /// Length: 3
        /// Definition:  NCPDP Rejection Code 
        /// </summary>
        public string ClaimRejectSegmentRejectCode5 { get; set; }

        /// <summary>
        /// Firld #: 8 
        /// Field Name: ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 1 
        /// </summary>
        public string ClaimRejectSegmentEccRejectCode1 { get; set; }

        /// <summary>
        /// Firld #: 9 
        /// Field Name: ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 2 
        /// </summary>
        public string ClaimRejectSegmentEccRejectCode2 { get; set; }

        /// <summary>
        /// Firld #: 10
        /// Field Name:  ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 3 
        /// </summary>
        public string ClaimRejectSegmentEccRejectCode3 { get; set; }

        /// <summary>
        /// Firld #: 11
        /// Field Name:  ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition:  Error clarification code for Rej Code 4 
        /// </summary>
        public string ClaimRejectSegmentEccRejectCode4 { get; set; }

        /// <summary>
        /// Firld #: 12
        /// Field Name:  ECC Reject Code 
        /// Format: AN 
        /// Length: 3
        /// Definition: Error clarification code for Rej Code 5
        /// </summary>
        public string ClaimRejectSegmentEccRejectCode5 { get; set; }
    }
}