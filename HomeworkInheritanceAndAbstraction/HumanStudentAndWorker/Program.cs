using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students:");
            Console.WriteLine();
            List<Student> students = new List<Student>() 
            {
                new Student("John", "Anderson", 101115),
                new Student("Georgi", "Ivanov", 101215),
                new Student("Georgi", "Georgiev", 101315),
                new Student("Aleksandar", "Garov", 101415),
                new Student("Petur", "Petorv", 101515),
                new Student("Goshko", "Goshkov", 101615),
                new Student("Pesho", "Peshev", 101715),
                new Student("Teodor", "Ivanov", 101815),
                new Student("Stamat", "Ivanov", 101915),
                new Student("Mariika", "Ivanova", 102015)
            };

            foreach (var student in students.OrderBy(p => p.FacultyNumber))
            {
                Console.WriteLine(student);
            }

            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan", "Ivanov", 512m, 8),
                new Worker("Georgi", "Ivanov", 999m, 9),
                new Worker("Georgi", "Georgiev", 330m, 4),
                new Worker("Aleksandar", "Garov", 1100m, 11),
                new Worker("Petur", "Petorv", 650m, 6),
                new Worker("Goshko", "Goshkov", 660m, 8),
                new Worker("Pesho", "Peshev", 660m, 4),
                new Worker("Teodor", "Ivanov", 142m, 3),
                new Worker("Stamat", "Ivanov", 2200m, 10),
                new Worker("Mariika", "Ivanova", 860m, 7)
            };

            Console.WriteLine("Workers:");
            Console.WriteLine();

            foreach (var worker in workers.OrderByDescending(p => p.MoneyPerHour()))
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("Merged:");
            Console.WriteLine();

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            foreach (var human in humans.OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName))
            {
                Console.WriteLine(human);
            }

        }
    }
}
