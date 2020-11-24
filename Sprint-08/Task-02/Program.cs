using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class MainThreadProgram
    {
        public static void Sum()
        {
            int[] num = new int[5];

            for (int i = 1; i <= num.Length; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter the 1st number:");
                        num[i - 1] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Enter the 2nd number:");
                        num[i - 1] = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine($"Enter the {i}th number:");
                        num[i - 1] = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine("Sum is: {0}", num.Sum());
        }

        public static void Product() 
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
            Thread.Sleep(10000);
            Console.WriteLine("Product is: {0}", list.Aggregate((x, y) => x * y));
        }

        public static (Thread, Thread) Calculator() 
        {
            Thread sumThread = new Thread(Sum);
            Thread productThread = new Thread(Product);
            sumThread.Start();
            productThread.Start();
            return (sumThread, productThread);
        }
    }
}

