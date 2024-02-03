using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace StringConcatenationDemo;

[MemoryDiagnoser(false)]
[Config(typeof(StyleConfig))]
public class Benchmarks
{
    [Benchmark(Baseline = true)]
    public void StringPlusString()
    {
        StringConcatenation.StringPlusString();
    }

    [Benchmark]
    public void StringConcate()
    {
        StringConcatenation.StringConcate();
    }

    [Benchmark]
    public void StringJoin()
    {
        StringConcatenation.StringJoin();
    }

    [Benchmark]
    public void StringInterop()
    {
        StringConcatenation.StringInterop();
    }

    [Benchmark]
    public void StringFormat()
    {
        StringConcatenation.StringFormat();
    }

    [Benchmark]
    public void StringBuilder()
    {
        StringConcatenation.StringBuilder();
    }
}

public class StyleConfig : ManualConfig
{
    public StyleConfig()
    {
        SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
    }
}
