using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery batt;
        private double price;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, double price, Battery battery,
            string manufacturer)
            : this(model, price)
        {
            this.batt = battery;
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, double price, Battery battery,
            string manufacturer = null, string processor = null,
            int ram = 0, string graphicCard = null, string hdd = null,
            string screen = null) : this(model, price, battery, manufacturer)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.HDD = hdd;
            this.Screen = screen;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Model is required !");
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new Exception("RAM must be bigger than 0");
                this.ram = value;
            }
        }

        public string GraphicCard
        {
            get { return this.graphicCard; }
            set { this.graphicCard = value; }
        }

        public string HDD
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Price must be a positive number bigger than 0");
                this.price = value;
            }
        }

        public void AddBattery(Battery battery)
        {
            this.batt = battery;
        }

        public override string ToString()
        {
            string result = "Model: " + this.model + "\n";
                if (!String.IsNullOrEmpty(this.manufacturer))
                    result += "Manufacturer: " + this.manufacturer + "\n";
                if (!String.IsNullOrEmpty(this.processor))
                    result += "Processor: " + this.processor + "\n";
                if (this.ram != 0)
                    result += "RAM: " + this.ram + "\n";
                if (!String.IsNullOrEmpty(this.graphicCard))
                    result += "Graphic card: " + this.graphicCard + "\n";
                if (!String.IsNullOrEmpty(this.hdd))
                    result += "HDD: " + this.hdd + "\n";
                if (!String.IsNullOrEmpty(this.screen))
                    result += "Screen: " + this.screen + "\n";
                result += batt + "\n";

                result += "Price: " + this.price + " lv.\n";

                return result;
        }
    }
}
