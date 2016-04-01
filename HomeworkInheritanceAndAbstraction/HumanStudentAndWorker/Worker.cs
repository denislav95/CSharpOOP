using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName,
            decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                this.weekSalary = value;
            } 
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException("Hours must be in the range [0...24]");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = this.WeekSalary / (this.workHoursPerDay * 7);
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Weekly salary:{0}\n, Work hours per day:{1}, Money per hour:{2}\n",
            this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
