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

        public Vehicle FindVehicle(string lp)
        {
            foreach (var v in vehicles) 
            {
                if (v.LicensePlate == lp)
                {
                    return v;
                }
            }
            return null;
        }

        public bool Park(T newVehicle)
        {
            //loop through vehicles array
            // find first null
            // make that spot into newVehicle, return true

            // iif no null is found, return false
            return false;
        }

        public bool Unpark(string licenseNumber)
        {
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
                //TODO: add nullcheck
                //yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
