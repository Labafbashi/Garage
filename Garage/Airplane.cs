using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;
using CompName = Program.CompanyName;

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
    internal class Airplane
    {
        AirplaneType type;
        CompName company;

        public Airplane() { }

        public Airplane(AirplaneType type, CompName company)
        {
            this.type = type;
            this.company = company;
        }

        internal AirplaneType Type { get => type; set => type = value; }
        internal CompName Company { get => company; set => company = value; }

        public static AirplaneType Parse(string input)
        {
            switch (input)
            {
                case "Passenger":
                    return AirplaneType.Passenger;
                case "Freight":
                    return AirplaneType.Freight;
                case "Fighter":
                    return AirplaneType.Fighter;
                case "Powered":
                    return AirplaneType.Powered;
                case "Unpowered":
                    return AirplaneType.Unpowered;
                case "Jet":
                    return AirplaneType.Jet;
                default:
                    return AirplaneType.Passenger;
            }
        }

    }
}
