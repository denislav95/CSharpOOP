﻿using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, Department department,
            decimal salary, ISet<Employee> employees = null)
            : base(id, firstName, lastName, department, salary)
        {
            this.Employees = employees ?? new HashSet<Employee>();
        }

        public ISet<Employee> Employees { get; set; }

        public void AddEmployees(ISet<Employee> employees)
        {
            foreach (var employee in employees)
            {
                this.Employees.Add(employee);
            }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Employees to manage: {0}\n",
                this.Employees.Count);
        }
    }
}
