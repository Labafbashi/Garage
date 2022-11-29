using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Garage<T>: IEnumerable<T> where T: Vehicle
    {
        private string name;
        private int capacity;

        private T[] vehicles;

        public Garage(string name, int capacity)
        {
            this.Name = name;
            this.capacity = capacity;
            vehicles = new T[capacity];
        }

        public Garage() { }

        public string Name { get => name; set => name = value; }

        //public string Name2 { get; set; }

        public int Capacity => capacity;

        public Vehicle FindVehicle(string searchWord)
        {

            if (!vehicles.Any(v => v is not null)) return null;
            foreach (var v in vehicles) 
            {
                if (v.LicensePlate == searchWord)
                {
                    return v;
                }
            }
            return null;
        }

        public bool Park(T newVehicle)
        {
            for(var i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = newVehicle;
                    return true;
                }
            }
  
            return false;
        }

        public bool Unpark(string licenseNumber)
        {
            for(var i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is not null && vehicles[i].LicensePlate == licenseNumber)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle is not null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void ListAllVehicle()
        {
            if (vehicles.Any(v => v is not null))
            {
                PrintHeader();
                foreach (var v in vehicles)
                {
                    if (v is not null)
                    {
                        PrintVehicle(v);
                    }
                }
                PrintFooter();
            }
            else
            {
                Console.WriteLine("The Garage is empty!!!");
            }
        }

        
        public void PrintHeader()
        {
            Console.WriteLine("Garage Place \t License Plate \t Color \t Wheels no. \t Owner \t Speed \t Engin Size \t Cylender no. \t Fuel");
            Console.WriteLine("============ \t ============= \t ===== \t ========== \t ===== \t ===== \t ========== \t ============ \t ====");
        }
        public void PrintVehicle(T paramV)
        {
            Console.WriteLine($"{paramV.Place} \t {paramV.LicensePlate} \t {paramV.Color} \t {paramV.WheelsNumber} \t {paramV.Owner} \t {paramV.Speed} \t {paramV.EnginSize} \t {paramV.Cylender} \t {paramV.Fuel}");
        }
        public void PrintFooter()
        {
            Console.WriteLine("End of the list, please press any key to continue.");
        }
    }
}
