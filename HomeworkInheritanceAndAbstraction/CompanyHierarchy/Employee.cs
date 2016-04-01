using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    abstract class Employee : Person, IEmployee
    {
        private Department department;
        private decimal salary;

        protected Employee(int id, string firstName, string lastName,
            Department department, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public Department Department { get; set; }

        public decimal Salary 
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }
                this.salary = value;
            } 
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Department: {0}\nSalary: {1}\n",
                this.Department, this.Salary);
        }
    }
}
