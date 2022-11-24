using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Garage
    {
        private string name;
        private int capacity;

        public Garage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }
    }
}
