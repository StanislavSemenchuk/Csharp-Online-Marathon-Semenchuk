using System;
using System.Collections.Generic;
using System.Text;

namespace Task_02
{
    class SportCar : Car
    {
        private int maxSpeed;
        public SportCar(string mark, int prodYear, int maxSpeed) : base(mark, prodYear)
        {
            this.maxSpeed = maxSpeed;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Mark : {mark}, Producted in { prodYear } Maximum speed is {maxSpeed}");
        }
    }
}
