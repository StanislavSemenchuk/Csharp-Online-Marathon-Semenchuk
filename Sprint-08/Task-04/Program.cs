using System;
using System.Threading;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProgram.Counter(5);
        }
    }
    class MyProgram
    {
        public static void Counter(int number)
        {
            Thread threadFactorial = new Thread(()=> 
            {
                Console.WriteLine("Factorial is: " + Factorial(number));
            });

            Thread fiboThread = new Thread(()=>
            {
                Console.WriteLine("Fibbonaci number is: " + Fibonachi(number));
            });

            threadFactorial.Start();
            threadFactorial.Join();
            fiboThread.Start();
        }
        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
