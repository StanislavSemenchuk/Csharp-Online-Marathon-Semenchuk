﻿using System;
using System.Threading;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class ParallelUtils<T, TR>
    {
        Func<T, T, TR> func;
        T operand1;
        T operand2;
        public ParallelUtils(Func<T,T,TR> func, T operand1, T operand2)
        {
            this.func = func;
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        public TR Result { get; set; }

        public void StartEvaluation() 
        {
            Thread thread = new Thread(Evaluate);
            thread.Start();
        }
        public void Evaluate() 
        {
            Result = func(operand1, operand2);
        }
    }
}
