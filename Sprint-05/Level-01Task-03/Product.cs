using System;
using System.Collections.Generic;
using System.Linq;

namespace Level_01Task_03
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public static void TotalPrice(ILookup<string, Product> lookup) 
        {
            foreach (var l in lookup) 
            {
                foreach (Product product in l)
                {
                    Console.WriteLine(product.Name + " " + product.Price);
                }

                Console.WriteLine(l.Key + " " + l.Sum(p => p.Price));
            }
        }
    }
}
