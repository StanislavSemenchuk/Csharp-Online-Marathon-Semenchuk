using System;

namespace Task_05
{
    public class Person
    {

        public Person(int yearOfBirth,
                      string healthInfo,
                      string name) 
        {
            this.yearOfBirth = yearOfBirth;
            this.healthInfo = healthInfo;
            this.name = name;
        }

        protected int yearOfBirth;
        protected string healthInfo;
        protected string name;
        public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
    }
}
