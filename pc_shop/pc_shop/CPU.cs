using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_shop
{
    [Serializable]
    public class CPU : Component
    {
        public CPU(string name, double price):base(name, price) { }
        public CPU() { }
    }
}
