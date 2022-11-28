using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    enum Fuel
    {
        Benzine,
        Diesel,
        Gas,
        Electric
    }

    enum CompanyName
    {
        ACSchnitzer,
        Adler,
        Alfer,
        Bajai,
        BMW,
        Boxer,
        Ducati,
        HarleyDavidson,
        Kawasaki,
        Peugeot,
        Saxon,
        Suzuki,
        Yamaha
    }
    internal class Vehicle 
    {
        string place;
        string licensePlate;
        string color;
        int wheelsNumber;
        string owner;
        int speed;
        int enginSize;
        int cylender;
        Fuel fuel;

        public Vehicle() { }

        public Vehicle(string place, string licensePlate, string color, int wheelsNumber, string owner, int speed, int enginSize, int cylender, Fuel fuel)
        {
            this.place = place;
            this.licensePlate = licensePlate;
            this.color = color;
            this.wheelsNumber = wheelsNumber;
            this.owner = owner;
            this.speed = speed;
            this.enginSize = enginSize;
            this.cylender = cylender;
            this.fuel = fuel;
        }

        public string Place { get => place; set => place = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string Color { get => color; set => color = value; }
        public int WheelsNumber { get => wheelsNumber; set => wheelsNumber = value; }
        public string Owner { get => owner; set => owner = value; }
        public int Speed { get => speed; set => speed = value; }
        public int EnginSize { get => enginSize; set => enginSize = value; }
        public int Cylender { get => cylender; set => cylender = value; }
        internal Fuel Fuel { get => fuel; set => fuel = value; }

        public Fuel ConvertToFuel(string str)
        {
            switch (str)
            {
                case "BENZINE":
                    return Fuel.Benzine;
                case "DIESEL":
                    return Fuel.Diesel;
                case "GAS":
                    return Fuel.Gas;
                case "ELECTRIC":
                    return Fuel.Electric;
                default:
                    return Fuel.Benzine;
            }
        }
    }
}
