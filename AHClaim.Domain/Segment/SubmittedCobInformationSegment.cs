namespace AHClaim.domain.Segment
{
    public class SubmittedCobInformationSegment
    {
        /// <summary> 
        /// Field #: 3
        /// Field Name: Coordination of Benefits / Other Payments Count 
        /// Format: AN
        /// Length: 1
        /// Value: 337-4C
        /// </summary>
        public string CoordinationOfBenefitsOtherPaymentsCount { get; set; }

        /// <summary> 
        /// Field #: 4
        /// Field Name: Other Payer Coverage Type - Primary Submission 
        /// Format: AN
        /// Length: 2
        /// Value: 338-5C
        /// </summary>
        public string OtherPayerCoverageTypePrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 5
        /// Field Name: Other Payer ID Qualifier - Primary Submission 
        /// Format: AN
        /// Length: 2
        /// Value: 339-6C
        /// </summary>
        public string OtherPayerIdQualifierPrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 6
        /// Field Name: Other Payer ID (BIN) - Primary Submission 
        /// Format: AN
        /// Length: 10
        /// Value: 340-7C
        /// </summary>
        public string OtherPayerIdBinPrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 7
        /// Field Name: Other Payer Date 
        /// Format: N
        /// Length: 8
        /// Definition: 443-E8 - format ccyymmdd 
        /// </summary>
        public string OtherPayerDatePrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 8
        /// Field Name: Reject Count - Primary Submission 
        /// Format: N
        /// Length: 2
        /// Definition: 471-5E 
        /// </summary>
        public string RejectCountPrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 9
        /// Field Name: Reject Code - Primary Submission 
        /// Format: AN
        /// Length: 3
        /// Definition: 472-6E 
        /// </summary>
        public string RejectCodePrimarySubmission1 { get; set; }

        /// <summary> 
        /// Field #: 10
        /// Field Name: Reject Code - Primary Submission 
        /// Format: AN
        /// Length: 3
        /// Definition: 472-6E 
        /// </summary>
        public string RejectCodePrimarySubmission2 { get; set; }

        /// <summary> 
        /// Field #: 11
        /// Field Name: Reject Code - Primary Submission 
        /// Format: AN
        /// Length: 3
        /// Definition: 472-6E 
        /// </summary>
        public string RejectCodePrimarySubmission3 { get; set; }

        /// <summary> 
        /// Field #: 12
        /// Field Name: Other Payer Patient Responsibilty Amount Qualifier 
        /// Format: AN
        /// Length: 14
        /// Definition: 351-NP ,If multiple qualifiers are submitted, the first 5 will be presented in this field with '-' as seperator. 
        /// </summary>
        public string OtherPayerPatientResponsibilityAmountQualifierPrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 13
        /// Field Name: Other Payer Patient Responsibility Amount SUM 
        /// Format: N
        /// Length: 10
        /// Definition: SUM of 352-NQ for identified Payer. If 06 submitted in qualifier, submitted value is provided, else all OPPRA amounts are summed 
        /// </summary>
        public string OtherPayerPatientResponsibilityAmountSumPrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 14
        /// Field Name: Other Payer Amount Paid - SUM 
        /// Format: N
        /// Length: 10
        /// Definition: SUM of 431-DV for identfied Payer 
        /// </summary>
        public string OtherPayerAmountPaidSumPrimarySubmission { get; set; }

        /// <summary> 
        /// Field #: 15
        /// Field Name: Other Payer Coverage Type - Secondary Submission 
        /// Format: AN
        /// Length: 2
        /// Definition: 338-5C
        /// </summary>
        public string OtherPayerCoverageTypeSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 16
        /// Field Name: Other Payer ID Qualifier - Secondary Submission 
        /// Format: AN
        /// Length: 2
        /// Definition: 339-6C
        /// </summary>
        public string OtherPayerIdQualifierSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 17
        /// Field Name: Other Payer ID (BIN) - Secondary Submission 
        /// Format: AN
        /// Length: 10
        /// Definition: 340-7C
        /// </summary>
        public string OtherPayerIdBinSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 18
        /// Field Name: Other Payer Date 
        /// Format: N
        /// Length: 8
        /// Definition: 443-E8 - format ccyymmdd
        /// </summary>
        public string OtherPayerDateSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 19
        /// Field Name: Reject Count - Secondary Submission 
        /// Format: N
        /// Length: 2
        /// Definition: 471-5E
        /// </summary>
        public string RejectCountSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 20
        /// Field Name: Reject Code - Secondary Submission 
        /// Format: AN
        /// Length: 3
        /// Definition: 472-6E
        /// </summary>
        public string RejectCodeSecondarySubmission1 { get; set; }

        /// <summary> 
        /// Field #: 21
        /// Field Name: Reject Code - Secondary Submission 
        /// Format: AN
        /// Length: 3
        /// Definition: 472-6E
        /// </summary>
        public string RejectCodeSecondarySubmission2 { get; set; }

        /// <summary> 
        /// Field #: 22
        /// Field Name: Reject Code - Secondary Submission 
        /// Format: AN
        /// Length: 3
        /// Definition: 472-6E
        /// </summary>
        public string RejectCodeSecondarySubmission3 { get; set; }

        /// <summary> 
        /// Field #: 23
        /// Field Name: Other Payer Patient Responsibility Amount Qualifier 
        /// Format: AN
        /// Length: 14 
        /// Definition: 351-NP, If multiple qualifiers are submitted, the first 5 will be presented in this field. 
        /// </summary>
        public string OtherPayerPatientResponsibilityAmountQualifierSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 24
        /// Field Name: Other Payer Patient Responsibility Amount SUM 
        /// Format: N
        /// Length: 10 
        /// Definition: SUM of 352-NQ for identified Payer. If 06 submitted in qualifier, submitted value is provided, else all OPPRA amounts are summed 
        /// </summary>
        public string OtherPayerPatientResponsibilityAmountSumSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 25
        /// Field Name: Other Payer Amount Paid - SUM 
        /// Format: N
        /// Length: 10 
        /// Definition: SUM of 431-DV for identfied Payer 
        /// </summary>
        public string OtherPayerAmountPaidSumSecondarySubmission { get; set; }

        /// <summary> 
        /// Field #: 26
        /// Field Name: Other Payer Coverage Type - Tertiary Submission 
        /// Format: AN
        /// Length: 2 
        /// Definition: 338-5C 
        /// </summary>
        public string Submission { get; set; }

        /// <summary> 
        /// Field #: 27
        /// Field Name: Other Payer ID Qualifier - Tertiary Submission 
        /// Format: AN
        /// Length: 2 
        /// Definition: 339-6C 
        /// </summary>
        public string OtherPayerIdQualifierTertiarySubmission { get; set; }

        /// <summary> 
        /// Field #: 28
        /// Field Name: Other Payer ID (BIN) - Tertiary Submission 
        /// Format: AN
        /// Length: 10 
        /// Definition: 340-7C 
        /// </summary>
        public string OtherPayerIdBinTertiarySubmission { get; set; }

        /// <summary> 
        /// Field #: 29
        /// Field Name: Other Payer Date 
        /// Format: N
        /// Length: 8 
        /// Definition: 443-E8 - format ccyymmdd 
        /// </summary>
        public string OtherPayerDateTertiarySubmission { get; set; }

        /// <summary> 
        /// Field #: 30
        /// Field Name: Reject Count - Tertiary Submission 
        /// Format: N
        /// Length: 2 
        /// Definition: 471-5E 
        /// </summary>
        public string RejectCountTertiarySubmission { get; set; }

        /// <summary> 
        /// Field #: 31
        /// Field Name: Reject Code - Tertiary Submission 
        /// Format: AN
        /// Length: 3 
        /// Definition: 472-6E 
        /// </summary>
        public string RejectCodeTertiarySubmission1 { get; set; }

        /// <summary> 
        /// Field #: 32
        /// Field Name: Reject Code - Tertiary Submission 
        /// Format: AN
        /// Length: 3 
        /// Definition: 472-6E 
        /// </summary>
        public string RejectCodeTertiarySubmission2 { get; set; }

        /// <summary> 
        /// Field #: 33
        /// Field Name: Reject Code - Tertiary Submission 
        /// Format: AN
        /// Length: 3 
        /// Definition: 472-6E 
        /// </summary>
        public string RejectCodeTertiarySubmission3 { get; set; }

        /// <summary> 
        /// Field #: 34
        /// Field Name: Other Payer Patient Responsibility Amount Qualifier 
        /// Format: AN
        /// Length: 14 
        /// Definition: 351-NP 
        /// </summary>
        public string OtherPayerPatientResponsibilityAmountQualifierTertiarySubmission { get; set; }

        /// <summary> 
        /// Field #: 35
        /// Field Name: Other Payer Patient Responsibility Amount SUM 
        /// Format: N
        /// Length: 10 
        /// Definition: SUM of 352-NQ for identified Payer. If 06 submitted in qualifier, submitted value is provided, else all OPPRA amounts are summed 
        /// </summary>
        public string OtherPayerPatientResponsibilityAmountSumTertiarySubmission { get; set; }

        /// <summary> 
        /// Field #: 36
        /// Field Name: Other Payer Amount Paid - SUM 
        /// Format: N
        /// Length: 10 
        /// Definition: SUM of 431-DV for identfied Payer 
        /// </summary>
        public string OtherPayerAmountPaidSumTertiarySubmission { get; set; }

        /// <summary> 
        /// Field #: 37
        /// Field Name: Other Payer (BIN) Name - Primary 
        /// Format: AN
        /// Length: 20
        /// </summary>
        public string OtherPayerBinNamePrimary { get; set; }

        /// <summary> 
        /// Field #: 38
        /// Field Name: Other Payer (BIN) Name - Secondary 
        /// Format: AN
        /// Length: 20
        /// </summary>
        public string OtherPayerBinNameSecondary { get; set; }

        /// <summary> 
        /// Field #: 39
        /// Field Name: Other Payer (BIN) Name - Tertiary 
        /// Format: AN
        /// Length: 20
        /// </summary>
        public string OtherPayerBinNameTertiary { get; set; }

        /// <summary> 
        /// Field #: 40
        /// Field Name: Benefit Stage Information Presented - Primary 
        /// Format: N
        /// Length: 1
        /// </summary>  
        public string BenefitStageInformationPresentedPrimary { get; set; }

        /// <summary> 
        /// Field #: 41
        /// Field Name: Benefit Stage Information Presented - Secondary 
        /// Format: N
        /// Length: 1
        /// </summary>
        public string BenefitStageInformationPresentedSecondary { get; set; }

        /// <summary> 
        /// Field #: 42 
        /// Field Name: Benefit Stage Information Presented - Tertiary 
        /// Format: N 
        /// Length: 1
        /// </summary>
        public string BenefitStageInformationPresentedTertiary { get; set; }

        /// <summary> 
        /// Field #: 43 
        /// Field Name: Future Use 
        /// Length: 33
        /// </summary>
        public string FutureUse { get; set; }
    }
}