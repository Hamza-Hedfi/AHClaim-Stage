namespace AHClaim.domain.Segment
{
    /// <summary>
    /// Workers' Compensation Segment
    /// </summary>
    public class WorkersCompensationSegment
    {
        /// <summary> 
        /// Field #: 3 
        /// Field Name: WC Date of Injury 
        /// Format: N 
        /// Length: 8 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcDateOfInjury { get; set; }

        /// <summary> 
        /// Field #: 4 
        /// Field Name: WC Claim Number 
        /// Format: AN 
        /// Length: 14 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcClaimNumber { get; set; }

        /// <summary> 
        /// Field #: 5 
        /// Field Name: WC Record Claim Number - Info Only 
        /// Format: AN 
        /// Length: 14 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordClaimNumberInfoOnly { get; set; }

        /// <summary> 
        /// Field #: 6 
        /// Field Name: WC Record Adjustor Code 
        /// Format: AN 
        /// Length: 10 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordAdjustorCode { get; set; }

        /// <summary> 
        /// Field #: 7 
        /// Field Name: WC Employer Name 
        /// Format: AN 
        /// Length: 35 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcEmployerName { get; set; }

        /// <summary> 
        /// Field #: 8 
        /// Field Name: WC Employer Address 1 
        /// Format: AN 
        /// Length: 35 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcEmployerAddress1 { get; set; }

        /// <summary> 
        /// Field #: 9 
        /// Field Name: WC Employer Address 2 
        /// Format: AN 
        /// Length: 35 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcEmployerAddress2 { get; set; }

        /// <summary> 
        /// Field #: 10 
        /// Field Name: WC Employer City 
        /// Format: AN 
        /// Length: 18 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcEmployerCity { get; set; }

        /// <summary> 
        /// Field #: 11 
        /// Field Name: WC Employer State AN 2 173 174 Value associated w/ Work Comp record used in processing the claim or as submitted B
        /// </summary>
        public string WcEmployerState { get; set; }

        /// <summary> 
        /// Field #: 12 
        /// Field Name: WC Employer Zip Code 
        /// Format: N 
        /// Length: 9 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcEmployerZipCode { get; set; }

        /// <summary> 
        /// Field #: 13 
        /// Field Name: WC Employer Phone Number 
        /// Format: N 
        /// Length: 10 
        /// Definition: Value associated w/ Work Comp record used in processing the claim or as submitted 
        /// </summary>
        public string WcEmployerPhoneNumber { get; set; }

        /// <summary> 
        /// Field #: 14 
        /// Field Name: WC Record Therapy Category Code 1 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordTherapyCategoryCode1 { get; set; }

        /// <summary> 
        /// Field #: 15 
        /// Field Name: WC Record Therapy Category Code 2 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordTherapyCategoryCode2 { get; set; }

        /// <summary> 
        /// Field #: 16 
        /// Field Name: WC Record Therapy Category Code 3 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordTherapyCategoryCode3 { get; set; }

        /// <summary> 
        /// Field #: 17 
        /// Field Name: WC Record Therapy Category Code 4 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordTherapyCategoryCode4 { get; set; }

        /// <summary> 
        /// Field #: 18 
        /// Field Name: WC Record Therapy Category Code 5 
        /// Format: AN 
        /// Length: 6 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordTherapyCategoryCode5 { get; set; }

        /// <summary> 
        /// Field #: 19 
        /// Field Name: WC Record Termination Date 
        /// Format: N 
        /// Length: 8 
        /// Definition: Value associated w/ Work Comp record used in processing the claim 
        /// </summary>
        public string WcRecordTerminationDate { get; set; }

        /// <summary> 
        /// Field #: 20 
        /// Field Name: Reserved for Future Use 
        /// Length: 290
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}