using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRootCalculator
    {
        private double number;

        public SquareRootCalculator(double number)
        {
            this.Number = number;
        }
        public double Number
        {
            get
            {
                return Math.Sqrt(this.number);
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number cannot be negative");
                }
                this.number = value;
            }
        }
    }
}
