using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;
using CompName = Program.CompanyName;

namespace Garage
{
    enum MotorType
    {
        Classic,
        Custom,
        Individual,
        Racing
    }   
    internal class Motorcycle
    {
        CompName brand;
        MotorType type;

        public Motorcycle(CompName brand, MotorType type)
        {
            this.brand = brand;
            this.type = type;
        }

        internal CompName Brand { get => brand; set => brand = value; }
        internal MotorType Type { get => type; set => type = value; }

        public static MotorType Parse(string input)
        {
            switch (input)
            {
                case "Classic":
                    return MotorType.Classic;
                case "Custom":
                    return MotorType.Custom;
                case "Individual":
                    return MotorType.Individual;
                case "Racing":
                    return MotorType.Racing;
                default:
                    return MotorType.Classic;
            }
        }
        public static void MotorTypePrint()
        {
            int counter = 0;
            for (int i = 0; i < 60; i++) { Console.Write("-"); }
            Console.WriteLine();
            foreach (string name in Enum.GetNames(typeof(MotorType)))
            {
                Console.Write($"| {name,15} |");
                if (counter % 3 == 2)
                {
                    Console.WriteLine();
                }
                counter++;
            }
            Console.WriteLine();
            for (int i = 0; i < 60; i++) { Console.Write("-"); }
            Console.WriteLine() ;
        }
    }
}
