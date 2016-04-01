using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("Acer ASPIRE", 999,
                new Battery("Li-ion", 3), "Acer", "AMD", 4,
                "AMD Radeon", "750GB HDD", "Full HD");

            Laptop laptop2 = new Laptop("Asus", 2399);
            Battery battery = new Battery("Cell-ion", 1);
            laptop2.AddBattery(battery);

            Laptop laptop3 = new Laptop("Dell Inspiron", 899,
                new Battery("Del-ion", 1), "Dell");

            Console.WriteLine(laptop1);
            Console.WriteLine(laptop2);
            Console.WriteLine(laptop3);
        }
    }
}
