using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public delegate decimal CalculateInterest(decimal money, decimal interest, int years);

    public class InterestCalculatorClass
    {
        private readonly CalculateInterest calculationMethod;

        private decimal interest;
        private int years;

        public InterestCalculatorClass(decimal money, decimal interest,
            int years, CalculateInterest calculationMethod)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.calculationMethod = calculationMethod;
        }

        public decimal Money { get; set; }

        public decimal Interest { get; set; }

        public int Years { get; set; }

        public decimal Balance 
        {
            get 
            {
                return this.calculationMethod(this.Money, this.Interest, this.Years);
            }
        }
    }
}
