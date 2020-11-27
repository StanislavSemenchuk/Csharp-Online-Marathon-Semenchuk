using System;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = CalcAsync.TaskPrintSeqAsync(35);
            t.TrackStatus();
        }
    }
    static class CalcAsync
    {
        public static async Task TaskPrintSeqAsync(int n)
        {
            Console.WriteLine("Seq[{0}] = {1}", n, await Task.Run(() => Calc.Seq(n)));
        }
        public static void PrintStatusIfChanged(this Task t, ref TaskStatus previousStatus)
        {
            if (previousStatus != t.Status)
            {
                Console.WriteLine(t.Status.ToString());
            }
            previousStatus = t.Status;
        }

        public static void TrackStatus(this Task t)
        {
            TaskStatus initialStatus = TaskStatus.Created;

            while (t.IsCompletedSuccessfully)
            {
                t.PrintStatusIfChanged(ref initialStatus);
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
