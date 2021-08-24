using System;
using AHClaim.Record;
using AHClaim.Segment;
using FileHelpers;

namespace AHClaim.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Extract 
            var engine = new FixedFileEngine<RawClaimRecord>() {Options = {IgnoreFirstLines = 1, IgnoreLastLines = 1}};
            var headerEngine = new FixedFileEngine<HeaderRecord>();
            var footerEngine = new FixedFileEngine<FileTrailerRecord>();

            var result =
                engine.ReadFile($"{Environment.CurrentDirectory}\\..\\..\\ClaimsSample\\2021-02-19_EC210218.AC");

            var headerResult = headerEngine.ReadString(engine.HeaderText);
            var footerResult = footerEngine.ReadString(engine.FooterText);


            // Transform
            // var claimSegments = SegmentFactory.GetClaimSegments(result);
            var claimSegments = result.GetClaimSegments();
            // var segments = claimSegments.GroupBy(segment => segment.OriginalClaimAuthorizationNumber).Count();

            // Load 
            // TODO: 
        }
    }
}