using System;
using System.Collections.Generic;
using System.Linq;

namespace Level_02Task_01
{
    public class MyUtils
    {
        public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> dictionary)  
        {
            var ListDict = dictionary.Select(dict => dict.Value).Distinct().ToList();
            ListDict.Sort();
            list = list.Distinct().ToList();
            list.Sort();
            return ListDict.SequenceEqual(list);
        }
    }
}
