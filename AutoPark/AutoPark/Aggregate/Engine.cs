using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Aggregate
{
    internal class Engine
    {
        public int Power { get; set; }

        public string Type { get; set; }

        public double Volume { get; set; }

        public int SerialNumber { get; set; }

        public Engine(int power, string type, double volume, int serialNumber)
        {
            if (power < 0 || power > 2000)
            {
                throw new ArgumentOutOfRangeException(nameof(power), $"{power} is not correct");
            }

            if (volume < 0 || volume > 30)
            {
                throw new ArgumentOutOfRangeException(nameof(volume), $"{volume} is not correct");
            }

            Power = power;
            Type = type;
            Volume = volume;
            SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return $"Engine: power - {Power}, Type - {Type}, volume - {Volume}, serial number - {SerialNumber}";
        }
    }
}
