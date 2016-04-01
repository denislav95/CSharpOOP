using BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Classes
{
    public abstract class Account : IAccount, IDepositable
    {
        private decimal monthlyInterestRate;
        private ICustomer customer;
        private decimal balance;

        public Account(ICustomer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public decimal MonthlyInterestRate 
        {
            get { return this.monthlyInterestRate; }
            set
            {
                this.monthlyInterestRate = value;
            } 
        }

        public ICustomer Customer 
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Account customer can not be null!");
                }
                this.customer = value;
            } 
        }

        public decimal Balance 
        {
            get { return this.balance; }
            set
            {
                this.balance = value;
            } 
        }

        public virtual decimal CalculateRate(double months)
        {
            return this.Balance * (1 + ((this.MonthlyInterestRate) * (decimal)months / 100));
        }

        public virtual void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
