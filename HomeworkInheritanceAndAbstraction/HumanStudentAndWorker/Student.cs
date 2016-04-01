using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    public class Student : Human
    {
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.ToString().Length < 5 || value.ToString().Length > 10)
                {
                    throw new ArgumentOutOfRangeException("The faculty number must be in the range [5...10]");
                }
                this.facultyNumber = value;
            } 
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Faculty number:{0}\n",
                this.FacultyNumber);
        }
    }
}
