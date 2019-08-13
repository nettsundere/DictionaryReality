``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.6 (18G87) [Darwin 18.7.0]
Intel Core i5-3427U CPU 1.80GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|           Method | Size |        Mean |      Error |     StdDev |      Median | Rank |
|----------------- |----- |------------:|-----------:|-----------:|------------:|-----:|
| **DictionaryInsert** |    **1** |    **396.9 ns** |   **7.823 ns** |  **15.258 ns** |    **392.0 ns** |    **3** |
|       ListInsert |    1 |    149.9 ns |   2.486 ns |   2.076 ns |    149.0 ns |    1 |
| **DictionaryInsert** |    **3** |    **614.3 ns** |  **11.828 ns** |  **11.064 ns** |    **612.0 ns** |    **5** |
|       ListInsert |    3 |    353.3 ns |   6.953 ns |   9.282 ns |    353.6 ns |    2 |
| **DictionaryInsert** |    **4** |    **876.8 ns** |  **16.690 ns** |  **17.858 ns** |    **872.5 ns** |    **7** |
|       ListInsert |    4 |    445.2 ns |   8.949 ns |   7.933 ns |    442.7 ns |    4 |
| **DictionaryInsert** |    **5** |    **999.2 ns** |  **15.789 ns** |  **13.997 ns** |    **996.0 ns** |    **8** |
|       ListInsert |    5 |    656.1 ns |  16.731 ns |  17.182 ns |    648.8 ns |    6 |
| **DictionaryInsert** |   **10** |  **2,079.7 ns** |  **40.889 ns** |  **50.215 ns** |  **2,062.2 ns** |   **11** |
|       ListInsert |   10 |  1,271.8 ns |  24.931 ns |  25.602 ns |  1,265.7 ns |    9 |
| **DictionaryInsert** |   **15** |  **2,716.6 ns** |  **52.787 ns** |  **51.844 ns** |  **2,694.6 ns** |   **12** |
|       ListInsert |   15 |  1,847.2 ns |  36.891 ns |  36.232 ns |  1,853.5 ns |   10 |
| **DictionaryInsert** |   **30** |  **5,356.8 ns** | **111.998 ns** | **109.997 ns** |  **5,321.6 ns** |   **14** |
|       ListInsert |   30 |  3,737.8 ns | 186.586 ns | 372.631 ns |  3,548.5 ns |   13 |
| **DictionaryInsert** |   **60** | **10,513.7 ns** | **182.733 ns** | **161.988 ns** | **10,489.9 ns** |   **16** |
|       ListInsert |   60 |  6,859.5 ns | 133.738 ns | 169.135 ns |  6,827.8 ns |   15 |
