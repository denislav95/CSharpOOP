using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, "")
        {
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("The name cannot be empty");
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                    throw new Exception("The age must be in the range [1...100]");
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
               return this.email;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.email = "(email not set!)";
                else if (!value.Contains("@"))
                    throw new Exception("The email must contain '@'");
                else
                    this.email = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
        }
        static void Main()
        {
            Person pesho = new Person("Pesho", 15, "pesho@abv.bg");
            Person gosho = new Person("Gosho", 25);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);

        }
    }
}
