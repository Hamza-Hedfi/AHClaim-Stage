using FileHelpers;

namespace AHClaim.Record
{
    /// <summary>
    /// Header Record
    /// </summary>
    [FixedLengthRecord]
    public class HeaderRecord
    {
        /// <summary>
        /// Field #: 1
        /// Field Name: Header Record Indicator ($H)
        /// Format: AN 
        /// Length: 2
        /// Values: $H
        /// Definition:
        /// </summary>
        [FieldFixedLength(2)]
        public string HeaderRecordIndicator { get; set; }

        /// <summary>
        /// Field #: 2
        /// Field Name: Carrier code
        /// Format: AN
        /// Length: 3
        /// Values:
        /// Definition: Carrier code as processed
        /// </summary>
        [FieldFixedLength(3)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Field #: 3
        /// Field Name: File Name
        /// Format: AN 
        /// Length: 20
        /// Values:
        /// Definition: Name assigned by user, or default
        /// </summary>
        [FieldFixedLength(20)]
        public string FileName { get; set; }

        /// <summary>
        /// Field #: 4
        /// Field Name: Write Mode
        /// Format: AN 
        /// Length: 1
        /// Values: O, A
        /// Definition: "O" = Overwrite, "A" = Append
        /// </summary>
        [FieldFixedLength(1)]
        public string WriteMode { get; set; }

        /// <summary>
        /// Field #: 5
        /// Field Name: Output Type
        /// Format: AN 
        /// Length: 1
        /// Values: D, F
        /// Definition: "D" = Delimited, "F"= Fixed Length
        /// </summary>
        [FieldFixedLength(1)]
        public string OutputMode { get; set; }

        /// <summary>
        /// Field #: 6
        /// Field Name: Date Processed From
        /// Format: N
        /// Length: 8
        /// Values:
        /// Definition:
        /// </summary>
        [FieldFixedLength(8)]
        public string DataProcessedFrom { get; set; }

        /// <summary>
        /// Field #: 7
        /// Field Name: Date Processed Through
        /// Format: N 
        /// Length: 8
        /// Values:
        /// Definition: 
        /// </summary>
        [FieldFixedLength(8)]
        public string DataProcessedThrough { get; set; }

        /// <summary>
        /// Field #: 8
        /// Field Name: Claims Type
        /// Format: AN 
        /// Length: 1
        /// Values: A, P, R
        /// Definition: "A" = All, "P" = Paid, "R"=Rejected
        /// </summary>
        [FieldFixedLength(1)]
        public string ClaimsType { get; set; }

        /// <summary>
        /// Field #: 9
        /// Field Name: Suppress in Period PD/RV
        /// Format: N 
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = suppression applied of matching paid/reversal within specified file processed date range
        /// </summary>
        [FieldFixedLength(1)]
        public string SuppressInPeriodPdRv { get; set; }

        /// <summary>
        /// Field #: 10
        /// Field Name: Segment Output
        /// Format: AN 
        /// Length: 75
        /// Values:
        /// Definition: String of selected Segment Identifier codes selected, separated by a "-"
        /// </summary>
        [FieldFixedLength(75)]
        public string SegmentOutput { get; set; }

        /// <summary>
        /// Field #: 11
        /// Field Name: Sponsor Range Type
        /// Format: AN 
        /// Length: 1
        /// Values: N, R, M, C, B, E
        /// Definition: "N"=None, "R"=Range, "M"=Matches, "C"=Contains, "B"=Begins With, "E"=Ends With
        /// </summary>
        [FieldFixedLength(1)]
        public string SponsorRangeType { get; set; }

        /// <summary>
        /// Field #: 12
        /// Field Name: Sponsor Range From
        /// Format: AN 
        /// Length: 10
        /// Values:
        /// Definition: Value entered to select conditional range
        /// </summary>
        [FieldFixedLength(10)]
        public string SponsorRangeFrom { get; set; }

        /// <summary>
        /// Field #: 13
        /// Field Name: Sponsor Range To
        /// Format: AN 
        /// Length: 10
        /// Values:
        /// Definition: Value entered to select conditional range
        /// </summary>
        [FieldFixedLength(10)]
        public string SponsorRangeTo { get; set; }

        /// <summary>
        /// Field #: 14
        /// Field Name: TPA/Broker Range Type
        /// Format: AN 
        /// Length: 1
        /// Values: N, R, M, C, B, E
        /// Definition: "N"=None, "R"=Range, "M"=Matches, "C"=Contains, "B"=Begins With, "E"=Ends With
        /// </summary>
        [FieldFixedLength(1)]
        public string TpaBrokerRangeType { get; set; }

        /// <summary>
        /// Field #: 15
        /// Field Name: TPA/Broker Range From 
        /// Format: AN 
        /// Length: 10
        /// Values:
        /// Definition: Value entered to select conditional range
        /// </summary>
        [FieldFixedLength(10)]
        public string TpaBrokerRangeFrom { get; set; }

        /// <summary>
        /// Field #: 16
        /// Field Name: TPA/Broker Range To
        /// Format: AN 
        /// Length: 10
        /// Values:
        /// Definition: Value entered to select conditional range
        /// </summary>
        [FieldFixedLength(10)]
        public string TpaBrokerRangeTo { get; set; }

        /// <summary>
        /// Field #: 17
        /// Field Name: Group Range Type 
        /// Format: AN 
        /// Length: 1
        /// Values: N, R, M, C, B, E
        /// Definition: "N"=None, "R"=Range, "M"=Matches, "C"=Contains, "B"=Begins With, "E"=Ends With
        /// </summary>
        [FieldFixedLength(1)]
        public string GroupRangeType { get; set; }

        /// <summary>
        /// Field #: 18
        /// Field Name: Group Range From
        /// Format: AN 
        /// Length: 15
        /// Values:
        /// Definition: Name assigned by user, or default
        /// </summary>
        [FieldFixedLength(15)]
        public string GroupRangeFrom { get; set; }

        /// <summary>
        /// Field #: 19
        /// Field Name: Group Range To
        /// Format: AN 
        /// Length: 15
        /// Values:
        /// Definition: Name assigned by user, or default
        /// </summary>
        [FieldFixedLength(15)]
        public string GroupRangeTo { get; set; }

        /// <summary>
        /// Field #: 20
        /// Field Name: NCPDP ID Range Type
        /// Format: AN 
        /// Length: 1
        /// Values: N, R, M, C, B, E
        /// Definition: "N"=None, "R"=Range, "M"=Matches, "C"=Contains, "B"=Begins With, "E"=Ends With
        /// </summary>
        [FieldFixedLength(1)]
        public string NcPdPIdRangeType { get; set; }

        /// <summary>
        /// Field #: 21
        /// Field Name: NCPDP ID Range From
        /// Format: AN 
        /// Length: 12
        /// Values:
        /// Definition: Value entered to select conditional range
        /// </summary>
        [FieldFixedLength(12)]
        public string NcPdPIdRangeFrom { get; set; }

        /// <summary>
        /// Field #: 22
        /// Field Name: NCPDP ID Range To
        /// Format: AN 
        /// Length: 12
        /// Values:
        /// Definition: Value entered to select conditional range
        /// </summary>
        [FieldFixedLength(12)]
        public string NcPdPIdRangeTo { get; set; }

        /// <summary>
        /// Field #: 23
        /// Field Name: Include Test Claims
        /// Format: N 
        /// Length: 1
        /// Values: 0, 1
        /// Definition: "1" = Test Claims included in file
        /// </summary>
        [FieldFixedLength(1)]
        public string IncludeTestClaims { get; set; }

        /// <summary>
        /// Field #: 24
        /// Field Name: Create Multi Ingredient Compound File
        /// Format: N 
        /// Length: 1
        /// Values:
        /// Definition: “0”= No File Created, “1”= M/1 Compound Created
        /// </summary>
        [FieldFixedLength(1)]
        public string CreateMultiIngredientCompoundFile { get; set; }

        /// <summary>
        /// Field #: 25
        /// Field Name: De-Identify Data
        /// Format: N 
        /// Length: 1
        /// Values:
        /// Definition: "0" = Not De-identified, "1" = De-identified
        /// </summary>
        [FieldFixedLength(1)]
        public string DeIdentifyData { get; set; }

        /// <summary>
        /// Field #: 26
        /// Field Name: Future Use
        /// Format: 
        /// Length: 40
        /// Values:
        /// Definition:
        /// </summary>
        [FieldFixedLength(40)]
        public string HeaderRecordFutureUse { get; set; }
    }
}