using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface IDeveloper
    {
        ISet<Project> Projects { get; set; }

        void AddProjects(ISet<Project> projects);

        string ToString();
    }
}
