namespace AHClaim.domain.Segment
{
    public class PrescriberSegment
    {
        /// <summary>
        /// Field #: 3
        /// Field Name: Business Activity Code 
        /// Format: AN 
        /// Length: 1
        /// </summary>
        public string BusinessActivityCode { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Drug Schedules 
        /// Format: AN 
        /// Length: 12
        /// </summary>
        public string DrugSchedules { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Address Line 1 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Address Line 2 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Address Line 3 
        /// Format: AN 
        /// Length: 40
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Address Line 4 
        /// Format: AN 
        /// Length: 33
        /// </summary>
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: City 
        /// Format: AN 
        /// Length: 24
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: State 
        /// Format: AN 
        /// Length: 2
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Zip Code 
        /// Format: N 
        /// Length: 5
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: DEA 
        /// Format: AN 
        /// Length: 9
        /// </summary>
        public string Dea { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: NPI 
        /// Format: N 
        /// Length: 10
        /// </summary>
        public string Npi { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Prescriber ID Qualifier 
        /// Format: N 
        /// Length: 2
        /// </summary>
        public string PrescriberIdQualifier { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: Reserved for Future Use 
        /// Length: 4
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}