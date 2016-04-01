using BankOfKurtovoKonare.Classes;
using BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer pesho = new IndividualCustomer("Pesho Peshov");
            ICustomer ITCompany = new CompanyCustomer("IT Company Ltd.");

            IAccount mortgageAccInd = new MortgageAccount(pesho, 1024m, 5.3m);
            IAccount mortgageAccComp = new MortgageAccount(ITCompany, 1024m, 5.3m);
            IAccount loanAccInd = new LoanAccount(pesho, 1024m, 5.3m);
            IAccount loanAccComp = new LoanAccount(ITCompany, 1024m, 5.3m);
            IAccount depositAccIndBig = new DepositAccounts(pesho, 1024m, 5.3m);
            IAccount depositAccIndSmall = new DepositAccounts(pesho, 999m, 5.3m);
            IAccount depositAccComp = new DepositAccounts(ITCompany, 11024m, 4.3m);

            List<IAccount> accounts = new List<IAccount>()
            {
                mortgageAccInd,
                mortgageAccComp,
                loanAccInd,
                loanAccComp,
                depositAccIndBig,
                depositAccIndSmall,
                depositAccComp
            };

            foreach (var acc in accounts)
            {
                Console.WriteLine(
                    "{5} {0}: {1:N2}, {2:N2}, {3:N2}, {4:N2}",
                    acc.GetType().Name,
                    acc.CalculateRate(2),
                    acc.CalculateRate(3),
                    acc.CalculateRate(10),
                    acc.CalculateRate(13),
                    acc.Customer.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}
