using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class Program
    {
        public const int MonthsInYear = 12;
        static void Main(string[] args)
        {

            InterestCalculatorClass compoundInterest = 
                new InterestCalculatorClass(500m, 0.056m, 10, GetCompoundInterest);
            Console.WriteLine(compoundInterest.Balance);

            InterestCalculatorClass simpleInterest = 
                new InterestCalculatorClass(2500m, 0.072m, 15, GetSimpleInterest);
            Console.WriteLine(simpleInterest.Balance);

        }

        public static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            decimal interestFactor = 1 + (interest * years);
            decimal sum = money * interestFactor;

            return decimal.Round(sum, 4);
        }

        public static decimal GetCompoundInterest(decimal money, decimal interest, int years)
        {
            decimal interestFactorBase = 1 + (interest / MonthsInYear);
            int interestFactorPower = years * MonthsInYear;

            decimal interestFactor = 1;

            for (int i = 0; i < interestFactorPower; i++)
            {
                interestFactor *= interestFactorBase;
            }

            decimal sum = money * interestFactor;

            return decimal.Round(sum, 4);
        }
    }
}
