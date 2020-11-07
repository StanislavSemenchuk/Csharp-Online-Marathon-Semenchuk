using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_04
{
    public static class IListExtensions
    {
        public static void IncreaseWith(this IList<int> vs, int x) 
        {
            for (int i = 0; i < vs.Count; ++i) 
            {
                vs[i] += x;
            }
        }
    }
    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> ts)
        {
            string str = string.Join(", ", ts);
            return '[' + str + ']';
        }
    }
}
