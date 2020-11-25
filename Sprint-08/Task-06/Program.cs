
using System;
using System.Threading;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class PersonInTheShop
    {
        public void Enter() { }

        public void Pay() { }

        public void Leave() { }

        public void SelectGroceries() { }
    }

    class Buyer : PersonInTheShop
    {
        static Semaphore sem = new Semaphore(0, 10);

        public Buyer(string treadName)
        {
            Thread buyerThread = new Thread(() =>
            {
                sem.WaitOne();

                Enter();
                SelectGroceries();
                Pay();
                Leave();

                sem.Release();
            })
            { Name = treadName };
            buyerThread.Start();
        }
    }
}
