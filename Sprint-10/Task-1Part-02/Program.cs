using System;

namespace Task_1Part_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Bird : IFlyable, IEating, IMoving
    {
        public void Eat()
        {
            Console.WriteLine("Oh! My corn!");
        }

        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }
    }
    class Cat : IEating, IMoving, IBasking
    {
        public void Eat()
        {
            Console.WriteLine("Oh! My milk!");
        }

        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
        public void Bask()
        {
            Console.WriteLine("Mrrr-Mrrr-Mrrr...");
        }
    }
    class Duck : Bird, IKryaking
    {
        public new void Move()
        {
            Console.WriteLine("I can swimm!");
        }
        public void Krya()
        {
            Console.WriteLine("Krya-Krya!");
        }
    }
    class Parrot : Bird, IBasking, IKryaking
    {
        public new void Eat()
        {
            Console.WriteLine("Oh! My seeds and fruits!");
        }
        public void Bask()
        {
            Console.WriteLine("Chuh-Chuh-Chuh...");
        }
        public void Krya()
        {
            Console.WriteLine("Krya-Krya-Krya...");
        }
    }
    interface IFlyable 
    {
        public void Fly();
    }
    interface IEating 
    {
        public void Eat();
    }
    interface IMoving 
    {
        public void Move();
    }
    interface IBasking 
    {
        public void Bask();
    }
    interface IKryaking 
    {
        public void Krya();
    }
}
