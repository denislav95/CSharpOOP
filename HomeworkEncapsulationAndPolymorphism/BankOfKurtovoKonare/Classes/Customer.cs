using BankOfKurtovoKonare.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Classes
{
    public abstract class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string  Name 
        {
            get { return this.name; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty or null");
                }
                this.name = value;
            } 
        }
    }
}
