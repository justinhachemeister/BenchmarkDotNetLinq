# Benchmark dotnet using linq

Welcome to my simple linq benchmark using dotnet core

In this project I will going to benchmark some functionalities using linq and simple for-statements

## How to run:

> dotnet run --project BenchmarkDotNetLinq --no-restore -c Release

## Some results using [github-actions](https://github.com/lfmachadodasilva/BenchmarkDotNetLinq/actions/workflows/dotnet.yml):

| Method                          |      Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
| ------------------------------- | --------: | -------: | -------: | ----: | ----: | ----: | --------: |
| AlcoholicDrinksCountLinqWhere   |  47.66 us | 0.942 us | 0.881 us |     - |     - |     - |      72 B |
| AlcoholicDrinksCountLinqCount   | 131.19 us | 2.508 us | 2.683 us |     - |     - |     - |      40 B |
| AlcoholicDrinksCountForLoop     |  35.87 us | 0.712 us | 1.043 us |     - |     - |     - |         - |
| AlcoholicDrinksCountForEachLoop |  68.20 us | 1.353 us | 2.439 us |     - |     - |     - |         - |
