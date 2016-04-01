using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal purchasesAmount;

        public Customer(int id, string firstName, string lastName, decimal purchasesAmount)
            : base(id, firstName, lastName)
        {
            this.PurchasesAmount = purchasesAmount;
        }

        public decimal PurchasesAmount
        {
            get { return this.purchasesAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Purchases amount cannot be negative");
                }
                this.purchasesAmount = value;
            }
        }

        public void AddPurchasePrice(decimal purchasePrice)
        {
            this.purchasesAmount += purchasePrice;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendFormat("Purchases amount: {0}",
                this.PurchasesAmount);
            return result.ToString();
        }
    }
}
