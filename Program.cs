// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using SpanBenchmarks;

var summary = BenchmarkRunner.Run<NameParserBenchmarks>();