using BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Classes
{
    public class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}
