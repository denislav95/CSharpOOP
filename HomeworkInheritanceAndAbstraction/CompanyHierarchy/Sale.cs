using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Sale : ISale
    {
        private string productName;
        private decimal productPrice;

        public Sale(string productName, DateTime saleDate, decimal price)
        {
            this.ProductName = productName;
            this.SaleDate = saleDate;
            this.ProductPrice = productPrice;
        }

        public string  ProductName 
        {
            get { return this.productName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty");
                }
                this.productName = value;
            } 
        }

        public DateTime SaleDate { get; set; }

        public decimal ProductPrice 
        {
            get { return this.productPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product price cannot be negative");
                }
                this.productPrice = value;
            } 
        }
    }
}
