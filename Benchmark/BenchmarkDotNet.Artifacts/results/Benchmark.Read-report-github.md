``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.6 (18G87) [Darwin 18.7.0]
Intel Core i5-3427U CPU 1.80GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                   Method | Size |        Mean |      Error |     StdDev | Rank |
|------------------------- |----- |------------:|-----------:|-----------:|-----:|
|     **DictionaryReadRandom** |    **1** |  **2,559.1 ns** |  **64.485 ns** |  **81.552 ns** |   **12** |
|           ListReadRandom |    1 |  2,629.7 ns |  49.014 ns |  48.139 ns |   13 |
| DictionaryReadSequential |    1 |    168.3 ns |   3.259 ns |   3.048 ns |    1 |
|       ListReadSequential |    1 |    292.3 ns |   8.174 ns |   9.085 ns |    2 |
|     **DictionaryReadRandom** |    **3** |  **2,903.5 ns** |  **57.017 ns** |  **50.544 ns** |   **14** |
|           ListReadRandom |    3 |  3,034.1 ns |  59.457 ns |  70.779 ns |   15 |
| DictionaryReadSequential |    3 |    454.6 ns |   8.809 ns |   8.240 ns |    3 |
|       ListReadSequential |    3 |    562.2 ns |  11.000 ns |  11.770 ns |    4 |
|     **DictionaryReadRandom** |    **4** |  **3,102.5 ns** |  **55.454 ns** |  **51.872 ns** |   **16** |
|           ListReadRandom |    4 |  3,415.3 ns |  77.642 ns |  79.733 ns |   18 |
| DictionaryReadSequential |    4 |    585.4 ns |  13.418 ns |  11.895 ns |    5 |
|       ListReadSequential |    4 |    717.0 ns |   6.755 ns |   6.319 ns |    6 |
|     **DictionaryReadRandom** |    **5** |  **3,262.6 ns** |  **23.138 ns** |  **20.511 ns** |   **17** |
|           ListReadRandom |    5 |  3,620.9 ns |  23.904 ns |  18.663 ns |   20 |
| DictionaryReadSequential |    5 |    749.3 ns |   5.720 ns |   5.071 ns |    7 |
|       ListReadSequential |    5 |    895.8 ns |   7.256 ns |   6.433 ns |    8 |
|     **DictionaryReadRandom** |   **10** |  **4,225.6 ns** |  **36.836 ns** |  **30.760 ns** |   **21** |
|           ListReadRandom |   10 |  4,941.4 ns |  56.121 ns |  52.495 ns |   23 |
| DictionaryReadSequential |   10 |  1,413.1 ns |   9.695 ns |   9.069 ns |    9 |
|       ListReadSequential |   10 |  2,104.9 ns |  18.942 ns |  15.818 ns |   10 |
|     **DictionaryReadRandom** |   **15** |  **5,417.4 ns** |  **61.415 ns** |  **51.284 ns** |   **24** |
|           ListReadRandom |   15 |  6,675.1 ns |  37.825 ns |  35.382 ns |   25 |
| DictionaryReadSequential |   15 |  2,232.6 ns |  20.995 ns |  18.611 ns |   11 |
|       ListReadSequential |   15 |  3,491.1 ns |  21.756 ns |  19.286 ns |   19 |
|     **DictionaryReadRandom** |   **30** |  **8,388.8 ns** |  **67.913 ns** |  **63.526 ns** |   **26** |
|           ListReadRandom |   30 | 14,046.0 ns | 126.579 ns | 118.402 ns |   29 |
| DictionaryReadSequential |   30 |  4,364.2 ns |  40.253 ns |  33.613 ns |   22 |
|       ListReadSequential |   30 |  9,979.6 ns | 199.293 ns | 221.514 ns |   28 |
|     **DictionaryReadRandom** |   **60** | **14,379.1 ns** |  **92.127 ns** |  **81.669 ns** |   **30** |
|           ListReadRandom |   60 | 37,420.3 ns | 503.573 ns | 471.043 ns |   32 |
| DictionaryReadSequential |   60 |  9,037.0 ns | 138.921 ns | 123.150 ns |   27 |
|       ListReadSequential |   60 | 30,675.1 ns | 170.042 ns | 141.993 ns |   31 |
