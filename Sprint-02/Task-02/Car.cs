using System;

namespace Task_02
{
    public abstract class Car
    {
        internal string mark;
        internal int prodYear;

        public Car(string mark, int prodYear) 
        {
            this.mark = mark;
            this.prodYear = prodYear;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Mark : {mark}, Producted in { prodYear }");
        }

    }
}
