using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(22, 7);
            Fraction fr2 = new Fraction(40, 4);
            Fraction result = fr1 + fr2;

            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
