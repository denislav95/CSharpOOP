using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point;

namespace Distance
{
    public static class DistanceCalculator
    {
        public static double CalcDistance(Point3D p1, Point3D p2)
        {
            double deltaX = p1.X - p2.X;
            double deltaY = p1.Y - p2.Y;
            double deltaZ = p1.Z - p2.Z;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
