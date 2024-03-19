using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanBenchmarks
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class NameParserBenchmarks
    {
        private const string FullName = "Steve J Gordon";
        private static readonly NameParser Parser = new NameParser();

        [Benchmark(Baseline = true)]
        public void GetLastName()
        {
            Parser.GetLastName(FullName);
        }

        [Benchmark]
        public void GetLastNameUsingSubstring()
        {
            Parser.GetLastNameUsingSubstring(FullName);
        }

        [Benchmark]
        public void GetLastNameWithSpan()
        {
            Parser.GetLastNameWithSpan(FullName);
        }
    }
}
