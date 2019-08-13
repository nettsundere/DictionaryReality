using BenchmarkDotNet.Running;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Insert>();
            BenchmarkRunner.Run<Read>();
            BenchmarkRunner.Run<Delete>();
        }
    }
}
