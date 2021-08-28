using System;
using AHClaim.domain.Record;
using AHClaim.domain.Segment.Extension;
using FileHelpers;

namespace AHClaim.App
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * The below code is just for testing for the time being
             * It is not neither the final product nor the final architecture and should not be
             * 
             */
            
            // Extract 
            var engine = new FixedFileEngine<RawClaimRecord>() {Options = {IgnoreFirstLines = 1, IgnoreLastLines = 1}};
            var headerEngine = new FixedFileEngine<HeaderRecord>();
            var footerEngine = new FixedFileEngine<FileTrailerRecord>();

            Console.WriteLine($"{Environment.CurrentDirectory}");
            var result =
                engine.ReadFile($"{Environment.CurrentDirectory}\\..\\..\\..\\ClaimsSample\\2021-02-19_EC210218.AC");

            var headerResult = headerEngine.ReadString(engine.HeaderText);
            var footerResult = footerEngine.ReadString(engine.FooterText);


            // var claimSegments = SegmentFactory.GetClaimSegments(result);
            var claimSegments = result.GetClaimSegments();
            // var segments = claimSegments.GroupBy(segment => segment.OriginalClaimAuthorizationNumber).Count();

            // Transform
            // Load 
            // TODO: 
        }
    }
}