using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [RPlotExporter, RankColumn]
    public class Insert
    {
        [Params(1, 3, 4, 5, 10, 15, 30, 60)] public int Size;
        
        [BenchmarkCategory("Build and Insert")]
        [Benchmark]
        public void DictionaryInsert()
        {
            Helper.BuildDictionary(Size);
        }
        
        [BenchmarkCategory("Build and Insert")]
        [Benchmark]
        public void ListInsert()
        { 
            Helper.BuildList(Size);
        }
    }
}