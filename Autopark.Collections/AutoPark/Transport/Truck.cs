using AutoPark.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    [Serializable]
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public readonly string VehicleName = "Truck";

        public Truck()
        {
        }

        public Truck(int loadCapacity, Chassis chassis, Engine engine, 
            Transmission transmission, string name) : base(chassis, engine, transmission, name)
        {
            if (loadCapacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(loadCapacity), $"{loadCapacity} can't be less then 0");
            }

            LoadCapacity = loadCapacity;
        }

        public override void Print()
        {
            Console.WriteLine($"Load capacity: {LoadCapacity} \n");
        }
    }
}
