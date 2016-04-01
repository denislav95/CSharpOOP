using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string battery;
        private int batteryLife;

        public Battery(string battery = null, int batteryLife = 0)
        {
            this.Batt = battery;
            this.BatteryLife = batteryLife;
        }

        public string Batt
        {
            get { return this.battery; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.battery = null;
                this.battery = value;
            }
        }

        public int BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                    throw new Exception("The value must be a positive number");
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return "Battery: " + this.battery +
                " Battery life: " + this.batteryLife;
        }
    }
}
