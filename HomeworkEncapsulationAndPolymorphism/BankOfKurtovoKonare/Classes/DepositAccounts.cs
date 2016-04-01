using BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Classes
{
    public class DepositAccounts : Account, IAccount, IDepositable, IWithdrawable
    {
        public DepositAccounts(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {

        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateRate(double months)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateRate(months);
            }
        }
    }
}
