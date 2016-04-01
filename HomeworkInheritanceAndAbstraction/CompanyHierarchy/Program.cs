﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager(15264, "Manager1", "Manager1 Last name", Department.Accounting, 123m);
            Manager manager2 = new Manager(18987, "Manager2", "Manager2 Last name", Department.Sales, 3124m);
            Manager manager3 = new Manager(1423738, "Manager2", "Manager2 Last name", Department.Marketing, 1423m);

            SalesEmployee salesEmployee1 = new SalesEmployee(776724, "SalesEmployee1", "SalesEmployee1 Last name", Department.Accounting, 512m);
            SalesEmployee salesEmployee2 = new SalesEmployee(12789, "SalesEmployee2", "SalesEmployee2 Last name", Department.Marketing, 513m);
            SalesEmployee salesEmployee3 = new SalesEmployee(53796, "SalesEmployee3", "SalesEmployee3 Last name", Department.Production, 1000m);

            Developer developer1 = new Developer(123, "Developer1", "Developer1 Last name", Department.Marketing, 5523m);
            Developer developer2 = new Developer(586934, "Developer2", "Developer2 Last name", Department.Sales, 513m);
            Developer developer3 = new Developer(1237673, "Developer3", "Developer3 Last name", Department.Accounting, 523m);

            Sale sale = new Sale("graphic card", DateTime.Now, 220m);
            Project project = new Project("OOP", "OOP course", DateTime.Now);

            manager1.AddEmployees(new HashSet<Employee> { salesEmployee1, developer3 });
            salesEmployee1.AddSales(new HashSet<Sale> { sale });
            developer1.AddProjects(new HashSet<Project> { project });

            IList<Employee> employees = new List<Employee>
            {
                manager1,
                manager2,
                manager3,
                salesEmployee1,
                salesEmployee2,
                salesEmployee3,
                developer1,
                developer2,
                developer3
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
