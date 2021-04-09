using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetLinq
{
    [MemoryDiagnoser]
    public class BenchmarkLinq
    {
        private List<Drink> _drinks;

        [GlobalSetup]
        public void Setup()
        {
            _drinks = new Fixture()
                .CreateMany<Drink>(10000)
                .ToList();
        }

        [Benchmark]
        public int AlcoholicDrinksCountLinqWhere()
        {
            return _drinks.Where(x => x.IsAlcoholic).Count();
        }

        [Benchmark]
        public int AlcoholicDrinksCountLinqCount()
        {
            return _drinks.Count(x => x.IsAlcoholic);
        }

        [Benchmark]
        public int AlcoholicDrinksCountForLoop()
        {
            var count = 0;
            for (var i = 0; i < _drinks.Count; i++)
            {
                if (_drinks[i].IsAlcoholic)
                {
                    count++;
                }
            }

            return count;
        }

        [Benchmark]
        public int AlcoholicDrinksCountForEachLoop()
        {
            var count = 0;
            foreach (var t in _drinks)
            {
                if (t.IsAlcoholic)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
