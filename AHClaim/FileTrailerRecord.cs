using FileHelpers;

namespace AHClaim
{
    [FixedLengthRecord]
    public class FileTrailerRecord
    {
        [FieldFixedLength(2)] public string TrailerRecordIndicator { get; set; }
        [FieldFixedLength(9)] public string ClaimCount { get; set; }
        [FieldFixedLength(9)] public string MicClaimCount { get; set; }
        [FieldFixedLength(6)] public string FileTrailerRecordFutureUse { get; set; }
    }
}