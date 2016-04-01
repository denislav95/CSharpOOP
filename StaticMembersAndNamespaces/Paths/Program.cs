using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point3D> listOfPoints = new List<Point3D>();
            listOfPoints.Add(Point3D.StartingPoint);
            listOfPoints.Add(new Point3D(0, 3, 5));
            listOfPoints.Add(new Point3D(2.8, -3.2, 10));
            listOfPoints.Add(new Point3D(-1.1, 0, 2));

            Path3D path = new Path3D(listOfPoints);
            path.AddPointToPath(new Point3D(2, -3.5, 10.325));
            Console.WriteLine(path);

            string fileLocation = "Path3D.txt";
            Storage.SaveToPathFile(fileLocation, path);

            Path3D pathFromFile = Storage.LoadPathFromFile(fileLocation);
            Console.WriteLine(pathFromFile);

        }
    }
}
