using AutoPark.Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    internal class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public new readonly string Name = "Truck";

        public Truck (int loadCapacity, Chassis chassis, 
            Engine engine, Transmission transmission, 
            string name) : base(chassis, engine, transmission, name)
        {
            if (LoadCapacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(loadCapacity), $"{loadCapacity} can't be less then 0");
            }

            LoadCapacity = loadCapacity;
        }

        public override void Print()
        {
            Console.WriteLine($"Load capacity: {LoadCapacity}  \n");
        }
    }
}
