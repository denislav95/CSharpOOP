using BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Classes
{
    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}
