using System;
using System.Collections.Generic;
using System.Text;

namespace Task_05
{
    class Child : Person
    {
        public Child(int yearOfBirth,
                     string healthInfo,
                     string name,
                     string childIDNumber) : base(yearOfBirth, name, healthInfo)
        {
            this.childIDNumber = childIDNumber;
        }

        public override string ToString()
        {
            return $"{name} {childIDNumber}";
        }

        private string childIDNumber;
    }
}
