using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; set; }

        decimal Balance { get; }

        decimal MonthlyInterestRate { get; }

        decimal CalculateRate(double months);
    }
}
