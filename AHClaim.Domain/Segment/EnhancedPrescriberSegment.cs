namespace AHClaim.domain.Segment
{
    /// <summary>
    /// Enhanced Prescriber Segment
    /// </summary>
    public class EnhancedPrescriberSegment
    {
        /// <summary> 
        /// Field #: 3 
        /// Field Name: Prescriber Name 
        /// Format: AN 
        /// Length: 35
        /// </summary>
        public string PrescriberName { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: DEA 
        /// Format: AN 
        /// Length: 9
        /// </summary>
        public string Dea { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: NPI 
        /// Format: N 
        /// Length: 10
        /// </summary>
        public string Npi { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: Business Activity Code 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        public string BusinessActivityCode { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: Business Activity Sub Code 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        public string BusinessActivitySubCode { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: Drug Schedules 
        /// Format: AN 
        /// Length: 12
        /// </summary>
        public string DrugSchedules { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: Address Line 1 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: Address Line 2 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: City 
        /// Format: AN 
        /// Length: 24
        /// </summary>
        public string City { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string State { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: Zip Code + 4 
        /// Format: N 
        /// Length: 9
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: Phone 
        /// Format: N 
        /// Length: 10
        /// </summary>
        public string Phone { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: Fax # 
        /// Format: N 
        /// Length: 10
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: Credentials 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string Credentials { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: Practitioner Type 
        /// Format: AN 
        /// Length: 25
        /// </summary>
        public string PractitionerType { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: Specialty 1 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        public string Specialty1 { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: Specialty 2 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        public string Specialty2 { get; set; }

        /// <summary> 
        /// Field #: 20 
        /// Field Name: State License #1 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string StateLicenseNumber1 { get; set; }

        /// <summary> 
        /// Field #: 21 
        /// Field Name: State License #1 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string StateLicenseNumber1State { get; set; }

        /// <summary> 
        /// Field #: 22 
        /// Field Name: State License #2 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string StateLicenseNumber2 { get; set; }

        /// <summary> 
        /// Field #: 23 
        /// Field Name: State License #2 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string StateLicenseNumber2State { get; set; }

        /// <summary> 
        /// Field #: 24 
        /// Field Name: State License #3 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string StateLicenseNumber3 { get; set; }

        /// <summary> 
        /// Field #: 25 
        /// Field Name: State License #3 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string StateLicenseNumber3State { get; set; }

        /// <summary> 
        /// Field #: 26 
        /// Field Name: Medicaid ID #1 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string MedicaidIdNumber1 { get; set; }

        /// <summary> 
        /// Field #: 27 
        /// Field Name: Medicaid ID #1 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string MedicaidIdNumber1State { get; set; }

        /// <summary> 
        /// Field #: 28 
        /// Field Name: Medicaid ID #2 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string MedicaidIdNumber2 { get; set; }

        /// <summary> 
        /// Field #: 29 
        /// Field Name: Medicaid ID #2 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string MedicaidIdNumber2State { get; set; }

        /// <summary> 
        /// Field #: 30 
        /// Field Name: Medicaid ID #3 
        /// Format: AN 
        /// Length: 15
        /// </summary>
        public string MedicaidIdNumber3 { get; set; }

        /// <summary> 
        /// Field #: 31 
        /// Field Name: Medicaid ID #3 State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string MedicaidIdNumber3State { get; set; }

        /// <summary> 
        /// Field #: 32 
        /// Field Name: Tax ID 
        /// Format: AN 
        /// Length: 9
        /// </summary>
        public string TaxId { get; set; }

        /// <summary> 
        /// Field #: 33 
        /// Field Name: Expiration Date 
        /// Format: N 
        /// Length: 8
        /// </summary>
        public string ExpirationDate { get; set; }

        /// <summary> 
        /// Field #: 34 
        /// Field Name: Prescriber ID Qualifier 
        /// Format: N 
        /// Length: 2
        /// </summary>
        public string PrescriberIdQualifier { get; set; }

        /// <summary>
        /// Field #: 35 
        /// Field Name: Reserved for Future Use 
        /// Lenght: 99
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}