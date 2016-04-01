using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public abstract class Person
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id 
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be negative");
                }
                this.id = value;
            } 
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                this.firstName = value;
            } 
        }

        public string LastName 
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Id: {0}\nFirst name: {1}\nLast name: {2}",
                this.Id, this.FirstName, this.LastName);
        }
    }
}
