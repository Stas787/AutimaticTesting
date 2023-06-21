using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using AutoPark.Aggregates;

namespace AutoPark.Transport
{
    [Serializable]
    [XmlInclude(typeof(Bus)), XmlInclude(typeof(Car)),
        XmlInclude(typeof(Scooter)), XmlInclude(typeof(Truck))]
    public class Vehicle
    {
        public Chassis Chassis { get; set; }

        public Engine Engine { get; set; }

        public Transmission Transmission { get; set; }

        public string Name { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(Chassis chassis, Engine engine, Transmission transmission, string name)
        {
            Chassis = chassis;
            Engine = engine;
            Transmission = transmission;
            Name = name;
        }

        /// <summary>
        /// Write additional information
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"{Chassis} \n {Engine}  \n {Transmission}";
        }
    }

    [Serializable]
    public class Vehicles
    {
        public Vehicles() { }

        public List<Vehicle> VehicleList { get; set; } = new List<Vehicle>();
    }
}
