using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Project : IProject
    {
        private string name;

        public Project(string name, string details, DateTime startDate)
        {

        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be empty");
                }
                this.name = value;
            } 
        }

        public string Details { get; set; }

        public DateTime StartDate { get; set; }

        public ProjectState State { get; set; }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }
    }
}
