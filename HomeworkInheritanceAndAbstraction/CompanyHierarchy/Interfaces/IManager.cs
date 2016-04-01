using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface IManager
    {
        ISet<Employee> Employees { get; set; }

        void AddEmployees(ISet<Employee> employees);

        string ToString();
    }
}
