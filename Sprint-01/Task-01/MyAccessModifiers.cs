using System;

namespace Task_01
{
    class MyAccessModifiers
    {
        private int birthYear;

        protected string personalInfo;

        private protected string IdNumber;

        public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo) 
        {
            this.birthYear = birthYear;
            this.IdNumber = IdNumber;
            this.personalInfo = personalInfo;
        }

        public int Age => int.Parse(DateTime.Now.Year.ToString()) - birthYear;

        private static byte averageMiddleAge = 50;

        internal string Name { get; set; }

        public string NickName { get; internal set; }

        protected internal void HasLivedHalfOfLife() 
        {
            //TODO
        }


        public static bool operator == (MyAccessModifiers accessModifiers, MyAccessModifiers myAccessModifiers) 
        {
            return accessModifiers.Equals(myAccessModifiers);
        }
        public static bool operator != (MyAccessModifiers accessModifiers, MyAccessModifiers myAccessModifiers)
        {
            return !(accessModifiers.Equals(myAccessModifiers));
        }
        public override bool Equals(Object obj)
        {
            if (!(obj is MyAccessModifiers)) return false;

            MyAccessModifiers accessModifiers = (MyAccessModifiers)obj;
            return ((this.Name == accessModifiers.Name)
                && (this.Age == accessModifiers.Age)
                && (this.personalInfo == accessModifiers.personalInfo));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
