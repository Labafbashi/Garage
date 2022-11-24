using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Boat : Vehicle
    {
        string name;
        CompanyName company;

        public Boat(string place, string licensePlate, string color, int wheelsNumber, string owner, int speed, int enginSize, int cylender, Fuel fuel, string name, CompanyName company) : base(place, licensePlate, color, wheelsNumber, owner, speed, enginSize, cylender, fuel)
        {
            this.name = name;
            this.company = company;
        }

        public string Name { get => name; set => name = value; }
        internal CompanyName Company { get => company; set => company = value; }
    }
}
