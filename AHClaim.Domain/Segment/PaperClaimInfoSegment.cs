namespace AHClaim.domain.Segment
{
    public class PaperClaimInfoSegment
    {
        /// <summary> 
        /// Field # 3
        /// Field Name: User ID 
        /// Format: AN 
        /// Length: 10
        /// </summary>
        public string UserId { get; set; }

        /// <summary> 
        /// Field # 4
        /// Field Name: Terminal ID 
        /// Format: N
        /// Length: 4
        /// </summary>
        public string TerminalId { get; set; }

        /// <summary> 
        /// Field # 5
        /// Field Name: Received Date #1 
        /// Format: N
        /// Length: 8
        /// </summary>
        public string ReceivedDateNumber1 { get; set; }

        /// <summary> 
        /// Field # 6
        /// Field Name: Received Date #2 
        /// Format: N
        /// Length: 8
        /// </summary>
        public string ReceivedDateNumber2 { get; set; }

        /// <summary> 
        /// Field # 7
        /// Field Name: Reference Code 
        /// Format: AN
        /// Length: 20
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary> 
        /// Field # 8
        /// Field Name: Reserved for Future Use 
        /// Length: 29
        /// </summary>
        public string ReservedForFutureUse { get; set; }
    }
}