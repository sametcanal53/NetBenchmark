using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using LINQ.Benchmark;

BenchmarkRunner.Run<LinqBenchmark>(
    DefaultConfig.Instance
        .WithOptions(ConfigOptions.DisableOptimizationsValidator));
