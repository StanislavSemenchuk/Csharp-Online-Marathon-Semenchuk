using System;

namespace Task_03
{
    public class Fraction
    {

        private readonly int denominator;

        private readonly int numerator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            this.numerator = numerator;
            this.denominator = denominator;

        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) 
            => Simplify(new Fraction(-a.numerator, a.denominator));

        public static Fraction operator +(Fraction a, Fraction b)
            => Simplify(new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator));

        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)
            => Simplify(new Fraction(a.numerator * b.numerator, a.denominator * b.denominator));

        public static Fraction operator /(Fraction a, Fraction b)
            => Simplify(new Fraction(a.numerator * b.denominator, a.denominator * b.numerator));

        public static Fraction operator !(Fraction fr) 
            => new Fraction(fr.denominator, fr.numerator);

        public static bool operator ==(Fraction fraction, Fraction fraction1)
            => fraction.Equals(fraction1);

        public static bool operator !=(Fraction fraction, Fraction fraction1)
            => !(fraction.Equals(fraction1));

        public override bool Equals(Object obj)
        {
            if (!(obj is Fraction)) return false;

            var fraction = (Fraction)obj;

            fraction = Simplify(fraction);

            return this.denominator == fraction.denominator
                && this.numerator==fraction.numerator;
        }

        public override int GetHashCode()
            => base.GetHashCode();

        public override string ToString()
        {
            Fraction fr = new Fraction(this.numerator, this.denominator);
            fr = Simplify(fr);
            return $"{fr.numerator} / {fr.denominator}";
        }

        private static int GreatestCommonDevisor(int value1, int value2)
        {
            if (value2 == 0)
                return value1;
            else
                return GreatestCommonDevisor(value2, value1 % value2);
        }

        private static Fraction Simplify(Fraction fr)
        {
            int gcdNumber = GreatestCommonDevisor(fr.numerator, fr.denominator);
            
            int numerator = fr.numerator;
            int denominator = fr.denominator;

            if (gcdNumber != 0)
            {
                numerator /= gcdNumber;
                denominator /= gcdNumber;
            }
            if (denominator < 0)
            {
                denominator = denominator* -1;
                numerator = numerator * -1;
            }

            return new Fraction(numerator, denominator);
        }
    }
}
