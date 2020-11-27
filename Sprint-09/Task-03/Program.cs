using System;
using System.Threading.Tasks;

namespace Task_03
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
        public static async Task<int> SeqAsync(int n)
        {
            return await Task.Run(() => Calc.Seq(n));
        }

        public static async void PrintSeqElementsConsequentlyAsync(int quant) 
        {
            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine("Seq[{0}] = {1}", i, await SeqAsync(i));
            }
        }
        public static async void PrintSeqElementsInParallelAsync(int quant) 
        {
            Task<int[]> result = Task.WhenAll(GetSeqAsyncTasks(quant));

            for (int i = 1; i <= quant; i++)
            {
                await Task.Run(() => Console.WriteLine("Seq[{0}] = {1}", i, result.Result[i - 1]));
            } 
        }

        public static Task<int>[] GetSeqAsyncTasks(int numb) 
        {
            Task<int>[] tasks = new Task<int>[numb];

            for (int i = 0; i < numb; i++)
            {
                tasks[i] = SeqAsync(i + 1);
            }

            return tasks;
        }
    }

    public class Calc 
    {
        public static int Seq(int numb) 
        {
            return 0;
        }
    }
}
