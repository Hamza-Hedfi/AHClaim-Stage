using System;
using System.Collections.Generic;
using System.IO;
using AHClaim.domain.Record;
using FileHelpers;

namespace AHClaim.App
{
    public class Extractor
    {
        public string Path { get; init; }

        private readonly FixedFileEngine<RawClaimRecord> _claimEngine = new()
            {Options = {IgnoreFirstLines = 1, IgnoreLastLines = 1}};

        // For future use
        // private FixedFileEngine<HeaderRecord> _headerEngine = new();
        private readonly FixedFileEngine<FileTrailerRecord> _footerEngine = new();

        private readonly List<RawClaimRecord> _claimResult = new();
        
        // For future use
        // private IEnumerable<HeaderRecord> _headerResult;
        // private IEnumerable<FileTrailerRecord> _footerResult;

        /// <summary>
        /// Reads all .AC files in specified folder and returns all claim records as is.
        /// </summary>
        /// <returns>IEnumerable&lt;RawClaimRecord&gt;</returns>
        /// <exception cref="NullReferenceException"></exception>
        public IEnumerable<RawClaimRecord> Extract()
        {
            if (Path == null)
                throw new NullReferenceException("You must specify a path to your raw data [Path to (*.AC) files]...");

            var claimCountSum = 0;
            
            foreach (var file in Directory.EnumerateFiles(Path, "*.AC"))
            {
                Console.WriteLine($"Processing {file}");
                _claimResult.AddRange(_claimEngine.ReadFile(file));
                var claimCount = int.Parse(_footerEngine.ReadString(_claimEngine.FooterText)[0].ClaimCount);
                Console.WriteLine($"Claim count: {claimCount}");
                claimCountSum += claimCount;
            }

            Console.WriteLine($"Total processed claims: {claimCountSum}");

            return _claimResult;
        }
    }
}