using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_03
{
    public class Class1
    {
        public static int ProductWithCondition(List<int> list, Func<int, bool> cond) 
        {
            return list.Where(cond).Count() == 0 ? 1 : list.Where(cond).Aggregate((x, y) => x * y);
        }
    }
}
