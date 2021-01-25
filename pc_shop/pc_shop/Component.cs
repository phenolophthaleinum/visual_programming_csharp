using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_shop
{
    public abstract class Component
    {
        private string name;
        private double price;

        public Component(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Component() { }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
