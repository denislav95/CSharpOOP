using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces.Geometry.Geometry._2D
{
    class Square : Figure2D
    {
        private Point2D location;
        private double sideLength;

        public Square(Point2D location, double sideLength = 0)
        {
            this.Location = location;
            this.SideLength = sideLength;
        }

        public Point2D Location { get; set; }

        public double SideLength
        {
            get { return this.sideLength; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be negative.");
                }

                this.sideLength = value;
            }
        }

        public double Area
        {
            get { return this.SideLength * this.SideLength; }
        }
    }
}
