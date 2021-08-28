namespace AHClaim.domain.Segment
{
    public class AddtlSubmittedValuesSegment
    {
        /// <summary> 
        /// Field #: 3 Submitted NDC Number 
        /// Format: N 
        /// Length: 19  
        /// Definition: Displays Submitted NDC if an NDC Remap Occurs
        /// </summary>
        public string SubmittedNdcNumber { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: Submitted Cardholder ID 
        /// Format: AN 
        /// Length: 20 
        /// </summary>
        public string SubmittedCardholderId { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: Prescription Origin Code 
        /// Format: N 
        /// Length: 1  
        /// Value: 0-5 
        /// Definition: Value as submitted by the pharmacy
        /// </summary>
        public string PrescriptionOriginCode { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: Primary Other Payer ID Qualifier 
        /// Format: N 
        /// Length: 2  
        /// Definition: Other Payer ID Qualifier as submitted by the pharmacy, etc.
        /// </summary>
        public string PrimaryOtherPayerIdQualifier { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: Primary Other Payer ID 
        /// Format: N 
        /// Length: 10 
        /// </summary>
        public string PrimaryOtherPayerId { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: Submitted NCPDP Version 
        /// Format: AN 
        /// Length: 2
        /// Definition: Identifies the submitted NCPDP version
        /// </summary>
        public string SubmittedNcpdpVersion { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: Submitted Group Number 
        /// Format: AN 
        /// Length: 15 
        /// </summary>
        public string SubmittedGroupNumber { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: Submitted BIN 
        /// Format: AN 
        /// Length: 10 
        /// </summary>
        public string SubmittedBin { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: Submitted Transaction Type 
        /// Format: AN 
        /// Length: 2 
        /// </summary>
        public string SubmittedTransactionType { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: Software Vendor ID 
        /// Format: AN 
        /// Length: 10 
        /// </summary>
        public string SoftwareVendorId { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: Reserved for Future  Use 
        /// Length: 106 
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}