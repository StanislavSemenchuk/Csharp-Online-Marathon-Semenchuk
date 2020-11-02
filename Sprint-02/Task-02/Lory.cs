using System;
using System.Collections.Generic;
using System.Text;

namespace Task_02
{
    class Lory : Car
    {
        private double loadCapacity;

        public Lory(string mark, int prodYear, double loadCapacity) : base(mark, prodYear)
        {
            this.loadCapacity = loadCapacity;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Mark : {mark}, Producted in { prodYear } The load capacity is {loadCapacity}");
        }
    }
}
