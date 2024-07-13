```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method             | Mean     | Error     | StdDev    | Gen0   | Allocated |
|------------------- |---------:|----------:|----------:|-------:|----------:|
| GetExcelColumnName | 5.211 ns | 0.1234 ns | 0.1154 ns | 0.0057 |      24 B |
