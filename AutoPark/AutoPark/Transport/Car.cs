using AutoPark.Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    internal class Car : Vehicle
    {
        public string Company;

        public new readonly string Name = "Car";

        public Car (string company, Chassis chassis, 
            Engine engine, Transmission transmission, 
            string name) : base (chassis, engine, transmission, name)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"Company: {Company} \n");
        }
    }
}
