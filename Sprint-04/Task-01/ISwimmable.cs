using System;

namespace Task_01
{
    public interface ISwimmable
    {
        public void Swim() 
        {
            Console.WriteLine("I can swim!");
        }
    }
    public interface IFlyable 
    {
        public int MaxHeight { get => 0;}

        public void Fly() 
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }
    }
    public interface IRunnable 
    {
        public int MaxSpeed { get => 0; }

        public void Run() 
        {
            Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }
    }
    public interface IAnimal 
    {
        public int LifeDuration { get => 0; }
        public void Voice() 
        {
            Console.WriteLine("No voice!");
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"I am a {this.GetType()} and I live approximately {LifeDuration} years.");
        }
    }
    public class Cat : IAnimal, IRunnable
    {
        public int LifeDuration { get; set; }
        public int MaxSpeed { get; set; }
        public void Voice()
        {
            Console.WriteLine("Meow!");
        }
    }
    public class Eagle : IAnimal, IFlyable
    {
        public int LifeDuration { get; set; }
        public int MaxHeight { get; set; }
    }

    public class Shark : IAnimal, ISwimmable
    {
        public int LifeDuration { get; set; }
    }
}
