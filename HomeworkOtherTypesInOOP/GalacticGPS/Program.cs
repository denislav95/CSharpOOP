﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.0379686, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
