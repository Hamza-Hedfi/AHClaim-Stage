namespace AHClaim.Segment
{
    public class AddtlPatientInfoSegment
    {
        /// <summary>
        /// Field #: 3 
        /// Field Name: Cardholder Last Name 
        /// Format: AN 
        /// Length: 15
        /// Definition: Value associated with Primary/Cardholder record
        /// </summary>
        public string CardholderLastName { get; set; }

        /// <summary>
        /// Field #: 4 
        /// Field Name: Cardholder First Name 
        /// Format: AN 
        /// Length: 12
        /// Definition: Value associated with Primary/Cardholder record
        /// </summary>
        public string CardholderFirstName { get; set; }

        /// <summary>
        /// Field #: 5 
        /// Field Name: Patient Middle Initial 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        public string PatientMiddleInitial { get; set; }

        /// <summary>
        /// Field #: 6 
        /// Field Name: Patient Name Suffix 
        /// Format: AN 
        /// Length: 3
        /// </summary>
        public string PatientNameSuffix { get; set; }

        /// <summary>
        /// Field #: 7 
        /// Field Name: Address Line 1 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Field #: 8 
        /// Field Name: Address Line 2 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Field #: 9 
        /// Field Name: City 
        /// Format: AN 
        /// Length: 18
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name:  State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name:  Zip Code + 4 
        /// Format: N 
        /// Length: 9
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name:  Phone Number 
        /// Format: N 
        /// Length: 10
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name:  Effective Date 
        /// Format: N 
        /// Length: 8
        /// </summary>
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name:  Termination Date 
        /// Format: N 
        /// Length: 8
        /// </summary>
        public string TerminationDate { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name:  Date Of Birth 
        /// Format: N 
        /// Length: 8
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name:  Gender Code
        /// Format:  N 
        /// Length: 1
        /// </summary>
        public string GenderCode { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name:  Relationship Code 
        /// Format: N 
        /// Length: 1
        /// </summary>
        public string RelationshipCode { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name:  Coverage Code 
        /// Format: N 
        /// Length: 1
        /// </summary>
        public string CoverageCode { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name:  Reserved for Future Use 
        /// Format: N 
        /// Length: 1
        /// </summary>
        public string ReservedForFutureUse1 { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name:  Student Flag 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1 
        /// Definition: "1" = true
        /// </summary>
        public string StudentFlag { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name:  Reserved for Future Use 
        /// Format: N 
        /// Length: 1
        /// </summary>
        public string ReservedForFutureUse2 { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name:  Location Code 
        /// Format: AN 
        /// Length: 20
        /// Definition: Value associated with Member/Patient ID
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name:  Location Name 
        /// Format: AN 
        /// Length: 35
        /// Dfinition: Value associated with Location Code
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name:  Secondary Coverage 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1
        /// Definition: "1" = true
        /// </summary>
        public string SecondaryCoverage { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name:  Pharmacy Lock-in 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1 
        /// Definition: "1" = true, lock-in exists
        /// </summary>
        public string PharmacyLockIn { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name:  Physician Lock-in 
        /// Format: N 
        /// Length: 1
        /// Value: 0,1 
        /// Definition: "1" = true, lock-in exists
        /// </summary>
        public string PhysicianLockIn { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name:  Test Member Flag 
        /// Format: N 
        /// Length: 1 
        /// Value: 0,1
        /// Definition: "1" = true B
        /// </summary>
        public string TestMemberFlag { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name:  Eligibility Created By User ID 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string EligibilityCreatedByUserId { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name:  Eligibility Created Date 
        /// Format: N 
        /// Length: 8
        /// Definition: Date initial eligibility record was created
        /// </summary>
        public string EligibilityCreatedDate { get; set; }

        /// <summary>
        /// Field #: 30
        /// Field Name:  Eligibility Modified By User ID 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string EligibilityModifiedByUserId { get; set; }

        /// <summary>
        /// Field #: 31
        /// Field Name:  Eligibility Modified Date 
        /// Format: N 
        /// Length: 8
        /// Definition: Date of most recent eligibility modification 
        /// </summary>
        public string EligibilityModifiedDate { get; set; }

        /// <summary>
        /// Field #: 32
        /// Field Name:  Reserved for Future Use 
        /// Length: 15
        /// </summary>
        public string ReservedForFutureUse3 { get; set; }
    }
}