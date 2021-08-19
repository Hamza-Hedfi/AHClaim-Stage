using FileHelpers;

namespace AHClaim
{
    [FixedLengthRecord]
    public class HeaderRecord
    {
        [FieldFixedLength(2)] public string HeaderRecordIndicator { get; set; }
        [FieldFixedLength(3)] public string CarrierCode { get; set; }
        [FieldFixedLength(20)] public string FileName { get; set; }
        [FieldFixedLength(1)] public string WriteMode { get; set; }
        [FieldFixedLength(1)] public string OutputMode { get; set; }
        [FieldFixedLength(8)] public string DataProcessedFrom { get; set; }
        [FieldFixedLength(8)] public string DataProcessedThrough { get; set; }
        [FieldFixedLength(1)] public string ClaimType { get; set; }
        [FieldFixedLength(1)] public string SuppressInPeriodPdRv { get; set; }
        [FieldFixedLength(75)] public string SegmentOutput { get; set; }
        [FieldFixedLength(1)] public string SponsorRangeType { get; set; }
        [FieldFixedLength(10)] public string SponsorRangeFrom { get; set; }
        [FieldFixedLength(10)] public string SponsorRangeTo { get; set; }
        [FieldFixedLength(1)] public string TpaBrokerRangeType { get; set; }
        [FieldFixedLength(10)] public string TpaBrokerRangeFrom { get; set; }
        [FieldFixedLength(10)] public string TpaBrokerRangeTo { get; set; }
        [FieldFixedLength(1)] public string GroupRangeType { get; set; }
        [FieldFixedLength(15)] public string GroupRangeFrom { get; set; }
        [FieldFixedLength(15)] public string GroupRangeTo { get; set; }
        [FieldFixedLength(1)] public string NcPdPIdRangeType { get; set; }
        [FieldFixedLength(12)] public string NcPdPIdRangeFrom { get; set; }
        [FieldFixedLength(12)] public string NcPdPIdRangeTo { get; set; }
        [FieldFixedLength(1)] public string IncludeTestClaims { get; set; }
        [FieldFixedLength(1)] public string CreateMultiIngredientCompoundFile { get; set; }
        [FieldFixedLength(1)] public string DeIdentifyData { get; set; }
        [FieldFixedLength(40)] public string HeaderRecordFutureUse { get; set; }
    }
}