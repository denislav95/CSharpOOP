using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            } 
        }

        public int Age 
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Age cannot be negative");
                }
                this.age = value;
            }
        }

        public string Gender { get; set; }

        public abstract void ProduceSound();
    }
}
