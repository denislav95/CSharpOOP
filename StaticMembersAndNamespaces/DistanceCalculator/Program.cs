using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D(1, -8, 5);
            Point3D b = new Point3D(25, 2, 6.3);

            Console.WriteLine(DistanceCalculator.CalcDistance(a, b));
        }
    }
}
