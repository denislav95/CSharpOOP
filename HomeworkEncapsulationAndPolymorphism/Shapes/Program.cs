using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape rhombus = new Rhombus(4.5, 8);

            IShape rectangle = new Rectangle(3.1, 2);

            IShape circle = new Circle(2.5);

            IShape[] shapes = new IShape[3] { rhombus, rectangle, circle };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0, -20}: Perimeter: {1:N2}, Area: {2:N2}",
                    shape.GetType().Name, shape.CalculatePerimeter(), shape.CalculateArea());
            }
        }
    }
}
