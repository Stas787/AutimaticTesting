using System;
using AutoPark.Transport;
using System.Collections.Generic;
using AutoPark.Aggregate;

namespace AutoPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chassis busChassis = new Chassis(6, 345, 6000);
            Engine busEngine = new Engine(350, "diesel", 4.0, 3124555);
            Transmission busTransmission = new Transmission("mechanic", "German", 5);
            Chassis carChassis = new Chassis(4, 3445, 1000);
            Engine carEngine = new Engine(110, "gazoline", 1.6, 213213213);
            Transmission carTransmission = new Transmission("automatic", "german", 5);
            Chassis scooterChassis = new Chassis(2, 234122, 120);
            Engine scooterEngine = new Engine(50, "gazoline", 0.8, 321135);
            Transmission scooterTransmission = new Transmission("-", "japanese", 3);
            Chassis truckChassis = new Chassis(12, 1145, 9000);
            Engine truckEngine = new Engine(400, "diesel", 8.0, 2312344);
            Transmission truckTransmission = new Transmission("mechanic", "american", 8);

            var bus = new Bus(200, busChassis, busEngine, busTransmission, "Bus");
            var car = new Car("Volkswagen", carChassis, carEngine, carTransmission, "Car");
            var scooter = new Scooter(65, scooterChassis, scooterEngine, scooterTransmission, "Scooter");
            var truck = new Truck(8000, truckChassis, truckEngine, truckTransmission, "Truck");
            List<Vehicle> vehicles = new List<Vehicle> { bus, car, scooter, truck };

            foreach (var item in vehicles)
            {
                Console.WriteLine(item);
                item.Print();
            }
        }
    }
}
