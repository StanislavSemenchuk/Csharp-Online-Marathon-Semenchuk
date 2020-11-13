using System;
using System.Collections.Generic;
using System.Linq;

namespace Level_02Task_03
{
    public class Class1
    {
        public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        { 
            var mylookup = (Lookup<string, string>)phonesToNames.ToLookup(ph => ph.Value ?? "", ph => ph.Key ?? "");
            var mydict = mylookup.ToDictionary(x => x.Key, x => x.ToList());
            return mydict;
        }
    }
}
