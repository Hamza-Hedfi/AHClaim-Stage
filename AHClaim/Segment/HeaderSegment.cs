namespace AHClaim.Segment
{
    /// <summary>
    /// Header Segment
    /// </summary>
    public class HeaderSegment
    {
        public string ClaimFileRecordIndicator { get; set; }
        public string VersionNumber { get; set; }
        public string MinorVersionNumber { get; set; }
    }
}