using FileHelpers;

namespace AHClaim.Record
{
    /// <summary>
    /// File Trailer Record
    /// </summary>
    [FixedLengthRecord]
    public class FileTrailerRecord
    {
        /// <summary>
        /// Field #: 1
        /// Field Name: Trailer Record Indicator ($T)
        /// Format: AN 
        /// Length: 2
        /// Values:
        /// Definition:
        /// </summary>
        [FieldFixedLength(2)]
        public string TrailerRecordIndicator { get; set; }

        /// <summary>
        /// Field #: 2
        /// Field Name: Claim Count
        /// Format: N
        /// Length: 9
        /// Values:
        /// Definition:
        /// </summary>
        [FieldFixedLength(9)]
        public string ClaimCount { get; set; }

        /// <summary>
        /// Field #: 3
        /// Field Name: MIC Claim Count
        /// Format: N 
        /// Length: 9
        /// Values:
        /// Definition:
        /// </summary>
        [FieldFixedLength(9)]
        public string MicClaimCount { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Future Use
        /// Format:
        /// Length: 6
        /// Values:
        /// Definition:
        /// </summary>
        [FieldFixedLength(6)]
        public string FileTrailerRecordFutureUse { get; set; }
    }
}