using System;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class CalcAsync : Calc
    {
        public static async void PrintSeqAsync(int n) 
        {
            Console.WriteLine("Seq[{0}] = {1}", n, await Task.Run(() => Seq(n)));
        }
    }

    class Calc
    {
        public static int Seq(int n) { return 0; }
    }
}
