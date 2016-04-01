using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces.Geometry.Geometry._3D
{
    class Point3D
    {
        private double xCoordinate;
        private double yCoordinate;
        private double zCoordinate;

        public Point3D(double xCoordinate = 0, double yCoordinate = 0, double zCordinate = 0)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
            this.ZCoordinate = zCordinate;
        }

        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public double ZCoordinate { get; set; }
    }
}
