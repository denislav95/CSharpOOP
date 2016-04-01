using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point;

namespace Namespaces.Geometry.Geometry._2D
{
    static class DistanceCalculator2D
    {
        public static double CalculateDistance2D(Point2D a, Point2D b)
        {
            double deltaX = a.XCoordinate - b.XCoordinate;
            double deltaY = a.YCoordinate - b.YCoordinate;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }
    }
}
