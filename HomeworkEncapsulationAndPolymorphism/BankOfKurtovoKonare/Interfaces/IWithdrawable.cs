using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Interfaces
{
    public interface IWithdrawable
    {
        void Withdraw(decimal amount);
    }
}
