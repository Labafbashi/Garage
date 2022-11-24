using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    enum AirplaneType
    {
        Passenger,
        Freight,
        Fighter,
        Powered,
        Unpowered,
        Jet
    }
    internal class Airplane : Vehicle
    {
        AirplaneType type;
        CompanyName company;

        public Airplane(string place, string licensePlate, string color, int wheelsNumber, string owner, int speed, int enginSize, int cylender, Fuel fuel, AirplaneType type, CompanyName company) : base(place, licensePlate, color, wheelsNumber, owner, speed, enginSize, cylender, fuel)
        {
            this.type = type;
            this.company = company;
        }

        internal AirplaneType Type { get => type; set => type = value; }
        internal CompanyName Company { get => company; set => company = value; }
    }
}
