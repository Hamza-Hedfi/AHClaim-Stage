namespace AHClaim.domain.Segment
{
    public class PlanCodesUsedSegment
    {
        ///<summary>
        /// Field #: 3
        /// Field Name: Line of Business Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string LineOfBusinessCode { get; set; }

        ///<summary>
        /// Field #: 4
        /// Field Name: Plan Network Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string PlanNetworkCode { get; set; }

        ///<summary>
        /// Field #: 5
        /// Field Name: Margin Network Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string MarginNetworkCode { get; set; }

        ///<summary>
        /// Field #: 6
        /// Field Name: Common Formulary Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string CommonFormularyCode { get; set; }

        ///<summary>
        /// Field #: 7
        /// Field Name: Plan Formula Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string PlanFormulaCode { get; set; }

        ///<summary>
        /// Field #: 8
        /// Field Name: Pharmacy Formula Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string PharmacyFormulaCode { get; set; }

        ///<summary>
        /// Field #: 9
        /// Field Name: Common MAC Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string CommonMacCode { get; set; }

        ///<summary>
        /// Field #: 10
        /// Field Name: Copay Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string CopayCode { get; set; }

        ///<summary>
        /// Field #: 11
        /// Field Name: Level 2 Messaging Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string Level2MessagingCode { get; set; }

        ///<summary>
        /// Field #: 12
        /// Field Name: Member Plan Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string MemberPlanCode { get; set; }

        ///<summary>
        /// Field #: 13
        /// Field Name: Plan Common MAC Code
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string PlanCommonMacCode { get; set; }

        ///<summary>
        /// Field #: 14
        /// Field Name: Reserved for Future Use 
        /// Length: 70
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}