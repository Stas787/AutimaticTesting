using AutoPark.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    [Serializable]
    public class Car : Vehicle
    {
        public string Company { get; set; }

        public new readonly string Name = "Car";

        public Car()
        {
        }

        public Car (string company, Chassis chassis, Engine engine, 
            Transmission transmission, string name) : base (chassis, engine, transmission, name)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"Company: {Company} \n");
        }
    }
}
