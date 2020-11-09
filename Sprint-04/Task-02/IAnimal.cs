using System;

namespace Task_01
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public void Voice();

        public void Feed();
    }

    public class Dog : IAnimal
    {
        public string Name { get ; set ; }

        public void Feed()
        {
            Console.WriteLine("I eat meat");
        }

        public void Voice()
        {
            Console.WriteLine("Woof");
        }
    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }

        public void Feed()
        {
            Console.WriteLine("I eat mice");
        }

        public void Voice()
        {
            Console.WriteLine("Mew");
        }
    }
}
