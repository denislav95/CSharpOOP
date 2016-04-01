using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, Department department,
            decimal salary, ISet<Sale> sales = null)
            : base(id, firstName, lastName, department, salary)
        {
            this.Sales = sales ?? new HashSet<Sale>();
        }

        public ISet<Sale> Sales { get; set; }

        public void AddSales(ISet<Sale> sales)
        {
            foreach (var sale in sales)
            {
                this.Sales.Add(sale);
            }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Number of sales: {0}",
                this.Sales.Count);
        }
    }
}
