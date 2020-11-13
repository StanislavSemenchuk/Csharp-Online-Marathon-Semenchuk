using System;
using System.Collections.Generic;
using System.Linq;

namespace Level_01Task_02
{
    public class MyProgram
    {
        public static void SearchKeys(Dictionary<string, string> persons) 
        {
            foreach (var person in persons) 
            {
                Console.WriteLine(person.Key);
            }
        }
        public static void SearchValues(Dictionary<string, string> persons) 
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.Value);
            }
        }
        public static void SearchAdmin(Dictionary<string, string> persons) 
        {
            var AdminDictionary = persons.Where(p => p.Value == "Admin");
            foreach (var Admin in AdminDictionary)
            {
                Console.WriteLine(Admin.Key + " " + Admin.Value);
            }
        }
    }
}
