using System;
using System.Linq;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static double EvaluateSumOfElementsOddPositions(double[] inputData)
        {
            return inputData.Where((item, index) => index % 2 != 0).Sum();
        }
    }
}
