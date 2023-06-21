using System;
using System.Collections.Generic;
using System.Text;
using AutoPark.Aggregate;

namespace AutoPark.Transport
{
    internal class Vehicle
    {
        public Chassis Chassis { get; set; }

        public Engine Engine { get; set; }

        public Transmission Transmission { get; set; }

        public string Name { get; set; }

        public Vehicle(Chassis chassis, Engine engine, Transmission transmission, string name)
        {
            Chassis = chassis;
            Engine = engine;
            Transmission = transmission;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} : \n {Chassis.ToString()} \n {Engine.ToString()} \n {Transmission.ToString()}";
        }

        /// <summary>
        /// Write additional information  
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
