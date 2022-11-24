using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    enum MotorType
    {
        Classic,
        Custom,
        Individual,
        Racing
    }   
    internal class Motorcycle : Vehicle
    {
        string engine;
        CompanyName brand;
        MotorType type;

        public Motorcycle(string place, string licensePlate, string color, int wheelsNumber, string owner, int speed, int enginSize, int cylender, Fuel fuel, string engine, CompanyName brand, MotorType type) : base(place, licensePlate, color, wheelsNumber, owner, speed, enginSize, cylender, fuel)
        {
            this.engine = engine;
            this.brand = brand;
            this.type = type;
        }

        public string Engine { get => engine; set => engine = value; }
        internal CompanyName Brand { get => brand; set => brand = value; }
        internal MotorType Type { get => type; set => type = value; }
    }
}
