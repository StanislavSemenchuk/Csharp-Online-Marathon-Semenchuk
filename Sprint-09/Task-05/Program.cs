using System;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 1 };
            CalcAsync.PrintSpecificSeqElementsAsync(numbers);
            Thread.Sleep(10000);
        }
    }
    class CalcAsync
    {
        public static async void PrintSpecificSeqElementsAsync(int[] specificInts)
        {
            List<Task> tasks = new List<Task>();
            Task allTasks = null;
            for (int i = 0; i < specificInts.Length; i++)
            {
                int temp = specificInts[i];
                var tempTask = Task.Run(() => Console.WriteLine("Seq[{0}] = {1}", temp, Calc.Seq(temp)));
                tasks.Add(tempTask);
            }
            try
            {
                allTasks = Task.WhenAll(tasks);
                await allTasks;
            }
            catch (Exception ex) 
            {
                foreach (var inex in allTasks.Exception.InnerExceptions) 
                {
                    Console.WriteLine("Inner exception: " + inex.Message);
                }
                
            }
        }
    }

    class Calc
    {
        internal static int Seq(int n)
        {
            return 0;
        }
    }
}
