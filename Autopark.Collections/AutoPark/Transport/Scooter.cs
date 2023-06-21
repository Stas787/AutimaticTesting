using AutoPark.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    [Serializable]
    public class Scooter : Vehicle
    {
        public int MaximumSpeed { get; set; }

        public new readonly string Name = "Scooter";

        public Scooter()
        {
        }
        
        public Scooter (int maximumSpeed, Chassis chassis, Engine engine, 
            Transmission transmission, string name) : base (chassis, engine, transmission, name)
        {
            if (maximumSpeed < 0 || maximumSpeed > 300)
            {
                throw new ArgumentOutOfRangeException(nameof(maximumSpeed), $"{maximumSpeed} is not correct");
            }

            MaximumSpeed = maximumSpeed;
        }

        public override void Print()
        {
            Console.WriteLine($"Maximun speed: {MaximumSpeed} \n");
        }
    }
}
