using System;

namespace Task_05
{
    public class EventProgram
    {
        public static event EventHandler Show;

        public EventProgram() 
        {
            Show += Dog;
            Show += Cat;
            Show += Mouse;
            Show += Elephant;

            Show?.Invoke(this, null);
        }

        public static void Dog(object o, EventArgs e)
        {
            Console.WriteLine("Dog");
        }
        public static void Cat(object o, EventArgs e)
        {
            Console.WriteLine("Cat");
        }
        public static void Mouse(object o, EventArgs e)
        {
            Console.WriteLine("Mouse");
        }
        public static void Elephant(object o, EventArgs e)
        {
            Console.WriteLine("Elephant");
        }
    }
}
