using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetWord("lorem ipsune hui sosi", "fdasdfhgfg"));
        }

        public static string GetWord(string input, string seed)
        {
            string biggestWord = input.Split(' ')
                                 .Aggregate(seed, (longest, next)
                                  => next.Length > longest.Length ? next : longest,
                                  bigger => bigger.ToLower());
            return biggestWord.Contains('a') ? biggestWord.Substring(biggestWord.IndexOf('a')) : "";
        }
    }
}
