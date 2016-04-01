using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rhombus : BasicShape
    {
        private double rhombusBase;

        public Rhombus(double rhombusBase, double height)
        {
            this.Height = height;
            this.RhombusBase = rhombusBase;
        }

        public double RhombusBase 
        { 
            get { return this.rhombusBase; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Write positive number");
                    }
                    this.rhombusBase = value;
                }
                catch (FormatException)
                {

                    throw new FormatException("Write NUMBER");
                }

            } 
        }

        public override double CalculateArea()
        {
            return this.RhombusBase * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 4 * this.RhombusBase;
        }
    }
}
