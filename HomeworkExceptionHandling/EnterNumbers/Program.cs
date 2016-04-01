using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.ReadNumber(-1, 15);
        }
    }
}
