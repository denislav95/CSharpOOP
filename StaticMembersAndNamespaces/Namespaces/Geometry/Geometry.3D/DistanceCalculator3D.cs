﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces.Geometry.Geometry._3D
{
    static class DistanceCalculator3D
    {
        public static double CalculateDistance3D(Point3D pointA, Point3D pointB)
        {
            double deltaX = pointA.XCoordinate - pointB.XCoordinate;
            double deltaY = pointA.YCoordinate - pointB.YCoordinate;
            double deltaZ = pointA.ZCoordinate - pointB.ZCoordinate;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            return distance;
        }
    }
}
