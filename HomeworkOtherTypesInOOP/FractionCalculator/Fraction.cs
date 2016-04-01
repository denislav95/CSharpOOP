using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    public struct Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public int Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public int Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new InvalidOperationException("Denominator cannot be 0.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            f1.Numerator *= f2.Denominator;
            f2.Numerator *= f1.Denominator;
            int denom = f1.Denominator * f2.Denominator;

            return new Fraction(f1.Numerator + f2.Numerator, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            f1.Numerator *= f2.Denominator;
            f2.Numerator *= f1.Denominator;
            int denom = f1.Denominator * f2.Denominator;

            return new Fraction(f1.Numerator - f2.Numerator, denom);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }

    }
}
