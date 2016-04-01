using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            StringDisperser stringDisperserCopy = (StringDisperser)stringDisperser.Clone();
            stringDisperser.TotalString.Append("Borko");
            stringDisperserCopy.TotalString.Append("Alex");

            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();

            foreach (var item in stringDisperserCopy)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
