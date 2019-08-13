using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [RPlotExporter, RankColumn]
    public class Delete
    {
        [Params(1, 3, 4, 5, 10, 15, 30, 60)] public int Size;

        [BenchmarkCategory("Delete")]
        [Benchmark(OperationsPerInvoke = 10)]
        public void ListDeleteSequential()
        {
            Helper.GenerateListsAndDictionaries(new[] {Size}, 1);

            var list = Helper.GetList(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(i);
                
                for (var j = 0; j < list.Count; j++)
                {
                    if (list[j].Item1 == index)
                    {
                        list.RemoveAt(j);
                        break;
                    }
                }
                
            }
        }

        [BenchmarkCategory("Delete")]
        [Benchmark]
        public void DictionaryDeleteSequential()
        {
            Helper.GenerateListsAndDictionaries(new[] {Size}, 1);

            var dictionary = Helper.GetDictionary(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(i);
                dictionary.Remove(index);
            }
        }
        
        [BenchmarkCategory("Delete")]
        [Benchmark]
        public void ListDeleteRandom()
        {
            Helper.GenerateListsAndDictionaries(new[] {Size}, 1);

            var list = Helper.GetList(Size);
            var randomIds = Helper.GetRandomIds(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(randomIds[i]);
                
                for (var j = 0; j < list.Count; j++)
                {
                    if (list[j].Item1 == index)
                    {
                        list.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        [BenchmarkCategory("Delete")]
        [Benchmark]
        public void DictionaryDeleteRandom()
        {
            Helper.GenerateListsAndDictionaries(new[] {Size}, 1);

            var dictionary = Helper.GetDictionary(Size);
            var randomIds = Helper.GetRandomIds(Size);
            
            for (var i = 0; i < Size; i++)
            {
                var index = Helper.GetItemKey(randomIds[i]);
                dictionary.Remove(index);
            }
        }
    }
}