using System;
using AutoPark.Transport;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Xml;
using AutoPark.Aggregates;

namespace AutoPark
{
    public class Program
    {
        public static void Main(string[] args)
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
            var vehicle = new List<Vehicle> {bus, car, scooter, truck };

            EngineVolumeXml(vehicle, "EngineVolume.xml");
            TypeSerialNumberPower(vehicle);
            TransmissionType(vehicle);
        }

        /// <summary>
        /// If engine volume is more then 1.5 - Create and write collection into xml.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="engineVolume"></param>
        private static void EngineVolumeXml (List<Vehicle> vehicle, string engineVolume)
        {
            Vehicles vehicleList = new Vehicles();

            foreach (var item in vehicle)
            {
                if (item.Engine.Volume > 1.5)
                {
                    vehicleList.VehicleList.Add(item);
                }
            }

            SerialisationXML(vehicleList, engineVolume);
        }

        /// <summary>
        /// Method chooses truck and bus vehicles and write iformation about engines in xml file 
        /// </summary>
        /// <param name="vehicle"></param>
        private static void TypeSerialNumberPower (List<Vehicle> vehicle)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            XmlWriter xmlWriter = XmlWriter.Create("TypeSerialNumberPower.xml", settings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Engines"); 

            foreach (var item in vehicle)
            {
                xmlWriter.WriteStartElement(item.Name);
                xmlWriter.WriteAttributeString("Type", item.Engine.Type);
                xmlWriter.WriteAttributeString("SerialNumber", item.Engine.SerialNumber.ToString());
                xmlWriter.WriteAttributeString("Power", item.Engine.Power.ToString());
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        /// <summary>
        /// Sort vehicles: groups information according to trasmission type
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="transmissionType"></param>
        private static void TransmissionType(List<Vehicle> vehicle)
        {
            Vehicles vehicles = new Vehicles();
            var sorted = vehicle.OrderBy(item => item.Transmission.Type);

            foreach (Vehicle item in sorted)
            {
                vehicles.VehicleList.Add(item);
            }

            SerialisationXML(vehicles, "TransmissionType.xml");
        }
        
        /// <summary>
        /// Performs seriliszation and record information using filestream
        /// </summary>
        /// <param name="vehicles"></param>
        /// <param name="xmlName"></param>
        private static void SerialisationXML(Vehicles vehicles, string xmlName)//Xml serializer должен быть в методах, using оставляем
        {
            XmlSerializer xml = new XmlSerializer(typeof(Vehicles));
            using FileStream fileStream = new FileStream(xmlName, FileMode.OpenOrCreate);
            xml.Serialize(fileStream, vehicles);
        }
    }
}
