using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces.Geometry.Geometry._2D
{
    class Circle : Figure2D
    {
        private double radius;

        public Circle(Point2D center, double radius = 0)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public Point2D Center { get; set; }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative");
                }
                this.radius = value;
            }
        }
    }
}
