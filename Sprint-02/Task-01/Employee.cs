using System;

namespace Task_01
{
    public class Emploee
    {
        internal string name;
        private DateTime hiringDate;

        public Emploee(string name, DateTime hiringDate) 
        {
            this.name = name;
            this.hiringDate = hiringDate;
        }

        public int Experience() 
        {
            int Experience = DateTime.Today.Year - hiringDate.Year;
            if (hiringDate.Date > DateTime.Today.AddYears(-Experience)) Experience--;
            return Experience;
        }
        public void ShowInfo() => Console.WriteLine($"{name} has {Experience()} years of experience");
    }
}
