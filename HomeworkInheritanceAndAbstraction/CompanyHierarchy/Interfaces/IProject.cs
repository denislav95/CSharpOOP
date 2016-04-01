using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string Name { get; set; }

        string Details { get; set; }

        DateTime StartDate { get; set; }

        ProjectState State { get; set; }

        void CloseProject();
    }
}
