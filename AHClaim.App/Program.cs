using System;
using System.IO;
using System.Linq;
using AHClaim.domain.Segment.Extension;

namespace AHClaim.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var extractor = new Extractor
            {
                Path =
                    $"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}" +
                    $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}" +
                    $"..{Path.DirectorySeparatorChar}ClaimsSample"
            };
            var rawClaimRecords = extractor.Extract();

            var claimSegments = rawClaimRecords.GetClaimSegments().ToList();
        }
    }
}