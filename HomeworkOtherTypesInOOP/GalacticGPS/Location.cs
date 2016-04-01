using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planets;

        public Location(double latitude, double longitude, Planet planets)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planets = planets;
        }

        public Planet Planets { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude,
                this.Planets);
        }
    }
}
