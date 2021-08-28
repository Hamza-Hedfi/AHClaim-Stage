namespace AHClaim.domain.Segment
{
    public class EnhancedSubmittedMemberSegment
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
        public string SubmittedPatientDateOfBirth { get; set; }

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
        /// Field Name: Submitted Patient Street Address 
        /// Format: AN
        /// Length: 30
        /// </summary>
        public string SubmittedPatientStreetAddress { get; set; }

        /// <summary> 
        /// Field #: 9
        /// Field Name: Submitted Patient City Address 
        /// Format: AN
        /// Length: 20
        /// </summary>
        public string SubmittedPatientCityAddress { get; set; }

        /// <summary> 
        /// Field #: 10
        /// Field Name: Patient State/Province Address 
        /// Format: AN
        /// Length: 2
        /// </summary>
        public string PatientStateProvinceAddress { get; set; }

        /// <summary> 
        /// Field #: 11
        /// Field Name: Submitted Patient Zip/Postal Code 
        /// Format: AN
        /// Length: 15
        /// </summary>
        public string SubmittedPatientZipPostalCode { get; set; }

        /// <summary> 
        /// Field #: 12
        /// Field Name: Future Use 
        /// Length: 100
        /// </summary>
        public string FutureUse { get; set; }
    }
}