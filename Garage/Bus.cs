using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompName = Program.CompanyName;

namespace Garage
{
    internal class Bus
    {
        string name;
        CompName company;

        public Bus( string name, CompName company) 
        {
            this.name = name;
            this.company = company;
        }

        public string Name { get => name; set => name = value; }
        internal CompName Company { get => company; set => company = value; }
    }
}
