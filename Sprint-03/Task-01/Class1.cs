using System;

namespace Task_01
{

    public class CalcProgram
    {
        public delegate double CalcDelegate(int x, int y, char sign);
        public static double Calc(int x, int y, char sign) 
        {
            switch(sign)
            {
                case '+':
                    return (double)(x + y);
                case '-':
                    return (double)(x - y);
                case '*':
                    return (double)(x * y);
                case '/':
                    if (y == 0)
                        return default;
                    else
                        return (double)(x / y);
                default:
                    Console.WriteLine("Something Wrong!!");
                    return 0;
            }
        }

        CalcDelegate calcDelegate = Calc;

    }
}