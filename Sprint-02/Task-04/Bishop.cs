using System;
using System.Collections.Generic;
using System.Text;

namespace Task_04
{
    class Bishop : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves by a diagonal!");
        }
    }
}
