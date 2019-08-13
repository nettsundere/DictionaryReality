using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [RPlotExporter, RankColumn]
    public class Read
    {
        [Params(1, 3, 4, 5, 10, 15, 30, 60)] public int Size;

        [GlobalSetup]
        public void Setup()
        {
            Helper.GenerateListsAndDictionaries(new [] { 1, 3, 4, 5, 10, 15, 30, 60 }, 1);
        }
        
        [BenchmarkCategory("Read")]
        [Benchmark]
        public void DictionaryReadRandom()
        {
            var dictionary = Helper.BorrowDictionary(Size);
            var randomIds = Helper.GetRandomIds(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(randomIds[i]);
                var data = dictionary[index];
            }
        }
        
        [BenchmarkCategory("Read")]
        [Benchmark]
        public void ListReadRandom()
        {
            var list = Helper.BorrowList(Size);
            var randomIds = Helper.GetRandomIds(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(randomIds[i]);

                var j = 0;
                for (; j < list.Count; j++)
                {
                    if (list[j].Item1 == index)
                    {
                        break;
                    }
                }

                var data = list[j].Item2;
            }
        }

        [BenchmarkCategory("Read")]
        [Benchmark]
        public void DictionaryReadSequential()
        {
            var dictionary = Helper.BorrowDictionary(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(i);
                var data = dictionary[index];
            }
        }

        [BenchmarkCategory("Read")]
        [Benchmark]
        public void ListReadSequential()
        {
            var list = Helper.BorrowList(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(i);

                var j = 0;
                for (; j < list.Count; j++)
                {
                    if (list[j].Item1 == index)
                    {
                        break;
                    }
                }

                var data = list[j].Item2;
            }
        }
    }
}