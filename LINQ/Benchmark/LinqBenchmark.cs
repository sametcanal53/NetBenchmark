using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;
using System;
using LINQ.Models;

namespace LINQ.Benchmark
{
    #region .NET Version
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net50, baseline: true)]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net70)]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90)]
    #endregion

    #region Data
    [MemoryDiagnoser]
    #endregion

    #region Exporter
    [AsciiDocExporter]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [HtmlExporter]
    [JsonExporter]
    [MarkdownExporter]
    [PlainExporter]
    [RPlotExporter]
    [XmlExporter]
    #endregion

    public class LinqBenchmark
    {
        private List<Product> _products = new();

        [Params(1000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            _products = Enumerable.Range(0, N)
                .Select(i => new Product($"Product {i}", random.NextDouble() * N, random.Next(N)))
                .ToList();
        }

        [Benchmark] public void FirstOrDefault() => _products.FirstOrDefault();

        /*[Benchmark] public void Aggreagate() => _products.Aggregate(0.0, (acc, p) => acc + p.Price);
        [Benchmark] public void All() => _products.All(p => p.Price > 50);
        [Benchmark] public void Any() => _products.Any(p => p.Price > 50);
        [Benchmark] public void Append() => _products.Append(new Product("Product", 10, 10)).ToList();
        [Benchmark] public void Average() => _products.Average(p => p.Price);
        [Benchmark] public void Cast() => _products.Cast<object>().ToList();
        [Benchmark] public void Concat() => _products.Concat(_products).ToList();
        [Benchmark] public void Contains() => _products.Contains(_products[0]);
        [Benchmark] public void Count() => _products.Count();
        [Benchmark] public void DefaultIfEmpty() => _products.DefaultIfEmpty().ToList();
        [Benchmark] public void Distinct() => _products.Distinct().ToList();
        [Benchmark] public void ElementAt() => _products.ElementAt(0);
        [Benchmark] public void ElementAtOrDefault() => _products.ElementAtOrDefault(0);
        [Benchmark] public void Except() => _products.Except(_products).ToList();
        [Benchmark] public void First() => _products.First();
        [Benchmark] public void FirstOrDefault() => _products.FirstOrDefault();
        [Benchmark] public void GroupBy() => _products.GroupBy(p => p.Price).ToList();
        [Benchmark] public void GroupJoin() => _products.GroupJoin(_products, p => p.Price, p => p.Price, (p, ps) => p).ToList();
        [Benchmark] public void Intersect() => _products.Intersect(_products).ToList();
        [Benchmark] public void Join() => _products.Join(_products, p => p.Price, p => p.Price, (p, p1) => p).ToList();
        [Benchmark] public void Last() => _products.Last();
        [Benchmark] public void LastOrDefault() => _products.LastOrDefault();
        [Benchmark] public void Max() => _products.Max(p => p.Price);
        [Benchmark] public void Min() => _products.Min(p => p.Price);
        [Benchmark] public void OfType() => _products.OfType<Product>().ToList();
        [Benchmark] public void OrderBy() => _products.OrderBy(p => p.Price).ToList();
        [Benchmark] public void OrderByDescending() => _products.OrderByDescending(p => p.Price).ToList();
        [Benchmark] public void Prepend() => _products.Prepend(new Product("Product", 10, 10)).ToList();
        [Benchmark] public void Reverse() => _products.Reverse();
        [Benchmark] public void Select() => _products.Select(p => p.Price).ToList();
        [Benchmark] public void SelectMany() => _products.SelectMany(p => new[] { p.Price }).ToList();
        [Benchmark] public void SequenceEqual() => _products.SequenceEqual(_products);
        //[Benchmark] public void Single() => _products.Single();
        //[Benchmark] public void SingleOrDefault() => _products.SingleOrDefault();
        [Benchmark] public void Skip() => _products.Skip(1).ToList();
        [Benchmark] public void SkipLast() => _products.SkipLast(1).ToList();
        [Benchmark] public void SkipWhile() => _products.SkipWhile(p => p.Price > 50).ToList();
        [Benchmark] public void Sum() => _products.Sum(p => p.Price);
        [Benchmark] public void Take() => _products.Take(1).ToList();
        [Benchmark] public void TakeLast() => _products.TakeLast(1).ToList();
        [Benchmark] public void TakeWhile() => _products.TakeWhile(p => p.Price > 50).ToList();
        [Benchmark] public void ThenBy() => _products.OrderBy(p => p.Price).ThenBy(p => p.Stock).ToList();
        [Benchmark] public void ThenByDescending() => _products.OrderBy(p => p.Price).ThenByDescending(p => p.Stock).ToList();
        [Benchmark] public void ToArray() => _products.ToArray();
        [Benchmark] public void ToDictionary() => _products.ToDictionary(p => p.Name);
        [Benchmark] public void ToHashSet() => _products.ToHashSet();
        [Benchmark] public void ToList() => _products.ToList();
        [Benchmark] public void ToLookup() => _products.ToLookup(p => p.Price);
        [Benchmark] public void Union() => _products.Union(_products).ToList();
        [Benchmark] public void Where() => _products.Where(p => p.Price > 50).ToList();
        [Benchmark] public void Zip() => _products.Zip(_products, (p, p1) => p).ToList();*/
    }

}
