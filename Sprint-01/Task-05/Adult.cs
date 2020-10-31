using System;
using System.Collections.Generic;
using System.Text;

namespace Task_05
{
    class Adult : Person
    {
        public Adult(int yearOfBirth,
                     string healthInfo,
                     string name,
                     string passportNumber) : base(yearOfBirth, name, healthInfo)
        {
            this.passportNumber = passportNumber;
        }
        private string passportNumber;

        public override string ToString()
        {
            return $"{name} {passportNumber}";
        }
    }
}
