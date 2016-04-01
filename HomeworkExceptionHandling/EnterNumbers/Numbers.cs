using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Numbers
    {

        public Numbers()
        {
        }

        public void ReadNumber(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (start < 0 || end > 100)
                {
                    throw new ArgumentOutOfRangeException("The number should be in the range [1...100]");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
