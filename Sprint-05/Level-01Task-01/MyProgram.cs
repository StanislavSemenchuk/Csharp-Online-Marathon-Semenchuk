using System.Collections.Generic;
using System.Linq;
using System;

namespace Level_01Task_01
{
    public class MyProgram
    {
        public static void Position(List<int> numbers) 
        {
            for (int i = 1; i < numbers.Count; i++) 
            {
                if (numbers[i] == 5) 
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
        public static void Remove(List<int> numbers) 
        {
            var RemovedNumbers = numbers.Where(n => n <= 20).ToList();
            foreach (var i in RemovedNumbers) 
            {
                Console.WriteLine(i);
            }
        }


        public static void Insert(List<int> numbers) 
        {
            numbers.Insert(2, -5);
            numbers.Insert(5, -6);
            numbers.Insert(7, -7);
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public static void Sort(List<int> numbers) 
        {
            numbers.Sort();
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
