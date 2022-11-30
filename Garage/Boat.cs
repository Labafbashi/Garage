using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompName = Program.CompanyName;

namespace Garage
{
    internal class Boat
    {
        string name;
        CompName company;

        public Boat(string name, CompName company) 
        {
            this.name = name;
            this.company = company;
        }

        public string Name { get => name; set => name = value; }
        internal CompName Company { get => company; set => company = value; }
    }
}
