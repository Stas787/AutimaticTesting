using AutoPark.Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    internal class Bus : Vehicle
    {
        public int NumberOfPassengers { get; set; }

        public new readonly string Name = "Bus";

        public Bus (int numberOfPassengers, Chassis chassis, 
            Engine engine, Transmission transmission, 
            string name) : base (chassis, engine, transmission, name)
        {
            if (numberOfPassengers < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfPassengers), $"{numberOfPassengers} can't be less then 0");
            }

            NumberOfPassengers = numberOfPassengers;
        }

        public override void Print()
        {
            Console.WriteLine($"Number of passengers: {NumberOfPassengers} \n");
        }
    }
}
