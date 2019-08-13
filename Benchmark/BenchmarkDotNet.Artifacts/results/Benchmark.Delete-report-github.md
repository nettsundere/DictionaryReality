``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.6 (18G87) [Darwin 18.7.0]
Intel Core i5-3427U CPU 1.80GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                     Method | Size |        Mean |      Error |     StdDev |      Median | Rank |
|--------------------------- |----- |------------:|-----------:|-----------:|------------:|-----:|
|       **ListDeleteSequential** |    **1** |    **105.0 ns** |   **2.394 ns** |   **3.727 ns** |    **103.6 ns** |    **1** |
| DictionaryDeleteSequential |    1 |  1,047.0 ns |  13.061 ns |  12.217 ns |  1,044.4 ns |    7 |
|           ListDeleteRandom |    1 |  3,420.9 ns |  29.087 ns |  27.208 ns |  3,411.8 ns |   13 |
|     DictionaryDeleteRandom |    1 |  3,469.5 ns |  25.697 ns |  24.037 ns |  3,470.3 ns |   13 |
|       **ListDeleteSequential** |    **3** |    **169.3 ns** |   **2.052 ns** |   **1.919 ns** |    **168.5 ns** |    **2** |
| DictionaryDeleteSequential |    3 |  1,732.0 ns |  18.495 ns |  15.444 ns |  1,729.0 ns |    9 |
|           ListDeleteRandom |    3 |  4,280.9 ns |  59.987 ns |  53.177 ns |  4,281.0 ns |   14 |
|     DictionaryDeleteRandom |    3 |  4,209.9 ns |  46.012 ns |  40.788 ns |  4,212.5 ns |   14 |
|       **ListDeleteSequential** |    **4** |    **253.8 ns** |   **1.930 ns** |   **1.806 ns** |    **254.0 ns** |    **3** |
| DictionaryDeleteSequential |    4 |  2,478.0 ns |  19.375 ns |  18.123 ns |  2,482.8 ns |   10 |
|           ListDeleteRandom |    4 |  4,825.9 ns |  38.454 ns |  35.970 ns |  4,833.0 ns |   16 |
|     DictionaryDeleteRandom |    4 |  4,709.7 ns |  29.009 ns |  27.135 ns |  4,706.6 ns |   15 |
|       **ListDeleteSequential** |    **5** |    **276.6 ns** |   **3.052 ns** |   **2.855 ns** |    **276.7 ns** |    **4** |
| DictionaryDeleteSequential |    5 |  2,664.0 ns |  35.954 ns |  33.631 ns |  2,662.2 ns |   11 |
|           ListDeleteRandom |    5 |  5,705.0 ns |  75.064 ns |  70.215 ns |  5,703.6 ns |   18 |
|     DictionaryDeleteRandom |    5 |  5,716.3 ns |  60.616 ns |  50.617 ns |  5,722.0 ns |   18 |
|       **ListDeleteSequential** |   **10** |    **531.2 ns** |   **5.358 ns** |   **4.750 ns** |    **530.8 ns** |    **5** |
| DictionaryDeleteSequential |   10 |  5,060.7 ns |  47.194 ns |  41.836 ns |  5,057.4 ns |   17 |
|           ListDeleteRandom |   10 |  8,645.7 ns |  78.291 ns |  69.403 ns |  8,641.2 ns |   21 |
|     DictionaryDeleteRandom |   10 |  8,127.1 ns | 102.900 ns |  85.926 ns |  8,084.8 ns |   20 |
|       **ListDeleteSequential** |   **15** |    **748.4 ns** |  **18.737 ns** |  **30.256 ns** |    **734.0 ns** |    **6** |
| DictionaryDeleteSequential |   15 |  6,966.5 ns |  83.562 ns |  74.075 ns |  6,959.1 ns |   19 |
|           ListDeleteRandom |   15 | 11,647.9 ns | 123.689 ns | 115.698 ns | 11,656.4 ns |   23 |
|     DictionaryDeleteRandom |   15 | 10,359.9 ns | 121.812 ns | 113.943 ns | 10,326.0 ns |   22 |
|       **ListDeleteSequential** |   **30** |  **1,478.4 ns** |  **12.589 ns** |  **11.776 ns** |  **1,478.9 ns** |    **8** |
| DictionaryDeleteSequential |   30 | 13,467.4 ns |  97.499 ns |  86.430 ns | 13,463.0 ns |   24 |
|           ListDeleteRandom |   30 | 22,401.8 ns | 179.856 ns | 159.438 ns | 22,348.0 ns |   26 |
|     DictionaryDeleteRandom |   30 | 17,538.0 ns | 199.439 ns | 176.797 ns | 17,520.0 ns |   25 |
|       **ListDeleteSequential** |   **60** |  **2,903.5 ns** |  **27.763 ns** |  **25.969 ns** |  **2,897.9 ns** |   **12** |
| DictionaryDeleteSequential |   60 | 26,354.0 ns | 203.329 ns | 180.246 ns | 26,322.6 ns |   27 |
|           ListDeleteRandom |   60 | 50,126.1 ns | 426.737 ns | 399.170 ns | 50,278.4 ns |   29 |
|     DictionaryDeleteRandom |   60 | 31,837.3 ns | 358.882 ns | 318.139 ns | 31,858.7 ns |   28 |
