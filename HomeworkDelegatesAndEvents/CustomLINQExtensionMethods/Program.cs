using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>()
            {
                 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var filteredCollection = nums.WhereNot(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", filteredCollection));


            var students = new List<Student>()
            {
                new Student("Ani", 6),
                new Student("Ivan", 4),
                new Student("Penka", 5),
                new Student("Gosho", 3)
            };

            Console.WriteLine();

            Console.WriteLine(students.Max(student => student.Grade));
            Console.WriteLine(students.Max(student => student.Name));

            Console.WriteLine();

            Console.WriteLine(students.Min(student => student.Grade));
            Console.WriteLine(students.Min(student => student.Name));

            Console.WriteLine();

            Console.WriteLine(students.MaxStudent(student => student.Name));
            Console.WriteLine(students.MaxStudent(student => student.Grade));

            Console.WriteLine();

            Console.WriteLine(students.MinStudent(student => student.Name));
            Console.WriteLine(students.MinStudent(student => student.Grade));
        }
    }
}
