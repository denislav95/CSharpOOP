using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(int id, string firstName, string lastName, Department department,
            decimal salary)
            : base(id, firstName, lastName, department, salary)
        {

        }
    }
}
