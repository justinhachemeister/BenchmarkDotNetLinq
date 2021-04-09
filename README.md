# Benchmark dotnet using linq

Welcome to my simple linq benchmark using dotnet core

In this project I will going to benchmark some functionalities using linq and simple for-statements

## How to run:

> dotnet run --project BenchmarkDotNetLinq --no-restore -c Release

## Some results using [github-actions](https://github.com/lfmachadodasilva/BenchmarkDotNetLinq/actions/workflows/dotnet.yml):

|                                    Method |       Mean |    Error |    StdDev |     Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|------------------------------------------ |-----------:|---------:|----------:|-----------:|---------:|---------:|---------:|----------:|
|             AlcoholicDrinksCountLinqWhere |   498.6 us |  8.77 us |   8.20 us |   496.1 us |        - |        - |        - |      72 B |
|             AlcoholicDrinksCountLinqCount | 1,846.3 us | 67.57 us | 197.09 us | 1,792.4 us |        - |        - |        - |      41 B |
|               AlcoholicDrinksCountForLoop |   410.9 us |  8.10 us |   8.66 us |   409.1 us |        - |        - |        - |       1 B |
|           AlcoholicDrinksCountForEachLoop |   809.5 us | 15.78 us |  24.56 us |   805.8 us |        - |        - |        - |         - |
|             NonAlcoholicDrinkNamesForLoop |   962.5 us | 19.10 us |  17.86 us |   959.4 us |  57.6172 |  53.7109 |  52.7344 | 1049223 B |
| NonAlcoholicDrinkNamesForLoopWithCapacity |   794.9 us | 15.42 us |  17.76 us |   795.6 us |  46.8750 |  46.8750 |  46.8750 |  800381 B |
|     NonAlcoholicDrinkNamesParallelForEach | 4,326.2 us | 85.18 us | 119.41 us | 4,308.3 us | 164.0625 | 148.4375 | 148.4375 | 2565905 B |
|                NonAlcoholicDrinkNamesLinq | 1,187.6 us | 22.80 us |  19.04 us | 1,182.2 us |  62.5000 |  58.5938 |  58.5938 | 1049419 B |
|      NonAlcoholicDrinkNamesLinkAsParallel | 3,993.3 us | 79.73 us | 162.88 us | 4,006.9 us | 148.4375 | 132.8125 | 132.8125 | 2102335 B |
