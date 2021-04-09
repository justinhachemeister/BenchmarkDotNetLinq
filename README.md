# Benchmark dotnet using linq

Welcome to my simple linq benchmark using dotnet core

In this project I will going to benchmark some functionalities using linq and simple for-statements

## How to run:

> dotnet run --project BenchmarkDotNetLinq --no-restore -c Release

## Some results using [github-actions](https://github.com/lfmachadodasilva/BenchmarkDotNetLinq/actions/workflows/dotnet.yml):

|                                    Method |      Mean |    Error |    StdDev |   Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|------------------------------------------ |----------:|---------:|----------:|--------:|-------:|-------:|----------:|
|             AlcoholicDrinksCountLinqWhere |  30.06 us | 0.127 us |  0.106 us |       - |      - |      - |      72 B |
|             AlcoholicDrinksCountLinqCount | 118.17 us | 1.410 us |  1.319 us |       - |      - |      - |      40 B |
|               AlcoholicDrinksCountForLoop |  17.47 us | 0.014 us |  0.013 us |       - |      - |      - |         - |
|           AlcoholicDrinksCountForEachLoop |  51.81 us | 0.072 us |  0.060 us |       - |      - |      - |         - |
|             NonAlcoholicDrinkNamesForLoop |  66.62 us | 1.094 us |  1.023 us |  6.9580 | 1.7090 |      - |  131360 B |
| NonAlcoholicDrinkNamesForLoopWithCapacity |  52.02 us | 0.611 us |  0.477 us |  4.2114 | 1.0376 |      - |   80056 B |
|     NonAlcoholicDrinkNamesParallelForEach | 376.99 us | 7.529 us | 15.881 us | 16.6016 | 8.3008 | 0.4883 |  300008 B |
|                NonAlcoholicDrinkNamesLinq |  77.11 us | 0.545 us |  0.510 us |  6.9580 | 1.7090 |      - |  131512 B |
|      NonAlcoholicDrinkNamesLinkAsParallel | 351.26 us | 6.973 us | 10.855 us | 14.1602 | 4.3945 |      - |  266055 B |
