using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01
{
    class Tester : Emploee
    {
        private bool isAuthomation;

        public Tester(string name, DateTime hiringDate ,bool isAiuthomation) : base(name, hiringDate)
        {
            this.isAuthomation = isAuthomation;
        }


        public void ShowInfo() 
        {
            if (isAuthomation) 
                Console.WriteLine($"{name} is authomated tester and has {Experience()} year(s) of experience");
            else
                Console.WriteLine($"{name} is manual tester and has {Experience()} year(s) of experience");
        }
    }
}
