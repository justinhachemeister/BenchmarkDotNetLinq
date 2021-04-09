# Benchmark dotnet using linq

Welcome to my simple linq benchmark using dotnet core

In this project I will going to benchmark some functionalities using linq and simple for-statements

## How to run:

> dotnet run --project BenchmarkDotNetLinq --no-restore -c Release

## Some results using [github-actions](https://github.com/lfmachadodasilva/BenchmarkDotNetLinq/actions/workflows/dotnet.yml):

|                                    Method |   Size |        Mean | Allocated |
|------------------------------------------ |------- |------------:|----------:|
|             AlcoholicDrinksCountLinqWhere |  10000 |    25.50 us |      72 B |
|             AlcoholicDrinksCountLinqCount |  10000 |   141.48 us |      41 B |
|               AlcoholicDrinksCountForLoop |  10000 |    21.66 us |         - |
|           AlcoholicDrinksCountForEachLoop |  10000 |    51.03 us |         - |
|             NonAlcoholicDrinkNamesForLoop |  10000 |    72.75 us |  131360 B |
| NonAlcoholicDrinkNamesForLoopWithCapacity |  10000 |    56.09 us |   80056 B |
|     NonAlcoholicDrinkNamesParallelForEach |  10000 |   385.66 us |  298026 B |
|                NonAlcoholicDrinkNamesLinq |  10000 |    84.71 us |  131512 B |
|      NonAlcoholicDrinkNamesLinkAsParallel |  10000 |   308.37 us |  266052 B |
|             AlcoholicDrinksCountLinqWhere | 100000 |   526.34 us |      72 B |
|             AlcoholicDrinksCountLinqCount | 100000 | 1,441.83 us |      41 B |
|               AlcoholicDrinksCountForLoop | 100000 |   456.06 us |         - |
|           AlcoholicDrinksCountForEachLoop | 100000 |   765.34 us |         - |
|             NonAlcoholicDrinkNamesForLoop | 100000 |   950.13 us | 1049272 B |
| NonAlcoholicDrinkNamesForLoopWithCapacity | 100000 |   749.22 us |  800438 B |
|     NonAlcoholicDrinkNamesParallelForEach | 100000 | 3,452.65 us | 2544404 B |
|                NonAlcoholicDrinkNamesLinq | 100000 |   961.05 us | 1049455 B |
|      NonAlcoholicDrinkNamesLinkAsParallel | 100000 | 3,206.17 us | 2102070 B |
