namespace AHClaim.domain.Segment
{
    /// <summary>
    /// Claim Balances Segment
    /// </summary>
    public class ClaimBalancesSegment
    {
        /// <summary>
        /// Field #: 3
        /// Field Name: Individual Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Individual Member Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualMemberAmount { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Individual Sponsor Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualSponsorAmount { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Individual Starting Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualStartingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Individual Ending Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualEndingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Individual Remaining Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualRemainingDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Individual Starting Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualStartingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: Individual Ending Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualEndingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Individual Starting Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualStartingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: Individual Ending Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string IndividualEndingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: Individual Starting Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        public string IndividualStartingTierLevel { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: Individual Ending Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        public string IndividualEndingTierLevel { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: Family Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name: Family Member Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyMemberAmount { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name: Family Sponsor Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilySponsorAmount { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name: Family Starting Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyStartingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name: Family Ending Deductible Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyEndingDeductibleAccumulation { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name: Family Remaining Deductible Amount 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyRemainingDeductibleAmount { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name: Family Starting Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyStartingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name: Family Ending Member Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyEndingMemberAccumulation { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name: Family Starting Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyStartingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name: Family Ending Sponsor Accumulation 
        /// Format: D 
        /// Length: 10 
        /// </summary>
        public string FamilyEndingSponsorAccumulation { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name: Family Starting Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        public string FamilyStartingTierLevel { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name: Family Ending Tier Level 
        /// Format: N 
        /// Length: 1 
        /// </summary>
        public string FamilyEndingTierLevel { get; set; }

        /// <summary>
        /// Field #: 27
        /// Field Name: Card Value 
        /// Format: D 
        /// Length: 10 
        /// Definition: Dollar Amount Sent to Debit Card Vendor 
        /// </summary>
        public string CardValue { get; set; }

        /// <summary>
        /// Field #: 28
        /// Field Name: Rebate Adjustment 
        /// Format: D 
        /// Length: 7 
        /// </summary>
        public string RebateAdjustment { get; set; }

        /// <summary>
        /// Field #: 29
        /// Field Name: Reserved for Future Use 
        /// Length: 73
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}