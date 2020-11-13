using System;
using System.Collections.Generic;
using System.Linq;

namespace Level_02Task_02
{
    public class Class1
    {
        public static Lookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
        {
            return (Lookup<string, string>)phonesToNames.ToLookup(ph => ph.Value ?? "", ph => ph.Key ?? "");
        }
    }
}
