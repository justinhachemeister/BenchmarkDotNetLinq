using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetLinq
{
    [MemoryDiagnoser]
    public class BenchmarkLinq
    {
        private List<Drink> _drinks;

        [Params(1, 10, 50, 100, 1000, 5000, 10000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _drinks = new Fixture()
                .CreateMany<Drink>(Size)
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

        [Benchmark]
        public List<string> NonAlcoholicDrinkNamesForLoop()
        {
            var names = new List<string>();
            for (var i = 0; i < _drinks.Count; i++)
            {
                if (!_drinks[i].IsAlcoholic)
                {
                    names.Add(_drinks[i].Name);
                }
            }
            return names;
        }

        [Benchmark]
        public List<string> NonAlcoholicDrinkNamesForLoopWithCapacity()
        {
            var names = new List<string>(_drinks.Count);
            for (var i = 0; i < _drinks.Count; i++)
            {
                if (!_drinks[i].IsAlcoholic)
                {
                    names.Add(_drinks[i].Name);
                }
            }
            return names;
        }

        [Benchmark]
        public List<string> NonAlcoholicDrinkNamesParallelForEach()
        {
            var names = new ConcurrentBag<string>();
            Parallel.ForEach(_drinks, x =>
            {
                if (!x.IsAlcoholic)
                {
                    names.Add(x.Name);
                }
            });
            return names.ToList();
        }

        [Benchmark]
        public List<string> NonAlcoholicDrinkNamesLinq()
        {
            return _drinks
                .Where(x => !x.IsAlcoholic)
                .Select(x => x.Name)
                .ToList();
        }

        [Benchmark]
        public List<string> NonAlcoholicDrinkNamesLinkAsParallel()
        {
            return _drinks
                .AsParallel()
                .Where(x => !x.IsAlcoholic)
                .Select(x => x.Name)
                .ToList();
        }
    }
}
