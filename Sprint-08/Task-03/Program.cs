using System;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks();
        }

        public static void Tasks()
        {
            int[] sequense_array = new int[10];

            Task[] tasks1 = new Task[3] {
                new Task(()=>{
                    for (int i = 0; i < 10; i++)
                    {
                        sequense_array[i] = i*i;
                    }
                    Console.WriteLine("Calculated!");
                }),
                new Task(()=>{
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Bye!");
                }),
                new Task(()=>{
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(sequense_array[i]);
                    }
                    Console.WriteLine("Bye!");
                })
            };

            for (int i = 0; i < tasks1.Length; i++)
            {
                tasks1[i].Start();
                tasks1[i].Wait();
            }

            Task.WaitAll(tasks1);

            Console.WriteLine("Main done!");
        }
    }
}
