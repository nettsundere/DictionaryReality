using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace Benchmark
{
    public static class Helper
    {
        private const int SomeItem = 42;

        private static readonly Dictionary<int, Stack<IDictionary<string, int>>> _dictionaries;
        private static readonly Dictionary<int, Stack<IList<(string, int)>>> _lists;

        static Helper()
        {
            _dictionaries = new Dictionary<int, Stack<IDictionary<string, int>>>();
            _lists = new Dictionary<int, Stack<IList<(string, int)>>>();
        }

        public static void GenerateListsAndDictionaries(int[] knownSizes, int count)
        {
            foreach (var size in knownSizes)
            {
                _lists[size] = new Stack<IList<(string, int)>>();
                _dictionaries[size] = new Stack<IDictionary<string, int>>();
                for (var i = 0; i < count; i++)
                {
                    _lists[size].Push(BuildList(size));
                    _dictionaries[size].Push(BuildDictionary(size));
                }
            }
        }

        public static IDictionary<string, int> GetDictionary(int size)
        {
            return _dictionaries[size].Pop();
        }

        public static IList<(string, int)> GetList(int size)
        {
            return _lists[size].Pop();
        }
        
        public static IReadOnlyDictionary<string, int> BorrowDictionary(int size)
        {
            return (IReadOnlyDictionary<string, int>) _dictionaries[size].Peek();
        }

        public static IReadOnlyList<(string, int)> BorrowList(int size)
        {
            return (IReadOnlyList<(string, int)>) _lists[size].Peek();
        }
        
        public static IDictionary<string, int> BuildDictionary(int size)
        {
            var dictionary = new Dictionary<string, int>();
            
            for (var i = 0; i < size; i++)
            {
                dictionary[GetItemKey(i)] = SomeItem;
            }

            return dictionary;
        }

        public static IList<(string, int)> BuildList(int size)
        {
            var list = new List<(string, int)>();
            for (var i = 0; i < size; i++)
            {
                list.Add((GetItemKey(i), SomeItem));
            }

            return list;
        }

        public static string GetItemKey(int address)
        {
            var end = address % 2 == 0 ? "_2" : "_";
            return "item" + address + end;
        }
        
        public static void Shuffle<T>(this IList<T> list, Random rnd)
        {
            for (var i = 0; i < list.Count - 1; i++)
            {
                Swap<T>(list, i, rnd.Next(i, list.Count));
            }
        }

        private static void Swap<T>(IList<T> list, int a, int b)
        {
            var temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        
        public static IReadOnlyList<int> GetRandomIds(int size)
        {
            var random = new Random();
            var randomIds = Enumerable.Range(0, size).ToList();
            randomIds.Shuffle(random);
            return randomIds;
        }
    }
}