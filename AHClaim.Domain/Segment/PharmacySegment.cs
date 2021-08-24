namespace AHClaim.Segment
{
    public class PharmacySegment
    {
        /// <summary> 
        /// Field #: 3 
        /// Field Name: Physical Address Line 1 
        /// Format: AN
        /// Lenght: 35
        /// </summary>
        public string PhysicalAddressLine1 { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: Physical Address Line 2 
        /// Format: AN
        /// Lenght: 35
        /// </summary>
        public string PhysicalAddressLine2 { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: Physical City 
        /// Format: AN
        /// Lenght: 18
        /// </summary>
        public string PhysicalCity { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: Physical State 
        /// Format: AN
        /// Lenght: 2
        /// </summary>
        public string PhysicalState { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: Physical Zip Code + 4 
        /// Format: N
        /// Lenght: 9
        /// </summary>
        public string PhysicalZipCode { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: Phone Number 
        /// Format: N
        /// Lenght: 10
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: Reserved for Future Use 
        /// Format: AN
        /// Lenght: 10
        /// </summary>
        public string ReservedForFutureUse1 { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: Fax Number 
        /// Format: N
        /// Lenght: 10
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: Federal License Number 
        /// Format: AN
        /// Lenght: 12
        /// </summary>
        public string FederalLicenseNumber { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: Federal Tax ID Number 
        /// Format: AN
        /// Lenght: 15
        /// </summary>
        public string FederalTaxIdNumber { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: State License Number 
        /// Format: AN
        /// Lenght: 20
        /// </summary>
        public string StateLicenseNumber { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: State Tax ID Number 
        /// Format: AN
        /// Lenght: 15
        /// </summary>
        public string StateTaxIdNumber { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: State Medicaid Number 
        /// Format: AN
        /// Lenght: 20
        /// </summary>
        public string StateMedicaidNumber { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: Pharmacy Store Number 
        /// Format: AN
        /// Lenght: 10
        /// </summary>
        public string PharmacyStoreNumber { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: Test Pharmacy Flag 
        /// Format: N
        /// Lenght: 1
        /// </summary>
        public string TestPharmacyFlag { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: Pharmacist ID Qualifier 
        /// Format: AN
        /// Lenght: 2
        /// </summary>
        public string PharmacistIdQualifier { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: Pharmacist ID 
        /// Format: AN
        /// Lenght: 15
        /// </summary>
        public string PharmacistId { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name: Primary Pharmacy Dispenser Type 
        /// Format: N 
        /// Length: 2
        /// Definition: Numeric Value indicating the Primary Dispenser Type for the Pharmacy
        /// </summary>
        public string PrimaryPharmacyDispenserType { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name: Reserved for Future Use 
        /// Length: 6
        /// </summary>
        public string ReservedForFutureUse2 { get; set; }
    }
}