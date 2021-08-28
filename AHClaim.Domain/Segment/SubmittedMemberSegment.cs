namespace AHClaim.domain.Segment
{
    public class SubmittedMemberSegment
    {
        /// <summary> 
        /// Field #: 3 
        /// Field Name: Submitted Cardholder Last Name 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string SubmittedCardholderLastName { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: Submitted Patient First Name 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string SubmittedPatientFirstName { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: Submitted Patient Date of Birth 
        /// Format: N 
        /// Length: 8
        /// </summary>
        public string SubmittedPatientDateofBirth { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: Submitted Gender 
        /// Format: AN 
        /// Length: 1
        /// Value: M, F, U 
        /// </summary>
        public string SubmittedGender { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: Submitted Patient Email Address 
        /// Format: AN 
        /// Length: 80
        /// </summary>
        public string SubmittedPatientEmailAddress { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: Reserved for Future Use 
        /// Length: 43
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}