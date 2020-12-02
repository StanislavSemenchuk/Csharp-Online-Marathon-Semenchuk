using System;

namespace Task_04Part_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface ILead 
    {
        void AssignTask();
        void CreateSubTask();
    }
    interface IProgrammer 
    {
        void WorkOnTask();
    }

    public class TeamLead : ILead, IProgrammer
    {
        public void AssignTask()
        {
            
        }

        public void CreateSubTask()
        {
            
        }

        public void WorkOnTask()
        {
            
        }
    }
    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            
        }
    }
    public class Manager : ILead
    {
        public void AssignTask()
        {
        
        }

        public void CreateSubTask()
        {
        
        }
    }
}
