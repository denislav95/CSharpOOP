using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                SquareRootCalculator number = new SquareRootCalculator(25);
                Console.WriteLine(number.Number);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
