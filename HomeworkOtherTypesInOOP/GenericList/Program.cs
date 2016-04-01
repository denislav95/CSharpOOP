using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new GenericListT<int>(1);

            intList.AddElem(1);

            intList.AddElem(2);

            intList.InsertAtIndex(0, 0);

            intList.RemoveAtIndex(2);

            intList.AddElem(2);

            Console.WriteLine(intList);

            Console.WriteLine(intList.Min());

            Console.WriteLine(intList.Max());

           
            var stringList = new GenericListT<string>();
            stringList.AddElem("first element");
            stringList.AddElem("second element");

            Console.WriteLine(stringList.IndexOf("first element"));

            Console.WriteLine(stringList.Contains("second element"));
 
            Console.WriteLine(stringList);

            stringList.ClearList();

            Console.WriteLine(stringList);

            Console.WriteLine();

            Type type = intList.GetType();
            object[] allAttributes =
                type.GetCustomAttributes(false)
                .Where(x => x.GetType() == typeof(VersionAttribute))
                .ToArray();

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine(attr.Major + "." + attr.Minor);
            }
        }
    }
}
