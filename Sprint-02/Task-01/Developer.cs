using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01
{
    class Developer : Emploee
    {
        private string programmingLanguage;

        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate) 
        {
            this.programmingLanguage = programmingLanguage;
        }

        public void ShowInfo() => Console.WriteLine($"{name} has {Experience()} years of experience. {name} is { programmingLanguage } programmer");
    }
}
