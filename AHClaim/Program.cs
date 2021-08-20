using System;
using System.Linq;
using FileHelpers;

namespace AHClaim
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var engine = new FixedFileEngine<RawClaim>() {Options = {IgnoreFirstLines = 1, IgnoreLastLines = 1}};
            var headerEngine = new FixedFileEngine<HeaderRecord>();
            var footerEngine = new FixedFileEngine<FileTrailerRecord>();

            var result =
                engine.ReadFile($"{Environment.CurrentDirectory}\\..\\..\\ClaimsSample\\2021-02-19_EC210218.AC");

            var headerResult = headerEngine.ReadString(engine.HeaderText);
            var footerResult = footerEngine.ReadString(engine.FooterText);
        }
    }
}