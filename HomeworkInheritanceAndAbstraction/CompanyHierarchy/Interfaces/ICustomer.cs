using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface ICustomer
    {
        decimal PurchasesAmount { get; set; }

        void AddPurchasePrice(decimal purchasePrice);

        string ToString();
    }
}
