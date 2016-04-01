using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D temp = new Point3D(5.2, 3.8, 1.5);
            Point3D temp2 = Point3D.StartingPoint;

            Console.WriteLine(temp);
            Console.WriteLine(temp2);
        }
    }
}
