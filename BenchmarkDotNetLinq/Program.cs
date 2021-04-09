using BenchmarkDotNet.Running;

namespace BenchmarkDotNetLinq
{
    public class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<BenchmarkLinq>();
        }
    }
}
