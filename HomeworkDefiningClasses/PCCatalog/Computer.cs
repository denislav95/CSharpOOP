using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }    
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return CalcPrice(this);
            }
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value.Count == 0)
                {
                    throw new Exception("Need at least one component");
                }
                this.components = value;
            }
        }

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public int CompareTo(object obj)
        {
            Computer computer = (Computer)obj;
            return this.Price.CompareTo(computer.Price);
        }

        public static decimal CalcPrice(Computer computer)
        {
            var components = computer.Components;
            decimal price = 0;

            foreach (var component in components)
            {
                price += component.Price;
            }
            return price;
        }

        public void AddComponent(Component component)
        {
            var list = this.Components;
            list.Add(component);
            this.Components = list;
        }

        public override string ToString()
        {
            string result = new string('-', 50) + "\n";
            result += "COMPUTER DESCRIPTION\n";
            result += new string('-', 50) + "\n";
            result += "Name: " + this.Name + "\n";
            result += "Components:\n";

            foreach (var component in this.Components)
            {
                result += String.Format("\t{0}{2} ({1:c2})\n",
                    component.Name, component.Price,
                    String.IsNullOrWhiteSpace(component.Details)
                    ? "" : ": " + component.Details);
            }

            result += String.Format("Total price: {0:c2}\n", this.Price);
            result += new string('-', 50) + "\n";

            return result;
        }
    }
}
