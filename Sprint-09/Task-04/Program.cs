using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class CalcAsync
    {
        public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return (i + 1, await Task.Run(() => Calc.Seq(i + 1)));
            }
        }
        public static async void PrintStream(IAsyncEnumerable<(int, int)> asyncEnumerable)
        {
            await foreach (var enumerable in asyncEnumerable)
            {
                Console.WriteLine("Seq[{0}] = {1}", enumerable.Item1, enumerable.Item2);
            }
        }
    }

    internal class Calc
    {
        internal static Task<int> Seq(int n)
        {
            throw new NotImplementedException();
        }
    }
}
