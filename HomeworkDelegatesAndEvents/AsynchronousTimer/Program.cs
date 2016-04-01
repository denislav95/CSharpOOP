using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class Program
    {
        private static readonly Encoding EncodingOEMUnitedStates = Encoding.GetEncoding(437);

        public static void PasswordGenerator(int x)
        {
            string ch = EncodingOEMUnitedStates.GetString(new byte[] { (byte)x });
            Console.WriteLine(ch);
        }

        public static void AddNewLine(int x)
        {
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            AsynchronousTimerClass passGenerator =
                new AsynchronousTimerClass(PasswordGenerator, 20, 100000);
            passGenerator.ExecuteAction();

            AsynchronousTimerClass addNewLine =
                new AsynchronousTimerClass(AddNewLine, 3, 50000);
            addNewLine.ExecuteAction();
        }
    }
}
